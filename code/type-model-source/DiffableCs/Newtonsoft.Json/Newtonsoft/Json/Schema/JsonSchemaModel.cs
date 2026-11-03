namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000148")]
internal class JsonSchemaModel
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061E")]
	private bool <Required>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400061F")]
	private JsonSchemaType <Type>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000620")]
	private Nullable<Int32> <MinimumLength>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000621")]
	private Nullable<Int32> <MaximumLength>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000622")]
	private Nullable<Double> <DivisibleBy>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000623")]
	private Nullable<Double> <Minimum>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000624")]
	private Nullable<Double> <Maximum>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000625")]
	private bool <ExclusiveMinimum>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000626")]
	private bool <ExclusiveMaximum>k__BackingField; //Field offset: 0x59
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000627")]
	private Nullable<Int32> <MinimumItems>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000628")]
	private Nullable<Int32> <MaximumItems>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000629")]
	private IList<String> <Patterns>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400062A")]
	private IList<JsonSchemaModel> <Items>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400062B")]
	private IDictionary<String, JsonSchemaModel> <Properties>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400062C")]
	private IDictionary<String, JsonSchemaModel> <PatternProperties>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400062D")]
	private JsonSchemaModel <AdditionalProperties>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400062E")]
	private JsonSchemaModel <AdditionalItems>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400062F")]
	private bool <PositionalItemsValidation>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000630")]
	private bool <AllowAdditionalProperties>k__BackingField; //Field offset: 0xA1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000631")]
	private bool <AllowAdditionalItems>k__BackingField; //Field offset: 0xA2
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA3")]
	[Token(Token = "0x4000632")]
	private bool <UniqueItems>k__BackingField; //Field offset: 0xA3
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000633")]
	private IList<JToken> <Enum>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000634")]
	private JsonSchemaType <Disallow>k__BackingField; //Field offset: 0xB0

	[Token(Token = "0x170001B9")]
	public JsonSchemaModel AdditionalItems
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9B")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B8")]
	public JsonSchemaModel AdditionalProperties
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A99")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001BC")]
	public bool AllowAdditionalItems
	{
		[Address(RVA = "0x215EEE0", Offset = "0x215E2E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA1")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF40", Offset = "0x215E340", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA2")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001BB")]
	public bool AllowAdditionalProperties
	{
		[Address(RVA = "0x215EEF0", Offset = "0x215E2F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9F")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF50", Offset = "0x215E350", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA0")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001BF")]
	public JsonSchemaType Disallow
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA7")]
		 get { } //Length: 7
		[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA8")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001AD")]
	public Nullable<Double> DivisibleBy
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A83")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A84")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001BE")]
	public IList<JToken> Enum
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA5")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA6")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B1")]
	public bool ExclusiveMaximum
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8B")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001B0")]
	public bool ExclusiveMinimum
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A89")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001B5")]
	public IList<JsonSchemaModel> Items
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A93")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A94")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001AF")]
	public Nullable<Double> Maximum
	{
		[Address(RVA = "0x215EF10", Offset = "0x215E310", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A87")]
		 get { } //Length: 11
		[Address(RVA = "0x215EFA0", Offset = "0x215E3A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A88")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B3")]
	public Nullable<Int32> MaximumItems
	{
		[Address(RVA = "0x215EF00", Offset = "0x215E300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8F")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF80", Offset = "0x215E380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A90")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001AC")]
	public Nullable<Int32> MaximumLength
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A81")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A82")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001AE")]
	public Nullable<Double> Minimum
	{
		[Address(RVA = "0x215EF20", Offset = "0x215E320", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A85")]
		 get { } //Length: 11
		[Address(RVA = "0x215EFB0", Offset = "0x215E3B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A86")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170001B2")]
	public Nullable<Int32> MinimumItems
	{
		[Address(RVA = "0x1E52380", Offset = "0x1E51780", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8D")]
		 get { } //Length: 5
		[Address(RVA = "0x1E523C0", Offset = "0x1E517C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8E")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001AB")]
	public Nullable<Int32> MinimumLength
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7F")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A80")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001B7")]
	public IDictionary<String, JsonSchemaModel> PatternProperties
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A97")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A98")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001B4")]
	public IList<String> Patterns
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A91")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A92")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001BA")]
	public bool PositionalItemsValidation
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9D")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A9E")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001B6")]
	public IDictionary<String, JsonSchemaModel> Properties
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A95")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6000A96")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170001A9")]
	public bool Required
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7B")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001AA")]
	public JsonSchemaType Type
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7D")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001BD")]
	public bool UniqueItems
	{
		[Address(RVA = "0x215EF30", Offset = "0x215E330", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA3")]
		 get { } //Length: 8
		[Address(RVA = "0x215EFC0", Offset = "0x215E3C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA4")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x215EEB0", Offset = "0x215E2B0", Length = "0x2A")]
	[Token(Token = "0x6000AA9")]
	public JsonSchemaModel() { }

	[Address(RVA = "0x215E920", Offset = "0x215DD20", Length = "0x387")]
	[Token(Token = "0x6000AAB")]
	private static void Combine(JsonSchemaModel model, JsonSchema schema) { }

	[Address(RVA = "0x215ECB0", Offset = "0x215E0B0", Length = "0x1FB")]
	[Token(Token = "0x6000AAA")]
	public static JsonSchemaModel Create(IList<JsonSchema> schemata) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9B")]
	public JsonSchemaModel get_AdditionalItems() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A99")]
	public JsonSchemaModel get_AdditionalProperties() { }

	[Address(RVA = "0x215EEE0", Offset = "0x215E2E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA1")]
	public bool get_AllowAdditionalItems() { }

	[Address(RVA = "0x215EEF0", Offset = "0x215E2F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9F")]
	public bool get_AllowAdditionalProperties() { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA7")]
	public JsonSchemaType get_Disallow() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A83")]
	public Nullable<Double> get_DivisibleBy() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA5")]
	public IList<JToken> get_Enum() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8B")]
	public bool get_ExclusiveMaximum() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A89")]
	public bool get_ExclusiveMinimum() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A93")]
	public IList<JsonSchemaModel> get_Items() { }

	[Address(RVA = "0x215EF10", Offset = "0x215E310", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A87")]
	public Nullable<Double> get_Maximum() { }

	[Address(RVA = "0x215EF00", Offset = "0x215E300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8F")]
	public Nullable<Int32> get_MaximumItems() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A81")]
	public Nullable<Int32> get_MaximumLength() { }

	[Address(RVA = "0x215EF20", Offset = "0x215E320", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A85")]
	public Nullable<Double> get_Minimum() { }

	[Address(RVA = "0x1E52380", Offset = "0x1E51780", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8D")]
	public Nullable<Int32> get_MinimumItems() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7F")]
	public Nullable<Int32> get_MinimumLength() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A97")]
	public IDictionary<String, JsonSchemaModel> get_PatternProperties() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A91")]
	public IList<String> get_Patterns() { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9D")]
	public bool get_PositionalItemsValidation() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A95")]
	public IDictionary<String, JsonSchemaModel> get_Properties() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7B")]
	public bool get_Required() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7D")]
	public JsonSchemaType get_Type() { }

	[Address(RVA = "0x215EF30", Offset = "0x215E330", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA3")]
	public bool get_UniqueItems() { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9C")]
	public void set_AdditionalItems(JsonSchemaModel value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9A")]
	public void set_AdditionalProperties(JsonSchemaModel value) { }

	[Address(RVA = "0x215EF40", Offset = "0x215E340", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA2")]
	public void set_AllowAdditionalItems(bool value) { }

	[Address(RVA = "0x215EF50", Offset = "0x215E350", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA0")]
	public void set_AllowAdditionalProperties(bool value) { }

	[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA8")]
	public void set_Disallow(JsonSchemaType value) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A84")]
	public void set_DivisibleBy(Nullable<Double> value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA6")]
	public void set_Enum(IList<JToken> value) { }

	[Address(RVA = "0x1CEB130", Offset = "0x1CEA530", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8C")]
	public void set_ExclusiveMaximum(bool value) { }

	[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8A")]
	public void set_ExclusiveMinimum(bool value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A94")]
	public void set_Items(IList<JsonSchemaModel> value) { }

	[Address(RVA = "0x215EFA0", Offset = "0x215E3A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A88")]
	public void set_Maximum(Nullable<Double> value) { }

	[Address(RVA = "0x215EF80", Offset = "0x215E380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A90")]
	public void set_MaximumItems(Nullable<Int32> value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A82")]
	public void set_MaximumLength(Nullable<Int32> value) { }

	[Address(RVA = "0x215EFB0", Offset = "0x215E3B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A86")]
	public void set_Minimum(Nullable<Double> value) { }

	[Address(RVA = "0x1E523C0", Offset = "0x1E517C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8E")]
	public void set_MinimumItems(Nullable<Int32> value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A80")]
	public void set_MinimumLength(Nullable<Int32> value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A98")]
	public void set_PatternProperties(IDictionary<String, JsonSchemaModel> value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A92")]
	public void set_Patterns(IList<String> value) { }

	[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A9E")]
	public void set_PositionalItemsValidation(bool value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x6000A96")]
	public void set_Properties(IDictionary<String, JsonSchemaModel> value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7C")]
	public void set_Required(bool value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7E")]
	public void set_Type(JsonSchemaType value) { }

	[Address(RVA = "0x215EFC0", Offset = "0x215E3C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA4")]
	public void set_UniqueItems(bool value) { }

}

