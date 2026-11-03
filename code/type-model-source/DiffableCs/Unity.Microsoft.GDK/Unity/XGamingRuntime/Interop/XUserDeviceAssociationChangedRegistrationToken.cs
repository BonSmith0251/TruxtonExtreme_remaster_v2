namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003AE")]
internal class XUserDeviceAssociationChangedRegistrationToken : XRegistrationToken<XUserDeviceAssociationChangedCallback>
{

	[Address(RVA = "0x2BA5FC0", Offset = "0x2BA53C0", Length = "0x116")]
	[Token(Token = "0x6001265")]
	public XUserDeviceAssociationChangedRegistrationToken(XUserDeviceAssociationChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA5D40", Offset = "0x2BA5140", Length = "0x11E")]
	[MonoPInvokeCallback(typeof(XUserDeviceAssociationChangedCallback))]
	[Token(Token = "0x6001264")]
	private static void DeviceAssociationChanged(IntPtr context, ref XUserDeviceAssociationChange change) { }

	[Address(RVA = "0x2BA5E60", Offset = "0x2BA5260", Length = "0x9B")]
	[Token(Token = "0x6001267")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA5F00", Offset = "0x2BA5300", Length = "0xB7")]
	[Token(Token = "0x6001266")]
	public bool Unregister(bool wait) { }

}

