namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x20002A2")]
public struct FastMemoryDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BBD")]
	public bool inFastMemory; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BBE")]
	public FastMemoryFlags flags; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BBF")]
	public float residencyFraction; //Field offset: 0x8

}

