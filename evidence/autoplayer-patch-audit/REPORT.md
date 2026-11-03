# Autoplayer patch audit and reconstruction retry

2026-10-31. No persistent autoplayer patch was found or removed. All 264 files listed in the local GOG installer hash database match their MD5 values, including GameAssembly.dll, UnityPlayer.dll, executable, metadata and assets. This is local installer consistency evidence, not independently authenticated publisher provenance. No original game, Frida or Python controller process was running when checked.

Claude project history documents Frida runtime input interception and an optional --immortal flag invoking the game's existing PlayerControll.SetPlayerInvincible. The GameAssembly SHA256 recorded during that work is identical to the current binary. The controller and launcher files are absent from this installation. No original-binary patch or restoration backup was identified. No original files were modified in this audit.

The coordinator workflow retried Cpp2IL dll_il_recovery directly from the installer-matching source. The first attempt on D: failed because that drive is full; its incomplete assembly output was removed, and the failure log retained. A retry in C: TEMP completed successfully. It produced 118 assemblies and 137,034 methods: 130,106 throw-null placeholders (including generated helpers), 6,928 bodyless methods, and zero other implementations. The installed writer explicitly emits ldnull/throw. This confirms the previous code-recovery limitation; the autoplayer did not cause it.

Retry assemblies: C:/Users/Administrator/AppData/Local/Temp/TruxtonRecon-unpatched-retry/assemblies. Logs and census accompany this report. Original evidence: gog-integrity.json. Claude history: C:/Users/Administrator/.claude/projects/D--games-Truxton-Extreme/26756280-1cb6-4195-96fc-7422d957fb92.jsonl line 128; 6cc36164-60e4-4169-9e1e-383d208e3d8c.jsonl lines 2018 and 5694-5695.

Existing reconstruction assets and project were not rewritten because source inputs match. Existing editor and standalone passes remain historical results; they were not rerun during this source-patch investigation. The full-game behavior and rendering limitations in RECONSTRUCTION_REPORT.md remain. D: requires free space before further substantial export/import/build work. Comic exclusion remains in force.

Expert audit requested gpt-6-astra/high through the code skill; host accepted the assignment. Coordinator read unity-project-reconstruction and its routing policy. Installed skill improvement: distinguish unchanged-baseline checks from installer consistency and runtime instrumentation from on-disk modifications.
