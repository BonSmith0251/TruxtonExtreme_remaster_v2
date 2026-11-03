namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[Token(Token = "0x20000AC")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035F")]
	internal Byte[] _rgbBuf; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000360")]
	private long _lCurLen; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000361")]
	internal Stream _stream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000362")]
	private SqlBytesCharsState _state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000363")]
	private Byte[] _rgbWorkBuf; //Field offset: 0x30

	[Token(Token = "0x1700015B")]
	public Byte[] Buffer
	{
		[Address(RVA = "0x238AF20", Offset = "0x238A320", Length = "0x18D")]
		[Token(Token = "0x60008EB")]
		 get { } //Length: 397
	}

	[Token(Token = "0x1700015A")]
	public override bool IsNull
	{
		[Address(RVA = "0x1D71780", Offset = "0x1D70B80", Length = "0x8")]
		[Token(Token = "0x60008EA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015C")]
	public long Length
	{
		[Address(RVA = "0x238B0B0", Offset = "0x238A4B0", Length = "0x81")]
		[Token(Token = "0x60008EC")]
		 get { } //Length: 129
	}

	[Token(Token = "0x1700015E")]
	public static SqlBytes Null
	{
		[Address(RVA = "0x238B140", Offset = "0x238A540", Length = "0x47")]
		[Token(Token = "0x60008F7")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700015D")]
	public Byte[] Value
	{
		[Address(RVA = "0x238B190", Offset = "0x238A590", Length = "0x235")]
		[Token(Token = "0x60008ED")]
		 get { } //Length: 565
	}

	[Address(RVA = "0x238ADC0", Offset = "0x238A1C0", Length = "0x38")]
	[Token(Token = "0x60008E7")]
	public SqlBytes() { }

	[Address(RVA = "0x238AE90", Offset = "0x238A290", Length = "0x80")]
	[Token(Token = "0x60008E8")]
	public SqlBytes(Byte[] buffer) { }

	[Address(RVA = "0x238AE00", Offset = "0x238A200", Length = "0x87")]
	[Token(Token = "0x60008E9")]
	public SqlBytes(SqlBinary value) { }

	[Address(RVA = "0x238A780", Offset = "0x2389B80", Length = "0x180")]
	[Token(Token = "0x60008EF")]
	private void CopyStreamToBuffer() { }

	[Address(RVA = "0x238A910", Offset = "0x2389D10", Length = "0x8")]
	[Token(Token = "0x60008F0")]
	internal bool FStream() { }

	[Address(RVA = "0x238AF20", Offset = "0x238A320", Length = "0x18D")]
	[Token(Token = "0x60008EB")]
	public Byte[] get_Buffer() { }

	[Address(RVA = "0x1D71780", Offset = "0x1D70B80", Length = "0x8")]
	[Token(Token = "0x60008EA")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x238B0B0", Offset = "0x238A4B0", Length = "0x81")]
	[Token(Token = "0x60008EC")]
	public long get_Length() { }

	[Address(RVA = "0x238B140", Offset = "0x238A540", Length = "0x47")]
	[Token(Token = "0x60008F7")]
	public static SqlBytes get_Null() { }

	[Address(RVA = "0x238B190", Offset = "0x238A590", Length = "0x235")]
	[Token(Token = "0x60008ED")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x238A920", Offset = "0x2389D20", Length = "0x6B")]
	[Token(Token = "0x60008F5")]
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x238A990", Offset = "0x2389D90", Length = "0x5C")]
	[Token(Token = "0x60008F1")]
	private void SetBuffer(Byte[] buffer) { }

	[Address(RVA = "0x238A9F0", Offset = "0x2389DF0", Length = "0x31")]
	[Token(Token = "0x60008EE")]
	public void SetNull() { }

	[Address(RVA = "0x238AA30", Offset = "0x2389E30", Length = "0x3E")]
	[Token(Token = "0x60008F6")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008F2")]
	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	[Address(RVA = "0x238AA70", Offset = "0x2389E70", Length = "0x1B7")]
	[Token(Token = "0x60008F3")]
	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	[Address(RVA = "0x238AC30", Offset = "0x238A030", Length = "0x189")]
	[Token(Token = "0x60008F4")]
	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

