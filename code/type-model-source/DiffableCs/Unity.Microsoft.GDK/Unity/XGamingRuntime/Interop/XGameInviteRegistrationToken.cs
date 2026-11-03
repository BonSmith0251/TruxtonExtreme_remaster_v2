namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000353")]
internal class XGameInviteRegistrationToken : XRegistrationToken<XGameInviteEventCallback>
{

	[Address(RVA = "0x2BA0FD0", Offset = "0x2BA03D0", Length = "0x116")]
	[Token(Token = "0x60011BD")]
	internal XGameInviteRegistrationToken(XGameInviteEventCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA0D50", Offset = "0x2BA0150", Length = "0x9B")]
	[Token(Token = "0x60011BF")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA0DF0", Offset = "0x2BA01F0", Length = "0x11E")]
	[MonoPInvokeCallback(typeof(XGameInviteEventCallback))]
	[Token(Token = "0x60011BC")]
	private static void OnInvite(IntPtr context, string inviteUri) { }

	[Address(RVA = "0x2BA0F10", Offset = "0x2BA0310", Length = "0xB7")]
	[Token(Token = "0x60011BE")]
	public bool Unregister(bool wait) { }

}

