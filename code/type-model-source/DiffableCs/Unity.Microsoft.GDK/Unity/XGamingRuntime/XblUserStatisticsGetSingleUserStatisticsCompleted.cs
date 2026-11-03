namespace Unity.XGamingRuntime;

[Token(Token = "0x2000201")]
public sealed class XblUserStatisticsGetSingleUserStatisticsCompleted : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000A95")]
	public XblUserStatisticsGetSingleUserStatisticsCompleted(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x6000A97")]
	public override IAsyncResult BeginInvoke(int hresult, XblUserStatisticsResult result, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000A98")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000A96")]
	public override void Invoke(int hresult, XblUserStatisticsResult result) { }

}

