namespace UnityEngine;

[Token(Token = "0x2000130")]
public struct BlendShapeBufferRange
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40003EB")]
	private uint m_StartIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40003EC")]
	private uint m_EndIndex; //Field offset: 0x4

	[Token(Token = "0x170001FD")]
	internal uint endIndex
	{
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6000D4A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170001FC")]
	internal uint startIndex
	{
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000D49")]
		internal set { } //Length: 3
	}

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6000D4A")]
	internal void set_endIndex(uint value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000D49")]
	internal void set_startIndex(uint value) { }

}

