"""Read-only asset inventory for this Unity 6000.3 game; writes reports only.

Requires UnityPy (validated with 1.25.4). Bundle scanning decompresses only
blocks covering serialized files, skipping bulk .resS/.resource payloads.
This is an analysis tool, not a Unity project exporter or catalog decoder.
"""
import argparse
import csv
import gc
import io
import json
import struct
from collections import Counter
from pathlib import Path

import UnityPy
from UnityPy.helpers.CompressionHelper import DECOMPRESSION_MAP


def unpack(stream, fmt):
    return struct.unpack(fmt, stream.read(struct.calcsize(fmt)))


def cstring(stream):
    data = bytearray()
    while True:
        c = stream.read(1)
        if not c:
            raise EOFError('Unterminated bundle string')
        if c == b'\0':
            return data.decode('utf-8')
        data.extend(c)


def decompress(data, size, flags):
    result = DECOMPRESSION_MAP[flags & 63](data, size)
    if len(result) != size:
        raise ValueError('Decompressed size mismatch')
    return result


def bundle_metadata(path):
    """Read this build's standard UnityFS v8 directory and serialized nodes."""
    with path.open('rb') as f:
        prefix = f.read(8)
        if prefix != b'UnityFS\0':
            raise ValueError('Non-UnityFS header: ' + prefix.hex() + '; custom wrapper/encoding not decoded')
        f.seek(0)
        signature = cstring(f)
        version, = unpack(f, '>I')
        player, engine = cstring(f), cstring(f)
        size, compressed, raw, flags = unpack(f, '>QIII')
        if signature != 'UnityFS' or version != 8 or flags & 0x400:
            raise ValueError('Unsupported bundle format or encryption flag')
        if size != path.stat().st_size:
            raise ValueError('Bundle size does not match header')
        f.seek((f.tell() + 15) & ~15)
        data_start = f.tell()
        if flags & 0x80:
            f.seek(size - compressed)
        info = io.BytesIO(decompress(f.read(compressed), raw, flags))
        if not flags & 0x80:
            data_start = f.tell()
        if flags & 0x200:
            data_start = (data_start + 15) & ~15
        info.read(16)
        block_count, = unpack(info, '>I')
        blocks = [unpack(info, '>IIH') for _ in range(block_count)]
        node_count, = unpack(info, '>I')
        nodes = []
        for _ in range(node_count):
            offset, length, node_flags = unpack(info, '>QQI')
            nodes.append(dict(name=cstring(info), offset=offset, size=length, flags=node_flags))
        selected = [n for n in nodes if n['flags'] & 4]
        buffers = {n['name']: bytearray(n['size']) for n in selected}
        compressed_offset, raw_offset = data_start, 0
        for raw_size, compressed_size, block_flags in blocks:
            overlaps = [n for n in selected if n['offset'] < raw_offset + raw_size
                        and n['offset'] + n['size'] > raw_offset]
            if overlaps:
                f.seek(compressed_offset)
                block = decompress(f.read(compressed_size), raw_size, block_flags)
                for node in overlaps:
                    start = max(node['offset'], raw_offset)
                    end = min(node['offset'] + node['size'], raw_offset + raw_size)
                    buffers[node['name']][start-node['offset']:end-node['offset']] = block[start-raw_offset:end-raw_offset]
            compressed_offset += compressed_size
            raw_offset += raw_size
        header = dict(signature=signature, format_version=version, engine=engine,
                      flags=flags, block_compression=dict(Counter(str(b[2] & 63) for b in blocks)),
                      uncompressed_bytes=raw_offset, nodes=nodes)
        return header, buffers


