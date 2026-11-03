# Original animation and native behavior evidence

For motion investigations, inspect source serialized values, actual runtime curves and the compiled consumer before adding new easing. Use video for visual comparison, but prefer original embedded media when available.

Existing `extractor/export_player_motion.py` recovers the two entrance clips' exact streamed polynomial keys and the serialized player steering profile. `extractor/analyze_player_native.py` performs read-only metadata-v39/PE/Capstone analysis. Both are build-specific; hash `GameAssembly.dll` and `global-metadata.dat` and re-establish layouts/addresses after an update. They are project tools, not included in this skill. The earlier native evidence and selected disassemblies are under `extractor/motion-source`; a readable audit is also installed at `TruxtonRemaster/SourceAssets/Motion/player-motion-analysis.txt`.

## Established source behavior

- `anm_player01.controller` has the two entrance states; left/right banking is procedural, not an undiscovered left/right animation pair.
- `PlayerControll._moveYaw` uses `_playerDefined2D`: `YawSpeedTime = 500` **milliseconds**, `YawRotateMax = 45`, speed factors `[1, .76, .625, .5, .4, .3]`.
- On horizontal input change, retain current yaw as start, target `Sinf(inputX * Rad2Deg) * 45` (zero for neutral), duration `.5 * speedFactor * abs(target-start) / 90`. Interpolate with `Sinf(progress * 90 degrees)` and set `_yawModel.localRotation = Euler(0, 0, -yaw)`.
- Source `Sinf` quantizes degrees to 0.1 degree before lookup. Full input produces about 37.8255 degrees rather than 45. Preserve the negative local roll sign and the actual `_yawModel` pivot (`proot/modelTop/pf_player01`, source local position `(0,0,2.5)`).
- Positive horizontal input sets the last-right flag; negative clears it; neutral retains it. The source entrance picks `anc_player_start1` for right, otherwise `anc_player_start2`. A fresh run defaults to start2; a respawn follows the last direction.
- Each entrance clip lasts about 1.1666666269 seconds at 60 Hz. The native playable graph is manually evaluated using game delta time. The 1.5-second branch is a missing-animation fallback, not an extra phase.

## Exact streamed curve reconstruction

The original entrance has six streamed Transform channels. Stream records contain float time, int count, then int channel index and four float coefficients `(a,b,c,d)`. For local time `u`, the segment is `a*u^3 + b*u^2 + c*u + d`. Discard negative-time sentinels only after confirming their role in this clip format.

Set a key's outgoing tangent to its segment's `c`. Its incoming tangent is the previous segment derivative `(3*a*dt + 2*b)*dt + c`. Preserve source times and values rather than converting the clip to 71 linearly interpolated frame samples. Source position key times are `0`, `.4166666567`, `1.1666666269`; Y goes `320 → 220 → 0`, Z goes `-45 → 12 → 0` with cubic overshoot. Euler Z spins from ±420 to 0. Test both signs, endpoints and between-key samples.

A Unity 2023 camera-plane mapping can be necessary because the remaster camera differs; label that mapping as an adaptation. Do not add waypoint pauses and present them as source animation. Advance entrance particles consistently once per rendered game frame, preserve their simulation history, and test pause/restart plus 30/60/144 FPS; restarting their simulation every frame can make otherwise-correct motion look uneven.

## Native analysis limits and useful anchors

In the inspected build, PlayerControll belongs to `InGame.Kernel.dll`. Evidence RVAs: `_moveYaw` `0x1d4c060`, `_playerControll` `0x1d4ca40`, `PlayerEntryAsync.MoveNext` `0x1d54430`, `VectorUtility.Sinf` `0x1df8a70`. These are evidence anchors, not stable APIs or offsets to patch.

Metadata v39 uses a different table/header layout from many older dumpers. The local parser uses the observed 380-byte header with 31 `(offset,size,count)` entries, variable-width indices, native codegen modules and token RID-to-method-pointer mapping. Verify bounds and names before trusting disassembly. Use compatible maintained tooling or inspect its actual metadata schemas if the binary changes; do not reinterpret v39 as an earlier version merely to suppress errors.

The source intro movie is `StreamingAssets/movies/demo_takeoff_10.mp4` (the inspected file was 2560×1440, 60 FPS, approximately 15.034 seconds). Copying it preserves the original carrier/hangar sequence. `pf_eff_burner_p01.prefab` and `pf_eff_demo_boost01.prefab` are real container roots; the red burner child is not a separate addressable prefab. Discover roots through the inventory rather than guessing filenames from hierarchy names.
