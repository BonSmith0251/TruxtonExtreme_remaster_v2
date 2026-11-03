namespace Newtonsoft.Json.Schema;

[Flags]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x200014F")]
public enum JsonSchemaType : int
{
	None = 0,
	String = 1,
	Float = 2,
	Integer = 4,
	Boolean = 8,
	Object = 16,
	Array = 32,
	Null = 64,
	Any = 127,
}

