namespace System.Reflection;

[Flags]
[Token(Token = "0x2000521")]
internal enum PInfo : int
{
	Attributes = 1,
	GetMethod = 2,
	SetMethod = 4,
	ReflectedType = 8,
	DeclaringType = 16,
	Name = 32,
}

