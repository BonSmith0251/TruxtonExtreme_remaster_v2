namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200025E")]
public class XSpeechSynthesizerStreamHandle : EquatableHandle
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000665")]
	private int <CloseResult>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000274")]
	public private int CloseResult
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C48")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C49")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000275")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000C4B")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000C47")]
	public XSpeechSynthesizerStreamHandle(IntPtr handle) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C48")]
	public int get_CloseResult() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000C4B")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B825D0", Offset = "0x2B819D0", Length = "0x2D")]
	[Token(Token = "0x6000C4A")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C49")]
	private void set_CloseResult(int value) { }

}

