namespace UnityEngine;

[Flags]
[Token(Token = "0x2000003")]
internal enum TextGenerationError : int
{
	None = 0,
	CustomSizeOnNonDynamicFont = 1,
	CustomStyleOnNonDynamicFont = 2,
	NoFont = 4,
}

