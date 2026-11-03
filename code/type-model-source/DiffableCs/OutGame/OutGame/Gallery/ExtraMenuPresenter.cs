namespace OutGame.Gallery;

[Token(Token = "0x20001DA")]
public class ExtraMenuPresenter : PresenterMenu<MenuItems>
{
	[CompilerGenerated]
	[Token(Token = "0x20001DD")]
	private sealed class <_Initialize>d__1 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000835")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000836")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000837")]
		public ExtraMenuPresenter <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000838")]
		private General <general>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000839")]
		private StorySaveData <storySaveData>5__3; //Field offset: 0x30

		[Token(Token = "0x170002B0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF4")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170002B1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000BF6")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000BF1")]
		public <_Initialize>d__1(int <>1__state) { }

		[Address(RVA = "0x2221350", Offset = "0x2220750", Length = "0x25C")]
		[Token(Token = "0x6000BF3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BF4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000BF6")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2221670", Offset = "0x2220A70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000BF5")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000BF2")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20001DC")]
	internal enum MenuItems : int
	{
		HowTo = 0,
		Tutorial = 1,
		Training = 2,
		Ranking = 3,
		ServiceRecord = 4,
		Achievement = 5,
		Model = 6,
		Comic = 7,
		Pipiru = 8,
		Credits = 9,
	}

	[Token(Token = "0x20001DB")]
	internal class Value : ValueMenu<MenuItems>
	{

		[Address(RVA = "0x2226940", Offset = "0x2225D40", Length = "0x46")]
		[Token(Token = "0x6000BF0")]
		public Value(MenuItems tmenu) { }

	}

	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000829")]
	private ComboButtonSelecter<MenuItems>[] _items; //Field offset: 0x58

	[Token(Token = "0x170002AB")]
	private ComboButtonSelecter<MenuItems> _achievement
	{
		[Address(RVA = "0x2215EC0", Offset = "0x22152C0", Length = "0x27")]
		[Token(Token = "0x6000BE9")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002AD")]
	private ComboButtonSelecter<MenuItems> _comic
	{
		[Address(RVA = "0x2215EF0", Offset = "0x22152F0", Length = "0x27")]
		[Token(Token = "0x6000BEB")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002AF")]
	private ComboButtonSelecter<MenuItems> _credits
	{
		[Address(RVA = "0x2215F20", Offset = "0x2215320", Length = "0x27")]
		[Token(Token = "0x6000BED")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002A6")]
	private ComboButtonSelecter<MenuItems> _howTo
	{
		[Address(RVA = "0x2215F50", Offset = "0x2215350", Length = "0x27")]
		[Token(Token = "0x6000BE4")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002AC")]
	private ComboButtonSelecter<MenuItems> _model
	{
		[Address(RVA = "0x2215F80", Offset = "0x2215380", Length = "0x27")]
		[Token(Token = "0x6000BEA")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002AE")]
	private ComboButtonSelecter<MenuItems> _pipiru
	{
		[Address(RVA = "0x2215FB0", Offset = "0x22153B0", Length = "0x27")]
		[Token(Token = "0x6000BEC")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002A9")]
	private ComboButtonSelecter<MenuItems> _ranking
	{
		[Address(RVA = "0x2215FE0", Offset = "0x22153E0", Length = "0x27")]
		[Token(Token = "0x6000BE7")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002AA")]
	private ComboButtonSelecter<MenuItems> _serviceRecord
	{
		[Address(RVA = "0x2216010", Offset = "0x2215410", Length = "0x27")]
		[Token(Token = "0x6000BE8")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002A8")]
	private ComboButtonSelecter<MenuItems> _training
	{
		[Address(RVA = "0x2216040", Offset = "0x2215440", Length = "0x27")]
		[Token(Token = "0x6000BE6")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002A7")]
	private ComboButtonSelecter<MenuItems> _tutorial
	{
		[Address(RVA = "0x2216070", Offset = "0x2215470", Length = "0x27")]
		[Token(Token = "0x6000BE5")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170002A5")]
	protected virtual ComboButtonSelecter<MenuItems>[] Items
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000BE3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2215B70", Offset = "0x2214F70", Length = "0x12C")]
	[Token(Token = "0x6000BE0")]
	protected virtual bool _decideMenu(ref MenuItems tmenu, bool isClicked = true) { }

	[Address(RVA = "0x2215E60", Offset = "0x2215260", Length = "0x51")]
	[Token(Token = "0x6000BE2")]
	private string _getMarqueeString(MenuItems tkind) { }

	[Address(RVA = "0x2215AC0", Offset = "0x2214EC0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_Initialize>d__1))]
	[Token(Token = "0x6000BDD")]
	protected virtual IEnumerator _Initialize() { }

	[Address(RVA = "0x2215B30", Offset = "0x2214F30", Length = "0x39")]
	[Token(Token = "0x6000BEE")]
	public ExtraMenuPresenter() { }

	[Address(RVA = "0x22159C0", Offset = "0x2214DC0", Length = "0x39")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000BEF")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x2215EC0", Offset = "0x22152C0", Length = "0x27")]
	[Token(Token = "0x6000BE9")]
	private ComboButtonSelecter<MenuItems> get__achievement() { }

	[Address(RVA = "0x2215EF0", Offset = "0x22152F0", Length = "0x27")]
	[Token(Token = "0x6000BEB")]
	private ComboButtonSelecter<MenuItems> get__comic() { }

	[Address(RVA = "0x2215F20", Offset = "0x2215320", Length = "0x27")]
	[Token(Token = "0x6000BED")]
	private ComboButtonSelecter<MenuItems> get__credits() { }

	[Address(RVA = "0x2215F50", Offset = "0x2215350", Length = "0x27")]
	[Token(Token = "0x6000BE4")]
	private ComboButtonSelecter<MenuItems> get__howTo() { }

	[Address(RVA = "0x2215F80", Offset = "0x2215380", Length = "0x27")]
	[Token(Token = "0x6000BEA")]
	private ComboButtonSelecter<MenuItems> get__model() { }

	[Address(RVA = "0x2215FB0", Offset = "0x22153B0", Length = "0x27")]
	[Token(Token = "0x6000BEC")]
	private ComboButtonSelecter<MenuItems> get__pipiru() { }

	[Address(RVA = "0x2215FE0", Offset = "0x22153E0", Length = "0x27")]
	[Token(Token = "0x6000BE7")]
	private ComboButtonSelecter<MenuItems> get__ranking() { }

	[Address(RVA = "0x2216010", Offset = "0x2215410", Length = "0x27")]
	[Token(Token = "0x6000BE8")]
	private ComboButtonSelecter<MenuItems> get__serviceRecord() { }

	[Address(RVA = "0x2216040", Offset = "0x2215440", Length = "0x27")]
	[Token(Token = "0x6000BE6")]
	private ComboButtonSelecter<MenuItems> get__training() { }

	[Address(RVA = "0x2216070", Offset = "0x2215470", Length = "0x27")]
	[Token(Token = "0x6000BE5")]
	private ComboButtonSelecter<MenuItems> get__tutorial() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000BE3")]
	protected virtual ComboButtonSelecter<MenuItems>[] get_Items() { }

	[Address(RVA = "0x22154D0", Offset = "0x22148D0", Length = "0x16E")]
	[Token(Token = "0x6000BDE")]
	public static bool IsNew() { }

	[Address(RVA = "0x2215640", Offset = "0x2214A40", Length = "0x37F")]
	[Token(Token = "0x6000BDF")]
	protected virtual void SetupButton() { }

	[Address(RVA = "0x2215A00", Offset = "0x2214E00", Length = "0xB3")]
	[Token(Token = "0x6000BE1")]
	protected virtual void UpdateMenu(MenuItems next, bool seFlg = true) { }

}

