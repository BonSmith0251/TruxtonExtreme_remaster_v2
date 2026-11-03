# Script recovery

## Mono builds (`<Game>_Data/Managed/*.dll`)

Default **plugin mode**: the game's own assemblies go to `Assets/Plugins/Recovered/`, so the
rebuilt project runs the original compiled logic. Rules applied by `scripts_recover.py`:

- Only assemblies that define used scripts, plus their non-Unity dependencies (from the PE
  AssemblyRef table), are copied. `UnityEngine.*`, `Unity.*` and `System.*` come from the
  editor and packages; `make_project.py` maps known package assemblies to package ids.
- `Assembly-CSharp` / `Assembly-CSharp-firstpass` are renamed to `Original-CSharp*` by
  overwriting the identity strings in the metadata `#Strings` heap (same length, shared
  suffix preserved). Without this Unity either refuses to load the DLL (identity clash with
  its own Assembly-CSharp) or creates no MonoScripts for it, and every component goes missing.
- Consequence: anything that names the old assembly at runtime breaks. That includes
  original asset bundles (handled by repacking) and code such as
  `Type.GetType("Foo, Assembly-CSharp")`. Grep the DLL's user strings for `Assembly-CSharp`
  if a type lookup fails at runtime.

For **editable source**, decompile the same DLLs with ILSpy (`ilspycmd -p -o <dir> <dll>`),
put the sources under `Assets/Scripts/`, delete the plugin, and re-run `make_project.py
--force`. Script types resolve by namespace and class name, so the rebuild re-binds to the
sources automatically. Expect a round of compile fixes: compiler-generated names, `unsafe`,
and missing `#if` platform code.

Decompiling without a .NET SDK, and checking the result (proven on Top Heroes, ilspycmd 8.2.0.7535):
- `ilspycmd` is a dotnet-tool nupkg. Download it from `api.nuget.org/v3-flatcontainer/ilspycmd/<ver>/`, check its
  sha512 against the catalog `packageHash`, unzip it and run `dotnet tools/<tfm>/any/ilspycmd.dll`. That needs only
  the matching runtime; 8.2 targets net6.0.
- Compile check with no SDK: run the editor's `Data/NetCoreRuntime/dotnet.exe Data/DotNetSdkRoslyn/csc.dll` with
  `-noconfig -nostdlib+` and `-r:` on the game's own DLLs, including its mscorlib. Then compare TypeDef/MethodDef
  sets of the original and recompiled DLLs (dnfile).
- Use `-lv CSharp7_3` for old Mono profiles. At 9.0 ilspycmd deconstructs tuples, which needs `Deconstruct` that a
  2019-era mscorlib lacks. Compile the output as C# 9 all the same: 7.3 output still contains C# 8/9 patterns.
- ilspycmd writes `x is (A, B) t` for a ValueTuple type test. C# 9 parses that as a positional pattern
  (CS8129 "Deconstruct on object"), so rewrite it to `System.ValueTuple<A, B>`. `.csproj` HintPaths come out
  relative to the working directory, not to the project.
- Rare logic losses show up as compile errors, e.g. an unassigned local where a `dup`'d IL value fed a dropped
  call. Fix them from `ilspycmd -il` output, never by guessing. `-t` doesn't narrow `-il` output, so dump to a file.

## IL2CPP builds (`GameAssembly.dll` + `global-metadata.dat`)

C# method bodies are compiled to native code and can't be turned back into source
automatically. **Stub mode** generates one file per script class with its serialized fields,
derived from the same type trees the extractor uses (TypeTreeGeneratorAPI reads the IL2CPP
metadata directly). This preserves:

- every MonoBehaviour / ScriptableObject in scenes, prefabs and assets, with all values and
  object references,
- nested `[Serializable]` classes, arrays, and Unity value types.

Lost: methods, properties, events, enum names (enums become `int`), `byte` vs `bool`
distinctions (`UInt8` maps to `bool`), and non-serialized state. Generic base classes are
flattened.

**Inheritance.** Type trees carry fields, not base classes. Without base types every stub is a
bare MonoBehaviour, so a `UIText : TextMeshProUGUI` renders nothing and a `UINullImage : Graphic`
can't be assigned to a `Graphic` field (the rebuild logs those as `type mismatch`). Generate
signature DLLs first (Cpp2IL `--output-as dummydll --output-to <work>/cpp2il/DummyDll`, or
Il2CppDumper's `DummyDll/`). `scripts_recover.py` reads them by default from
`<work>/cpp2il/DummyDll` or from `--signatures`. Then:
- stubs derive from stubbed game classes, including unused intermediate ancestors
  (`SkeletonAnimation : SkeletonRenderer`), or from the safe uGUI/TMP bases in `SAFE_BASES`,
  and drop the fields the base already declares;
- abstract engine bases listed in `ABSTRACT_OVERRIDES` (URP `ScriptableRendererFeature`) get
  empty overrides.

Games often ship **modified packages**, for example custom renderer features compiled into
`Unity.RenderPipelines.Universal.Runtime`. After a first `make_project`, re-run with
`--project <project>`. Used `Unity.*` scripts that the project's `Library/PackageCache` doesn't
declare are then stubbed too.

Reference fields only name types that will exist. A script class that gets no stub becomes
`UnityEngine.Object`, which still holds the reference. This includes a short name shared with an
engine type, e.g. a game class `Jelly2D.Sprite`. Flattened engine structs (`Navigation`,
`ColorBlock`, ...) and UnityEvent subclasses bind to the real Unity types. Other helper types
are nested inside their stub class.

**Android IL2CPP.** `libil2cpp.so` + `assets/bin/Data/Managed/Metadata/global-metadata.dat`
work like `GameAssembly.dll` + `il2cpp_data/Metadata`. Stage the APK as `<work>/game/` with the
library copied to `GameAssembly.dll` and the metadata under `<X>_Data/il2cpp_data/Metadata/`.
Join `*.splitN` files. Android ships no `ScriptingAssemblies.json`, so `make_project.py`
builds the package manifest from the IL2CPP assembly list.

To re-implement logic, use Il2CppDumper (`dump.cs`, plus `DummyDll/` with signatures) or
Cpp2IL (it can emit pseudo-C# / ISIL) for method signatures and call graphs. Then read the
native code in Ghidra or IDA with the generated `script.json` / `il2cpp.h` applied. Rewrite
the logic class by class into the stubs, keeping field names unchanged so data stays bound.

## Package-provided scripts

Components from Unity packages (uGUI `Image`/`Text`/`Button`, TextMeshPro, Cinemachine,
Input System, ...) resolve by full type name to the package versions installed in the new
project. If `missingScripts` lists `UnityEngine.UI.*` or `TMPro.*`, the package is missing
from `Packages/manifest.json`. Add it and re-run.
