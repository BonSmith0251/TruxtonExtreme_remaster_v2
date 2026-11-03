namespace InGame.Utility;

[Token(Token = "0x2000009")]
public class LayerUtility
{
	[Token(Token = "0x4000014")]
	public static readonly int NoneLayer; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	private static readonly int DefaultLayer; //Field offset: 0x4
	[Token(Token = "0x4000016")]
	public static readonly int EnemyBulletLayer; //Field offset: 0x8
	[Token(Token = "0x4000017")]
	public static readonly int PlayerBulletLayer; //Field offset: 0xC
	[Token(Token = "0x4000018")]
	public static readonly int PlayerBombLayer; //Field offset: 0x10
	[Token(Token = "0x4000019")]
	public static readonly int PlayerLayer; //Field offset: 0x14
	[Token(Token = "0x400001A")]
	public static readonly int EnemyBullet; //Field offset: 0x18
	[Token(Token = "0x400001B")]
	public static readonly int EnemyLayer; //Field offset: 0x1C
	[Token(Token = "0x400001C")]
	public static readonly int EnemySkyLayer; //Field offset: 0x20
	[Token(Token = "0x400001D")]
	public static readonly int EnemyGroundLayer; //Field offset: 0x24
	[Token(Token = "0x400001E")]
	public static readonly int NeutralObjectLayer; //Field offset: 0x28
	[Token(Token = "0x400001F")]
	public static readonly int ItemLayer; //Field offset: 0x2C
	[Token(Token = "0x4000020")]
	public static readonly int BGSkyLayer; //Field offset: 0x30
	[Token(Token = "0x4000021")]
	public static readonly int BGObjectLayer; //Field offset: 0x34
	[Token(Token = "0x4000022")]
	public static readonly int CastShadowLayer; //Field offset: 0x38
	[Token(Token = "0x4000023")]
	public static readonly int PhysicsLayer; //Field offset: 0x3C
	[Token(Token = "0x4000024")]
	public static readonly int UILayer; //Field offset: 0x40
	[Token(Token = "0x4000025")]
	public static readonly int BGMasked; //Field offset: 0x44
	[Token(Token = "0x4000026")]
	public static readonly int MainMasked; //Field offset: 0x48
	[Token(Token = "0x4000027")]
	public static readonly int SortingLayerDefault; //Field offset: 0x4C
	[Token(Token = "0x4000028")]
	public static readonly int SortingLayerBG; //Field offset: 0x50
	[Token(Token = "0x4000029")]
	public static readonly int SortingLayerBGEffect; //Field offset: 0x54
	[Token(Token = "0x400002A")]
	public static readonly int SortingLayerBomb; //Field offset: 0x58
	[Token(Token = "0x400002B")]
	public static readonly int SortingLayerJewel; //Field offset: 0x5C
	[Token(Token = "0x400002C")]
	public static readonly int SortingLayerBullet; //Field offset: 0x60
	[Token(Token = "0x400002D")]
	public static readonly int SortingLayerPlayerBullet; //Field offset: 0x64
	[Token(Token = "0x400002E")]
	public static readonly int SortingLayerEffectBurn; //Field offset: 0x68
	[Token(Token = "0x400002F")]
	public static readonly int SortingLayerPlayerAndEnemy; //Field offset: 0x6C
	[Token(Token = "0x4000030")]
	public static readonly int SortingLayerUI; //Field offset: 0x70

	[Address(RVA = "0x1DD85E0", Offset = "0x1DD79E0", Length = "0x503")]
	[Token(Token = "0x600001E")]
	private static LayerUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600001D")]
	public LayerUtility() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600001C")]
	public static bool CheckNoTarget(GameObject tobj, int targetLayer) { }

	[Address(RVA = "0x1DD7770", Offset = "0x1DD6B70", Length = "0x7C")]
	[Token(Token = "0x600000F")]
	public static bool IsBullet(int n) { }

	[Address(RVA = "0x1DD7850", Offset = "0x1DD6C50", Length = "0xBD")]
	[Token(Token = "0x6000010")]
	public static bool IsEnemy(int n) { }

	[Address(RVA = "0x1DD77F0", Offset = "0x1DD6BF0", Length = "0x56")]
	[Token(Token = "0x6000011")]
	public static bool IsEnemyBullet(int n) { }

	[Address(RVA = "0x1DD7910", Offset = "0x1DD6D10", Length = "0x56")]
	[Token(Token = "0x6000015")]
	public static bool IsGround(int n) { }

	[Address(RVA = "0x1DD7970", Offset = "0x1DD6D70", Length = "0x56")]
	[Token(Token = "0x6000014")]
	public static bool IsNeutral(int n) { }

	[Address(RVA = "0x1DD79D0", Offset = "0x1DD6DD0", Length = "0x55")]
	[Token(Token = "0x6000013")]
	public static bool IsNone(int n) { }

	[Address(RVA = "0x1DD7A90", Offset = "0x1DD6E90", Length = "0x56")]
	[Token(Token = "0x600001A")]
	public static bool IsPlayer(int n) { }

	[Address(RVA = "0x1DD7A30", Offset = "0x1DD6E30", Length = "0x56")]
	[Token(Token = "0x6000012")]
	public static bool IsPlayerBullet(int n) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600001B")]
	public static bool IsTestClear() { }

	[Address(RVA = "0x1DD7AF0", Offset = "0x1DD6EF0", Length = "0x332")]
	[Token(Token = "0x6000016")]
	public static void SetEnemyLayer(GameObject tobj, int targetLayer) { }

	[Address(RVA = "0x1DD7E30", Offset = "0x1DD7230", Length = "0x255")]
	[Token(Token = "0x6000017")]
	public static void SetLayerForce(GameObject tobj, int targetLayer) { }

	[Address(RVA = "0x1DD8090", Offset = "0x1DD7490", Length = "0x2C2")]
	[Token(Token = "0x6000018")]
	public static void SetLayerIfDefault(GameObject tobj, int targetLayer) { }

	[Address(RVA = "0x1DD8360", Offset = "0x1DD7760", Length = "0x27D")]
	[Token(Token = "0x6000019")]
	public static void SetLayerIfTarget(GameObject tobj, int wannabeLayer, int targetLayer) { }

}

