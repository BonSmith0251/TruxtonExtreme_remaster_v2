namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000171")]
public class XblMultiplayerSearchHandle : EquatableHandle
{

	[Token(Token = "0x170000D9")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000824")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000823")]
	internal XblMultiplayerSearchHandle(XblMultiplayerSearchHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000824")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B87BE0", Offset = "0x2B86FE0", Length = "0x24")]
	[Token(Token = "0x6000826")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B87C10", Offset = "0x2B87010", Length = "0x94")]
	[Token(Token = "0x6000825")]
	internal static int WrapInteropHandleAndReturnHResult(int hresult, XblMultiplayerSearchHandle interopHandle, out XblMultiplayerSearchHandle userHandle) { }

}

