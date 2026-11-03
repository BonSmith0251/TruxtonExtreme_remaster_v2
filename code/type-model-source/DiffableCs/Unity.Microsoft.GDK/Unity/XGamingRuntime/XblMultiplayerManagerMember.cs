namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000194")]
public class XblMultiplayerManagerMember
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039F")]
	private readonly uint <MemberId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A0")]
	private readonly string <TeamId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A1")]
	private readonly string <InitialTeam>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003A2")]
	private readonly ulong <Xuid>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003A3")]
	private readonly string <DebugGamertag>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003A4")]
	private readonly bool <IsLocal>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40003A5")]
	private readonly bool <IsInLobby>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x40003A6")]
	private readonly bool <IsInGame>k__BackingField; //Field offset: 0x3A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003A7")]
	private readonly XblMultiplayerSessionMemberStatus <Status>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003A8")]
	private readonly string <ConnectionAddress>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003A9")]
	private readonly string <PropertiesJson>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003AA")]
	private readonly string <DeviceToken>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000148")]
	public string ConnectionAddress
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000143")]
	public string DebugGamertag
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014A")]
	public string DeviceToken
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000141")]
	public string InitialTeam
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000146")]
	public bool IsInGame
	{
		[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000145")]
	public bool IsInLobby
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000144")]
	public bool IsLocal
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700013F")]
	public uint MemberId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60008C9")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000149")]
	public string PropertiesJson
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008D3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000147")]
	public XblMultiplayerSessionMemberStatus Status
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008D1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000140")]
	public string TeamId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000142")]
	public ulong Xuid
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B87370", Offset = "0x2B86770", Length = "0x28E")]
	[Token(Token = "0x60008C8")]
	internal XblMultiplayerManagerMember(XblMultiplayerManagerMember interopStruct) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D2")]
	public string get_ConnectionAddress() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CD")]
	public string get_DebugGamertag() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D4")]
	public string get_DeviceToken() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CB")]
	public string get_InitialTeam() { }

	[Address(RVA = "0x1EF8780", Offset = "0x1EF7B80", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D0")]
	public bool get_IsInGame() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CF")]
	public bool get_IsInLobby() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CE")]
	public bool get_IsLocal() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60008C9")]
	public uint get_MemberId() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008D3")]
	public string get_PropertiesJson() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008D1")]
	public XblMultiplayerSessionMemberStatus get_Status() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CA")]
	public string get_TeamId() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CC")]
	public ulong get_Xuid() { }

}

