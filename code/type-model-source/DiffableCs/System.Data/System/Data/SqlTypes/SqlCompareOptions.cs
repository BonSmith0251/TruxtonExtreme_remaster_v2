namespace System.Data.SqlTypes;

[Flags]
[Token(Token = "0x20000B7")]
public enum SqlCompareOptions : int
{
	None = 0,
	IgnoreCase = 1,
	IgnoreNonSpace = 2,
	IgnoreKanaType = 8,
	IgnoreWidth = 16,
	BinarySort = 32768,
	BinarySort2 = 16384,
}

