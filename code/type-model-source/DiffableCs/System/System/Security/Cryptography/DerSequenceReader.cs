namespace System.Security.Cryptography;

[Token(Token = "0x2000114")]
internal class DerSequenceReader
{
	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private sealed class <>c
	{
		[Token(Token = "0x40004E7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004E8")]
		public static Func<Encoding> <>9__45_0; //Field offset: 0x8
		[Token(Token = "0x40004E9")]
		public static Func<Encoding> <>9__45_1; //Field offset: 0x10
		[Token(Token = "0x40004EA")]
		public static Func<DateTimeFormatInfo> <>9__51_0; //Field offset: 0x18

		[Address(RVA = "0x26405E0", Offset = "0x263F9E0", Length = "0x67")]
		[Token(Token = "0x60006AF")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006B0")]
		public <>c() { }

		[Address(RVA = "0x2640480", Offset = "0x263F880", Length = "0x4A")]
		[Token(Token = "0x60006B1")]
		internal Encoding <ReadT61String>b__45_0() { }

		[Address(RVA = "0x26404D0", Offset = "0x263F8D0", Length = "0x32")]
		[Token(Token = "0x60006B2")]
		internal Encoding <ReadT61String>b__45_1() { }

		[Address(RVA = "0x2640510", Offset = "0x263F910", Length = "0xCF")]
		[Token(Token = "0x60006B3")]
		internal DateTimeFormatInfo <ReadTime>b__51_0() { }

	}

	[Token(Token = "0x2000115")]
	public enum DerTag : byte
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30,
	}

	[Token(Token = "0x40004D0")]
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; //Field offset: 0x0
	[Token(Token = "0x40004D1")]
	private static Encoding s_utf8EncodingWithExceptionFallback; //Field offset: 0x8
	[Token(Token = "0x40004D2")]
	private static Encoding s_latin1Encoding; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004D3")]
	private readonly Byte[] _data; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004D4")]
	private readonly int _end; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004D5")]
	private int _position; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004D6")]
	private int <ContentLength>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700010B")]
	private int ContentLength
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600068F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700010C")]
	internal bool HasData
	{
		[Address(RVA = "0x262F070", Offset = "0x262E470", Length = "0xA")]
		[Token(Token = "0x6000693")]
		internal get { } //Length: 10
	}

	[Address(RVA = "0x262F000", Offset = "0x262E400", Length = "0x30")]
	[Token(Token = "0x6000690")]
	internal DerSequenceReader(Byte[] data) { }

	[Address(RVA = "0x262F040", Offset = "0x262E440", Length = "0x24")]
	[Token(Token = "0x6000691")]
	internal DerSequenceReader(Byte[] data, int offset, int length) { }

	[Address(RVA = "0x262EE90", Offset = "0x262E290", Length = "0x16D")]
	[Token(Token = "0x6000692")]
	private DerSequenceReader(DerTag tagToEat, Byte[] data, int offset, int length) { }

	[Address(RVA = "0x262D480", Offset = "0x262C880", Length = "0x12D")]
	[Token(Token = "0x60006AC")]
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	[Address(RVA = "0x262D5B0", Offset = "0x262C9B0", Length = "0x36")]
	[Token(Token = "0x60006AD")]
	private int EatLength() { }

	[Address(RVA = "0x262D5F0", Offset = "0x262C9F0", Length = "0x7A")]
	[Token(Token = "0x60006AB")]
	private void EatTag(DerTag expected) { }

	[Address(RVA = "0x262F070", Offset = "0x262E470", Length = "0xA")]
	[Token(Token = "0x6000693")]
	internal bool get_HasData() { }

	[Address(RVA = "0x262D670", Offset = "0x262CA70", Length = "0xD3")]
	[Token(Token = "0x6000694")]
	internal byte PeekTag() { }

	[Address(RVA = "0x262D830", Offset = "0x262CC30", Length = "0x186")]
	[Token(Token = "0x600069A")]
	internal Byte[] ReadBitString() { }

	[Address(RVA = "0x262D750", Offset = "0x262CB50", Length = "0xD9")]
	[Token(Token = "0x60006A7")]
	internal string ReadBMPString() { }

