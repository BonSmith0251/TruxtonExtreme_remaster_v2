namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x200014A")]
internal class JsonSchemaNode
{
	[CompilerGenerated]
	[Token(Token = "0x200014B")]
	private sealed class <>c
	{
		[Token(Token = "0x400063F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000640")]
		public static Func<JsonSchema, String> <>9__26_0; //Field offset: 0x8
		[Token(Token = "0x4000641")]
		public static Func<String, String> <>9__26_1; //Field offset: 0x10

		[Address(RVA = "0x2170B60", Offset = "0x216FF60", Length = "0x67")]
		[Token(Token = "0x6000AC2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AC3")]
		public <>c() { }

		[Address(RVA = "0x2170510", Offset = "0x216F910", Length = "0x1A")]
		[Token(Token = "0x6000AC4")]
		internal string <GetId>b__26_0(JsonSchema s) { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x6000AC5")]
		internal string <GetId>b__26_1(string id) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000638")]
	private readonly string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000639")]
	private readonly ReadOnlyCollection<JsonSchema> <Schemas>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400063A")]
	private readonly Dictionary<String, JsonSchemaNode> <Properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400063B")]
	private readonly Dictionary<String, JsonSchemaNode> <PatternProperties>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400063C")]
	private readonly List<JsonSchemaNode> <Items>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400063D")]
	private JsonSchemaNode <AdditionalProperties>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400063E")]
	private JsonSchemaNode <AdditionalItems>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x170001C6")]
	public JsonSchemaNode AdditionalItems
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000ABC")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000ABD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001C5")]
	public JsonSchemaNode AdditionalProperties
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000ABA")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000ABB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001C0")]
	public string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C4")]
	public List<JsonSchemaNode> Items
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C3")]
	public Dictionary<String, JsonSchemaNode> PatternProperties
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C2")]
	public Dictionary<String, JsonSchemaNode> Properties
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C1")]
	public ReadOnlyCollection<JsonSchema> Schemas
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x215F300", Offset = "0x215E700", Length = "0x1D7")]
	[Token(Token = "0x6000ABE")]
	public JsonSchemaNode(JsonSchema schema) { }

	[Address(RVA = "0x215F4E0", Offset = "0x215E8E0", Length = "0x26E")]
	[Token(Token = "0x6000ABF")]
	private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema) { }

	[Address(RVA = "0x215F010", Offset = "0x215E410", Length = "0x64")]
	[Token(Token = "0x6000AC0")]
	public JsonSchemaNode Combine(JsonSchema schema) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000ABC")]
	public JsonSchemaNode get_AdditionalItems() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000ABA")]
	public JsonSchemaNode get_AdditionalProperties() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB5")]
	public string get_Id() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB9")]
	public List<JsonSchemaNode> get_Items() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB8")]
	public Dictionary<String, JsonSchemaNode> get_PatternProperties() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB7")]
	public Dictionary<String, JsonSchemaNode> get_Properties() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB6")]
	public ReadOnlyCollection<JsonSchema> get_Schemas() { }

	[Address(RVA = "0x215F080", Offset = "0x215E480", Length = "0x275")]
	[Token(Token = "0x6000AC1")]
	public static string GetId(IEnumerable<JsonSchema> schemata) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000ABD")]
	public void set_AdditionalItems(JsonSchemaNode value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000ABB")]
	public void set_AdditionalProperties(JsonSchemaNode value) { }

}

