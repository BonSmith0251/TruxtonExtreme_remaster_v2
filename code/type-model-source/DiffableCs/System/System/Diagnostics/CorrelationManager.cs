namespace System.Diagnostics;

[Token(Token = "0x20000F9")]
public class CorrelationManager
{

	[Token(Token = "0x170000E6")]
	public Stack LogicalOperationStack
	{
		[Address(RVA = "0x262CA70", Offset = "0x262BE70", Length = "0xA4")]
		[Token(Token = "0x6000618")]
		 get { } //Length: 164
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000617")]
	internal CorrelationManager() { }

	[Address(RVA = "0x262CA70", Offset = "0x262BE70", Length = "0xA4")]
	[Token(Token = "0x6000618")]
	public Stack get_LogicalOperationStack() { }

	[Address(RVA = "0x262CA70", Offset = "0x262BE70", Length = "0xA4")]
	[Token(Token = "0x6000619")]
	private Stack GetLogicalOperationStack() { }

}

