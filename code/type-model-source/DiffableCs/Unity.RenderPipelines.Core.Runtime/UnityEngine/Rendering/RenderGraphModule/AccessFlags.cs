namespace UnityEngine.Rendering.RenderGraphModule;

[Flags]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000267")]
public enum AccessFlags : int
{
	None = 0,
	Read = 1,
	Write = 2,
	Discard = 4,
	WriteAll = 6,
	ReadWrite = 3,
}

