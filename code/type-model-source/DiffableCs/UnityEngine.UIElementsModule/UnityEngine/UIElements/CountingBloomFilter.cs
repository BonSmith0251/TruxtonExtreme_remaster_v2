namespace UnityEngine.UIElements;

[Token(Token = "0x2000180")]
internal struct CountingBloomFilter
{
	[CompilerGenerated]
	[Token(Token = "0x2000181")]
	[UnsafeValueType]
	internal struct <m_Counters>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400076D")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(byte), 16384)]
	[Token(Token = "0x400076C")]
	private <m_Counters>e__FixedBuffer m_Counters; //Field offset: 0x0

	[Address(RVA = "0x33AC6E0", Offset = "0x33ABAE0", Length = "0x23")]
	[Token(Token = "0x6000B7A")]
	private void AdjustSlot(uint index, bool increment) { }

	[Address(RVA = "0x33AC710", Offset = "0x33ABB10", Length = "0x2B")]
	[Token(Token = "0x6000B80")]
	public bool ContainsHash(uint hash) { }

	[Address(RVA = "0x33AC740", Offset = "0x33ABB40", Length = "0xB")]
	[Token(Token = "0x6000B7B")]
	private uint Hash1(uint hash) { }

	[Address(RVA = "0x33AC750", Offset = "0x33ABB50", Length = "0xE")]
	[Token(Token = "0x6000B7C")]
	private uint Hash2(uint hash) { }

	[Address(RVA = "0x33AC760", Offset = "0x33ABB60", Length = "0x25")]
	[Token(Token = "0x6000B7E")]
	public void InsertHash(uint hash) { }

	[Address(RVA = "0x33AC790", Offset = "0x33ABB90", Length = "0xC")]
	[Token(Token = "0x6000B7D")]
	private bool IsSlotEmpty(uint index) { }

	[Address(RVA = "0x33AC7A0", Offset = "0x33ABBA0", Length = "0x25")]
	[Token(Token = "0x6000B7F")]
	public void RemoveHash(uint hash) { }

}

