namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000169")]
public class XblMatchTicketDetailsResponse
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002AB")]
	private readonly XblTicketStatus <MatchStatus>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002AC")]
	private readonly long <EstimatedWaitTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002AD")]
	private readonly XblPreserveSessionMode <PreserveSession>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002AE")]
	private readonly XblMultiplayerSessionReference <TicketSession>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002AF")]
	private readonly XblMultiplayerSessionReference <TargetSession>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B0")]
	private readonly string <TicketAttributes>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000C2")]
	public long EstimatedWaitTime
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000808")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C1")]
	public XblTicketStatus MatchStatus
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000807")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000C3")]
	public XblPreserveSessionMode PreserveSession
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000809")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000C5")]
	public XblMultiplayerSessionReference TargetSession
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600080B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C6")]
	public string TicketAttributes
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600080C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C4")]
	public XblMultiplayerSessionReference TicketSession
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600080A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B863B0", Offset = "0x2B857B0", Length = "0x53B")]
	[Token(Token = "0x6000806")]
	internal XblMatchTicketDetailsResponse(XblMatchTicketDetailsResponse interopHandle) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000808")]
	public long get_EstimatedWaitTime() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000807")]
	public XblTicketStatus get_MatchStatus() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000809")]
	public XblPreserveSessionMode get_PreserveSession() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600080B")]
	public XblMultiplayerSessionReference get_TargetSession() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600080C")]
	public string get_TicketAttributes() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600080A")]
	public XblMultiplayerSessionReference get_TicketSession() { }

}

