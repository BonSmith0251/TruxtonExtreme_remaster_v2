namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000032")]
public class JsonSerializer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009F")]
	internal TypeNameHandling _typeNameHandling; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A0")]
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A1")]
	internal PreserveReferencesHandling _preserveReferencesHandling; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000A2")]
	internal ReferenceLoopHandling _referenceLoopHandling; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A3")]
	internal MissingMemberHandling _missingMemberHandling; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A4")]
	internal ObjectCreationHandling _objectCreationHandling; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A5")]
	internal NullValueHandling _nullValueHandling; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000A6")]
	internal DefaultValueHandling _defaultValueHandling; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A7")]
	internal ConstructorHandling _constructorHandling; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000A8")]
	internal MetadataPropertyHandling _metadataPropertyHandling; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Nullable(2)]
	[Token(Token = "0x40000A9")]
	internal JsonConverterCollection _converters; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AA")]
	internal IContractResolver _contractResolver; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Nullable(2)]
	[Token(Token = "0x40000AB")]
	internal ITraceWriter _traceWriter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Nullable(2)]
	[Token(Token = "0x40000AC")]
	internal IEqualityComparer _equalityComparer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000AD")]
	internal ISerializationBinder _serializationBinder; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000AE")]
	internal StreamingContext _context; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Nullable(2)]
	[Token(Token = "0x40000AF")]
	private IReferenceResolver _referenceResolver; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000B0")]
	private Nullable<Formatting> _formatting; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000B1")]
	private Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000B2")]
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000B3")]
	private Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000B4")]
	private Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000B5")]
	private Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000B6")]
	private Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000B7")]
	private CultureInfo _culture; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000B8")]
	private Nullable<Int32> _maxDepth; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000B9")]
	private bool _maxDepthSet; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC1")]
	[Token(Token = "0x40000BA")]
	private Nullable<Boolean> _checkAdditionalContent; //Field offset: 0xC1
	[FieldOffset(Offset = "0xC8")]
	[Nullable(2)]
	[Token(Token = "0x40000BB")]
	private string _dateFormatString; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000BC")]
	private bool _dateFormatStringSet; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x40000BD")]
	private EventHandler<ErrorEventArgs> Error; //Field offset: 0xD8

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x14000001")]
	public override event EventHandler<ErrorEventArgs> Error
	{
		[Address(RVA = "0x20D8280", Offset = "0x20D7680", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600014A")]
		 add { } //Length: 186
		[Address(RVA = "0x20D87C0", Offset = "0x20D7BC0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x600014B")]
		 remove { } //Length: 186
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	[Token(Token = "0x17000043")]
	public override SerializationBinder Binder
	{
		[Address(RVA = "0x20D8340", Offset = "0x20D7740", Length = "0xE1")]
		[Token(Token = "0x600014E")]
		 get { } //Length: 225
		[Address(RVA = "0x20D8880", Offset = "0x20D7C80", Length = "0xFA")]
		[Token(Token = "0x600014F")]
		 set { } //Length: 250
	}

	[Token(Token = "0x1700005F")]
	public override bool CheckAdditionalContent
	{
		[Address(RVA = "0x20D8430", Offset = "0x20D7830", Length = "0x3F")]
		[Token(Token = "0x6000185")]
		 get { } //Length: 63
		[Address(RVA = "0x20D8980", Offset = "0x20D7D80", Length = "0x5E")]
		[Token(Token = "0x6000186")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000050")]
	public override ConstructorHandling ConstructorHandling
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 4
		[Address(RVA = "0x20D89E0", Offset = "0x20D7DE0", Length = "0x63")]
		[Token(Token = "0x6000169")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000054")]
	public override StreamingContext Context
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[Token(Token = "0x600016F")]
		 get { } //Length: 11
		[Address(RVA = "0x20D8A50", Offset = "0x20D7E50", Length = "0x12")]
		[Token(Token = "0x6000170")]
		 set { } //Length: 18
	}

	[Token(Token = "0x17000053")]
	public override IContractResolver ContractResolver
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600016D")]
		 get { } //Length: 5
		[Address(RVA = "0x20D8A70", Offset = "0x20D7E70", Length = "0xAB")]
		[Token(Token = "0x600016E")]
		 set { } //Length: 171
	}

	[Token(Token = "0x17000052")]
	public override JsonConverterCollection Converters
	{
		[Address(RVA = "0x20D8480", Offset = "0x20D7880", Length = "0x8A")]
		[Token(Token = "0x600016C")]
		 get { } //Length: 138
	}

	[Token(Token = "0x1700005D")]
	public override CultureInfo Culture
	{
		[Address(RVA = "0x20D8510", Offset = "0x20D7910", Length = "0x61")]
		[Token(Token = "0x6000181")]
		 get { } //Length: 97
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[Token(Token = "0x6000182")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000056")]
	public override DateFormatHandling DateFormatHandling
	{
		[Address(RVA = "0x20D8580", Offset = "0x20D7980", Length = "0x3D")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 61
		[Address(RVA = "0x20D8B20", Offset = "0x20D7F20", Length = "0x5E")]
		[Token(Token = "0x6000174")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700005C")]
	public override string DateFormatString
	{
		[Address(RVA = "0x20D85C0", Offset = "0x20D79C0", Length = "0x40")]
		[Token(Token = "0x600017F")]
		 get { } //Length: 64
		[Address(RVA = "0x20D8B80", Offset = "0x20D7F80", Length = "0x29")]
		[Token(Token = "0x6000180")]
		 set { } //Length: 41
	}

	[Token(Token = "0x17000058")]
	public override DateParseHandling DateParseHandling
	{
		[Address(RVA = "0x20D8600", Offset = "0x20D7A00", Length = "0x51")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 81
		[Address(RVA = "0x20D8BB0", Offset = "0x20D7FB0", Length = "0x5E")]
		[Token(Token = "0x6000178")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000057")]
	public override DateTimeZoneHandling DateTimeZoneHandling
	{
		[Address(RVA = "0x20D8660", Offset = "0x20D7A60", Length = "0x51")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 81
		[Address(RVA = "0x20D8C10", Offset = "0x20D8010", Length = "0x5E")]
		[Token(Token = "0x6000176")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700004E")]
	public override DefaultValueHandling DefaultValueHandling
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 4
		[Address(RVA = "0x20D8C70", Offset = "0x20D8070", Length = "0x63")]
		[Token(Token = "0x6000165")]
		 set { } //Length: 99
	}

	[Nullable(2)]
	[Token(Token = "0x17000046")]
	public override IEqualityComparer EqualityComparer
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[NullableContext(2)]
		[Token(Token = "0x6000154")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[NullableContext(2)]
		[Token(Token = "0x6000155")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700005A")]
	public override FloatFormatHandling FloatFormatHandling
	{
		[Address(RVA = "0x20D86C0", Offset = "0x20D7AC0", Length = "0x3D")]
		[Token(Token = "0x600017B")]
		 get { } //Length: 61
		[Address(RVA = "0x20D8CE0", Offset = "0x20D80E0", Length = "0x5E")]
		[Token(Token = "0x600017C")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000059")]
	public override FloatParseHandling FloatParseHandling
	{
		[Address(RVA = "0x20D8700", Offset = "0x20D7B00", Length = "0x3D")]
		[Token(Token = "0x6000179")]
		 get { } //Length: 61
		[Address(RVA = "0x20D8D40", Offset = "0x20D8140", Length = "0x5E")]
		[Token(Token = "0x600017A")]
		 set { } //Length: 94
	}

	[Token(Token = "0x17000055")]
	public override Formatting Formatting
	{
		[Address(RVA = "0x20D8740", Offset = "0x20D7B40", Length = "0x37")]
		[Token(Token = "0x6000171")]
		 get { } //Length: 55
		[Address(RVA = "0x20D8DA0", Offset = "0x20D81A0", Length = "0x5B")]
		[Token(Token = "0x6000172")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700005E")]
	public override Nullable<Int32> MaxDepth
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 8
		[Address(RVA = "0x20D8E00", Offset = "0x20D8200", Length = "0xBB")]
		[Token(Token = "0x6000184")]
		 set { } //Length: 187
	}

	[Token(Token = "0x17000051")]
	public override MetadataPropertyHandling MetadataPropertyHandling
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x600016A")]
		 get { } //Length: 4
		[Address(RVA = "0x20D8EC0", Offset = "0x20D82C0", Length = "0x63")]
		[Token(Token = "0x600016B")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700004C")]
	public override MissingMemberHandling MissingMemberHandling
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 4
		[Address(RVA = "0x20D8F30", Offset = "0x20D8330", Length = "0x63")]
		[Token(Token = "0x6000161")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700004D")]
	public override NullValueHandling NullValueHandling
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 4
		[Address(RVA = "0x20D8FA0", Offset = "0x20D83A0", Length = "0x63")]
		[Token(Token = "0x6000163")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700004F")]
	public override ObjectCreationHandling ObjectCreationHandling
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 4
		[Address(RVA = "0x20D9010", Offset = "0x20D8410", Length = "0x63")]
		[Token(Token = "0x6000167")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700004A")]
	public override PreserveReferencesHandling PreserveReferencesHandling
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 4
		[Address(RVA = "0x20D9080", Offset = "0x20D8480", Length = "0x63")]
		[Token(Token = "0x600015D")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700004B")]
	public override ReferenceLoopHandling ReferenceLoopHandling
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 4
		[Address(RVA = "0x20D90F0", Offset = "0x20D84F0", Length = "0x63")]
		[Token(Token = "0x600015F")]
		 set { } //Length: 99
	}

	[Nullable(2)]
	[Token(Token = "0x17000042")]
	public override IReferenceResolver ReferenceResolver
	{
		[Address(RVA = "0x20D6E10", Offset = "0x20D6210", Length = "0x69")]
		[NullableContext(2)]
		[Token(Token = "0x600014C")]
		 get { } //Length: 105
		[Address(RVA = "0x20D9160", Offset = "0x20D8560", Length = "0x88")]
		[NullableContext(2)]
		[Token(Token = "0x600014D")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000044")]
	public override ISerializationBinder SerializationBinder
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000150")]
		 get { } //Length: 5
		[Address(RVA = "0x20D91F0", Offset = "0x20D85F0", Length = "0x88")]
		[Token(Token = "0x6000151")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700005B")]
	public override StringEscapeHandling StringEscapeHandling
	{
		[Address(RVA = "0x20D8780", Offset = "0x20D7B80", Length = "0x3D")]
		[Token(Token = "0x600017D")]
		 get { } //Length: 61
		[Address(RVA = "0x20D9280", Offset = "0x20D8680", Length = "0x5E")]
		[Token(Token = "0x600017E")]
		 set { } //Length: 94
	}

	[Nullable(2)]
	[Token(Token = "0x17000045")]
	public override ITraceWriter TraceWriter
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[NullableContext(2)]
		[Token(Token = "0x6000152")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[NullableContext(2)]
		[Token(Token = "0x6000153")]
		 set { } //Length: 13
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	[Token(Token = "0x17000048")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 4
		[Address(RVA = "0x20D9350", Offset = "0x20D8750", Length = "0x63")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000049")]
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 4
		[Address(RVA = "0x20D92E0", Offset = "0x20D86E0", Length = "0x63")]
		[Token(Token = "0x600015B")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000047")]
	public override TypeNameHandling TypeNameHandling
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 85
		[Address(RVA = "0x20D93C0", Offset = "0x20D87C0", Length = "0x63")]
		[Token(Token = "0x6000157")]
		 set { } //Length: 99
	}

	[Address(RVA = "0x20D8120", Offset = "0x20D7520", Length = "0x15A")]
	[Token(Token = "0x6000188")]
	public JsonSerializer() { }

	[Address(RVA = "0x20D8280", Offset = "0x20D7680", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600014A")]
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	[Address(RVA = "0x20D5960", Offset = "0x20D4D60", Length = "0x8FC")]
	[Token(Token = "0x600018D")]
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20D6720", Offset = "0x20D5B20", Length = "0x186")]
	[Token(Token = "0x6000189")]
	public static JsonSerializer Create() { }

	[Address(RVA = "0x20D6570", Offset = "0x20D5970", Length = "0x1A5")]
	[Token(Token = "0x600018A")]
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	[Address(RVA = "0x20D6260", Offset = "0x20D5660", Length = "0x236")]
	[Token(Token = "0x600018B")]
	public static JsonSerializer CreateDefault() { }

	[Address(RVA = "0x20D64A0", Offset = "0x20D58A0", Length = "0x38")]
	[Token(Token = "0x600018C")]
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	[Address(RVA = "0x20D64E0", Offset = "0x20D58E0", Length = "0x88")]
	[Token(Token = "0x600019C")]
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[Address(RVA = "0x84F580", Offset = "0x84E980", Length = "0xBE")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000193")]
	public T Deserialize(JsonReader reader) { }

	[Address(RVA = "0x20D6BA0", Offset = "0x20D5FA0", Length = "0x17")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000191")]
	public object Deserialize(JsonReader reader) { }

	[Address(RVA = "0x20D6BE0", Offset = "0x20D5FE0", Length = "0x87")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000192")]
	public object Deserialize(TextReader reader, Type objectType) { }

	[Address(RVA = "0x20D6BC0", Offset = "0x20D5FC0", Length = "0x14")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000194")]
	public object Deserialize(JsonReader reader, Type objectType) { }

	[Address(RVA = "0x20D68B0", Offset = "0x20D5CB0", Length = "0x2EE")]
	[NullableContext(2)]
	[Token(Token = "0x6000195")]
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	[Address(RVA = "0x20D8340", Offset = "0x20D7740", Length = "0xE1")]
	[Token(Token = "0x600014E")]
	public override SerializationBinder get_Binder() { }

	[Address(RVA = "0x20D8430", Offset = "0x20D7830", Length = "0x3F")]
	[Token(Token = "0x6000185")]
	public override bool get_CheckAdditionalContent() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000168")]
	public override ConstructorHandling get_ConstructorHandling() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[Token(Token = "0x600016F")]
	public override StreamingContext get_Context() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600016D")]
	public override IContractResolver get_ContractResolver() { }

	[Address(RVA = "0x20D8480", Offset = "0x20D7880", Length = "0x8A")]
	[Token(Token = "0x600016C")]
	public override JsonConverterCollection get_Converters() { }

	[Address(RVA = "0x20D8510", Offset = "0x20D7910", Length = "0x61")]
	[Token(Token = "0x6000181")]
	public override CultureInfo get_Culture() { }

	[Address(RVA = "0x20D8580", Offset = "0x20D7980", Length = "0x3D")]
	[Token(Token = "0x6000173")]
	public override DateFormatHandling get_DateFormatHandling() { }

	[Address(RVA = "0x20D85C0", Offset = "0x20D79C0", Length = "0x40")]
	[Token(Token = "0x600017F")]
	public override string get_DateFormatString() { }

	[Address(RVA = "0x20D8600", Offset = "0x20D7A00", Length = "0x51")]
	[Token(Token = "0x6000177")]
	public override DateParseHandling get_DateParseHandling() { }

	[Address(RVA = "0x20D8660", Offset = "0x20D7A60", Length = "0x51")]
	[Token(Token = "0x6000175")]
	public override DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000164")]
	public override DefaultValueHandling get_DefaultValueHandling() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[NullableContext(2)]
	[Token(Token = "0x6000154")]
	public override IEqualityComparer get_EqualityComparer() { }

	[Address(RVA = "0x20D86C0", Offset = "0x20D7AC0", Length = "0x3D")]
	[Token(Token = "0x600017B")]
	public override FloatFormatHandling get_FloatFormatHandling() { }

	[Address(RVA = "0x20D8700", Offset = "0x20D7B00", Length = "0x3D")]
	[Token(Token = "0x6000179")]
	public override FloatParseHandling get_FloatParseHandling() { }

	[Address(RVA = "0x20D8740", Offset = "0x20D7B40", Length = "0x37")]
	[Token(Token = "0x6000171")]
	public override Formatting get_Formatting() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000183")]
	public override Nullable<Int32> get_MaxDepth() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x600016A")]
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000160")]
	public override MissingMemberHandling get_MissingMemberHandling() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000162")]
	public override NullValueHandling get_NullValueHandling() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000166")]
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600015C")]
	public override PreserveReferencesHandling get_PreserveReferencesHandling() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600015E")]
	public override ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[Address(RVA = "0x20D6E10", Offset = "0x20D6210", Length = "0x69")]
	[NullableContext(2)]
	[Token(Token = "0x600014C")]
	public override IReferenceResolver get_ReferenceResolver() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000150")]
	public override ISerializationBinder get_SerializationBinder() { }

	[Address(RVA = "0x20D8780", Offset = "0x20D7B80", Length = "0x3D")]
	[Token(Token = "0x600017D")]
	public override StringEscapeHandling get_StringEscapeHandling() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[NullableContext(2)]
	[Token(Token = "0x6000152")]
	public override ITraceWriter get_TraceWriter() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000158")]
	public override FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600015A")]
	public override TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000156")]
	public override TypeNameHandling get_TypeNameHandling() { }

	[Address(RVA = "0x20D6C70", Offset = "0x20D6070", Length = "0xC3")]
	[Token(Token = "0x600019F")]
	internal JsonConverter GetMatchingConverter(Type type) { }

	[Address(RVA = "0x20D6D40", Offset = "0x20D6140", Length = "0xC4")]
	[Token(Token = "0x60001A0")]
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	[Address(RVA = "0x20D6E10", Offset = "0x20D6210", Length = "0x69")]
	[Token(Token = "0x600019E")]
	internal IReferenceResolver GetReferenceResolver() { }

	[Address(RVA = "0x20D6E80", Offset = "0x20D6280", Length = "0x3F")]
	[Token(Token = "0x6000187")]
	internal bool IsCheckAdditionalContentSet() { }

	[Address(RVA = "0x20D6EC0", Offset = "0x20D62C0", Length = "0x22")]
	[Token(Token = "0x60001A1")]
	internal void OnError(ErrorEventArgs e) { }

	[Address(RVA = "0x20D71D0", Offset = "0x20D65D0", Length = "0x14")]
	[DebuggerStepThrough]
	[Token(Token = "0x600018F")]
	public void Populate(JsonReader reader, object target) { }

	[Address(RVA = "0x20D71F0", Offset = "0x20D65F0", Length = "0x87")]
	[DebuggerStepThrough]
	[Token(Token = "0x600018E")]
	public void Populate(TextReader reader, object target) { }

	[Address(RVA = "0x20D6EF0", Offset = "0x20D62F0", Length = "0x2DF")]
	[Token(Token = "0x6000190")]
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[Address(RVA = "0x20D87C0", Offset = "0x20D7BC0", Length = "0xBA")]
	[CompilerGenerated]
	[Token(Token = "0x600014B")]
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[Address(RVA = "0x20D7280", Offset = "0x20D6680", Length = "0x2F9")]
	[NullableContext(2)]
	[Token(Token = "0x6000197")]
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<Int32> previousMaxDepth, string previousDateFormatString) { }

	[Address(RVA = "0x20D7BE0", Offset = "0x20D6FE0", Length = "0x90")]
	[Token(Token = "0x6000198")]
	public void Serialize(TextWriter textWriter, object value) { }

	[Address(RVA = "0x20D7BC0", Offset = "0x20D6FC0", Length = "0x19")]
	[NullableContext(2)]
	[Token(Token = "0x6000199")]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	[Address(RVA = "0x20D7B20", Offset = "0x20D6F20", Length = "0x9E")]
	[Token(Token = "0x600019A")]
	public void Serialize(TextWriter textWriter, object value, Type objectType) { }

	[Address(RVA = "0x20D7C70", Offset = "0x20D7070", Length = "0x25")]
	[Token(Token = "0x600019B")]
	public void Serialize(JsonWriter jsonWriter, object value) { }

	[Address(RVA = "0x20D7580", Offset = "0x20D6980", Length = "0x59D")]
	[NullableContext(2)]
	[Token(Token = "0x600019D")]
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	[Address(RVA = "0x20D8880", Offset = "0x20D7C80", Length = "0xFA")]
	[Token(Token = "0x600014F")]
	public override void set_Binder(SerializationBinder value) { }

	[Address(RVA = "0x20D8980", Offset = "0x20D7D80", Length = "0x5E")]
	[Token(Token = "0x6000186")]
	public override void set_CheckAdditionalContent(bool value) { }

	[Address(RVA = "0x20D89E0", Offset = "0x20D7DE0", Length = "0x63")]
	[Token(Token = "0x6000169")]
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	[Address(RVA = "0x20D8A50", Offset = "0x20D7E50", Length = "0x12")]
	[Token(Token = "0x6000170")]
	public override void set_Context(StreamingContext value) { }

	[Address(RVA = "0x20D8A70", Offset = "0x20D7E70", Length = "0xAB")]
	[Token(Token = "0x600016E")]
	public override void set_ContractResolver(IContractResolver value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6000182")]
	public override void set_Culture(CultureInfo value) { }

	[Address(RVA = "0x20D8B20", Offset = "0x20D7F20", Length = "0x5E")]
	[Token(Token = "0x6000174")]
	public override void set_DateFormatHandling(DateFormatHandling value) { }

	[Address(RVA = "0x20D8B80", Offset = "0x20D7F80", Length = "0x29")]
	[Token(Token = "0x6000180")]
	public override void set_DateFormatString(string value) { }

	[Address(RVA = "0x20D8BB0", Offset = "0x20D7FB0", Length = "0x5E")]
	[Token(Token = "0x6000178")]
	public override void set_DateParseHandling(DateParseHandling value) { }

	[Address(RVA = "0x20D8C10", Offset = "0x20D8010", Length = "0x5E")]
	[Token(Token = "0x6000176")]
	public override void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[Address(RVA = "0x20D8C70", Offset = "0x20D8070", Length = "0x63")]
	[Token(Token = "0x6000165")]
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[NullableContext(2)]
	[Token(Token = "0x6000155")]
	public override void set_EqualityComparer(IEqualityComparer value) { }

	[Address(RVA = "0x20D8CE0", Offset = "0x20D80E0", Length = "0x5E")]
	[Token(Token = "0x600017C")]
	public override void set_FloatFormatHandling(FloatFormatHandling value) { }

	[Address(RVA = "0x20D8D40", Offset = "0x20D8140", Length = "0x5E")]
	[Token(Token = "0x600017A")]
	public override void set_FloatParseHandling(FloatParseHandling value) { }

	[Address(RVA = "0x20D8DA0", Offset = "0x20D81A0", Length = "0x5B")]
	[Token(Token = "0x6000172")]
	public override void set_Formatting(Formatting value) { }

	[Address(RVA = "0x20D8E00", Offset = "0x20D8200", Length = "0xBB")]
	[Token(Token = "0x6000184")]
	public override void set_MaxDepth(Nullable<Int32> value) { }

	[Address(RVA = "0x20D8EC0", Offset = "0x20D82C0", Length = "0x63")]
	[Token(Token = "0x600016B")]
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	[Address(RVA = "0x20D8F30", Offset = "0x20D8330", Length = "0x63")]
	[Token(Token = "0x6000161")]
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	[Address(RVA = "0x20D8FA0", Offset = "0x20D83A0", Length = "0x63")]
	[Token(Token = "0x6000163")]
	public override void set_NullValueHandling(NullValueHandling value) { }

	[Address(RVA = "0x20D9010", Offset = "0x20D8410", Length = "0x63")]
	[Token(Token = "0x6000167")]
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[Address(RVA = "0x20D9080", Offset = "0x20D8480", Length = "0x63")]
	[Token(Token = "0x600015D")]
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	[Address(RVA = "0x20D90F0", Offset = "0x20D84F0", Length = "0x63")]
	[Token(Token = "0x600015F")]
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[Address(RVA = "0x20D9160", Offset = "0x20D8560", Length = "0x88")]
	[NullableContext(2)]
	[Token(Token = "0x600014D")]
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[Address(RVA = "0x20D91F0", Offset = "0x20D85F0", Length = "0x88")]
	[Token(Token = "0x6000151")]
	public override void set_SerializationBinder(ISerializationBinder value) { }

	[Address(RVA = "0x20D9280", Offset = "0x20D8680", Length = "0x5E")]
	[Token(Token = "0x600017E")]
	public override void set_StringEscapeHandling(StringEscapeHandling value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[NullableContext(2)]
	[Token(Token = "0x6000153")]
	public override void set_TraceWriter(ITraceWriter value) { }

	[Address(RVA = "0x20D9350", Offset = "0x20D8750", Length = "0x63")]
	[Token(Token = "0x6000159")]
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	[Address(RVA = "0x20D92E0", Offset = "0x20D86E0", Length = "0x63")]
	[Token(Token = "0x600015B")]
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	[Address(RVA = "0x20D93C0", Offset = "0x20D87C0", Length = "0x63")]
	[Token(Token = "0x6000157")]
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	[Address(RVA = "0x20D7CA0", Offset = "0x20D70A0", Length = "0x475")]
	[NullableContext(2)]
	[Token(Token = "0x6000196")]
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling>& previousDateTimeZoneHandling, out Nullable<DateParseHandling>& previousDateParseHandling, out Nullable<FloatParseHandling>& previousFloatParseHandling, out Nullable<Int32>& previousMaxDepth, out string previousDateFormatString) { }

}

