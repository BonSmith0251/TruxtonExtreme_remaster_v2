namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024B")]
public class XPackageMountHandle : EquatableHandle
{

	[Token(Token = "0x17000248")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000BC6")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000BC4")]
	public XPackageMountHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000BC6")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B82160", Offset = "0x2B81560", Length = "0x24")]
	[Token(Token = "0x6000BC5")]
	protected virtual bool ReleaseHandle() { }

}

