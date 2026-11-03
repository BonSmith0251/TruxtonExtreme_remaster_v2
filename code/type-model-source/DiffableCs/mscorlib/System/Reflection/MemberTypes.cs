namespace System.Reflection;

[Flags]
[Token(Token = "0x20004EB")]
public enum MemberTypes : int
{
	Constructor = 1,
	Event = 2,
	Field = 4,
	Method = 8,
	Property = 16,
	TypeInfo = 32,
	Custom = 64,
	NestedType = 128,
	All = 191,
}

