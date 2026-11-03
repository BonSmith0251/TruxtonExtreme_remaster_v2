namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001E5")]
public class Ene_Mc01 : PawnEnemy
{
	[Token(Token = "0x20001E6")]
	internal class BulletData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010C9")]
		public BulletTemplate _bt; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010CA")]
		public string BTname; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010CB")]
		public float Time; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010CC")]
		public Transform _muzzle; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EA5")]
		public BulletData() { }

	}

	[Token(Token = "0x40010C1")]
	private static readonly float FireTime; //Field offset: 0x0
	[Token(Token = "0x40010C2")]
	private static readonly float AnimationTime; //Field offset: 0x4
	[Token(Token = "0x40010C3")]
	private static readonly float AnimationLoopTime; //Field offset: 0x8
	[Token(Token = "0x40010C4")]
	private static readonly float NoDamageTime; //Field offset: 0xC
	[Token(Token = "0x40010C5")]
	private static readonly float NoDamageDuration; //Field offset: 0x10
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x40010C0")]
	private BulletData[] _bulletData; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40010C6")]
	private float _timer; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40010C7")]
	private int _openAnimationHash; //Field offset: 0x1BC
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40010C8")]
	private int _closeAnimationHash; //Field offset: 0x1C0

	[Address(RVA = "0x1DC1A50", Offset = "0x1DC0E50", Length = "0x1B2")]
	[Token(Token = "0x6000EA0")]
	private void _onBulletFire(CancellationToken token, RouteEvent _event) { }

	[Address(RVA = "0x1DC1960", Offset = "0x1DC0D60", Length = "0x94")]
	[Token(Token = "0x6000EA4")]
	private static Ene_Mc01() { }

	[Address(RVA = "0x1DC1A00", Offset = "0x1DC0E00", Length = "0x49")]
	[Token(Token = "0x6000EA3")]
	public Ene_Mc01() { }

	[Address(RVA = "0x1DC1030", Offset = "0x1DC0430", Length = "0x12C")]
	[Token(Token = "0x6000E9F")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1DC12B0", Offset = "0x1DC06B0", Length = "0x9E")]
	[Token(Token = "0x6000E9C")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1DC1160", Offset = "0x1DC0560", Length = "0x146")]
	[Token(Token = "0x6000E9E")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1DC1350", Offset = "0x1DC0750", Length = "0x4DF")]
	[Token(Token = "0x6000EA2")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1DC1830", Offset = "0x1DC0C30", Length = "0xEC")]
	[Token(Token = "0x6000EA1")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DC1920", Offset = "0x1DC0D20", Length = "0x30")]
	[Token(Token = "0x6000E9D")]
	public virtual void Terminate() { }

}

