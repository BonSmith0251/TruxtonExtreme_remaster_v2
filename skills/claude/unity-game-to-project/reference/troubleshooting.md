# Troubleshooting the rebuild

Reports, in reading order: `<work>/extract/extract_report.json` ->
`<project>/RebuildData/rebuild_report.json` -> `rebuild.log` -> `smoke_report.md` ->
`smoke_player_rebuilt.log`.

| symptom | cause | fix |
|---|---|---|
| `Expected to read N bytes, but only read M` for MonoBehaviours | script type tree mismatch (wrong assembly, generic base, version drift) | check `make_typetree_generator` loaded the right DLLs / metadata; for IL2CPP confirm the metadata version is supported by TypeTreeGeneratorAPI |
| script fields shifted / `m_Script` pathIDs look like `x << 24` | missing alignment after `m_Enabled` in generated nodes | already patched in `ugp_common.make_typetree_generator`; re-check after upgrading UnityPy |
| settings `PlayerSettings` unreadable (warning) | built-in type tree for that version differs | harmless; product/company come from `app.info` |
| `compile errors` in `rebuild.log` | bad stub type mapping, or a package assembly not in the manifest | fix `scripts_recover.py` mapping or add the package; the build continues with `-ignoreCompilerErrors` but scripts won't bind |
| `missingScripts: ... could not be attached` | precompiled DLL produced no MonoScripts (reserved name, or Unity failed to load it) | look for "Assembly ... will not be loaded" in `rebuild.log` |
| `missingScripts: ... (script X @ Assembly-CSharp)` in stub mode | class not generated (no usage recorded) | `scripts_recover.py --mode stubs` writes only used classes; check `rebuild.json -> scripts` |
| `unresolvedReferences` key `file:pathID` | the target object wasn't exported (unsupported type) or lives in a bundle that wasn't loaded/decrypted | grep the key in `extract/reference/dumps`; add an exporter or decrypt the bundle |
| `(type mismatch: X)` in unresolved | a reference resolved to the wrong object kind (e.g. Texture2D where a Sprite is expected) | the sprite wasn't sliced from that texture; check `textures[...].sprites` |
| `builtinUnmapped` | runtime-only built-in resources (e.g. halo texture "Soft") | usually harmless |
| `OverflowException` in `unsupportedProperties` | uint value into int property | use `unchecked` conversion in `PropertyApplier.cs` |
| "The referenced script on this Behaviour is missing" at runtime | an ORIGINAL bundle still references the old script assembly | make sure the bundle was repacked (`repack_report.json`); Addressables need their catalog rebuilt |
| Unity replaced `Packages/manifest.json` with template packages | project opened without `ProjectSettings/` | `make_project.py` writes `ProjectVersion.txt` first; don't delete it |
| sprites render as whole textures | sprite rects came from atlas data | sprites with `settingsRaw & 1` (packed) are re-exported standalone; check `m_SpriteAtlas` |
| magenta materials | custom shader not available | write or port the shader; the decompiled dump is in `extract/reference/shaders/` |
| player runs but behaves differently | logic depends on things the rebuild doesn't recreate (animation, timeline, lightmaps) or on script execution order | check `extract_report.json -> unsupported`; set Script Execution Order to match the original |
| batch Unity hangs on first run | license prompt or package resolution | run the editor once interactively; check `rebuild.log` for "Licensing" |

## Large games

UnityPy loads lazily, but cross-references need everything in one environment. For
multi-GB games, run `extract.py` on a machine with enough RAM (roughly 1.5x the size of the
bundles being processed at once). Expect long first imports in Unity, so raise
`make_project.py --timeout`. Do a first pass with `--no-dumps` to save disk space.
