namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000363")]
internal class XGameStreamingRegisterClientPropertiesChangedToken : XRegistrationToken<XGameStreamingClientPropertiesChangedCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009B2")]
	private XGameStreamingClientId clientId; //Field offset: 0x38

	[Address(RVA = "0x2BA20C0", Offset = "0x2BA14C0", Length = "0x12A")]
	[Token(Token = "0x60011D9")]
	public XGameStreamingRegisterClientPropertiesChangedToken(XGameStreamingClientId clientId, XGameStreamingClientPropertiesChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA1D10", Offset = "0x2BA1110", Length = "0xA8")]
	[Token(Token = "0x60011DC")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA1DC0", Offset = "0x2BA11C0", Length = "0x152")]
	[MonoPInvokeCallback(typeof(XGameStreamingClientPropertiesChangedCallback))]
	[Token(Token = "0x60011D8")]
	private static void OnClientPropertiesChanged(IntPtr context, XGameStreamingClientId client, uint updatedPropertiesCount, XGameStreamingClientProperty[] updatedProperties) { }

	[Address(RVA = "0x2BA1F20", Offset = "0x2BA1320", Length = "0xCC")]
	[Token(Token = "0x60011DA")]
	public bool Unregister(XGameStreamingClientId clientId, bool wait) { }

	[Address(RVA = "0x2BA1FF0", Offset = "0x2BA13F0", Length = "0xC7")]
	[Token(Token = "0x60011DB")]
	public bool Unregister(bool wait) { }

}

