namespace Unity.XGamingRuntime;

[Token(Token = "0x2000237")]
public class XGameUiTextEntryHandle : EquatableHandle
{

	[Token(Token = "0x17000230")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000B81")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000B7F")]
	public XGameUiTextEntryHandle(IntPtr handle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000B81")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B816F0", Offset = "0x2B80AF0", Length = "0x24")]
	[Token(Token = "0x6000B80")]
	protected virtual bool ReleaseHandle() { }

}

