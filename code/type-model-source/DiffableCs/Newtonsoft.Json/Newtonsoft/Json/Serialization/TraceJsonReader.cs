namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200013B")]
internal class TraceJsonReader : JsonReader, IJsonLineInfo
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005BF")]
	private readonly JsonReader _innerReader; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005C0")]
	private readonly JsonTextWriter _textWriter; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005C1")]
	private readonly StringWriter _sw; //Field offset: 0x88

	[Token(Token = "0x17000173")]
	public virtual int Depth
	{
		[Address(RVA = "0x2104AA0", Offset = "0x2103EA0", Length = "0x2A")]
		[Token(Token = "0x60009A7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000179")]
	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		[Address(RVA = "0x216D650", Offset = "0x216CA50", Length = "0x59")]
		[Token(Token = "0x60009B0")]
		private get { } //Length: 89
	}

	[Token(Token = "0x1700017A")]
	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		[Address(RVA = "0x216D6B0", Offset = "0x216CAB0", Length = "0x59")]
		[Token(Token = "0x60009B1")]
		private get { } //Length: 89
	}

	[Token(Token = "0x17000174")]
	public virtual string Path
	{
		[Address(RVA = "0x2104AD0", Offset = "0x2103ED0", Length = "0x2A")]
		[Token(Token = "0x60009A8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000175")]
	public private virtual char QuoteChar
	{
		[Address(RVA = "0x2104B00", Offset = "0x2103F00", Length = "0x2A")]
		[Token(Token = "0x60009A9")]
		 get { } //Length: 42
		[Address(RVA = "0x216DD70", Offset = "0x216D170", Length = "0x2A")]
		[Token(Token = "0x60009AA")]
		private set { } //Length: 42
	}

	[Token(Token = "0x17000176")]
	public virtual JsonToken TokenType
	{
		[Address(RVA = "0x2104B30", Offset = "0x2103F30", Length = "0x2A")]
		[Token(Token = "0x60009AB")]
		 get { } //Length: 42
	}

	[Nullable(2)]
	[Token(Token = "0x17000177")]
	public virtual object Value
	{
		[Address(RVA = "0x2104B90", Offset = "0x2103F90", Length = "0x2A")]
		[NullableContext(2)]
		[Token(Token = "0x60009AC")]
		 get { } //Length: 42
	}

	[Nullable(2)]
	[Token(Token = "0x17000178")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x2104B60", Offset = "0x2103F60", Length = "0x2A")]
		[NullableContext(2)]
		[Token(Token = "0x60009AD")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x216DC00", Offset = "0x216D000", Length = "0x167")]
	[Token(Token = "0x600099B")]
	public TraceJsonReader(JsonReader innerReader) { }

	[Address(RVA = "0x216D590", Offset = "0x216C990", Length = "0x2A")]
	[Token(Token = "0x60009AE")]
	public virtual void Close() { }

	[Address(RVA = "0x2104AA0", Offset = "0x2103EA0", Length = "0x2A")]
	[Token(Token = "0x60009A7")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2104AD0", Offset = "0x2103ED0", Length = "0x2A")]
	[Token(Token = "0x60009A8")]
	public virtual string get_Path() { }

	[Address(RVA = "0x2104B00", Offset = "0x2103F00", Length = "0x2A")]
	[Token(Token = "0x60009A9")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2104B30", Offset = "0x2103F30", Length = "0x2A")]
	[Token(Token = "0x60009AB")]
	public virtual JsonToken get_TokenType() { }

	[Address(RVA = "0x2104B90", Offset = "0x2103F90", Length = "0x2A")]
	[NullableContext(2)]
	[Token(Token = "0x60009AC")]
	public virtual object get_Value() { }

	[Address(RVA = "0x2104B60", Offset = "0x2103F60", Length = "0x2A")]
	[NullableContext(2)]
	[Token(Token = "0x60009AD")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x216D5C0", Offset = "0x216C9C0", Length = "0x2D")]
	[Token(Token = "0x600099C")]
	public string GetDeserializedJsonMessage() { }

	[Address(RVA = "0x216D650", Offset = "0x216CA50", Length = "0x59")]
	[Token(Token = "0x60009B0")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	[Address(RVA = "0x216D6B0", Offset = "0x216CAB0", Length = "0x59")]
	[Token(Token = "0x60009B1")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	[Address(RVA = "0x216D5F0", Offset = "0x216C9F0", Length = "0x56")]
	[Token(Token = "0x60009AF")]
	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[Address(RVA = "0x216DB30", Offset = "0x216CF30", Length = "0x74")]
	[Token(Token = "0x600099D")]
	public virtual bool Read() { }

	[Address(RVA = "0x216D710", Offset = "0x216CB10", Length = "0x73")]
	[Token(Token = "0x60009A3")]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[Address(RVA = "0x216D790", Offset = "0x216CB90", Length = "0x73")]
	[NullableContext(2)]
	[Token(Token = "0x60009A0")]
	public virtual Byte[] ReadAsBytes() { }

	[Address(RVA = "0x216D8A0", Offset = "0x216CCA0", Length = "0x7E")]
	[Token(Token = "0x60009A4")]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[Address(RVA = "0x216D810", Offset = "0x216CC10", Length = "0x88")]
	[Token(Token = "0x60009A5")]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[Address(RVA = "0x216D920", Offset = "0x216CD20", Length = "0x88")]
	[Token(Token = "0x60009A1")]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[Address(RVA = "0x216D9B0", Offset = "0x216CDB0", Length = "0x7E")]
	[Token(Token = "0x60009A2")]
	public virtual Nullable<Double> ReadAsDouble() { }

	[Address(RVA = "0x216DA30", Offset = "0x216CE30", Length = "0x73")]
	[Token(Token = "0x600099E")]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[Address(RVA = "0x216DAB0", Offset = "0x216CEB0", Length = "0x73")]
	[NullableContext(2)]
	[Token(Token = "0x600099F")]
	public virtual string ReadAsString() { }

	[Address(RVA = "0x216DD70", Offset = "0x216D170", Length = "0x2A")]
	[Token(Token = "0x60009AA")]
	protected private virtual void set_QuoteChar(char value) { }

	[Address(RVA = "0x216DBB0", Offset = "0x216CFB0", Length = "0x45")]
	[Token(Token = "0x60009A6")]
	public void WriteCurrentToken() { }

}

