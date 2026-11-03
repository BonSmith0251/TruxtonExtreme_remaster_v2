# Discovery and extraction

For APK, split-package, AAB or OBB inputs, read [Android APK reconstruction](android-apk.md) before export. It covers package completeness, engine identification, safe staging, Android code/plugin recovery and device validation.

## Build boundary

Inventory every supplied installation/content root. Desktop builds commonly have a player plus `*_Data`; macOS uses an application bundle. Android can split content across APKs, OBBs, and asset packs; iOS content can be inside an IPA; WebGL can have compressed data, framework, and WASM files. Unpack archives into staging with traversal checks. An absent companion file does not prove content never existed.

Record engine version from parsed serialized headers, player metadata, or logs, retaining conflicting evidence. Determine CPU architecture from executable headers, not the host OS. Identify rendering pipeline from assets, assemblies, and settings. Assembly filenames are clues rather than proof of package versions.

Mono candidates have game assemblies with actual IL and a Mono runtime. IL2CPP candidates have matching native code (`GameAssembly.dll`, `libil2cpp.so`, an executable/framework, or WASM) and metadata, often `global-metadata.dat`. A `Managed` directory alone does not prove Mono. Classify multiple installations independently.

Include `globalgamemanagers`, `globalgamemanagers.assets`, `mainData`, `level*`, shared/resources assets, built-in resources, bundles with arbitrary extensions, `StreamingAssets`, `.resS`/`.resource` streams, Addressables catalogs/settings/hash files, localization, audio banks, video, native libraries, custom archives, DLC, and loose data. Preserve unrecognized files. Distinguish installed coverage from catalog coverage; report missing remote dependencies without claiming they were extracted.

## File inventory helper

```powershell
python '<skill-dir>\scripts\inventory_build.py' --root 'D:\Games\Example' --out 'D:\Recovery\Example\evidence\files.json' --sha256
```

Use `--exclude` repeatedly for generated directories under the input root, using absolute or root-relative paths. Choose a new `--out` path for each run; existing reports are never overwritten. The standard-library helper skips symlinks/reparse points, reports unreadable files, and exits 2 for incomplete reads. It excludes its own output file, but not other reports/exports. Selected header samples provide unconfirmed version hints. Without `--sha256` it does not provide content fingerprints. It does not parse Unity objects, inspect assemblies, decompress archives, download tools, or execute the game.

## Tools

Inspect existing tools before installing anything. Use official distributions and an isolated environment. Record versions, commands, configuration, source fingerprints, and outputs. Check actual help/UI/API rather than inventing flags.

| Job | Candidate | Selection criterion |
| --- | --- | --- |
| Project export | AssetRipper | Check version support, edition/features, script output and errors on this build. |
| Object inventory, type trees, targeted extraction | UnityPy or a maintained equivalent | Pin the working version; APIs/schema support change. Retain unparsed objects. |
| Managed C# recovery | ILSpy / ilspycmd | Supply all assembly references; inspect decompilation failures. |
| IL2CPP analysis | Cpp2IL; metadata tools/native disassemblers as needed | Verify metadata-version, architecture and output-mode support. |
| Import and validation | Matching Unity Editor | Confirm assets really import and scenes load. |

Primary sources checked during skill creation on 2026-10-30; recheck the chosen release when used:

