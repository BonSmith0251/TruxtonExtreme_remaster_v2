namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200017F")]
public class XblMultiplayerSessionProperties
{
	[CompilerGenerated]
	[Token(Token = "0x2000180")]
	private sealed class <>c
	{
		[Token(Token = "0x4000336")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000337")]
		public static Func<UInt32, UInt32> <>9__0_0; //Field offset: 0x8
		[Token(Token = "0x4000338")]
		public static Func<UInt32, UInt32> <>9__0_1; //Field offset: 0x10

		[Address(RVA = "0x2B80740", Offset = "0x2B7FB40", Length = "0x67")]
		[Token(Token = "0x6000895")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000896")]
		public <>c() { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x6000897")]
		internal uint <.ctor>b__0_0(uint x) { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x6000898")]
		internal uint <.ctor>b__0_1(uint x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000327")]
	private readonly String[] <Keywords>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000328")]
	private readonly XblMultiplayerSessionRestriction <JoinRestriction>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000329")]
	private readonly XblMultiplayerSessionRestriction <ReadRestriction>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400032A")]
	private readonly UInt32[] <TurnCollection>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400032B")]
	private readonly string <MatchmakingTargetSessionConstantsJson>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400032C")]
	private readonly string <SessionCustomPropertiesJson>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400032D")]
	private readonly string <MatchmakingServerConnectionString>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400032E")]
	private readonly String[] <ServerConnectionStringCandidates>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400032F")]
	private readonly UInt32[] <SessionOwnerMemberIds>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000330")]
	private readonly XblDeviceToken <HostDeviceToken>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000331")]
	private readonly bool <Closed>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000332")]
	private readonly bool <Locked>k__BackingField; //Field offset: 0x59
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000333")]
	private readonly bool <AllocateCloudCompute>k__BackingField; //Field offset: 0x5A
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5B")]
	[Token(Token = "0x4000334")]
	private readonly bool <MatchmakingResubmit>k__BackingField; //Field offset: 0x5B
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000335")]
	private readonly XblMultiplayerSessionProperties <InteropHandle>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x17000125")]
	public bool AllocateCloudCompute
	{
		[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000892")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000123")]
	public bool Closed
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000890")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000122")]
	public XblDeviceToken HostDeviceToken
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000127")]
	internal XblMultiplayerSessionProperties InteropHandle
	{
		[Address(RVA = "0x2B8A020", Offset = "0x2B89420", Length = "0x63")]
		[CompilerGenerated]
		[Token(Token = "0x6000894")]
		internal get { } //Length: 99
	}

	[Token(Token = "0x1700011A")]
	public XblMultiplayerSessionRestriction JoinRestriction
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000887")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000119")]
	public String[] Keywords
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000886")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000124")]
	public bool Locked
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000891")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000126")]
	public bool MatchmakingResubmit
	{
		[Address(RVA = "0x2204BC0", Offset = "0x2203FC0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000893")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011F")]
	public string MatchmakingServerConnectionString
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011D")]
	public string MatchmakingTargetSessionConstantsJson
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011B")]
	public XblMultiplayerSessionRestriction ReadRestriction
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000888")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000120")]
	public String[] ServerConnectionStringCandidates
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011E")]
	public string SessionCustomPropertiesJson
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000121")]
	public UInt32[] SessionOwnerMemberIds
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600088E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011C")]
	public UInt32[] TurnCollection
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000889")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B89BE0", Offset = "0x2B88FE0", Length = "0x435")]
	[Token(Token = "0x6000885")]
	internal XblMultiplayerSessionProperties(XblMultiplayerSessionProperties interopHandle) { }

	[Address(RVA = "0x1CF2E00", Offset = "0x1CF2200", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000892")]
	public bool get_AllocateCloudCompute() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000890")]
	public bool get_Closed() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088F")]
	public XblDeviceToken get_HostDeviceToken() { }

	[Address(RVA = "0x2B8A020", Offset = "0x2B89420", Length = "0x63")]
	[CompilerGenerated]
	[Token(Token = "0x6000894")]
	internal XblMultiplayerSessionProperties get_InteropHandle() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000887")]
	public XblMultiplayerSessionRestriction get_JoinRestriction() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000886")]
	public String[] get_Keywords() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000891")]
	public bool get_Locked() { }

	[Address(RVA = "0x2204BC0", Offset = "0x2203FC0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000893")]
	public bool get_MatchmakingResubmit() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088C")]
	public string get_MatchmakingServerConnectionString() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088A")]
	public string get_MatchmakingTargetSessionConstantsJson() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000888")]
	public XblMultiplayerSessionRestriction get_ReadRestriction() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088D")]
	public String[] get_ServerConnectionStringCandidates() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088B")]
	public string get_SessionCustomPropertiesJson() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600088E")]
	public UInt32[] get_SessionOwnerMemberIds() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000889")]
	public UInt32[] get_TurnCollection() { }

}

