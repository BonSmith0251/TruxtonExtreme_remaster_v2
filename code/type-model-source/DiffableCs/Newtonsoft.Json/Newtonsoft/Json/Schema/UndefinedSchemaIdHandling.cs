namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Token(Token = "0x2000152")]
public enum UndefinedSchemaIdHandling : int
{
	None = 0,
	UseTypeName = 1,
	UseAssemblyQualifiedName = 2,
}

