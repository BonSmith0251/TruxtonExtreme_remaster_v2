namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000218")]
public class XGameSaveProviderHandle : EquatableHandle
{

	[Token(Token = "0x17000203")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000B02")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000B00")]
	public XGameSaveProviderHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000B02")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B80FD0", Offset = "0x2B803D0", Length = "0x24")]
	[Token(Token = "0x6000B01")]
	protected virtual bool ReleaseHandle() { }

}

