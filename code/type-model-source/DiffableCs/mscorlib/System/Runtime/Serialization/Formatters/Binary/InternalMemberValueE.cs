namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000409")]
internal enum InternalMemberValueE : int
{
	Empty = 0,
	InlineValue = 1,
	Nested = 2,
	Reference = 3,
	Null = 4,
}

