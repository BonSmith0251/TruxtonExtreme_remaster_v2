namespace System.Runtime.Serialization;

[Token(Token = "0x20003EC")]
internal class FixupHolderList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F60")]
	internal FixupHolder[] m_values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F61")]
	internal int m_count; //Field offset: 0x18

	[Address(RVA = "0x1F1C650", Offset = "0x1F1BA50", Length = "0x5C")]
	[Token(Token = "0x6001E27")]
	internal FixupHolderList() { }

	[Address(RVA = "0x1F1C5E0", Offset = "0x1F1B9E0", Length = "0x64")]
	[Token(Token = "0x6001E28")]
	internal FixupHolderList(int startingSize) { }

	[Address(RVA = "0x1F1C440", Offset = "0x1F1B840", Length = "0x10C")]
	[Token(Token = "0x6001E29")]
	internal override void Add(FixupHolder fixup) { }

	[Address(RVA = "0x1F1C550", Offset = "0x1F1B950", Length = "0x81")]
	[Token(Token = "0x6001E2A")]
	private void EnlargeArray() { }

}

