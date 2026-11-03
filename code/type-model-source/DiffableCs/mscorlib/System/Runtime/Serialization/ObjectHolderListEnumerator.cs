namespace System.Runtime.Serialization;

[Token(Token = "0x20003EF")]
internal class ObjectHolderListEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F68")]
	private bool m_isFixupEnumerator; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F69")]
	private ObjectHolderList m_list; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F6A")]
	private int m_startingVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F6B")]
	private int m_currPos; //Field offset: 0x24

	[Token(Token = "0x170003C7")]
	internal ObjectHolder Current
	{
		[Address(RVA = "0x1F1CF10", Offset = "0x1F1C310", Length = "0x34")]
		[Token(Token = "0x6001E3D")]
		internal get { } //Length: 52
	}

	[Address(RVA = "0x1F1CEB0", Offset = "0x1F1C2B0", Length = "0x5F")]
	[Token(Token = "0x6001E3B")]
	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator) { }

	[Address(RVA = "0x1F1CF10", Offset = "0x1F1C310", Length = "0x34")]
	[Token(Token = "0x6001E3D")]
	internal ObjectHolder get_Current() { }

	[Address(RVA = "0x1F1CE20", Offset = "0x1F1C220", Length = "0x8F")]
	[Token(Token = "0x6001E3C")]
	internal bool MoveNext() { }

}

