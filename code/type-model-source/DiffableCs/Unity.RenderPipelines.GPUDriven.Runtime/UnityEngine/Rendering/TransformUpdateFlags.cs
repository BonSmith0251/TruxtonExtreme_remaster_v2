namespace UnityEngine.Rendering;

[Flags]
[Token(Token = "0x2000082")]
internal enum TransformUpdateFlags : byte
{
	None = 0,
	HasLightProbeCombined = 1,
	IsPartOfStaticBatch = 2,
}

