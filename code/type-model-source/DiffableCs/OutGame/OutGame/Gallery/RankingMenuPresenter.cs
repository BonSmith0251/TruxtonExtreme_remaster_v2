namespace OutGame.Gallery;

[Token(Token = "0x20001E5")]
public class RankingMenuPresenter : PresenterMenu<MenuItems>
{
	[CompilerGenerated]
	[Token(Token = "0x20001E8")]
	private sealed class <_BeginView>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000855")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000856")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000857")]
		public RankingMenuPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002C4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C3E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002C5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C40")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3B")]
		public <_BeginView>d__2(int <>1__state) { }

		[Address(RVA = "0x221E680", Offset = "0x221DA80", Length = "0x17A")]
		[Token(Token = "0x6000C3D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000C40")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x221F160", Offset = "0x221E560", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000C3C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001E9")]
	private sealed class <_Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000858")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000859")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400085A")]
		public RankingMenuPresenter <>4__this; //Field offset: 0x20

		[Token(Token = "0x170002C6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C44")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002C7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000C46")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000C41")]
		public <_Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x2221210", Offset = "0x2220610", Length = "0x93")]
		[Token(Token = "0x6000C43")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000C44")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000C46")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2221630", Offset = "0x2220A30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000C45")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000C42")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20001E7")]
	internal enum MenuItems : int
	{
		StoryAsh = 0,
		StoryBergamot = 1,
		StoryCyrilla = 2,
		Team = 3,
		Arcade = 4,
		Arena = 5,
	}

	[Token(Token = "0x20001E6")]
	internal class Value : ValueMenu<MenuItems>
	{

		[Address(RVA = "0x2226B00", Offset = "0x2225F00", Length = "0x3B")]
		[Token(Token = "0x6000C39")]
		public Value() { }

		[Address(RVA = "0x2226A40", Offset = "0x2225E40", Length = "0x46")]
		[Token(Token = "0x6000C3A")]
		public Value(MenuItems tmenu) { }

	}

	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400084D")]
	private ComboButtonSelecter<MenuItems>[] _items; //Field offset: 0x58

	[Token(Token = "0x170002C2")]
	private ComboButtonSelecter<MenuItems> _arcade
	{
		[Address(RVA = "0x2216010", Offset = "0x2215410", Length = "0x27")]
		[Token(Token = "0x6000C34")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002C3")]
	private ComboButtonSelecter<MenuItems> _arena
	{
		[Address(RVA = "0x2215EC0", Offset = "0x22152C0", Length = "0x27")]
		[Token(Token = "0x6000C35")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002BE")]
	private ComboButtonSelecter<MenuItems> _storyAsh
	{
		[Address(RVA = "0x2215F50", Offset = "0x2215350", Length = "0x27")]
		[Token(Token = "0x6000C30")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002BF")]
	private ComboButtonSelecter<MenuItems> _storyBergamot
	{
		[Address(RVA = "0x2216070", Offset = "0x2215470", Length = "0x27")]
		[Token(Token = "0x6000C31")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002C0")]
	private ComboButtonSelecter<MenuItems> _storyCyrilla
	{
		[Address(RVA = "0x2216040", Offset = "0x2215440", Length = "0x27")]
		[Token(Token = "0x6000C32")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002C1")]
	private ComboButtonSelecter<MenuItems> _team
	{
		[Address(RVA = "0x2215FE0", Offset = "0x22153E0", Length = "0x27")]
		[Token(Token = "0x6000C33")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002BD")]
	protected virtual ComboButtonSelecter<MenuItems>[] Items
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000C2F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2217790", Offset = "0x2216B90", Length = "0x67")]
	[IteratorStateMachine(typeof(<_BeginView>d__2))]
	[Token(Token = "0x6000C2A")]
	protected virtual IEnumerator _BeginView() { }

	[Address(RVA = "0x22178B0", Offset = "0x2216CB0", Length = "0xDC")]
	[Token(Token = "0x6000C2C")]
	protected virtual bool _decideMenu(ref MenuItems tmenu, bool isClicked = true) { }

	[Address(RVA = "0x2217AD0", Offset = "0x2216ED0", Length = "0x51")]
	[Token(Token = "0x6000C2E")]
	private string _getMarqueeString(MenuItems tkind) { }

	[Address(RVA = "0x2217800", Offset = "0x2216C00", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__1))]
	[Token(Token = "0x6000C29")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x2217870", Offset = "0x2216C70", Length = "0x39")]
	[Token(Token = "0x6000C36")]
	public RankingMenuPresenter() { }

	[Address(RVA = "0x2217650", Offset = "0x2216A50", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000C37")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x2217690", Offset = "0x2216A90", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000C38")]
	private IEnumerator <>n__1() { }

	[Address(RVA = "0x2216010", Offset = "0x2215410", Length = "0x27")]
	[Token(Token = "0x6000C34")]
	private ComboButtonSelecter<MenuItems> get__arcade() { }

	[Address(RVA = "0x2215EC0", Offset = "0x22152C0", Length = "0x27")]
	[Token(Token = "0x6000C35")]
	private ComboButtonSelecter<MenuItems> get__arena() { }

	[Address(RVA = "0x2215F50", Offset = "0x2215350", Length = "0x27")]
	[Token(Token = "0x6000C30")]
	private ComboButtonSelecter<MenuItems> get__storyAsh() { }

	[Address(RVA = "0x2216070", Offset = "0x2215470", Length = "0x27")]
	[Token(Token = "0x6000C31")]
	private ComboButtonSelecter<MenuItems> get__storyBergamot() { }

	[Address(RVA = "0x2216040", Offset = "0x2215440", Length = "0x27")]
	[Token(Token = "0x6000C32")]
	private ComboButtonSelecter<MenuItems> get__storyCyrilla() { }

	[Address(RVA = "0x2215FE0", Offset = "0x22153E0", Length = "0x27")]
	[Token(Token = "0x6000C33")]
	private ComboButtonSelecter<MenuItems> get__team() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000C2F")]
	protected virtual ComboButtonSelecter<MenuItems>[] get_Items() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C2B")]
	public static bool IsNew() { }

	[Address(RVA = "0x22176D0", Offset = "0x2216AD0", Length = "0xB3")]
	[Token(Token = "0x6000C2D")]
	protected virtual void UpdateMenu(MenuItems next, bool seFlg = true) { }

}

