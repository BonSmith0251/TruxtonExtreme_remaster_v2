namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200015F")]
public class XblLeaderboardQuery
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000273")]
	private ulong <XboxUserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000274")]
	private string <ServiceConfigurationId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000275")]
	private string <LeaderboardName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000276")]
	private string <StatName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000277")]
	private XblSocialGroupType <SocialGroup>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000278")]
	private String[] <AdditionalColumnleaderboardNames>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000279")]
	private XblLeaderboardSortOrder <Order>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400027A")]
	private uint <MaxItems>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400027B")]
	private ulong <SkipToXboxUserId>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400027C")]
	private uint <SkipResultToRank>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400027D")]
	private string <ContinuationToken>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400027E")]
	private XblLeaderboardQueryType <QueryType>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170000A9")]
	public private String[] AdditionalColumnleaderboardNames
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007CE")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007CF")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000AE")]
	public private string ContinuationToken
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007D8")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007D9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000A6")]
	public private string LeaderboardName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007C8")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007C9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000AB")]
	public private uint MaxItems
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D2")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000AA")]
	public private XblLeaderboardSortOrder Order
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D0")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D1")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000AF")]
	public private XblLeaderboardQueryType QueryType
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 4
		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007DB")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000A5")]
	public private string ServiceConfigurationId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007C7")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000AD")]
	public private uint SkipResultToRank
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D6")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D7")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000AC")]
	public private ulong SkipToXboxUserId
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007D4")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007D5")]
		private set { } //Length: 5
	}

	[Token(Token = "0x170000A8")]
	public private XblSocialGroupType SocialGroup
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007CC")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007CD")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000A7")]
	public private string StatName
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007CA")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007CB")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000A4")]
	public private ulong XboxUserId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007C4")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007C5")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B7EC30", Offset = "0x2B7E030", Length = "0xCB")]
	[Token(Token = "0x60007C1")]
	private XblLeaderboardQuery(ulong xboxUserId, string serviceConfigurationId, string leaderboardName, string statName, XblSocialGroupType socialGroup, String[] additionalColumnleaderboardNames, XblLeaderboardSortOrder order, uint maxItems, ulong skipToXboxUserId, uint skipResultToRank, string continuationToken, XblLeaderboardQueryType queryType) { }

	[Address(RVA = "0x2B7ED00", Offset = "0x2B7E100", Length = "0x176")]
	[Token(Token = "0x60007C2")]
	internal XblLeaderboardQuery(XblLeaderboardQuery interopLeaderboardQuery) { }

	[Address(RVA = "0x2B7EAE0", Offset = "0x2B7DEE0", Length = "0x144")]
	[Token(Token = "0x60007C3")]
	public static int Create(ulong xboxUserId, string serviceConfigurationId, string leaderboardName, string statName, XblSocialGroupType socialGroup, String[] additionalColumnleaderboardNames, XblLeaderboardSortOrder order, uint maxItems, ulong skipToXboxUserId, uint skipResultToRank, string continuationToken, XblLeaderboardQueryType queryType, out XblLeaderboardQuery leaderboardQuery) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007CE")]
	public String[] get_AdditionalColumnleaderboardNames() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007D8")]
	public string get_ContinuationToken() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007C8")]
	public string get_LeaderboardName() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D2")]
	public uint get_MaxItems() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D0")]
	public XblLeaderboardSortOrder get_Order() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DA")]
	public XblLeaderboardQueryType get_QueryType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007C6")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D6")]
	public uint get_SkipResultToRank() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007D4")]
	public ulong get_SkipToXboxUserId() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007CC")]
	public XblSocialGroupType get_SocialGroup() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007CA")]
	public string get_StatName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007C4")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007CF")]
	private void set_AdditionalColumnleaderboardNames(String[] value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007D9")]
	private void set_ContinuationToken(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007C9")]
	private void set_LeaderboardName(string value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D3")]
	private void set_MaxItems(uint value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D1")]
	private void set_Order(XblLeaderboardSortOrder value) { }

	[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007DB")]
	private void set_QueryType(XblLeaderboardQueryType value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007C7")]
	private void set_ServiceConfigurationId(string value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D7")]
	private void set_SkipResultToRank(uint value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007D5")]
	private void set_SkipToXboxUserId(ulong value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007CD")]
	private void set_SocialGroup(XblSocialGroupType value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007CB")]
	private void set_StatName(string value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007C5")]
	private void set_XboxUserId(ulong value) { }

}

