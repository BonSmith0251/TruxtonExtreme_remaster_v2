# Unity player build formats (what the parsers read)

```
<Game>.exe, UnityPlayer.dll
GameAssembly.dll                      IL2CPP native code (absent on Mono)
<Game>_Data/
  globalgamemanagers                  project settings objects + BuildSettings (scene list)
  globalgamemanagers.assets           MonoScripts, assets used by settings (splash, etc.)
  level0..N                           one SerializedFile per scene in build order
  sharedassets0..N.assets             assets referenced by scene N (prefabs live here as plain GameObjects)
  resources.assets                    everything under Resources/ (paths in ResourceManager.m_Container)
  *.resS / *.resource                 raw texture / audio / video data streamed from the files above
  data.unity3d                        all of the above packed into one UnityFS bundle (LZ4 build option)
  Managed/*.dll                       Mono: compiled C# (game + engine + packages)
  il2cpp_data/Metadata/global-metadata.dat   IL2CPP: type/method/string metadata
  ScriptingAssemblies.json            assembly list (used to infer packages)
  StreamingAssets/                    copied verbatim; AssetBundles, Addressables (aa/), videos, custom data
  Resources/unity default resources, unity_builtin_extra   engine built-ins
```

## SerializedFile

Big-endian header (`metadataSize, fileSize, version, dataOffset`; v22+ moves 64-bit values to
offset 20), followed by type info, an object table (`pathID -> type, offset, size`) and
externals (other files, referenced by `fileID - 1`). Player builds normally omit type trees.
UnityPy uses a bundled per-version database (TPK) for engine types. Script (MonoBehaviour)
data needs field layouts generated from the game's assemblies or IL2CPP metadata.

## UnityFS bundle

`"UnityFS\0"`, format version (u32 BE), `"5.x.x\0"`, engine version string, total size (i64),
compressed and uncompressed block-info sizes, flags. Block info (often LZ4/LZMA compressed)
lists data blocks and a directory of contained files (a `CAB-<hash>` SerializedFile plus
`.resS`). Compression in block flags: 0 none, 1 LZMA, 2 LZ4, 3 LZ4HC. The `AssetBundle`
object inside lists `m_Container` (lower-case original asset paths -> objects), which the
extractor reuses as project paths.

## References

`PPtr = {m_FileID, m_PathID}`. FileID 0 means the same file; otherwise
`externals[fileID-1]`. The pipeline normalises this to `"<file>:<pathID>"`, with `<file>`
lower-cased and `archive:/CAB-x/CAB-x` reduced to `cab-x`.

## Sprites

`m_Rect` is the sprite rectangle on its texture. `m_RD.textureRect` is the trimmed alpha
bounds, or the packed rectangle when `m_RD.settingsRaw & 1` (packed into a SpriteAtlas).
Bits 1 (tight) and 2-5 (rotation) describe packing. Unpacked sprites are re-sliced on their
texture with `m_Rect`. Packed ones are rendered standalone (UnityPy `Sprite.image` handles
tight meshes and rotation).

## Tags and layers

`GameObject.m_Tag` in builds is an index: 0 Untagged, 1 Respawn, 2 Finish, 3 EditorOnly,
5 MainCamera, 6 Player, 7 GameController, and 20000+i for `TagManager.tags[i]`.