	[Address(RVA = "0x262D9C0", Offset = "0x262CDC0", Length = "0xC2")]
	[Token(Token = "0x6000697")]
	internal bool ReadBoolean() { }

	[Address(RVA = "0x262DA90", Offset = "0x262CE90", Length = "0xD8")]
	[Token(Token = "0x600069E")]
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	[Address(RVA = "0x262DB70", Offset = "0x262CF70", Length = "0xA3")]
	[Token(Token = "0x60006AA")]
	private Byte[] ReadContentAsBytes() { }

	[Address(RVA = "0x262DC20", Offset = "0x262D020", Length = "0x3E")]
	[Token(Token = "0x60006A6")]
	internal DateTime ReadGeneralizedTime() { }

	[Address(RVA = "0x262DC60", Offset = "0x262D060", Length = "0xD9")]
	[Token(Token = "0x60006A2")]
	internal string ReadIA5String() { }

	[Address(RVA = "0x262DD70", Offset = "0x262D170", Length = "0xA4")]
	[Token(Token = "0x6000698")]
	internal int ReadInteger() { }

	[Address(RVA = "0x262DD40", Offset = "0x262D140", Length = "0x22")]
	[Token(Token = "0x6000699")]
	internal Byte[] ReadIntegerBytes() { }

	[Address(RVA = "0x262DE20", Offset = "0x262D220", Length = "0xAE")]
	[Token(Token = "0x6000696")]
	internal Byte[] ReadNextEncodedValue() { }

	[Address(RVA = "0x262DED0", Offset = "0x262D2D0", Length = "0x22")]
	[Token(Token = "0x600069B")]
	internal Byte[] ReadOctetString() { }

	[Address(RVA = "0x262DF00", Offset = "0x262D300", Length = "0x34C")]
	[Token(Token = "0x600069C")]
	internal string ReadOidAsString() { }

	[Address(RVA = "0x262E250", Offset = "0x262D650", Length = "0xD9")]
	[Token(Token = "0x60006A1")]
	internal string ReadPrintableString() { }

	[Address(RVA = "0x262E330", Offset = "0x262D730", Length = "0xA")]
	[Token(Token = "0x600069F")]
	internal DerSequenceReader ReadSequence() { }

	[Address(RVA = "0x262E340", Offset = "0x262D740", Length = "0xA")]
	[Token(Token = "0x60006A0")]
	internal DerSequenceReader ReadSet() { }

	[Address(RVA = "0x262E350", Offset = "0x262D750", Length = "0x312")]
	[Token(Token = "0x60006A3")]
	internal string ReadT61String() { }

	[Address(RVA = "0x262E670", Offset = "0x262DA70", Length = "0x258")]
	[Token(Token = "0x60006A9")]
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	[Address(RVA = "0x262E8D0", Offset = "0x262DCD0", Length = "0x3E")]
	[Token(Token = "0x60006A5")]
	internal DateTime ReadUtcTime() { }

	[Address(RVA = "0x262E910", Offset = "0x262DD10", Length = "0xD9")]
	[Token(Token = "0x600069D")]
	internal string ReadUtf8String() { }

	[Address(RVA = "0x262E9F0", Offset = "0x262DDF0", Length = "0xCA")]
	[Token(Token = "0x60006A4")]
	internal DateTime ReadX509Date() { }

	[Address(RVA = "0x262EAC0", Offset = "0x262DEC0", Length = "0x30A")]
	[Token(Token = "0x60006AE")]
	private static int ScanContentLength(Byte[] data, int offset, int end, out int bytesConsumed) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600068F")]
	private void set_ContentLength(int value) { }

	[Address(RVA = "0x262EDD0", Offset = "0x262E1D0", Length = "0x50")]
	[Token(Token = "0x6000695")]
	internal void SkipValue() { }

	[Address(RVA = "0x262EE20", Offset = "0x262E220", Length = "0x66")]
	[Token(Token = "0x60006A8")]
	private static string TrimTrailingNulls(string value) { }

}

