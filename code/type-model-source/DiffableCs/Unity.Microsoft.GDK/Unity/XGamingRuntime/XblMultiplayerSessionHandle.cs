namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000174")]
public class XblMultiplayerSessionHandle : EquatableHandle
{

	[Token(Token = "0x170000DD")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x600082C")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x600082B")]
	internal XblMultiplayerSessionHandle(XblMultiplayerSessionHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x600082C")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B88DA0", Offset = "0x2B881A0", Length = "0x24")]
	[Token(Token = "0x600082E")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B88DD0", Offset = "0x2B881D0", Length = "0x94")]
	[Token(Token = "0x600082D")]
	internal static int WrapInteropHandleAndReturnHResult(int hresult, XblMultiplayerSessionHandle interopHandle, out XblMultiplayerSessionHandle sessionHandle) { }

}

