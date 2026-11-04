---
name: unity-crash-checks
description: "User wants every Unity run checked for crashes (Crash!!! in the log / exit 139) and reported; don't treat exit segfaults as harmless"
metadata:
  node_type: memory
  type: feedback
  originSessionId: 2b8ca490-dda9-4211-a370-09a54cc12c16
  modified: 2026-11-01T23:03:25.057Z
---

Check every Unity run (batch builds, GUI play checks, compiles) for a crash and say so when one happens: grep the
log for "Crash!!!" and look at the exit code (139 = segfault). Use tools/common/unity_batch_run.sh and
unity_gui_run.sh in TruxtonExRecon, which print "CRASH" with the top of the native stack.

**Why:** the user saw Unity crash windows repeatedly (2026-11-01). I had been calling the exit segfaults "harmless";
they were real bugs: ReconstructionStagePlay.Remap re-pointed m_GameObject owner links (corrupt scene in memory ->
crash on unload), and EditorApplication.Exit inside the play-mode callback crashed in DestroyGfxDevice. Fixed with
the Structural skip list in Remap and Editor/ReconstructionExit.Quit. The user said: skip hunting further, but
remember and check for crashes all the time.

**How to apply:** after any Unity process, report crash yes/no; if yes, read the stack (OUTPUTTING STACK TRACE
section) before moving on. Related: [[truxton-recon-project]].
