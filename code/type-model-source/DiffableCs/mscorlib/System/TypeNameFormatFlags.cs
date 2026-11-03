namespace System;

[Token(Token = "0x2000190")]
internal enum TypeNameFormatFlags : int
{
	FormatBasic = 0,
	FormatNamespace = 1,
	FormatFullInst = 2,
	FormatAssembly = 4,
	FormatSignature = 8,
	FormatNoVersion = 16,
	FormatAngleBrackets = 64,
	FormatStubInfo = 128,
	FormatGenericParam = 256,
	FormatSerialization = 259,
}

