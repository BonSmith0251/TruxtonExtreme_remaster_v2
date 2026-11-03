namespace KANAI.Popup;

[Token(Token = "0x2000020")]
public class PopupContentBase : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <AppearanceDelay>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B3")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000028")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000EF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000029")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000EC")]
		public <AppearanceDelay>d__8(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x60000EE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000EF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0DE90", Offset = "0x1E0D290", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000F0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000ED")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <TerminateDelay>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B5")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x1700002A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000F2")]
		public <TerminateDelay>d__13(int <>1__state) { }

		[Address(RVA = "0x1B7BED0", Offset = "0x1B7B2D0", Length = "0x10")]
		[Token(Token = "0x60000F4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0E400", Offset = "0x1E0D800", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000F6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000F3")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A7")]
	public bool IsEnableBackkey; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	[Token(Token = "0x40000A8")]
	protected bool _useInspectorParam; //Field offset: 0x21
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40000A9")]
	private Vector2 _popupSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40000AA")]
	private Vector2 _displayOffset; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000AB")]
	private bool <isInitialized>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AC")]
	private int <ClickButtonID>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000AD")]
	private Vector2 <WindowSize>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000AE")]
	private float <_headerSize>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AF")]
	private float <_footerSize>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B0")]
	protected PopupBase PopupBaseWindow; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B1")]
	protected CommonPopupParam Param; //Field offset: 0x58

	[Token(Token = "0x17000027")]
	public float _footerSize
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000E2")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000026")]
	public float _headerSize
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 6
		[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60000E0")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000024")]
	public private int ClickButtonID
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000DB")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public Vector2 DisplayOffset
	{
		[Address(RVA = "0x1E08DC0", Offset = "0x1E081C0", Length = "0x13")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000023")]
	public private bool isInitialized
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000D9")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000DA")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public Vector2 PopupSize
	{
		[Address(RVA = "0x1E08DE0", Offset = "0x1E081E0", Length = "0x13")]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000020")]
	public bool UseInspectorParam
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000025")]
	public Vector2 WindowSize
	{
		[Address(RVA = "0x1E08E10", Offset = "0x1E08210", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 19
		[Address(RVA = "0x1E08FE0", Offset = "0x1E083E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x1E08CB0", Offset = "0x1E080B0", Length = "0x104")]
	[Token(Token = "0x60000E7")]
	protected void _updateContentSize(Vector2 value) { }

	[Address(RVA = "0x1E08C90", Offset = "0x1E08090", Length = "0x15")]
	[Token(Token = "0x60000EB")]
	public PopupContentBase() { }

	[Address(RVA = "0x1E03B80", Offset = "0x1E02F80", Length = "0x4B")]
	[IteratorStateMachine(typeof(<AppearanceDelay>d__8))]
	[Token(Token = "0x60000C8")]
	public override IEnumerator AppearanceDelay() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000CC")]
	public override void ContentUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C9")]
	public override void CreatedWindow() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000E1")]
	public float get__footerSize() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000DF")]
	public float get__headerSize() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000DB")]
	public int get_ClickButtonID() { }

	[Address(RVA = "0x1E08DC0", Offset = "0x1E081C0", Length = "0x13")]
	[Token(Token = "0x60000D8")]
	public Vector2 get_DisplayOffset() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000D9")]
	public bool get_isInitialized() { }

	[Address(RVA = "0x1E08DE0", Offset = "0x1E081E0", Length = "0x13")]
	[Token(Token = "0x60000D7")]
	public Vector2 get_PopupSize() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x60000D6")]
	public bool get_UseInspectorParam() { }

	[Address(RVA = "0x1E08E10", Offset = "0x1E08210", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	public Vector2 get_WindowSize() { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x60000D5")]
	public float GetFooterSize() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x60000D4")]
	public float GetHeaderSize() { }

	[Address(RVA = "0x1E08950", Offset = "0x1E07D50", Length = "0x7F")]
	[Token(Token = "0x60000C4")]
	public int GetPadNo() { }

	[Address(RVA = "0x1E089D0", Offset = "0x1E07DD0", Length = "0xB1")]
	[Token(Token = "0x60000C1")]
	public void Hidden(int iID) { }

	[Address(RVA = "0x1E08A90", Offset = "0x1E07E90", Length = "0x5")]
	[Token(Token = "0x60000C5")]
	public override void Initialize() { }

	[Address(RVA = "0x1E08AA0", Offset = "0x1E07EA0", Length = "0x28")]
	[Token(Token = "0x60000D2")]
	public bool IsEnableOnClickBackkey() { }

	[Address(RVA = "0x1E08AD0", Offset = "0x1E07ED0", Length = "0x1E")]
	[Token(Token = "0x60000E3")]
	public override bool IsFooter() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000D3")]
	public override bool IsReadyToActive() { }

	[Address(RVA = "0x1E08F10", Offset = "0x1E08310", Length = "0xB1")]
	[Token(Token = "0x60000E6")]
	protected bool isStrech(RectTransform rtf) { }

	[Address(RVA = "0x1E08E30", Offset = "0x1E08230", Length = "0x62")]
	[Token(Token = "0x60000E4")]
	protected bool isStrechX(RectTransform rtf) { }

	[Address(RVA = "0x1E08EA0", Offset = "0x1E082A0", Length = "0x62")]
	[Token(Token = "0x60000E5")]
	protected bool isStrechY(RectTransform rtf) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000D0")]
	public override bool OnClickBackKey() { }

	[Address(RVA = "0x1E08AF0", Offset = "0x1E07EF0", Length = "0xD8")]
	[Token(Token = "0x60000CF")]
	public override void OnClickButton(int index) { }

	[Address(RVA = "0x1E08BD0", Offset = "0x1E07FD0", Length = "0x3E")]
	[Token(Token = "0x60000D1")]
	public override void OnClickOutOfRange() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000CB")]
	public override void ReActive() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C6")]
	public override void ReShow() { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000E2")]
	protected void set__footerSize(float value) { }

	[Address(RVA = "0x1E08FF0", Offset = "0x1E083F0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x60000E0")]
	protected void set__headerSize(float value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	private void set_ClickButtonID(int value) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000DA")]
	private void set_isInitialized(bool value) { }

	[Address(RVA = "0x1E08FE0", Offset = "0x1E083E0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	protected void set_WindowSize(Vector2 value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60000C3")]
	public void SetBaseWindow(PopupBase t) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60000C2")]
	public void SetParam(CommonPopupParam t) { }

	[Address(RVA = "0x1E08C10", Offset = "0x1E08010", Length = "0x2B")]
	[Token(Token = "0x60000C0")]
	public void ShowContent() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000CA")]
	public override void StartActive() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C7")]
	public override void StartAppear() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000CE")]
	public override void Terminate() { }

	[Address(RVA = "0x1E08C40", Offset = "0x1E08040", Length = "0x4B")]
	[IteratorStateMachine(typeof(<TerminateDelay>d__13))]
	[Token(Token = "0x60000CD")]
	public override IEnumerator TerminateDelay() { }

	[Address(RVA = "0x1E092D0", Offset = "0x1E086D0", Length = "0x3A")]
	[Token(Token = "0x60000EA")]
	protected override Vector2 updateContentSize(PopupFooter f, PopupHeader h) { }

	[Address(RVA = "0x1E09000", Offset = "0x1E08400", Length = "0x1B9")]
	[Token(Token = "0x60000E8")]
	protected override Vector2 updateContentSize(Vector2 s, PopupFooter f, PopupHeader h) { }

	[Address(RVA = "0x1E091C0", Offset = "0x1E085C0", Length = "0x10B")]
	[Token(Token = "0x60000E9")]
	protected override Vector2 updateContentSize(PopupSizeType value, PopupFooter f, PopupHeader h) { }

}

