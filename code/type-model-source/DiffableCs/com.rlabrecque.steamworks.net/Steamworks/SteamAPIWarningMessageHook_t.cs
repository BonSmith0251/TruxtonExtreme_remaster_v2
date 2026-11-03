namespace Steamworks;

[Token(Token = "0x20001B7")]
[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x60009DB")]
	public SteamAPIWarningMessageHook_t(object object, IntPtr method) { }

	[Address(RVA = "0x63A0C0", Offset = "0x6394C0", Length = "0x6B")]
	[Token(Token = "0x60009DD")]
	public override IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009DE")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60009DC")]
	public override void Invoke(int nSeverity, StringBuilder pchDebugText) { }

}

