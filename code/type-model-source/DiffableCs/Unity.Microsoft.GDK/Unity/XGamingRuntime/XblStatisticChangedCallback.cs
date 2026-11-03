namespace Unity.XGamingRuntime;

[Token(Token = "0x2000204")]
public sealed class XblStatisticChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x1B5CE70", Offset = "0x1B5C270", Length = "0xA6")]
	[Token(Token = "0x6000AA1")]
	public XblStatisticChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B8C460", Offset = "0x2B8B860", Length = "0x80")]
	[Token(Token = "0x6000AA3")]
	public override IAsyncResult BeginInvoke(XblStatisticChangeEventArgs statisticChangeEventArgs, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000AA4")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0xE2BDE0", Offset = "0xE2B1E0", Length = "0x2F")]
	[Token(Token = "0x6000AA2")]
	public override void Invoke(XblStatisticChangeEventArgs statisticChangeEventArgs) { }

}

