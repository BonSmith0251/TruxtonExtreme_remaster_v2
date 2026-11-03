namespace KANAI.Kernel;

[Token(Token = "0x2000023")]
public class PrefabBank
{
	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <>c
	{
		[Token(Token = "0x40000A4")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x40000A5")]
		public static Func<PoolObject<T>, Boolean> <>9__4_0; //Field offset: 0x0
		[Token(Token = "0x40000A6")]
		public static Func<PoolObject<T>, T> <>9__4_1; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600014B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600014C")]
		public <>c() { }

		[Address(RVA = "0xA34D00", Offset = "0xA34100", Length = "0x5")]
		[Token(Token = "0x600014D")]
		internal bool <GetActives>b__4_0(PoolObject<T> p) { }

		[Address(RVA = "0xA34D10", Offset = "0xA34110", Length = "0x5")]
		[Token(Token = "0x600014E")]
		internal T <GetActives>b__4_1(PoolObject<T> a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <InitializeCoroutine>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A7")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A8")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A9")]
		public PrefabBank<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AA")]
		public PrefabBankValue v; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AB")]
		public Transform _root; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AC")]
		private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x0

		[Token(Token = "0x17000022")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000152")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000023")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000154")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600014F")]
		public <InitializeCoroutine>d__2(int <>1__state) { }

