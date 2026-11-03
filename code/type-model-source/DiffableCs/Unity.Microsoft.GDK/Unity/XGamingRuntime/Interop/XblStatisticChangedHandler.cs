namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003B9")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
public sealed class XblStatisticChangedHandler : MulticastDelegate
{

	[Address(RVA = "0x2BB8C10", Offset = "0x2BB8010", Length = "0xA6")]
	[Token(Token = "0x6001279")]
	public XblStatisticChangedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2BB8A90", Offset = "0x2BB7E90", Length = "0x8E")]
	[Token(Token = "0x600127B")]
	public override IAsyncResult BeginInvoke(XblStatisticChangeEventArgs statisticChangeEventArgs, Void* context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600127C")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x2BB8BC0", Offset = "0x2BB7FC0", Length = "0x4A")]
	[Token(Token = "0x600127A")]
	public override void Invoke(XblStatisticChangeEventArgs statisticChangeEventArgs, Void* context) { }

}

