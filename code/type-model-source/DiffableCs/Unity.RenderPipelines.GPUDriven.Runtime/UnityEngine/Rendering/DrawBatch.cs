namespace UnityEngine.Rendering;

[Token(Token = "0x200003C")]
internal struct DrawBatch
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D0")]
	public DrawKey key; //Field offset: 0x0
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000D1")]
	public int instanceCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D2")]
	public int instanceOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000D3")]
	public MeshProceduralInfo procInfo; //Field offset: 0x44

}

