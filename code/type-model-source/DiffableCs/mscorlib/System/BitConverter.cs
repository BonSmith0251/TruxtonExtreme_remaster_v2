namespace System;

[Token(Token = "0x20000BE")]
public static class BitConverter
{
	[CompilerGenerated]
	[Token(Token = "0x20000BF")]
	private sealed class <>c
	{
		[Token(Token = "0x40002A1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002A2")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"value", "startIndex", "length"})]
		public static SpanAction<Char, ValueTuple`3<Byte[], Int32, Int32>> <>9__38_0; //Field offset: 0x8

		[Address(RVA = "0x1FA85E0", Offset = "0x1FA79E0", Length = "0x67")]
		[Token(Token = "0x6000444")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000445")]
		public <>c() { }

		[Address(RVA = "0x1FA8290", Offset = "0x1FA7690", Length = "0x207")]
		[Token(Token = "0x6000446")]
		internal void <ToString>b__38_0(Span<Char> dst, ValueTuple<Byte[], Int32, Int32> state) { }

	}

	[Intrinsic]
	[Token(Token = "0x40002A0")]
	public static readonly bool IsLittleEndian; //Field offset: 0x0

	[Address(RVA = "0x1F8D9C0", Offset = "0x1F8CDC0", Length = "0x36")]
	[Token(Token = "0x6000443")]
	private static BitConverter() { }

	[Address(RVA = "0x1F8CFC0", Offset = "0x1F8C3C0", Length = "0x6")]
	[Token(Token = "0x6000440")]
	public static long DoubleToInt64Bits(double value) { }

	[Address(RVA = "0x1F8D330", Offset = "0x1F8C730", Length = "0x5E")]
	[Token(Token = "0x6000436")]
	public static Byte[] GetBytes(double value) { }

	[Address(RVA = "0x1F8D270", Offset = "0x1F8C670", Length = "0x5E")]
	[Token(Token = "0x6000435")]
	public static Byte[] GetBytes(float value) { }

	[Address(RVA = "0x1F8D0F0", Offset = "0x1F8C4F0", Length = "0x56")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000434")]
	public static Byte[] GetBytes(ulong value) { }

	[Address(RVA = "0x1F8D150", Offset = "0x1F8C550", Length = "0x54")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000432")]
	public static Byte[] GetBytes(uint value) { }

	[Address(RVA = "0x1F8D210", Offset = "0x1F8C610", Length = "0x55")]
	[Token(Token = "0x600042C")]
	public static Byte[] GetBytes(bool value) { }

	[Address(RVA = "0x1F8D1B0", Offset = "0x1F8C5B0", Length = "0x56")]
	[Token(Token = "0x6000430")]
	public static Byte[] GetBytes(long value) { }

	[Address(RVA = "0x1F8D2D0", Offset = "0x1F8C6D0", Length = "0x54")]
	[Token(Token = "0x600042F")]
	public static Byte[] GetBytes(int value) { }

	[Address(RVA = "0x1F8CFD0", Offset = "0x1F8C3D0", Length = "0x56")]
	[Token(Token = "0x600042E")]
	public static Byte[] GetBytes(short value) { }

	[Address(RVA = "0x1F8D090", Offset = "0x1F8C490", Length = "0x56")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000431")]
	public static Byte[] GetBytes(ushort value) { }

	[Address(RVA = "0x1F8D030", Offset = "0x1F8C430", Length = "0x56")]
	[Token(Token = "0x600042D")]
	public static Byte[] GetBytes(char value) { }

	[Address(RVA = "0x1F8D390", Offset = "0x1F8C790", Length = "0x5")]
	[Token(Token = "0x6000442")]
	public static float Int32BitsToSingle(int value) { }

	[Address(RVA = "0x1F8D3A0", Offset = "0x1F8C7A0", Length = "0x5")]
	[Token(Token = "0x6000441")]
	public static int SingleToInt32Bits(float value) { }

	[Address(RVA = "0x1F8D3B0", Offset = "0x1F8C7B0", Length = "0x7A")]
	[Token(Token = "0x600043F")]
	public static bool ToBoolean(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D430", Offset = "0x1F8C830", Length = "0x74")]
	[Token(Token = "0x6000437")]
	public static short ToInt16(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D4B0", Offset = "0x1F8C8B0", Length = "0x73")]
	[Token(Token = "0x6000438")]
	public static int ToInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D530", Offset = "0x1F8C930", Length = "0x74")]
	[Token(Token = "0x6000439")]
	public static long ToInt64(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D5B0", Offset = "0x1F8C9B0", Length = "0x75")]
	[Token(Token = "0x600043C")]
	public static float ToSingle(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D660", Offset = "0x1F8CA60", Length = "0x2DC")]
	[Token(Token = "0x600043D")]
	public static string ToString(Byte[] value, int startIndex, int length) { }

	[Address(RVA = "0x1F8D630", Offset = "0x1F8CA30", Length = "0x2C")]
	[Token(Token = "0x600043E")]
	public static string ToString(Byte[] value) { }

	[Address(RVA = "0x1F8D430", Offset = "0x1F8C830", Length = "0x74")]
	[CLSCompliant(False)]
	[Token(Token = "0x600043A")]
	public static ushort ToUInt16(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D4B0", Offset = "0x1F8C8B0", Length = "0x73")]
	[CLSCompliant(False)]
	[Token(Token = "0x600043B")]
	public static uint ToUInt32(Byte[] value, int startIndex) { }

	[Address(RVA = "0x1F8D940", Offset = "0x1F8CD40", Length = "0x72")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000433")]
	public static bool TryWriteBytes(Span<Byte> destination, uint value) { }

}

