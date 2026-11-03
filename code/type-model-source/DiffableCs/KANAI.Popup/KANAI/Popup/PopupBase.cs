namespace KANAI.Popup;

[Token(Token = "0x2000016")]
public abstract class PopupBase : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <_StartAppear>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000088")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000089")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400008A")]
		public PopupBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700001E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000B3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000B5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000B0")]
		public <_StartAppear>d__7(int <>1__state) { }

		[Address(RVA = "0x1E0EC80", Offset = "0x1E0E080", Length = "0x120")]
		[Token(Token = "0x60000B2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000B3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000B5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0EDB0", Offset = "0x1E0E1B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000B4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000B1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000017")]
	private sealed class <AppearToActive>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400007D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400007E")]
		public PopupBase <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000018")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000019")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600009E")]
		public <AppearToActive>d__8(int <>1__state) { }

		[Address(RVA = "0x1E0D6D0", Offset = "0x1E0CAD0", Length = "0x54")]
		[Token(Token = "0x60000A0")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0D730", Offset = "0x1E0CB30", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600009F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000018")]
	private sealed class <CoroutineWaitFor>d__31 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000080")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000081")]
		public PopupBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000082")]
		public PopupState iState; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000083")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x30

		[Token(Token = "0x1700001A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000A9")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000A4")]
		public <CoroutineWaitFor>d__31(int <>1__state) { }

		[Address(RVA = "0x1E0E000", Offset = "0x1E0D400", Length = "0xF0")]
		[Token(Token = "0x60000A6")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000A9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0E100", Offset = "0x1E0D500", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000A5")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private sealed class <CoroutineWaitForClose>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000084")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000085")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000086")]
		public PopupBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000087")]
		private YieldInstruction <cacheWait>5__2; //Field offset: 0x28

		[Token(Token = "0x1700001C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000AD")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000AF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000AA")]
		public <CoroutineWaitForClose>d__30(int <>1__state) { }

		[Address(RVA = "0x1E0DED0", Offset = "0x1E0D2D0", Length = "0xEE")]
		[Token(Token = "0x60000AC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000AD")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000AF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0DFC0", Offset = "0x1E0D3C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000AE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000AB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CustomLabel("PopupStatus")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000065")]
	private PopupState _status; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000066")]
	private PopupAttribute <_attribute>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000067")]
	private int <popupID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000068")]
	private int <padID>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000069")]
	private bool <IsAutoDelete>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400006A")]
	private bool <IsCancelPopup>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400006B")]
	private bool <IsEnableCollide>k__BackingField; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[Token(Token = "0x400006C")]
	protected bool isEnableOutOfRangeTouch; //Field offset: 0x33
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400006D")]
	private Func<Int32, Boolean> <OnHiddenCallback>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400006E")]
	private Action<Int32> <OnTerminateCallback>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400006F")]
	private Func<Boolean> <DisappearCheck>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000070")]
	private int <SelectID>k__BackingField; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000071")]
	protected GameObject _windowInsideTop; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000072")]
	protected RectTransform _ContentTransform; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	protected UIImage BackgroundObject; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000074")]
	protected GameObject HeaderObject; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	protected GameObject FooterObject; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000076")]
	private PopupContentBase <Content>k__BackingField; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000077")]
	internal OutOfRangeTouch RangeTouchMode; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000078")]
	internal bool BackgroundAct; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000079")]
	private CanvasGroup _popupCanvas; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400007A")]
	private RectTransform _insideTransform; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400007B")]
	private GameObject _windowObject; //Field offset: 0xA0

	[Token(Token = "0x1700000A")]
	public private PopupAttribute _attribute
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000084")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000085")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public private PopupContentBase Content
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000099")]
		 get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x600009A")]
		private set { } //Length: 16
	}

	[Token(Token = "0x17000013")]
	public Func<Boolean> DisappearCheck
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000095")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000096")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000D")]
	public private bool IsAutoDelete
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600008A")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600008B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public private bool IsCancelPopup
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600008C")]
		 get { } //Length: 5
		[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600008D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public private bool IsEnableCollide
	{
		[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600008E")]
		 get { } //Length: 5
		[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600008F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public bool IsSkipDark
	{
		[Address(RVA = "0x1E075D0", Offset = "0x1E069D0", Length = "0x8")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	internal Func<Int32, Boolean> OnHiddenCallback
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000091")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000092")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000012")]
	internal Action<Int32> OnTerminateCallback
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000093")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000094")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700000C")]
	public private int padID
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000088")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000089")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	public CanvasGroup PopupCanvas
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x600009B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public private int popupID
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000086")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000087")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	public RectTransform PopupWindow
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000014")]
	public private int SelectID
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000097")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000098")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public PopupState Status
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1E07400", Offset = "0x1E06800", Length = "0x105")]
	[Token(Token = "0x6000082")]
	private UIImage _findPopupWindowImage(string targetName) { }

	[Address(RVA = "0x1E07510", Offset = "0x1E06910", Length = "0x9A")]
	[Token(Token = "0x6000079")]
	protected bool _isForeground() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000069")]
	protected override void _OnHidden(int tid) { }

	[Address(RVA = "0x1E059B0", Offset = "0x1E04DB0", Length = "0x67")]
	[IteratorStateMachine(typeof(<_StartAppear>d__7))]
	[Token(Token = "0x600005F")]
	protected override IEnumerator _StartAppear() { }

	[Token(Token = "0x6000068")]
	protected abstract void _Update() { }

	[Address(RVA = "0x1E073D0", Offset = "0x1E067D0", Length = "0x27")]
	[Token(Token = "0x600009D")]
	protected PopupBase() { }

	[Address(RVA = "0x1E06810", Offset = "0x1E05C10", Length = "0x36")]
	[Token(Token = "0x600005E")]
	public override void Appear() { }

	[Address(RVA = "0x1E05A20", Offset = "0x1E04E20", Length = "0x67")]
	[IteratorStateMachine(typeof(<AppearToActive>d__8))]
	[Token(Token = "0x6000060")]
	public override IEnumerator AppearToActive() { }

	[Address(RVA = "0x1E06850", Offset = "0x1E05C50", Length = "0x161")]
	[Token(Token = "0x6000081")]
	public override void ChangeWindowImage(string windowName, Sprite windowSprite) { }

	[Token(Token = "0x600006A")]
	public abstract void ClickDefaultBackkey() { }

	[Address(RVA = "0x1E06A30", Offset = "0x1E05E30", Length = "0x76")]
	[IteratorStateMachine(typeof(<CoroutineWaitFor>d__31))]
	[Token(Token = "0x6000077")]
	public IEnumerator CoroutineWaitFor(PopupState iState) { }

	[Address(RVA = "0x1E069C0", Offset = "0x1E05DC0", Length = "0x67")]
	[IteratorStateMachine(typeof(<CoroutineWaitForClose>d__30))]
	[Token(Token = "0x6000076")]
	public IEnumerator CoroutineWaitForClose() { }

	[Address(RVA = "0x1E04C10", Offset = "0x1E04010", Length = "0x92")]
	[Token(Token = "0x6000064")]
	public override void Disappear() { }

	[Address(RVA = "0x1E06AB0", Offset = "0x1E05EB0", Length = "0x9C")]
	[Token(Token = "0x6000066")]
	public override void EnableBackground(bool value) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000084")]
	public PopupAttribute get__attribute() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000099")]
	public PopupContentBase get_Content() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000095")]
	public Func<Boolean> get_DisappearCheck() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600008A")]
	public bool get_IsAutoDelete() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600008C")]
	public bool get_IsCancelPopup() { }

	[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600008E")]
	public bool get_IsEnableCollide() { }

	[Address(RVA = "0x1E075D0", Offset = "0x1E069D0", Length = "0x8")]
	[Token(Token = "0x6000090")]
	public bool get_IsSkipDark() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000091")]
	internal Func<Int32, Boolean> get_OnHiddenCallback() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000093")]
	internal Action<Int32> get_OnTerminateCallback() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000088")]
	public int get_padID() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x600009B")]
	public CanvasGroup get_PopupCanvas() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000086")]
	public int get_popupID() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600009C")]
	public RectTransform get_PopupWindow() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000097")]
	public int get_SelectID() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000083")]
	public PopupState get_Status() { }

	[Address(RVA = "0x1E06B50", Offset = "0x1E05F50", Length = "0xF7")]
	[Token(Token = "0x6000073")]
	public override PopupButton GetButton(string bpath) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000070")]
	public override int GetButtonCount() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000072")]
	public int GetPadNo() { }

	[Address(RVA = "0x1E06C50", Offset = "0x1E06050", Length = "0x23")]
	[Token(Token = "0x600005A")]
	public int GetSiblingIndex() { }

	[Address(RVA = "0x1E06C80", Offset = "0x1E06080", Length = "0xA7")]
	[Token(Token = "0x600005B")]
	public void Hidden(int tid = -1) { }

	[Address(RVA = "0x1E06D30", Offset = "0x1E06130", Length = "0x8")]
	[Token(Token = "0x600005D")]
	public override void Initialize() { }

	[Address(RVA = "0x1E06D40", Offset = "0x1E06140", Length = "0x8")]
	[Token(Token = "0x600007A")]
	public bool IsActive() { }

	[Address(RVA = "0x1E06D80", Offset = "0x1E06180", Length = "0x8")]
	[Token(Token = "0x600007B")]
	public override bool IsDisappeared() { }

	[Address(RVA = "0x1E06D50", Offset = "0x1E06150", Length = "0x2B")]
	[Token(Token = "0x6000065")]
	public override bool IsDisappearOK() { }

	[Address(RVA = "0x1E06D90", Offset = "0x1E06190", Length = "0x8")]
	[Token(Token = "0x600007C")]
	public bool IsTerminated() { }

	[Address(RVA = "0x1E06DA0", Offset = "0x1E061A0", Length = "0x14")]
	[Token(Token = "0x6000067")]
	public override void OverlapBackground(bool isOverlapEnd) { }

	[Address(RVA = "0xE37F60", Offset = "0xE37360", Length = "0x14")]
	[Token(Token = "0x6000058")]
	public void PopupUpdate() { }

	[Address(RVA = "0x1E06DC0", Offset = "0x1E061C0", Length = "0x82")]
	[Token(Token = "0x6000062")]
	public override void ReActive() { }

	[Address(RVA = "0x1E06E50", Offset = "0x1E06250", Length = "0x25F")]
	[Token(Token = "0x600006D")]
	public override void Refresh() { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000085")]
	private void set__attribute(PopupAttribute value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x600009A")]
	private void set_Content(PopupContentBase value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000096")]
	public void set_DisappearCheck(Func<Boolean> value) { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600008B")]
	private void set_IsAutoDelete(bool value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600008D")]
	private void set_IsCancelPopup(bool value) { }

	[Address(RVA = "0x1E075F0", Offset = "0x1E069F0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600008F")]
	private void set_IsEnableCollide(bool value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000092")]
	internal void set_OnHiddenCallback(Func<Int32, Boolean> value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000094")]
	internal void set_OnTerminateCallback(Action<Int32> value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000089")]
	private void set_padID(int value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000087")]
	private void set_popupID(int value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000098")]
	private void set_SelectID(int value) { }

	[Address(RVA = "0x1E070B0", Offset = "0x1E064B0", Length = "0x4")]
	[Token(Token = "0x600007D")]
	public void SetAttribute(PopupAttribute a) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000080")]
	public void SetBaseWindow(GameObject windowObject) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006F")]
	public override void SetButtonEnable(int iIndex, bool isEnable) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006E")]
	public override void SetButtonInfo(List<PopupButtonInfo> lists) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600007E")]
	public void SetCallbackOnClose(Func<Int32, Boolean> tcallback) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600007F")]
	public void SetCallbackOnTerminate(Action<Int32> tcallback) { }

	[Address(RVA = "0x1E070C0", Offset = "0x1E064C0", Length = "0x6B")]
	[Token(Token = "0x600006B")]
	public override void SetContent(PopupContentBase iCon) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000075")]
	public override void SetDisplayOffset(Vector2 toffset, bool forceFlg = false) { }

	[Address(RVA = "0x1E07130", Offset = "0x1E06530", Length = "0x8C")]
	[Token(Token = "0x600005C")]
	public void SetEnableWindowCollide(bool value) { }

	[Address(RVA = "0x1E071C0", Offset = "0x1E065C0", Length = "0x10C")]
	[Token(Token = "0x6000059")]
	public void SetID(int tid) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x6000071")]
	public void SetPadNo(int npad = 2) { }

	[Address(RVA = "0x1E072D0", Offset = "0x1E066D0", Length = "0x8E")]
	[Token(Token = "0x6000074")]
	public override void SetSize(Vector2 tsize) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600006C")]
	public override void SetTitle(string value) { }

	[Address(RVA = "0x1E07360", Offset = "0x1E06760", Length = "0xE")]
	[Token(Token = "0x6000061")]
	public void SkipActive() { }

	[Address(RVA = "0x1E07370", Offset = "0x1E06770", Length = "0x8")]
	[Token(Token = "0x6000063")]
	public override void StartDisappear() { }

	[Address(RVA = "0x1E07380", Offset = "0x1E06780", Length = "0x42")]
	[Token(Token = "0x6000078")]
	public override void Terminate() { }

}

