namespace Steamworks;

[Token(Token = "0x20001B8")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate
{

	[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
	[Token(Token = "0x60009DF")]
	public SteamAPI_CheckCallbackRegistered_t(object object, IntPtr method) { }

	[Address(RVA = "0x63A130", Offset = "0x639530", Length = "0x5D")]
	[Token(Token = "0x60009E1")]
	public override IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x60009E2")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x60009E0")]
	public override void Invoke(int iCallbackNum) { }

}

