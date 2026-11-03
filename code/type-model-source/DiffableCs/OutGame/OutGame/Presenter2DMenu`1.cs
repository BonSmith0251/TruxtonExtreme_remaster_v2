namespace OutGame;

[Token(Token = "0x200000F")]
public abstract class Presenter2DMenu : PresenterBasic<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <_BeginView>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		public Presenter2DMenu<T> <>4__this; //Field offset: 0x0

		[Token(Token = "0x17000012")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000060")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000013")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000062")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600005D")]
		public <_BeginView>d__6(int <>1__state) { }

		[Address(RVA = "0x1B7BD20", Offset = "0x1B7B120", Length = "0x1A9")]
		[Token(Token = "0x600005F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000060")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000062")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000061")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600005E")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000010")]
	internal class Value2DMenu : ValueBasic<T>
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private readonly T <TargetKind>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		private readonly PlayActor <TargetActor>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private readonly int <TargetStage>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000010")]
		public PlayActor TargetActor
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000059")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700000F")]
		public T TargetKind
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x6000058")]
			 get { } //Length: 85
		}

		[Token(Token = "0x17000011")]
		public int TargetStage
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600005A")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[Token(Token = "0x600005B")]
		public Value2DMenu(T kind) { }

		[Address(RVA = "0x11EB3F0", Offset = "0x11EA7F0", Length = "0x44")]
		[Token(Token = "0x600005C")]
		public Value2DMenu(T kind, PlayActor actor, int stage) { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000059")]
		public PlayActor get_TargetActor() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000058")]
		public T get_TargetKind() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600005A")]
		public int get_TargetStage() { }

	}

	[Token(Token = "0x400002C")]
	protected static readonly int StageMax; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400002D")]
	protected EpisodeButton[] _ash; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400002E")]
	protected EpisodeButton[] _bergamot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400002F")]
	protected EpisodeButton[] _chria; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000030")]
	protected T _storyKind; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000031")]
	protected PlayActor _storyActor; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000032")]
	protected int _storyStage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000033")]
	protected UISlideSelecter _currentSelecter; //Field offset: 0x0

	[Address(RVA = "0xE121A0", Offset = "0xE115A0", Length = "0x85")]
	[IteratorStateMachine(typeof(<_BeginView>d__6))]
	[Token(Token = "0x600004F")]
	protected virtual IEnumerator _BeginView() { }

	[Token(Token = "0x600004C")]
	protected abstract bool _decideMenu(ref T kind, PlayActor actor = -1, int stage = 0, bool isClicked = true) { }

	[Address(RVA = "0xE32200", Offset = "0xE31600", Length = "0x1FB")]
	[Token(Token = "0x6000052")]
	protected override void _updateMenu(bool isStory, T kind, PlayActor actor, int stage, bool seFlg = true) { }

	[Address(RVA = "0xE31D20", Offset = "0xE31120", Length = "0x56")]
	[Token(Token = "0x6000056")]
	private static Presenter2DMenu`1() { }

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000055")]
	protected Presenter2DMenu`1() { }

	[Address(RVA = "0xE31C00", Offset = "0xE31000", Length = "0x80")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000057")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0xE31300", Offset = "0xE30700", Length = "0x1F2")]
	[Token(Token = "0x6000051")]
	protected override void DecideMenu(T kind, PlayActor actor = -1, int stage = 0, bool isClicked = true) { }

	[Address(RVA = "0xE31670", Offset = "0xE30A70", Length = "0xDF")]
	[Token(Token = "0x6000054")]
	protected EpisodeButton GetEpisodeButton(PlayActor actor, int stage) { }

	[Token(Token = "0x600004A")]
	protected abstract void initButton() { }

	[Address(RVA = "0xE324B0", Offset = "0xE318B0", Length = "0x13C")]
	[Token(Token = "0x6000053")]
	protected bool isButtonEnable(PlayActor actor, int stage) { }

	[Token(Token = "0x600004D")]
	protected abstract void MoveCursor(int stepx, int stepy) { }

	[Address(RVA = "0xE31A00", Offset = "0xE30E00", Length = "0x1C0")]
	[Token(Token = "0x6000050")]
	protected virtual bool Select(AppGamePad pad) { }

	[Token(Token = "0x600004B")]
	protected abstract void SetupButton() { }

	[Token(Token = "0x600004E")]
	protected abstract void UpdateMenu(T kind, PlayActor actor, int stage, bool seFlg = true, bool foceCharacterFlg = false) { }

}

