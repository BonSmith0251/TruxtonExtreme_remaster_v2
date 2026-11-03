namespace Unity.XGamingRuntime;

[Token(Token = "0x200026C")]
public class XStoreProductQuery : EquatableHandle
{

	[Token(Token = "0x170002A0")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000CB6")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000CB4")]
	public XStoreProductQuery(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000CB6")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B82AF0", Offset = "0x2B81EF0", Length = "0x24")]
	[Token(Token = "0x6000CB5")]
	protected virtual bool ReleaseHandle() { }

}

