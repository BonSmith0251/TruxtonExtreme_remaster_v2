namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200026A")]
public class XStoreContext : EquatableHandle
{

	[Token(Token = "0x1700029E")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000CB0")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000CAE")]
	public XStoreContext(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000CB0")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B82A10", Offset = "0x2B81E10", Length = "0x24")]
	[Token(Token = "0x6000CAF")]
	protected virtual bool ReleaseHandle() { }

}

