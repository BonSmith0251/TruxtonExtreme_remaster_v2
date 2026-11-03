# Android APK reconstruction

Use this branch for APKs, installed split packages, APKS archives, XAPK/APKM containers, AABs, and companion OBB or Play Asset Delivery content. The deliverable remains an editable Unity project, either recovered from Unity or rebuilt from Cocos when requested. Repacking an APK or decompiling its Java wrapper does not establish recovered gameplay.

## Establish package and engine evidence

Inventory archive members before choosing an exporter. Hash the original containers, preserve their bytes, and record each member's container, exact path, compressed/uncompressed size and CRC; CRC is not a cryptographic fingerprint. Inspect signatures and payloads rather than inferring engine, version or completeness from the filename or store listing.

- Parse the manifest with Android SDK `apkanalyzer` or an equivalent binary-XML reader. Record package ID, version code/name, split identifiers and dependencies, launcher/application classes, SDK levels, permissions and native-library settings. Binary `AndroidManifest.xml` is not ordinary text XML. Check installed help; typical read-only commands are `apkanalyzer apk summary <apk>` and `apkanalyzer manifest print <apk>`. See [APK Analyzer commands](https://developer.android.com/tools/apkanalyzer).
- Look for corroborating Unity evidence: parsable Unity serialized files/bundles, `assets/bin/Data/`, `lib/<abi>/libunity.so`, Unity player entry classes, and a matching Mono or IL2CPP runtime. Unity Ads or a mediation adapter alone does not identify the game's engine.
- If no Unity payload is found, inspect companion packages and entrypoint/loader evidence. A base APK can omit ABI libraries and delivered assets. Classify the result as confirmed Unity, incomplete/unknown engine, or evidence for another engine; absence in one APK is not proof of absence from the complete app.
- Cocos entry classes, `cocos2d-jsb` payloads, or JavaScript resource layouts warrant engine-specific investigation. When Unity is the explicit destination, continue through [Cocos-to-Unity reconstruction](cocos-to-unity.md) without asking the user to reconfirm that destination. Use this page's package inventory/staging and Android validation guidance, and skip its Unity-source/IL2CPP assumptions. If no cross-engine destination was requested, report the detected engine and clarify the intended deliverable while continuing useful inspection.

## Determine the full content boundary

| Input | Handling |
| --- | --- |
| Standalone APK | Inspect code and assets; check manifests/catalogs for external content even when the APK is installable. |
| Base APK plus splits | Inventory every supplied APK, including ABI, language, density and feature splits. Verify package/version compatibility and signing consistency where available; retain configuration variants separately. |
| `.apks` | Treat as an APK-set archive; retain its table of contents and targeting information. Inventory all members, then identify the device-compatible subset for runtime tests. |
| `.xapk` / `.apkm` | Inspect the actual ZIP layout and wrapper metadata; these are not interchangeable with bundletool APKS. Retain nested APKs and OBBs separately. |
| `.aab` | Inspect module manifests, assets and libraries. It is a publishing bundle, not an installable APK; use supported bundletool commands if a test APK set is needed. A universal APK alone does not establish coverage of every delivery module. |
| `.obb` / asset packs / downloaded content | Match to the package and content version using available evidence. Inspect format signatures before treating an OBB as ZIP. Record install-time, fast-follow and on-demand dependencies that are absent. |

For bundle structure and device targeting, consult [bundletool](https://developer.android.com/tools/bundletool). Unity can place later scenes and resources outside the base package; consult the source editor's [OBB documentation](https://docs.unity3d.com/2023.2/Documentation/Manual/android-OBBsupport.html) and [Play delivery documentation](https://docs.unity3d.com/2023.2/Documentation/Manual/android-distribution-google-play.html).

If an authorized connected device supplies the original install, `adb shell pm path <package>` can enumerate installed APK paths for copying with `adb pull`. This does not enumerate all OBBs, asset packs or private downloaded caches. Record inaccessible content explicitly. Do not mix arbitrary versions or call a base-only inventory whole-game coverage. Continue independent recovery while identifying exact missing inputs.

Unpack into a new directory per outer container and nested APK. Preflight member paths and resolved destinations: reject traversal, absolute/drive paths, links, Windows alternate streams and target-path collisions (including case collisions); bound expanded size before extraction. Never flatten or overwrite duplicate paths from different splits. Retain an archive-to-staged-path map, and include the outer package in serialized-object provenance. The existing `inventory_build.py` inventories directories only: run it on the staged roots; it neither opens an APK nor expands nested archives.

## Locate Unity payloads and recover code

Treat these as common locations, not required layouts:

| Evidence | Typical location or interpretation |
| --- | --- |
| Player data | `assets/bin/Data/`, sometimes with a nested `data.unity3d`; inspect both loose serialized files and inner containers. |
| Resource streams | `.resS` and `.resource` beside serialized data or inside bundles; resolve from the owning source, not a flattened directory. |
| IL2CPP code | `lib/<abi>/libil2cpp.so`, possibly in an ABI split. Confirm ELF architecture and retain each ABI independently. |
| IL2CPP metadata | Often `assets/bin/Data/Managed/Metadata/global-metadata.dat`; search all supplied modules/content if absent. |
| Mono code | Managed assemblies with actual IL and matching Mono runtime libraries. A `Managed` directory alone is insufficient. |
| Streaming assets | APK `assets/` includes StreamingAssets payloads and other Android/Unity data; do not copy the entire tree blindly into `Assets/StreamingAssets`. Recover placement from loader paths and catalog evidence. |
| Android wrapper/plugins | `classes*.dex`, manifest/resources and native libraries; these require a separate plugin/launcher assessment. |

Use [Unity's player-build format notes](https://github.com/Unity-Technologies/UnityDataTools/blob/main/Documentation/playerbuild-format.md) for container layout, and confirm it against the supplied version. Parse Unity headers for engine-version evidence; Android versionName is the app version.

Pass the code expert a same-build native/metadata pair with hashes, ABI, ELF details and metadata version. Do not pair an ARM64 library with files from another app revision or treat Unity's `libunity.so` as the game's IL2CPP assembly. If metadata is stripped, renamed or transformed, inspect loader evidence and report the specific recovery gap. Dummy assemblies are type/layout evidence, not recovered method behavior. DEX decompilation recovers Android-side code, not IL2CPP C# gameplay. Keep native disassembly addresses and module offsets associated with the chosen ABI.

## Restore Android dependencies in the project

Hand the scene/integration expert the package inventory, Unity object mappings, native/managed type results, manifest evidence and delivery dependencies. Preserve the existing editor-version policy; APK input alone does not select a new target editor.

Recover application behavior and plugin requirements from evidence: launcher lifecycle, JNI/AndroidJavaObject calls, permissions, resources, native dependencies, orientation, touch input, safe-area handling, pause/resume and storage. The packaged manifest is a merged build output; reconstruct necessary source manifest/plugin settings rather than treating it as an original Gradle project.

Keep Android-only libraries targeted to the correct platform/CPU. Reuse or reconstruct plugin interfaces as supported by evidence; document unavailable SDK/service behavior explicitly. Do not import original `libunity.so`, `libil2cpp.so`, `libmain.so`, or the whole DEX set as a substitute for compiling recovered scripts with the target Unity editor. Do not claim original AAR/JAR boundaries, Gradle templates or signing keys were recovered from merged output. Consult [Unity native plugin guidance](https://docs.unity3d.com/2023.2/Documentation/Manual/AndroidNativePlugins.html).

Retain mobile texture formats, shader variants and graphics API evidence. An Android-only texture or shader failing in a desktop preview is a compatibility finding, not proof of absent payload. For runtime loading, preserve the distinction between packaged read-only assets, writable persistent data and remote content; Android StreamingAssets may require URL-based access through UnityWebRequest. See [StreamingAssets](https://docs.unity3d.com/2023.2/Documentation/Manual/StreamingAssets.html).

## Validate and report

Report separate outcomes for package completeness, extraction coverage, editor import/Play Mode, Android compilation, device launch and gameplay fidelity. A successful desktop Play session does not validate Android plugins, asset delivery or touch controls.

For an Android deliverable, record the actual editor Android Build Support, SDK/NDK/JDK, backend, ABI and graphics API used. Build with a development signing identity and use an isolated test device/profile or a distinct test package ID when compatible. Do not overwrite/uninstall the original app or erase its save data to work around a signing conflict. Record any package-ID change and its effect on services or OBB lookup.

On a compatible authorized device/emulator, retain install/launch logs and `adb logcat` evidence. Check entry scenes, touch/orientation, pause/resume, rendering, audio, JNI/native loading, StreamingAssets, persistent saves and available external content against the original. ARM-only libraries require a compatible environment; missing device/ABI support yields an explicit untested or inconclusive result. Separate unavailable backend services from local recovery defects; do not claim an offline playable game when essential server behavior is missing.

The handoff includes original package hashes, split/module/ABI matrix, archive-to-file and object-to-project mappings, missing delivery content, plugin/code status, reproducible recovery steps, Android build settings and the exact runtime checks performed. Keep game-specific filenames and observations in project evidence rather than this reusable reference.
