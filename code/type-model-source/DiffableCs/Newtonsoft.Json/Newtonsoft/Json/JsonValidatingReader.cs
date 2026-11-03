namespace Newtonsoft.Json;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000073")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000076")]
	private sealed class <>c
	{
		[Token(Token = "0x40002C6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002C7")]
		public static Func<JsonSchemaModel, Boolean> <>9__50_0; //Field offset: 0x8
		[Token(Token = "0x40002C8")]
		public static Func<JsonSchemaModel, Boolean> <>9__50_1; //Field offset: 0x10
		[Token(Token = "0x40002C9")]
		public static Func<JsonSchemaModel, Boolean> <>9__50_2; //Field offset: 0x18
		[Token(Token = "0x40002CA")]
		public static Func<Boolean, Boolean> <>9__51_0; //Field offset: 0x20
		[Token(Token = "0x40002CB")]
		public static Func<KeyValuePair`2<String, Boolean>, Boolean> <>9__51_1; //Field offset: 0x28
		[Token(Token = "0x40002CC")]
		public static Func<KeyValuePair`2<String, Boolean>, String> <>9__51_2; //Field offset: 0x30

		[Address(RVA = "0x2115A70", Offset = "0x2114E70", Length = "0x67")]
		[Token(Token = "0x60003E5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60003E6")]
		public <>c() { }

		[Address(RVA = "0x21159A0", Offset = "0x2114DA0", Length = "0x7")]
		[Token(Token = "0x60003EA")]
		internal bool <ValidateEndObject>b__51_0(bool v) { }

		[Address(RVA = "0x21159B0", Offset = "0x2114DB0", Length = "0x32")]
		[Token(Token = "0x60003EB")]
		internal bool <ValidateEndObject>b__51_1(KeyValuePair<String, Boolean> kv) { }

		[Address(RVA = "0x21159F0", Offset = "0x2114DF0", Length = "0x37")]
		[Token(Token = "0x60003EC")]
		internal string <ValidateEndObject>b__51_2(KeyValuePair<String, Boolean> kv) { }

		[Address(RVA = "0x2115A30", Offset = "0x2114E30", Length = "0x1E")]
		[Token(Token = "0x60003E7")]
		internal bool <WriteToken>b__50_0(JsonSchemaModel s) { }

		[Address(RVA = "0x2115A50", Offset = "0x2114E50", Length = "0x1A")]
		[Token(Token = "0x60003E8")]
		internal bool <WriteToken>b__50_1(JsonSchemaModel s) { }

		[Address(RVA = "0x2115A30", Offset = "0x2114E30", Length = "0x1E")]
		[Token(Token = "0x60003E9")]
		internal bool <WriteToken>b__50_2(JsonSchemaModel s) { }

	}

	[Token(Token = "0x2000074")]
	private class SchemaScope
	{
		[CompilerGenerated]
		[Token(Token = "0x2000075")]
		private sealed class <>c
		{
			[Token(Token = "0x40002C0")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40002C1")]
			public static Func<String, String> <>9__27_0; //Field offset: 0x8
			[Token(Token = "0x40002C2")]
			public static Func<String, Boolean> <>9__27_1; //Field offset: 0x10
			[Token(Token = "0x40002C3")]
			public static Func<JsonSchemaModel, Boolean> <>9__27_2; //Field offset: 0x18
			[Token(Token = "0x40002C4")]
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, Boolean> <>9__28_0; //Field offset: 0x20
			[Token(Token = "0x40002C5")]
			public static Func<KeyValuePair`2<String, JsonSchemaModel>, String> <>9__28_1; //Field offset: 0x28

			[Address(RVA = "0x2115AE0", Offset = "0x2114EE0", Length = "0x67")]
			[Token(Token = "0x60003DE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003DF")]
			public <>c() { }

			[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
			[Token(Token = "0x60003E0")]
			internal string <.ctor>b__27_0(string p) { }

			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60003E1")]
			internal bool <.ctor>b__27_1(string p) { }

			[Address(RVA = "0x2115A50", Offset = "0x2114E50", Length = "0x1A")]
			[Token(Token = "0x60003E2")]
			internal bool <.ctor>b__27_2(JsonSchemaModel s) { }

			[Address(RVA = "0x2115920", Offset = "0x2114D20", Length = "0x3D")]
			[Token(Token = "0x60003E3")]
			internal bool <GetRequiredProperties>b__28_0(KeyValuePair<String, JsonSchemaModel> p) { }

			[Address(RVA = "0x2115960", Offset = "0x2114D60", Length = "0x37")]
			[Token(Token = "0x60003E4")]
			internal string <GetRequiredProperties>b__28_1(KeyValuePair<String, JsonSchemaModel> p) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002B8")]
		private readonly JTokenType _tokenType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002B9")]
		private readonly IList<JsonSchemaModel> _schemas; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002BA")]
		private readonly Dictionary<String, Boolean> _requiredProperties; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002BB")]
		private string <CurrentPropertyName>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002BC")]
		private int <ArrayItemCount>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40002BD")]
		private readonly bool <IsUniqueArray>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002BE")]
		private readonly IList<JToken> <UniqueArrayItems>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40002BF")]
		private JTokenWriter <CurrentItemWriter>k__BackingField; //Field offset: 0x40

		[Token(Token = "0x17000097")]
		public int ArrayItemCount
		{
			[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60003D3")]
			 get { } //Length: 4
			[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60003D4")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700009A")]
		public JTokenWriter CurrentItemWriter
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60003D7")]
			 get { } //Length: 5
			[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60003D8")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000096")]
		public string CurrentPropertyName
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60003D1")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60003D2")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000098")]
		public bool IsUniqueArray
		{
			[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60003D5")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700009C")]
		public Dictionary<String, Boolean> RequiredProperties
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60003DA")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700009B")]
		public IList<JsonSchemaModel> Schemas
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60003D9")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700009D")]
		public JTokenType TokenType
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x60003DB")]
			 get { } //Length: 85
		}

		[Token(Token = "0x17000099")]
		public IList<JToken> UniqueArrayItems
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60003D6")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2110450", Offset = "0x210F850", Length = "0x3C5")]
		[Token(Token = "0x60003DC")]
		public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas) { }

		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003D3")]
		public int get_ArrayItemCount() { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D7")]
		public JTokenWriter get_CurrentItemWriter() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D1")]
		public string get_CurrentPropertyName() { }

		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D5")]
		public bool get_IsUniqueArray() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60003DA")]
		public Dictionary<String, Boolean> get_RequiredProperties() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60003D9")]
		public IList<JsonSchemaModel> get_Schemas() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60003DB")]
		public JTokenType get_TokenType() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60003D6")]
		public IList<JToken> get_UniqueArrayItems() { }

		[Address(RVA = "0x21101D0", Offset = "0x210F5D0", Length = "0x27A")]
		[Token(Token = "0x60003DD")]
		private IEnumerable<String> GetRequiredProperties(JsonSchemaModel schema) { }

		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60003D4")]
		public void set_ArrayItemCount(int value) { }

		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003D8")]
		public void set_CurrentItemWriter(JTokenWriter value) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60003D2")]
		public void set_CurrentPropertyName(string value) { }

	}

	[Token(Token = "0x40002B7")]
	private static readonly IList<JsonSchemaModel> EmptySchemaList; //Field offset: 0x0
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002B1")]
	private readonly JsonReader _reader; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002B2")]
	private readonly Stack<SchemaScope> _stack; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002B3")]
	private JsonSchema _schema; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002B4")]
	private JsonSchemaModel _model; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002B5")]
	private SchemaScope _currentScope; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002B6")]
	private ValidationEventHandler ValidationEventHandler; //Field offset: 0xA0

	[Token(Token = "0x14000002")]
	public event ValidationEventHandler ValidationEventHandler
	{
		[Address(RVA = "0x2104000", Offset = "0x2103400", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600039D")]
		 add { } //Length: 162
		[Address(RVA = "0x2104BC0", Offset = "0x2103FC0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x600039E")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x17000091")]
	private IList<JsonSchemaModel> CurrentMemberSchemas
	{
		[Address(RVA = "0x21040B0", Offset = "0x21034B0", Length = "0x9C4")]
		[Token(Token = "0x60003A9")]
		private get { } //Length: 2500
	}

	[Token(Token = "0x17000090")]
	private IList<JsonSchemaModel> CurrentSchemas
	{
		[Address(RVA = "0x2104A80", Offset = "0x2103E80", Length = "0x1E")]
		[Token(Token = "0x60003A8")]
		private get { } //Length: 30
	}

	[Token(Token = "0x1700008B")]
	public virtual int Depth
	{
		[Address(RVA = "0x2104AA0", Offset = "0x2103EA0", Length = "0x2A")]
		[Token(Token = "0x60003A0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000094")]
	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		[Address(RVA = "0x21001B0", Offset = "0x20FF5B0", Length = "0x59")]
		[Token(Token = "0x60003CE")]
		private get { } //Length: 89
	}

	[Token(Token = "0x17000095")]
	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		[Address(RVA = "0x2100210", Offset = "0x20FF610", Length = "0x59")]
		[Token(Token = "0x60003CF")]
		private get { } //Length: 89
	}

	[Token(Token = "0x1700008C")]
	public virtual string Path
	{
		[Address(RVA = "0x2104AD0", Offset = "0x2103ED0", Length = "0x2A")]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700008D")]
	public private virtual char QuoteChar
	{
		[Address(RVA = "0x2104B00", Offset = "0x2103F00", Length = "0x2A")]
		[Token(Token = "0x60003A2")]
		 get { } //Length: 42
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60003A3")]
		private set { } //Length: 3
	}

	[Token(Token = "0x17000093")]
	public JsonReader Reader
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000092")]
	public JsonSchema Schema
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60003AD")]
		 get { } //Length: 8
		[Address(RVA = "0x2104C70", Offset = "0x2104070", Length = "0xA8")]
		[Token(Token = "0x60003AE")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700008E")]
	public virtual JsonToken TokenType
	{
		[Address(RVA = "0x2104B30", Offset = "0x2103F30", Length = "0x2A")]
		[Token(Token = "0x60003A4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700008A")]
	public virtual object Value
	{
		[Address(RVA = "0x2104B90", Offset = "0x2103F90", Length = "0x2A")]
		[Token(Token = "0x600039F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700008F")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x2104B60", Offset = "0x2103F60", Length = "0x2A")]
		[Token(Token = "0x60003A5")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2103EC0", Offset = "0x21032C0", Length = "0x84")]
	[Token(Token = "0x60003D0")]
	private static JsonValidatingReader() { }

	[Address(RVA = "0x2103F50", Offset = "0x2103350", Length = "0xAE")]
	[Token(Token = "0x60003AC")]
	public JsonValidatingReader(JsonReader reader) { }

	[Address(RVA = "0x2104000", Offset = "0x2103400", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600039D")]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x20FFC00", Offset = "0x20FF000", Length = "0x3E")]
	[Token(Token = "0x60003B0")]
	public virtual void Close() { }

	[Address(RVA = "0x20FFC40", Offset = "0x20FF040", Length = "0x6B")]
	[Token(Token = "0x60003C6")]
	private static double FloatingPointRemainder(double dividend, double divisor) { }

	[Address(RVA = "0x21040B0", Offset = "0x21034B0", Length = "0x9C4")]
	[Token(Token = "0x60003A9")]
	private IList<JsonSchemaModel> get_CurrentMemberSchemas() { }

	[Address(RVA = "0x2104A80", Offset = "0x2103E80", Length = "0x1E")]
	[Token(Token = "0x60003A8")]
	private IList<JsonSchemaModel> get_CurrentSchemas() { }

	[Address(RVA = "0x2104AA0", Offset = "0x2103EA0", Length = "0x2A")]
	[Token(Token = "0x60003A0")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2104AD0", Offset = "0x2103ED0", Length = "0x2A")]
	[Token(Token = "0x60003A1")]
	public virtual string get_Path() { }

	[Address(RVA = "0x2104B00", Offset = "0x2103F00", Length = "0x2A")]
	[Token(Token = "0x60003A2")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60003AF")]
	public JsonReader get_Reader() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60003AD")]
	public JsonSchema get_Schema() { }

	[Address(RVA = "0x2104B30", Offset = "0x2103F30", Length = "0x2A")]
	[Token(Token = "0x60003A4")]
	public virtual JsonToken get_TokenType() { }

	[Address(RVA = "0x2104B90", Offset = "0x2103F90", Length = "0x2A")]
	[Token(Token = "0x600039F")]
	public virtual object get_Value() { }

	[Address(RVA = "0x2104B60", Offset = "0x2103F60", Length = "0x2A")]
	[Token(Token = "0x60003A5")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x20FFCB0", Offset = "0x20FF0B0", Length = "0x5C")]
	[Token(Token = "0x60003B2")]
	private Nullable<JsonSchemaType> GetCurrentNodeSchemaType() { }

	[Address(RVA = "0x20FFE80", Offset = "0x20FF280", Length = "0x26E")]
	[Token(Token = "0x60003C9")]
	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName) { }

	[Address(RVA = "0x21000F0", Offset = "0x20FF4F0", Length = "0x5D")]
	[Token(Token = "0x60003C7")]
	private static bool IsZero(double value) { }

	[Address(RVA = "0x21001B0", Offset = "0x20FF5B0", Length = "0x59")]
	[Token(Token = "0x60003CE")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	[Address(RVA = "0x2100210", Offset = "0x20FF610", Length = "0x59")]
	[Token(Token = "0x60003CF")]
	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	[Address(RVA = "0x2100150", Offset = "0x20FF550", Length = "0x56")]
	[Token(Token = "0x60003CD")]
	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[Address(RVA = "0x2100270", Offset = "0x20FF670", Length = "0x9F")]
	[Token(Token = "0x60003AB")]
	private void OnValidationEvent(JsonSchemaException exception) { }

	[Address(RVA = "0x2100310", Offset = "0x20FF710", Length = "0xA8")]
	[Token(Token = "0x60003A7")]
	private SchemaScope Pop() { }

	[Address(RVA = "0x21003C0", Offset = "0x20FF7C0", Length = "0x2D6")]
	[Token(Token = "0x60003C4")]
	private void ProcessValue() { }

	[Address(RVA = "0x21006A0", Offset = "0x20FFAA0", Length = "0x6C")]
	[Token(Token = "0x60003A6")]
	private void Push(SchemaScope scope) { }

	[Address(RVA = "0x2100710", Offset = "0x20FFB10", Length = "0x23C")]
	[Token(Token = "0x60003AA")]
	private void RaiseError(string message, JsonSchemaModel schema) { }

	[Address(RVA = "0x2100C10", Offset = "0x2100010", Length = "0x69")]
	[Token(Token = "0x60003BB")]
	public virtual bool Read() { }

	[Address(RVA = "0x2100950", Offset = "0x20FFD50", Length = "0x4A")]
	[Token(Token = "0x60003B7")]
	public virtual Nullable<Boolean> ReadAsBoolean() { }

	[Address(RVA = "0x21009A0", Offset = "0x20FFDA0", Length = "0x4A")]
	[Token(Token = "0x60003B4")]
	public virtual Byte[] ReadAsBytes() { }

	[Address(RVA = "0x2100A50", Offset = "0x20FFE50", Length = "0x54")]
	[Token(Token = "0x60003B9")]
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	[Address(RVA = "0x21009F0", Offset = "0x20FFDF0", Length = "0x5E")]
	[Token(Token = "0x60003BA")]
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	[Address(RVA = "0x2100AB0", Offset = "0x20FFEB0", Length = "0x5E")]
	[Token(Token = "0x60003B5")]
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	[Address(RVA = "0x2100B10", Offset = "0x20FFF10", Length = "0x54")]
	[Token(Token = "0x60003B6")]
	public virtual Nullable<Double> ReadAsDouble() { }

	[Address(RVA = "0x2100B70", Offset = "0x20FFF70", Length = "0x4A")]
	[Token(Token = "0x60003B3")]
	public virtual Nullable<Int32> ReadAsInt32() { }

	[Address(RVA = "0x2100BC0", Offset = "0x20FFFC0", Length = "0x4A")]
	[Token(Token = "0x60003B8")]
	public virtual string ReadAsString() { }

	[Address(RVA = "0x2104BC0", Offset = "0x2103FC0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x600039E")]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003A3")]
	protected private virtual void set_QuoteChar(char value) { }

	[Address(RVA = "0x2104C70", Offset = "0x2104070", Length = "0xA8")]
	[Token(Token = "0x60003AE")]
	public void set_Schema(JsonSchema value) { }

	[Address(RVA = "0x2100C80", Offset = "0x2100080", Length = "0x138")]
	[Token(Token = "0x60003CC")]
	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType) { }

	[Address(RVA = "0x2100DC0", Offset = "0x21001C0", Length = "0x16")]
	[Token(Token = "0x60003CA")]
	private bool ValidateArray(JsonSchemaModel schema) { }

	[Address(RVA = "0x2100DE0", Offset = "0x21001E0", Length = "0x40")]
	[Token(Token = "0x60003C1")]
	private void ValidateBoolean(JsonSchemaModel schema) { }

	[Address(RVA = "0x2100E20", Offset = "0x2100220", Length = "0xCC0")]
	[Token(Token = "0x60003BC")]
	private void ValidateCurrentToken() { }

	[Address(RVA = "0x2101B30", Offset = "0x2100F30", Length = "0x1F1")]
	[Token(Token = "0x60003BF")]
	private void ValidateEndArray(JsonSchemaModel schema) { }

	[Address(RVA = "0x2101D30", Offset = "0x2101130", Length = "0x3AD")]
	[Token(Token = "0x60003BE")]
	private void ValidateEndObject(JsonSchemaModel schema) { }

	[Address(RVA = "0x21020E0", Offset = "0x21014E0", Length = "0x581")]
	[Token(Token = "0x60003C5")]
	private void ValidateFloat(JsonSchemaModel schema) { }

	[Address(RVA = "0x2102670", Offset = "0x2101A70", Length = "0x6DD")]
	[Token(Token = "0x60003C3")]
	private void ValidateInteger(JsonSchemaModel schema) { }

	[Address(RVA = "0x2102D50", Offset = "0x2102150", Length = "0x288")]
	[Token(Token = "0x60003B1")]
	private void ValidateNotDisallowed(JsonSchemaModel schema) { }

	[Address(RVA = "0x2103010", Offset = "0x2102410", Length = "0x40")]
	[Token(Token = "0x60003C0")]
	private void ValidateNull(JsonSchemaModel schema) { }

	[Address(RVA = "0x2103050", Offset = "0x2102450", Length = "0x16")]
	[Token(Token = "0x60003CB")]
	private bool ValidateObject(JsonSchemaModel schema) { }

	[Address(RVA = "0x2103070", Offset = "0x2102470", Length = "0x1CC")]
	[Token(Token = "0x60003C8")]
	private void ValidatePropertyName(JsonSchemaModel schema) { }

	[Address(RVA = "0x2103240", Offset = "0x2102640", Length = "0x3C7")]
	[Token(Token = "0x60003C2")]
	private void ValidateString(JsonSchemaModel schema) { }

	[Address(RVA = "0x2103610", Offset = "0x2102A10", Length = "0x8A9")]
	[Token(Token = "0x60003BD")]
	private void WriteToken(IList<JsonSchemaModel> schemas) { }

}

