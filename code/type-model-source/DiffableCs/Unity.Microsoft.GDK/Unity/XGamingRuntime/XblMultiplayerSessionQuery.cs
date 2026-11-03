namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200017C")]
public class XblMultiplayerSessionQuery
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000310")]
	private string <Scid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000311")]
	private uint <MaxItems>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000312")]
	private bool <IncludePrivateSessions>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000313")]
	private bool <IncludeReservations>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E")]
	[Token(Token = "0x4000314")]
	private bool <IncludeInactiveSessions>k__BackingField; //Field offset: 0x1E
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000315")]
	private UInt64[] <XuidFilters>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000316")]
	private string <KeywordFilter>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000317")]
	private string <SessionTemplateNameFilter>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000318")]
	private XblMultiplayerSessionVisibility <VisibilityFilter>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000319")]
	private uint <ContractVersionFilter>k__BackingField; //Field offset: 0x3C

	[Token(Token = "0x17000110")]
	public uint ContractVersionFilter
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600087A")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600087B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010B")]
	public bool IncludeInactiveSessions
	{
		[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000870")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000871")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000109")]
	public bool IncludePrivateSessions
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600086C")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600086D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010A")]
	public bool IncludeReservations
	{
		[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600086E")]
		 get { } //Length: 5
		[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600086F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010D")]
	public string KeywordFilter
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000874")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000875")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000108")]
	public uint MaxItems
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600086A")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600086B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000107")]
	public string Scid
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000868")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000869")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700010E")]
	public string SessionTemplateNameFilter
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000876")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000877")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700010F")]
	public XblMultiplayerSessionVisibility VisibilityFilter
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000878")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000879")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700010C")]
	public UInt64[] XuidFilters
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000872")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000873")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000867")]
	public XblMultiplayerSessionQuery() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600087A")]
	public uint get_ContractVersionFilter() { }

	[Address(RVA = "0x2B69C10", Offset = "0x2B69010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000870")]
	public bool get_IncludeInactiveSessions() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600086C")]
	public bool get_IncludePrivateSessions() { }

	[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600086E")]
	public bool get_IncludeReservations() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000874")]
	public string get_KeywordFilter() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600086A")]
	public uint get_MaxItems() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000868")]
	public string get_Scid() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000876")]
	public string get_SessionTemplateNameFilter() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000878")]
	public XblMultiplayerSessionVisibility get_VisibilityFilter() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000872")]
	public UInt64[] get_XuidFilters() { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600087B")]
	public void set_ContractVersionFilter(uint value) { }

	[Address(RVA = "0x2B81780", Offset = "0x2B80B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000871")]
	public void set_IncludeInactiveSessions(bool value) { }

	[Address(RVA = "0x2B81770", Offset = "0x2B80B70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600086D")]
	public void set_IncludePrivateSessions(bool value) { }

	[Address(RVA = "0x2B81760", Offset = "0x2B80B60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600086F")]
	public void set_IncludeReservations(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000875")]
	public void set_KeywordFilter(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600086B")]
	public void set_MaxItems(uint value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000869")]
	public void set_Scid(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000877")]
	public void set_SessionTemplateNameFilter(string value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000879")]
	public void set_VisibilityFilter(XblMultiplayerSessionVisibility value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000873")]
	public void set_XuidFilters(UInt64[] value) { }

}

