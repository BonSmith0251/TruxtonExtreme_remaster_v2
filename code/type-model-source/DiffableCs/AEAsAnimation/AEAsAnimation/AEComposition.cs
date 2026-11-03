namespace AEAsAnimation;

[Token(Token = "0x2000010")]
public class AEComposition : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <>c
	{
		[Token(Token = "0x4000046")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000047")]
		public static Comparison<Int32> <>9__10_0; //Field offset: 0x8
		[Token(Token = "0x4000048")]
		public static Comparison<Int32> <>9__11_0; //Field offset: 0x10

		[Address(RVA = "0x5C1320", Offset = "0x5C0720", Length = "0x67")]
		[Token(Token = "0x600006C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600006D")]
		public <>c() { }

		[Address(RVA = "0x5C0190", Offset = "0x5BF590", Length = "0x7")]
		[Token(Token = "0x600006E")]
		internal int <SetUp>b__10_0(int a, int b) { }

		[Address(RVA = "0x5C0190", Offset = "0x5BF590", Length = "0x7")]
		[Token(Token = "0x600006F")]
		internal int <SetUpAsync>b__11_0(int a, int b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000012")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000049")]
		public AEItemsAccessor accessor; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004A")]
		public AEComposition <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000070")]
		public <>c__DisplayClass11_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private sealed class <>c__DisplayClass11_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004B")]
		public AELayer layer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004C")]
		public <>c__DisplayClass11_0 CS$<>8__locals1; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000071")]
		public <>c__DisplayClass11_1() { }

		[Address(RVA = "0x5C01A0", Offset = "0x5BF5A0", Length = "0x10B")]
		[Token(Token = "0x6000072")]
		internal void <SetUpAsync>b__1(AELayerReflection reflectionNode) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000014")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004D")]
		public AEItemsAccessor accessor; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004E")]
		public GameObject container; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004F")]
		public Action<AEComposition> callback; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000073")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x5C12C0", Offset = "0x5C06C0", Length = "0x5E")]
		[Token(Token = "0x6000074")]
		internal void <AttachAsync>b__0(AEComposition composition) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <AttachAsync>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000050")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000051")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000052")]
		public AEItemsAccessor accessor; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000053")]
		public Action<AEComposition> callback; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000054")]
		public CompositionData data; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000055")]
		public Transform parent; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000056")]
		public AELayer parentLayer; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000057")]
		public Stopwatch stopWatch; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000058")]
		public bool isChild; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000059")]
		private IEnumerator <enumerator>5__2; //Field offset: 0x58

		[Token(Token = "0x17000011")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000078")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000012")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600007A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000075")]
		public <AttachAsync>d__9(int <>1__state) { }

		[Address(RVA = "0x5BCDF0", Offset = "0x5BC1F0", Length = "0x4B4")]
		[Token(Token = "0x6000077")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000078")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600007A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BD2B0", Offset = "0x5BC6B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000079")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000076")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000016")]
	private sealed class <SetUpAsync>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400005C")]
		public AEItemsAccessor accessor; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400005D")]
		public AEComposition <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400005E")]
		public CompositionData data; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400005F")]
		public AELayer parentLayer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000060")]
		public bool isChild; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000061")]
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000062")]
		public Stopwatch stopWatch; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000063")]
		private <>c__DisplayClass11_1 <>8__2; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000064")]
		public Action<AEComposition> callback; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000065")]
		private Dictionary<Int32, AELayer> <indexMap>5__2; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000066")]
		private Enumerator<Int32> <>7__wrap2; //Field offset: 0x70
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000067")]
		private AELayerReflector <reflector>5__4; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000068")]
		private IEnumerator <enumerator>5__5; //Field offset: 0x90

		[Token(Token = "0x17000013")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600007F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000014")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000081")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600007B")]
		public <SetUpAsync>d__11(int <>1__state) { }

		[Address(RVA = "0x5BEF50", Offset = "0x5BE350", Length = "0x41")]
		[Token(Token = "0x600007E")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x5BD2F0", Offset = "0x5BC6F0", Length = "0x1B8F")]
		[Token(Token = "0x600007D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600007F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000081")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BEE80", Offset = "0x5BE280", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000080")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BEEC0", Offset = "0x5BE2C0", Length = "0x85")]
		[DebuggerHidden]
		[Token(Token = "0x600007C")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003E")]
	private CompositionData _data; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003F")]
	private Transform _nodeTreeRoot; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000040")]
	private Transform _reflectionRoot; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000041")]
	private List<AELayer> _layers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000042")]
	private List<AELayerReflection> _reflections; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000043")]
	private AELayer _parentLayer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000044")]
	private float _inSeconds; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000045")]
	private float _outSeconds; //Field offset: 0x54

	[Token(Token = "0x1700000E")]
	public List<String> allImageFiles
	{
		[Address(RVA = "0x5B2B60", Offset = "0x5B1F60", Length = "0x498")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 1176
	}

	[Token(Token = "0x17000010")]
	public List<String> allLayerMetaData
	{
		[Address(RVA = "0x5B3000", Offset = "0x5B2400", Length = "0x403")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 1027
	}

	[Token(Token = "0x1700000F")]
	public List<String> allLayerNames
	{
		[Address(RVA = "0x5B3410", Offset = "0x5B2810", Length = "0x3E3")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 995
	}

	[Token(Token = "0x1700000B")]
	public float inSeconds
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000D")]
	public List<MarkerData> markerList
	{
		[Address(RVA = "0x5B3810", Offset = "0x5B2C10", Length = "0x1B")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700000C")]
	public float outSeconds
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B2AA0", Offset = "0x5B1EA0", Length = "0xBD")]
	[Token(Token = "0x600006B")]
	public AEComposition() { }

	[Address(RVA = "0x5B0FD0", Offset = "0x5B03D0", Length = "0x318")]
	[Token(Token = "0x600005D")]
	public static AEComposition Attach(Transform parent, CompositionData data, AEItemsAccessor accessor, AELayer parentLayer, bool isChild) { }

	[Address(RVA = "0x5B0EE0", Offset = "0x5B02E0", Length = "0xEC")]
	[IteratorStateMachine(typeof(<AttachAsync>d__9))]
	[Token(Token = "0x600005E")]
	public static IEnumerator AttachAsync(Transform parent, CompositionData data, AEItemsAccessor accessor, AELayer parentLayer, bool isChild, Action<AEComposition> callback, Stopwatch stopWatch) { }

	[Address(RVA = "0x5B12F0", Offset = "0x5B06F0", Length = "0xF8")]
	[Token(Token = "0x6000061")]
	public float CalcParentRemapedTime(float remapSeconds) { }

	[Address(RVA = "0x5B2B60", Offset = "0x5B1F60", Length = "0x498")]
	[Token(Token = "0x6000067")]
	public List<String> get_allImageFiles() { }

	[Address(RVA = "0x5B3000", Offset = "0x5B2400", Length = "0x403")]
	[Token(Token = "0x6000069")]
	public List<String> get_allLayerMetaData() { }

	[Address(RVA = "0x5B3410", Offset = "0x5B2810", Length = "0x3E3")]
	[Token(Token = "0x6000068")]
	public List<String> get_allLayerNames() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000062")]
	public float get_inSeconds() { }

	[Address(RVA = "0x5B3810", Offset = "0x5B2C10", Length = "0x1B")]
	[Token(Token = "0x6000066")]
	public List<MarkerData> get_markerList() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x6000063")]
	public float get_outSeconds() { }

	[Address(RVA = "0x5B13F0", Offset = "0x5B07F0", Length = "0x85")]
	[Token(Token = "0x6000064")]
	public float GetOpacity() { }

	[Address(RVA = "0x5B1480", Offset = "0x5B0880", Length = "0x1A")]
	[Token(Token = "0x6000065")]
	public int GetTotalFrame() { }

	[Address(RVA = "0x5B14A0", Offset = "0x5B08A0", Length = "0x1B")]
	[Token(Token = "0x600006A")]
	public bool IsFilterEnable() { }

	[Address(RVA = "0x5B15B0", Offset = "0x5B09B0", Length = "0x14E3")]
	[Token(Token = "0x600005F")]
	public AEComposition SetUp(CompositionData data, AEItemsAccessor accessor, AELayer parentLayer, bool isChild) { }

	[Address(RVA = "0x5B14C0", Offset = "0x5B08C0", Length = "0xEC")]
	[IteratorStateMachine(typeof(<SetUpAsync>d__11))]
	[Token(Token = "0x6000060")]
	public IEnumerator SetUpAsync(CompositionData data, AEItemsAccessor accessor, AELayer parentLayer, Action<AEComposition> callback, Stopwatch stopWatch, bool isChild) { }

}

