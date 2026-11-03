namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000197")]
public class XblMultiplayerMemberInitialization
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C6")]
	private readonly ulong <JoinTimeout>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C7")]
	private readonly ulong <MeasurementTimeout>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C8")]
	private readonly ulong <EvaluationTimeout>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003C9")]
	private readonly bool <ExternalEvaluation>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003CA")]
	private readonly uint <MembersNeededToStart>k__BackingField; //Field offset: 0x2C

	[Token(Token = "0x1700014D")]
	public ulong EvaluationTimeout
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014E")]
	public bool ExternalEvaluation
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014B")]
	public ulong JoinTimeout
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014C")]
	public ulong MeasurementTimeout
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014F")]
	public uint MembersNeededToStart
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008DA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B879D0", Offset = "0x2B86DD0", Length = "0x77")]
	[Token(Token = "0x60008D5")]
	internal XblMultiplayerMemberInitialization(XblMultiplayerMemberInitialization interopStruct) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D8")]
	public ulong get_EvaluationTimeout() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D9")]
	public bool get_ExternalEvaluation() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D6")]
	public ulong get_JoinTimeout() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D7")]
	public ulong get_MeasurementTimeout() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008DA")]
	public uint get_MembersNeededToStart() { }

}

