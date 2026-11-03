namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200028F")]
public struct RenderTargetInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B69")]
	public int width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B6A")]
	public int height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B6B")]
	public int volumeDepth; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000B6C")]
	public int msaaSamples; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B6D")]
	public GraphicsFormat format; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000B6E")]
	public bool bindMS; //Field offset: 0x14

}

