namespace Unity.XGamingRuntime;

[Token(Token = "0x20002A2")]
public sealed class XUserDeviceAssociationChangedCallback : MulticastDelegate
{

	[Address(RVA = "0x60DC10", Offset = "0x60D010", Length = "0xA6")]
	[Token(Token = "0x6000DAF")]
	public XUserDeviceAssociationChangedCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B84B60", Offset = "0x2B83F60", Length = "0x6F")]
	[Token(Token = "0x6000DB1")]
	public override IAsyncResult BeginInvoke(IntPtr context, ref XUserDeviceAssociationChange change, AsyncCallback callback, object object) { }

	[Address(RVA = "0x1116830", Offset = "0x1115C30", Length = "0x1B")]
	[Token(Token = "0x6000DB2")]
	public override void EndInvoke(ref XUserDeviceAssociationChange change, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000DB0")]
	public override void Invoke(IntPtr context, ref XUserDeviceAssociationChange change) { }

}

