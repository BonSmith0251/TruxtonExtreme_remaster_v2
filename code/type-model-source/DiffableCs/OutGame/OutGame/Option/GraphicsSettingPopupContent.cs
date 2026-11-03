namespace OutGame.Option;

[Token(Token = "0x20000D7")]
public class GraphicsSettingPopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000D9")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035F")]
		public MenuItems tmenu; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000360")]
		public GraphicsSettingPopupContent <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000559")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x21E0AC0", Offset = "0x21DFEC0", Length = "0x34")]
		[Token(Token = "0x600055A")]
		internal void <SetupButton>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DA")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000361")]
		public GraphicsSettingPopupContent <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000362")]
		public TXERSelecter selecter; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600055B")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x21E0B30", Offset = "0x21DFF30", Length = "0x2B")]
		[Token(Token = "0x600055C")]
		internal void <_SetupSelecter>b__0() { }

		[Address(RVA = "0x21E0B60", Offset = "0x21DFF60", Length = "0x2B")]
		[Token(Token = "0x600055D")]
		internal void <_SetupSelecter>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DB")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000363")]
		public GraphicsSettingPopupContent <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000364")]
		public TXERSelecterNumber selecter; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600055E")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x21E0B30", Offset = "0x21DFF30", Length = "0x2B")]
		[Token(Token = "0x600055F")]
		internal void <_SetupSelecter>b__0() { }

		[Address(RVA = "0x21E0B60", Offset = "0x21DFF60", Length = "0x2B")]
		[Token(Token = "0x6000560")]
		internal void <_SetupSelecter>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DC")]
	private sealed class <PopupConfirm>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000365")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000366")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000367")]
		public GraphicsSettingPopupContent <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700013D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000564")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700013E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000566")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000561")]
		public <PopupConfirm>d__15(int <>1__state) { }

		[Address(RVA = "0x21DE260", Offset = "0x21DD660", Length = "0x359")]
		[Token(Token = "0x6000563")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000564")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000566")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x21DE5C0", Offset = "0x21DD9C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000565")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000562")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20000D8")]
	private enum MenuItems : int
	{
		Resolution = 0,
		FullScreen = 1,
		Brightness = 2,
		VSync = 3,
		NVReflex = 4,
	}

	[Token(Token = "0x4000351")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"width", "height"})]
	public static readonly ValueTuple<Int32, Int32>[] AllowedResolutions; //Field offset: 0x0
	[Token(Token = "0x4000352")]
	private static readonly String[] _allowedResolutionsKeys; //Field offset: 0x8
	[Token(Token = "0x4000353")]
	private static readonly String[] _fullscreenKeys; //Field offset: 0x10
	[Token(Token = "0x4000354")]
	private static readonly String[] _vSyncKeys; //Field offset: 0x18
	[Token(Token = "0x4000355")]
	private static readonly String[] _nvReflexKeys; //Field offset: 0x20
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000348")]
	private readonly int MenuMax; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000349")]
	private TXEFontButton[] _buttons; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400034A")]
	private TXERSelecter _resolution; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400034B")]
	private TXERSelecter _fullScreen; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400034C")]
	private TXERSelecterNumber _brightness; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400034D")]
	private TXERSelecter _vSync; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x400034E")]
	private TXERSelecter _nvReflex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400034F")]
	private int _defResolution; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000350")]
	private int _defFullscreen; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000356")]
	private UISlideSelecter _currentSelecter; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000357")]
	private MenuItems _menuIndex; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000358")]
	private Dictionary<MenuItems, String> _locKeys; //Field offset: 0xB0

	[Address(RVA = "0x21D60D0", Offset = "0x21D54D0", Length = "0x14")]
	[Token(Token = "0x600054B")]
	private void _decideMenu(MenuItems tmenu, bool isClicked = true) { }

	[Address(RVA = "0x21D60F0", Offset = "0x21D54F0", Length = "0x54")]
	[Token(Token = "0x6000555")]
	private string _getMarqueeString(MenuItems tkind) { }

	[Address(RVA = "0x21D6150", Offset = "0x21D5550", Length = "0x89")]
	[Token(Token = "0x600054C")]
	private void _moveCursor(int step) { }

	[Address(RVA = "0x21D61E0", Offset = "0x21D55E0", Length = "0x2B3")]
	[Token(Token = "0x6000547")]
	private void _select(AppGamePad pad) { }

	[Address(RVA = "0x21D56D0", Offset = "0x21D4AD0", Length = "0x1CF")]
	[Token(Token = "0x6000544")]
	private void _SetupSelecter(TXERSelecter selecter, int index, String[] strings = null) { }

	[Address(RVA = "0x21D58A0", Offset = "0x21D4CA0", Length = "0x197")]
	[Token(Token = "0x6000545")]
	private void _SetupSelecter(TXERSelecterNumber selecter, int index) { }

	[Address(RVA = "0x21D64A0", Offset = "0x21D58A0", Length = "0x9A")]
	[Token(Token = "0x6000553")]
	private void _updateGraphicsSettings() { }

	[Address(RVA = "0x21D6540", Offset = "0x21D5940", Length = "0x3C0")]
	[Token(Token = "0x600054D")]
	private void _updateMenu(int tindex, bool seFlg = true) { }

	[Address(RVA = "0x21D6910", Offset = "0x21D5D10", Length = "0x80")]
	[Token(Token = "0x6000554")]
	private void _updateNvReflex() { }

	[Address(RVA = "0x21D69A0", Offset = "0x21D5DA0", Length = "0xED")]
	[Token(Token = "0x6000552")]
	private void _updateScreenResolution() { }

	[Address(RVA = "0x21D5A40", Offset = "0x21D4E40", Length = "0x4CB")]
	[Token(Token = "0x6000557")]
	private static GraphicsSettingPopupContent() { }

	[Address(RVA = "0x21D5F10", Offset = "0x21D5310", Length = "0x1B5")]
	[Token(Token = "0x6000556")]
	public GraphicsSettingPopupContent() { }

	[Address(RVA = "0x21D55A0", Offset = "0x21D49A0", Length = "0x123")]
	[CompilerGenerated]
	[Token(Token = "0x6000558")]
	private bool <PopupConfirm>b__15_0(int id) { }

	[Address(RVA = "0x21D6A90", Offset = "0x21D5E90", Length = "0xAB")]
	[Token(Token = "0x6000550")]
	private void checkDefaultSetting(MenuItems menuItem) { }

	[Address(RVA = "0x21D48D0", Offset = "0x21D3CD0", Length = "0x90")]
	[Token(Token = "0x6000541")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x21D4960", Offset = "0x21D3D60", Length = "0x1DA")]
	[Token(Token = "0x6000540")]
	public virtual void Initialize() { }

	[Address(RVA = "0x21D4B40", Offset = "0x21D3F40", Length = "0x3E")]
	[Token(Token = "0x6000551")]
	private bool IsDefaultSetting() { }

	[Address(RVA = "0x21D4B80", Offset = "0x21D3F80", Length = "0x10A")]
	[Token(Token = "0x600054E")]
	private void OnClickReturn() { }

	[Address(RVA = "0x21D6B40", Offset = "0x21D5F40", Length = "0xBB")]
	[Token(Token = "0x6000548")]
	private void onLeftClicked(UISlideSelecter selecter, int n = 1) { }

	[Address(RVA = "0x21D6C00", Offset = "0x21D6000", Length = "0xBB")]
	[Token(Token = "0x6000549")]
	private void onRightClicked(UISlideSelecter selecter, int n = 1) { }

	[Address(RVA = "0x21D4C90", Offset = "0x21D4090", Length = "0x67")]
	[IteratorStateMachine(typeof(<PopupConfirm>d__15))]
	[Token(Token = "0x600054F")]
	private IEnumerator PopupConfirm() { }

	[Address(RVA = "0x21D6CC0", Offset = "0x21D60C0", Length = "0x175")]
	[Token(Token = "0x600054A")]
	private void selecterClicked() { }

	[Address(RVA = "0x21D4D00", Offset = "0x21D4100", Length = "0x417")]
	[Token(Token = "0x6000543")]
	private void SetupButton() { }

	[Address(RVA = "0x21D5120", Offset = "0x21D4520", Length = "0x41F")]
	[Token(Token = "0x6000546")]
	private void SetupSelecter() { }

	[Address(RVA = "0x21D5540", Offset = "0x21D4940", Length = "0x60")]
	[Token(Token = "0x6000542")]
	public virtual void StartAppear() { }

}

