# BG camera slide (horizontal camera follow)

Disassembly in `dis/` (made with evidence/bosses/Bos08/tools/bdis.py).

- `InGameStage.<SetupStage>d__2.MoveNext` (call at 0x1d4735f): `CinemachineMan.SetBGCameraTransform(_stageCamera.transform, 50)`.
  `_stageCamera` is the stage rail Camera (`BGxxStage/BGxx/camera_bgxx/Rail/Camera`, local pitch 83 deg =
  `InGameManager._groundCameraRotate`, Euler x 0x3fb96c7d rad). SetBGCameraTransform stores it as `_BGRootTransform`,
  sets `_BGCameraSlideRange = (50,0,0)` and calls `SetBGCameraRoll(DefaultCameraAngle)`.
- `BGSlideRangeMixer.ProcessFrame` -> `SetBGCameraSlideRange(w)`: writes `_BGCameraSlideRange.x` only.
- `InGameManager.LateUpdate` (play phases 1, 2, 3, 8) and `UpdateSlideRate(r)`, with `_bgSlideRate` =
  `_getSlideRate()` = clamp(sum of player X (x0.5 each in team mode) / PlayerControllWidth 123, -1, 1):
  1. `CinemachineMan.SetBGCameraSlide(rate)` (0x1CC5D50): `_bgCameraRate = rate`;
     `_BGRootTransform.SetLocalPositionAndRotation(_BGCameraSlideRange * rate + _shakeOffset, _groundCameraRotate * _shakeRotate)`.
  2. `_inGameEnemyRoot.localPosition = -0.5 * rate * _BGCameraSlideRange`.
- `get_BGCameraPos` = `_BGCameraSlideRange * _bgCameraRate + _shakeOffset`.

So the background camera moves up to +range (50 in BG03) sideways with the ship, and the air-enemy layer moves the
other way by half of it. The player and air enemies are drawn by the game camera, which does not move.

Remaster (2026-11-04): `Round1EnemyWaves.Step` -> `SlideCamera(rate * SlideAt(t))` adds the slide to the stage camera's
local position (base 0 in every BGxxStage; a new base is taken if something else moves the camera). Not reconstructed:
camera shake (`ShakeCamera`/`AddShake`, `_shakeOffset`/`_shakeRotate`), `CameraPersMixer` -> `SetBGCameraRoll`,
`InGameManager.BGSliderSkyRate` 0.5 (a const, so its uses are inlined; not traced).
