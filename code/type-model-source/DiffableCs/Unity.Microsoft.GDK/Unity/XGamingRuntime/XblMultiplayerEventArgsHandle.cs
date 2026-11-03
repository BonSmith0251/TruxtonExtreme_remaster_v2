namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000191")]
public class XblMultiplayerEventArgsHandle : EquatableHandle
{

	[Token(Token = "0x1700013E")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B871B0", Offset = "0x2B865B0", Length = "0x1F")]
	[Token(Token = "0x60008C4")]
	internal XblMultiplayerEventArgsHandle(XblMultiplayerEventArgsHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x60008C7")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B841F0", Offset = "0x2B835F0", Length = "0xB")]
	[Token(Token = "0x60008C6")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B87110", Offset = "0x2B86510", Length = "0x94")]
	[Token(Token = "0x60008C5")]
	internal static int WrapInteropHandleAndReturnHResult(int hresult, XblMultiplayerEventArgsHandle interopHandle, out XblMultiplayerEventArgsHandle handle) { }

}

