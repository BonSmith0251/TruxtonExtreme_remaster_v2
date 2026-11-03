namespace Unity.Properties;

[Flags]
[Token(Token = "0x200000C")]
public enum TypeGenerationOptions : int
{
	None = 0,
	ValueType = 2,
	ReferenceType = 4,
	Default = 6,
}

