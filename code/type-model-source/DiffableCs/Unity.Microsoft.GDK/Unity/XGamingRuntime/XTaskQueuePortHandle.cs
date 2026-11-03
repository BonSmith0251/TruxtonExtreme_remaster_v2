namespace Unity.XGamingRuntime;

[Token(Token = "0x200028D")]
public class XTaskQueuePortHandle : EquatableHandle
{

	[Token(Token = "0x170002E9")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000D74")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000D72")]
	public XTaskQueuePortHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000D74")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B841F0", Offset = "0x2B835F0", Length = "0xB")]
	[Token(Token = "0x6000D73")]
	protected virtual bool ReleaseHandle() { }

}

