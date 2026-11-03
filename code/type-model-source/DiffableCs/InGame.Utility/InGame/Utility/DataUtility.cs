namespace InGame.Utility;

[Token(Token = "0x2000007")]
public static class DataUtility
{
	[Token(Token = "0x400000B")]
	public static readonly string _bulletTemplatePath; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	public static readonly string _bulletSelecterPath; //Field offset: 0x8
	[Token(Token = "0x400000D")]
	public static readonly string _enemyPath; //Field offset: 0x10
	[Token(Token = "0x400000E")]
	public static readonly string _obstaclePath; //Field offset: 0x18
	[Token(Token = "0x400000F")]
	public static readonly string _inGameObjectsPath; //Field offset: 0x20
	[Token(Token = "0x4000010")]
	public static readonly string _effectExplosionPath; //Field offset: 0x28
	[Token(Token = "0x4000011")]
	public static readonly string _effectSignBoardPath; //Field offset: 0x30
	[Token(Token = "0x4000012")]
	public static readonly string _inGameEnemyClipPath; //Field offset: 0x38
	[Token(Token = "0x4000013")]
	public static readonly string _inGameItemClipPath; //Field offset: 0x40

	[Address(RVA = "0x1DD6E20", Offset = "0x1DD6220", Length = "0x27A")]
	[Token(Token = "0x6000009")]
	private static DataUtility() { }

}

