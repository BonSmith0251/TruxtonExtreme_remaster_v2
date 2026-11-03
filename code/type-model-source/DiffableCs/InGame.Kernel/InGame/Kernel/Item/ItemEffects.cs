namespace InGame.Kernel.Item;

[Token(Token = "0x2000142")]
public class ItemEffects
{
	[Token(Token = "0x2000143")]
	internal enum Kind : int
	{
		None = 0,
		PlayerUp = 1,
		PowerUp = 2,
		SpeedUp = 4,
		PipilUp = 5,
		BombStock = 7,
		ScoreUp = 8,
		PlayerUp2 = 9,
		PlayerUp3 = 10,
		ArmNormal = 100,
		ArmBeam = 101,
		ArmLaser = 102,
		ArmGlow = 103,
		ArmHorming = 104,
		ArmGold = 105,
		ArmBlack = 106,
		ReferenceTable = 1000,
	}

	[Token(Token = "0x400093A")]
	private static readonly Dictionary<Kind, String> _itemObjectNames; //Field offset: 0x0
	[Token(Token = "0x400093B")]
	private static readonly Dictionary<Kind, String> _groundItemNames; //Field offset: 0x8

	[Address(RVA = "0x1D70400", Offset = "0x1D6F800", Length = "0x534")]
	[Token(Token = "0x6000A1E")]
	private static ItemEffects() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A1D")]
	public ItemEffects() { }

	[Address(RVA = "0x1D6FBA0", Offset = "0x1D6EFA0", Length = "0x31")]
	[Token(Token = "0x6000A1B")]
	public static int GetGroundItemCount(Kind ikind) { }

	[Address(RVA = "0x1D6FBE0", Offset = "0x1D6EFE0", Length = "0x1C6")]
	[Token(Token = "0x6000A1C")]
	public static Kind GetGroundItemKind(string tkind) { }

	[Address(RVA = "0x1D6FDB0", Offset = "0x1D6F1B0", Length = "0xA6")]
	[Token(Token = "0x6000A1A")]
	public static string GetGroundItemName(Kind ikind) { }

	[Address(RVA = "0x1D6FE60", Offset = "0x1D6F260", Length = "0xA5")]
	[Token(Token = "0x6000A19")]
	public static string GetItemName(Kind ikind) { }

	[Address(RVA = "0x1D6FF10", Offset = "0x1D6F310", Length = "0x328")]
	[Token(Token = "0x6000A18")]
	public static bool ItemEffectResult(PlayerControll player, PlayerInformation pinfo, Kind kind, int value) { }

	[Address(RVA = "0x1D703E0", Offset = "0x1D6F7E0", Length = "0x1C")]
	[Token(Token = "0x6000A17")]
	private static ID UpSE(Kind tkind) { }

}

