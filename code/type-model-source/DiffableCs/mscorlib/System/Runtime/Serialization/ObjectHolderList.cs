namespace System.Runtime.Serialization;

[Token(Token = "0x20003EE")]
internal class ObjectHolderList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F66")]
	internal ObjectHolder[] m_values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F67")]
	internal int m_count; //Field offset: 0x18

	[Token(Token = "0x170003C6")]
	internal int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001E3A")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170003C5")]
	internal int Version
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001E39")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x1F1D140", Offset = "0x1F1C540", Length = "0x5C")]
	[Token(Token = "0x6001E34")]
	internal ObjectHolderList() { }

	[Address(RVA = "0x1F1D1A0", Offset = "0x1F1C5A0", Length = "0x64")]
	[Token(Token = "0x6001E35")]
	internal ObjectHolderList(int startingSize) { }

	[Address(RVA = "0x1F1CF50", Offset = "0x1F1C350", Length = "0xD9")]
	[Token(Token = "0x6001E36")]
	internal override void Add(ObjectHolder value) { }

	[Address(RVA = "0x1F1D030", Offset = "0x1F1C430", Length = "0x81")]
	[Token(Token = "0x6001E38")]
	private void EnlargeArray() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6001E3A")]
	internal int get_Count() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6001E39")]
	internal int get_Version() { }

	[Address(RVA = "0x1F1D0C0", Offset = "0x1F1C4C0", Length = "0x7F")]
	[Token(Token = "0x6001E37")]
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

}

