namespace InGame.Kernel;

[Token(Token = "0x20000A7")]
public class ShortCutEffect
{
	[Token(Token = "0x20000A8")]
	internal enum Explosion : int
	{
		None = 0,
		E4Little = 1,
		E1Small = 2,
		E2Middle = 3,
		E3Large = 4,
		E5Huge = 5,
		Meteo01 = 6,
		Meteo02 = 7,
		Meteo03 = 8,
	}

	[Token(Token = "0x4000500")]
	public static readonly int ExplosionCodeLittle; //Field offset: 0x0
	[Token(Token = "0x4000501")]
	public static readonly int ExplosionCodeSmall; //Field offset: 0x4
	[Token(Token = "0x4000502")]
	public static readonly int ExplosionCodeMiddle; //Field offset: 0x8
	[Token(Token = "0x4000503")]
	public static readonly int ExplosionCodeLarge; //Field offset: 0xC
	[Token(Token = "0x4000504")]
	public static readonly int ExplosionCodeHuge; //Field offset: 0x10
	[Token(Token = "0x4000505")]
	private static readonly Int32[] ExplosionHashCode; //Field offset: 0x18
	[Token(Token = "0x4000506")]
	private static readonly Dictionary<Int32, Int32> _MuzzleEffects; //Field offset: 0x20
	[Token(Token = "0x4000507")]
	private static readonly Dictionary<Int32, Int32> _HitEffects; //Field offset: 0x28

	[Address(RVA = "0x1D40830", Offset = "0x1D3FC30", Length = "0x60E")]
	[Token(Token = "0x6000621")]
	private static ShortCutEffect() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000620")]
	public ShortCutEffect() { }

	[Address(RVA = "0x1D406C0", Offset = "0x1D3FAC0", Length = "0x6E")]
	[Token(Token = "0x600061D")]
	public static int GetHashCode(Explosion tindex) { }

	[Address(RVA = "0x1D40730", Offset = "0x1D3FB30", Length = "0x77")]
	[Token(Token = "0x600061F")]
	public static int GetHitEffectCode(BulletColorType ctype) { }

	[Address(RVA = "0x1D407B0", Offset = "0x1D3FBB0", Length = "0x77")]
	[Token(Token = "0x600061E")]
	public static int GetMuzzleEffectCode(BulletColorType ctype) { }

}

