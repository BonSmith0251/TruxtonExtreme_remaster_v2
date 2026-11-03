namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200024A")]
public class XPackageInstallationMonitorHandle : EquatableHandle
{

	[Token(Token = "0x17000247")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000BC3")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000BC1")]
	public XPackageInstallationMonitorHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000BC3")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B82100", Offset = "0x2B81500", Length = "0x24")]
	[Token(Token = "0x6000BC2")]
	protected virtual bool ReleaseHandle() { }

}

