namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200012D")]
internal class JsonSerializerProxy : JsonSerializer
{
	[FieldOffset(Offset = "0xE0")]
	[Nullable(2)]
	[Token(Token = "0x40005A2")]
	private readonly JsonSerializerInternalReader _serializerReader; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Nullable(2)]
	[Token(Token = "0x40005A3")]
	private readonly JsonSerializerInternalWriter _serializerWriter; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40005A4")]
	internal readonly JsonSerializer _serializer; //Field offset: 0xF0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x14000003")]
	public virtual event EventHandler<ErrorEventArgs> Error
	{
		[Address(RVA = "0x216A5A0", Offset = "0x21699A0", Length = "0x2D")]
		[Token(Token = "0x6000913")]
		 add { } //Length: 45
		[Address(RVA = "0x216AB90", Offset = "0x2169F90", Length = "0x2D")]
		[Token(Token = "0x6000914")]
		 remove { } //Length: 45
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	[Token(Token = "0x1700015E")]
	public virtual SerializationBinder Binder
	{
		[Address(RVA = "0x216A5D0", Offset = "0x21699D0", Length = "0x2D")]
		[Token(Token = "0x6000934")]
		 get { } //Length: 45
		[Address(RVA = "0x216ABC0", Offset = "0x2169FC0", Length = "0x2D")]
		[Token(Token = "0x6000935")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700016B")]
	public virtual bool CheckAdditionalContent
	{
		[Address(RVA = "0x216A600", Offset = "0x2169A00", Length = "0x2D")]
		[Token(Token = "0x600094E")]
		 get { } //Length: 45
		[Address(RVA = "0x216ABF0", Offset = "0x2169FF0", Length = "0x2D")]
		[Token(Token = "0x600094F")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700015D")]
	public virtual ConstructorHandling ConstructorHandling
	{
		[Address(RVA = "0x216A630", Offset = "0x2169A30", Length = "0x2D")]
		[Token(Token = "0x6000932")]
		 get { } //Length: 45
		[Address(RVA = "0x216AC20", Offset = "0x216A020", Length = "0x2D")]
		[Token(Token = "0x6000933")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000160")]
	public virtual StreamingContext Context
	{
		[Address(RVA = "0x216A660", Offset = "0x2169A60", Length = "0x41")]
		[Token(Token = "0x6000938")]
		 get { } //Length: 65
		[Address(RVA = "0x216AC50", Offset = "0x216A050", Length = "0x3A")]
		[Token(Token = "0x6000939")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000153")]
	public virtual IContractResolver ContractResolver
	{
		[Address(RVA = "0x216A6B0", Offset = "0x2169AB0", Length = "0x2D")]
		[Token(Token = "0x600091E")]
		 get { } //Length: 45
		[Address(RVA = "0x216AC90", Offset = "0x216A090", Length = "0x2D")]
		[Token(Token = "0x600091F")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000151")]
	public virtual JsonConverterCollection Converters
	{
		[Address(RVA = "0x216A6E0", Offset = "0x2169AE0", Length = "0x2D")]
		[Token(Token = "0x600091B")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000169")]
	public virtual CultureInfo Culture
	{
		[Address(RVA = "0x216A710", Offset = "0x2169B10", Length = "0x2D")]
		[Token(Token = "0x600094A")]
		 get { } //Length: 45
		[Address(RVA = "0x216ACC0", Offset = "0x216A0C0", Length = "0x2D")]
		[Token(Token = "0x600094B")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000162")]
	public virtual DateFormatHandling DateFormatHandling
	{
		[Address(RVA = "0x216A740", Offset = "0x2169B40", Length = "0x2D")]
		[Token(Token = "0x600093C")]
		 get { } //Length: 45
		[Address(RVA = "0x216ACF0", Offset = "0x216A0F0", Length = "0x2D")]
		[Token(Token = "0x600093D")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000168")]
	public virtual string DateFormatString
	{
		[Address(RVA = "0x216A770", Offset = "0x2169B70", Length = "0x2D")]
		[Token(Token = "0x6000948")]
		 get { } //Length: 45
		[Address(RVA = "0x216AD20", Offset = "0x216A120", Length = "0x2D")]
		[Token(Token = "0x6000949")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000164")]
	public virtual DateParseHandling DateParseHandling
	{
		[Address(RVA = "0x216A7A0", Offset = "0x2169BA0", Length = "0x2D")]
		[Token(Token = "0x6000940")]
		 get { } //Length: 45
		[Address(RVA = "0x216AD50", Offset = "0x216A150", Length = "0x2D")]
		[Token(Token = "0x6000941")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000163")]
	public virtual DateTimeZoneHandling DateTimeZoneHandling
	{
		[Address(RVA = "0x216A7D0", Offset = "0x2169BD0", Length = "0x2D")]
		[Token(Token = "0x600093E")]
		 get { } //Length: 45
		[Address(RVA = "0x216AD80", Offset = "0x216A180", Length = "0x2D")]
		[Token(Token = "0x600093F")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000152")]
	public virtual DefaultValueHandling DefaultValueHandling
	{
		[Address(RVA = "0x216A800", Offset = "0x2169C00", Length = "0x2D")]
		[Token(Token = "0x600091C")]
		 get { } //Length: 45
		[Address(RVA = "0x216ADB0", Offset = "0x216A1B0", Length = "0x2D")]
		[Token(Token = "0x600091D")]
		 set { } //Length: 45
	}

	[Nullable(2)]
	[Token(Token = "0x17000150")]
	public virtual IEqualityComparer EqualityComparer
	{
		[Address(RVA = "0x216A830", Offset = "0x2169C30", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x6000919")]
		 get { } //Length: 45
		[Address(RVA = "0x216ADE0", Offset = "0x216A1E0", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x600091A")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000165")]
	public virtual FloatFormatHandling FloatFormatHandling
	{
		[Address(RVA = "0x216A860", Offset = "0x2169C60", Length = "0x2D")]
		[Token(Token = "0x6000942")]
		 get { } //Length: 45
		[Address(RVA = "0x216AE10", Offset = "0x216A210", Length = "0x2D")]
		[Token(Token = "0x6000943")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000166")]
	public virtual FloatParseHandling FloatParseHandling
	{
		[Address(RVA = "0x216A890", Offset = "0x2169C90", Length = "0x2D")]
		[Token(Token = "0x6000944")]
		 get { } //Length: 45
		[Address(RVA = "0x216AE40", Offset = "0x216A240", Length = "0x2D")]
		[Token(Token = "0x6000945")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000161")]
	public virtual Formatting Formatting
	{
		[Address(RVA = "0x216A8C0", Offset = "0x2169CC0", Length = "0x2D")]
		[Token(Token = "0x600093A")]
		 get { } //Length: 45
		[Address(RVA = "0x216AE70", Offset = "0x216A270", Length = "0x2D")]
		[Token(Token = "0x600093B")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700016A")]
	public virtual Nullable<Int32> MaxDepth
	{
		[Address(RVA = "0x216A8F0", Offset = "0x2169CF0", Length = "0x2D")]
		[Token(Token = "0x600094C")]
		 get { } //Length: 45
		[Address(RVA = "0x216AEA0", Offset = "0x216A2A0", Length = "0x2D")]
		[Token(Token = "0x600094D")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700015A")]
	public virtual MetadataPropertyHandling MetadataPropertyHandling
	{
		[Address(RVA = "0x216A920", Offset = "0x2169D20", Length = "0x2D")]
		[Token(Token = "0x600092C")]
		 get { } //Length: 45
		[Address(RVA = "0x216AED0", Offset = "0x216A2D0", Length = "0x2D")]
		[Token(Token = "0x600092D")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000154")]
	public virtual MissingMemberHandling MissingMemberHandling
	{
		[Address(RVA = "0x216A950", Offset = "0x2169D50", Length = "0x2D")]
		[Token(Token = "0x6000920")]
		 get { } //Length: 45
		[Address(RVA = "0x216AF00", Offset = "0x216A300", Length = "0x2D")]
		[Token(Token = "0x6000921")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000155")]
	public virtual NullValueHandling NullValueHandling
	{
		[Address(RVA = "0x216A980", Offset = "0x2169D80", Length = "0x2D")]
		[Token(Token = "0x6000922")]
		 get { } //Length: 45
		[Address(RVA = "0x216AF30", Offset = "0x216A330", Length = "0x2D")]
		[Token(Token = "0x6000923")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000156")]
	public virtual ObjectCreationHandling ObjectCreationHandling
	{
		[Address(RVA = "0x216A9B0", Offset = "0x2169DB0", Length = "0x2D")]
		[Token(Token = "0x6000924")]
		 get { } //Length: 45
		[Address(RVA = "0x216AF60", Offset = "0x216A360", Length = "0x2D")]
		[Token(Token = "0x6000925")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000158")]
	public virtual PreserveReferencesHandling PreserveReferencesHandling
	{
		[Address(RVA = "0x216A9E0", Offset = "0x2169DE0", Length = "0x2D")]
		[Token(Token = "0x6000928")]
		 get { } //Length: 45
		[Address(RVA = "0x216AF90", Offset = "0x216A390", Length = "0x2D")]
		[Token(Token = "0x6000929")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000157")]
	public virtual ReferenceLoopHandling ReferenceLoopHandling
	{
		[Address(RVA = "0x216AA10", Offset = "0x2169E10", Length = "0x2D")]
		[Token(Token = "0x6000926")]
		 get { } //Length: 45
		[Address(RVA = "0x216AFC0", Offset = "0x216A3C0", Length = "0x2D")]
		[Token(Token = "0x6000927")]
		 set { } //Length: 45
	}

	[Nullable(2)]
	[Token(Token = "0x1700014E")]
	public virtual IReferenceResolver ReferenceResolver
	{
		[Address(RVA = "0x216AA40", Offset = "0x2169E40", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x6000915")]
		 get { } //Length: 45
		[Address(RVA = "0x216AFF0", Offset = "0x216A3F0", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x6000916")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700015F")]
	public virtual ISerializationBinder SerializationBinder
	{
		[Address(RVA = "0x216AA70", Offset = "0x2169E70", Length = "0x2D")]
		[Token(Token = "0x6000936")]
		 get { } //Length: 45
		[Address(RVA = "0x216B020", Offset = "0x216A420", Length = "0x2D")]
		[Token(Token = "0x6000937")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000167")]
	public virtual StringEscapeHandling StringEscapeHandling
	{
		[Address(RVA = "0x216AAA0", Offset = "0x2169EA0", Length = "0x2D")]
		[Token(Token = "0x6000946")]
		 get { } //Length: 45
		[Address(RVA = "0x216B050", Offset = "0x216A450", Length = "0x2D")]
		[Token(Token = "0x6000947")]
		 set { } //Length: 45
	}

	[Nullable(2)]
	[Token(Token = "0x1700014F")]
	public virtual ITraceWriter TraceWriter
	{
		[Address(RVA = "0x216AAD0", Offset = "0x2169ED0", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x6000917")]
		 get { } //Length: 45
		[Address(RVA = "0x216B080", Offset = "0x216A480", Length = "0x2D")]
		[NullableContext(2)]
		[Token(Token = "0x6000918")]
		 set { } //Length: 45
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	[Token(Token = "0x1700015B")]
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		[Address(RVA = "0x216AB30", Offset = "0x2169F30", Length = "0x2D")]
		[Token(Token = "0x600092E")]
		 get { } //Length: 45
		[Address(RVA = "0x216B0E0", Offset = "0x216A4E0", Length = "0x2D")]
		[Token(Token = "0x600092F")]
		 set { } //Length: 45
	}

	[Token(Token = "0x1700015C")]
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		[Address(RVA = "0x216AB00", Offset = "0x2169F00", Length = "0x2D")]
		[Token(Token = "0x6000930")]
		 get { } //Length: 45
		[Address(RVA = "0x216B0B0", Offset = "0x216A4B0", Length = "0x2D")]
		[Token(Token = "0x6000931")]
		 set { } //Length: 45
	}

	[Token(Token = "0x17000159")]
	public virtual TypeNameHandling TypeNameHandling
	{
		[Address(RVA = "0x216AB60", Offset = "0x2169F60", Length = "0x2D")]
		[Token(Token = "0x600092A")]
		 get { } //Length: 45
		[Address(RVA = "0x216B110", Offset = "0x216A510", Length = "0x2D")]
		[Token(Token = "0x600092B")]
		 set { } //Length: 45
	}

	[Address(RVA = "0x216A480", Offset = "0x2169880", Length = "0x89")]
	[Token(Token = "0x6000952")]
	public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) { }

	[Address(RVA = "0x216A510", Offset = "0x2169910", Length = "0x89")]
	[Token(Token = "0x6000951")]
	public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) { }

	[Address(RVA = "0x216A5A0", Offset = "0x21699A0", Length = "0x2D")]
	[Token(Token = "0x6000913")]
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[Address(RVA = "0x216A370", Offset = "0x2169770", Length = "0x4D")]
	[NullableContext(2)]
	[Token(Token = "0x6000953")]
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[Address(RVA = "0x216A5D0", Offset = "0x21699D0", Length = "0x2D")]
	[Token(Token = "0x6000934")]
	public virtual SerializationBinder get_Binder() { }

	[Address(RVA = "0x216A600", Offset = "0x2169A00", Length = "0x2D")]
	[Token(Token = "0x600094E")]
	public virtual bool get_CheckAdditionalContent() { }

	[Address(RVA = "0x216A630", Offset = "0x2169A30", Length = "0x2D")]
	[Token(Token = "0x6000932")]
	public virtual ConstructorHandling get_ConstructorHandling() { }

	[Address(RVA = "0x216A660", Offset = "0x2169A60", Length = "0x41")]
	[Token(Token = "0x6000938")]
	public virtual StreamingContext get_Context() { }

	[Address(RVA = "0x216A6B0", Offset = "0x2169AB0", Length = "0x2D")]
	[Token(Token = "0x600091E")]
	public virtual IContractResolver get_ContractResolver() { }

	[Address(RVA = "0x216A6E0", Offset = "0x2169AE0", Length = "0x2D")]
	[Token(Token = "0x600091B")]
	public virtual JsonConverterCollection get_Converters() { }

	[Address(RVA = "0x216A710", Offset = "0x2169B10", Length = "0x2D")]
	[Token(Token = "0x600094A")]
	public virtual CultureInfo get_Culture() { }

	[Address(RVA = "0x216A740", Offset = "0x2169B40", Length = "0x2D")]
	[Token(Token = "0x600093C")]
	public virtual DateFormatHandling get_DateFormatHandling() { }

	[Address(RVA = "0x216A770", Offset = "0x2169B70", Length = "0x2D")]
	[Token(Token = "0x6000948")]
	public virtual string get_DateFormatString() { }

	[Address(RVA = "0x216A7A0", Offset = "0x2169BA0", Length = "0x2D")]
	[Token(Token = "0x6000940")]
	public virtual DateParseHandling get_DateParseHandling() { }

	[Address(RVA = "0x216A7D0", Offset = "0x2169BD0", Length = "0x2D")]
	[Token(Token = "0x600093E")]
	public virtual DateTimeZoneHandling get_DateTimeZoneHandling() { }

	[Address(RVA = "0x216A800", Offset = "0x2169C00", Length = "0x2D")]
	[Token(Token = "0x600091C")]
	public virtual DefaultValueHandling get_DefaultValueHandling() { }

	[Address(RVA = "0x216A830", Offset = "0x2169C30", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x6000919")]
	public virtual IEqualityComparer get_EqualityComparer() { }

	[Address(RVA = "0x216A860", Offset = "0x2169C60", Length = "0x2D")]
	[Token(Token = "0x6000942")]
	public virtual FloatFormatHandling get_FloatFormatHandling() { }

	[Address(RVA = "0x216A890", Offset = "0x2169C90", Length = "0x2D")]
	[Token(Token = "0x6000944")]
	public virtual FloatParseHandling get_FloatParseHandling() { }

	[Address(RVA = "0x216A8C0", Offset = "0x2169CC0", Length = "0x2D")]
	[Token(Token = "0x600093A")]
	public virtual Formatting get_Formatting() { }

	[Address(RVA = "0x216A8F0", Offset = "0x2169CF0", Length = "0x2D")]
	[Token(Token = "0x600094C")]
	public virtual Nullable<Int32> get_MaxDepth() { }

	[Address(RVA = "0x216A920", Offset = "0x2169D20", Length = "0x2D")]
	[Token(Token = "0x600092C")]
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	[Address(RVA = "0x216A950", Offset = "0x2169D50", Length = "0x2D")]
	[Token(Token = "0x6000920")]
	public virtual MissingMemberHandling get_MissingMemberHandling() { }

	[Address(RVA = "0x216A980", Offset = "0x2169D80", Length = "0x2D")]
	[Token(Token = "0x6000922")]
	public virtual NullValueHandling get_NullValueHandling() { }

	[Address(RVA = "0x216A9B0", Offset = "0x2169DB0", Length = "0x2D")]
	[Token(Token = "0x6000924")]
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	[Address(RVA = "0x216A9E0", Offset = "0x2169DE0", Length = "0x2D")]
	[Token(Token = "0x6000928")]
	public virtual PreserveReferencesHandling get_PreserveReferencesHandling() { }

	[Address(RVA = "0x216AA10", Offset = "0x2169E10", Length = "0x2D")]
	[Token(Token = "0x6000926")]
	public virtual ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[Address(RVA = "0x216AA40", Offset = "0x2169E40", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x6000915")]
	public virtual IReferenceResolver get_ReferenceResolver() { }

	[Address(RVA = "0x216AA70", Offset = "0x2169E70", Length = "0x2D")]
	[Token(Token = "0x6000936")]
	public virtual ISerializationBinder get_SerializationBinder() { }

	[Address(RVA = "0x216AAA0", Offset = "0x2169EA0", Length = "0x2D")]
	[Token(Token = "0x6000946")]
	public virtual StringEscapeHandling get_StringEscapeHandling() { }

	[Address(RVA = "0x216AAD0", Offset = "0x2169ED0", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x6000917")]
	public virtual ITraceWriter get_TraceWriter() { }

	[Address(RVA = "0x216AB30", Offset = "0x2169F30", Length = "0x2D")]
	[Token(Token = "0x600092E")]
	public virtual FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	[Address(RVA = "0x216AB00", Offset = "0x2169F00", Length = "0x2D")]
	[Token(Token = "0x6000930")]
	public virtual TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	[Address(RVA = "0x216AB60", Offset = "0x2169F60", Length = "0x2D")]
	[Token(Token = "0x600092A")]
	public virtual TypeNameHandling get_TypeNameHandling() { }

	[Address(RVA = "0x216A3C0", Offset = "0x21697C0", Length = "0x1A")]
	[Token(Token = "0x6000950")]
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	[Address(RVA = "0x216A3E0", Offset = "0x21697E0", Length = "0x43")]
	[Token(Token = "0x6000954")]
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[Address(RVA = "0x216AB90", Offset = "0x2169F90", Length = "0x2D")]
	[Token(Token = "0x6000914")]
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[Address(RVA = "0x216A430", Offset = "0x2169830", Length = "0x49")]
	[NullableContext(2)]
	[Token(Token = "0x6000955")]
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

	[Address(RVA = "0x216ABC0", Offset = "0x2169FC0", Length = "0x2D")]
	[Token(Token = "0x6000935")]
	public virtual void set_Binder(SerializationBinder value) { }

	[Address(RVA = "0x216ABF0", Offset = "0x2169FF0", Length = "0x2D")]
	[Token(Token = "0x600094F")]
	public virtual void set_CheckAdditionalContent(bool value) { }

	[Address(RVA = "0x216AC20", Offset = "0x216A020", Length = "0x2D")]
	[Token(Token = "0x6000933")]
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	[Address(RVA = "0x216AC50", Offset = "0x216A050", Length = "0x3A")]
	[Token(Token = "0x6000939")]
	public virtual void set_Context(StreamingContext value) { }

	[Address(RVA = "0x216AC90", Offset = "0x216A090", Length = "0x2D")]
	[Token(Token = "0x600091F")]
	public virtual void set_ContractResolver(IContractResolver value) { }

	[Address(RVA = "0x216ACC0", Offset = "0x216A0C0", Length = "0x2D")]
	[Token(Token = "0x600094B")]
	public virtual void set_Culture(CultureInfo value) { }

	[Address(RVA = "0x216ACF0", Offset = "0x216A0F0", Length = "0x2D")]
	[Token(Token = "0x600093D")]
	public virtual void set_DateFormatHandling(DateFormatHandling value) { }

	[Address(RVA = "0x216AD20", Offset = "0x216A120", Length = "0x2D")]
	[Token(Token = "0x6000949")]
	public virtual void set_DateFormatString(string value) { }

	[Address(RVA = "0x216AD50", Offset = "0x216A150", Length = "0x2D")]
	[Token(Token = "0x6000941")]
	public virtual void set_DateParseHandling(DateParseHandling value) { }

	[Address(RVA = "0x216AD80", Offset = "0x216A180", Length = "0x2D")]
	[Token(Token = "0x600093F")]
	public virtual void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	[Address(RVA = "0x216ADB0", Offset = "0x216A1B0", Length = "0x2D")]
	[Token(Token = "0x600091D")]
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	[Address(RVA = "0x216ADE0", Offset = "0x216A1E0", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x600091A")]
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	[Address(RVA = "0x216AE10", Offset = "0x216A210", Length = "0x2D")]
	[Token(Token = "0x6000943")]
	public virtual void set_FloatFormatHandling(FloatFormatHandling value) { }

	[Address(RVA = "0x216AE40", Offset = "0x216A240", Length = "0x2D")]
	[Token(Token = "0x6000945")]
	public virtual void set_FloatParseHandling(FloatParseHandling value) { }

	[Address(RVA = "0x216AE70", Offset = "0x216A270", Length = "0x2D")]
	[Token(Token = "0x600093B")]
	public virtual void set_Formatting(Formatting value) { }

	[Address(RVA = "0x216AEA0", Offset = "0x216A2A0", Length = "0x2D")]
	[Token(Token = "0x600094D")]
	public virtual void set_MaxDepth(Nullable<Int32> value) { }

	[Address(RVA = "0x216AED0", Offset = "0x216A2D0", Length = "0x2D")]
	[Token(Token = "0x600092D")]
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	[Address(RVA = "0x216AF00", Offset = "0x216A300", Length = "0x2D")]
	[Token(Token = "0x6000921")]
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	[Address(RVA = "0x216AF30", Offset = "0x216A330", Length = "0x2D")]
	[Token(Token = "0x6000923")]
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	[Address(RVA = "0x216AF60", Offset = "0x216A360", Length = "0x2D")]
	[Token(Token = "0x6000925")]
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	[Address(RVA = "0x216AF90", Offset = "0x216A390", Length = "0x2D")]
	[Token(Token = "0x6000929")]
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	[Address(RVA = "0x216AFC0", Offset = "0x216A3C0", Length = "0x2D")]
	[Token(Token = "0x6000927")]
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[Address(RVA = "0x216AFF0", Offset = "0x216A3F0", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x6000916")]
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	[Address(RVA = "0x216B020", Offset = "0x216A420", Length = "0x2D")]
	[Token(Token = "0x6000937")]
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[Address(RVA = "0x216B050", Offset = "0x216A450", Length = "0x2D")]
	[Token(Token = "0x6000947")]
	public virtual void set_StringEscapeHandling(StringEscapeHandling value) { }

	[Address(RVA = "0x216B080", Offset = "0x216A480", Length = "0x2D")]
	[NullableContext(2)]
	[Token(Token = "0x6000918")]
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[Address(RVA = "0x216B0E0", Offset = "0x216A4E0", Length = "0x2D")]
	[Token(Token = "0x600092F")]
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	[Address(RVA = "0x216B0B0", Offset = "0x216A4B0", Length = "0x2D")]
	[Token(Token = "0x6000931")]
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	[Address(RVA = "0x216B110", Offset = "0x216A510", Length = "0x2D")]
	[Token(Token = "0x600092B")]
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

}

