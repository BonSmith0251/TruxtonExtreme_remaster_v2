namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200017D")]
public class XblMultiplayerSessionQueryResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400031A")]
	private readonly DateTime <StartTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400031B")]
	private readonly XblMultiplayerSessionReference <SessionReference>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031C")]
	private readonly XblMultiplayerSessionStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400031D")]
	private readonly XblMultiplayerSessionVisibility <Visibility>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031E")]
	private readonly bool <IsMyTurn>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031F")]
	private readonly ulong <Xuid>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000320")]
	private readonly uint <AcceptedMemberCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000321")]
	private readonly XblMultiplayerSessionRestriction <JoinRestriction>k__BackingField; //Field offset: 0x3C

	[Token(Token = "0x17000117")]
	public uint AcceptedMemberCount
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000883")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000115")]
	public bool IsMyTurn
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000881")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000118")]
	public XblMultiplayerSessionRestriction JoinRestriction
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000884")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000112")]
	public XblMultiplayerSessionReference SessionReference
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600087E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000111")]
	public DateTime StartTime
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600087D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000113")]
	public XblMultiplayerSessionStatus Status
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600087F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000114")]
	public XblMultiplayerSessionVisibility Visibility
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000880")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000116")]
	public ulong Xuid
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000882")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B8A090", Offset = "0x2B89490", Length = "0x4F4")]
	[Token(Token = "0x600087C")]
	internal XblMultiplayerSessionQueryResult(XblMultiplayerSessionQueryResult interopHandle) { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000883")]
	public uint get_AcceptedMemberCount() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000881")]
	public bool get_IsMyTurn() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000884")]
	public XblMultiplayerSessionRestriction get_JoinRestriction() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600087E")]
	public XblMultiplayerSessionReference get_SessionReference() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600087D")]
	public DateTime get_StartTime() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600087F")]
	public XblMultiplayerSessionStatus get_Status() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000880")]
	public XblMultiplayerSessionVisibility get_Visibility() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000882")]
	public ulong get_Xuid() { }

}

