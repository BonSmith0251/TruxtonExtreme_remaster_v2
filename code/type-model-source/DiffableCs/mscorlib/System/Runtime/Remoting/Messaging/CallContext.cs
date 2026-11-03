namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x200039F")]
public sealed class CallContext
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001C41")]
	private CallContext() { }

	[Address(RVA = "0x1EFC070", Offset = "0x1EFB470", Length = "0xD1")]
	[Token(Token = "0x6001C44")]
	public static object LogicalGetData(string name) { }

	[Address(RVA = "0x1EFC150", Offset = "0x1EFB550", Length = "0x1AA")]
	[Token(Token = "0x6001C45")]
	public static void LogicalSetData(string name, object data) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001C42")]
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	[Address(RVA = "0x1EFC300", Offset = "0x1EFB700", Length = "0x65")]
	[Token(Token = "0x6001C43")]
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}

