namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000150")]
internal class JsonSchemaWriter
{
	[CompilerGenerated]
	[Token(Token = "0x2000151")]
	private sealed class <>c
	{
		[Token(Token = "0x4000650")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000651")]
		public static Func<JsonSchemaType, Boolean> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x2170C40", Offset = "0x2170040", Length = "0x67")]
		[Token(Token = "0x6000AD6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AD7")]
		public <>c() { }

		[Address(RVA = "0x2170550", Offset = "0x216F950", Length = "0x6")]
		[Token(Token = "0x6000AD8")]
		internal bool <WriteType>b__7_0(JsonSchemaType v) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400064E")]
	private readonly JsonWriter _writer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400064F")]
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18

	[Address(RVA = "0x2161560", Offset = "0x2160960", Length = "0x7F")]
	[Token(Token = "0x6000ACF")]
	public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver) { }

	[Address(RVA = "0x215F900", Offset = "0x215ED00", Length = "0x114")]
	[Token(Token = "0x6000AD0")]
	private void ReferenceOrWriteSchema(JsonSchema schema) { }

	[Address(RVA = "0x215FA20", Offset = "0x215EE20", Length = "0x2A3")]
	[Token(Token = "0x6000AD3")]
	private void WriteItems(JsonSchema schema) { }

	[Address(RVA = "0x215FCD0", Offset = "0x215F0D0", Length = "0x5F")]
	[Token(Token = "0x6000AD5")]
	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value) { }

	[Address(RVA = "0x215FFC0", Offset = "0x215F3C0", Length = "0x113B")]
	[Token(Token = "0x6000AD1")]
	public void WriteSchema(JsonSchema schema) { }

	[Address(RVA = "0x215FD30", Offset = "0x215F130", Length = "0x281")]
	[Token(Token = "0x6000AD2")]
	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<String, JsonSchema> properties) { }

	[Address(RVA = "0x2161100", Offset = "0x2160500", Length = "0x450")]
	[Token(Token = "0x6000AD4")]
	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type) { }

}

