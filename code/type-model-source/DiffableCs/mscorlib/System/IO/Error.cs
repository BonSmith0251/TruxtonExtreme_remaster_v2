namespace System.IO;

[Token(Token = "0x2000639")]
internal static class Error
{

	[Address(RVA = "0x1FD5140", Offset = "0x1FD4540", Length = "0x5F")]
	[Token(Token = "0x6002E2E")]
	internal static Exception GetEndOfFile() { }

	[Address(RVA = "0x1FD51A0", Offset = "0x1FD45A0", Length = "0x58")]
	[Token(Token = "0x6002E2F")]
	internal static Exception GetReadNotSupported() { }

	[Address(RVA = "0x1FD5200", Offset = "0x1FD4600", Length = "0x5A")]
	[Token(Token = "0x6002E2D")]
	internal static Exception GetStreamIsClosed() { }

	[Address(RVA = "0x1FD5260", Offset = "0x1FD4660", Length = "0x58")]
	[Token(Token = "0x6002E30")]
	internal static Exception GetWriteNotSupported() { }

}

