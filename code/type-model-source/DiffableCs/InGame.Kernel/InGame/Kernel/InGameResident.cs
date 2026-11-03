namespace InGame.Kernel;

[Token(Token = "0x2000085")]
public class InGameResident : MonoBehaviourSingleton<InGameResident>
{
	[CompilerGenerated]
	[Token(Token = "0x2000086")]
	private sealed class <Setup>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400045F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000460")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000461")]
		public InGameResident <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000462")]
		public int bgmlist; //Field offset: 0x28

		[Token(Token = "0x170000F7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000538")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000F8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600053A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000535")]
		public <Setup>d__1(int <>1__state) { }

		[Address(RVA = "0x1D2B0B0", Offset = "0x1D2A4B0", Length = "0x819")]
		[Token(Token = "0x6000537")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000538")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600053A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1D2B8D0", Offset = "0x1D2ACD0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000539")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000536")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000434")]
	private static readonly string _bulletSelecterLabel; //Field offset: 0x0
	[Token(Token = "0x4000435")]
	private static readonly Dictionary<attackType, Int32> _attackTypeArray; //Field offset: 0x8
	[Token(Token = "0x4000436")]
	private static readonly Dictionary<String, Int32> _residentItems; //Field offset: 0x10
	[Token(Token = "0x4000437")]
	private static readonly Vector2[] psuv; //Field offset: 0x18
	[Token(Token = "0x4000438")]
	private static readonly Int32[] pstriangles; //Field offset: 0x20
	[Token(Token = "0x4000439")]
	private static readonly float p10w; //Field offset: 0x28
	[Token(Token = "0x400043A")]
	private static readonly float p10h; //Field offset: 0x2C
	[Token(Token = "0x400043B")]
	private static readonly Vector3[] p10vertices; //Field offset: 0x30
	[Token(Token = "0x400043C")]
	private static readonly float p20w; //Field offset: 0x38
	[Token(Token = "0x400043D")]
	private static readonly float p20h; //Field offset: 0x3C
	[Token(Token = "0x400043E")]
	private static readonly Vector3[] p20vertices; //Field offset: 0x40
	[Token(Token = "0x400043F")]
	private static readonly float p30size; //Field offset: 0x48
	[Token(Token = "0x4000440")]
	private static readonly Vector3[] p30vertices; //Field offset: 0x50
	[Token(Token = "0x4000441")]
	private static readonly float p50w; //Field offset: 0x58
	[Token(Token = "0x4000442")]
	private static readonly float p50h; //Field offset: 0x5C
	[Token(Token = "0x4000443")]
	private static readonly Vector3[] p50vertices; //Field offset: 0x60
	[Token(Token = "0x4000458")]
	private static readonly int bmatCount; //Field offset: 0x68
	[Token(Token = "0x4000459")]
	private static readonly int _alphaID; //Field offset: 0x6C
	[Token(Token = "0x400045A")]
	private static readonly string _bgmPlaylistPath; //Field offset: 0x70
	[Token(Token = "0x400045B")]
	private static readonly String[] _bgmLists; //Field offset: 0x78
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000444")]
	private Color[] _FlushColors; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000445")]
	private PlayMode _playMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000446")]
	private PlayActor _playActor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000447")]
	private String[] _routeData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000448")]
	private EffectPalette _effectPalette; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000449")]
	private AnimationPalette _animationPalette; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400044A")]
	private BulletSpeeds _bulletPalette; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400044B")]
	private BulletSounds _bulletSEPalette; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400044C")]
	private BulletPalette _regidentBullet; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400044D")]
	private Color[] _hitFlashColors; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400044E")]
	private AssetReference[] _playerShotAssets; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400044F")]
	private AssetReference _ingameScaler; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000450")]
	private PlayerJetColors _playerJetColors; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000451")]
	private Material _billboardMaterial; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000452")]
	private Material[] _bmaterials; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000453")]
	private Dictionary<ArmsKind, Mesh> _pshotMesh; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000454")]
	private GameScalability _ingameScalerTable; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000455")]
	private ItemReferenceTable _dropItemTable; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000456")]
	private PlayerDefinedShots[] _playerShotDatas; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000457")]
	private Dictionary<String, BulletTemplateSelecter> _bltSelecters; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400045C")]
	private string _bgmPath; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400045D")]
	private StagePlayList _bgmPlaylist; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400045E")]
	private bool _isTraining; //Field offset: 0xC8

	[Token(Token = "0x170000F5")]
	public StagePlayList BGMPlayList
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x6000531")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000EF")]
	public BulletSpeeds BulletPalette
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600052B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F0")]
	public BulletSounds BulletSEPalette
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600052C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F4")]
	public ItemReferenceTable DropItemTable
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000530")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F2")]
	public Color[] HitFlashColors
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600052E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F3")]
	public GameScalability InGameScaler
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600052F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F6")]
	public bool IsTraining
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[Token(Token = "0x6000532")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000F1")]
	public BulletPalette RegidentBullet
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600052D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D22540", Offset = "0x1D21940", Length = "0xC73")]
	[Token(Token = "0x6000534")]
	private static InGameResident() { }

	[Address(RVA = "0x1D231C0", Offset = "0x1D225C0", Length = "0xB9")]
	[Token(Token = "0x6000533")]
	public InGameResident() { }

	[Address(RVA = "0x1D21870", Offset = "0x1D20C70", Length = "0x9B")]
	[Token(Token = "0x600051C")]
	public float BulletASecondPass(string bulletName) { }

	[Address(RVA = "0x1D23280", Offset = "0x1D22680", Length = "0x200")]
	[Token(Token = "0x6000528")]
	private void createBulletMesh() { }

	[Address(RVA = "0x1D23780", Offset = "0x1D22B80", Length = "0x221")]
	[Token(Token = "0x6000527")]
	private void createMaterials() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x6000531")]
	public StagePlayList get_BGMPlayList() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600052B")]
	public BulletSpeeds get_BulletPalette() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600052C")]
	public BulletSounds get_BulletSEPalette() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000530")]
	public ItemReferenceTable get_DropItemTable() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600052E")]
	public Color[] get_HitFlashColors() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600052F")]
	public GameScalability get_InGameScaler() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[Token(Token = "0x6000532")]
	public bool get_IsTraining() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600052D")]
	public BulletPalette get_RegidentBullet() { }

	[Address(RVA = "0x1D21910", Offset = "0x1D20D10", Length = "0xAE")]
	[Token(Token = "0x6000525")]
	public Material GetBillboardMaterial(float trate) { }

	[Address(RVA = "0x1D219C0", Offset = "0x1D20DC0", Length = "0x93")]
	[Token(Token = "0x6000522")]
	public BulletTemplateSelecter GetBltSelecter(string sname) { }

	[Address(RVA = "0x1D21A60", Offset = "0x1D20E60", Length = "0xB3")]
	[Token(Token = "0x6000523")]
	public string GetBulletTemplate(string btname, float brate) { }

	[Address(RVA = "0x1D21B20", Offset = "0x1D20F20", Length = "0xA5")]
	[Token(Token = "0x6000524")]
	public String[] GetBulletTemplates(string btname) { }

	[Address(RVA = "0x1D21BD0", Offset = "0x1D20FD0", Length = "0x95")]
	[Token(Token = "0x600051B")]
	public AnimationClip GetClip(string clipname) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600051A")]
	public EffectPalette GetEffectPalette() { }

	[Address(RVA = "0x1D21C70", Offset = "0x1D21070", Length = "0x150")]
	[Token(Token = "0x6000529")]
	public Color GetHitFlashColor(attackType atkType, float trate) { }

	[Address(RVA = "0x1D21DD0", Offset = "0x1D211D0", Length = "0x98")]
	[Token(Token = "0x600052A")]
	public static PlayerJetColors GetJetColors() { }

	[Address(RVA = "0x1D21E70", Offset = "0x1D21270", Length = "0x54")]
	[Token(Token = "0x6000526")]
	public Mesh GetMesh(ArmsKind tarm) { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000520")]
	public PlayActor GetPlayActor() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600051F")]
	public PlayMode GetPlayMode() { }

	[Address(RVA = "0x1D21ED0", Offset = "0x1D212D0", Length = "0x1D")]
	[Token(Token = "0x6000521")]
	public Dictionary<String, Int32> GetRegidentBulletNames() { }

	[Address(RVA = "0x1D21EF0", Offset = "0x1D212F0", Length = "0x97")]
	[Token(Token = "0x6000519")]
	public Dictionary<String, Int32> GetResidentEnemys() { }

	[Address(RVA = "0x1D21F90", Offset = "0x1D21390", Length = "0xD2")]
	[Token(Token = "0x6000518")]
	public Dictionary<String, Int32> GetResidentRoutes() { }

	[Address(RVA = "0x1D22070", Offset = "0x1D21470", Length = "0x6B")]
	[Token(Token = "0x6000517")]
	private void ReleasePlayList() { }

	[Address(RVA = "0x1D220E0", Offset = "0x1D214E0", Length = "0x1F5")]
	[Token(Token = "0x600051E")]
	public void SetPlayMode(PlayMode pmode, PlayActor pactor, bool isTraining = false) { }

	[Address(RVA = "0x1D222E0", Offset = "0x1D216E0", Length = "0x76")]
	[IteratorStateMachine(typeof(<Setup>d__1))]
	[Token(Token = "0x6000515")]
	public IEnumerator Setup(int bgmlist) { }

	[Address(RVA = "0x1D22360", Offset = "0x1D21760", Length = "0x5A")]
	[Token(Token = "0x600051D")]
	public PlayerDefinedShots ShotDatas(ArmsKind tarm) { }

	[Address(RVA = "0x1D223C0", Offset = "0x1D217C0", Length = "0x175")]
	[Token(Token = "0x6000516")]
	public void Teardown() { }

}

