namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000219")]
public class XGameSaveContainerHandle : EquatableHandle
{

	[Token(Token = "0x17000204")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000B05")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000B03")]
	public XGameSaveContainerHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000B05")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B80FA0", Offset = "0x2B803A0", Length = "0x24")]
	[Token(Token = "0x6000B04")]
	protected virtual bool ReleaseHandle() { }

}

