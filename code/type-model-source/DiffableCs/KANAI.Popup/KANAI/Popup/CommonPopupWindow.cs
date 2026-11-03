namespace KANAI.Popup;

[Token(Token = "0x200000D")]
public class CommonPopupWindow : PopupBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000011")]
	private sealed class <_StartAppear>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000048")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000049")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004A")]
		public CommonPopupWindow <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000005")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000042")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000006")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000044")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600003F")]
		public <_StartAppear>d__8(int <>1__state) { }

		[Address(RVA = "0x1E0EDF0", Offset = "0x1E0E1F0", Length = "0xE7")]
		[Token(Token = "0x6000041")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000042")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000044")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0EEE0", Offset = "0x1E0E2E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000043")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <>c
	{
		[Token(Token = "0x400003E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400003F")]
		public static Predicate<PopupButtonInfo> <>9__2_0; //Field offset: 0x8
		[Token(Token = "0x4000040")]
		public static Func<PopupButtonInfo, Boolean> <>9__7_0; //Field offset: 0x10

		[Address(RVA = "0x1E0E790", Offset = "0x1E0DB90", Length = "0x67")]
		[Token(Token = "0x6000033")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000034")]
		public <>c() { }

		[Address(RVA = "0x1E0E440", Offset = "0x1E0D840", Length = "0x17")]
		[Token(Token = "0x6000035")]
		internal bool <ClickDefaultBackkey>b__2_0(PopupButtonInfo iBtn) { }

		[Address(RVA = "0x1E0E440", Offset = "0x1E0D840", Length = "0x17")]
		[Token(Token = "0x6000036")]
		internal bool <Initialize>b__7_0(PopupButtonInfo iInfo) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000041")]
		public int iIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000042")]
		public CommonPopupWindow <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000037")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x1E0E560", Offset = "0x1E0D960", Length = "0x24")]
		[Token(Token = "0x6000038")]
		internal void <SetButtonInfo>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000010")]
	private sealed class <AppearToActive>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000043")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000044")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000045")]
		public CommonPopupWindow <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000046")]
		private float <ttime>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000047")]
		private YieldInstruction <cacheWait>5__3; //Field offset: 0x30

		[Token(Token = "0x17000003")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003C")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000004")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003E")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000039")]
		public <AppearToActive>d__9(int <>1__state) { }

		[Address(RVA = "0x1E0D770", Offset = "0x1E0CB70", Length = "0x4C4")]
		[Token(Token = "0x600003B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0DC50", Offset = "0x1E0D050", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600003D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600003A")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private Text titleText; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private ButtonBase outOfRangeButton; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000039")]
	private List<PopupButtonInfo> buttonInfos; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400003A")]
	private int _currentIndex; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400003B")]
	private int _currentFloor; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400003C")]
	private float durationSecond; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[Token(Token = "0x400003D")]
	private Vector3 startScale; //Field offset: 0xCC

	[Address(RVA = "0x1E05E00", Offset = "0x1E05200", Length = "0x7A")]
	[Token(Token = "0x6000029")]
	public PopupButton _getButton(int iButtonIndex) { }

	[Address(RVA = "0x1E05DC0", Offset = "0x1E051C0", Length = "0x31")]
	[Token(Token = "0x600002B")]
	private float _getButtonSpace() { }

	[Address(RVA = "0x1E05A90", Offset = "0x1E04E90", Length = "0x98")]
	[Token(Token = "0x600002D")]
	private bool _IsAnimationButton() { }

	[Address(RVA = "0x1E05B30", Offset = "0x1E04F30", Length = "0x8B")]
	[Token(Token = "0x600002C")]
	private bool _IsLockButtons() { }

	[Address(RVA = "0x1E05BC0", Offset = "0x1E04FC0", Length = "0x98")]
	[Token(Token = "0x600002E")]
	private void _OnClickOutOfRange() { }

	[Address(RVA = "0x1E05C60", Offset = "0x1E05060", Length = "0x67")]
	[IteratorStateMachine(typeof(<_StartAppear>d__8))]
	[Token(Token = "0x6000022")]
	protected virtual IEnumerator _StartAppear() { }

	[Address(RVA = "0x1E05CD0", Offset = "0x1E050D0", Length = "0x9C")]
	[Token(Token = "0x6000028")]
	protected virtual void _Update() { }

	[Address(RVA = "0x1E05D70", Offset = "0x1E05170", Length = "0x4F")]
	[Token(Token = "0x600002F")]
	public CommonPopupWindow() { }

	[Address(RVA = "0x1E059B0", Offset = "0x1E04DB0", Length = "0x67")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000030")]
	private IEnumerator <>n__0() { }

	[Address(RVA = "0x1E05A20", Offset = "0x1E04E20", Length = "0x67")]
	[CompilerGenerated]
	[DebuggerHidden]
	[Token(Token = "0x6000032")]
	private IEnumerator <>n__1() { }

	[Address(RVA = "0x1E05980", Offset = "0x1E04D80", Length = "0x2D")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	private bool <AppearToActive>b__9_0() { }

	[Address(RVA = "0x1E04A50", Offset = "0x1E03E50", Length = "0x67")]
	[IteratorStateMachine(typeof(<AppearToActive>d__9))]
	[Token(Token = "0x6000023")]
	public virtual IEnumerator AppearToActive() { }

	[Address(RVA = "0x1E04AC0", Offset = "0x1E03EC0", Length = "0x144")]
	[Token(Token = "0x600001C")]
	public virtual void ClickDefaultBackkey() { }

	[Address(RVA = "0x1E04C10", Offset = "0x1E04010", Length = "0x92")]
	[Token(Token = "0x6000026")]
	public virtual void Disappear() { }

	[Address(RVA = "0x1E04CB0", Offset = "0x1E040B0", Length = "0x47")]
	[Token(Token = "0x600001F")]
	public virtual int GetButtonCount() { }

	[Address(RVA = "0x1E04D00", Offset = "0x1E04100", Length = "0x214")]
	[Token(Token = "0x6000021")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E04F20", Offset = "0x1E04320", Length = "0xD8")]
	[Token(Token = "0x6000025")]
	public virtual bool IsDisappearOK() { }

	[Address(RVA = "0x1E05000", Offset = "0x1E04400", Length = "0x12D")]
	[Token(Token = "0x600002A")]
	public void OnClickButton(int iButtonIndex) { }

	[Address(RVA = "0x1E05130", Offset = "0x1E04530", Length = "0x10F")]
	[Token(Token = "0x6000024")]
	public virtual void ReActive() { }

	[Address(RVA = "0x1E05240", Offset = "0x1E04640", Length = "0x97")]
	[Token(Token = "0x6000020")]
	public virtual void SetButtonEnable(int iIndex, bool isEnable) { }

	[Address(RVA = "0x1E052E0", Offset = "0x1E046E0", Length = "0x50F")]
	[Token(Token = "0x600001E")]
	public virtual void SetButtonInfo(List<PopupButtonInfo> lists) { }

	[Address(RVA = "0x1E057F0", Offset = "0x1E04BF0", Length = "0x95")]
	[Token(Token = "0x600001D")]
	public virtual void SetTitle(string value) { }

	[Address(RVA = "0x1E05890", Offset = "0x1E04C90", Length = "0xE8")]
	[Token(Token = "0x6000027")]
	public virtual void Terminate() { }

}

