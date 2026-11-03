namespace OutGame.Extra;

[Token(Token = "0x2000178")]
public class HowToPresenter : PresenterBasic<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x2000179")]
	private sealed class <_BeginView>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000699")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400069A")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400069B")]
		public HowToPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000209")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000963")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700020A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000965")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000960")]
		public <_BeginView>d__0(int <>1__state) { }

		[Address(RVA = "0x220A780", Offset = "0x2209B80", Length = "0x2B7")]
		[Token(Token = "0x6000962")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000963")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000965")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x220AA40", Offset = "0x2209E40", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000964")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000961")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000695")]
	private Transform _viewTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000696")]
	private List<GameObject> _pages; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000697")]
	private List<GameObject> _howToPages; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000698")]
	private int _nowPage; //Field offset: 0x60

	[Address(RVA = "0x21FDC10", Offset = "0x21FD010", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__0))]
	[Token(Token = "0x6000959")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x21FDD10", Offset = "0x21FD110", Length = "0x141")]
	[Token(Token = "0x600095C")]
	private void _dispPage(int pageNo) { }

	[Address(RVA = "0x21FDE60", Offset = "0x21FD260", Length = "0x97")]
	[Token(Token = "0x600095D")]
	private void _movePage(int delta) { }

	[Address(RVA = "0x21FDC80", Offset = "0x21FD080", Length = "0x88")]
	[Token(Token = "0x600095E")]
	public HowToPresenter() { }

	[Address(RVA = "0x21FDBD0", Offset = "0x21FCFD0", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x600095F")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600095A")]
	public static bool IsNew() { }

	[Address(RVA = "0x21FDB00", Offset = "0x21FCF00", Length = "0xC4")]
	[Token(Token = "0x600095B")]
	protected virtual bool Select(AppGamePad pad) { }

}

