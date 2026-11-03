namespace UnityEngine.UIElements;

[Flags]
[Token(Token = "0x20002B2")]
public enum UsageHints : int
{
	None = 0,
	DynamicTransform = 1,
	GroupTransform = 2,
	MaskContainer = 4,
	DynamicColor = 8,
	DynamicPostProcessing = 16,
	LargePixelCoverage = 32,
}

