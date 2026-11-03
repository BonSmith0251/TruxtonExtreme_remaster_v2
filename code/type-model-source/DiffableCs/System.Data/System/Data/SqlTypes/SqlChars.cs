namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[Token(Token = "0x20000AD")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000364")]
	internal Char[] _rgchBuf; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000365")]
	private long _lCurLen; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000366")]
	internal SqlStreamChars _stream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000367")]
	private SqlBytesCharsState _state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000368")]
	private Char[] _rgchWorkBuf; //Field offset: 0x30

	[Token(Token = "0x17000160")]
	public Char[] Buffer
	{
		[Address(RVA = "0x238B990", Offset = "0x238AD90", Length = "0x18D")]
		[Token(Token = "0x60008FC")]
		 get { } //Length: 397
	}

	[Token(Token = "0x1700015F")]
	public override bool IsNull
	{
		[Address(RVA = "0x1D71780", Offset = "0x1D70B80", Length = "0x8")]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000161")]
	public long Length
	{
		[Address(RVA = "0x238BB20", Offset = "0x238AF20", Length = "0x81")]
		[Token(Token = "0x60008FD")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000163")]
	public static SqlChars Null
	{
		[Address(RVA = "0x238BBB0", Offset = "0x238AFB0", Length = "0x47")]
		[Token(Token = "0x6000908")]
		 get { } //Length: 71
	}

	[Token(Token = "0x17000162")]
	public Char[] Value
	{
		[Address(RVA = "0x238BC00", Offset = "0x238B000", Length = "0x235")]
		[Token(Token = "0x60008FE")]
		 get { } //Length: 565
	}

	[Address(RVA = "0x238ADC0", Offset = "0x238A1C0", Length = "0x38")]
	[Token(Token = "0x60008F8")]
	public SqlChars() { }

	[Address(RVA = "0x238AE90", Offset = "0x238A290", Length = "0x80")]
	[Token(Token = "0x60008F9")]
	public SqlChars(Char[] buffer) { }

	[Address(RVA = "0x238B8F0", Offset = "0x238ACF0", Length = "0x96")]
	[Token(Token = "0x60008FA")]
	public SqlChars(SqlString value) { }

	[Address(RVA = "0x238B3D0", Offset = "0x238A7D0", Length = "0x180")]
	[Token(Token = "0x6000901")]
	private void CopyStreamToBuffer() { }

	[Address(RVA = "0x238A910", Offset = "0x2389D10", Length = "0x8")]
	[Token(Token = "0x6000900")]
	internal bool FStream() { }

	[Address(RVA = "0x238B990", Offset = "0x238AD90", Length = "0x18D")]
	[Token(Token = "0x60008FC")]
	public Char[] get_Buffer() { }

	[Address(RVA = "0x1D71780", Offset = "0x1D70B80", Length = "0x8")]
	[Token(Token = "0x60008FB")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x238BB20", Offset = "0x238AF20", Length = "0x81")]
	[Token(Token = "0x60008FD")]
	public long get_Length() { }

	[Address(RVA = "0x238BBB0", Offset = "0x238AFB0", Length = "0x47")]
	[Token(Token = "0x6000908")]
	public static SqlChars get_Null() { }

	[Address(RVA = "0x238BC00", Offset = "0x238B000", Length = "0x235")]
	[Token(Token = "0x60008FE")]
	public Char[] get_Value() { }

	[Address(RVA = "0x238B560", Offset = "0x238A960", Length = "0x6B")]
	[Token(Token = "0x6000906")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x238A990", Offset = "0x2389D90", Length = "0x5C")]
	[Token(Token = "0x6000902")]
	private void SetBuffer(Char[] buffer) { }

	[Address(RVA = "0x238A9F0", Offset = "0x2389DF0", Length = "0x31")]
	[Token(Token = "0x60008FF")]
	public void SetNull() { }

	[Address(RVA = "0x238B5D0", Offset = "0x238A9D0", Length = "0x3E")]
	[Token(Token = "0x6000907")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000903")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x238B610", Offset = "0x238AA10", Length = "0x168")]
	[Token(Token = "0x6000904")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	[Address(RVA = "0x238B780", Offset = "0x238AB80", Length = "0x16E")]
	[Token(Token = "0x6000905")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

