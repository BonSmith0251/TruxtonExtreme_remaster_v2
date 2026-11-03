namespace KANAI.Popup;

[Token(Token = "0x2000012")]
public class MessagePopupContent : PopupContentBase
{
	[CompilerGenerated]
	[Token(Token = "0x2000013")]
	private sealed class <AppearanceDelay>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000054")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000055")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000056")]
		public MessagePopupContent <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000007")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000055")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000057")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000052")]
		public <AppearanceDelay>d__2(int <>1__state) { }

		[Address(RVA = "0x1E0DC90", Offset = "0x1E0D090", Length = "0xCB")]
		[Token(Token = "0x6000054")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000055")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000057")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E0DD60", Offset = "0x1E0D160", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000056")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000053")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private ScrollRect _scrollRect; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x400004C")]
	private UITextMeshPro _Text; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private Scrollbar _scrollBar; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private HorizontalLayoutGroup _hlayoutGroup; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private UILayoutSizeSender _layoutSender; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000050")]
	private Vector2 _contentSize; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000051")]
	private float _scrollStep; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000052")]
	private float _remainTime; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000053")]
	private bool _isAppearanceReady; //Field offset: 0x98

	[Address(RVA = "0x1E06560", Offset = "0x1E05960", Length = "0x1AF")]
	[Token(Token = "0x600004F")]
	private void _CheckAndUpdateContentRightPadding() { }

	[Address(RVA = "0x1E06710", Offset = "0x1E05B10", Length = "0x8B")]
	[Token(Token = "0x6000050")]
	private void _SetTextMinHeight(float baseSize) { }

	[Address(RVA = "0x1E067A0", Offset = "0x1E05BA0", Length = "0x65")]
	[Token(Token = "0x6000051")]
	public MessagePopupContent() { }

	[Address(RVA = "0x1E05E80", Offset = "0x1E05280", Length = "0x67")]
	[IteratorStateMachine(typeof(<AppearanceDelay>d__2))]
	[Token(Token = "0x6000047")]
	public virtual IEnumerator AppearanceDelay() { }

	[Address(RVA = "0x1E05EF0", Offset = "0x1E052F0", Length = "0x82")]
	[Token(Token = "0x600004C")]
	public void ClearFontAtlas() { }

	[Address(RVA = "0x1E05F80", Offset = "0x1E05380", Length = "0x1E2")]
	[Token(Token = "0x600004D")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0x1E06170", Offset = "0x1E05570", Length = "0x218")]
	[Token(Token = "0x6000045")]
	public virtual void Initialize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000048")]
	public virtual bool IsFooter() { }

	[Address(RVA = "0x1E06390", Offset = "0x1E05790", Length = "0x8")]
	[Token(Token = "0x6000049")]
	public virtual void OnClickButton(int iButtonID) { }

	[Address(RVA = "0x1E063A0", Offset = "0x1E057A0", Length = "0x82")]
	[Token(Token = "0x600004A")]
	public void SetTextAlign(TextAlignmentOptions value) { }

	[Address(RVA = "0x1E06430", Offset = "0x1E05830", Length = "0x99")]
	[Token(Token = "0x600004B")]
	public void SetTextColor(Color value) { }

	[Address(RVA = "0x1E064D0", Offset = "0x1E058D0", Length = "0x9")]
	[Token(Token = "0x600004E")]
	public void SetTimer(float tsec) { }

	[Address(RVA = "0x1E064E0", Offset = "0x1E058E0", Length = "0x79")]
	[Token(Token = "0x6000046")]
	public virtual void Terminate() { }

}

