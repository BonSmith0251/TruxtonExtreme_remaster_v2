namespace KANAI.Popup;

[Token(Token = "0x200002C")]
public class PopupSystem : MonoBehaviourSingleton<PopupSystem>
{
	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <>c
	{
		[Token(Token = "0x40000F0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000F1")]
		public static Func<PopupInfo, Int32> <>9__14_0; //Field offset: 0x8
		[Token(Token = "0x40000F2")]
		public static Func<PopupInfo, Int32> <>9__14_2; //Field offset: 0x10
		[Token(Token = "0x40000F3")]
		public static Func<PopupInfo, Int32> <>9__20_1; //Field offset: 0x18

		[Address(RVA = "0x1E0E720", Offset = "0x1E0DB20", Length = "0x67")]
		[Token(Token = "0x6000149")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600014A")]
		public <>c() { }

		[Address(RVA = "0x1E0E460", Offset = "0x1E0D860", Length = "0x16")]
		[Token(Token = "0x600014B")]
		internal int <_Appear>b__14_0(PopupInfo i) { }

		[Address(RVA = "0x1E0E480", Offset = "0x1E0D880", Length = "0x1F")]
		[Token(Token = "0x600014C")]
		internal int <_Appear>b__14_2(PopupInfo iPopup) { }

		[Address(RVA = "0x1E0E4A0", Offset = "0x1E0D8A0", Length = "0x31")]
		[Token(Token = "0x600014D")]
		internal int <_getForegroundPopup>b__20_1(PopupInfo iInfo) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F4")]
		public int tid; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600014E")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x1E0E4E0", Offset = "0x1E0D8E0", Length = "0x25")]
		[Token(Token = "0x600014F")]
		internal bool <Hidden>b__0(PopupInfo iInfo) { }

