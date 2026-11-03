namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000178")]
public class XblMultiplayerSessionMember
{
	[CompilerGenerated]
	[Token(Token = "0x2000179")]
	private sealed class <>c
	{
		[Token(Token = "0x4000308")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000309")]
		public static Func<XblMultiplayerSessionMemberRole, XblMultiplayerSessionMemberRole> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x400030A")]
		public static Func<UInt32, UInt32> <>9__0_1; //Field offset: 0x10

		[Address(RVA = "0x2B80820", Offset = "0x2B7FC20", Length = "0x67")]
		[Token(Token = "0x600085B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600085C")]
		public <>c() { }

		[Address(RVA = "0x2B7FA00", Offset = "0x2B7EE00", Length = "0x99")]
		[Token(Token = "0x600085D")]
		internal XblMultiplayerSessionMemberRole <.ctor>b__0_0(XblMultiplayerSessionMemberRole r) { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x600085E")]
		internal uint <.ctor>b__0_1(uint x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EC")]
	private readonly uint <MemberId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002ED")]
	private readonly string <TeamId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002EE")]
	private readonly string <InitialTeam>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002EF")]
	private readonly XblTournamentArbitrationStatus <ArbitrationStatus>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F0")]
	private readonly ulong <Xuid>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002F1")]
	private readonly string <CustomConstantsJson>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002F2")]
	private readonly string <SecureDeviceBaseAddress64>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002F3")]
	private readonly XblMultiplayerSessionMemberRole[] <Roles>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002F4")]
	private readonly string <CustomPropertiesJson>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002F5")]
	private readonly string <Gamertag>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002F6")]
	private readonly XblMultiplayerSessionMemberStatus <Status>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002F7")]
	private readonly bool <IsTurnAvailable>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x40002F8")]
	private readonly bool <IsCurrentUser>k__BackingField; //Field offset: 0x65
	[CompilerGenerated]
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x40002F9")]
	private readonly bool <InitializeRequested>k__BackingField; //Field offset: 0x66
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002FA")]
	private readonly string <MatchmakingResultServerMeasurementsJson>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002FB")]
	private readonly string <ServerMeasurementsJson>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002FC")]
	private readonly UInt32[] <MembersInGroupIds>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002FD")]
	private readonly string <QosMeasurementsJson>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002FE")]
	private readonly XblDeviceToken <DeviceToken>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002FF")]
	private readonly XblNetworkAddressTranslationSetting <Nat>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000300")]
	private readonly uint <ActiveTitleId>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000301")]
	private readonly uint <InitializationEpisode>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000302")]
	private readonly DateTime <JoinTime>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000303")]
	private readonly XblMultiplayerMeasurementFailure <InitializationFailureCause>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000304")]
	private readonly String[] <Groups>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000305")]
	private readonly String[] <Encounters>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000306")]
	private readonly XblMultiplayerSessionReference <TournamentTeamSessionReference>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000307")]
	private readonly XblMultiplayerSessionMember <InteropHandle>k__BackingField; //Field offset: 0xC8

	[Token(Token = "0x170000FA")]
	public uint ActiveTitleId
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000853")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000E9")]
	public XblTournamentArbitrationStatus ArbitrationStatus
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000842")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000EB")]
	public string CustomConstantsJson
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000844")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000EE")]
	public string CustomPropertiesJson
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000847")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F8")]
	public XblDeviceToken DeviceToken
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000851")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000FF")]
	public String[] Encounters
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000858")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EF")]
	public string Gamertag
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000848")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FE")]
	public String[] Groups
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000857")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000FB")]
	public uint InitializationEpisode
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000854")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000FD")]
	public XblMultiplayerMeasurementFailure InitializationFailureCause
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000856")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000F3")]
	public bool InitializeRequested
	{
		[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E8")]
	public string InitialTeam
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000841")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000101")]
	internal XblMultiplayerSessionMember InteropHandle
	{
		[Address(RVA = "0x2B89AC0", Offset = "0x2B88EC0", Length = "0x76")]
		[CompilerGenerated]
		[Token(Token = "0x600085A")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170000F2")]
	public bool IsCurrentUser
	{
		[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F1")]
	public bool IsTurnAvailable
	{
		[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000FC")]
	public DateTime JoinTime
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000855")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F4")]
	public string MatchmakingResultServerMeasurementsJson
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000E6")]
	public uint MemberId
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600083F")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000F6")]
	public UInt32[] MembersInGroupIds
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F9")]
	public XblNetworkAddressTranslationSetting Nat
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000852")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170000F7")]
	public string QosMeasurementsJson
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000850")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000ED")]
	public XblMultiplayerSessionMemberRole[] Roles
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000846")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000EC")]
	public string SecureDeviceBaseAddress64
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000845")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F5")]
	public string ServerMeasurementsJson
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600084E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F0")]
	public XblMultiplayerSessionMemberStatus Status
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000849")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000E7")]
	public string TeamId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000840")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000100")]
	public XblMultiplayerSessionReference TournamentTeamSessionReference
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000859")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EA")]
	public ulong Xuid
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000843")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B88F60", Offset = "0x2B88360", Length = "0xB57")]
	[Token(Token = "0x600083E")]
	internal XblMultiplayerSessionMember(XblMultiplayerSessionMember interopHandle) { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000853")]
	public uint get_ActiveTitleId() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000842")]
	public XblTournamentArbitrationStatus get_ArbitrationStatus() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000844")]
	public string get_CustomConstantsJson() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000847")]
	public string get_CustomPropertiesJson() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000851")]
	public XblDeviceToken get_DeviceToken() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000858")]
	public String[] get_Encounters() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000848")]
	public string get_Gamertag() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000857")]
	public String[] get_Groups() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000854")]
	public uint get_InitializationEpisode() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000856")]
	public XblMultiplayerMeasurementFailure get_InitializationFailureCause() { }

	[Address(RVA = "0x23382C0", Offset = "0x23376C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084C")]
	public bool get_InitializeRequested() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000841")]
	public string get_InitialTeam() { }

	[Address(RVA = "0x2B89AC0", Offset = "0x2B88EC0", Length = "0x76")]
	[CompilerGenerated]
	[Token(Token = "0x600085A")]
	internal XblMultiplayerSessionMember get_InteropHandle() { }

	[Address(RVA = "0x2338DA0", Offset = "0x23381A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084B")]
	public bool get_IsCurrentUser() { }

	[Address(RVA = "0x29B71F0", Offset = "0x29B65F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084A")]
	public bool get_IsTurnAvailable() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000855")]
	public DateTime get_JoinTime() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084D")]
	public string get_MatchmakingResultServerMeasurementsJson() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600083F")]
	public uint get_MemberId() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084F")]
	public UInt32[] get_MembersInGroupIds() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000852")]
	public XblNetworkAddressTranslationSetting get_Nat() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000850")]
	public string get_QosMeasurementsJson() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000846")]
	public XblMultiplayerSessionMemberRole[] get_Roles() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000845")]
	public string get_SecureDeviceBaseAddress64() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600084E")]
	public string get_ServerMeasurementsJson() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000849")]
	public XblMultiplayerSessionMemberStatus get_Status() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000840")]
	public string get_TeamId() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000859")]
	public XblMultiplayerSessionReference get_TournamentTeamSessionReference() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000843")]
	public ulong get_Xuid() { }

}

