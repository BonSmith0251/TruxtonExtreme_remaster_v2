namespace InGame.Kernel.Player;

[Token(Token = "0x200013B")]
public class WeaponNormalShot : WeaponBaseShot, IWeapons
{
	[CompilerGenerated]
	[Token(Token = "0x200013C")]
	private sealed class <>c__DisplayClass18_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000929")]
		public WeaponNormalShot <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400092A")]
		public int tindex; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009FB")]
		public <>c__DisplayClass18_0() { }

		[Address(RVA = "0x1D73DA0", Offset = "0x1D731A0", Length = "0x30")]
		[Token(Token = "0x60009FC")]
		internal void <FireBySData>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200013D")]
	private sealed class <Initialize>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400092B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400092C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400092D")]
		public WeaponNormalShot <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400092E")]
		public Transform gameroot; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400092F")]
		public int pno; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000930")]
		public Transform poolroot; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000931")]
		public Transform[] emitTable; //Field offset: 0x40

		[Token(Token = "0x170001BD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000A00")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001BE")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000A02")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60009FD")]
		public <Initialize>d__0(int <>1__state) { }

		[Address(RVA = "0x1D72F80", Offset = "0x1D72380", Length = "0x5AD")]
		[Token(Token = "0x60009FF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000A00")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000A02")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D73910", Offset = "0x1D72D10", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000A01")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60009FE")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000928")]
	private const float _exBoostSpeed = 1.75; //Field offset: 0x0
	[Token(Token = "0x4000910")]
	private static readonly int _PropertyID_AIndex; //Field offset: 0x0
	[Token(Token = "0x4000911")]
	private static readonly int _PropertyID_DividedH; //Field offset: 0x4
	[Token(Token = "0x4000912")]
	private static readonly int _PropertyID_DividedV; //Field offset: 0x8
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400090B")]
	private Transform _transformCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400090C")]
	private float _RapidDelay; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400090D")]
	private float _RapidCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400090E")]
	private PrefabBank<WeaponNormalCollision> _normalBulletBank; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400090F")]
	private GameObject _basePrefab; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000913")]
	private Material _baseShotMaterial; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000914")]
	protected Material _shotMaterial; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000915")]
	private int _animationIndexMax; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Range(1, 4)]
	[SerializeField]
	[Token(Token = "0x4000916")]
	private int _animationDivide; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Range(1, 4)]
	[SerializeField]
	[Token(Token = "0x4000917")]
	private int _animationDivideV; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x4000918")]
	private float _DisplaySecondMax; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000919")]
	private float _DisplaySecond; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400091A")]
	private int _animationIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400091B")]
	protected int MuzzlePerAmmo; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[Token(Token = "0x400091C")]
	private int RapidCountMax; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400091D")]
	protected int _bulletMax; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400091E")]
	protected int _shotDataCount; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x400091F")]
	private float BulletSpeed; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000920")]
	protected ShotDirectionData[] _shotDatas; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000921")]
	private Transform[] _emittersParent; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000922")]
	private Vector3[] _emitPosCache; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000923")]
	protected ID[] _requestSounds; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000924")]
	protected ID _pipiruShotSound; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	[Token(Token = "0x4000925")]
	private bool _isNoRapid; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000926")]
	private Int32[] _weaponLevelBits; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000927")]
	private Int32[] _needAmmo; //Field offset: 0xE8

	[Token(Token = "0x170001BC")]
	protected override int MuzzleCreateCount
	{
		[Address(RVA = "0x1D78120", Offset = "0x1D77520", Length = "0xA")]
		[Token(Token = "0x60009F8")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1D77F60", Offset = "0x1D77360", Length = "0xA5")]
	[Token(Token = "0x60009FA")]
	private static WeaponNormalShot() { }

	[Address(RVA = "0x1D78010", Offset = "0x1D77410", Length = "0x105")]
	[Token(Token = "0x60009F9")]
	public WeaponNormalShot() { }

	[Address(RVA = "0x1D76F00", Offset = "0x1D76300", Length = "0x4F4")]
	[Token(Token = "0x60009E4")]
	public override int Fire(float dt, bool isExBoost) { }

	[Address(RVA = "0x1D76B60", Offset = "0x1D75F60", Length = "0x395")]
	[Token(Token = "0x60009F4")]
	private WeaponNormalCollision FireBySData(ShotDirectionData sdata, float bspeed, bool isExboost) { }

	[Address(RVA = "0x1D78120", Offset = "0x1D77520", Length = "0xA")]
	[Token(Token = "0x60009F8")]
	protected override int get_MuzzleCreateCount() { }

	[Address(RVA = "0x1D77400", Offset = "0x1D76800", Length = "0x2E")]
	[Token(Token = "0x60009F7")]
	protected Transform GetEParent(int eindex) { }

	[Address(RVA = "0x1D77430", Offset = "0x1D76830", Length = "0x3C")]
	[Token(Token = "0x60009EE")]
	protected override int GetInGameBulletCount() { }

	[Address(RVA = "0x1D77470", Offset = "0x1D76870", Length = "0x12")]
	[Token(Token = "0x60009F2")]
	protected float GetRapidCount(bool isExBoost) { }

	[Address(RVA = "0x1D77490", Offset = "0x1D76890", Length = "0x182")]
	[Token(Token = "0x60009F5")]
	protected override Vector3 GetShotDir(ShotDirectionData sdata, Quaternion lrot, bool isExBoost) { }

	[Address(RVA = "0x1D778F0", Offset = "0x1D76CF0", Length = "0xBA")]
	[IteratorStateMachine(typeof(<Initialize>d__0))]
	[Token(Token = "0x60009E2")]
	public override IEnumerator Initialize(Transform poolroot, Transform gameroot, GameObject parent, Transform[] emitTable, int pno) { }

	[Address(RVA = "0x1D77620", Offset = "0x1D76A20", Length = "0x2C2")]
	[Token(Token = "0x60009E3")]
	public override void InitializeShotDatas() { }

	[Address(RVA = "0x1D779B0", Offset = "0x1D76DB0", Length = "0x88")]
	[Token(Token = "0x60009E5")]
	public virtual bool IsFire(bool isExboost) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009ED")]
	public override PrefabBank<WeaponLaserCollision> LBBank() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60009EC")]
	public override PrefabBank<WeaponNormalCollision> NBBank() { }

	[Address(RVA = "0x1D77A40", Offset = "0x1D76E40", Length = "0x26")]
	[Token(Token = "0x60009E6")]
	public override void NoFire(float dt) { }

	[Address(RVA = "0x1D752B0", Offset = "0x1D746B0", Length = "0x3E")]
	[Token(Token = "0x60009E7")]
	public virtual int OptionLevel() { }

	[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
	[Token(Token = "0x60009F3")]
	public override ID PipiruShotSE() { }

	[Address(RVA = "0x1D77A70", Offset = "0x1D76E70", Length = "0x74")]
	[Token(Token = "0x60009F1")]
	protected void PlayFireSound(int tlevel) { }

	[Address(RVA = "0x1D77AF0", Offset = "0x1D76EF0", Length = "0x51")]
	[Token(Token = "0x60009EF")]
	protected override void PoolBullet(int tindex) { }

	[Address(RVA = "0x1D77C10", Offset = "0x1D77010", Length = "0xCB")]
	[Token(Token = "0x60009E9")]
	public override void Reset() { }

	[Address(RVA = "0x1D77B50", Offset = "0x1D76F50", Length = "0xB7")]
	[Token(Token = "0x60009EA")]
	protected void ResetBulletBank() { }

	[Address(RVA = "0x1D77CE0", Offset = "0x1D770E0", Length = "0xB1")]
	[Token(Token = "0x60009EB")]
	public override void SetGameRoot(Transform gmr) { }

	[Address(RVA = "0x1D77DA0", Offset = "0x1D771A0", Length = "0x71")]
	[Token(Token = "0x60009E8")]
	public override void Terminate() { }

	[Address(RVA = "0x1D77E20", Offset = "0x1D77220", Length = "0x1B")]
	[Token(Token = "0x60009F0")]
	protected bool UpdateRapidCount(float dt) { }

	[Address(RVA = "0x1D77E40", Offset = "0x1D77240", Length = "0x11E")]
	[Token(Token = "0x60009F6")]
	private void UpdateShotUVAnime(float dt) { }

}

