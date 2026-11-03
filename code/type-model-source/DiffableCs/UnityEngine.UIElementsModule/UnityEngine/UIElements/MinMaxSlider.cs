namespace UnityEngine.UIElements;

[Token(Token = "0x2000106")]
public class MinMaxSlider : BaseField<Vector2>
{
	[Token(Token = "0x2000109")]
	private enum DragState : int
	{
		MinThumb = 0,
		MaxThumb = 1,
		MiddleThumb = 2,
		NoThumb = 3,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000107")]
	internal class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
	{

		[Address(RVA = "0x33912A0", Offset = "0x33906A0", Length = "0x39")]
		[Token(Token = "0x6000828")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000108")]
	internal class UxmlTraits : UxmlTraits<Vector2>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000505")]
		private UxmlFloatAttributeDescription m_MinValue; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000506")]
		private UxmlFloatAttributeDescription m_MaxValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000507")]
		private UxmlFloatAttributeDescription m_LowLimit; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000508")]
		private UxmlFloatAttributeDescription m_HighLimit; //Field offset: 0xB0

		[Address(RVA = "0x3392320", Offset = "0x3391720", Length = "0x1F4")]
		[Token(Token = "0x6000829")]
		public UxmlTraits() { }

		[Address(RVA = "0x33917D0", Offset = "0x3390BD0", Length = "0x267")]
		[Token(Token = "0x600082A")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40004EF")]
	internal static readonly BindingId minValueProperty; //Field offset: 0x0
	[Token(Token = "0x40004F0")]
	internal static readonly BindingId maxValueProperty; //Field offset: 0x98
	[Token(Token = "0x40004F1")]
	internal static readonly BindingId rangeProperty; //Field offset: 0x130
	[Token(Token = "0x40004F2")]
	internal static readonly BindingId lowLimitProperty; //Field offset: 0x1C8
	[Token(Token = "0x40004F3")]
	internal static readonly BindingId highLimitProperty; //Field offset: 0x260
	[Token(Token = "0x40004FD")]
	public static readonly string ussClassName; //Field offset: 0x2F8
	[Token(Token = "0x40004FE")]
	public static readonly string labelUssClassName; //Field offset: 0x300
	[Token(Token = "0x40004FF")]
	public static readonly string inputUssClassName; //Field offset: 0x308
	[Token(Token = "0x4000500")]
	public static readonly string trackerUssClassName; //Field offset: 0x310
	[Token(Token = "0x4000501")]
	public static readonly string draggerUssClassName; //Field offset: 0x318
	[Token(Token = "0x4000502")]
	public static readonly string minThumbUssClassName; //Field offset: 0x320
	[Token(Token = "0x4000503")]
	public static readonly string maxThumbUssClassName; //Field offset: 0x328
	[Token(Token = "0x4000504")]
	public static readonly string movableUssClassName; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x40004F4")]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x358
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40004F5")]
	private VisualElement <dragMinThumb>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40004F6")]
	private VisualElement <dragMaxThumb>k__BackingField; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40004F7")]
	private ClampedDragger<Single> <clampedDragger>k__BackingField; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40004F8")]
	private Vector2 m_DragElementStartPos; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x40004F9")]
	private Vector2 m_ValueStartPos; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x40004FA")]
	private DragState m_DragState; //Field offset: 0x388
	[FieldOffset(Offset = "0x38C")]
	[Token(Token = "0x40004FB")]
	private float m_MinLimit; //Field offset: 0x38C
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x40004FC")]
	private float m_MaxLimit; //Field offset: 0x390

	[Token(Token = "0x1700014E")]
	internal ClampedDragger<Single> clampedDragger
	{
		[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000803")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000804")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700014B")]
	internal VisualElement dragElement
	{
		[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007FD")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60007FE")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700014D")]
	internal VisualElement dragMaxThumb
	{
		[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000801")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000802")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700014C")]
	internal VisualElement dragMinThumb
	{
		[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60007FF")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000800")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x17000154")]
	public float highLimit
	{
		[Address(RVA = "0x16B3E40", Offset = "0x16B3240", Length = "0xB")]
		[Token(Token = "0x600080F")]
		 get { } //Length: 11
		[Address(RVA = "0x338ADB0", Offset = "0x338A1B0", Length = "0x14A")]
		[Token(Token = "0x6000810")]
		 set { } //Length: 330
	}

	[CreateProperty]
	[Token(Token = "0x17000153")]
	public float lowLimit
	{
		[Address(RVA = "0x338AC80", Offset = "0x338A080", Length = "0xB")]
		[Token(Token = "0x600080D")]
		 get { } //Length: 11
		[Address(RVA = "0x338AF00", Offset = "0x338A300", Length = "0x146")]
		[Token(Token = "0x600080E")]
		 set { } //Length: 326
	}

	[CreateProperty]
	[Token(Token = "0x17000150")]
	public float maxValue
	{
		[Address(RVA = "0x338AC90", Offset = "0x338A090", Length = "0x27")]
		[Token(Token = "0x6000807")]
		 get { } //Length: 39
		[Address(RVA = "0x338B050", Offset = "0x338A450", Length = "0x115")]
		[Token(Token = "0x6000808")]
		 set { } //Length: 277
	}

	[CreateProperty]
	[Token(Token = "0x1700014F")]
	public float minValue
	{
		[Address(RVA = "0x338ACC0", Offset = "0x338A0C0", Length = "0x27")]
		[Token(Token = "0x6000805")]
		 get { } //Length: 39
		[Address(RVA = "0x338B170", Offset = "0x338A570", Length = "0x10E")]
		[Token(Token = "0x6000806")]
		 set { } //Length: 270
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000152")]
	public float range
	{
		[Address(RVA = "0x338ACF0", Offset = "0x338A0F0", Length = "0x72")]
		[Token(Token = "0x600080C")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000151")]
	public virtual Vector2 value
	{
		[Address(RVA = "0x338AD70", Offset = "0x338A170", Length = "0x3A")]
		[Token(Token = "0x6000809")]
		 get { } //Length: 58
		[Address(RVA = "0x338B280", Offset = "0x338A680", Length = "0x5B")]
		[Token(Token = "0x600080A")]
		 set { } //Length: 91
	}

	[Address(RVA = "0x3389B30", Offset = "0x3388F30", Length = "0x726")]
	[Token(Token = "0x6000827")]
	private static MinMaxSlider() { }

	[Address(RVA = "0x338A260", Offset = "0x3389660", Length = "0x40")]
	[Token(Token = "0x6000811")]
	public MinMaxSlider() { }

	[Address(RVA = "0x338A2A0", Offset = "0x33896A0", Length = "0x9DE")]
	[Token(Token = "0x6000812")]
	public MinMaxSlider(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38) { }

	[Address(RVA = "0x3387970", Offset = "0x3386D70", Length = "0x86")]
	[Token(Token = "0x6000813")]
	private Vector2 ClampValues(Vector2 valueToClamp) { }

	[Address(RVA = "0x3387A00", Offset = "0x3386E00", Length = "0x225")]
	[Token(Token = "0x6000823")]
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	[Address(RVA = "0x3387C30", Offset = "0x3387030", Length = "0x4C6")]
	[Token(Token = "0x6000820")]
	private void ComputeValueFromKey(bool leftDirection, bool isShift, DragState moveState) { }

	[Address(RVA = "0x3388100", Offset = "0x3387500", Length = "0xC1")]
	[Token(Token = "0x6000818")]
	private float ComputeValueFromPosition(float positionToConvert) { }

	[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000803")]
	internal ClampedDragger<Single> get_clampedDragger() { }

	[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007FD")]
	internal VisualElement get_dragElement() { }

	[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000801")]
	internal VisualElement get_dragMaxThumb() { }

	[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60007FF")]
	internal VisualElement get_dragMinThumb() { }

	[Address(RVA = "0x16B3E40", Offset = "0x16B3240", Length = "0xB")]
	[Token(Token = "0x600080F")]
	public float get_highLimit() { }

	[Address(RVA = "0x338AC80", Offset = "0x338A080", Length = "0xB")]
	[Token(Token = "0x600080D")]
	public float get_lowLimit() { }

	[Address(RVA = "0x338AC90", Offset = "0x338A090", Length = "0x27")]
	[Token(Token = "0x6000807")]
	public float get_maxValue() { }

	[Address(RVA = "0x338ACC0", Offset = "0x338A0C0", Length = "0x27")]
	[Token(Token = "0x6000805")]
	public float get_minValue() { }

	[Address(RVA = "0x338ACF0", Offset = "0x338A0F0", Length = "0x72")]
	[Token(Token = "0x600080C")]
	public float get_range() { }

	[Address(RVA = "0x338AD70", Offset = "0x338A170", Length = "0x3A")]
	[Token(Token = "0x6000809")]
	public virtual Vector2 get_value() { }

	[Address(RVA = "0x33881D0", Offset = "0x33875D0", Length = "0xCF")]
	[Token(Token = "0x600081A")]
	private DragState GetNavigationState() { }

	[Address(RVA = "0x33882A0", Offset = "0x33876A0", Length = "0x182")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)})]
	[Token(Token = "0x6000819")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x3388430", Offset = "0x3387830", Length = "0x111")]
	[Token(Token = "0x600081D")]
	private void OnBlur(BlurEvent evt) { }

	[Address(RVA = "0x3388550", Offset = "0x3387950", Length = "0x123")]
	[Token(Token = "0x600081C")]
	private void OnFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x3388680", Offset = "0x3387A80", Length = "0xDD")]
	[Token(Token = "0x600081F")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x3388760", Offset = "0x3387B60", Length = "0x2A")]
	[Token(Token = "0x600081E")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x3388790", Offset = "0x3387B90", Length = "0x12D")]
	[Token(Token = "0x6000825")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000804")]
	private void set_clampedDragger(ClampedDragger<Single> value) { }

	[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60007FE")]
	private void set_dragElement(VisualElement value) { }

	[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000802")]
	private void set_dragMaxThumb(VisualElement value) { }

	[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000800")]
	private void set_dragMinThumb(VisualElement value) { }

	[Address(RVA = "0x338ADB0", Offset = "0x338A1B0", Length = "0x14A")]
	[Token(Token = "0x6000810")]
	public void set_highLimit(float value) { }

	[Address(RVA = "0x338AF00", Offset = "0x338A300", Length = "0x146")]
	[Token(Token = "0x600080E")]
	public void set_lowLimit(float value) { }

	[Address(RVA = "0x338B050", Offset = "0x338A450", Length = "0x115")]
	[Token(Token = "0x6000808")]
	public void set_maxValue(float value) { }

	[Address(RVA = "0x338B170", Offset = "0x338A570", Length = "0x10E")]
	[Token(Token = "0x6000806")]
	public void set_minValue(float value) { }

	[Address(RVA = "0x338B280", Offset = "0x338A680", Length = "0x5B")]
	[Token(Token = "0x600080A")]
	public virtual void set_value(Vector2 value) { }

	[Address(RVA = "0x33888C0", Offset = "0x3387CC0", Length = "0x149")]
	[Token(Token = "0x600081B")]
	private void SetNavigationState(DragState newState) { }

	[Address(RVA = "0x3388A10", Offset = "0x3387E10", Length = "0x5CF")]
	[Token(Token = "0x6000822")]
	private void SetSliderValueFromClick() { }

	[Address(RVA = "0x3388FE0", Offset = "0x33883E0", Length = "0x8E")]
	[Token(Token = "0x6000821")]
	private void SetSliderValueFromDrag() { }

	[Address(RVA = "0x3389070", Offset = "0x3388470", Length = "0x65")]
	[Token(Token = "0x600080B")]
	public virtual void SetValueWithoutNotify(Vector2 newValue) { }

	[Address(RVA = "0x33890E0", Offset = "0x33884E0", Length = "0x12")]
	[Token(Token = "0x6000816")]
	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	[Address(RVA = "0x3389100", Offset = "0x3388500", Length = "0x12")]
	[Token(Token = "0x6000817")]
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	[Address(RVA = "0x3389120", Offset = "0x3388520", Length = "0x12D")]
	[Token(Token = "0x6000826")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x3389250", Offset = "0x3388650", Length = "0x820")]
	[Token(Token = "0x6000815")]
	private void UpdateDragElementPosition() { }

	[Address(RVA = "0x3389A80", Offset = "0x3388E80", Length = "0xA9")]
	[Token(Token = "0x6000814")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000824")]
	protected virtual void UpdateMixedValueContent() { }

}

