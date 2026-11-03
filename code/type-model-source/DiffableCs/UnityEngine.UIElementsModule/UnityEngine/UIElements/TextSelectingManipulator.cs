namespace UnityEngine.UIElements;

[Token(Token = "0x20004B1")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TextSelectingManipulator
{
	[Token(Token = "0x4000FEF")]
	private const int k_DragThresholdSqr = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FE9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TextSelectingUtilities m_SelectingUtilities; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEA")]
	private bool selectAllOnMouseUp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FEB")]
	private TextElement m_TextElement; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FEC")]
	private Vector2 m_ClickStartPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FED")]
	private bool m_Dragged; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000FEE")]
	private bool m_IsClicking; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000FF0")]
	private int m_ConsecutiveMouseDownCount; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FF1")]
	private long m_LastMouseDownTimeStamp; //Field offset: 0x38

	[Token(Token = "0x17000981")]
	internal int cursorIndex
	{
		[Address(RVA = "0x32AE280", Offset = "0x32AD680", Length = "0x16")]
		[Token(Token = "0x60023AA")]
		internal get { } //Length: 22
		[Address(RVA = "0x32AE2C0", Offset = "0x32AD6C0", Length = "0x1E")]
		[Token(Token = "0x60023AB")]
		internal set { } //Length: 30
	}

	[Token(Token = "0x17000980")]
	internal bool isClicking
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x60023A7")]
		internal get { } //Length: 5
		[Address(RVA = "0x32AE2E0", Offset = "0x32AD6E0", Length = "0x9")]
		[Token(Token = "0x60023A8")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000982")]
	internal int selectIndex
	{
		[Address(RVA = "0x32AE2A0", Offset = "0x32AD6A0", Length = "0x16")]
		[Token(Token = "0x60023AC")]
		internal get { } //Length: 22
		[Address(RVA = "0x32AE2F0", Offset = "0x32AD6F0", Length = "0x1E")]
		[Token(Token = "0x60023AD")]
		internal set { } //Length: 30
	}

	[Address(RVA = "0x32ADFA0", Offset = "0x32AD3A0", Length = "0x2D0")]
	[Token(Token = "0x60023A9")]
	public TextSelectingManipulator(TextElement textElement) { }

	[Address(RVA = "0x32AE280", Offset = "0x32AD680", Length = "0x16")]
	[Token(Token = "0x60023AA")]
	internal int get_cursorIndex() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x60023A7")]
	internal bool get_isClicking() { }

	[Address(RVA = "0x32AE2A0", Offset = "0x32AD6A0", Length = "0x16")]
	[Token(Token = "0x60023AC")]
	internal int get_selectIndex() { }

	[Address(RVA = "0x32ACC00", Offset = "0x32AC000", Length = "0x6DF")]
	[Token(Token = "0x60023B4")]
	internal void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x32AD2E0", Offset = "0x32AC6E0", Length = "0x1D")]
	[Token(Token = "0x60023B3")]
	internal bool HasFocus() { }

	[Address(RVA = "0x32AD300", Offset = "0x32AC700", Length = "0x1D")]
	[Token(Token = "0x60023B2")]
	internal bool HasSelection() { }

	[Address(RVA = "0x32AD320", Offset = "0x32AC720", Length = "0x3F")]
	[Token(Token = "0x60023BD")]
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

	[Address(RVA = "0x32AD360", Offset = "0x32AC760", Length = "0x4D")]
	[Token(Token = "0x60023B6")]
	private void OnBlurEvent() { }

	[Address(RVA = "0x32AD3B0", Offset = "0x32AC7B0", Length = "0xFB")]
	[Token(Token = "0x60023B0")]
	private void OnCursorIndexChange() { }

	[Address(RVA = "0x32AD4B0", Offset = "0x32AC8B0", Length = "0x10B")]
	[Token(Token = "0x60023BC")]
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	[Address(RVA = "0x32AD5C0", Offset = "0x32AC9C0", Length = "0x9A")]
	[Token(Token = "0x60023B5")]
	private void OnFocusEvent() { }

	[Address(RVA = "0x32AD660", Offset = "0x32ACA60", Length = "0x87")]
	[Token(Token = "0x60023B7")]
	private void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x32AD6F0", Offset = "0x32ACAF0", Length = "0x37F")]
	[Token(Token = "0x60023B8")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x32ADA70", Offset = "0x32ACE70", Length = "0x1A4")]
	[Token(Token = "0x60023B9")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x32ADC20", Offset = "0x32AD020", Length = "0xA0")]
	[Token(Token = "0x60023BA")]
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	[Address(RVA = "0x32ADCD0", Offset = "0x32AD0D0", Length = "0x23")]
	[Token(Token = "0x60023AE")]
	private void OnRevealCursor() { }

	[Address(RVA = "0x32ADD00", Offset = "0x32AD100", Length = "0xFB")]
	[Token(Token = "0x60023AF")]
	private void OnSelectIndexChange() { }

	[Address(RVA = "0x32ADE00", Offset = "0x32AD200", Length = "0x172")]
	[Token(Token = "0x60023BB")]
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	[Address(RVA = "0x32ADF80", Offset = "0x32AD380", Length = "0x1B")]
	[Token(Token = "0x60023B1")]
	internal bool RevealCursor() { }

	[Address(RVA = "0x32AE2C0", Offset = "0x32AD6C0", Length = "0x1E")]
	[Token(Token = "0x60023AB")]
	internal void set_cursorIndex(int value) { }

	[Address(RVA = "0x32AE2E0", Offset = "0x32AD6E0", Length = "0x9")]
	[Token(Token = "0x60023A8")]
	private void set_isClicking(bool value) { }

	[Address(RVA = "0x32AE2F0", Offset = "0x32AD6F0", Length = "0x1E")]
	[Token(Token = "0x60023AD")]
	internal void set_selectIndex(int value) { }

}

