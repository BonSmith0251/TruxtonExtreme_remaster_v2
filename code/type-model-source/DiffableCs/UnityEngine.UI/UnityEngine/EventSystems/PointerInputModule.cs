namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BF")]
public abstract class PointerInputModule : BaseInputModule
{
	[Token(Token = "0x20000C0")]
	internal class ButtonState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000349")]
		private InputButton m_Button; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034A")]
		private MouseButtonEventData m_EventData; //Field offset: 0x18

		[Token(Token = "0x170001F2")]
		public InputButton button
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600073D")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[Token(Token = "0x600073E")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170001F1")]
		public MouseButtonEventData eventData
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600073B")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x600073C")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600073F")]
		public ButtonState() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600073D")]
		public InputButton get_button() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600073B")]
		public MouseButtonEventData get_eventData() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x600073E")]
		public void set_button(InputButton value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600073C")]
		public void set_eventData(MouseButtonEventData value) { }

	}

	[Token(Token = "0x20000C2")]
	internal class MouseButtonEventData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034C")]
		public FramePressState buttonState; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034D")]
		public PointerEventData buttonData; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000747")]
		public MouseButtonEventData() { }

		[Address(RVA = "0x3467120", Offset = "0x3466520", Length = "0x11")]
		[Token(Token = "0x6000745")]
		public bool PressedThisFrame() { }

		[Address(RVA = "0x3467140", Offset = "0x3466540", Length = "0x11")]
		[Token(Token = "0x6000746")]
		public bool ReleasedThisFrame() { }

	}

	[Token(Token = "0x20000C1")]
	internal class MouseState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034B")]
		private List<ButtonState> m_TrackedButtons; //Field offset: 0x10

		[Address(RVA = "0x34674F0", Offset = "0x34668F0", Length = "0x77")]
		[Token(Token = "0x6000744")]
		public MouseState() { }

		[Address(RVA = "0x3467160", Offset = "0x3466560", Length = "0xB0")]
		[Token(Token = "0x6000740")]
		public bool AnyPressesThisFrame() { }

		[Address(RVA = "0x3467220", Offset = "0x3466620", Length = "0xB0")]
		[Token(Token = "0x6000741")]
		public bool AnyReleasesThisFrame() { }

		[Address(RVA = "0x34672E0", Offset = "0x34666E0", Length = "0x1A9")]
		[Token(Token = "0x6000742")]
		public ButtonState GetButtonState(InputButton button) { }

		[Address(RVA = "0x3467490", Offset = "0x3466890", Length = "0x51")]
		[Token(Token = "0x6000743")]
		public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	}

	[Token(Token = "0x4000343")]
	public const int kMouseLeftId = -1; //Field offset: 0x0
	[Token(Token = "0x4000344")]
	public const int kMouseRightId = -2; //Field offset: 0x0
	[Token(Token = "0x4000345")]
	public const int kMouseMiddleId = -3; //Field offset: 0x0
	[Token(Token = "0x4000346")]
	public const int kFakeTouchesId = -4; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000347")]
	protected Dictionary<Int32, PointerEventData> m_PointerData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000348")]
	private readonly MouseState m_MouseState; //Field offset: 0x60

	[Address(RVA = "0x346F480", Offset = "0x346E880", Length = "0x166")]
	[Token(Token = "0x600073A")]
	protected PointerInputModule() { }

	[Address(RVA = "0x346DB30", Offset = "0x346CF30", Length = "0x1AC")]
	[Token(Token = "0x6000737")]
	protected void ClearSelection() { }

	[Address(RVA = "0x346DCE0", Offset = "0x346D0E0", Length = "0x181")]
	[Token(Token = "0x600072E")]
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	[Address(RVA = "0x346DE70", Offset = "0x346D270", Length = "0xDC")]
	[Token(Token = "0x6000739")]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	[Address(RVA = "0x346DF50", Offset = "0x346D350", Length = "0x27")]
	[Token(Token = "0x6000732")]
	protected PointerEventData GetLastPointerEventData(int id) { }

	[Address(RVA = "0x346DF80", Offset = "0x346D380", Length = "0x16")]
	[Token(Token = "0x6000730")]
	protected override MouseState GetMousePointerEventData() { }

	[Address(RVA = "0x346DFA0", Offset = "0x346D3A0", Length = "0x7A5")]
	[Token(Token = "0x6000731")]
	protected override MouseState GetMousePointerEventData(int id) { }

	[Address(RVA = "0x346E750", Offset = "0x346DB50", Length = "0xFC")]
	[Token(Token = "0x600072B")]
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	[Address(RVA = "0x346E850", Offset = "0x346DC50", Length = "0x47D")]
	[Token(Token = "0x600072D")]
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	[Address(RVA = "0x346ECD0", Offset = "0x346E0D0", Length = "0x8E")]
	[Token(Token = "0x6000736")]
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	[Address(RVA = "0x346ED60", Offset = "0x346E160", Length = "0x2BF")]
	[Token(Token = "0x6000735")]
	protected override void ProcessDrag(PointerEventData pointerEvent) { }

	[Address(RVA = "0x346F020", Offset = "0x346E420", Length = "0x50")]
	[Token(Token = "0x6000734")]
	protected override void ProcessMove(PointerEventData pointerEvent) { }

	[Address(RVA = "0x346F080", Offset = "0x346E480", Length = "0x5B")]
	[Token(Token = "0x600072C")]
	protected void RemovePointerData(PointerEventData data) { }

	[Address(RVA = "0x346F0E0", Offset = "0x346E4E0", Length = "0x4B")]
	[Token(Token = "0x6000733")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	[Address(RVA = "0x346F130", Offset = "0x346E530", Length = "0xBE")]
	[Token(Token = "0x600072F")]
	protected FramePressState StateForMouseButton(int buttonId) { }

	[Address(RVA = "0x346F1F0", Offset = "0x346E5F0", Length = "0x28D")]
	[Token(Token = "0x6000738")]
	public virtual string ToString() { }

}