def scan_serialized(data, source, cab, output, record):
    env = UnityPy.load(data)
    counts = Counter()
    errors = []
    for asset in env.assets:
        asset_name = cab or asset.name
        record.setdefault('serialized_files', []).append(dict(
            name=asset_name, engine=asset.unity_version, type_tree=asset._enable_type_tree,
            externals=[x.path for x in asset.externals]))
        for obj in asset.objects.values():
            kind = obj.type.name
            counts[kind] += 1
            row = dict(source=source, serialized_file=asset_name, path_id=str(obj.path_id),
                       type=kind, bytes=obj.byte_size)
            try:
                row['name'] = obj.peek_name()
                if kind in ('Texture2D', 'AudioClip', 'Mesh', 'AnimationClip', 'MonoScript', 'MonoBehaviour', 'Material', 'Shader', 'AssetBundle', 'BuildSettings', 'GraphicsSettings'):
                    d = obj.read_typetree()
                    if kind == 'Texture2D':
                        row['details'] = {k: d.get(k) for k in ('m_Width','m_Height','m_TextureFormat','m_MipCount','m_ColorSpace','m_StreamData')}
                    elif kind == 'AudioClip':
                        row['details'] = {k: d.get(k) for k in ('m_Channels','m_Frequency','m_Length','m_CompressionFormat','m_Resource')}
                    elif kind == 'Mesh':
                        row['details'] = dict(vertices=d.get('m_VertexData',{}).get('m_VertexCount'), submeshes=len(d.get('m_SubMeshes',[])), bindposes=len(d.get('m_BindPose',[])), stream=d.get('m_StreamData'))
                    elif kind == 'AnimationClip':
                        row['details'] = {k: d.get(k) for k in ('m_Legacy','m_Compressed','m_SampleRate','m_WrapMode')}
                    elif kind == 'MonoScript':
                        row['details'] = {k: d.get(k) for k in ('m_ClassName','m_Namespace','m_AssemblyName')}
                    elif kind == 'MonoBehaviour':
                        row['details'] = dict(script=d.get('m_Script'), fields=list(d))
                    elif kind == 'Material':
                        row['details'] = dict(shader=d.get('m_Shader'), keywords=d.get('m_ValidKeywords'), properties=d.get('m_SavedProperties'))
                    elif kind == 'Shader':
                        row['name'] = d.get('m_ParsedForm',{}).get('m_Name') or row['name']
                    elif kind == 'AssetBundle':
                        record.setdefault('containers', []).extend(dict(name=k, file_id=v['asset']['m_FileID'], path_id=str(v['asset']['m_PathID']), serialized_file=asset_name) for k,v in d.get('m_Container',[]))
                    elif kind == 'BuildSettings':
                        row['details'] = {k: d.get(k) for k in ('scenes', 'm_Version', 'm_GraphicsAPIs')}
                    elif kind == 'GraphicsSettings':
                        row['details'] = d
            except Exception as exc:
                row['read_error'] = str(exc)[:300]
                errors.append(dict(type=kind, path_id=str(obj.path_id), error=str(exc)[:300]))
            output.write(json.dumps(row, ensure_ascii=True) + '\n')
    record.setdefault('counts', Counter()).update(counts)
    record.setdefault('read_errors', []).extend(errors)
    del env
    gc.collect()


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--root', type=Path, default=Path(__file__).resolve().parents[1])
    parser.add_argument('--out', type=Path, default=Path(__file__).resolve().parent)
    args = parser.parse_args()
    data = args.root / 'TATSUJIN EXTREME_Data'
    args.out.mkdir(parents=True, exist_ok=True)
    sources = sorted(data.rglob('*.bundle'))
    sources += sorted(p for p in data.iterdir() if p.is_file() and (p.suffix == '.assets' or p.name in ('globalgamemanagers','level0','level1')))
    sources += sorted((data / 'Resources').iterdir())
    records = []
    with (args.out / 'objects.jsonl').open('w', encoding='utf-8') as output:
        for index, path in enumerate(sources, 1):
            source = path.relative_to(args.root).as_posix()
            record = dict(source=source, bytes=path.stat().st_size)
            try:
                if path.suffix == '.bundle':
                    record['header'], buffers = bundle_metadata(path)
                    for cab, buffer in buffers.items():
                        scan_serialized(bytes(buffer), source, cab, output, record)
                    del buffers
                else:
                    scan_serialized(str(path), source, path.name, output, record)
            except Exception as exc:
                record['error'] = repr(exc)
            records.append(record)
            print(f'{index}/{len(sources)} {path.name}: {sum(record.get("counts",{}).values())} objects; {len(record.get("read_errors",[]))} read errors; {record.get("error", "")}', flush=True)
    totals = Counter()
    for record in records:
        totals.update(record.get('counts',{}))
    report = dict(unitypy_version=UnityPy.__version__, counts=dict(totals), sources=records)
    (args.out / 'inventory.json').write_text(json.dumps(report, indent=2), encoding='utf-8')
    with (args.out / 'bundle_summary.csv').open('w', newline='', encoding='utf-8') as f:
        writer = csv.writer(f)
        types = ['GameObject','Mesh','Texture2D','Material','AnimationClip','AudioClip','MonoBehaviour','ParticleSystem']
        writer.writerow(['source','bytes','objects','read_errors']+types)
        for r in records:
            writer.writerow([r['source'],r['bytes'],sum(r.get('counts',{}).values()),len(r.get('read_errors',[]))]+[r.get('counts',{}).get(t,0) for t in types])
    print('TOTALS', json.dumps(dict(totals)), flush=True)


if __name__ == '__main__':
    main()
