namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200019E")]
public class XblMultiplayerSessionConstants
{
	[CompilerGenerated]
	[Token(Token = "0x200019F")]
	private sealed class <>c
	{
		[Token(Token = "0x40003FA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003FB")]
		public static Func<UInt64, UInt64> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x40003FC")]
		public static Func<XblMultiplayerMemberInitialization, XblMultiplayerMemberInitialization> <>9__0_1; //Field offset: 0x10

		[Address(RVA = "0x2B80580", Offset = "0x2B7F980", Length = "0x67")]
		[Token(Token = "0x600090A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600090B")]
		public <>c() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x600090C")]
		internal ulong <.ctor>b__0_0(ulong x) { }

		[Address(RVA = "0x2B80030", Offset = "0x2B7F430", Length = "0xA5")]
		[Token(Token = "0x600090D")]
		internal XblMultiplayerMemberInitialization <.ctor>b__0_1(XblMultiplayerMemberInitialization x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E5")]
	private readonly uint <MaxMembersInSession>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003E6")]
	private readonly XblMultiplayerSessionVisibility <Visibility>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E7")]
	private readonly UInt64[] <InitiatorXuids>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E8")]
	private readonly string <CustomJson>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003E9")]
	private readonly string <SessionCloudComputePackageConstantsJson>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003EA")]
	private readonly ulong <MemberReservedTimeout>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003EB")]
	private readonly ulong <MemberInactiveTimeout>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003EC")]
	private readonly ulong <MemberReadyTimeout>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003ED")]
	private readonly ulong <SessionEmptyTimeout>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003EE")]
	private readonly ulong <ArbitrationTimeout>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003EF")]
	private readonly ulong <ForfeitTimeout>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003F0")]
	private readonly bool <EnableMetricsLatency>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40003F1")]
	private readonly bool <EnableMetricsBandwidthDown>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x40003F2")]
	private readonly bool <EnableMetricsBandwidthUp>k__BackingField; //Field offset: 0x62
	[CompilerGenerated]
	[FieldOffset(Offset = "0x63")]
	[Token(Token = "0x40003F3")]
	private readonly bool <EnableMetricsCustom>k__BackingField; //Field offset: 0x63
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003F4")]
	private readonly XblMultiplayerMemberInitialization <MemberInitialization>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003F5")]
	private readonly XblMultiplayerPeerToPeerRequirements <PeerToPeerRequirements>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003F6")]
	private readonly XblMultiplayerPeerToHostRequirements <PeerToHostRequirements>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003F7")]
	private readonly string <MeasurementServerAddressesJson>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003F8")]
	private readonly bool <ClientMatchmakingCapable>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003F9")]
	private readonly XblMultiplayerSessionCapabilities <SessionCapabilities>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x1700016B")]
	public ulong ArbitrationTimeout
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000175")]
	public bool ClientMatchmakingCapable
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000908")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000165")]
	public string CustomJson
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016E")]
	public bool EnableMetricsBandwidthDown
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000901")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016F")]
	public bool EnableMetricsBandwidthUp
	{
		[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000902")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000170")]
	public bool EnableMetricsCustom
	{
		[Address(RVA = "0x2B88D50", Offset = "0x2B88150", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000903")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016D")]
	public bool EnableMetricsLatency
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000900")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016C")]
	public ulong ForfeitTimeout
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000164")]
	public UInt64[] InitiatorXuids
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000162")]
	public uint MaxMembersInSession
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60008F5")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000174")]
	public string MeasurementServerAddressesJson
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000907")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000168")]
	public ulong MemberInactiveTimeout
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000171")]
	public XblMultiplayerMemberInitialization MemberInitialization
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000904")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000169")]
	public ulong MemberReadyTimeout
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000167")]
	public ulong MemberReservedTimeout
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000173")]
	public XblMultiplayerPeerToHostRequirements PeerToHostRequirements
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000906")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000172")]
	public XblMultiplayerPeerToPeerRequirements PeerToPeerRequirements
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000905")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000176")]
	public XblMultiplayerSessionCapabilities SessionCapabilities
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000909")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000166")]
	public string SessionCloudComputePackageConstantsJson
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008F9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016A")]
	public ulong SessionEmptyTimeout
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008FD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000163")]
	public XblMultiplayerSessionVisibility Visibility
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008F6")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B88040", Offset = "0x2B87440", Length = "0xD08")]
	[Token(Token = "0x60008F4")]
	internal XblMultiplayerSessionConstants(XblMultiplayerSessionConstants interopStruct) { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FE")]
	public ulong get_ArbitrationTimeout() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000908")]
	public bool get_ClientMatchmakingCapable() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F8")]
	public string get_CustomJson() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000901")]
	public bool get_EnableMetricsBandwidthDown() { }

	[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000902")]
	public bool get_EnableMetricsBandwidthUp() { }

	[Address(RVA = "0x2B88D50", Offset = "0x2B88150", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000903")]
	public bool get_EnableMetricsCustom() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000900")]
	public bool get_EnableMetricsLatency() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FF")]
	public ulong get_ForfeitTimeout() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F7")]
	public UInt64[] get_InitiatorXuids() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60008F5")]
	public uint get_MaxMembersInSession() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000907")]
	public string get_MeasurementServerAddressesJson() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FB")]
	public ulong get_MemberInactiveTimeout() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000904")]
	public XblMultiplayerMemberInitialization get_MemberInitialization() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FC")]
	public ulong get_MemberReadyTimeout() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FA")]
	public ulong get_MemberReservedTimeout() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000906")]
	public XblMultiplayerPeerToHostRequirements get_PeerToHostRequirements() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000905")]
	public XblMultiplayerPeerToPeerRequirements get_PeerToPeerRequirements() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000909")]
	public XblMultiplayerSessionCapabilities get_SessionCapabilities() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008F9")]
	public string get_SessionCloudComputePackageConstantsJson() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008FD")]
	public ulong get_SessionEmptyTimeout() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008F6")]
	public XblMultiplayerSessionVisibility get_Visibility() { }

}

