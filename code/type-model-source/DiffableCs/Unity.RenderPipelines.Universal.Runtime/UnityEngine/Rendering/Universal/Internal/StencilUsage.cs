namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200023A")]
internal enum StencilUsage : int
{
	UserMask = 15,
	StencilLight = 16,
	MaterialMask = 96,
	MaterialUnlit = 0,
	MaterialLit = 32,
	MaterialSimpleLit = 64,
}

