namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200021A")]
public class XGameSaveUpdateHandle : EquatableHandle
{

	[Token(Token = "0x17000205")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000B08")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000B06")]
	public XGameSaveUpdateHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000B08")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B81000", Offset = "0x2B80400", Length = "0x24")]
	[Token(Token = "0x6000B07")]
	protected virtual bool ReleaseHandle() { }

}