		[Address(RVA = "0x18093A0", Offset = "0x18087A0", Length = "0x241")]
		[Token(Token = "0x6000151")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000152")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000154")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000153")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000150")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private struct <InitializeUniTask>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AD")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AF")]
		public PrefabBank<T> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B0")]
		public PrefabBankValue v; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B1")]
		public Transform _root; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B2")]
		private AsyncInstantiateOperation<GameObject> <op>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B3")]
		private Awaiter<GameObject> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x1809AB0", Offset = "0x1808EB0", Length = "0x4C7")]
		[Token(Token = "0x6000155")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000156")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000024")]
	internal struct PoolObject
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009F")]
		public IPrefabBankObject _object; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A0")]
		public Transform _transform; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		public T _component; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A2")]
		public bool _isActive; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A3")]
		public bool _isPool; //Field offset: 0x0

		[Address(RVA = "0xE27980", Offset = "0xE26D80", Length = "0x104")]
		[Token(Token = "0x6000146")]
		public PoolObject(GameObject obj) { }

		[Address(RVA = "0xE27250", Offset = "0xE26650", Length = "0xCA")]
		[Token(Token = "0x6000147")]
		public T Get(Transform _parent) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000148")]
		public T GetBaseComponent() { }

		[Address(RVA = "0xE273C0", Offset = "0xE267C0", Length = "0x11")]
		[Token(Token = "0x6000144")]
		public bool IsActive() { }

		[Address(RVA = "0xE273E0", Offset = "0xE267E0", Length = "0x11")]
		[Token(Token = "0x6000143")]
		public bool IsEmpty() { }

		[Address(RVA = "0xE27580", Offset = "0xE26980", Length = "0x62")]
		[Token(Token = "0x600014A")]
		public bool IsSame(int tid) { }

		[Address(RVA = "0xE277B0", Offset = "0xE26BB0", Length = "0x84")]
		[Token(Token = "0x6000149")]
		public void Pool(Transform _root) { }

		[Address(RVA = "0xE27960", Offset = "0xE26D60", Length = "0x12")]
		[Token(Token = "0x6000145")]
		public bool SetPool() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000097")]
	private Transform _poolRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000098")]
	private PoolObject<T>[] _pools; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000099")]
	private string _baseName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009A")]
	private int _Max; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009B")]
	private int _PoolWaitCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009C")]
	private int _ActiveObjectCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009D")]
	private int _AwakeIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009E")]
	private HashSet<Int32> _poolQues; //Field offset: 0x0

	[Token(Token = "0x17000020")]
	public int ActiveObjectCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public float ActiveRate
	{
		[Address(RVA = "0xE30F60", Offset = "0xE30360", Length = "0x15")]
		[Token(Token = "0x6000141")]
		 get { } //Length: 21
	}

	[Token(Token = "0x1700001F")]
	public int CreateMax
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600013F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public PoolObject<T>[] Pools
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600013E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE30880", Offset = "0xE2FC80", Length = "0x94")]
	[Token(Token = "0x600012E")]
	private void _createPools(PrefabBankValue v) { }

	[Address(RVA = "0xE30B80", Offset = "0xE2FF80", Length = "0xFD")]
	[Token(Token = "0x600013D")]
	private int _getIndex(GameObject o) { }

	[Address(RVA = "0xE30920", Offset = "0xE2FD20", Length = "0x95")]
	[Token(Token = "0x6000142")]
	public PrefabBank`1() { }

	[Address(RVA = "0xE2E840", Offset = "0xE2DC40", Length = "0x1F6")]
	[Token(Token = "0x600013A")]
	public void ExecQues() { }

	[Address(RVA = "0xE2F790", Offset = "0xE2EB90", Length = "0x21E")]
	[Token(Token = "0x6000136")]
	public T Get(Transform _rt = null, int vindex = -1) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000140")]
	public int get_ActiveObjectCount() { }

	[Address(RVA = "0xE30F60", Offset = "0xE30360", Length = "0x15")]
	[Token(Token = "0x6000141")]
	public float get_ActiveRate() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600013F")]
	public int get_CreateMax() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600013E")]
	public PoolObject<T>[] get_Pools() { }

	[Address(RVA = "0xE2EDB0", Offset = "0xE2E1B0", Length = "0x357")]
	[Token(Token = "0x600012F")]
	public T[] GetActives() { }

	[Address(RVA = "0xE2F1F0", Offset = "0xE2E5F0", Length = "0x2F")]
	[Token(Token = "0x6000132")]
	public T GetByIndex(int index) { }

	[Address(RVA = "0xE30D60", Offset = "0xE30160", Length = "0xBE")]
	[Token(Token = "0x6000134")]
	private int getEmpty() { }

	[Address(RVA = "0xE2F220", Offset = "0xE2E620", Length = "0x142")]
	[Token(Token = "0x6000133")]
	public int GetEmptyIndex(bool isRetry = true) { }

	[Address(RVA = "0xE30E20", Offset = "0xE30220", Length = "0x6F")]
	[Token(Token = "0x6000135")]
	private int getNoActive() { }

	[Address(RVA = "0xE2F400", Offset = "0xE2E800", Length = "0xE7")]
	[Token(Token = "0x6000137")]
	public T GetPool(Transform _rt, int index) { }

	[Address(RVA = "0xE2F9B0", Offset = "0xE2EDB0", Length = "0xC5")]
	[IteratorStateMachine(typeof(<InitializeCoroutine>d__2))]
	[Token(Token = "0x600012D")]
	public IEnumerator InitializeCoroutine(Transform _root, PrefabBankValue v) { }

	[Address(RVA = "0xE2FB50", Offset = "0xE2EF50", Length = "0x105")]
	[AsyncStateMachine(typeof(<InitializeUniTask>d__1))]
	[Token(Token = "0x600012C")]
	public UniTask InitializeUniTask(Transform _root, PrefabBankValue v) { }

	[Address(RVA = "0xE2FE40", Offset = "0xE2F240", Length = "0x12C")]
	[Token(Token = "0x6000138")]
	public void Pool(GameObject o) { }

	[Address(RVA = "0xE2FF70", Offset = "0xE2F370", Length = "0xB9")]
	[Token(Token = "0x6000139")]
	public void Pool(int nindex) { }

	[Address(RVA = "0xE300F0", Offset = "0xE2F4F0", Length = "0x5C")]
	[Token(Token = "0x600013B")]
	public void QuePool(int poolIndex) { }

	[Address(RVA = "0xE30150", Offset = "0xE2F550", Length = "0xA3")]
	[Token(Token = "0x6000130")]
	public void Reset() { }

	[Address(RVA = "0xE302B0", Offset = "0xE2F6B0", Length = "0x1BD")]
	[Token(Token = "0x6000131")]
	public void Terminate() { }

	[Address(RVA = "0xE30780", Offset = "0xE2FB80", Length = "0xF2")]
	[Token(Token = "0x600013C")]
	public void UpdateState(bool isForce) { }

}

