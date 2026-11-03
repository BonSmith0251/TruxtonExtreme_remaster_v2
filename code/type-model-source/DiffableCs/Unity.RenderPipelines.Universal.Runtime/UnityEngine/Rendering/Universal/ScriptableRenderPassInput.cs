namespace UnityEngine.Rendering.Universal;

[Flags]
[Token(Token = "0x2000156")]
public enum ScriptableRenderPassInput : int
{
	None = 0,
	Depth = 1,
	Normal = 2,
	Color = 4,
	Motion = 8,
}

