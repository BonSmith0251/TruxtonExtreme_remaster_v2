namespace UnityEngine.Splines;

[Flags]
[Token(Token = "0x200001D")]
public enum EmbeddedSplineDataField : int
{
	Container = 1,
	SplineIndex = 2,
	Key = 4,
	Type = 8,
	All = 255,
}

