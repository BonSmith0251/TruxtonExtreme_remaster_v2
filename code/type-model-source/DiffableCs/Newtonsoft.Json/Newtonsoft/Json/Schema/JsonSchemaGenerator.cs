namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000145")]
public class JsonSchemaGenerator
{
	[CompilerGenerated]
	[Token(Token = "0x2000147")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400061D")]
		public Type type; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A79")]
		public <>c__DisplayClass23_0() { }

		[Address(RVA = "0x2170A40", Offset = "0x216FE40", Length = "0x51")]
		[Token(Token = "0x6000A7A")]
		internal bool <GenerateInternal>b__0(TypeSchema tc) { }

	}

	[Token(Token = "0x2000146")]
	private class TypeSchema
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400061B")]
		private readonly Type <Type>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400061C")]
		private readonly JsonSchema <Schema>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x170001A8")]
		public JsonSchema Schema
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000A77")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001A7")]
		public Type Type
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000A76")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x216FDC0", Offset = "0x216F1C0", Length = "0x9D")]
		[Token(Token = "0x6000A78")]
		public TypeSchema(Type type, JsonSchema schema) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A77")]
		public JsonSchema get_Schema() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A76")]
		public Type get_Type() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000616")]
	private UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000617")]
	private IContractResolver _contractResolver; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000618")]
	private JsonSchemaResolver _resolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000619")]
	private readonly IList<TypeSchema> _stack; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400061A")]
	private JsonSchema _currentSchema; //Field offset: 0x30

	[Token(Token = "0x170001A5")]
	public IContractResolver ContractResolver
	{
		[Address(RVA = "0x215D2C0", Offset = "0x215C6C0", Length = "0x93")]
		[Token(Token = "0x6000A62")]
		 get { } //Length: 147
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000A63")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001A6")]
	private JsonSchema CurrentSchema
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000A64")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170001A4")]
	public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000A60")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A61")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x215D240", Offset = "0x215C640", Length = "0x77")]
	[Token(Token = "0x6000A75")]
	public JsonSchemaGenerator() { }

	[Address(RVA = "0x215B190", Offset = "0x215A590", Length = "0xD")]
	[Token(Token = "0x6000A6F")]
	private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired) { }

	[Address(RVA = "0x215C840", Offset = "0x215BC40", Length = "0x83")]
	[Token(Token = "0x6000A69")]
	public JsonSchema Generate(Type type, bool rootSchemaNullable) { }

	[Address(RVA = "0x215C990", Offset = "0x215BD90", Length = "0x1A")]
	[Token(Token = "0x6000A68")]
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver) { }

	[Address(RVA = "0x215C9B0", Offset = "0x215BDB0", Length = "0x74")]
	[Token(Token = "0x6000A67")]
	public JsonSchema Generate(Type type) { }

	[Address(RVA = "0x215C8D0", Offset = "0x215BCD0", Length = "0xB2")]
	[Token(Token = "0x6000A6A")]
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { }

	[Address(RVA = "0x215B1C0", Offset = "0x215A5C0", Length = "0xBAC")]
	[Token(Token = "0x6000A6E")]
	private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required) { }

	[Address(RVA = "0x215B1A0", Offset = "0x215A5A0", Length = "0x1E")]
	[Token(Token = "0x6000A72")]
	private void GenerateISerializableContract(Type type, JsonISerializableContract contract) { }

	[Address(RVA = "0x215C470", Offset = "0x215B870", Length = "0x3CC")]
	[Token(Token = "0x6000A71")]
	private void GenerateObjectSchema(Type type, JsonObjectContract contract) { }

	[Address(RVA = "0x215D2C0", Offset = "0x215C6C0", Length = "0x93")]
	[Token(Token = "0x6000A62")]
	public IContractResolver get_ContractResolver() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000A64")]
	private JsonSchema get_CurrentSchema() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000A60")]
	public UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling() { }

	[Address(RVA = "0x215CA30", Offset = "0x215BE30", Length = "0xFA")]
	[Token(Token = "0x6000A6C")]
	private string GetDescription(Type type) { }

	[Address(RVA = "0x215CB30", Offset = "0x215BF30", Length = "0x1B8")]
	[Token(Token = "0x6000A74")]
	private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired) { }

	[Address(RVA = "0x215CD30", Offset = "0x215C130", Length = "0x8C")]
	[Token(Token = "0x6000A6B")]
	private string GetTitle(Type type) { }

	[Address(RVA = "0x215CDC0", Offset = "0x215C1C0", Length = "0xF3")]
	[Token(Token = "0x6000A6D")]
	private string GetTypeId(Type type, bool explicitOnly) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6000A70")]
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[Address(RVA = "0x215CEC0", Offset = "0x215C2C0", Length = "0xE6")]
	[Token(Token = "0x6000A73")]
	internal static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag) { }

	[Address(RVA = "0x215CFB0", Offset = "0x215C3B0", Length = "0x164")]
	[Token(Token = "0x6000A66")]
	private TypeSchema Pop() { }

	[Address(RVA = "0x215D120", Offset = "0x215C520", Length = "0x113")]
	[Token(Token = "0x6000A65")]
	private void Push(TypeSchema typeSchema) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000A63")]
	public void set_ContractResolver(IContractResolver value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A61")]
	public void set_UndefinedSchemaIdHandling(UndefinedSchemaIdHandling value) { }

}

