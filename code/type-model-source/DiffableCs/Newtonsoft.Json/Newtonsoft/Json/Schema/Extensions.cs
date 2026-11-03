namespace Newtonsoft.Json.Schema;

[Extension]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x200013D")]
public static class Extensions
{
	[CompilerGenerated]
	[Token(Token = "0x200013E")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005C5")]
		public bool valid; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009EE")]
		public <>c__DisplayClass0_0() { }

		[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
		[Token(Token = "0x60009EF")]
		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200013F")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005C6")]
		public IList<String> errors; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009F0")]
		public <>c__DisplayClass1_0() { }

		[Address(RVA = "0x2170570", Offset = "0x216F970", Length = "0xF3")]
		[Token(Token = "0x60009F1")]
		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}


	[Address(RVA = "0x2155A00", Offset = "0x2154E00", Length = "0xC3")]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Token(Token = "0x60009EA")]
	public static bool IsValid(JToken source, JsonSchema schema) { }

	[Address(RVA = "0x21558B0", Offset = "0x2154CB0", Length = "0x14A")]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Token(Token = "0x60009EB")]
	public static bool IsValid(JToken source, JsonSchema schema, out IList<String>& errorMessages) { }

	[Address(RVA = "0x2155DD0", Offset = "0x21551D0", Length = "0xB")]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Token(Token = "0x60009EC")]
	public static void Validate(JToken source, JsonSchema schema) { }

	[Address(RVA = "0x2155C20", Offset = "0x2155020", Length = "0x1A2")]
	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Token(Token = "0x60009ED")]
	public static void Validate(JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler) { }

}

