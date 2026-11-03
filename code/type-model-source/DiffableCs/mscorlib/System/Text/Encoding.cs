namespace System.Text;

[ComVisible(True)]
[Token(Token = "0x20002C1")]
public abstract class Encoding : ICloneable
{
	[Token(Token = "0x20002C3")]
	public class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE7")]
		private Encoding m_encoding; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE8")]
		private bool m_hasInitializedEncoding; //Field offset: 0x28

		[Address(RVA = "0x1EA0160", Offset = "0x1E9F560", Length = "0x36")]
		[Token(Token = "0x600173F")]
		public DefaultDecoder(Encoding encoding) { }

		[Address(RVA = "0x1E9FEB0", Offset = "0x1E9F2B0", Length = "0x2AE")]
		[Token(Token = "0x6001740")]
		internal DefaultDecoder(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1E9FC90", Offset = "0x1E9F090", Length = "0x27")]
		[Token(Token = "0x6001743")]
		public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

		[Address(RVA = "0x1E9FC60", Offset = "0x1E9F060", Length = "0x2F")]
		[Token(Token = "0x6001744")]
		public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

		[Address(RVA = "0x1E9FCC0", Offset = "0x1E9F0C0", Length = "0x2A")]
		[Token(Token = "0x6001745")]
		public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

		[Address(RVA = "0x1E9FCF0", Offset = "0x1E9F0F0", Length = "0x39")]
		[Token(Token = "0x6001746")]
		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

		[Address(RVA = "0x1E9FD60", Offset = "0x1E9F160", Length = "0x32")]
		[Token(Token = "0x6001747")]
		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

		[Address(RVA = "0x1E9FD30", Offset = "0x1E9F130", Length = "0x2F")]
		[Token(Token = "0x6001748")]
		public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

		[Address(RVA = "0x1E9FDA0", Offset = "0x1E9F1A0", Length = "0x6C")]
		[Token(Token = "0x6001741")]
		public override object GetRealObject(StreamingContext context) { }

		[Address(RVA = "0x1E9FE10", Offset = "0x1E9F210", Length = "0x99")]
		[Token(Token = "0x6001742")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x20002C2")]
	public class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE4")]
		private Encoding m_encoding; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE5")]
		private bool m_hasInitializedEncoding; //Field offset: 0x28
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x4000BE6")]
		internal char charLeftOver; //Field offset: 0x2A

		[Address(RVA = "0x1EA0160", Offset = "0x1E9F560", Length = "0x36")]
		[Token(Token = "0x6001737")]
		public DefaultEncoder(Encoding encoding) { }

		[Address(RVA = "0x1EA03E0", Offset = "0x1E9F7E0", Length = "0x2FE")]
		[Token(Token = "0x6001738")]
		internal DefaultEncoder(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1EA01D0", Offset = "0x1E9F5D0", Length = "0x2F")]
		[Token(Token = "0x600173B")]
		public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

		[Address(RVA = "0x1EA01A0", Offset = "0x1E9F5A0", Length = "0x2A")]
		[Token(Token = "0x600173C")]
		public virtual int GetByteCount(Char* chars, int count, bool flush) { }

		[Address(RVA = "0x1EA0200", Offset = "0x1E9F600", Length = "0x32")]
		[Token(Token = "0x600173D")]
		public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

		[Address(RVA = "0x1EA0240", Offset = "0x1E9F640", Length = "0x2F")]
		[Token(Token = "0x600173E")]
		public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

		[Address(RVA = "0x1EA0270", Offset = "0x1E9F670", Length = "0xCF")]
		[Token(Token = "0x6001739")]
		public override object GetRealObject(StreamingContext context) { }

		[Address(RVA = "0x1EA0340", Offset = "0x1E9F740", Length = "0x99")]
		[Token(Token = "0x600173A")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x20002C5")]
	public class EncodingByteBuffer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BF3")]
		private Byte* bytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BF4")]
		private Byte* byteStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BF5")]
		private Byte* byteEnd; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BF6")]
		private Char* chars; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BF7")]
		private Char* charStart; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BF8")]
		private Char* charEnd; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BF9")]
		private int byteCountResult; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BFA")]
		private Encoding enc; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BFB")]
		private EncoderNLS encoder; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BFC")]
		internal EncoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		[Token(Token = "0x1700024B")]
		internal int CharsUsed
		{
			[Address(RVA = "0x1EA0C90", Offset = "0x1EA0090", Length = "0x11")]
			[Token(Token = "0x600175B")]
			internal get { } //Length: 17
		}

		[Token(Token = "0x1700024C")]
		internal int Count
		{
			[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
			[Token(Token = "0x600175C")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x1700024A")]
		internal bool MoreData
		{
			[Address(RVA = "0x1EA0CB0", Offset = "0x1EA00B0", Length = "0x47")]
			[Token(Token = "0x6001759")]
			internal get { } //Length: 71
		}

		[Address(RVA = "0x1EA0A10", Offset = "0x1E9FE10", Length = "0x277")]
		[Token(Token = "0x6001753")]
		internal EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, Byte* inByteStart, int inByteCount, Char* inCharStart, int inCharCount) { }

		[Address(RVA = "0x1EA07A0", Offset = "0x1E9FBA0", Length = "0x11E")]
		[Token(Token = "0x6001754")]
		internal bool AddByte(byte b, int moreBytesExpected) { }

		[Address(RVA = "0x1EA0790", Offset = "0x1E9FB90", Length = "0xB")]
		[Token(Token = "0x6001755")]
		internal bool AddByte(byte b1) { }

		[Address(RVA = "0x1EA0740", Offset = "0x1E9FB40", Length = "0x4A")]
		[Token(Token = "0x6001756")]
		internal bool AddByte(byte b1, byte b2) { }

		[Address(RVA = "0x1EA06E0", Offset = "0x1E9FAE0", Length = "0x5A")]
		[Token(Token = "0x6001757")]
		internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

		[Address(RVA = "0x1EA0C90", Offset = "0x1EA0090", Length = "0x11")]
		[Token(Token = "0x600175B")]
		internal int get_CharsUsed() { }

		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x600175C")]
		internal int get_Count() { }

		[Address(RVA = "0x1EA0CB0", Offset = "0x1EA00B0", Length = "0x47")]
		[Token(Token = "0x6001759")]
		internal bool get_MoreData() { }

		[Address(RVA = "0x1EA08C0", Offset = "0x1E9FCC0", Length = "0x42")]
		[Token(Token = "0x600175A")]
		internal char GetNextChar() { }

		[Address(RVA = "0x1EA0910", Offset = "0x1E9FD10", Length = "0xF6")]
		[Token(Token = "0x6001758")]
		internal void MovePrevious(bool bThrow) { }

	}

	[Token(Token = "0x20002C4")]
	public class EncodingCharBuffer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BE9")]
		private Char* chars; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BEA")]
		private Char* charStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BEB")]
		private Char* charEnd; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BEC")]
		private int charCountResult; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BED")]
		private Encoding enc; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BEE")]
		private DecoderNLS decoder; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BEF")]
		private Byte* byteStart; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BF0")]
		private Byte* byteEnd; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BF1")]
		private Byte* bytes; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BF2")]
		private DecoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		[Token(Token = "0x17000248")]
		internal int BytesUsed
		{
			[Address(RVA = "0x1EA11D0", Offset = "0x1EA05D0", Length = "0x7")]
			[Token(Token = "0x600174F")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x17000249")]
		internal int Count
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[Token(Token = "0x6001752")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x17000247")]
		internal bool MoreData
		{
			[Address(RVA = "0x1EA11E0", Offset = "0x1EA05E0", Length = "0xC")]
			[Token(Token = "0x600174D")]
			internal get { } //Length: 12
		}

		[Address(RVA = "0x1EA10E0", Offset = "0x1EA04E0", Length = "0xEF")]
		[Token(Token = "0x6001749")]
		internal EncodingCharBuffer(Encoding enc, DecoderNLS decoder, Char* charStart, int charCount, Byte* byteStart, int byteCount) { }

		[Address(RVA = "0x1EA0D00", Offset = "0x1EA0100", Length = "0xE4")]
		[Token(Token = "0x600174A")]
		internal bool AddChar(char ch, int numBytes) { }

		[Address(RVA = "0x1EA0DF0", Offset = "0x1EA01F0", Length = "0xDF")]
		[Token(Token = "0x600174B")]
		internal bool AddChar(char ch) { }

		[Address(RVA = "0x1EA0ED0", Offset = "0x1EA02D0", Length = "0x8")]
		[Token(Token = "0x600174C")]
		internal void AdjustBytes(int count) { }

		[Address(RVA = "0x1EA0EE0", Offset = "0x1EA02E0", Length = "0x6E")]
		[Token(Token = "0x6001750")]
		internal bool Fallback(byte fallbackByte) { }

		[Address(RVA = "0x1EA0F50", Offset = "0x1EA0350", Length = "0x16C")]
		[Token(Token = "0x6001751")]
		internal bool Fallback(Byte[] byteBuffer) { }

		[Address(RVA = "0x1EA11D0", Offset = "0x1EA05D0", Length = "0x7")]
		[Token(Token = "0x600174F")]
		internal int get_BytesUsed() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6001752")]
		internal int get_Count() { }

		[Address(RVA = "0x1EA11E0", Offset = "0x1EA05E0", Length = "0xC")]
		[Token(Token = "0x600174D")]
		internal bool get_MoreData() { }

		[Address(RVA = "0x1EA10C0", Offset = "0x1EA04C0", Length = "0x1D")]
		[Token(Token = "0x600174E")]
		internal byte GetNextByte() { }

	}

	[Token(Token = "0x4000BD4")]
	private static Encoding defaultEncoding; //Field offset: 0x0
	[Token(Token = "0x4000BD5")]
	private static Encoding unicodeEncoding; //Field offset: 0x8
	[Token(Token = "0x4000BD6")]
	private static Encoding bigEndianUnicode; //Field offset: 0x10
	[Token(Token = "0x4000BD7")]
	private static Encoding utf7Encoding; //Field offset: 0x18
	[Token(Token = "0x4000BD8")]
	private static Encoding utf8Encoding; //Field offset: 0x20
	[Token(Token = "0x4000BD9")]
	private static Encoding utf32Encoding; //Field offset: 0x28
	[Token(Token = "0x4000BDA")]
	private static Encoding asciiEncoding; //Field offset: 0x30
	[Token(Token = "0x4000BDB")]
	private static Encoding latin1Encoding; //Field offset: 0x38
	[Token(Token = "0x4000BDC")]
	private static Dictionary<Int32, Encoding> encodings; //Field offset: 0x40
	[Token(Token = "0x4000BE3")]
	private static object s_InternalSyncObject; //Field offset: 0x48
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BDD")]
	internal int m_codePage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BDE")]
	internal CodePageDataItem dataItem; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BDF")]
	internal bool m_deserializedFromEverett; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE0")]
	private bool m_isReadOnly; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE1")]
	internal EncoderFallback encoderFallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE2")]
	internal DecoderFallback decoderFallback; //Field offset: 0x30

	[Token(Token = "0x1700023E")]
	public static Encoding ASCII
	{
		[Address(RVA = "0x1EA49A0", Offset = "0x1EA3DA0", Length = "0xB4")]
		[Token(Token = "0x600170A")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000243")]
	public static Encoding BigEndianUnicode
	{
		[Address(RVA = "0x1EA4A60", Offset = "0x1EA3E60", Length = "0xC8")]
		[Token(Token = "0x600172A")]
		 get { } //Length: 200
	}

	[Token(Token = "0x17000240")]
	public override int CodePage
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600171F")]
		 get { } //Length: 85
	}

	[ComVisible(False)]
	[Token(Token = "0x1700023C")]
	public DecoderFallback DecoderFallback
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001706")]
		 get { } //Length: 5
		[Address(RVA = "0x1EA5250", Offset = "0x1EA4650", Length = "0xCA")]
		[Token(Token = "0x6001707")]
		 set { } //Length: 202
	}

	[Token(Token = "0x17000241")]
	public static Encoding Default
	{
		[Address(RVA = "0x1EA4B30", Offset = "0x1EA3F30", Length = "0xD0")]
		[Token(Token = "0x6001723")]
		 get { } //Length: 208
	}

	[ComVisible(False)]
	[Token(Token = "0x1700023B")]
	public EncoderFallback EncoderFallback
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001704")]
		 get { } //Length: 5
		[Address(RVA = "0x1EA5320", Offset = "0x1EA4720", Length = "0xCA")]
		[Token(Token = "0x6001705")]
		 set { } //Length: 202
	}

	[Token(Token = "0x17000239")]
	public override string EncodingName
	{
		[Address(RVA = "0x1EA4C10", Offset = "0x1EA4010", Length = "0xA")]
		[Token(Token = "0x6001702")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000237")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x1EA4C20", Offset = "0x1EA4020", Length = "0x98")]
		[Token(Token = "0x60016FB")]
		private get { } //Length: 152
	}

	[ComVisible(False)]
	[Token(Token = "0x1700023D")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x6001709")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700023F")]
	private static Encoding Latin1
	{
		[Address(RVA = "0x1EA4CC0", Offset = "0x1EA40C0", Length = "0xB4")]
		[Token(Token = "0x600170B")]
		private get { } //Length: 180
	}

	[Token(Token = "0x17000238")]
	public override ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x1EA4D80", Offset = "0x1EA4180", Length = "0x6C")]
		[Token(Token = "0x6001700")]
		 get { } //Length: 108
	}

	[Token(Token = "0x17000242")]
	public static Encoding Unicode
	{
		[Address(RVA = "0x1EA5030", Offset = "0x1EA4430", Length = "0xC8")]
		[Token(Token = "0x6001729")]
		 get { } //Length: 200
	}

	[Token(Token = "0x17000246")]
	public static Encoding UTF32
	{
		[Address(RVA = "0x1EA4DF0", Offset = "0x1EA41F0", Length = "0xBA")]
		[Token(Token = "0x600172D")]
		 get { } //Length: 186
	}

	[Token(Token = "0x17000244")]
	public static Encoding UTF7
	{
		[Address(RVA = "0x1EA4EB0", Offset = "0x1EA42B0", Length = "0xB4")]
		[Token(Token = "0x600172B")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000245")]
	public static Encoding UTF8
	{
		[Address(RVA = "0x1EA4F70", Offset = "0x1EA4370", Length = "0xB7")]
		[Token(Token = "0x600172C")]
		 get { } //Length: 183
	}

	[Token(Token = "0x1700023A")]
	public override string WebName
	{
		[Address(RVA = "0x1EA5100", Offset = "0x1EA4500", Length = "0x13F")]
		[Token(Token = "0x6001703")]
		 get { } //Length: 319
	}

	[Address(RVA = "0x1EA48D0", Offset = "0x1EA3CD0", Length = "0x37")]
	[Token(Token = "0x60016F1")]
	protected Encoding() { }

	[Address(RVA = "0x1EA4910", Offset = "0x1EA3D10", Length = "0x8A")]
	[Token(Token = "0x60016F2")]
	protected Encoding(int codePage) { }

	[Address(RVA = "0x1EA1B10", Offset = "0x1EA0F10", Length = "0x7B")]
	[ComVisible(False)]
	[Token(Token = "0x6001708")]
	public override object Clone() { }

	[Address(RVA = "0x1EA1B90", Offset = "0x1EA0F90", Length = "0x4F")]
	[Token(Token = "0x6001721")]
	private static Encoding CreateDefaultEncoding() { }

	[Address(RVA = "0x1EA1BE0", Offset = "0x1EA0FE0", Length = "0x38F")]
	[Token(Token = "0x60016F9")]
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EA1F70", Offset = "0x1EA1370", Length = "0xC9")]
	[Token(Token = "0x600172E")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1EA49A0", Offset = "0x1EA3DA0", Length = "0xB4")]
	[Token(Token = "0x600170A")]
	public static Encoding get_ASCII() { }

	[Address(RVA = "0x1EA4A60", Offset = "0x1EA3E60", Length = "0xC8")]
	[Token(Token = "0x600172A")]
	public static Encoding get_BigEndianUnicode() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600171F")]
	public override int get_CodePage() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001706")]
	public DecoderFallback get_DecoderFallback() { }

	[Address(RVA = "0x1EA4B30", Offset = "0x1EA3F30", Length = "0xD0")]
	[Token(Token = "0x6001723")]
	public static Encoding get_Default() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001704")]
	public EncoderFallback get_EncoderFallback() { }

	[Address(RVA = "0x1EA4C10", Offset = "0x1EA4010", Length = "0xA")]
	[Token(Token = "0x6001702")]
	public override string get_EncodingName() { }

	[Address(RVA = "0x1EA4C20", Offset = "0x1EA4020", Length = "0x98")]
	[Token(Token = "0x60016FB")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x6001709")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x1EA4CC0", Offset = "0x1EA40C0", Length = "0xB4")]
	[Token(Token = "0x600170B")]
	private static Encoding get_Latin1() { }

	[Address(RVA = "0x1EA4D80", Offset = "0x1EA4180", Length = "0x6C")]
	[Token(Token = "0x6001700")]
	public override ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x1EA5030", Offset = "0x1EA4430", Length = "0xC8")]
	[Token(Token = "0x6001729")]
	public static Encoding get_Unicode() { }

	[Address(RVA = "0x1EA4DF0", Offset = "0x1EA41F0", Length = "0xBA")]
	[Token(Token = "0x600172D")]
	public static Encoding get_UTF32() { }

	[Address(RVA = "0x1EA4EB0", Offset = "0x1EA42B0", Length = "0xB4")]
	[Token(Token = "0x600172B")]
	public static Encoding get_UTF7() { }

	[Address(RVA = "0x1EA4F70", Offset = "0x1EA4370", Length = "0xB7")]
	[Token(Token = "0x600172C")]
	public static Encoding get_UTF8() { }

	[Address(RVA = "0x1EA5100", Offset = "0x1EA4500", Length = "0x13F")]
	[Token(Token = "0x6001703")]
	public override string get_WebName() { }

	[Address(RVA = "0x1EA2040", Offset = "0x1EA1440", Length = "0x4E")]
	[Token(Token = "0x6001731")]
	internal override Char[] GetBestFitBytesToUnicodeData() { }

	[Address(RVA = "0x1EA2090", Offset = "0x1EA1490", Length = "0x4E")]
	[Token(Token = "0x6001730")]
	internal override Char[] GetBestFitUnicodeToBytesData() { }

	[Address(RVA = "0x1EA2320", Offset = "0x1EA1720", Length = "0x14")]
	[Token(Token = "0x600170F")]
	internal override int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[Address(RVA = "0x1EA2180", Offset = "0x1EA1580", Length = "0x198")]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x600170E")]
	public override int GetByteCount(Char* chars, int count) { }

	[Token(Token = "0x600170D")]
	public abstract int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1EA2340", Offset = "0x1EA1740", Length = "0x9F")]
	[Token(Token = "0x6001736")]
	public override int GetByteCount(ReadOnlySpan<Char> chars) { }

	[Address(RVA = "0x1EA20E0", Offset = "0x1EA14E0", Length = "0x9A")]
	[Token(Token = "0x600170C")]
	public override int GetByteCount(string s) { }

	[Address(RVA = "0x1EA2850", Offset = "0x1EA1C50", Length = "0xA9")]
	[Token(Token = "0x6001713")]
	public override int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1EA2650", Offset = "0x1EA1A50", Length = "0xC8")]
	[Token(Token = "0x6001710")]
	public override Byte[] GetBytes(Char[] chars, int index, int count) { }

	[Token(Token = "0x6001711")]
	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1EA2740", Offset = "0x1EA1B40", Length = "0x10A")]
	[Token(Token = "0x6001712")]
	public override Byte[] GetBytes(string s) { }

	[Address(RVA = "0x1EA2720", Offset = "0x1EA1B20", Length = "0x19")]
	[Token(Token = "0x6001714")]
	internal override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x1EA23E0", Offset = "0x1EA17E0", Length = "0x263")]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x6001715")]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1EA2AA0", Offset = "0x1EA1EA0", Length = "0x14")]
	[Token(Token = "0x6001718")]
	internal override int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	[Address(RVA = "0x1EA2900", Offset = "0x1EA1D00", Length = "0x19A")]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x6001717")]
	public override int GetCharCount(Byte* bytes, int count) { }

	[Token(Token = "0x6001716")]
	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1EA2AC0", Offset = "0x1EA1EC0", Length = "0xC8")]
	[Token(Token = "0x6001719")]
	public override Char[] GetChars(Byte[] bytes, int index, int count) { }

	[Token(Token = "0x600171A")]
	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1EA2BB0", Offset = "0x1EA1FB0", Length = "0x264")]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x600171B")]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1EA2B90", Offset = "0x1EA1F90", Length = "0x19")]
	[Token(Token = "0x600171C")]
	internal override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[Address(RVA = "0x1EA2E20", Offset = "0x1EA2220", Length = "0x124")]
	[Token(Token = "0x6001701")]
	private void GetDataItem() { }

	[Address(RVA = "0x1EA2F50", Offset = "0x1EA2350", Length = "0x64")]
	[Token(Token = "0x6001720")]
	public override Decoder GetDecoder() { }

	[Address(RVA = "0x1EA2FC0", Offset = "0x1EA23C0", Length = "0x64")]
	[Token(Token = "0x6001724")]
	public override Encoder GetEncoder() { }

	[Address(RVA = "0x1EA3330", Offset = "0x1EA2730", Length = "0xB84")]
	[Token(Token = "0x60016FC")]
	public static Encoding GetEncoding(int codepage) { }

	[Address(RVA = "0x1EA3030", Offset = "0x1EA2430", Length = "0x26E")]
	[Token(Token = "0x60016FD")]
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	[Address(RVA = "0x1EA32A0", Offset = "0x1EA26A0", Length = "0x87")]
	[Token(Token = "0x60016FE")]
	public static Encoding GetEncoding(string name) { }

	[Address(RVA = "0x1EA3EC0", Offset = "0x1EA32C0", Length = "0x69")]
	[Token(Token = "0x600172F")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6001725")]
	public abstract int GetMaxByteCount(int charCount) { }

	[Token(Token = "0x6001726")]
	public abstract int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1EA3F30", Offset = "0x1EA3330", Length = "0x4E")]
	[Token(Token = "0x60016FF")]
	public override Byte[] GetPreamble() { }

	[Address(RVA = "0x1EA4130", Offset = "0x1EA3530", Length = "0x168")]
	[Token(Token = "0x600171E")]
	public string GetString(ReadOnlySpan<Byte> bytes) { }

	[Address(RVA = "0x1EA4030", Offset = "0x1EA3430", Length = "0xFC")]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x600171D")]
	public string GetString(Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1EA3F80", Offset = "0x1EA3380", Length = "0xA6")]
	[Token(Token = "0x6001727")]
	public override string GetString(Byte[] bytes) { }

	[Address(RVA = "0x1EA42A0", Offset = "0x1EA36A0", Length = "0x2E")]
	[Token(Token = "0x6001728")]
	public override string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1EA42D0", Offset = "0x1EA36D0", Length = "0x46")]
	[Token(Token = "0x60016F5")]
	internal void OnDeserialized() { }

	[Address(RVA = "0x1EA42D0", Offset = "0x1EA36D0", Length = "0x46")]
	[OnDeserialized]
	[Token(Token = "0x60016F7")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1EA4320", Offset = "0x1EA3720", Length = "0x39")]
	[Token(Token = "0x60016F4")]
	internal void OnDeserializing() { }

	[Address(RVA = "0x1EA4320", Offset = "0x1EA3720", Length = "0x39")]
	[OnDeserializing]
	[Token(Token = "0x60016F6")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0xB0D5E0", Offset = "0xB0C9E0", Length = "0x13")]
	[OnSerializing]
	[Token(Token = "0x60016F8")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x1EA4360", Offset = "0x1EA3760", Length = "0x168")]
	[Token(Token = "0x60016FA")]
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EA5250", Offset = "0x1EA4650", Length = "0xCA")]
	[Token(Token = "0x6001707")]
	public void set_DecoderFallback(DecoderFallback value) { }

	[Address(RVA = "0x1EA5320", Offset = "0x1EA4720", Length = "0xCA")]
	[Token(Token = "0x6001705")]
	public void set_EncoderFallback(EncoderFallback value) { }

	[Address(RVA = "0x1EA44D0", Offset = "0x1EA38D0", Length = "0x99")]
	[Token(Token = "0x60016F3")]
	internal override void SetDefaultFallbacks() { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[Token(Token = "0x6001722")]
	internal void setReadOnly(bool value = true) { }

	[Address(RVA = "0x1EA4570", Offset = "0x1EA3970", Length = "0x10B")]
	[Token(Token = "0x6001732")]
	internal void ThrowBytesOverflow() { }

	[Address(RVA = "0x1EA4680", Offset = "0x1EA3A80", Length = "0x93")]
	[Token(Token = "0x6001733")]
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	[Address(RVA = "0x1EA4830", Offset = "0x1EA3C30", Length = "0x93")]
	[Token(Token = "0x6001735")]
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

	[Address(RVA = "0x1EA4720", Offset = "0x1EA3B20", Length = "0x10B")]
	[Token(Token = "0x6001734")]
	internal void ThrowCharsOverflow() { }

}

