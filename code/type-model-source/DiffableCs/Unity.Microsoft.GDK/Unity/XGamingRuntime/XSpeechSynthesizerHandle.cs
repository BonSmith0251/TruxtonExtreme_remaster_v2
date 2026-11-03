namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200025D")]
public class XSpeechSynthesizerHandle : EquatableHandle
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000664")]
	private int <CloseResult>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000272")]
	public private int CloseResult
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C43")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C44")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000273")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000C46")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000C42")]
	public XSpeechSynthesizerHandle(IntPtr handle) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C43")]
	public int get_CloseResult() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000C46")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B82440", Offset = "0x2B81840", Length = "0x2D")]
	[Token(Token = "0x6000C45")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C44")]
	private void set_CloseResult(int value) { }

}

