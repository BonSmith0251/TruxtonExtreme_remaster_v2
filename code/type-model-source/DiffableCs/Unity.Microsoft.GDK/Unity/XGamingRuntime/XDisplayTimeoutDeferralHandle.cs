namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200020B")]
public class XDisplayTimeoutDeferralHandle : EquatableHandle
{

	[Token(Token = "0x170001F2")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000ACC")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000ACA")]
	public XDisplayTimeoutDeferralHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000ACC")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B80B90", Offset = "0x2B7FF90", Length = "0x24")]
	[Token(Token = "0x6000ACB")]
	protected virtual bool ReleaseHandle() { }

}

