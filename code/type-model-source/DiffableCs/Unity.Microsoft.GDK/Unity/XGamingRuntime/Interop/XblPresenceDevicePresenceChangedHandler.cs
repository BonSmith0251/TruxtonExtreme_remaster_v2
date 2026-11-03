namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000329")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XblPresenceDevicePresenceChangedHandler : MulticastDelegate
{

	[Address(RVA = "0x2BB7900", Offset = "0x2BB6D00", Length = "0xA6")]
	[Token(Token = "0x600118E")]
	public XblPresenceDevicePresenceChangedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2BB7830", Offset = "0x2BB6C30", Length = "0xC5")]
	[Token(Token = "0x6001190")]
	public override IAsyncResult BeginInvoke(IntPtr context, ulong xuid, XblPresenceDeviceType deviceType, bool isUserLoggedOnDevice, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6001191")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1C4CE30", Offset = "0x1C4C230", Length = "0x1D")]
	[Token(Token = "0x600118F")]
	public override void Invoke(IntPtr context, ulong xuid, XblPresenceDeviceType deviceType, bool isUserLoggedOnDevice) { }

}

