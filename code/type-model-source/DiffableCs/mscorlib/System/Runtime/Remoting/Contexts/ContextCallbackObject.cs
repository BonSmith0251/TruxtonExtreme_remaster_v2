namespace System.Runtime.Remoting.Contexts;

[Token(Token = "0x2000375")]
internal class ContextCallbackObject : ContextBoundObject
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001BC5")]
	public ContextCallbackObject() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001BC4")]
	public void DoCallBack(CrossContextDelegate deleg) { }

}

