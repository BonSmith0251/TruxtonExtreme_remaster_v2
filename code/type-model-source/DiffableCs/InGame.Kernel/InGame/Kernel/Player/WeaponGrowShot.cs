namespace InGame.Kernel.Player;

[Token(Token = "0x2000130")]
public class WeaponGrowShot : WeaponNormalShot
{
	[Token(Token = "0x4000889")]
	private static readonly Matrix4x4[] _exboostWaveL; //Field offset: 0x0
	[Token(Token = "0x400088A")]
	private static readonly Matrix4x4[] _exboostWaveR; //Field offset: 0x8
	[Token(Token = "0x400088B")]
	private static readonly int ExboostWaveCount; //Field offset: 0x10
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000887")]
	private int _exboostIndex; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000888")]
	private bool _isIndexRev; //Field offset: 0xF4

	[Token(Token = "0x170001B2")]
	protected virtual int MuzzleCreateCount
	{
		[Address(RVA = "0x1D5C4E0", Offset = "0x1D5B8E0", Length = "0x30")]
		[Token(Token = "0x6000978")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x1D5B0F0", Offset = "0x1D5A4F0", Length = "0x1391")]
	[Token(Token = "0x600097A")]
	private static WeaponGrowShot() { }

	[Address(RVA = "0x1D5C490", Offset = "0x1D5B890", Length = "0x49")]
	[Token(Token = "0x6000979")]
	public WeaponGrowShot() { }

	[Address(RVA = "0x1D5ACA0", Offset = "0x1D5A0A0", Length = "0xCD")]
	[Token(Token = "0x6000975")]
	public virtual int Fire(float dt, bool isExBoost) { }

	[Address(RVA = "0x1D5C4E0", Offset = "0x1D5B8E0", Length = "0x30")]
	[Token(Token = "0x6000978")]
	protected virtual int get_MuzzleCreateCount() { }

	[Address(RVA = "0x1D5AD70", Offset = "0x1D5A170", Length = "0x34D")]
	[Token(Token = "0x6000977")]
	protected virtual Vector3 GetShotDir(ShotDirectionData sdata, Quaternion lrot, bool isExBoost) { }

	[Address(RVA = "0x1D5B0C0", Offset = "0x1D5A4C0", Length = "0x21")]
	[Token(Token = "0x6000976")]
	public virtual void NoFire(float dt) { }

}

