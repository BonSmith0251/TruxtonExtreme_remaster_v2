namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200015E")]
public class XblLeaderboardColumn
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000271")]
	private string <StatName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000272")]
	private XblLeaderboardStatType <StatType>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000A2")]
	public private string StatName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60007BE")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170000A3")]
	public private XblLeaderboardStatType StatType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007BF")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007C0")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B7D960", Offset = "0x2B7CD60", Length = "0x55")]
	[Token(Token = "0x60007BC")]
	internal XblLeaderboardColumn(XblLeaderboardColumn interopColumn) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007BD")]
	public string get_StatName() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007BF")]
	public XblLeaderboardStatType get_StatType() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60007BE")]
	private void set_StatName(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007C0")]
	private void set_StatType(XblLeaderboardStatType value) { }

}

