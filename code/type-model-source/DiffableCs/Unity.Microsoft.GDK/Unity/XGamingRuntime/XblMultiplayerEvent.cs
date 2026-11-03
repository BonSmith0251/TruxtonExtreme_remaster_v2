namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000190")]
public class XblMultiplayerEvent
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037B")]
	private readonly int <Result>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037C")]
	private readonly string <ErrorMessage>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037D")]
	private readonly object <Context>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037E")]
	private readonly XblMultiplayerEventType <EventType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400037F")]
	private readonly XblMultiplayerEventArgsHandle <EventArgsHandle>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000380")]
	private readonly XblMultiplayerSessionType <SessionType>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700013A")]
	public object Context
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008C0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000139")]
	public string ErrorMessage
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008BF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013C")]
	public XblMultiplayerEventArgsHandle EventArgsHandle
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008C2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013B")]
	public XblMultiplayerEventType EventType
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000138")]
	public int Result
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60008BE")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700013D")]
	public XblMultiplayerSessionType SessionType
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B871D0", Offset = "0x2B865D0", Length = "0x195")]
	[Token(Token = "0x60008BD")]
	internal XblMultiplayerEvent(XblMultiplayerEvent interopStruct) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008C0")]
	public object get_Context() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008BF")]
	public string get_ErrorMessage() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008C2")]
	public XblMultiplayerEventArgsHandle get_EventArgsHandle() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008C1")]
	public XblMultiplayerEventType get_EventType() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60008BE")]
	public int get_Result() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008C3")]
	public XblMultiplayerSessionType get_SessionType() { }

}

