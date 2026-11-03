namespace System;

[Token(Token = "0x20001B9")]
internal static class KnownTerminals
{

	[Token(Token = "0x17000162")]
	public static Byte[] ansi
	{
		[Address(RVA = "0x2081AF0", Offset = "0x2080EF0", Length = "0x5D")]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000160")]
	public static Byte[] linux
	{
		[Address(RVA = "0x2081B50", Offset = "0x2080F50", Length = "0x5D")]
		[Token(Token = "0x6000FCC")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000161")]
	public static Byte[] xterm
	{
		[Address(RVA = "0x2081BB0", Offset = "0x2080FB0", Length = "0x5D")]
		[Token(Token = "0x6000FCD")]
		 get { } //Length: 93
	}

	[Address(RVA = "0x2081AF0", Offset = "0x2080EF0", Length = "0x5D")]
	[Token(Token = "0x6000FCE")]
	public static Byte[] get_ansi() { }

	[Address(RVA = "0x2081B50", Offset = "0x2080F50", Length = "0x5D")]
	[Token(Token = "0x6000FCC")]
	public static Byte[] get_linux() { }

	[Address(RVA = "0x2081BB0", Offset = "0x2080FB0", Length = "0x5D")]
	[Token(Token = "0x6000FCD")]
	public static Byte[] get_xterm() { }

}

