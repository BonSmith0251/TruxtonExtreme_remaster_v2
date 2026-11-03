namespace InGame.Kernel;

[Token(Token = "0x2000014")]
public class InGameBulletManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000017")]
	private sealed class <_loadTemplate>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B6")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B7")]
		public InGameBulletManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B8")]
		public string btname; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B9")]
		private string <loadPath>5__2; //Field offset: 0x30

		[Token(Token = "0x17000026")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000027")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000FB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000F6")]
		public <_loadTemplate>d__19(int <>1__state) { }

		[Address(RVA = "0x1CE08A0", Offset = "0x1CDFCA0", Length = "0x2DC")]
		[Token(Token = "0x60000F8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000FB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CE0B80", Offset = "0x1CDFF80", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000FA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000F7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000018")]
	private struct <_poolBullet>d__20 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000BA")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000BB")]
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BC")]
		public Transform _root; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BD")]
		public PrefabBankValue pvalue; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000BE")]
		public InGameBulletManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000BF")]
		private PrefabBank<InGameBulletInterface> <bank>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C0")]
		private Awaiter <>u__1; //Field offset: 0x38

		[Address(RVA = "0x1CE0BC0", Offset = "0x1CDFFC0", Length = "0x8D0")]
		[Token(Token = "0x60000FC")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60000FD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <LoadBulletTemplate>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000AB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000AC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000AD")]
		public InGameBulletManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000AE")]
		public Dictionary<String, Int32> _dic; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000AF")]
		public MonoBehaviour _mono; //Field offset: 0x30

		[Token(Token = "0x17000022")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000ED")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000023")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000EF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000EA")]
		public <LoadBulletTemplate>d__17(int <>1__state) { }

		[Address(RVA = "0x1CDE4A0", Offset = "0x1CDD8A0", Length = "0x25F")]
		[Token(Token = "0x60000EC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000ED")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000EF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDE700", Offset = "0x1CDDB00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000EE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000EB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000016")]
	private sealed class <SetupStageBullet>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B2")]
		public InGameBulletManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B3")]
		public PrefabBankValue[] values; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B4")]
		public Transform _root; //Field offset: 0x30

		[Token(Token = "0x17000024")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000025")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000F0")]
		public <SetupStageBullet>d__1(int <>1__state) { }

		[Address(RVA = "0x1CDF350", Offset = "0x1CDE750", Length = "0x1C0")]
		[Token(Token = "0x60000F2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDF520", Offset = "0x1CDE920", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000F4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000F1")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40000AA")]
	private static readonly string _bulletTemplatePath; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009D")]
	private Vector3 _targetPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009E")]
	private CancellationTokenSource _bulletToken; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009F")]
	private Dictionary<BulletKind, PrefabBank`1<InGameBulletInterface>> _pools; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A0")]
	private HashSet<BulletKind> _poolsKeys; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A1")]
	private Dictionary<String, BulletTemplate> _bulletTemplate; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A2")]
	private Dictionary<BulletKind, InGameBulletAnime> _bulletAnimes; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000A3")]
	private BulletSpeeds _bulletSpeeds; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000A4")]
	private Dictionary<BulletKind, Single> _bulletSpeedsDictionary; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000A5")]
	private BulletSounds _bulletSounds; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000A6")]
	private Dictionary<BulletKind, ID> _bulletSoundsDictionary; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000A7")]
	private int _poolTaskCount; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000A8")]
	private float _bulletSpeedScale; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000A9")]
	private bool _loadError; //Field offset: 0x70

	[Token(Token = "0x17000020")]
	public CancellationTokenSource BulletToken
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000021")]
	public bool IsLoadError
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CCCAB0", Offset = "0x1CCBEB0", Length = "0x84")]
	[IteratorStateMachine(typeof(<_loadTemplate>d__19))]
	[Token(Token = "0x60000E3")]
	private IEnumerator _loadTemplate(string btname) { }

	[Address(RVA = "0x1CCCB40", Offset = "0x1CCBF40", Length = "0xD3")]
	[AsyncStateMachine(typeof(<_poolBullet>d__20))]
	[Token(Token = "0x60000E4")]
	private UniTaskVoid _poolBullet(Transform _root, PrefabBankValue pvalue) { }

	[Address(RVA = "0x1CCCC20", Offset = "0x1CCC020", Length = "0x21")]
	[Token(Token = "0x60000DF")]
	private float _rate(int s, int p) { }

	[Address(RVA = "0x1CCC980", Offset = "0x1CCBD80", Length = "0x62")]
	[Token(Token = "0x60000E8")]
	private static InGameBulletManager() { }

	[Address(RVA = "0x1CCC9F0", Offset = "0x1CCBDF0", Length = "0xB7")]
	[Token(Token = "0x60000E7")]
	public InGameBulletManager() { }

	[Address(RVA = "0x1CCC970", Offset = "0x1CCBD70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000E9")]
	private bool <SetupStageBullet>b__1_0() { }

	[Address(RVA = "0x1CCAA40", Offset = "0x1CC9E40", Length = "0xA8B")]
	[Token(Token = "0x60000E0")]
	public void BulletFire(InGameManager gm, List<InGameBulletInterface> rlist, BulletTemplate bt, Vector3 spos, int nlap, Transform _selfT, Transform _dirT, InGameEnemyMoveBase _selfM, float startArc, float speedRate, float sevol, Action<InGameBulletInterface> generateCallback = null) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000E5")]
	public CancellationTokenSource get_BulletToken() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x60000E6")]
	public bool get_IsLoadError() { }

	[Address(RVA = "0x1CCB4D0", Offset = "0x1CCA8D0", Length = "0x76")]
	[Token(Token = "0x60000DC")]
	public PrefabBank<InGameBulletInterface> GetBank(BulletKind bkind) { }

	[Address(RVA = "0x1CCB550", Offset = "0x1CCA950", Length = "0x6F")]
	[Token(Token = "0x60000DB")]
	private ID GetSE(BulletKind hashCode) { }

	[Address(RVA = "0x1CCB5C0", Offset = "0x1CCA9C0", Length = "0x57")]
	[Token(Token = "0x60000DA")]
	public float GetSpeed(BulletKind hashCode) { }

	[Address(RVA = "0x1CCB620", Offset = "0x1CCAA20", Length = "0xF0")]
	[Token(Token = "0x60000DD")]
	public static float GetTargetBulletArc(Vector3 spos, Vector3 tpos) { }

	[Address(RVA = "0x1CCB710", Offset = "0x1CCAB10", Length = "0x93")]
	[Token(Token = "0x60000DE")]
	public static float GetTargetBulletArc(Vector3 tp) { }

	[Address(RVA = "0x1CCB7B0", Offset = "0x1CCABB0", Length = "0xA3")]
	[Token(Token = "0x60000D7")]
	public BulletTemplate GetTemplate(string tname) { }

	[Address(RVA = "0x1CCB860", Offset = "0x1CCAC60", Length = "0x2B1")]
	[Token(Token = "0x60000D0")]
	public void Initialize() { }

	[Address(RVA = "0x1CCBB20", Offset = "0x1CCAF20", Length = "0x53")]
	[Token(Token = "0x60000E2")]
	public bool IsPool(string btname) { }

	[Address(RVA = "0x1CCBB80", Offset = "0x1CCAF80", Length = "0xA1")]
	[IteratorStateMachine(typeof(<LoadBulletTemplate>d__17))]
	[Token(Token = "0x60000E1")]
	public IEnumerator LoadBulletTemplate(Dictionary<String, Int32> _dic, MonoBehaviour _mono) { }

	[Address(RVA = "0x1CCBC30", Offset = "0x1CCB030", Length = "0x286")]
	[Token(Token = "0x60000D5")]
	public void LocalLateUpdater(float dt) { }

	[Address(RVA = "0x1CCBEC0", Offset = "0x1CCB2C0", Length = "0x154")]
	[Token(Token = "0x60000D4")]
	public void Progress(float dt) { }

	[Address(RVA = "0x1CCC020", Offset = "0x1CCB420", Length = "0x271")]
	[Token(Token = "0x60000D3")]
	public void ResetBullet(bool isAll) { }

	[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
	[Token(Token = "0x60000D9")]
	public void SetBulletSpeedScale(float tscale) { }

	[Address(RVA = "0x1CCC2A0", Offset = "0x1CCB6A0", Length = "0x1D0")]
	[Token(Token = "0x60000D2")]
	public void SetGameRoot(Transform gmr) { }

	[Address(RVA = "0x1CCC480", Offset = "0x1CCB880", Length = "0x121")]
	[Token(Token = "0x60000D8")]
	public void SetTemplate(string btname, BulletTemplate bt) { }

	[Address(RVA = "0x1CCC5B0", Offset = "0x1CCB9B0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<SetupStageBullet>d__1))]
	[Token(Token = "0x60000D1")]
	public IEnumerator SetupStageBullet(Transform _root, PrefabBankValue[] values) { }

	[Address(RVA = "0x1CCC660", Offset = "0x1CCBA60", Length = "0x301")]
	[Token(Token = "0x60000D6")]
	public void Terminate() { }

}

