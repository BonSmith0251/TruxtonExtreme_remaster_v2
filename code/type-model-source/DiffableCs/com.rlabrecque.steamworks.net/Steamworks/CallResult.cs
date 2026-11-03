namespace Steamworks;

[Token(Token = "0x2000186")]
public abstract class CallResult
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008DC")]
	protected CallResult() { }

	[Token(Token = "0x60008D9")]
	internal abstract Type GetCallbackType() { }

	[Token(Token = "0x60008DA")]
	internal abstract void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall) { }

	[Token(Token = "0x60008DB")]
	internal abstract void SetUnregistered() { }

}

