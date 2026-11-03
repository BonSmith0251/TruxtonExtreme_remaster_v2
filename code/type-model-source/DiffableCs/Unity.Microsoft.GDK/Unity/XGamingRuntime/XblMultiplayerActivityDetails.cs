namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200016D")]
public class XblMultiplayerActivityDetails
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002BD")]
	private readonly XblMultiplayerSessionReference <SessionReference>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002BE")]
	private readonly string <HandleId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002BF")]
	private readonly uint <TitleId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002C0")]
	private readonly XblMultiplayerSessionVisibility <Visibility>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002C1")]
	private readonly XblMultiplayerSessionRestriction <JoinRestriction>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002C2")]
	private readonly bool <Closed>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002C3")]
	private readonly ulong <OwnerXuid>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002C4")]
	private readonly uint <MaxMembersCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40002C5")]
	private readonly uint <MembersCount>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002C6")]
	private readonly string <CustomSessionPropertiesJson>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x170000CE")]
	public bool Closed
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000816")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D2")]
	public string CustomSessionPropertiesJson
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CA")]
	public string HandleId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000812")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CD")]
	public XblMultiplayerSessionRestriction JoinRestriction
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000815")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000D0")]
	public uint MaxMembersCount
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000818")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000D1")]
	public uint MembersCount
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000819")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000CF")]
	public ulong OwnerXuid
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000817")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C9")]
	public XblMultiplayerSessionReference SessionReference
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000811")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000CB")]
	public uint TitleId
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000813")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000CC")]
	public XblMultiplayerSessionVisibility Visibility
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000814")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B868F0", Offset = "0x2B85CF0", Length = "0x592")]
	[Token(Token = "0x6000810")]
	internal XblMultiplayerActivityDetails(XblMultiplayerActivityDetails interopHandle) { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000816")]
	public bool get_Closed() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081A")]
	public string get_CustomSessionPropertiesJson() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000812")]
	public string get_HandleId() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000815")]
	public XblMultiplayerSessionRestriction get_JoinRestriction() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000818")]
	public uint get_MaxMembersCount() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000819")]
	public uint get_MembersCount() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000817")]
	public ulong get_OwnerXuid() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000811")]
	public XblMultiplayerSessionReference get_SessionReference() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000813")]
	public uint get_TitleId() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000814")]
	public XblMultiplayerSessionVisibility get_Visibility() { }

}

