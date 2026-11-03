namespace Unity.XGamingRuntime;

[Token(Token = "0x2000103")]
public class XAppCaptureLocalStreamHandle : EquatableHandle
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D2")]
	private int <CloseResult>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000065")]
	public private int CloseResult
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000644")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000645")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000066")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000647")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000643")]
	public XAppCaptureLocalStreamHandle(IntPtr handle) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000644")]
	public int get_CloseResult() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000647")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B7C0A0", Offset = "0x2B7B4A0", Length = "0x2D")]
	[Token(Token = "0x6000646")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000645")]
	private void set_CloseResult(int value) { }

}