		[Address(RVA = "0x1E0E4E0", Offset = "0x1E0D8E0", Length = "0x25")]
		[Token(Token = "0x6000150")]
		internal bool <Hidden>b__1(PopupInfo iInfo) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F5")]
		public int mp; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000151")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x1E0E510", Offset = "0x1E0D910", Length = "0x1C")]
		[Token(Token = "0x6000152")]
		internal bool <_Appear>b__1(PopupInfo i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F6")]
		public PopupState tstate; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000153")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x1E0E530", Offset = "0x1E0D930", Length = "0x25")]
		[Token(Token = "0x6000154")]
		internal bool <_getForegroundPopup>b__0(PopupInfo iInfo) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F7")]
		public int tid; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000155")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x1E0E4E0", Offset = "0x1E0D8E0", Length = "0x25")]
		[Token(Token = "0x6000156")]
		internal bool <IsExistsPopup>b__0(PopupInfo iInfo) { }

		[Address(RVA = "0x1E0E4E0", Offset = "0x1E0D8E0", Length = "0x25")]
		[Token(Token = "0x6000157")]
		internal bool <IsExistsPopup>b__1(PopupInfo iInfo) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000F8")]
		public PopupSystem <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F9")]
		public PopupBase popup; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000158")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x1E0E5D0", Offset = "0x1E0D9D0", Length = "0x148")]
		[Token(Token = "0x6000159")]
		internal bool <WaitHiddenPopup>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000034")]
	private sealed class <WaitHiddenPopup>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000FA")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000FB")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000FC")]
		public PopupSystem <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000FD")]
		public PopupBase popup; //Field offset: 0x28

		[Token(Token = "0x17000037")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600015D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000038")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600015F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600015A")]
		public <WaitHiddenPopup>d__8(int <>1__state) { }

		[Address(RVA = "0x1E0E800", Offset = "0x1E0DC00", Length = "0x12C")]
		[Token(Token = "0x600015C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600015D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600015F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0E930", Offset = "0x1E0DD30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600015E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600015B")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200002D")]
	private class PopupInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EE")]
		public PopupBase popup; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000EF")]
		public int priority; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000148")]
		public PopupInfo() { }

	}

	[Token(Token = "0x40000E7")]
	public const int ErrorPriority = 1000; //Field offset: 0x0
	[Token(Token = "0x40000ED")]
	private static readonly Vector3 ErrorPopupPosition; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000E8")]
	private Transform _popupRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E9")]
	private int nextPopupID; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000EA")]
	private PopupBase _frontPopup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000EB")]
	private List<PopupInfo> popupLists; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000EC")]
	private List<PopupInfo> initLists; //Field offset: 0x40

	[Token(Token = "0x17000036")]
	public PopupBase FrontPopup
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000145")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000035")]
	public Transform PopupRoot
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000144")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E0B610", Offset = "0x1E0AA10", Length = "0x4FA")]
	[Token(Token = "0x600013D")]
	private void _Appear() { }

	[Address(RVA = "0x1E0B540", Offset = "0x1E0A940", Length = "0xCB")]
	[Token(Token = "0x600013E")]
	private void _Appear(PopupInfo info, PopupInfo before) { }

	[Address(RVA = "0x1E0BB10", Offset = "0x1E0AF10", Length = "0x11C")]
	[Token(Token = "0x6000142")]
	private void _Destroy() { }

	[Address(RVA = "0x1E0BC30", Offset = "0x1E0B030", Length = "0x10F")]
	[Token(Token = "0x6000140")]
	private void _Disappear(PopupInfo info) { }

	[Address(RVA = "0x1E0BD40", Offset = "0x1E0B140", Length = "0x1AF")]
	[Token(Token = "0x600013F")]
	private void _Disappear() { }

	[Address(RVA = "0x1E0C030", Offset = "0x1E0B430", Length = "0x1FB")]
	[Token(Token = "0x6000143")]
	private PopupInfo _getForegroundPopup(PopupState tstate) { }

	[Address(RVA = "0x1E0BEF0", Offset = "0x1E0B2F0", Length = "0x2F")]
	[Token(Token = "0x6000141")]
	private void _Terminate(PopupInfo info) { }

	[Address(RVA = "0x1E0BF20", Offset = "0x1E0B320", Length = "0x4D")]
	[Token(Token = "0x6000147")]
	private static PopupSystem() { }

	[Address(RVA = "0x1E0BF70", Offset = "0x1E0B370", Length = "0xBD")]
	[Token(Token = "0x6000146")]
	public PopupSystem() { }

	[Address(RVA = "0x1E0A850", Offset = "0x1E09C50", Length = "0x176")]
	[Token(Token = "0x6000132")]
	public void CloseAll() { }

	[Address(RVA = "0x1E0A9D0", Offset = "0x1E09DD0", Length = "0xF9")]
	[Token(Token = "0x6000136")]
	public int ExitFrontPopup() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000145")]
	public PopupBase get_FrontPopup() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000144")]
	public Transform get_PopupRoot() { }

	[Address(RVA = "0x1E0AAD0", Offset = "0x1E09ED0", Length = "0x1D")]
	[Token(Token = "0x6000139")]
	public void Hidden(PopupBase popup) { }

	[Address(RVA = "0x1E0AAF0", Offset = "0x1E09EF0", Length = "0x1A7")]
	[Token(Token = "0x600013A")]
	public void Hidden(int tid) { }

	[Address(RVA = "0x1E0AD30", Offset = "0x1E0A130", Length = "0x96")]
	[Token(Token = "0x6000130")]
	public void Initialize(Transform p) { }

	[Address(RVA = "0x1E0ACA0", Offset = "0x1E0A0A0", Length = "0x89")]
	[Token(Token = "0x6000131")]
	public void Initialize() { }

	[Address(RVA = "0x1E0ADD0", Offset = "0x1E0A1D0", Length = "0x8E")]
	[Token(Token = "0x6000138")]
	public bool IsActiveForeground(int popupID) { }

	[Address(RVA = "0x1E0AF90", Offset = "0x1E0A390", Length = "0x56")]
	[Token(Token = "0x6000135")]
	public bool IsExists() { }

	[Address(RVA = "0x1E0AE60", Offset = "0x1E0A260", Length = "0x12F")]
	[Token(Token = "0x6000134")]
	public bool IsExistsPopup(int tid) { }

	[Address(RVA = "0x1E0AFF0", Offset = "0x1E0A3F0", Length = "0x7")]
	[Token(Token = "0x600013C")]
	private void LateUpdate() { }

	[Address(RVA = "0x1E0B000", Offset = "0x1E0A400", Length = "0x19C")]
	[Token(Token = "0x600013B")]
	public void Progress() { }

	[Address(RVA = "0x1E0B1A0", Offset = "0x1E0A5A0", Length = "0x303")]
	[Token(Token = "0x6000133")]
	public PopupBase ShowPopup(GameObject iObject, int iPriority) { }

	[Address(RVA = "0x1E0B4B0", Offset = "0x1E0A8B0", Length = "0x84")]
	[IteratorStateMachine(typeof(<WaitHiddenPopup>d__8))]
	[Token(Token = "0x6000137")]
	public IEnumerator WaitHiddenPopup(PopupBase popup) { }

}

