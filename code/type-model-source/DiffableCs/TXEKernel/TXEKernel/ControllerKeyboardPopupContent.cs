namespace TXEKernel;

[Token(Token = "0x2000101")]
public class ControllerKeyboardPopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000103")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000535")]
		public MenuItems tmenu; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000536")]
		public ControllerKeyboardPopupContent <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600076A")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x271FC50", Offset = "0x271F050", Length = "0x27")]
		[Token(Token = "0x600076B")]
		internal void <SetupButton>b__0() { }

		[Address(RVA = "0x271FC50", Offset = "0x271F050", Length = "0x27")]
		[Token(Token = "0x600076C")]
		internal void <SetupButton>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000104")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000537")]
		public ControllerKeyboardPopupContent <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000538")]
		public UISlideSelecter selecter; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600076D")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x271FC80", Offset = "0x271F080", Length = "0x2B")]
		[Token(Token = "0x600076E")]
		internal void <_SetupSelecter>b__0() { }

		[Address(RVA = "0x271FCB0", Offset = "0x271F0B0", Length = "0x2B")]
		[Token(Token = "0x600076F")]
		internal void <_SetupSelecter>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000105")]
	private sealed class <TerminateDelay>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000539")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400053A")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000214")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000773")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000215")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000775")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000770")]
		public <TerminateDelay>d__3(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x6000772")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000773")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000775")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x271EF70", Offset = "0x271E370", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000774")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000771")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000102")]
	private enum MenuItems : int
	{
		MOVEMENT = 0,
		SHOT = 1,
		BOMB = 2,
		EXBOOST = 3,
		CHANGESPEED = 4,
		SPEEDUP = 5,
		SPEEDDOWN = 6,
		SLOWSPEED = 7,
		DEFAULT = 8,
	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000526")]
	private readonly int MenuMax; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000527")]
	private String[] _movementTypeStr; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000528")]
	private KeyboardSettingPartsBase[] _items; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000529")]
	private UISlideSelecter _currentSelecter; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400052A")]
	private MenuItems _menuIndex; //Field offset: 0x80

	[Token(Token = "0x1700020D")]
	private KeyboardSettingParts2 _bomb
	{
		[Address(RVA = "0x270D720", Offset = "0x270CB20", Length = "0x88")]
		[Token(Token = "0x6000762")]
		private get { } //Length: 136
	}

	[Token(Token = "0x1700020F")]
	private KeyboardSettingParts2 _changeSpeed
	{
		[Address(RVA = "0x270D7B0", Offset = "0x270CBB0", Length = "0x88")]
		[Token(Token = "0x6000764")]
		private get { } //Length: 136
	}

	[Token(Token = "0x17000213")]
	private KeyboardSettingParts2 _Default
	{
		[Address(RVA = "0x270D600", Offset = "0x270CA00", Length = "0x88")]
		[Token(Token = "0x6000768")]
		private get { } //Length: 136
	}

	[Token(Token = "0x1700020E")]
	private KeyboardSettingParts2 _exboost
	{
		[Address(RVA = "0x270D840", Offset = "0x270CC40", Length = "0x88")]
		[Token(Token = "0x6000763")]
		private get { } //Length: 136
	}

	[Token(Token = "0x1700020B")]
	private KeyboardSettingParts1 _movement
	{
		[Address(RVA = "0x270D8D0", Offset = "0x270CCD0", Length = "0x88")]
		[Token(Token = "0x6000760")]
		private get { } //Length: 136
	}

	[Token(Token = "0x1700020C")]
	private KeyboardSettingParts2 _shot
	{
		[Address(RVA = "0x270D960", Offset = "0x270CD60", Length = "0x88")]
		[Token(Token = "0x6000761")]
		private get { } //Length: 136
	}

	[Token(Token = "0x17000212")]
	private KeyboardSettingParts2 _SlowSpeed
	{
		[Address(RVA = "0x270D690", Offset = "0x270CA90", Length = "0x88")]
		[Token(Token = "0x6000767")]
		private get { } //Length: 136
	}

	[Token(Token = "0x17000211")]
	private KeyboardSettingParts2 _speedDown
	{
		[Address(RVA = "0x270D9F0", Offset = "0x270CDF0", Length = "0x88")]
		[Token(Token = "0x6000766")]
		private get { } //Length: 136
	}

	[Token(Token = "0x17000210")]
	private KeyboardSettingParts2 _speedUp
	{
		[Address(RVA = "0x270DA80", Offset = "0x270CE80", Length = "0x88")]
		[Token(Token = "0x6000765")]
		private get { } //Length: 136
	}

	[Address(RVA = "0x270C400", Offset = "0x270B800", Length = "0x17E")]
	[Token(Token = "0x600075A")]
	private void _decideMenu(MenuItems tmenu, bool isClicked = true) { }

	[Address(RVA = "0x270C580", Offset = "0x270B980", Length = "0xF2")]
	[Token(Token = "0x600075C")]
	private void _defaultSetting() { }

	[Address(RVA = "0x270C680", Offset = "0x270BA80", Length = "0x51")]
	[Token(Token = "0x600075F")]
	private string _getMarqueeString(MenuItems tkind) { }

	[Address(RVA = "0x270C6E0", Offset = "0x270BAE0", Length = "0xFE")]
	[Token(Token = "0x600075B")]
	private void _moveCursor(int step) { }

	[Address(RVA = "0x270C7E0", Offset = "0x270BBE0", Length = "0x15C")]
	[Token(Token = "0x6000756")]
	private void _select(AppGamePad pad) { }

	[Address(RVA = "0x270C0E0", Offset = "0x270B4E0", Length = "0x197")]
	[Token(Token = "0x6000754")]
	private void _SetupSelecter(UISlideSelecter selecter, int index) { }

	[Address(RVA = "0x270CBE0", Offset = "0x270BFE0", Length = "0x48D")]
	[Token(Token = "0x600075E")]
	private void _updateMenu(MenuItems next, bool seFlg = true) { }

	[Address(RVA = "0x270D070", Offset = "0x270C470", Length = "0x583")]
	[Token(Token = "0x600075D")]
	private void _updateSetting() { }

	[Address(RVA = "0x270C280", Offset = "0x270B680", Length = "0x17B")]
	[Token(Token = "0x6000769")]
	public ControllerKeyboardPopupContent() { }

	[Address(RVA = "0x270B570", Offset = "0x270A970", Length = "0x90")]
	[Token(Token = "0x6000751")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x270D720", Offset = "0x270CB20", Length = "0x88")]
	[Token(Token = "0x6000762")]
	private KeyboardSettingParts2 get__bomb() { }

	[Address(RVA = "0x270D7B0", Offset = "0x270CBB0", Length = "0x88")]
	[Token(Token = "0x6000764")]
	private KeyboardSettingParts2 get__changeSpeed() { }

	[Address(RVA = "0x270D600", Offset = "0x270CA00", Length = "0x88")]
	[Token(Token = "0x6000768")]
	private KeyboardSettingParts2 get__Default() { }

	[Address(RVA = "0x270D840", Offset = "0x270CC40", Length = "0x88")]
	[Token(Token = "0x6000763")]
	private KeyboardSettingParts2 get__exboost() { }

	[Address(RVA = "0x270D8D0", Offset = "0x270CCD0", Length = "0x88")]
	[Token(Token = "0x6000760")]
	private KeyboardSettingParts1 get__movement() { }

	[Address(RVA = "0x270D960", Offset = "0x270CD60", Length = "0x88")]
	[Token(Token = "0x6000761")]
	private KeyboardSettingParts2 get__shot() { }

	[Address(RVA = "0x270D690", Offset = "0x270CA90", Length = "0x88")]
	[Token(Token = "0x6000767")]
	private KeyboardSettingParts2 get__SlowSpeed() { }

	[Address(RVA = "0x270D9F0", Offset = "0x270CDF0", Length = "0x88")]
	[Token(Token = "0x6000766")]
	private KeyboardSettingParts2 get__speedDown() { }

	[Address(RVA = "0x270DA80", Offset = "0x270CE80", Length = "0x88")]
	[Token(Token = "0x6000765")]
	private KeyboardSettingParts2 get__speedUp() { }

	[Address(RVA = "0x270B600", Offset = "0x270AA00", Length = "0x4E")]
	[Token(Token = "0x600074F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000759")]
	private void SelecterChanged(MenuItems menuItem) { }

	[Address(RVA = "0x270B650", Offset = "0x270AA50", Length = "0x301")]
	[Token(Token = "0x6000758")]
	private void SelecterClicked(UISlideSelecter selecter, int n) { }

	[Address(RVA = "0x270B960", Offset = "0x270AD60", Length = "0x417")]
	[Token(Token = "0x6000753")]
	private void SetupButton() { }

	[Address(RVA = "0x270BD80", Offset = "0x270B180", Length = "0x1BB")]
	[Token(Token = "0x6000755")]
	private void SetupSelecter() { }

	[Address(RVA = "0x270BF40", Offset = "0x270B340", Length = "0x43")]
	[Token(Token = "0x6000750")]
	public virtual void StartAppear() { }

	[Address(RVA = "0x270BF90", Offset = "0x270B390", Length = "0x4B")]
	[IteratorStateMachine(typeof(<TerminateDelay>d__3))]
	[Token(Token = "0x6000752")]
	public virtual IEnumerator TerminateDelay() { }

	[Address(RVA = "0x270BFE0", Offset = "0x270B3E0", Length = "0xFE")]
	[Token(Token = "0x6000757")]
	private void UpdateDirectionKey() { }

}

