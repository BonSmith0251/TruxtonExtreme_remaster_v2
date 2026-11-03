namespace InGame.Kernel;

[Token(Token = "0x2000020")]
public class InGameEffectManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private struct <_entryEffect>d__15 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000108")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000109")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010A")]
		public PrefabBankValue _effect; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400010B")]
		public InGameEffectManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400010C")]
		public Transform _root; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400010D")]
		private int <hashCode>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400010E")]
		private PrefabBank<InGameEffect> <pbank>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400010F")]
		private Awaiter <>u__1; //Field offset: 0x48

		[Address(RVA = "0x1CE0010", Offset = "0x1CDF410", Length = "0x449")]
		[Token(Token = "0x6000176")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x6000177")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <DammyPlay>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FD")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000FE")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FF")]
		public InGameEffectManager <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000100")]
		public Transform troot; //Field offset: 0x28

		[Token(Token = "0x17000035")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000167")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000036")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000169")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000164")]
		public <DammyPlay>d__3(int <>1__state) { }

		[Address(RVA = "0x1CDD8E0", Offset = "0x1CDCCE0", Length = "0x4B7")]
		[Token(Token = "0x6000166")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000167")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000169")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDDDA0", Offset = "0x1CDD1A0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000168")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000165")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <Debug_LoadPrefabBank>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000101")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000102")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000037")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600016D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000038")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600016F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600016A")]
		public <Debug_LoadPrefabBank>d__11(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x600016C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600016D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600016F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDDDE0", Offset = "0x1CDD1E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600016E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600016B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <SetupEffect>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000103")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000104")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000105")]
		public PrefabBankValue[] _effects; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000106")]
		public InGameEffectManager <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000107")]
		public Transform _root; //Field offset: 0x30

		[Token(Token = "0x17000039")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000173")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700003A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000175")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000170")]
		public <SetupEffect>d__2(int <>1__state) { }

		[Address(RVA = "0x1CDEFF0", Offset = "0x1CDE3F0", Length = "0x310")]
		[Token(Token = "0x6000172")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000173")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000175")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1CDF310", Offset = "0x1CDE710", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000174")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000171")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000023")]
	private struct EffectQue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000F4")]
		private Transform root; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000F5")]
		private QueKind kind; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000F6")]
		private int hashCode; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F7")]
		private int intVal; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000F8")]
		private int posHash; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F9")]
		private Vector3 epos; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000FA")]
		private Vector3 edir; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000FB")]
		private Quaternion erot; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000FC")]
		private bool bWithSE; //Field offset: 0x40

		[Token(Token = "0x17000032")]
		public Vector3 Dir
		{
			[Address(RVA = "0x1CC6CD0", Offset = "0x1CC60D0", Length = "0x13")]
			[Token(Token = "0x6000161")]
			 get { } //Length: 19
		}

		[Token(Token = "0x1700002E")]
		public int HashCode
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x600015D")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700002F")]
		public int IntVal
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600015E")]
			 get { } //Length: 85
		}

		[Token(Token = "0x1700002D")]
		public QueKind Kind
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[Token(Token = "0x600015C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000031")]
		public Vector3 Pos
		{
			[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
			[Token(Token = "0x6000160")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000030")]
		public int PosHash
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x600015F")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700002C")]
		public Transform Root
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x600015B")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000033")]
		public Quaternion Rot
		{
			[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
			[Token(Token = "0x6000162")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000034")]
		public bool WithSE
		{
			[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
			[Token(Token = "0x6000163")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1CC6CD0", Offset = "0x1CC60D0", Length = "0x13")]
		[Token(Token = "0x6000161")]
		public Vector3 get_Dir() { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x600015D")]
		public int get_HashCode() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600015E")]
		public int get_IntVal() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x600015C")]
		public QueKind get_Kind() { }

		[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
		[Token(Token = "0x6000160")]
		public Vector3 get_Pos() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600015F")]
		public int get_PosHash() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600015B")]
		public Transform get_Root() { }

		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x6000162")]
		public Quaternion get_Rot() { }

		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000163")]
		public bool get_WithSE() { }

		[Address(RVA = "0x1CC6A60", Offset = "0x1CC5E60", Length = "0xBE")]
		[Token(Token = "0x6000158")]
		public void SetEffect(Transform troot, int hcode, int ival, Vector3 tpos, Quaternion trot, bool withSE) { }

		[Address(RVA = "0x1CC6B20", Offset = "0x1CC5F20", Length = "0xDA")]
		[Token(Token = "0x600015A")]
		public void SetExp(Transform troot, int hcode, int tlayer, QueKind qkind, Vector3 tpos, Vector3 tdir, bool withSE) { }

		[Address(RVA = "0x1CC6C00", Offset = "0x1CC6000", Length = "0xCA")]
		[Token(Token = "0x6000159")]
		public void SetMustEffect(Transform troot, int hcode, int ival, Vector3 tpos, bool withSE) { }

	}

	[Token(Token = "0x2000022")]
	private enum QueKind : int
	{
		Effect = 0,
		ExplosionL = 1,
		ExplosionW = 2,
	}

	[BurstCompile]
	[Token(Token = "0x2000021")]
	private struct SimpleAssignJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40000EC")]
		public NativeArray<Vector3> sourcePositions; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x40000ED")]
		public NativeArray<Quaternion> sourceRotations; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x40000EE")]
		public NativeArray<Boolean> isWorld; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		[Token(Token = "0x40000EF")]
		public NativeArray<Boolean> isDo; //Field offset: 0x30

		[Address(RVA = "0x1CDD850", Offset = "0x1CDCC50", Length = "0x82")]
		[Token(Token = "0x6000157")]
		public override void Execute(int index, TransformAccess tt) { }

	}

	[Token(Token = "0x40000DF")]
	private const int EffectQueMax = 600; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D8")]
	private Dictionary<Int32, PrefabBank`1<InGameEffect>> _pools; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D9")]
	private HashSet<Int64> _samePlaceCheck; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DA")]
	private Dictionary<Int32, List`1<Sheet>> _effectSounds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000DB")]
	private HashSet<InGameEffect> _actives; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DC")]
	private HashSet<InGameEffect> _burstQue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DD")]
	private HashSet<InGameEffect> _finishes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DE")]
	private bool _isLoadError; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000E0")]
	private TransformAccessArray _transformAccessArray; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000E1")]
	private NativeArray<Vector3> _positionAccess; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000E2")]
	private NativeArray<Quaternion> _rotateAccess; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000E3")]
	private NativeArray<Boolean> _isWorldAccess; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000E4")]
	private NativeArray<Boolean> _isDoAccess; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000E5")]
	private NativeArray<Boolean> _isFalseFill; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000E6")]
	private JobHandle _jhandle; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000E7")]
	private bool _doJob; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000E8")]
	private EffectQue[] _requests; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000E9")]
	private int _queCount; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40000EA")]
	private int _effectMax; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000EB")]
	private int _bentry; //Field offset: 0xC8

	[Token(Token = "0x1700002B")]
	public bool IsLoadError
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600014A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CD2390", Offset = "0x1CD1790", Length = "0x113")]
	[AsyncStateMachine(typeof(<_entryEffect>d__15))]
	[Token(Token = "0x6000148")]
	private UniTask _entryEffect(Transform _root, PrefabBankValue _effect) { }

	[Address(RVA = "0x1CD21F0", Offset = "0x1CD15F0", Length = "0x192")]
	[Token(Token = "0x6000156")]
	public InGameEffectManager() { }

	[Address(RVA = "0x1CCFC50", Offset = "0x1CCF050", Length = "0x6A")]
	[Token(Token = "0x6000151")]
	private void BurstEntry(int bindex, Vector3 wpos, Quaternion wrot, bool isWorld) { }

	[Address(RVA = "0x1CCFBF0", Offset = "0x1CCEFF0", Length = "0x51")]
	[Token(Token = "0x6000152")]
	private void BurstEntryPos(InGameEffect ae) { }

	[Address(RVA = "0x1CCFCC0", Offset = "0x1CCF0C0", Length = "0x1DD")]
	[Token(Token = "0x6000154")]
	public void CompleteJobs() { }

	[Address(RVA = "0x1CCFEA0", Offset = "0x1CCF2A0", Length = "0x84")]
	[IteratorStateMachine(typeof(<DammyPlay>d__3))]
	[Token(Token = "0x600013C")]
	public IEnumerator DammyPlay(Transform troot) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000145")]
	public string Debug_GetCreateCount(int tcode) { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000146")]
	public string Debug_GetCreateCount() { }

	[Address(RVA = "0x1CCFF30", Offset = "0x1CCF330", Length = "0x4B")]
	[IteratorStateMachine(typeof(<Debug_LoadPrefabBank>d__11))]
	[Token(Token = "0x6000144")]
	public IEnumerator Debug_LoadPrefabBank(Dictionary<String, Int32> _dic, Transform _root) { }

	[Address(RVA = "0x1CCFF80", Offset = "0x1CCF380", Length = "0xBF")]
	[Token(Token = "0x6000153")]
	private void DoJobs() { }

	[Address(RVA = "0x1CD0040", Offset = "0x1CCF440", Length = "0x163")]
	[Token(Token = "0x600014E")]
	public void ExplosionQue(Transform root, int hcode, int nlayer, Vector3 pos, Vector3 tdir, bool isWorld, bool withSE = true) { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600014A")]
	public bool get_IsLoadError() { }

	[Address(RVA = "0x1CD0340", Offset = "0x1CCF740", Length = "0x12E")]
	[Token(Token = "0x6000141")]
	public InGameEffect GetEffect(int tcode, Transform _root, bool withSound) { }

	[Address(RVA = "0x1CD01B0", Offset = "0x1CCF5B0", Length = "0x182")]
	[Token(Token = "0x6000143")]
	private ID GetEffectSound(int hcode) { }

	[Address(RVA = "0x1CD0470", Offset = "0x1CCF870", Length = "0x2DF")]
	[Token(Token = "0x6000139")]
	public void Initialize(EffectPalette pl) { }

	[Address(RVA = "0x1CD0750", Offset = "0x1CCFB50", Length = "0x4F")]
	[Token(Token = "0x600013A")]
	public bool IsEmpty() { }

	[Address(RVA = "0x1CD24B0", Offset = "0x1CD18B0", Length = "0x7E")]
	[Token(Token = "0x6000149")]
	private bool isSamePlace(int hcode, int posh) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000147")]
	public bool IsTight(int tcode) { }

	[Address(RVA = "0x1CD07A0", Offset = "0x1CCFBA0", Length = "0x4E7")]
	[Token(Token = "0x600014F")]
	public void PlayJobQue() { }

	[Address(RVA = "0x1CD0C90", Offset = "0x1CD0090", Length = "0xBA")]
	[Token(Token = "0x6000142")]
	public void PoolEffect(InGameEffect teffect) { }

	[Address(RVA = "0x1CD0D50", Offset = "0x1CD0150", Length = "0x39E")]
	[Token(Token = "0x600013F")]
	public void ProgressEffect(float dt, float ts) { }

	[Address(RVA = "0x1CD10F0", Offset = "0x1CD04F0", Length = "0x44")]
	[Token(Token = "0x600013E")]
	public void ProgressSameCheck() { }

	[Address(RVA = "0x1CD1140", Offset = "0x1CD0540", Length = "0x91")]
	[Token(Token = "0x600014D")]
	public void RequestMustQue(Transform root, int hcode, int intval, Vector3 pos, bool withSE) { }

	[Address(RVA = "0x1CD11E0", Offset = "0x1CD05E0", Length = "0x13C")]
	[Token(Token = "0x600014C")]
	public void RequestQue(Transform root, int hcode, int intval, Vector3 pos, Quaternion rot, bool withSE) { }

	[Address(RVA = "0x1CD1320", Offset = "0x1CD0720", Length = "0x325")]
	[Token(Token = "0x600013D")]
	public void ResetEffect() { }

	[Address(RVA = "0x1CD1650", Offset = "0x1CD0A50", Length = "0x546")]
	[Token(Token = "0x600014B")]
	private void SetupBurst() { }

	[Address(RVA = "0x1CD1C50", Offset = "0x1CD1050", Length = "0xD1")]
	[Token(Token = "0x6000150")]
	private InGameEffect SetupEffect(EffectQue tq, InGameEffect e, int eIndex) { }

	[Address(RVA = "0x1CD1BA0", Offset = "0x1CD0FA0", Length = "0xA1")]
	[IteratorStateMachine(typeof(<SetupEffect>d__2))]
	[Token(Token = "0x600013B")]
	public IEnumerator SetupEffect(Transform _root, PrefabBankValue[] _effects) { }

	[Address(RVA = "0x1CD1E90", Offset = "0x1CD1290", Length = "0x355")]
	[Token(Token = "0x6000140")]
	public void Terminate() { }

	[Address(RVA = "0x1CD1D30", Offset = "0x1CD1130", Length = "0x152")]
	[Token(Token = "0x6000155")]
	public void TerminateJobs() { }

}

