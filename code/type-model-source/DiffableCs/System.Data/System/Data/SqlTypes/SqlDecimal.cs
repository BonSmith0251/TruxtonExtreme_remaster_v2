namespace System.Data.SqlTypes;

[Token(Token = "0x20000AF")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable
{
	[Token(Token = "0x400038E")]
	private static readonly byte s_NUMERIC_MAX_PRECISION; //Field offset: 0x0
	[Token(Token = "0x400038F")]
	public static readonly byte MaxPrecision; //Field offset: 0x1
	[Token(Token = "0x4000390")]
	public static readonly byte MaxScale; //Field offset: 0x2
	[Token(Token = "0x4000391")]
	private static readonly byte s_bNullMask; //Field offset: 0x3
	[Token(Token = "0x4000392")]
	private static readonly byte s_bIsNull; //Field offset: 0x4
	[Token(Token = "0x4000393")]
	private static readonly byte s_bNotNull; //Field offset: 0x5
	[Token(Token = "0x4000394")]
	private static readonly byte s_bReverseNullMask; //Field offset: 0x6
	[Token(Token = "0x4000395")]
	private static readonly byte s_bSignMask; //Field offset: 0x7
	[Token(Token = "0x4000396")]
	private static readonly byte s_bPositive; //Field offset: 0x8
	[Token(Token = "0x4000397")]
	private static readonly byte s_bNegative; //Field offset: 0x9
	[Token(Token = "0x4000398")]
	private static readonly byte s_bReverseSignMask; //Field offset: 0xA
	[Token(Token = "0x4000399")]
	private static readonly uint s_uiZero; //Field offset: 0xC
	[Token(Token = "0x400039A")]
	private static readonly int s_cNumeMax; //Field offset: 0x10
	[Token(Token = "0x400039B")]
	private static readonly long s_lInt32Base; //Field offset: 0x18
	[Token(Token = "0x400039C")]
	private static readonly ulong s_ulInt32Base; //Field offset: 0x20
	[Token(Token = "0x400039D")]
	private static readonly ulong s_ulInt32BaseForMod; //Field offset: 0x28
	[Token(Token = "0x400039E")]
	internal static readonly ulong s_llMax; //Field offset: 0x30
	[Token(Token = "0x400039F")]
	private static readonly uint s_ulBase10; //Field offset: 0x38
	[Token(Token = "0x40003A0")]
	private static readonly double s_DUINT_BASE; //Field offset: 0x40
	[Token(Token = "0x40003A1")]
	private static readonly double s_DUINT_BASE2; //Field offset: 0x48
	[Token(Token = "0x40003A2")]
	private static readonly double s_DUINT_BASE3; //Field offset: 0x50
	[Token(Token = "0x40003A3")]
	private static readonly double s_DMAX_NUME; //Field offset: 0x58
	[Token(Token = "0x40003A4")]
	private static readonly uint s_DBL_DIG; //Field offset: 0x60
	[Token(Token = "0x40003A5")]
	private static readonly byte s_cNumeDivScaleMin; //Field offset: 0x64
	[Token(Token = "0x40003A6")]
	private static readonly UInt32[] s_rgulShiftBase; //Field offset: 0x68
	[Token(Token = "0x40003A7")]
	private static readonly UInt32[] s_decimalHelpersLo; //Field offset: 0x70
	[Token(Token = "0x40003A8")]
	private static readonly UInt32[] s_decimalHelpersMid; //Field offset: 0x78
	[Token(Token = "0x40003A9")]
	private static readonly UInt32[] s_decimalHelpersHi; //Field offset: 0x80
	[Token(Token = "0x40003AA")]
	private static readonly UInt32[] s_decimalHelpersHiHi; //Field offset: 0x88
	[Token(Token = "0x40003AB")]
	private static readonly Byte[] s_rgCLenFromPrec; //Field offset: 0x90
	[Token(Token = "0x40003AC")]
	private static readonly uint s_ulT1; //Field offset: 0x98
	[Token(Token = "0x40003AD")]
	private static readonly uint s_ulT2; //Field offset: 0x9C
	[Token(Token = "0x40003AE")]
	private static readonly uint s_ulT3; //Field offset: 0xA0
	[Token(Token = "0x40003AF")]
	private static readonly uint s_ulT4; //Field offset: 0xA4
	[Token(Token = "0x40003B0")]
	private static readonly uint s_ulT5; //Field offset: 0xA8
	[Token(Token = "0x40003B1")]
	private static readonly uint s_ulT6; //Field offset: 0xAC
	[Token(Token = "0x40003B2")]
	private static readonly uint s_ulT7; //Field offset: 0xB0
	[Token(Token = "0x40003B3")]
	private static readonly uint s_ulT8; //Field offset: 0xB4
	[Token(Token = "0x40003B4")]
	private static readonly uint s_ulT9; //Field offset: 0xB8
	[Token(Token = "0x40003B5")]
	private static readonly ulong s_dwlT10; //Field offset: 0xC0
	[Token(Token = "0x40003B6")]
	private static readonly ulong s_dwlT11; //Field offset: 0xC8
	[Token(Token = "0x40003B7")]
	private static readonly ulong s_dwlT12; //Field offset: 0xD0
	[Token(Token = "0x40003B8")]
	private static readonly ulong s_dwlT13; //Field offset: 0xD8
	[Token(Token = "0x40003B9")]
	private static readonly ulong s_dwlT14; //Field offset: 0xE0
	[Token(Token = "0x40003BA")]
	private static readonly ulong s_dwlT15; //Field offset: 0xE8
	[Token(Token = "0x40003BB")]
	private static readonly ulong s_dwlT16; //Field offset: 0xF0
	[Token(Token = "0x40003BC")]
	private static readonly ulong s_dwlT17; //Field offset: 0xF8
	[Token(Token = "0x40003BD")]
	private static readonly ulong s_dwlT18; //Field offset: 0x100
	[Token(Token = "0x40003BE")]
	private static readonly ulong s_dwlT19; //Field offset: 0x108
	[Token(Token = "0x40003BF")]
	public static readonly SqlDecimal Null; //Field offset: 0x110
	[Token(Token = "0x40003C0")]
	public static readonly SqlDecimal MinValue; //Field offset: 0x124
	[Token(Token = "0x40003C1")]
	public static readonly SqlDecimal MaxValue; //Field offset: 0x138
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000386")]
	internal byte _bStatus; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000387")]
	internal byte _bLen; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000388")]
	internal byte _bPrec; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000389")]
	internal byte _bScale; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400038A")]
	internal uint _data1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400038B")]
	internal uint _data2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400038C")]
	internal uint _data3; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400038D")]
	internal uint _data4; //Field offset: 0x10

	[Token(Token = "0x1700016C")]
	public Int32[] Data
	{
		[Address(RVA = "0x2393980", Offset = "0x2392D80", Length = "0x13A")]
		[Token(Token = "0x6000931")]
		 get { } //Length: 314
	}

	[Token(Token = "0x17000168")]
	public override bool IsNull
	{
		[Address(RVA = "0x2393AC0", Offset = "0x2392EC0", Length = "0x60")]
		[Token(Token = "0x600092B")]
		 get { } //Length: 96
	}

	[Token(Token = "0x1700016A")]
	public bool IsPositive
	{
		[Address(RVA = "0x2393B20", Offset = "0x2392F20", Length = "0x10D")]
		[Token(Token = "0x600092D")]
		 get { } //Length: 269
	}

	[Token(Token = "0x1700016B")]
	public byte Scale
	{
		[Address(RVA = "0x2393C30", Offset = "0x2393030", Length = "0xE0")]
		[Token(Token = "0x6000930")]
		 get { } //Length: 224
	}

	[Token(Token = "0x17000169")]
	public decimal Value
	{
		[Address(RVA = "0x2393D20", Offset = "0x2393120", Length = "0x65")]
		[Token(Token = "0x600092C")]
		 get { } //Length: 101
	}

	[Address(RVA = "0x2392A10", Offset = "0x2391E10", Length = "0x78F")]
	[Token(Token = "0x600096B")]
	private static SqlDecimal() { }

	[Address(RVA = "0x2393420", Offset = "0x2392820", Length = "0x66")]
	[Token(Token = "0x6000926")]
	private SqlDecimal(bool fNull) { }

	[Address(RVA = "0x2393800", Offset = "0x2392C00", Length = "0x17C")]
	[Token(Token = "0x6000927")]
	public SqlDecimal(decimal value) { }

	[Address(RVA = "0x23931A0", Offset = "0x23925A0", Length = "0x273")]
	[Token(Token = "0x6000928")]
	public SqlDecimal(int value) { }

	[Address(RVA = "0x2393490", Offset = "0x2392890", Length = "0xF5")]
	[Token(Token = "0x6000929")]
	public SqlDecimal(long value) { }

	[Address(RVA = "0x2393590", Offset = "0x2392990", Length = "0x265")]
	[Token(Token = "0x600092A")]
	private SqlDecimal(UInt32[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	[Address(RVA = "0x238DD70", Offset = "0x238D170", Length = "0x279")]
	[Token(Token = "0x6000948")]
	private void AddULong(uint ulAdd) { }

	[Address(RVA = "0x238DFF0", Offset = "0x238D3F0", Length = "0x3BA")]
	[Token(Token = "0x600094B")]
	internal void AdjustScale(int digits, bool fRound) { }

	[Address(RVA = "0x238E3B0", Offset = "0x238D7B0", Length = "0x1A0")]
	[Token(Token = "0x6000946")]
	private static byte BGetPrecUI4(uint value) { }

	[Address(RVA = "0x238E550", Offset = "0x238D950", Length = "0x38B")]
	[Token(Token = "0x6000947")]
	private static byte BGetPrecUI8(ulong dwlVal) { }

	[Address(RVA = "0x238E8E0", Offset = "0x238DCE0", Length = "0x261")]
	[Token(Token = "0x6000924")]
	private byte CalculatePrecision() { }

	[Address(RVA = "0x238EB60", Offset = "0x238DF60", Length = "0xD1")]
	[Token(Token = "0x6000957")]
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	[Address(RVA = "0x238EB50", Offset = "0x238DF50", Length = "0x4")]
	[Token(Token = "0x6000960")]
	private static char ChFromDigit(uint uiDigit) { }

	[Address(RVA = "0x238EC40", Offset = "0x238E040", Length = "0x1DA")]
	[Token(Token = "0x6000956")]
	private EComparison CompareNm(SqlDecimal snumOp) { }

	[Address(RVA = "0x238EE20", Offset = "0x238E220", Length = "0x2BD")]
	[Token(Token = "0x6000964")]
	public int CompareTo(SqlDecimal value) { }

	[Address(RVA = "0x238F0E0", Offset = "0x238E4E0", Length = "0x127")]
	[Token(Token = "0x6000963")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x238F220", Offset = "0x238E620", Length = "0x1E8")]
	[Token(Token = "0x600094A")]
	private uint DivByULong(uint iDivisor) { }

	[Address(RVA = "0x238F210", Offset = "0x238E610", Length = "0xC")]
	[Token(Token = "0x6000952")]
	internal static ulong DWL(uint lo, uint hi) { }

	[Address(RVA = "0x238F410", Offset = "0x238E810", Length = "0x3F7")]
	[Token(Token = "0x6000965")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x238F810", Offset = "0x238EC10", Length = "0x34")]
	[Token(Token = "0x6000944")]
	private bool FGt10_38() { }

	[Address(RVA = "0x238F850", Offset = "0x238EC50", Length = "0x4D")]
	[Token(Token = "0x6000945")]
	private bool FGt10_38(UInt32[] rglData) { }

	[Address(RVA = "0x238F8A0", Offset = "0x238ECA0", Length = "0x11")]
	[Token(Token = "0x6000943")]
	private bool FZero() { }

	[Address(RVA = "0x2393980", Offset = "0x2392D80", Length = "0x13A")]
	[Token(Token = "0x6000931")]
	public Int32[] get_Data() { }

	[Address(RVA = "0x2393AC0", Offset = "0x2392EC0", Length = "0x60")]
	[Token(Token = "0x600092B")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2393B20", Offset = "0x2392F20", Length = "0x10D")]
	[Token(Token = "0x600092D")]
	public bool get_IsPositive() { }

	[Address(RVA = "0x2393C30", Offset = "0x2393030", Length = "0xE0")]
	[Token(Token = "0x6000930")]
	public byte get_Scale() { }

	[Address(RVA = "0x2393D20", Offset = "0x2393120", Length = "0x65")]
	[Token(Token = "0x600092C")]
	public decimal get_Value() { }

	[Address(RVA = "0x238F8C0", Offset = "0x238ECC0", Length = "0x16D")]
	[Token(Token = "0x6000966")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x238FA30", Offset = "0x238EE30", Length = "0x6B")]
	[Token(Token = "0x600096A")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x238FAA0", Offset = "0x238EEA0", Length = "0x7C")]
	[Token(Token = "0x600095C")]
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x202FD50", Offset = "0x202F150", Length = "0x7")]
	[Token(Token = "0x6000953")]
	private static uint HI(ulong x) { }

	[Address(RVA = "0x238FB20", Offset = "0x238EF20", Length = "0x1B6")]
	[Token(Token = "0x600094C")]
	private int LAbsCmp(SqlDecimal snumOp) { }

	[Address(RVA = "0x238FCE0", Offset = "0x238F0E0", Length = "0x7C")]
	[Token(Token = "0x600095B")]
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6000954")]
	private static uint LO(ulong x) { }

	[Address(RVA = "0x238FE60", Offset = "0x238F260", Length = "0xC56")]
	[Token(Token = "0x6000955")]
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, out int ciulQ, UInt32[] rgulR, out int ciulR) { }

	[Address(RVA = "0x238FD60", Offset = "0x238F160", Length = "0xFF")]
	[Token(Token = "0x6000951")]
	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	[Address(RVA = "0x2390AC0", Offset = "0x238FEC0", Length = "0x63")]
	[Token(Token = "0x600094D")]
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, out int ciulD) { }

	[Address(RVA = "0x2390B30", Offset = "0x238FF30", Length = "0xC7")]
	[Token(Token = "0x6000950")]
	private static void MpMul1(UInt32[] piulD, ref int ciulD, uint iulX) { }

	[Address(RVA = "0x2390C00", Offset = "0x2390000", Length = "0x3E")]
	[Token(Token = "0x600094F")]
	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	[Address(RVA = "0x2390C40", Offset = "0x2390040", Length = "0x29")]
	[Token(Token = "0x600094E")]
	private static void MpSet(UInt32[] rgulD, out int ciulD, uint iulN) { }

	[Address(RVA = "0x2390C70", Offset = "0x2390070", Length = "0x2C4")]
	[Token(Token = "0x6000949")]
	private void MultByULong(uint uiMultiplier) { }

	[Address(RVA = "0x2393D90", Offset = "0x2393190", Length = "0x827")]
	[Token(Token = "0x6000939")]
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x23945C0", Offset = "0x23939C0", Length = "0x67E")]
	[Token(Token = "0x600093C")]
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x2394C40", Offset = "0x2394040", Length = "0x19F")]
	[Token(Token = "0x6000958")]
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x2394DE0", Offset = "0x23941E0", Length = "0x19F")]
	[Token(Token = "0x600095A")]
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x23952F0", Offset = "0x23946F0", Length = "0xF0")]
	[Token(Token = "0x6000941")]
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	[Address(RVA = "0x2394F80", Offset = "0x2394380", Length = "0x32")]
	[Token(Token = "0x6000936")]
	public static SqlDecimal op_Implicit(decimal x) { }

	[Address(RVA = "0x2394FC0", Offset = "0x23943C0", Length = "0x4D")]
	[Token(Token = "0x6000937")]
	public static SqlDecimal op_Implicit(long x) { }

	[Address(RVA = "0x2395210", Offset = "0x2394610", Length = "0xDF")]
	[Token(Token = "0x600093D")]
	public static SqlDecimal op_Implicit(SqlByte x) { }

	[Address(RVA = "0x2395010", Offset = "0x2394410", Length = "0xD9")]
	[Token(Token = "0x600093E")]
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	[Address(RVA = "0x23953E0", Offset = "0x23947E0", Length = "0x10B")]
	[Token(Token = "0x600093F")]
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	[Address(RVA = "0x23950F0", Offset = "0x23944F0", Length = "0x113")]
	[Token(Token = "0x6000940")]
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	[Address(RVA = "0x23954F0", Offset = "0x23948F0", Length = "0x19E")]
	[Token(Token = "0x6000959")]
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x2395690", Offset = "0x2394A90", Length = "0xD52")]
	[Token(Token = "0x600093B")]
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x23963F0", Offset = "0x23957F0", Length = "0x270")]
	[Token(Token = "0x600093A")]
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	[Address(RVA = "0x2396660", Offset = "0x2395A60", Length = "0x1FD")]
	[Token(Token = "0x6000938")]
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	[Address(RVA = "0x2390F40", Offset = "0x2390340", Length = "0x749")]
	[Token(Token = "0x6000933")]
	public static SqlDecimal Parse(string s) { }

	[Address(RVA = "0x2391690", Offset = "0x2390A90", Length = "0x66")]
	[Token(Token = "0x600092E")]
	private void SetPositive() { }

	[Address(RVA = "0x2391700", Offset = "0x2390B00", Length = "0xAB")]
	[Token(Token = "0x600092F")]
	private void SetSignBit(bool fPositive) { }

	[Address(RVA = "0x23917B0", Offset = "0x2390BB0", Length = "0x6B")]
	[Token(Token = "0x6000962")]
	private void SetToZero() { }

	[Address(RVA = "0x2391820", Offset = "0x2390C20", Length = "0x49")]
	[Token(Token = "0x6000961")]
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000967")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x2391870", Offset = "0x2390C70", Length = "0x1AA")]
	[Token(Token = "0x6000968")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	[Address(RVA = "0x2391A20", Offset = "0x2390E20", Length = "0x15D")]
	[Token(Token = "0x6000969")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	[Address(RVA = "0x2391B80", Offset = "0x2390F80", Length = "0x1B4")]
	[Token(Token = "0x6000935")]
	private decimal ToDecimal() { }

	[Address(RVA = "0x2391D40", Offset = "0x2391140", Length = "0x1D0")]
	[Token(Token = "0x6000934")]
	public double ToDouble() { }

	[Address(RVA = "0x2391F20", Offset = "0x2391320", Length = "0x1CF")]
	[Token(Token = "0x600095D")]
	public SqlDouble ToSqlDouble() { }

	[Address(RVA = "0x23920F0", Offset = "0x23914F0", Length = "0x80")]
	[Token(Token = "0x600095E")]
	public SqlInt64 ToSqlInt64() { }

	[Address(RVA = "0x2392170", Offset = "0x2391570", Length = "0x1C7")]
	[Token(Token = "0x600095F")]
	public SqlMoney ToSqlMoney() { }

	[Address(RVA = "0x2392340", Offset = "0x2391740", Length = "0x407")]
	[Token(Token = "0x6000932")]
	public virtual string ToString() { }

	[Address(RVA = "0x2392750", Offset = "0x2391B50", Length = "0x23C")]
	[Token(Token = "0x6000925")]
	private bool VerifyPrecision(byte precision) { }

	[Address(RVA = "0x2392990", Offset = "0x2391D90", Length = "0x78")]
	[Token(Token = "0x6000942")]
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

}

