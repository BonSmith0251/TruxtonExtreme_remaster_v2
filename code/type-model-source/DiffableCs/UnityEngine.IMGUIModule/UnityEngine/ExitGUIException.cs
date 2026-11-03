namespace UnityEngine;

[Token(Token = "0x2000020")]
public sealed class ExitGUIException : Exception
{

	[Address(RVA = "0x30DF450", Offset = "0x30DE850", Length = "0xBB")]
	[Token(Token = "0x60001B6")]
	public ExitGUIException() { }

	[Address(RVA = "0x30DF510", Offset = "0x30DE910", Length = "0xCB")]
	[Token(Token = "0x60001B7")]
	internal ExitGUIException(string message) { }

}

