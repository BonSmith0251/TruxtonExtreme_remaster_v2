namespace UnityEngine.Timeline;

[Token(Token = "0x2000012")]
internal enum AppliedOffsetMode : int
{
	NoRootTransform = 0,
	TransformOffset = 1,
	SceneOffset = 2,
	TransformOffsetLegacy = 3,
	SceneOffsetLegacy = 4,
	SceneOffsetEditor = 5,
	SceneOffsetLegacyEditor = 6,
}

