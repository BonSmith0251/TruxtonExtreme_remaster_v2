namespace InGame.Kernel.Player;

[Token(Token = "0x2000135")]
public class WeaponLaserShot : WeaponBaseShot, IWeapons
{
	[CompilerGenerated]
	[Token(Token = "0x2000136")]
	private sealed class <Initialize>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008D9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008DA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40008DB")]
		public WeaponLaserShot <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40008DC")]
		public Transform gameroot; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40008DD")]
		public Transform[] emittable; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40008DE")]
		public GameObject parent; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40008DF")]
		public Transform poolroot; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40008E0")]
		public int playerNo; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40008E1")]
		private int <lcount>5__2; //Field offset: 0x4C

		[Token(Token = "0x170001B8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009BD")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001B9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60009BF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60009BA")]
		public <Initialize>d__0(int <>1__state) { }

		[Address(RVA = "0x1D73530", Offset = "0x1D72930", Length = "0x39F")]
		[Token(Token = "0x60009BC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009BD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60009BF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D738D0", Offset = "0x1D72CD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60009BE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60009BB")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008CD")]
	private int _laserSoundID; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008CE")]
	private int _shotDataCount; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008CF")]
	private bool _isExshooting; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008D0")]
	private Transform _playerTransform; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40008D1")]
	private GameObject _basePrefab; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40008D2")]
	[Tooltip("1秒間に進む距離")]
	private float _laserSpeed; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40008D3")]
	private PLaserSE[] _requestLptSounds; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40008D4")]
	protected ID _pipiruShotSound; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008D5")]
	private PrefabBank<WeaponLaserCollision> _laserShotBank; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008D6")]
	private Dictionary<Int32, WeaponLaserCollision> _currentShots; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008D7")]
	private List<Int32> _shotKeys; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008D8")]
	private ShotDirectionData[] _shotDatas; //Field offset: 0xA8

	[Address(RVA = "0x1D75710", Offset = "0x1D74B10", Length = "0x13D")]
	[Token(Token = "0x60009B8")]
	private WeaponLaserCollision _getLaser(ShotDirectionData sdata, bool isExBoost) { }

	[Address(RVA = "0x1D755F0", Offset = "0x1D749F0", Length = "0x114")]
	[Token(Token = "0x60009B9")]
	public WeaponLaserShot() { }

	[Address(RVA = "0x1D74B70", Offset = "0x1D73F70", Length = "0x27E")]
	[Token(Token = "0x60009AC")]
	public override int Fire(float dt, bool isExBoost) { }

	[Address(RVA = "0x1D74880", Offset = "0x1D73C80", Length = "0x2EE")]
	[Token(Token = "0x60009B7")]
	private WeaponLaserCollision FireBySData(ShotDirectionData sdata, float dt, bool isCreate) { }

	[Address(RVA = "0x1D74F50", Offset = "0x1D74350", Length = "0xD9")]
	[IteratorStateMachine(typeof(<Initialize>d__0))]
	[Token(Token = "0x60009AA")]
	public override IEnumerator Initialize(Transform poolroot, Transform gameroot, GameObject parent, Transform[] emittable, int playerNo) { }

	[Address(RVA = "0x1D74DF0", Offset = "0x1D741F0", Length = "0x156")]
	[Token(Token = "0x60009AB")]
	public override void InitializeShotDatas() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x60009B4")]
	public override PrefabBank<WeaponLaserCollision> LBBank() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009B3")]
	public override PrefabBank<WeaponNormalCollision> NBBank() { }

	[Address(RVA = "0x1D75030", Offset = "0x1D74430", Length = "0x158")]
	[Token(Token = "0x60009AE")]
	public override void NoFire(float dt) { }

	[Address(RVA = "0x1D75190", Offset = "0x1D74590", Length = "0x11A")]
	[Token(Token = "0x60009AD")]
	public virtual void OnUpdate(float dt) { }

	[Address(RVA = "0x1D752B0", Offset = "0x1D746B0", Length = "0x3E")]
	[Token(Token = "0x60009B2")]
	public virtual int OptionLevel() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x60009B1")]
	public override ID PipiruShotSE() { }

	[Address(RVA = "0x1D752F0", Offset = "0x1D746F0", Length = "0xDC")]
	[Token(Token = "0x60009AF")]
	public override void Reset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009B0")]
	public override void SetGameRoot(Transform gmr) { }

	[Address(RVA = "0x1D753D0", Offset = "0x1D747D0", Length = "0x155")]
	[Token(Token = "0x60009B6")]
	private void StopCurrentShot(int tid) { }

	[Address(RVA = "0x1D75530", Offset = "0x1D74930", Length = "0xB5")]
	[Token(Token = "0x60009B5")]
	public override void Terminate() { }

}

