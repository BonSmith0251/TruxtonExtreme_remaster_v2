namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000189")]
public class XblMultiplayerActivityInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035F")]
	private ulong <Xuid>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000360")]
	private string <ConnectionString>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000361")]
	private XblMultiplayerActivityJoinRestriction <JoinRestriction>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000362")]
	private uint <MaxPlayers>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000363")]
	private uint <CurrentPlayers>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000364")]
	private string <GroupId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000365")]
	private XblMultiplayerActivityPlatform <Platform>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x1700012C")]
	public string ConnectionString
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008A4")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60008A5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700012F")]
	public uint CurrentPlayers
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008AA")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008AB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000130")]
	public string GroupId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60008AD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700012D")]
	public XblMultiplayerActivityJoinRestriction JoinRestriction
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008A6")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008A7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700012E")]
	public uint MaxPlayers
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008A8")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008A9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000131")]
	public XblMultiplayerActivityPlatform Platform
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008AE")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008AF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700012B")]
	public ulong Xuid
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008A2")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008A3")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008A0")]
	public XblMultiplayerActivityInfo() { }

	[Address(RVA = "0x2B86E90", Offset = "0x2B86290", Length = "0x14A")]
	[Token(Token = "0x60008A1")]
	internal XblMultiplayerActivityInfo(XblMultiplayerActivityInfo interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008A4")]
	public string get_ConnectionString() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008AA")]
	public uint get_CurrentPlayers() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008AC")]
	public string get_GroupId() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008A6")]
	public XblMultiplayerActivityJoinRestriction get_JoinRestriction() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008A8")]
	public uint get_MaxPlayers() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008AE")]
	public XblMultiplayerActivityPlatform get_Platform() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008A2")]
	public ulong get_Xuid() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60008A5")]
	public void set_ConnectionString(string value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008AB")]
	public void set_CurrentPlayers(uint value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60008AD")]
	public void set_GroupId(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008A7")]
	public void set_JoinRestriction(XblMultiplayerActivityJoinRestriction value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008A9")]
	public void set_MaxPlayers(uint value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008AF")]
	public void set_Platform(XblMultiplayerActivityPlatform value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008A3")]
	public void set_Xuid(ulong value) { }

}

