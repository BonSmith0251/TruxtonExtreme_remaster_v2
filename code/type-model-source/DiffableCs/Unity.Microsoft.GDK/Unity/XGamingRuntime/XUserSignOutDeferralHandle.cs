namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20002A7")]
public class XUserSignOutDeferralHandle : EquatableHandle
{

	[Token(Token = "0x17000303")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000DCC")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000DCA")]
	public XUserSignOutDeferralHandle(IntPtr interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000DCC")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2BA6230", Offset = "0x2BA5630", Length = "0x8F")]
	[Token(Token = "0x6000DCB")]
	protected virtual bool ReleaseHandle() { }

}

