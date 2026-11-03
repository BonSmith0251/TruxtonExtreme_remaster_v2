namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000391")]
internal class GameLicenseChangedCallbackToken : XRegistrationToken<XStoreGameLicenseChangedCallback>
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A50")]
	private XStoreContext storeContext; //Field offset: 0x38

	[Address(RVA = "0x2B8E610", Offset = "0x2B8DA10", Length = "0x134")]
	[Token(Token = "0x6001217")]
	public GameLicenseChangedCallbackToken(XStoreContext storeContext, XStoreGameLicenseChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B8E370", Offset = "0x2B8D770", Length = "0xBA")]
	[Token(Token = "0x6001219")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2B8E430", Offset = "0x2B8D830", Length = "0x10B")]
	[MonoPInvokeCallback(typeof(XStoreGameLicenseChangedCallback))]
	[Token(Token = "0x6001216")]
	private static void OnGameLicenseChanged(IntPtr context) { }

	[Address(RVA = "0x2B8E540", Offset = "0x2B8D940", Length = "0xCE")]
	[Token(Token = "0x6001218")]
	public bool Unregister(bool wait) { }

}

