namespace Steamworks;

[Token(Token = "0x2000189")]
internal class CallbackIdentities
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008EF")]
	public CallbackIdentities() { }

	[Address(RVA = "0x609E00", Offset = "0x609200", Length = "0x153")]
	[Token(Token = "0x60008EE")]
	public static int GetCallbackIdentity(Type callbackStruct) { }

}

