namespace UnityEngine.UI;

[AddComponentMenu("UI (Canvas)/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200006D")]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
{
	[Token(Token = "0x2000070")]
	private enum Axis : int
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Token(Token = "0x200006E")]
	internal enum Direction : int
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3,
	}

	[Token(Token = "0x200006F")]
	internal class SliderEvent : UnityEvent<Single>
	{

		[Address(RVA = "0x3459010", Offset = "0x3458410", Length = "0x39")]
		[Token(Token = "0x600049A")]
		public SliderEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000222")]
	private RectTransform m_FillRect; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000223")]
	private RectTransform m_HandleRect; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000224")]
	private Direction m_Direction; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x4000225")]
	private float m_MinValue; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000226")]
	private float m_MaxValue; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	[Token(Token = "0x4000227")]
	private bool m_WholeNumbers; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000228")]
	protected float m_Value; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Space]
	[Token(Token = "0x4000229")]
	private SliderEvent m_OnValueChanged; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400022A")]
	private Image m_FillImage; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400022B")]
	private Transform m_FillTransform; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400022C")]
	private RectTransform m_FillContainerRect; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400022D")]
	private Transform m_HandleTransform; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400022E")]
	private RectTransform m_HandleContainerRect; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400022F")]
	private Vector2 m_Offset; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000230")]
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0x160
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x4000231")]
	private bool m_DelayedUpdateVisuals; //Field offset: 0x161

	[Token(Token = "0x17000131")]
	private Axis axis
	{
		[Address(RVA = "0x345AA50", Offset = "0x3459E50", Length = "0x15")]
		[Token(Token = "0x600048B")]
		private get { } //Length: 21
	}

	[Token(Token = "0x17000129")]
	public Direction direction
	{
		[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
		[Token(Token = "0x600046F")]
		 get { } //Length: 7
		[Address(RVA = "0x345AB90", Offset = "0x3459F90", Length = "0x59")]
		[Token(Token = "0x6000470")]
		 set { } //Length: 89
	}

	[Token(Token = "0x17000127")]
	public RectTransform fillRect
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x600046B")]
		 get { } //Length: 8
		[Address(RVA = "0x345ABF0", Offset = "0x3459FF0", Length = "0x65")]
		[Token(Token = "0x600046C")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000128")]
	public RectTransform handleRect
	{
		[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
		[Token(Token = "0x600046D")]
		 get { } //Length: 8
		[Address(RVA = "0x345AC60", Offset = "0x345A060", Length = "0x65")]
		[Token(Token = "0x600046E")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700012B")]
	public float maxValue
	{
		[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
		[Token(Token = "0x6000473")]
		 get { } //Length: 9
		[Address(RVA = "0x345ACD0", Offset = "0x345A0D0", Length = "0x7D")]
		[Token(Token = "0x6000474")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700012A")]
	public float minValue
	{
		[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 9
		[Address(RVA = "0x345AD50", Offset = "0x345A150", Length = "0x7D")]
		[Token(Token = "0x6000472")]
		 set { } //Length: 125
	}

	[Token(Token = "0x1700012E")]
	public float normalizedValue
	{
		[Address(RVA = "0x345AA70", Offset = "0x3459E70", Length = "0xAC")]
		[Token(Token = "0x600047A")]
		 get { } //Length: 172
		[Address(RVA = "0x345ADD0", Offset = "0x345A1D0", Length = "0x50")]
		[Token(Token = "0x600047B")]
		 set { } //Length: 80
	}

	[Token(Token = "0x1700012F")]
	public SliderEvent onValueChanged
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[Token(Token = "0x600047C")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[Token(Token = "0x600047D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000132")]
	private bool reverseValue
	{
		[Address(RVA = "0x345AB20", Offset = "0x3459F20", Length = "0x17")]
		[Token(Token = "0x600048C")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000130")]
	private float stepSize
	{
		[Address(RVA = "0x345AB40", Offset = "0x3459F40", Length = "0x2B")]
		[Token(Token = "0x600047E")]
		private get { } //Length: 43
	}

	[Token(Token = "0x1700012D")]
	public override float value
	{
		[Address(RVA = "0x345AB70", Offset = "0x3459F70", Length = "0x16")]
		[Token(Token = "0x6000477")]
		 get { } //Length: 22
		[Address(RVA = "0x345AE20", Offset = "0x345A220", Length = "0x17")]
		[Token(Token = "0x6000478")]
		 set { } //Length: 23
	}

	[Token(Token = "0x1700012C")]
	public bool wholeNumbers
	{
		[Address(RVA = "0x2D67CE0", Offset = "0x2D670E0", Length = "0x8")]
		[Token(Token = "0x6000475")]
		 get { } //Length: 8
		[Address(RVA = "0x345AE40", Offset = "0x345A240", Length = "0x7D")]
		[Token(Token = "0x6000476")]
		 set { } //Length: 125
	}

	[Address(RVA = "0x345A950", Offset = "0x3459D50", Length = "0xF7")]
	[Token(Token = "0x600047F")]
	protected Slider() { }

	[Address(RVA = "0x3459050", Offset = "0x3458450", Length = "0x2E")]
	[Token(Token = "0x6000488")]
	private float ClampValue(float input) { }

	[Address(RVA = "0x3459080", Offset = "0x3458480", Length = "0x2E")]
	[Token(Token = "0x6000496")]
	public virtual Selectable FindSelectableOnDown() { }

	[Address(RVA = "0x34590B0", Offset = "0x34584B0", Length = "0x2E")]
	[Token(Token = "0x6000493")]
	public virtual Selectable FindSelectableOnLeft() { }

	[Address(RVA = "0x34590E0", Offset = "0x34584E0", Length = "0x2E")]
	[Token(Token = "0x6000494")]
	public virtual Selectable FindSelectableOnRight() { }

	[Address(RVA = "0x3459110", Offset = "0x3458510", Length = "0x2E")]
	[Token(Token = "0x6000495")]
	public virtual Selectable FindSelectableOnUp() { }

	[Address(RVA = "0x345AA50", Offset = "0x3459E50", Length = "0x15")]
	[Token(Token = "0x600048B")]
	private Axis get_axis() { }

	[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
	[Token(Token = "0x600046F")]
	public Direction get_direction() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x600046B")]
	public RectTransform get_fillRect() { }

	[Address(RVA = "0xE7CFD0", Offset = "0xE7C3D0", Length = "0x8")]
	[Token(Token = "0x600046D")]
	public RectTransform get_handleRect() { }

	[Address(RVA = "0x2D25F20", Offset = "0x2D25320", Length = "0x9")]
	[Token(Token = "0x6000473")]
	public float get_maxValue() { }

	[Address(RVA = "0x2D25F00", Offset = "0x2D25300", Length = "0x9")]
	[Token(Token = "0x6000471")]
	public float get_minValue() { }

	[Address(RVA = "0x345AA70", Offset = "0x3459E70", Length = "0xAC")]
	[Token(Token = "0x600047A")]
	public float get_normalizedValue() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[Token(Token = "0x600047C")]
	public SliderEvent get_onValueChanged() { }

	[Address(RVA = "0x345AB20", Offset = "0x3459F20", Length = "0x17")]
	[Token(Token = "0x600048C")]
	private bool get_reverseValue() { }

	[Address(RVA = "0x345AB40", Offset = "0x3459F40", Length = "0x2B")]
	[Token(Token = "0x600047E")]
	private float get_stepSize() { }

	[Address(RVA = "0x345AB70", Offset = "0x3459F70", Length = "0x16")]
	[Token(Token = "0x6000477")]
	public override float get_value() { }

	[Address(RVA = "0x2D67CE0", Offset = "0x2D670E0", Length = "0x8")]
	[Token(Token = "0x6000475")]
	public bool get_wholeNumbers() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000482")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000481")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x3454490", Offset = "0x3453890", Length = "0x6D")]
	[Token(Token = "0x600048F")]
	private bool MayDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3459140", Offset = "0x3458540", Length = "0x27F")]
	[Token(Token = "0x6000486")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x34593C0", Offset = "0x34587C0", Length = "0x26")]
	[Token(Token = "0x6000484")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x34593F0", Offset = "0x34587F0", Length = "0x7A")]
	[Token(Token = "0x6000491")]
	public override void OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x3459470", Offset = "0x3458870", Length = "0x4A")]
	[Token(Token = "0x6000483")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3454A70", Offset = "0x3453E70", Length = "0x1A")]
	[Token(Token = "0x6000497")]
	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	[Address(RVA = "0x34594C0", Offset = "0x34588C0", Length = "0x44F")]
	[Token(Token = "0x6000492")]
	public virtual void OnMove(AxisEventData eventData) { }

	[Address(RVA = "0x3459910", Offset = "0x3458D10", Length = "0x257")]
	[Token(Token = "0x6000490")]
	public virtual void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x3459B70", Offset = "0x3458F70", Length = "0x3F")]
	[Token(Token = "0x600048A")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000480")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x3459DA0", Offset = "0x34591A0", Length = "0xE9")]
	[Token(Token = "0x6000489")]
	protected override void Set(float input, bool sendCallback = true) { }

	[Address(RVA = "0x345AB90", Offset = "0x3459F90", Length = "0x59")]
	[Token(Token = "0x6000470")]
	public void set_direction(Direction value) { }

	[Address(RVA = "0x345ABF0", Offset = "0x3459FF0", Length = "0x65")]
	[Token(Token = "0x600046C")]
	public void set_fillRect(RectTransform value) { }

	[Address(RVA = "0x345AC60", Offset = "0x345A060", Length = "0x65")]
	[Token(Token = "0x600046E")]
	public void set_handleRect(RectTransform value) { }

	[Address(RVA = "0x345ACD0", Offset = "0x345A0D0", Length = "0x7D")]
	[Token(Token = "0x6000474")]
	public void set_maxValue(float value) { }

	[Address(RVA = "0x345AD50", Offset = "0x345A150", Length = "0x7D")]
	[Token(Token = "0x6000472")]
	public void set_minValue(float value) { }

	[Address(RVA = "0x345ADD0", Offset = "0x345A1D0", Length = "0x50")]
	[Token(Token = "0x600047B")]
	public void set_normalizedValue(float value) { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[Token(Token = "0x600047D")]
	public void set_onValueChanged(SliderEvent value) { }

	[Address(RVA = "0x345AE20", Offset = "0x345A220", Length = "0x17")]
	[Token(Token = "0x6000478")]
	public override void set_value(float value) { }

	[Address(RVA = "0x345AE40", Offset = "0x345A240", Length = "0x7D")]
	[Token(Token = "0x6000476")]
	public void set_wholeNumbers(bool value) { }

	[Address(RVA = "0x3459BB0", Offset = "0x3458FB0", Length = "0x1C6")]
	[Token(Token = "0x6000498")]
	public void SetDirection(Direction direction, bool includeRectLayouts) { }

	[Address(RVA = "0x3459D80", Offset = "0x3459180", Length = "0x17")]
	[Token(Token = "0x6000479")]
	public override void SetValueWithoutNotify(float input) { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x6000499")]
	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	[Address(RVA = "0x345A900", Offset = "0x3459D00", Length = "0x4C")]
	[Token(Token = "0x6000485")]
	protected override void Update() { }

	[Address(RVA = "0x3459E90", Offset = "0x3459290", Length = "0x386")]
	[Token(Token = "0x6000487")]
	private void UpdateCachedReferences() { }

	[Address(RVA = "0x345A220", Offset = "0x3459620", Length = "0x2FC")]
	[Token(Token = "0x600048E")]
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	[Address(RVA = "0x345A520", Offset = "0x3459920", Length = "0x3DC")]
	[Token(Token = "0x600048D")]
	private void UpdateVisuals() { }

}

