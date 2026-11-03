namespace Unity.XGamingRuntime;

[Token(Token = "0x2000105")]
public sealed class XAsyncCompletionRoutine : MulticastDelegate
{

	[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
	[Token(Token = "0x600064E")]
	public XAsyncCompletionRoutine(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
	[Token(Token = "0x6000650")]
	public override IAsyncResult BeginInvoke(XAsyncBlock block, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000651")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x600064F")]
	public override void Invoke(XAsyncBlock block) { }

}

