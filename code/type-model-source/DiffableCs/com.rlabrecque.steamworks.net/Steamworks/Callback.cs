namespace Steamworks;

[Token(Token = "0x2000183")]
public abstract class Callback
{

	[Token(Token = "0x17000022")]
	public abstract bool IsGameServer
	{
		[Token(Token = "0x60008C3")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008C7")]
	protected Callback() { }

	[Token(Token = "0x60008C3")]
	public abstract bool get_IsGameServer() { }

	[Token(Token = "0x60008C4")]
	internal abstract Type GetCallbackType() { }

	[Token(Token = "0x60008C5")]
	internal abstract void OnRunCallback(IntPtr pvParam) { }

	[Token(Token = "0x60008C6")]
	internal abstract void SetUnregistered() { }

}

