namespace UnityEngine.Rendering;

[Token(Token = "0x2000056")]
internal struct MeshProceduralInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000175")]
	public MeshTopology topology; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000176")]
	public uint baseVertex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000177")]
	public uint firstIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000178")]
	public uint indexCount; //Field offset: 0xC

}

