namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x200014D")]
public class JsonSchemaResolver
{
	[CompilerGenerated]
	[Token(Token = "0x200014E")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000643")]
		public string reference; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000ACC")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2170B00", Offset = "0x216FF00", Length = "0x2B")]
		[Token(Token = "0x6000ACD")]
		internal bool <GetSchema>b__0(JsonSchema s) { }

		[Address(RVA = "0x2170B30", Offset = "0x216FF30", Length = "0x2E")]
		[Token(Token = "0x6000ACE")]
		internal bool <GetSchema>b__1(JsonSchema s) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000642")]
	private IList<JsonSchema> <LoadedSchemas>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001C7")]
	public IList<JsonSchema> LoadedSchemas
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC9")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x215F880", Offset = "0x215EC80", Length = "0x77")]
	[Token(Token = "0x6000ACA")]
	public JsonSchemaResolver() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC8")]
	public IList<JsonSchema> get_LoadedSchemas() { }

	[Address(RVA = "0x215F750", Offset = "0x215EB50", Length = "0x12B")]
	[Token(Token = "0x6000ACB")]
	public override JsonSchema GetSchema(string reference) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC9")]
	protected void set_LoadedSchemas(IList<JsonSchema> value) { }

}