- [AssetRipper](https://github.com/AssetRipper/AssetRipper) describes native Unity format conversion and version-dependent support.
- [UnityPy](https://github.com/K0lb3/UnityPy) documents object/type-tree access and API changes between minor versions.
- [ILSpy](https://github.com/icsharpcode/ILSpy) documents managed decompilation and the command-line frontend.
- [Cpp2IL development documentation](https://github.com/SamboyCoding/Cpp2IL/blob/development/README.md) describes processing/output modes. Development documentation can differ from release binaries.

## Extraction

Load dependencies together where supported. Retain a pristine export and repair a working copy. Prefer native Unity representations; PNG/OBJ/WAV previews alone discard important structure. Record every object's source identity, type, aliases, dependencies, raw representation, decoded outputs, import mapping, and outcome. Walk all serialized objects, not just container-name entries or objects reachable from the first scene.

Resolve resource streams by original path, offset, and size. A texture object with unreadable stream bytes is not an extracted texture. Preserve compressed payloads even when decoding fails. Never silently substitute thumbnails/lower mips for full textures.

For pointers, `m_PathID == 0` is null; `m_FileID == 0` addresses the current serialized file; positive file IDs index its external table from one. Use external metadata and loaded files to disambiguate matching CAB basenames. Record ambiguous/dangling edges instead of guessing.

For custom formats or missing type trees, inspect headers, neighboring objects, managed field layouts, IL2CPP metadata, and loader code. Use version-correct decoders; retain raw bytes and offsets. Decoder failure does not mean an empty asset. For protected/unavailable payloads, record the concrete limitation and continue independent recovery.

Process large builds by container with checkpoints and bounded memory. Retry failures when new evidence suggests another decoder/version/configuration; avoid repeating unchanged failures. Never silently narrow whole-game scope to supported classes.

## Verify exporter configuration before loading

Some AssetRipper GUI releases lock configuration after loading a build. In a tested release, a settings POST after load returned without applying the requested unreadable-asset option. Configure before load, then verify the effective settings in the UI/API or saved configuration; a successful HTTP response alone is not evidence the option changed. Preserve unreadable/raw objects independently when the effective exporter mode omits them. Record collection counts separately from serialized-object counts.

An effective setting is still not proof of output. AssetRipper 2.0.0 Free accepted `ShaderExportMode=Decompile` and showed it as effective, yet all 76 exported shaders of a Unity 2022.3 IL2CPP Android build were `DummyShaderTextExporter` placeholders. Whether another edition or release honors the option was not tested. After the first export, inspect a sample of the files each consequential setting governs (shader text, script bodies, unreadable-asset output) and record requested, reported-effective and observed-in-output separately. Classify placeholders as stubs under [compiled shader recovery checks](scenes-and-engine-features.md#compiled-shader-recovery-checks), and do not re-export with the same edition and setting expecting a different result.

## Partial reads and custom bundle providers

A non-strict object read may return only the native header of a managed component. Record exact byte-consumption and field coverage independently of parser return status. In UnityPy 1.25.4 on a Unity 6000.3.7f1 IL2CPP build, `check_read=False` exposed MonoBehaviour names and script pointers while omitting custom serialized fields; strict reading revealed the unread bytes. Such a result can establish identity, but cannot establish recovered pipeline settings or component state. Preserve the bytes and obtain the matching managed layout before resaving that object.

When a supplied bundle lacks a Unity signature, inspect the game's custom resource-provider types and native byte-transform methods before classifying it as unsupported. A verified local case used a cyclic XOR transform before the standard UnityFS reader. Header-based transform candidates require independent validation of directory sizes, block decompression, serialized objects and resource ranges; a plausible magic string alone is insufficient. Keep game-specific derivation details and code in project evidence. A seekable transformed reader can recover selected nodes and stream ranges without writing a second whole-build copy; report metadata recovery separately from payload decoding and target import.

## Export completion and auxiliary mappings

Check exporter tail phases before terminating a large job. In AssetRipper 2.0.0, completing the native asset collection counter was followed by StreamingAssets copying; interrupting that phase left the later auxiliary source-to-export map unavailable. Configure unwanted media duplication before loading where supported, and retain required mapping/report outputs before declaring the export finished. If interrupted, separate completed asset output from missing auxiliary evidence. Alias or name-based mapping candidates do not replace an exact object map.

## Suspected autoplayer or instrumentation patches

A preserved starting SHA256 baseline proves no subsequent changes, not an unmodified installation. When a patch is suspected, inspect patch records and backups and compare against an available installer manifest; label local manifest checks separately from independently authenticated publisher evidence. Distinguish Frida runtime hooks or runtime invincibility calls from on-disk patches. Do not overwrite matching binaries merely because instrumentation once ran. Record process/controller state and restore only demonstrated changes with a backup. If source fingerprints still match, reuse validated assets and retry the affected recovery stage in isolated output. Placeholder IL emitted by a recovery writer remains a tool limitation even on installer-matching inputs.
