namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A7")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XUserDeviceAssociationChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x6001258")]
	public XUserDeviceAssociationChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA5CA0", Offset = "0x2BA50A0", Length = "0x97")]
	[Token(Token = "0x600125A")]
	public override IAsyncResult BeginInvoke(IntPtr context, ref XUserDeviceAssociationChange change, AsyncCallback callback, object object) { }

	[Address(RVA = "0x1116830", Offset = "0x1115C30", Length = "0x1B")]
	[Token(Token = "0x600125B")]
	public override void EndInvoke(ref XUserDeviceAssociationChange change, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6001259")]
	public override void Invoke(IntPtr context, ref XUserDeviceAssociationChange change) { }

}

