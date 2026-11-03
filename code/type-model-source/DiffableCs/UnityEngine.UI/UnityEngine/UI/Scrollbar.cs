namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000060")]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000064")]
	private sealed class <ClickRepeat>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D6")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D7")]
		public Scrollbar <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001D8")]
		public Vector2 screenPosition; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001D9")]
		public Camera camera; //Field offset: 0x30

		[Token(Token = "0x170000F6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003CA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000F7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60003CC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60003C7")]
		public <ClickRepeat>d__59(int <>1__state) { }

		[Address(RVA = "0x345F3A0", Offset = "0x345E7A0", Length = "0x161")]
		[Token(Token = "0x60003C9")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003CA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60003CC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x345F510", Offset = "0x345E910", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60003CB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60003C8")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000063")]
	private enum Axis : int
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x2000061")]
	internal enum Direction : int
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	[Token(Token = "0x2000062")]
	internal class ScrollEvent : UnityEvent<Single>
	{

		[Address(RVA = "0x344F3E0", Offset = "0x344E7E0", Length = "0x39")]
		[Token(Token = "0x60003C6")]
		public ScrollEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001C1")]
	private RectTransform m_HandleRect; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001C2")]
	private Direction m_Direction; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40001C3")]
	private float m_Value; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40001C4")]
	private float m_Size; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Range(0, 11)]
	[SerializeField]
	[Token(Token = "0x40001C5")]
	private int m_NumberOfSteps; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Space(6)]
	[Token(Token = "0x40001C6")]
	private ScrollEvent m_OnValueChanged; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40001C7")]
	private RectTransform m_ContainerRect; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001C8")]
	private Vector2 m_Offset; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40001C9")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001CA")]
	private Coroutine m_PointerDownRepeat; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001CB")]
	private bool isPointerDownAndNotDragging; //Field offset: 0x140
	[FieldOffset(Offset = "0x141")]
	[Token(Token = "0x40001CC")]
	private bool m_DelayedUpdateVisuals; //Field offset: 0x141

	[Token(Token = "0x170000F4")]
	private Axis axis
	{
		[Address(RVA = "0x3455D60", Offset = "0x3455160", Length = "0x15")]
		[Token(Token = "0x60003B1")]
		private get { } //Length: 21
	}

	[Token(Token = "0x170000EE")]
	public Direction direction
	{
		[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
		[Token(Token = "0x600039B")]
		 get { } //Length: 7
		[Address(RVA = "0x3455E30", Offset = "0x3455230", Length = "0x59")]
		[Token(Token = "0x600039C")]
		 set { } //Length: 89
	}

	[Token(Token = "0x170000ED")]
	public RectTransform handleRect
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x6000399")]
		 get { } //Length: 8
		[Address(RVA = "0x3455E90", Offset = "0x3455290", Length = "0x65")]
		[Token(Token = "0x600039A")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170000F1")]
	public int numberOfSteps
	{
		[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
		[Token(Token = "0x60003A3")]
		 get { } //Length: 7
		[Address(RVA = "0x3455F00", Offset = "0x3455300", Length = "0x6F")]
		[Token(Token = "0x60003A4")]
		 set { } //Length: 111
	}

	[Token(Token = "0x170000F2")]
	public ScrollEvent onValueChanged
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x60003A5")]
		 get { } //Length: 8
		[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
		[Token(Token = "0x60003A6")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170000F5")]
	private bool reverseValue
	{
		[Address(RVA = "0x3455D80", Offset = "0x3455180", Length = "0x17")]
		[Token(Token = "0x60003B2")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170000F0")]
	public float size
	{
		[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
		[Token(Token = "0x60003A1")]
		 get { } //Length: 9
		[Address(RVA = "0x3455F70", Offset = "0x3455370", Length = "0x79")]
		[Token(Token = "0x60003A2")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170000F3")]
	private float stepSize
	{
		[Address(RVA = "0x3455DA0", Offset = "0x34551A0", Length = "0x2E")]
		[Token(Token = "0x60003A7")]
		private get { } //Length: 46
	}

	[Token(Token = "0x170000EF")]
	public float value
	{
		[Address(RVA = "0x3455DD0", Offset = "0x34551D0", Length = "0x54")]
		[Token(Token = "0x600039E")]
		 get { } //Length: 84
		[Address(RVA = "0x3455FF0", Offset = "0x34553F0", Length = "0xB")]
		[Token(Token = "0x600039F")]
		 set { } //Length: 11
	}

	[Address(RVA = "0x3455C60", Offset = "0x3455060", Length = "0xF7")]
	[Token(Token = "0x600039D")]
	protected Scrollbar() { }

	[Address(RVA = "0x3454290", Offset = "0x3453690", Length = "0x72")]
	[Token(Token = "0x60003BB")]
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[Address(RVA = "0x34541F0", Offset = "0x34535F0", Length = "0x9F")]
	[IteratorStateMachine(typeof(<ClickRepeat>d__59))]
	[Token(Token = "0x60003BC")]
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	[Address(RVA = "0x3454310", Offset = "0x3453710", Length = "0xB6")]
	[Token(Token = "0x60003B6")]
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	[Address(RVA = "0x34543D0", Offset = "0x34537D0", Length = "0x2E")]
	[Token(Token = "0x60003C2")]
	public virtual Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x3454400", Offset = "0x3453800", Length = "0x2E")]
	[Token(Token = "0x60003BF")]
	public virtual Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x3454430", Offset = "0x3453830", Length = "0x2E")]
	[Token(Token = "0x60003C0")]
	public virtual Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x3454460", Offset = "0x3453860", Length = "0x2E")]
	[Token(Token = "0x60003C1")]
	public virtual Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x3455D60", Offset = "0x3455160", Length = "0x15")]
	[Token(Token = "0x60003B1")]
	private Axis get_axis() { }

	[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
	[Token(Token = "0x600039B")]
	public Direction get_direction() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x6000399")]
	public RectTransform get_handleRect() { }

	[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
	[Token(Token = "0x60003A3")]
	public int get_numberOfSteps() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x60003A5")]
	public ScrollEvent get_onValueChanged() { }

	[Address(RVA = "0x3455D80", Offset = "0x3455180", Length = "0x17")]
	[Token(Token = "0x60003B2")]
	private bool get_reverseValue() { }

	[Address(RVA = "0x2D25F10", Offset = "0x2D25310", Length = "0x9")]
	[Token(Token = "0x60003A1")]
	public float get_size() { }

	[Address(RVA = "0x3455DA0", Offset = "0x34551A0", Length = "0x2E")]
	[Token(Token = "0x60003A7")]
	private float get_stepSize() { }

	[Address(RVA = "0x3455DD0", Offset = "0x34551D0", Length = "0x54")]
	[Token(Token = "0x600039E")]
	public float get_value() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003AA")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003A9")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x3454490", Offset = "0x3453890", Length = "0x6D")]
	[Token(Token = "0x60003B7")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3454500", Offset = "0x3453900", Length = "0x2CA")]
	[Token(Token = "0x60003B8")]
	public override void OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34547D0", Offset = "0x3453BD0", Length = "0x26")]
	[Token(Token = "0x60003AC")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3454800", Offset = "0x3453C00", Length = "0x193")]
	[Token(Token = "0x60003B9")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34549A0", Offset = "0x3453DA0", Length = "0xC5")]
	[Token(Token = "0x60003AB")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3454A70", Offset = "0x3453E70", Length = "0x1A")]
	[Token(Token = "0x60003C3")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3454A90", Offset = "0x3453E90", Length = "0x4EF")]
	[Token(Token = "0x60003BE")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x3454F80", Offset = "0x3454380", Length = "0x102")]
	[Token(Token = "0x60003BA")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x3455090", Offset = "0x3454490", Length = "0x37")]
	[Token(Token = "0x60003BD")]
	public virtual void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x34550D0", Offset = "0x34544D0", Length = "0x3F")]
	[Token(Token = "0x60003B0")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003A8")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x3455390", Offset = "0x3454790", Length = "0x129")]
	[Token(Token = "0x60003AF")]
	private void Set(float input, bool sendCallback = true) { }

	[Address(RVA = "0x3455E30", Offset = "0x3455230", Length = "0x59")]
	[Token(Token = "0x600039C")]
	public void set_direction(Direction value) { }

	[Address(RVA = "0x3455E90", Offset = "0x3455290", Length = "0x65")]
	[Token(Token = "0x600039A")]
	public void set_handleRect(RectTransform value) { }

	[Address(RVA = "0x3455F00", Offset = "0x3455300", Length = "0x6F")]
	[Token(Token = "0x60003A4")]
	public void set_numberOfSteps(int value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[Token(Token = "0x60003A6")]
	public void set_onValueChanged(ScrollEvent value) { }

	[Address(RVA = "0x3455F70", Offset = "0x3455370", Length = "0x79")]
	[Token(Token = "0x60003A2")]
	public void set_size(float value) { }

	[Address(RVA = "0x3455FF0", Offset = "0x34553F0", Length = "0xB")]
	[Token(Token = "0x600039F")]
	public void set_value(float value) { }

	[Address(RVA = "0x3455110", Offset = "0x3454510", Length = "0x1C6")]
	[Token(Token = "0x60003C4")]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[Address(RVA = "0x34552E0", Offset = "0x34546E0", Length = "0xA6")]
	[Token(Token = "0x60003A0")]
	public override void SetValueWithoutNotify(float input) { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x60003C5")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x3455C40", Offset = "0x3455040", Length = "0x18")]
	[Token(Token = "0x60003AD")]
	protected override void Update() { }

	[Address(RVA = "0x34554C0", Offset = "0x34548C0", Length = "0xFA")]
	[Token(Token = "0x60003AE")]
	private void UpdateCachedReferences() { }

	[Address(RVA = "0x34555C0", Offset = "0x34549C0", Length = "0xFD")]
	[Token(Token = "0x60003B4")]
	private void UpdateDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34556C0", Offset = "0x3454AC0", Length = "0x2FF")]
	[Token(Token = "0x60003B5")]
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	[Address(RVA = "0x34559C0", Offset = "0x3454DC0", Length = "0x278")]
	[Token(Token = "0x60003B3")]
	private void UpdateVisuals() { }

}

