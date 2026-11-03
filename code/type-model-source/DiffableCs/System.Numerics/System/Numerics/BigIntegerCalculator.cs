namespace System.Numerics;

[Token(Token = "0x2000005")]
internal static class BigIntegerCalculator
{
	[Token(Token = "0x400000C")]
	private static int ReducerThreshold; //Field offset: 0x0
	[Token(Token = "0x400000D")]
	private static int SquareThreshold; //Field offset: 0x4
	[Token(Token = "0x400000E")]
	private static int AllocationThreshold; //Field offset: 0x8
	[Token(Token = "0x400000F")]
	private static int MultiplyThreshold; //Field offset: 0xC

	[Address(RVA = "0x23E0DD0", Offset = "0x23E01D0", Length = "0x78")]
	[Token(Token = "0x6000061")]
	private static BigIntegerCalculator() { }

	[Address(RVA = "0x23DF1A0", Offset = "0x23DE5A0", Length = "0xB0")]
	[Token(Token = "0x600004B")]
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x23DF250", Offset = "0x23DE650", Length = "0xCD")]
	[Token(Token = "0x6000049")]
	public static UInt32[] Add(UInt32[] left, uint right) { }

	[Address(RVA = "0x23DF320", Offset = "0x23DE720", Length = "0x106")]
	[Token(Token = "0x600004A")]
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23DF100", Offset = "0x23DE500", Length = "0x30")]
	[Token(Token = "0x6000056")]
	private static uint AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	[Address(RVA = "0x23DF130", Offset = "0x23DE530", Length = "0x6E")]
	[Token(Token = "0x600004C")]
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	[Address(RVA = "0x23DF430", Offset = "0x23DE830", Length = "0x7F")]
	[Token(Token = "0x6000050")]
	public static int Compare(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23DF4B0", Offset = "0x23DE8B0", Length = "0x79")]
	[Token(Token = "0x6000059")]
	private static UInt32[] CreateCopy(UInt32[] value) { }

	[Address(RVA = "0x23DF570", Offset = "0x23DE970", Length = "0x3D0")]
	[Token(Token = "0x6000055")]
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x23DF940", Offset = "0x23DED40", Length = "0xD0")]
	[Token(Token = "0x6000051")]
	public static UInt32[] Divide(UInt32[] left, uint right) { }

	[Address(RVA = "0x23DFA20", Offset = "0x23DEE20", Length = "0x130")]
	[Token(Token = "0x6000053")]
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23DF530", Offset = "0x23DE930", Length = "0x3A")]
	[Token(Token = "0x6000058")]
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	[Address(RVA = "0x23DFB60", Offset = "0x23DEF60", Length = "0x69")]
	[Token(Token = "0x600005A")]
	private static int LeadingZeros(uint value) { }

	[Address(RVA = "0x23E0230", Offset = "0x23DF630", Length = "0xC5")]
	[Token(Token = "0x600005D")]
	public static UInt32[] Multiply(UInt32[] left, uint right) { }

	[Address(RVA = "0x23DFBD0", Offset = "0x23DEFD0", Length = "0x119")]
	[Token(Token = "0x600005E")]
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23DFCF0", Offset = "0x23DF0F0", Length = "0x537")]
	[Token(Token = "0x600005F")]
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x23E0400", Offset = "0x23DF800", Length = "0x6D")]
	[Token(Token = "0x6000052")]
	public static uint Remainder(UInt32[] left, uint right) { }

	[Address(RVA = "0x23E0300", Offset = "0x23DF700", Length = "0xF5")]
	[Token(Token = "0x6000054")]
	public static UInt32[] Remainder(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23E0890", Offset = "0x23DFC90", Length = "0xDA")]
	[Token(Token = "0x600005B")]
	public static UInt32[] Square(UInt32[] value) { }

	[Address(RVA = "0x23E0470", Offset = "0x23DF870", Length = "0x41C")]
	[Token(Token = "0x600005C")]
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x23E0D10", Offset = "0x23E0110", Length = "0xB0")]
	[Token(Token = "0x600004D")]
	public static UInt32[] Subtract(UInt32[] left, uint right) { }

	[Address(RVA = "0x23E0AD0", Offset = "0x23DFED0", Length = "0x185")]
	[Token(Token = "0x600004E")]
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	[Address(RVA = "0x23E0C60", Offset = "0x23E0060", Length = "0xB0")]
	[Token(Token = "0x600004F")]
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	[Address(RVA = "0x23E0970", Offset = "0x23DFD70", Length = "0x102")]
	[Token(Token = "0x6000060")]
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	[Address(RVA = "0x23E0A80", Offset = "0x23DFE80", Length = "0x4C")]
	[Token(Token = "0x6000057")]
	private static uint SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, ulong q) { }

}

