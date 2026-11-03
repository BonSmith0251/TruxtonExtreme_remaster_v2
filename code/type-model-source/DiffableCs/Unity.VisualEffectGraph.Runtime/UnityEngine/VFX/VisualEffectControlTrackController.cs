namespace UnityEngine.VFX;

[Token(Token = "0x2000031")]
internal class VisualEffectControlTrackController
{
	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class <>c
	{
		[Token(Token = "0x40000BB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000BC")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"evt", "sourceIndex"})]
		public static Comparison<ValueTuple`2<Event, Int32>> <>9__24_1; //Field offset: 0x8
		[Token(Token = "0x40000BD")]
		public static Comparison<Event> <>9__24_0; //Field offset: 0x10

		[Address(RVA = "0x2F727A0", Offset = "0x2F71BA0", Length = "0x67")]
		[Token(Token = "0x600009A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600009B")]
		public <>c() { }

		[Address(RVA = "0x2F72190", Offset = "0x2F71590", Length = "0x1D")]
		[Token(Token = "0x600009D")]
		internal int <Init>b__24_0(Event x, Event y) { }

		[Address(RVA = "0x2F72190", Offset = "0x2F71590", Length = "0x1D")]
		[Token(Token = "0x600009C")]
		internal int <Init>b__24_1(ValueTuple<Event, Int32> x, ValueTuple<Event, Int32> y) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private sealed class <ComputeRuntimeEvent>d__21 : IEnumerable<Event>, IEnumerable, IEnumerator<Event>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BF")]
		private Event <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000C0")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000C1")]
		private VisualEffectControlPlayableBehaviour behavior; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000C2")]
		public VisualEffectControlPlayableBehaviour <>3__behavior; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40000C3")]
		private VisualEffect vfx; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40000C4")]
		public VisualEffect <>3__vfx; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40000C5")]
		private IEnumerator<VisualEffectPlayableSerializedEvent> <>7__wrap1; //Field offset: 0x60

		[Token(Token = "0x17000016")]
		private override Event System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x60000A2")]
			private get { } //Length: 19
		}

		[Token(Token = "0x17000017")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F71B90", Offset = "0x2F70F90", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x60000A4")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600009E")]
		public <ComputeRuntimeEvent>d__21(int <>1__state) { }

		[Address(RVA = "0x2F71C70", Offset = "0x2F71070", Length = "0x50")]
		[Token(Token = "0x60000A1")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2F715F0", Offset = "0x2F709F0", Length = "0x4A8")]
		[Token(Token = "0x60000A0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F71AA0", Offset = "0x2F70EA0", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60000A5")]
		private override IEnumerator<Event> System.Collections.Generic.IEnumerable<UnityEngine.VFX.VisualEffectControlTrackController.Event>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x60000A2")]
		private override Event System.Collections.Generic.IEnumerator<UnityEngine.VFX.VisualEffectControlTrackController.Event>.get_Current() { }

		[Address(RVA = "0x2F71AA0", Offset = "0x2F70EA0", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60000A6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F71B90", Offset = "0x2F70F90", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F71B50", Offset = "0x2F70F50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2F71BE0", Offset = "0x2F70FE0", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x600009F")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000035")]
	private struct Chunk
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AF")]
		public bool scrubbing; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40000B0")]
		public bool reinitEnter; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40000B1")]
		public bool reinitExit; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000B2")]
		public uint startSeed; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000B3")]
		public double begin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		public double end; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B5")]
		public uint prewarmCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000B6")]
		public float prewarmDeltaTime; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000B7")]
		public double prewarmOffset; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000B8")]
		public int prewarmEvent; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000B9")]
		public Event[] events; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000BA")]
		public Clip[] clips; //Field offset: 0x38

	}

	[Token(Token = "0x2000034")]
	private struct Clip
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AD")]
		public int enter; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000AE")]
		public int exit; //Field offset: 0x4

	}

	[Token(Token = "0x2000032")]
	private struct Event
	{
		[Token(Token = "0x2000033")]
		internal enum ClipType : int
		{
			None = 0,
			Enter = 1,
			Exit = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A4")]
		public int nameId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000A5")]
		public VFXEventAttribute attribute; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A6")]
		public double time; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A7")]
		public int clipIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40000A8")]
		public ClipType clipType; //Field offset: 0x1C

	}

	[Token(Token = "0x2000036")]
	private class VisualEffectControlPlayableBehaviourComparer : IComparer<VisualEffectControlPlayableBehaviour>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000099")]
		public VisualEffectControlPlayableBehaviourComparer() { }

		[Address(RVA = "0x2F7A060", Offset = "0x2F79460", Length = "0x38")]
		[Token(Token = "0x6000098")]
		public override int Compare(VisualEffectControlPlayableBehaviour x, VisualEffectControlPlayableBehaviour y) { }

	}

	[Token(Token = "0x400009A")]
	private const int kErrorIndex = -2147483648; //Field offset: 0x0
	[Token(Token = "0x40000A3")]
	private static readonly double kEpsilonEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009B")]
	private int m_LastChunk; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400009C")]
	private int m_LastEvent; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009D")]
	private double m_LastPlayableTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009E")]
	private List<Int32> m_EventListIndexCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009F")]
	private VisualEffect m_Target; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A0")]
	private bool m_BackupReseedOnPlay; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000A1")]
	private uint m_BackupStartSeed; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A2")]
	private Chunk[] m_Chunks; //Field offset: 0x38

	[Address(RVA = "0x2F7C890", Offset = "0x2F7BC90", Length = "0x40")]
	[Token(Token = "0x6000097")]
	private static VisualEffectControlTrackController() { }

	[Address(RVA = "0x2F7C8D0", Offset = "0x2F7BCD0", Length = "0x93")]
	[Token(Token = "0x6000096")]
	public VisualEffectControlTrackController() { }

	[Address(RVA = "0x2F7A0A0", Offset = "0x2F794A0", Length = "0xAE")]
	[Token(Token = "0x6000091")]
	private static VFXEventAttribute ComputeAttribute(VisualEffect vfx, EventAttributes attributes) { }

	[Address(RVA = "0x2F7A150", Offset = "0x2F79550", Length = "0x8E")]
	[IteratorStateMachine(typeof(<ComputeRuntimeEvent>d__21))]
	[Token(Token = "0x6000092")]
	private static IEnumerable<Event> ComputeRuntimeEvent(VisualEffectControlPlayableBehaviour behavior, VisualEffect vfx) { }

	[Address(RVA = "0x2F7A1E0", Offset = "0x2F795E0", Length = "0x108")]
	[Token(Token = "0x6000090")]
	private static void GetEventsIndex(Chunk chunk, double minTime, double maxTime, int lastIndex, List<Int32> eventListIndex) { }

	[Address(RVA = "0x2F7A2F0", Offset = "0x2F796F0", Length = "0x1035")]
	[Token(Token = "0x6000094")]
	public void Init(Playable playable, VisualEffect vfx, VisualEffectControlTrack parentTrack) { }

	[Address(RVA = "0x2F7B330", Offset = "0x2F7A730", Length = "0x45")]
	[Token(Token = "0x600008C")]
	private bool IsTimeInChunk(double time, int index) { }

	[Address(RVA = "0x2F7B380", Offset = "0x2F7A780", Length = "0x116")]
	[Token(Token = "0x600008A")]
	private void OnEnterChunk(int currentChunk) { }

	[Address(RVA = "0x2F7B4A0", Offset = "0x2F7A8A0", Length = "0x115")]
	[Token(Token = "0x600008B")]
	private void OnLeaveChunk(int previousChunkIndex, bool leavingGoingBeforeClip) { }

	[Address(RVA = "0x2F7B5C0", Offset = "0x2F7A9C0", Length = "0x67")]
	[Token(Token = "0x600008F")]
	private void ProcessEvent(int eventIndex, Chunk currentChunk) { }

	[Address(RVA = "0x2F7B630", Offset = "0x2F7AA30", Length = "0x499")]
	[Token(Token = "0x600008E")]
	private void ProcessNoScrubbingEvents(Chunk chunk, double oldTime, double newTime) { }

	[Address(RVA = "0x2F7BAD0", Offset = "0x2F7AED0", Length = "0x9F")]
	[Token(Token = "0x6000095")]
	public void Release() { }

	[Address(RVA = "0x2F7BB70", Offset = "0x2F7AF70", Length = "0xC4")]
	[Token(Token = "0x6000093")]
	public void RestoreVFXState(bool restorePause = true, bool restoreSeedState = true) { }

	[Address(RVA = "0x2F7BC40", Offset = "0x2F7B040", Length = "0xC45")]
	[Token(Token = "0x600008D")]
	public void Update(double playableTime, float deltaTime) { }

}

