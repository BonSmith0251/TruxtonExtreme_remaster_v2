namespace System.Data.SqlTypes;

[Token(Token = "0x20000AB")]
internal enum SqlBytesCharsState : int
{
	Null = 0,
	Buffer = 1,
	Stream = 3,
}

