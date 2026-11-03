namespace TXEKernel;

[Token(Token = "0x20000D0")]
public class TXEComicPlayer : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20000D1")]
	private sealed class <CoroutineWaitForStop>d__44 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400043B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400043C")]
		public TXEComicPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400043D")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x28

		[Token(Token = "0x170001E4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000667")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001E5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000669")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000664")]
		public <CoroutineWaitForStop>d__44(int <>1__state) { }

		[Address(RVA = "0x271A4F0", Offset = "0x27198F0", Length = "0x11F")]
		[Token(Token = "0x6000666")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000667")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000669")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271A650", Offset = "0x2719A50", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000668")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000665")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D2")]
	private sealed class <Load>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400043F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000440")]
		public TXEComicPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000441")]
		public string episodeDatabaseAddress; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000442")]
		public string locale; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000443")]
		public string episodeLabel; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000444")]
		private DebugStopWatch <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000445")]
		private DebugStopWatch <>7__wrap2; //Field offset: 0x48

		[Token(Token = "0x170001E6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000672")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001E7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000674")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600066A")]
		public <Load>d__37(int <>1__state) { }

		[Address(RVA = "0x271D640", Offset = "0x271CA40", Length = "0x50")]
		[Token(Token = "0x600066D")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x271D690", Offset = "0x271CA90", Length = "0x50")]
		[Token(Token = "0x600066E")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x271D6E0", Offset = "0x271CAE0", Length = "0x50")]
		[Token(Token = "0x600066F")]
		private void <>m__Finally3() { }

		[Address(RVA = "0x271D730", Offset = "0x271CB30", Length = "0x50")]
		[Token(Token = "0x6000670")]
		private void <>m__Finally4() { }

		[Address(RVA = "0x271D780", Offset = "0x271CB80", Length = "0x50")]
		[Token(Token = "0x6000671")]
		private void <>m__Finally5() { }

		[Address(RVA = "0x271C600", Offset = "0x271BA00", Length = "0xBC0")]
		[Token(Token = "0x600066C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000672")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000674")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271D1F0", Offset = "0x271C5F0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000673")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x271D230", Offset = "0x271C630", Length = "0x3CC")]
		[DebuggerHidden]
		[Token(Token = "0x600066B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D3")]
	private sealed class <LoadJson>d__38 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000446")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000447")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000448")]
		public TXEComicPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000449")]
		private IEnumerator<AEData> <>7__wrap1; //Field offset: 0x28

		[Token(Token = "0x170001E8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000679")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001E9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600067B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000675")]
		public <LoadJson>d__38(int <>1__state) { }

		[Address(RVA = "0x271B500", Offset = "0x271A900", Length = "0x50")]
		[Token(Token = "0x6000678")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x271B0B0", Offset = "0x271A4B0", Length = "0x37D")]
		[Token(Token = "0x6000677")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000679")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600067B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271B430", Offset = "0x271A830", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600067A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x271B470", Offset = "0x271A870", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x6000676")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D4")]
	private sealed class <LoadPage>d__45 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400044A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400044B")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400044C")]
		public TXEComicPlayer <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400044D")]
		private DebugStopWatch <>7__wrap1; //Field offset: 0x28

		[Token(Token = "0x170001EA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000680")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001EB")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000682")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600067C")]
		public <LoadPage>d__45(int <>1__state) { }

		[Address(RVA = "0x271BE30", Offset = "0x271B230", Length = "0x50")]
		[Token(Token = "0x600067F")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x271B910", Offset = "0x271AD10", Length = "0x44E")]
		[Token(Token = "0x600067E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000680")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000682")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271BD60", Offset = "0x271B160", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000681")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x271BDA0", Offset = "0x271B1A0", Length = "0x8C")]
		[DebuggerHidden]
		[Token(Token = "0x600067D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000D5")]
	private sealed class <PreloadAEDataSpriteReferences>d__39 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400044E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400044F")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x170001EC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000686")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170001ED")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000688")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000683")]
		public <PreloadAEDataSpriteReferences>d__39(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x6000685")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000686")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000688")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271DE20", Offset = "0x271D220", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000687")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000684")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x400042E")]
	private static readonly string PageEndMarker; //Field offset: 0x0
	[Token(Token = "0x4000423")]
	private const string KrJpSpecialEpisodeLabel = "a00"; //Field offset: 0x0
	[Token(Token = "0x400042F")]
	private static readonly string PageLastMarker; //Field offset: 0x8
	[Token(Token = "0x4000430")]
	private static readonly string EpisodeFinalMarker; //Field offset: 0x10
	[Token(Token = "0x4000431")]
	private static readonly List<String> _markerTags; //Field offset: 0x18
	[Token(Token = "0x4000432")]
	private static readonly ID SEIdEnd; //Field offset: 0x20
	[Token(Token = "0x4000433")]
	private static readonly ID SEIdLast; //Field offset: 0x24
	[Token(Token = "0x4000434")]
	private static readonly ID SEIdLeft; //Field offset: 0x28
	[Token(Token = "0x4000435")]
	private static readonly ID SEIdRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000419")]
	private string _episodeDatabaseAddress; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400041A")]
	private ComicDataBaseRecords _episodeDatabase; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400041B")]
	private TXEAEPlayer _txeAEPlayer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400041C")]
	private TextureAccessor _textures; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400041D")]
	private AudioAccessor _audio; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400041E")]
	private AECompositionFilter _compositionFilter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400041F")]
	private AELayerFilter _layerFilter; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000420")]
	private string _episodeLabel; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000421")]
	private string _locale; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000422")]
	private string _localeValue; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000424")]
	private SortedDictionary<String, AEData> _comicDatas; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000425")]
	private List<String> _comicLabels; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000426")]
	private int _currentPage; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000427")]
	private bool _loading; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Token(Token = "0x4000428")]
	private bool _isStop; //Field offset: 0x85
	[FieldOffset(Offset = "0x86")]
	[Token(Token = "0x4000429")]
	private bool _isPauseArea; //Field offset: 0x86
	[FieldOffset(Offset = "0x87")]
	[Token(Token = "0x400042A")]
	private bool _isAutoPlay; //Field offset: 0x87
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400042B")]
	private float _autoTimer; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400042C")]
	private readonly float _autoDelay; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400042D")]
	private bool _disableHelpGuide; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000436")]
	private int _soundChEnd; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000437")]
	private int _soundChLast; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000438")]
	private int _soundChLeft; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000439")]
	private int _soundChRight; //Field offset: 0xA0

	[Token(Token = "0x170001E3")]
	private bool IsKrJpSpecialEpisode
	{
		[Address(RVA = "0x2714490", Offset = "0x2713890", Length = "0x66")]
		[Token(Token = "0x6000651")]
		private get { } //Length: 102
	}

	[Address(RVA = "0x2714060", Offset = "0x2713460", Length = "0x3F0")]
	[Token(Token = "0x6000663")]
	private static TXEComicPlayer() { }

	[Address(RVA = "0x2714460", Offset = "0x2713860", Length = "0x27")]
	[Token(Token = "0x6000662")]
	public TXEComicPlayer() { }

	[Address(RVA = "0x27123E0", Offset = "0x27117E0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CoroutineWaitForStop>d__44))]
	[Token(Token = "0x600065B")]
	public IEnumerator CoroutineWaitForStop() { }

	[Address(RVA = "0x2714490", Offset = "0x2713890", Length = "0x66")]
	[Token(Token = "0x6000651")]
	private bool get_IsKrJpSpecialEpisode() { }

	[Address(RVA = "0x2712450", Offset = "0x2711850", Length = "0x7")]
	[Token(Token = "0x600065F")]
	private void HideHelpGuild() { }

	[Address(RVA = "0x2712460", Offset = "0x2711860", Length = "0x2B6")]
	[Token(Token = "0x6000652")]
	public void Initialize() { }

	[Address(RVA = "0x2712720", Offset = "0x2711B20", Length = "0x9A")]
	[Token(Token = "0x6000661")]
	private bool IsEpisodeEnd() { }

	[Address(RVA = "0x27128A0", Offset = "0x2711CA0", Length = "0xC0")]
	[IteratorStateMachine(typeof(<Load>d__37))]
	[Token(Token = "0x6000654")]
	public IEnumerator Load(string episodeDatabaseAddress, string episodeLabel, string locale) { }

	[Address(RVA = "0x27127C0", Offset = "0x2711BC0", Length = "0x67")]
	[IteratorStateMachine(typeof(<LoadJson>d__38))]
	[Token(Token = "0x6000655")]
	private IEnumerator LoadJson() { }

	[Address(RVA = "0x2712830", Offset = "0x2711C30", Length = "0x67")]
	[IteratorStateMachine(typeof(<LoadPage>d__45))]
	[Token(Token = "0x600065C")]
	private IEnumerator LoadPage() { }

	[Address(RVA = "0x2712960", Offset = "0x2711D60", Length = "0x1FB")]
	[Token(Token = "0x600065A")]
	private void MarkerHit(MarkerData marker) { }

	[Address(RVA = "0x2712B60", Offset = "0x2711F60", Length = "0x39B")]
	[Token(Token = "0x600065D")]
	private void OnReady(AEAsAnimationRoot aeRoot, Dictionary<String, List`1<MarkerData>> markers) { }

	[Address(RVA = "0x2712F00", Offset = "0x2712300", Length = "0x77")]
	[Token(Token = "0x6000658")]
	public void Play() { }

	[Address(RVA = "0x2712F80", Offset = "0x2712380", Length = "0x4B")]
	[IteratorStateMachine(typeof(<PreloadAEDataSpriteReferences>d__39))]
	[Token(Token = "0x6000656")]
	private IEnumerator PreloadAEDataSpriteReferences() { }

	[Address(RVA = "0x2712FD0", Offset = "0x27123D0", Length = "0xD1")]
	[Token(Token = "0x600065E")]
	private void ReleasePage() { }

	[Address(RVA = "0x27130B0", Offset = "0x27124B0", Length = "0xBF")]
	[Token(Token = "0x6000660")]
	private void ShowHelpGuild(bool isAutoPlay) { }

	[Address(RVA = "0x2713170", Offset = "0x2712570", Length = "0x77")]
	[Token(Token = "0x6000657")]
	public void Stop() { }

	[Address(RVA = "0x27131F0", Offset = "0x27125F0", Length = "0x485")]
	[Token(Token = "0x6000653")]
	public void Terminate() { }

	[Address(RVA = "0x2713680", Offset = "0x2712A80", Length = "0x9B4")]
	[Token(Token = "0x6000659")]
	public void Update() { }

}

