# Decrypting obfuscated Unity content

`decrypt.py` handles the common cases automatically and validates every result by
parsing it with UnityPy. When it reports `FAIL`, find the game's loader and write a plugin.

## What the automatic strategies cover

| pattern | how it's detected | recorded transform |
|---|---|---|
| junk prefix / suffix around a normal bundle | `UnityFS\0` found at offset > 0; header size field gives the end | `carve` (offset, suffix) |
| repeating-key XOR, any offset <= 1024, key <= 24 bytes | known plaintext: `UnityFS\0` + format version + `5.x.x\0` + engine version from the survey | `xor` (key hex, offset) |
| explicit key | `--key HEX --offset N` | `xor` |
| anything else | `--plugin my.py` | `plugin` (path) |

The transform is stored in `decrypt_report.json` and reused by `make_project.py` to
re-obfuscate repacked bundles, so a plugin should implement both directions.

## Plugin template

```python
# my_decrypt.py
from pathlib import Path

KEY = bytes.fromhex("...")

def decrypt(path: Path, data: bytes) -> bytes | None:
    """Return a plain UnityFS bundle, or None if this file isn't ours."""
    if not path.name.endswith(".bundle"):
        return None
    ...

def encrypt(path: Path, plain: bytes) -> bytes:
    """Inverse of decrypt(); used when repacking rebuilt bundles."""
    ...
```
Run: `decrypt.py <work> --plugin my_decrypt.py`. Keep plugins in the work dir, not in the
game folder.

## Finding the scheme

1. **Look at the bytes.** `survey.json` gives the entropy per file. Near 8.0 means real
   encryption or compression; around 5-7 means XOR with a short key or a simple
   substitution. Compare the first 64 bytes of several files: identical prefixes are a
   custom header; a repeating period in `data[i] ^ b"UnityFS\0..."[i]` is an XOR key.
2. **Mono builds**: the loader is in `Managed/Assembly-CSharp.dll` (or another game DLL).
   Search its strings and methods for `LoadFromMemory`, `LoadFromStream`, `LoadFromFile`
   with an offset argument, custom `Stream` subclasses (override of `Read`), and
   `Aes`/`Rijndael`/`DES`/`RC4`/`xor`. Key literals are usually in the `#US` heap. dnfile
   can list user strings: `dnfile.dnPE(path).net.user_strings`.
3. **IL2CPP builds**: run Il2CppDumper or Cpp2IL on `GameAssembly.dll` +
   `global-metadata.dat` (download them from their official GitHub releases, with the user's
   OK) to get `dump.cs` and `script.json`. Find classes deriving from `Stream`, and callers of
   `AssetBundle.LoadFromStream` / `LoadFromMemory`. Then read the native function in a
   disassembler, using `script.json` for names. Keys are often static byte arrays initialised
   from `<PrivateImplementationDetails>` blobs in the metadata.
4. **Addressables**: `catalog.json` / `catalog.bin` may name a custom
   `IResourceProvider`. That class is the loader.
5. **UnityFS header flag `UsesAssetBundleEncryption`** (UnityCN / China builds): UnityPy
   supports it via `UnityPy.set_assetbundle_decrypt_key(key)`. The key lives in the game
   binary.
6. **global-metadata.dat magic mismatch** (survey flags it): the metadata itself is
   encrypted and decrypted at runtime by `GameAssembly.dll`/`UnityPlayer.dll`. Static
   recovery means reversing that routine. Runtime dumping is the usual alternative, but only
   on a machine and build the user controls. Stubs can still be generated if script data
   bundles carry type trees.

## Validation

A candidate is accepted only if UnityPy parses it and finds objects. If a plugin returns
bytes that fail validation, `decrypt.py` keeps trying the other strategies and finally
reports `FAIL`, so a broken plugin can't slip half-decrypted data into the pipeline.
