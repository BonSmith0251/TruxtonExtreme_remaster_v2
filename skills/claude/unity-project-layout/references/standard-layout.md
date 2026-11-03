# The standard Unity game project layout

Unity has no enforced layout; this is the convention most teams, templates and asset-store guides converge on. Pick the parts the project needs — empty folders are noise.

```
Assets/
  Scenes/                 *.unity (sub-folders by area: Levels/, Menus/, Test/)
  Scripts/
    Runtime/              game code, sub-folders by feature (Player/, Enemies/, UI/ ...)
    Editor/               editor-only code (an Editor folder: compiled into the editor assembly only)
  Prefabs/                *.prefab, by feature
  Materials/              *.mat, *.physicMaterial, *.physicsMaterial2D
  Textures/               *.png *.tga *.jpg *.psd *.exr *.hdr (UI/ for sprites and UI art)
  Models/                 *.fbx *.obj *.blend, mesh *.asset
  Animations/             *.anim *.controller *.overrideController *.mask *.playable (Timelines)
  Audio/                  Music/, SFX/ (*.wav *.ogg *.mp3) - unless the game loads it by name (then Resources/)
  Shaders/                *.shader *.shadergraph *.hlsl *.cginc *.compute *.shadersubgraph
  VFX/                    *.vfx, particle prefabs
  Fonts/                  *.ttf *.otf, TMP font assets
  Settings/               render pipeline assets, renderers, volume profiles, input actions, quality presets
  Data/                   ScriptableObject instances, *.json/*.csv/*.txt game data read as TextAssets
  Resources/              ONLY what code loads with Resources.Load (by path inside Resources)
  StreamingAssets/        files read from disk at runtime (videos, raw data); copied verbatim to builds
  Plugins/                native/managed plugins (DLLs, .so, .bundle); C# here compiles first (firstpass)
  ThirdParty/             asset-store / vendor packages, kept whole (or their own top-level folder)
```

Some teams nest the project's own content under `Assets/_Project/` (or `_Game/`) so it sorts first and stays apart from imported packages; offer it when the project has many third-party folders.

## Folders Unity treats specially

| Name | Where | What Unity does | Moving it |
| --- | --- | --- | --- |
| `Editor` | any depth | scripts compile into the editor assembly, excluded from builds | keep the name; `Scripts/Editor` is fine |
| `Resources` | any depth | contents included in builds; `Resources.Load("a/b")` looks inside *every* Resources folder | keep each Resources folder's inner paths; the folder can move, its contents' relative paths cannot (or code breaks) |
| `StreamingAssets` | only `Assets/StreamingAssets` | copied as plain files; `Application.streamingAssetsPath` | don't move |
| `Plugins` | top level (and `Plugins/<platform>`) | C# compiles into `-firstpass` before other scripts; native plugin import | keep at the top; moving C# out changes compile order |
| `Editor Default Resources` | top level | `EditorGUIUtility.Load` | don't move |
| `Gizmos` | top level | `Gizmos.DrawIcon` icons | don't move |
| `AddressableAssetsData` | top level by default | Addressables settings and groups | leave unless you change the settings' location in Addressables |
| `WebGLTemplates` | top level | WebGL player templates | don't move |
| `Standard Assets` | top level | legacy firstpass compile | leave |
| `TextMesh Pro` | wherever TMP was imported | TMP settings are found by path in `TMP Settings` | leave, or update TMP Settings |
| Hidden: names starting with `.` or ending with `~`, `cvs`, `*.tmp` | any | ignored by the asset database | — |

Assembly definitions (`.asmdef`) group scripts by folder: moving a script into a folder owned by a different asmdef changes which assembly it compiles into, and can break references between assemblies. Survey asmdefs first and keep each one's scripts together.

## Sorting by extension

| Extensions | Folder |
| --- | --- |
| `.unity` | Scenes |
| `.cs` (non-editor) | Scripts/Runtime |
| `.cs` under an Editor folder, or using `UnityEditor` without `#if UNITY_EDITOR` | Scripts/Editor |
| `.prefab` | Prefabs |
| `.mat .physicMaterial .physicsMaterial2D` | Materials |
| `.png .tga .jpg .jpeg .psd .exr .hdr .tif .bmp .gif` | Textures (sprites/atlases for UI: Textures/UI) |
| `.fbx .obj .blend .dae .3ds .max`, mesh `.asset` | Models |
| `.anim .controller .overrideController .mask .playable` | Animations |
| `.wav .ogg .mp3 .aif .flac` | Audio |
| `.shader .shadergraph .shadersubgraph .hlsl .cginc .compute` | Shaders |
| `.ttf .otf`, TMP font `.asset` | Fonts |
| render pipeline / renderer / volume profile / input actions `.asset` | Settings |
| other ScriptableObject `.asset`, `.json .csv .txt .bytes .xml` | Data |
| `.mp4 .webm .mov` | StreamingAssets if played by URL, else Video/ |
| `.dll .so .bundle .aar .jar` | Plugins |

Things that look like one type but belong with another: a `.json` that code loads with `Resources.Load` stays in Resources; a material that is a sub-asset of a model stays with the model; `.asset` files need a look at their `m_Script` or type (mesh, pipeline, ScriptableObject) before sorting.

## What survives a move and what does not

Survives (because MoveAsset keeps the `.meta` GUID): every serialized reference in scenes, prefabs, materials, ScriptableObjects; Build Settings entries (by GUID — paths are refreshed); Addressables entries (by GUID); `[SerializeField]` asset fields; `Shader.Find` (by shader name); `Resources.Load` as long as the path inside Resources is unchanged.

Does not survive: string paths in code (`AssetDatabase.LoadAssetAtPath`, `FindAssets(..., new[]{folder})`, `EditorSceneManager.OpenScene`), shader `#include "Assets/..."` absolute includes, tools and CI scripts outside Unity, path fields stored in JSON/YAML data written by your own tools, docs, `[MenuItem]`-driven generators that create folders, and tests that classify assets by folder name (`StartsWith("Assets/Imported/")`).
