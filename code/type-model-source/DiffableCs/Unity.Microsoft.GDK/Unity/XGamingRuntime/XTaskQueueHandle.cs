namespace Unity.XGamingRuntime;

[Token(Token = "0x200028C")]
public class XTaskQueueHandle : EquatableHandle
{

	[Token(Token = "0x170002E8")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000D71")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000D6F")]
	public XTaskQueueHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000D71")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B83FA0", Offset = "0x2B833A0", Length = "0x24")]
	[Token(Token = "0x6000D70")]
	protected virtual bool ReleaseHandle() { }

}

