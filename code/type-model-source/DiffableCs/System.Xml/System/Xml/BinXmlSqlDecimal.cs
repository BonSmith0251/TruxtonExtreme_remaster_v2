namespace System.Xml;

[Token(Token = "0x200000E")]
internal struct BinXmlSqlDecimal
{
	[Token(Token = "0x400005C")]
	private static readonly byte NUMERIC_MAX_PRECISION; //Field offset: 0x0
	[Token(Token = "0x400005D")]
	private static readonly byte MaxPrecision; //Field offset: 0x1
	[Token(Token = "0x400005E")]
	private static readonly byte MaxScale; //Field offset: 0x2
	[Token(Token = "0x400005F")]
	private static readonly int x_cNumeMax; //Field offset: 0x4
	[Token(Token = "0x4000060")]
	private static readonly long x_lInt32Base; //Field offset: 0x8
	[Token(Token = "0x4000061")]
	private static readonly ulong x_ulInt32Base; //Field offset: 0x10
	[Token(Token = "0x4000062")]
	private static readonly ulong x_ulInt32BaseForMod; //Field offset: 0x18
	[Token(Token = "0x4000063")]
	internal static readonly ulong x_llMax; //Field offset: 0x20
	[Token(Token = "0x4000064")]
	private static readonly double DUINT_BASE; //Field offset: 0x28
	[Token(Token = "0x4000065")]
	private static readonly double DUINT_BASE2; //Field offset: 0x30
	[Token(Token = "0x4000066")]
	private static readonly double DUINT_BASE3; //Field offset: 0x38
	[Token(Token = "0x4000067")]
	private static readonly UInt32[] x_rgulShiftBase; //Field offset: 0x40
	[Token(Token = "0x4000068")]
	private static readonly Byte[] rgCLenFromPrec; //Field offset: 0x48
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000054")]
	internal byte m_bLen; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000055")]
	internal byte m_bPrec; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000056")]
	internal byte m_bScale; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000057")]
	internal byte m_bSign; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000058")]
	internal uint m_data1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000059")]
	internal uint m_data2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400005A")]
	internal uint m_data3; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400005B")]
	internal uint m_data4; //Field offset: 0x10

	[Token(Token = "0x17000002")]
	public bool IsPositive
	{
		[Address(RVA = "0x23F2A80", Offset = "0x23F1E80", Length = "0x8")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x23F24F0", Offset = "0x23F18F0", Length = "0x201")]
	[Token(Token = "0x600001F")]
	private static BinXmlSqlDecimal() { }

	[Address(RVA = "0x23F2700", Offset = "0x23F1B00", Length = "0x37E")]
	[Token(Token = "0x6000017")]
	public BinXmlSqlDecimal(Byte[] data, int offset, bool trim) { }

	[Address(RVA = "0x238EB50", Offset = "0x238DF50", Length = "0x4")]
	[Token(Token = "0x600001B")]
	private static char ChFromDigit(uint uiDigit) { }

	[Address(RVA = "0x23F2A80", Offset = "0x23F1E80", Length = "0x8")]
	[Token(Token = "0x6000016")]
	public bool get_IsPositive() { }

	[Address(RVA = "0x23F1D10", Offset = "0x23F1110", Length = "0xFF")]
	[Token(Token = "0x6000019")]
	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	[Address(RVA = "0x2390C00", Offset = "0x2390000", Length = "0x3E")]
	[Token(Token = "0x600001A")]
	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	[Address(RVA = "0x23F1E10", Offset = "0x23F1210", Length = "0x106")]
	[Token(Token = "0x600001C")]
	public decimal ToDecimal() { }

	[Address(RVA = "0x23F1F20", Offset = "0x23F1320", Length = "0x377")]
	[Token(Token = "0x600001E")]
	public virtual string ToString() { }

	[Address(RVA = "0x23F22A0", Offset = "0x23F16A0", Length = "0x24C")]
	[Token(Token = "0x600001D")]
	private void TrimTrailingZeros() { }

	[Address(RVA = "0x1F29990", Offset = "0x1F28D90", Length = "0x6D")]
	[Token(Token = "0x6000018")]
	private static uint UIntFromByteArray(Byte[] data, int offset) { }

}

