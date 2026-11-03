namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003BF")]
internal class MCMDictionary : MessageDictionary
{
	[Token(Token = "0x4000EDD")]
	public static String[] InternalKeys; //Field offset: 0x0

	[Address(RVA = "0x1F06920", Offset = "0x1F05D20", Length = "0x172")]
	[Token(Token = "0x6001CF8")]
	private static MCMDictionary() { }

	[Address(RVA = "0x1F06AA0", Offset = "0x1F05EA0", Length = "0x86")]
	[Token(Token = "0x6001CF7")]
	public MCMDictionary(IMethodMessage message) { }

}

