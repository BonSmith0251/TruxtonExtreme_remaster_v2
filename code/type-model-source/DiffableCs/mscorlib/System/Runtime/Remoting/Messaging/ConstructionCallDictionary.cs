namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003B1")]
internal class ConstructionCallDictionary : MessageDictionary
{
	[Token(Token = "0x4000ECF")]
	public static String[] InternalKeys; //Field offset: 0x0

	[Address(RVA = "0x1EFF700", Offset = "0x1EFEB00", Length = "0x248")]
	[Token(Token = "0x6001CB3")]
	private static ConstructionCallDictionary() { }

	[Address(RVA = "0x1EFF950", Offset = "0x1EFED50", Length = "0x86")]
	[Token(Token = "0x6001CB0")]
	public ConstructionCallDictionary(IConstructionCallMessage message) { }

	[Address(RVA = "0x1EFF1A0", Offset = "0x1EFE5A0", Length = "0x33E")]
	[Token(Token = "0x6001CB1")]
	protected virtual object GetMethodProperty(string key) { }

	[Address(RVA = "0x1EFF4E0", Offset = "0x1EFE8E0", Length = "0x21A")]
	[Token(Token = "0x6001CB2")]
	protected virtual void SetMethodProperty(string key, object value) { }

}

