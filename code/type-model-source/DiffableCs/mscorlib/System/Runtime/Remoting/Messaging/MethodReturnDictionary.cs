namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003C3")]
internal class MethodReturnDictionary : MessageDictionary
{
	[Token(Token = "0x4000EF4")]
	public static String[] InternalReturnKeys; //Field offset: 0x0
	[Token(Token = "0x4000EF5")]
	public static String[] InternalExceptionKeys; //Field offset: 0x8

	[Address(RVA = "0x1F0B480", Offset = "0x1F0A880", Length = "0x207")]
	[Token(Token = "0x6001D32")]
	private static MethodReturnDictionary() { }

	[Address(RVA = "0x1F0B690", Offset = "0x1F0AA90", Length = "0xD7")]
	[Token(Token = "0x6001D31")]
	public MethodReturnDictionary(IMethodReturnMessage message) { }

}

