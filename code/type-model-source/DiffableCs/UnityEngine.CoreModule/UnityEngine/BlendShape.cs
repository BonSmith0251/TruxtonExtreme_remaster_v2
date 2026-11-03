namespace UnityEngine;

[Token(Token = "0x200012F")]
[UsedByNativeCode]
internal struct BlendShape
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40003E7")]
	private uint m_FirstVertex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40003E8")]
	private uint m_VertexCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40003E9")]
	private bool m_HasNormals; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[SerializeField]
	[Token(Token = "0x40003EA")]
	private bool m_HasTangents; //Field offset: 0x9

	[Token(Token = "0x170001FA")]
	public uint firstVertex
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6000D47")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FB")]
	public uint vertexCount
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x6000D48")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000D47")]
	public uint get_firstVertex() { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x6000D48")]
	public uint get_vertexCount() { }

}

