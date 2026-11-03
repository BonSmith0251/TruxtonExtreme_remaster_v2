namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200013D")]
public class XblAchievement
{
	[CompilerGenerated]
	[Token(Token = "0x200013E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000200")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000201")]
		public static Func<XblAchievementTitleAssociation, XblAchievementTitleAssociation> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000202")]
		public static Func<XblAchievementMediaAsset, XblAchievementMediaAsset> <>9__0_1; //Field offset: 0x10
		[Token(Token = "0x4000203")]
		public static Func<XblAchievementReward, XblAchievementReward> <>9__0_2; //Field offset: 0x18

		[Address(RVA = "0x2B7B620", Offset = "0x2B7AA20", Length = "0x67")]
		[Token(Token = "0x6000758")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000759")]
		public <>c() { }

		[Address(RVA = "0x2B71010", Offset = "0x2B70410", Length = "0x91")]
		[Token(Token = "0x600075A")]
		internal XblAchievementTitleAssociation <.ctor>b__0_0(XblAchievementTitleAssociation ta) { }

		[Address(RVA = "0x2B71230", Offset = "0x2B70630", Length = "0xD3")]
		[Token(Token = "0x600075B")]
		internal XblAchievementMediaAsset <.ctor>b__0_1(XblAchievementMediaAsset ma) { }

		[Address(RVA = "0x2B71310", Offset = "0x2B70710", Length = "0x70")]
		[Token(Token = "0x600075C")]
		internal XblAchievementReward <.ctor>b__0_2(XblAchievementReward reward) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001ED")]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001EE")]
	private string <ServiceConfigurationId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EF")]
	private string <Name>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F0")]
	private XblAchievementTitleAssociation[] <TitleAssociations>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F1")]
	private XblAchievementProgressState <ProgressState>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F2")]
	private XblAchievementProgression <Progression>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F3")]
	private XblAchievementMediaAsset[] <MediaAssets>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001F4")]
	private String[] <PlatformsAvailableOn>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001F5")]
	private bool <IsSecret>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F6")]
	private string <UnlockedDescription>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001F7")]
	private string <LockedDescription>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001F8")]
	private string <ProductId>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001F9")]
	private XblAchievementType <Type>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40001FA")]
	private XblAchievementParticipationType <ParticipationType>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001FB")]
	private XblAchievementTimeWindow <Available>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001FC")]
	private XblAchievementReward[] <Rewards>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001FD")]
	private ulong <EstimatedUnlockTime>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001FE")]
	private string <DeepLink>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001FF")]
	private bool <IsRevoked>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000080")]
	public private XblAchievementTimeWindow Available
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600074E")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600074F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000083")]
	public private string DeepLink
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000754")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000755")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000082")]
	public private ulong EstimatedUnlockTime
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000752")]
		 get { } //Length: 8
		[Address(RVA = "0x2144880", Offset = "0x2143C80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000753")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000072")]
	public private string Id
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000732")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000733")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000084")]
	public private bool IsRevoked
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000756")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000757")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700007A")]
	public private bool IsSecret
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000742")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000743")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700007C")]
	public private string LockedDescription
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000746")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x6000747")]
		private set { } //Length: 995
	}

	[Token(Token = "0x17000078")]
	public private XblAchievementMediaAsset[] MediaAssets
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600073E")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600073F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000074")]
	public private string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000736")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000737")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700007F")]
	public private XblAchievementParticipationType ParticipationType
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600074C")]
		 get { } //Length: 4
		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600074D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000079")]
	public private String[] PlatformsAvailableOn
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000740")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000741")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700007D")]
	public private string ProductId
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000748")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000749")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000077")]
	public private XblAchievementProgression Progression
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600073C")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600073D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000076")]
	public private XblAchievementProgressState ProgressState
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600073A")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600073B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000081")]
	public private XblAchievementReward[] Rewards
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000750")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6000751")]
		private set { } //Length: 16
	}

	[Token(Token = "0x17000073")]
	public private string ServiceConfigurationId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000734")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000735")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000075")]
	public private XblAchievementTitleAssociation[] TitleAssociations
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000738")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000739")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700007E")]
	public private XblAchievementType Type
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600074A")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600074B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700007B")]
	public private string UnlockedDescription
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000744")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000745")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B7D9C0", Offset = "0x2B7CDC0", Length = "0xCC6")]
	[Token(Token = "0x6000731")]
	internal XblAchievement(XblAchievement interopAchievement) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600074E")]
	public XblAchievementTimeWindow get_Available() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000754")]
	public string get_DeepLink() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000752")]
	public ulong get_EstimatedUnlockTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000732")]
	public string get_Id() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000756")]
	public bool get_IsRevoked() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000742")]
	public bool get_IsSecret() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000746")]
	public string get_LockedDescription() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600073E")]
	public XblAchievementMediaAsset[] get_MediaAssets() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000736")]
	public string get_Name() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600074C")]
	public XblAchievementParticipationType get_ParticipationType() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000740")]
	public String[] get_PlatformsAvailableOn() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000748")]
	public string get_ProductId() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600073C")]
	public XblAchievementProgression get_Progression() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600073A")]
	public XblAchievementProgressState get_ProgressState() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000750")]
	public XblAchievementReward[] get_Rewards() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000734")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000738")]
	public XblAchievementTitleAssociation[] get_TitleAssociations() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600074A")]
	public XblAchievementType get_Type() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000744")]
	public string get_UnlockedDescription() { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600074F")]
	private void set_Available(XblAchievementTimeWindow value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000755")]
	private void set_DeepLink(string value) { }

	[Address(RVA = "0x2144880", Offset = "0x2143C80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000753")]
	private void set_EstimatedUnlockTime(ulong value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000733")]
	private void set_Id(string value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000757")]
	private void set_IsRevoked(bool value) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000743")]
	private void set_IsSecret(bool value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x6000747")]
	private void set_LockedDescription(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600073F")]
	private void set_MediaAssets(XblAchievementMediaAsset[] value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000737")]
	private void set_Name(string value) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600074D")]
	private void set_ParticipationType(XblAchievementParticipationType value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000741")]
	private void set_PlatformsAvailableOn(String[] value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000749")]
	private void set_ProductId(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600073D")]
	private void set_Progression(XblAchievementProgression value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600073B")]
	private void set_ProgressState(XblAchievementProgressState value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x6000751")]
	private void set_Rewards(XblAchievementReward[] value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000735")]
	private void set_ServiceConfigurationId(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000739")]
	private void set_TitleAssociations(XblAchievementTitleAssociation[] value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600074B")]
	private void set_Type(XblAchievementType value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000745")]
	private void set_UnlockedDescription(string value) { }

}

