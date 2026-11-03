namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000140")]
public class JsonSchema
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C7")]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005C8")]
	private string <Title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C9")]
	private Nullable<Boolean> <Required>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x40005CA")]
	private Nullable<Boolean> <ReadOnly>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005CB")]
	private Nullable<Boolean> <Hidden>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x40005CC")]
	private Nullable<Boolean> <Transient>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005CD")]
	private string <Description>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005CE")]
	private Nullable<JsonSchemaType> <Type>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CF")]
	private string <Pattern>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005D0")]
	private Nullable<Int32> <MinimumLength>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005D1")]
	private Nullable<Int32> <MaximumLength>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005D2")]
	private Nullable<Double> <DivisibleBy>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005D3")]
	private Nullable<Double> <Minimum>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005D4")]
	private Nullable<Double> <Maximum>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005D5")]
	private Nullable<Boolean> <ExclusiveMinimum>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x40005D6")]
	private Nullable<Boolean> <ExclusiveMaximum>k__BackingField; //Field offset: 0x82
	[CompilerGenerated]
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40005D7")]
	private Nullable<Int32> <MinimumItems>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40005D8")]
	private Nullable<Int32> <MaximumItems>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40005D9")]
	private IList<JsonSchema> <Items>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40005DA")]
	private bool <PositionalItemsValidation>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40005DB")]
	private JsonSchema <AdditionalItems>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40005DC")]
	private bool <AllowAdditionalItems>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB1")]
	[Token(Token = "0x40005DD")]
	private bool <UniqueItems>k__BackingField; //Field offset: 0xB1
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40005DE")]
	private IDictionary<String, JsonSchema> <Properties>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40005DF")]
	private JsonSchema <AdditionalProperties>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40005E0")]
	private IDictionary<String, JsonSchema> <PatternProperties>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40005E1")]
	private bool <AllowAdditionalProperties>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40005E2")]
	private string <Requires>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40005E3")]
	private IList<JToken> <Enum>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40005E4")]
	private Nullable<JsonSchemaType> <Disallow>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40005E5")]
	private JToken <Default>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40005E6")]
	private IList<JsonSchema> <Extends>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40005E7")]
	private string <Format>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40005E8")]
	private string <Location>k__BackingField; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40005E9")]
	private readonly string _internalId; //Field offset: 0x110
	[CompilerGenerated]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005EA")]
	private string <DeferredReference>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005EB")]
	private bool <ReferencesResolved>k__BackingField; //Field offset: 0x120

	[Token(Token = "0x1700018F")]
	public JsonSchema AdditionalItems
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1A")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000193")]
	public JsonSchema AdditionalProperties
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A22")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A23")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000190")]
	public bool AllowAdditionalItems
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1C")]
		 get { } //Length: 8
		[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000195")]
	public bool AllowAdditionalProperties
	{
		[Address(RVA = "0x1F7B600", Offset = "0x1F7AA00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A26")]
		 get { } //Length: 8
		[Address(RVA = "0x2161F70", Offset = "0x2161370", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A27")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000199")]
	public JToken Default
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2E")]
		 get { } //Length: 8
		[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700019E")]
	internal string DeferredReference
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A37")]
		internal get { } //Length: 8
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A38")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000181")]
	public string Description
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FE")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009FF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000198")]
	public Nullable<JsonSchemaType> Disallow
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2C")]
		 get { } //Length: 8
		[Address(RVA = "0x2161FA0", Offset = "0x21613A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000186")]
	public Nullable<Double> DivisibleBy
	{
		[Address(RVA = "0xFF9390", Offset = "0xFF8790", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A08")]
		 get { } //Length: 11
		[Address(RVA = "0x2161FB0", Offset = "0x21613B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A09")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000197")]
	public IList<JToken> Enum
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700018A")]
	public Nullable<Boolean> ExclusiveMaximum
	{
		[Address(RVA = "0x2161F00", Offset = "0x2161300", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A10")]
		 get { } //Length: 8
		[Address(RVA = "0x2161FC0", Offset = "0x21613C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A11")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000189")]
	public Nullable<Boolean> ExclusiveMinimum
	{
		[Address(RVA = "0x20F1B80", Offset = "0x20F0F80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0E")]
		 get { } //Length: 8
		[Address(RVA = "0x2161FD0", Offset = "0x21613D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0F")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700019A")]
	public IList<JsonSchema> Extends
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A30")]
		 get { } //Length: 8
		[Address(RVA = "0x1D413A0", Offset = "0x1D407A0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A31")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700019B")]
	public string Format
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A32")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A33")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700017F")]
	public Nullable<Boolean> Hidden
	{
		[Address(RVA = "0x2161F10", Offset = "0x2161310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FA")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FE0", Offset = "0x21613E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FB")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700017B")]
	public string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F2")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009F3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700019D")]
	internal string InternalId
	{
		[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
		[Token(Token = "0x6000A36")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700018D")]
	public IList<JsonSchema> Items
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A16")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A17")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700019C")]
	internal string Location
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A34")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A35")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000188")]
	public Nullable<Double> Maximum
	{
		[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0C")]
		 get { } //Length: 11
		[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0D")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700018C")]
	public Nullable<Int32> MaximumItems
	{
		[Address(RVA = "0x2161F20", Offset = "0x2161320", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A14")]
		 get { } //Length: 8
		[Address(RVA = "0x119FC30", Offset = "0x119F030", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A15")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000185")]
	public Nullable<Int32> MaximumLength
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A06")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A07")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000187")]
	public Nullable<Double> Minimum
	{
		[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0A")]
		 get { } //Length: 11
		[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A0B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700018B")]
	public Nullable<Int32> MinimumItems
	{
		[Address(RVA = "0x2161F40", Offset = "0x2161340", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A12")]
		 get { } //Length: 8
		[Address(RVA = "0x2162010", Offset = "0x2161410", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A13")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000184")]
	public Nullable<Int32> MinimumLength
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A04")]
		 get { } //Length: 5
		[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A05")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000183")]
	public string Pattern
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A02")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A03")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000194")]
	public IDictionary<String, JsonSchema> PatternProperties
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A24")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A25")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700018E")]
	public bool PositionalItemsValidation
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A18")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A19")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000192")]
	public IDictionary<String, JsonSchema> Properties
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A20")]
		 get { } //Length: 8
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A21")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700017E")]
	public Nullable<Boolean> ReadOnly
	{
		[Address(RVA = "0x2161F50", Offset = "0x2161350", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F8")]
		 get { } //Length: 5
		[Address(RVA = "0x2162030", Offset = "0x2161430", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F9")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700019F")]
	internal bool ReferencesResolved
	{
		[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A39")]
		internal get { } //Length: 8
		[Address(RVA = "0x2142450", Offset = "0x2141850", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A3A")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700017D")]
	public Nullable<Boolean> Required
	{
		[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F6")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3FD0", Offset = "0x20D33D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F7")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000196")]
	public string Requires
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A28")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000A29")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700017C")]
	public string Title
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009F4")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60009F5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000180")]
	public Nullable<Boolean> Transient
	{
		[Address(RVA = "0x2161F60", Offset = "0x2161360", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FC")]
		 get { } //Length: 5
		[Address(RVA = "0x2162040", Offset = "0x2161440", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60009FD")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000182")]
	public Nullable<JsonSchemaType> Type
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A00")]
		 get { } //Length: 5
		[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A01")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000191")]
	public bool UniqueItems
	{
		[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1E")]
		 get { } //Length: 8
		[Address(RVA = "0x1D604B0", Offset = "0x1D5F8B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A1F")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2161E70", Offset = "0x2161270", Length = "0x89")]
	[Token(Token = "0x6000A3B")]
	public JsonSchema() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1A")]
	public JsonSchema get_AdditionalItems() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A22")]
	public JsonSchema get_AdditionalProperties() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1C")]
	public bool get_AllowAdditionalItems() { }

	[Address(RVA = "0x1F7B600", Offset = "0x1F7AA00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A26")]
	public bool get_AllowAdditionalProperties() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2E")]
	public JToken get_Default() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A37")]
	internal string get_DeferredReference() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FE")]
	public string get_Description() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2C")]
	public Nullable<JsonSchemaType> get_Disallow() { }

	[Address(RVA = "0xFF9390", Offset = "0xFF8790", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A08")]
	public Nullable<Double> get_DivisibleBy() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2A")]
	public IList<JToken> get_Enum() { }

	[Address(RVA = "0x2161F00", Offset = "0x2161300", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A10")]
	public Nullable<Boolean> get_ExclusiveMaximum() { }

	[Address(RVA = "0x20F1B80", Offset = "0x20F0F80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0E")]
	public Nullable<Boolean> get_ExclusiveMinimum() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A30")]
	public IList<JsonSchema> get_Extends() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A32")]
	public string get_Format() { }

	[Address(RVA = "0x2161F10", Offset = "0x2161310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FA")]
	public Nullable<Boolean> get_Hidden() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F2")]
	public string get_Id() { }

	[Address(RVA = "0x1CF27D0", Offset = "0x1CF1BD0", Length = "0x8")]
	[Token(Token = "0x6000A36")]
	internal string get_InternalId() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A16")]
	public IList<JsonSchema> get_Items() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A34")]
	internal string get_Location() { }

	[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0C")]
	public Nullable<Double> get_Maximum() { }

	[Address(RVA = "0x2161F20", Offset = "0x2161320", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A14")]
	public Nullable<Int32> get_MaximumItems() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A06")]
	public Nullable<Int32> get_MaximumLength() { }

	[Address(RVA = "0x20D8470", Offset = "0x20D7870", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0A")]
	public Nullable<Double> get_Minimum() { }

	[Address(RVA = "0x2161F40", Offset = "0x2161340", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A12")]
	public Nullable<Int32> get_MinimumItems() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A04")]
	public Nullable<Int32> get_MinimumLength() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A02")]
	public string get_Pattern() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A24")]
	public IDictionary<String, JsonSchema> get_PatternProperties() { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A18")]
	public bool get_PositionalItemsValidation() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A20")]
	public IDictionary<String, JsonSchema> get_Properties() { }

	[Address(RVA = "0x2161F50", Offset = "0x2161350", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F8")]
	public Nullable<Boolean> get_ReadOnly() { }

	[Address(RVA = "0x2142350", Offset = "0x2141750", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A39")]
	internal bool get_ReferencesResolved() { }

	[Address(RVA = "0x111BFD0", Offset = "0x111B3D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F6")]
	public Nullable<Boolean> get_Required() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A28")]
	public string get_Requires() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F4")]
	public string get_Title() { }

	[Address(RVA = "0x2161F60", Offset = "0x2161360", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FC")]
	public Nullable<Boolean> get_Transient() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A00")]
	public Nullable<JsonSchemaType> get_Type() { }

	[Address(RVA = "0x1D605B0", Offset = "0x1D5F9B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1E")]
	public bool get_UniqueItems() { }

	[Address(RVA = "0x2161640", Offset = "0x2160A40", Length = "0x13C")]
	[Token(Token = "0x6000A3F")]
	public static JsonSchema Parse(string json, JsonSchemaResolver resolver) { }

	[Address(RVA = "0x21615E0", Offset = "0x21609E0", Length = "0x5A")]
	[Token(Token = "0x6000A3E")]
	public static JsonSchema Parse(string json) { }

	[Address(RVA = "0x21617E0", Offset = "0x2160BE0", Length = "0x248")]
	[Token(Token = "0x6000A3D")]
	public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver) { }

	[Address(RVA = "0x2161780", Offset = "0x2160B80", Length = "0x5A")]
	[Token(Token = "0x6000A3C")]
	public static JsonSchema Read(JsonReader reader) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1B")]
	public void set_AdditionalItems(JsonSchema value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A23")]
	public void set_AdditionalProperties(JsonSchema value) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1D")]
	public void set_AllowAdditionalItems(bool value) { }

	[Address(RVA = "0x2161F70", Offset = "0x2161370", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A27")]
	public void set_AllowAdditionalProperties(bool value) { }

	[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2F")]
	public void set_Default(JToken value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A38")]
	internal void set_DeferredReference(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009FF")]
	public void set_Description(string value) { }

	[Address(RVA = "0x2161FA0", Offset = "0x21613A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2D")]
	public void set_Disallow(Nullable<JsonSchemaType> value) { }

	[Address(RVA = "0x2161FB0", Offset = "0x21613B0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A09")]
	public void set_DivisibleBy(Nullable<Double> value) { }

	[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2B")]
	public void set_Enum(IList<JToken> value) { }

	[Address(RVA = "0x2161FC0", Offset = "0x21613C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A11")]
	public void set_ExclusiveMaximum(Nullable<Boolean> value) { }

	[Address(RVA = "0x2161FD0", Offset = "0x21613D0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0F")]
	public void set_ExclusiveMinimum(Nullable<Boolean> value) { }

	[Address(RVA = "0x1D413A0", Offset = "0x1D407A0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A31")]
	public void set_Extends(IList<JsonSchema> value) { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A33")]
	public void set_Format(string value) { }

	[Address(RVA = "0x2161FE0", Offset = "0x21613E0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FB")]
	public void set_Hidden(Nullable<Boolean> value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009F3")]
	public void set_Id(string value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A17")]
	public void set_Items(IList<JsonSchema> value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A35")]
	internal void set_Location(string value) { }

	[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0D")]
	public void set_Maximum(Nullable<Double> value) { }

	[Address(RVA = "0x119FC30", Offset = "0x119F030", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A15")]
	public void set_MaximumItems(Nullable<Int32> value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A07")]
	public void set_MaximumLength(Nullable<Int32> value) { }

	[Address(RVA = "0x2162020", Offset = "0x2161420", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A0B")]
	public void set_Minimum(Nullable<Double> value) { }

	[Address(RVA = "0x2162010", Offset = "0x2161410", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A13")]
	public void set_MinimumItems(Nullable<Int32> value) { }

	[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A05")]
	public void set_MinimumLength(Nullable<Int32> value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A03")]
	public void set_Pattern(string value) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A25")]
	public void set_PatternProperties(IDictionary<String, JsonSchema> value) { }

	[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A19")]
	public void set_PositionalItemsValidation(bool value) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A21")]
	public void set_Properties(IDictionary<String, JsonSchema> value) { }

	[Address(RVA = "0x2162030", Offset = "0x2161430", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F9")]
	public void set_ReadOnly(Nullable<Boolean> value) { }

	[Address(RVA = "0x2142450", Offset = "0x2141850", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A3A")]
	internal void set_ReferencesResolved(bool value) { }

	[Address(RVA = "0x20D3FD0", Offset = "0x20D33D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009F7")]
	public void set_Required(Nullable<Boolean> value) { }

	[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000A29")]
	public void set_Requires(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60009F5")]
	public void set_Title(string value) { }

	[Address(RVA = "0x2162040", Offset = "0x2161440", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60009FD")]
	public void set_Transient(Nullable<Boolean> value) { }

	[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A01")]
	public void set_Type(Nullable<JsonSchemaType> value) { }

	[Address(RVA = "0x1D604B0", Offset = "0x1D5F8B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A1F")]
	public void set_UniqueItems(bool value) { }

	[Address(RVA = "0x2161A30", Offset = "0x2160E30", Length = "0x200")]
	[Token(Token = "0x6000A42")]
	public virtual string ToString() { }

	[Address(RVA = "0x2161C40", Offset = "0x2161040", Length = "0xFE")]
	[Token(Token = "0x6000A41")]
	public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver) { }

	[Address(RVA = "0x2161D40", Offset = "0x2161140", Length = "0x130")]
	[Token(Token = "0x6000A40")]
	public void WriteTo(JsonWriter writer) { }

}

