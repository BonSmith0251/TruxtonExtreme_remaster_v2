namespace UnityEngine.UIElements;

[Token(Token = "0x2000081")]
public abstract class BaseSlider : BaseField<TValueType>, IValueField<TValueType>
{
	[Token(Token = "0x2000083")]
	public enum SliderKey : int
	{
		None = 0,
		Lowest = 1,
		LowerPage = 2,
		Lower = 3,
		Higher = 4,
		HigherPage = 5,
		Highest = 6,
	}

	[Obsolete("UxmlTraits<TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000082")]
	internal class UxmlTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
	{

		[Address(RVA = "0x11E7420", Offset = "0x11E6820", Length = "0x62")]
		[Token(Token = "0x60004EA")]
		public UxmlTraits`1() { }

	}

	[Token(Token = "0x40002AB")]
	internal static readonly BindingId lowValueProperty; //Field offset: 0x0
	[Token(Token = "0x40002CF")]
	public static readonly string textFieldClassName; //Field offset: 0x0
	[Token(Token = "0x40002CE")]
	public static readonly string draggerBorderUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002CD")]
	public static readonly string draggerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002CC")]
	public static readonly string trackerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002CB")]
	public static readonly string dragContainerUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002CA")]
	public static readonly string verticalVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002C9")]
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002C8")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002C7")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002C6")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40002D0")]
	public static readonly string fillUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002D1")]
	public static readonly string movableUssClassName; //Field offset: 0x0
	[Token(Token = "0x40002AC")]
	internal static readonly BindingId highValueProperty; //Field offset: 0x0
	[Token(Token = "0x40002AD")]
	internal static readonly BindingId rangeProperty; //Field offset: 0x0
	[Token(Token = "0x40002AE")]
	internal static readonly BindingId pageSizeProperty; //Field offset: 0x0
	[Token(Token = "0x40002AF")]
	internal static readonly BindingId showInputFieldProperty; //Field offset: 0x0
	[Token(Token = "0x40002B0")]
	internal static readonly BindingId directionProperty; //Field offset: 0x0
	[Token(Token = "0x40002B1")]
	internal static readonly BindingId invertedProperty; //Field offset: 0x0
	[Token(Token = "0x40002B2")]
	internal static readonly BindingId fillProperty; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B8")]
	private VisualElement <fillElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B3")]
	private VisualElement <dragContainer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B4")]
	private VisualElement <dragElement>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B5")]
	private VisualElement <trackElement>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C5")]
	private bool m_Inverted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C4")]
	private SliderDirection m_Direction; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C3")]
	private Action<TValueType> onSetValueWithoutNotify; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C2")]
	private Rect m_DragElementStartPos; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C1")]
	private ClampedDragger<TValueType> <clampedDragger>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002C0")]
	private bool <clamped>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BF")]
	private bool m_ShowInputField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B6")]
	private VisualElement <dragBorderElement>k__BackingField; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40002BD")]
	private TValueType m_HighValue; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40002BC")]
	private TValueType m_LowValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BB")]
	private bool m_Fill; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BA")]
	private bool m_IsEditingTextField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B9")]
	private float m_AdjustedPageSizeFromClick; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B7")]
	private TextField <inputTextField>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002BE")]
	private float m_PageSize; //Field offset: 0x0

	[Token(Token = "0x14000011")]
	internal event Action<TValueType> onSetValueWithoutNotify
	{
		[Address(RVA = "0x16A5540", Offset = "0x16A4940", Length = "0xC5")]
		[CompilerGenerated]
		[Token(Token = "0x60004BF")]
		internal add { } //Length: 197
		[Address(RVA = "0x16A57B0", Offset = "0x16A4BB0", Length = "0xC5")]
		[CompilerGenerated]
		[Token(Token = "0x60004C0")]
		internal remove { } //Length: 197
	}

	[Token(Token = "0x170000B4")]
	virtual bool canSwitchToMixedValue
	{
		[Address(RVA = "0x16A5610", Offset = "0x16A4A10", Length = "0x76")]
		[Token(Token = "0x60004A7")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000BB")]
	internal bool clamped
	{
		[Address(RVA = "0x16A56A0", Offset = "0x16A4AA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004B4")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A58A0", Offset = "0x16A4CA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60004B5")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170000BC")]
	internal ClampedDragger<TValueType> clampedDragger
	{
		[Address(RVA = "0x16A5690", Offset = "0x16A4A90", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004B6")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5880", Offset = "0x16A4C80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004B7")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000BE")]
	public SliderDirection direction
	{
		[Address(RVA = "0x16A56B0", Offset = "0x16A4AB0", Length = "0x9")]
		[Token(Token = "0x60004C2")]
		 get { } //Length: 9
		[Address(RVA = "0x16A58B0", Offset = "0x16A4CB0", Length = "0x1DC")]
		[Token(Token = "0x60004C3")]
		 set { } //Length: 476
	}

	[Token(Token = "0x170000B1")]
	internal VisualElement dragBorderElement
	{
		[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004A1")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004A2")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000AE")]
	internal VisualElement dragContainer
	{
		[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600049B")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600049C")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000AF")]
	internal VisualElement dragElement
	{
		[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600049D")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600049E")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000BA")]
	public bool fill
	{
		[Address(RVA = "0x16A56E0", Offset = "0x16A4AE0", Length = "0x8")]
		[Token(Token = "0x60004B2")]
		 get { } //Length: 8
		[Address(RVA = "0x16A5B10", Offset = "0x16A4F10", Length = "0xE2")]
		[Token(Token = "0x60004B3")]
		 set { } //Length: 226
	}

	[Token(Token = "0x170000B3")]
	internal VisualElement fillElement
	{
		[Address(RVA = "0x16A56D0", Offset = "0x16A4AD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004A5")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5AF0", Offset = "0x16A4EF0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004A6")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000B6")]
	public TValueType highValue
	{
		[Address(RVA = "0x16A56F0", Offset = "0x16A4AF0", Length = "0x9")]
		[Token(Token = "0x60004AA")]
		 get { } //Length: 9
		[Address(RVA = "0x16A5C00", Offset = "0x16A5000", Length = "0x144")]
		[Token(Token = "0x60004AB")]
		 set { } //Length: 324
	}

	[Token(Token = "0x170000B2")]
	internal TextField inputTextField
	{
		[Address(RVA = "0x16A5700", Offset = "0x16A4B00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60004A3")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A5D50", Offset = "0x16A5150", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004A4")]
		private set { } //Length: 19
	}

	[CreateProperty]
	[Token(Token = "0x170000BF")]
	public bool inverted
	{
		[Address(RVA = "0x16A5710", Offset = "0x16A4B10", Length = "0xA")]
		[Token(Token = "0x60004C4")]
		 get { } //Length: 10
		[Address(RVA = "0x16A5D70", Offset = "0x16A5170", Length = "0xAB")]
		[Token(Token = "0x60004C5")]
		 set { } //Length: 171
	}

	[CreateProperty]
	[Token(Token = "0x170000B5")]
	public TValueType lowValue
	{
		[Address(RVA = "0x16A5720", Offset = "0x16A4B20", Length = "0x9")]
		[Token(Token = "0x60004A8")]
		 get { } //Length: 9
		[Address(RVA = "0x16A5E20", Offset = "0x16A5220", Length = "0x13D")]
		[Token(Token = "0x60004A9")]
		 set { } //Length: 317
	}

	[CreateProperty]
	[Token(Token = "0x170000B8")]
	public override float pageSize
	{
		[Address(RVA = "0x16A5730", Offset = "0x16A4B30", Length = "0xB")]
		[Token(Token = "0x60004AE")]
		 get { } //Length: 11
		[Address(RVA = "0x16A5F60", Offset = "0x16A5360", Length = "0x9C")]
		[Token(Token = "0x60004AF")]
		 set { } //Length: 156
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000B7")]
	public TValueType range
	{
		[Address(RVA = "0x16A5740", Offset = "0x16A4B40", Length = "0x14")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170000B9")]
	public override bool showInputField
	{
		[Address(RVA = "0x16A5760", Offset = "0x16A4B60", Length = "0xA")]
		[Token(Token = "0x60004B0")]
		 get { } //Length: 10
		[Address(RVA = "0x16A6000", Offset = "0x16A5400", Length = "0xAE")]
		[Token(Token = "0x60004B1")]
		 set { } //Length: 174
	}

	[Token(Token = "0x170000B0")]
	internal VisualElement trackElement
	{
		[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600049F")]
		internal get { } //Length: 8
		[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60004A0")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000BD")]
	public virtual TValueType value
	{
		[Address(RVA = "0x16A5780", Offset = "0x16A4B80", Length = "0x26")]
		[Token(Token = "0x60004BA")]
		 get { } //Length: 38
		[Address(RVA = "0x16A60D0", Offset = "0x16A54D0", Length = "0x53")]
		[Token(Token = "0x60004BB")]
		 set { } //Length: 83
	}

	[Address(RVA = "0x16A31F0", Offset = "0x16A25F0", Length = "0x173A")]
	[Token(Token = "0x60004E9")]
	private static BaseSlider`1() { }

	[Address(RVA = "0x16A4930", Offset = "0x16A3D30", Length = "0xC00")]
	[Token(Token = "0x60004C6")]
	internal BaseSlider`1(string label, TValueType start, TValueType end, SliderDirection direction = 0, float pageSize = 0) { }

	[Address(RVA = "0x16A5540", Offset = "0x16A4940", Length = "0xC5")]
	[CompilerGenerated]
	[Token(Token = "0x60004BF")]
	internal void add_onSetValueWithoutNotify(Action<TValueType> value) { }

	[Address(RVA = "0x169FB50", Offset = "0x169EF50", Length = "0x4A2")]
	[Token(Token = "0x60004D7")]
	public void AdjustDragElement(float factor) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004BC")]
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	[Address(RVA = "0x16A0050", Offset = "0x169F450", Length = "0x88")]
	[Token(Token = "0x60004B8")]
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	[Address(RVA = "0x16A0000", Offset = "0x169F400", Length = "0x48")]
	[Token(Token = "0x60004C9")]
	private void ClampValue() { }

	[Address(RVA = "0x16A00E0", Offset = "0x169F4E0", Length = "0x24D")]
	[Token(Token = "0x60004D6")]
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	[Address(RVA = "0x16A0330", Offset = "0x169F730", Length = "0x16A")]
	[Token(Token = "0x60004D1")]
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	[Token(Token = "0x60004CE")]
	internal abstract void ComputeValueFromKey(SliderKey<TValueType> sliderKey, bool isShift) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", False)]
	[Token(Token = "0x60004DE")]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x16A5610", Offset = "0x16A4A10", Length = "0x76")]
	[Token(Token = "0x60004A7")]
	virtual bool get_canSwitchToMixedValue() { }

	[Address(RVA = "0x16A56A0", Offset = "0x16A4AA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004B4")]
	internal bool get_clamped() { }

	[Address(RVA = "0x16A5690", Offset = "0x16A4A90", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004B6")]
	internal ClampedDragger<TValueType> get_clampedDragger() { }

	[Address(RVA = "0x16A56B0", Offset = "0x16A4AB0", Length = "0x9")]
	[Token(Token = "0x60004C2")]
	public SliderDirection get_direction() { }

	[Address(RVA = "0x16A56C0", Offset = "0x16A4AC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004A1")]
	internal VisualElement get_dragBorderElement() { }

	[Address(RVA = "0x10385F0", Offset = "0x10379F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600049B")]
	internal VisualElement get_dragContainer() { }

	[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600049D")]
	internal VisualElement get_dragElement() { }

	[Address(RVA = "0x16A56E0", Offset = "0x16A4AE0", Length = "0x8")]
	[Token(Token = "0x60004B2")]
	public bool get_fill() { }

	[Address(RVA = "0x16A56D0", Offset = "0x16A4AD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004A5")]
	internal VisualElement get_fillElement() { }

	[Address(RVA = "0x16A56F0", Offset = "0x16A4AF0", Length = "0x9")]
	[Token(Token = "0x60004AA")]
	public TValueType get_highValue() { }

	[Address(RVA = "0x16A5700", Offset = "0x16A4B00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60004A3")]
	internal TextField get_inputTextField() { }

	[Address(RVA = "0x16A5710", Offset = "0x16A4B10", Length = "0xA")]
	[Token(Token = "0x60004C4")]
	public bool get_inverted() { }

	[Address(RVA = "0x16A5720", Offset = "0x16A4B20", Length = "0x9")]
	[Token(Token = "0x60004A8")]
	public TValueType get_lowValue() { }

	[Address(RVA = "0x16A5730", Offset = "0x16A4B30", Length = "0xB")]
	[Token(Token = "0x60004AE")]
	public override float get_pageSize() { }

	[Address(RVA = "0x16A5740", Offset = "0x16A4B40", Length = "0x14")]
	[Token(Token = "0x60004AD")]
	public TValueType get_range() { }

	[Address(RVA = "0x16A5760", Offset = "0x16A4B60", Length = "0xA")]
	[Token(Token = "0x60004B0")]
	public override bool get_showInputField() { }

	[Address(RVA = "0x16A5770", Offset = "0x16A4B70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600049F")]
	internal VisualElement get_trackElement() { }

	[Address(RVA = "0x16A5780", Offset = "0x16A4B80", Length = "0x26")]
	[Token(Token = "0x60004BA")]
	public virtual TValueType get_value() { }

	[Address(RVA = "0x16A04A0", Offset = "0x169F8A0", Length = "0xD1")]
	[Token(Token = "0x60004B9")]
	private TValueType GetClampedValue(TValueType newValue) { }

	[Address(RVA = "0x16A0580", Offset = "0x169F980", Length = "0x10E")]
	[Token(Token = "0x60004C7")]
	protected private static float GetClosestPowerOfTen(float positiveNumber) { }

	[Address(RVA = "0x16A0690", Offset = "0x169FA90", Length = "0x1BC")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(GeometryChangedEvent)})]
	[Token(Token = "0x60004DD")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x16A0850", Offset = "0x169FC50", Length = "0x92")]
	[Token(Token = "0x60004E1")]
	private void OnFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x16A08F0", Offset = "0x169FCF0", Length = "0x92")]
	[Token(Token = "0x60004E2")]
	private void OnFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x16A0990", Offset = "0x169FD90", Length = "0x144")]
	[Token(Token = "0x60004D3")]
	private void OnKeyDown(KeyDownEvent evt) { }

	[Address(RVA = "0x16A0AE0", Offset = "0x169FEE0", Length = "0x180")]
	[Token(Token = "0x60004D4")]
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	[Address(RVA = "0x16A0C70", Offset = "0x16A0070", Length = "0x105")]
	[Token(Token = "0x60004D5")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x16A0D80", Offset = "0x16A0180", Length = "0x8")]
	[Token(Token = "0x60004E3")]
	private void OnTextFieldFocusIn(FocusInEvent evt) { }

	[Address(RVA = "0x16A0D90", Offset = "0x16A0190", Length = "0x1E")]
	[Token(Token = "0x60004E4")]
	private void OnTextFieldFocusOut(FocusOutEvent evt) { }

	[Address(RVA = "0x16A0DB0", Offset = "0x16A01B0", Length = "0x136")]
	[Token(Token = "0x60004E5")]
	private void OnTextFieldValueChange(ChangeEvent<String> evt) { }

	[Address(RVA = "0x16A0EF0", Offset = "0x16A02F0", Length = "0x6D")]
	[Token(Token = "0x60004D9")]
	internal virtual void OnViewDataReady() { }

	[Token(Token = "0x60004CD")]
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue) { }

	[Address(RVA = "0x16A0F60", Offset = "0x16A0360", Length = "0x176")]
	[Token(Token = "0x60004E7")]
	internal virtual void RegisterEditingCallbacks() { }

	[Address(RVA = "0x16A57B0", Offset = "0x16A4BB0", Length = "0xC5")]
	[CompilerGenerated]
	[Token(Token = "0x60004C0")]
	internal void remove_onSetValueWithoutNotify(Action<TValueType> value) { }

	[Address(RVA = "0x16A10E0", Offset = "0x16A04E0", Length = "0x2D")]
	[Token(Token = "0x60004C8")]
	protected private static float RoundToMultipleOf(float value, float roundingValue) { }

	[Address(RVA = "0x16A1110", Offset = "0x16A0510", Length = "0x14")]
	[Token(Token = "0x60004DA")]
	private bool SameValues(float a, float b, float epsilon) { }

	[Address(RVA = "0x16A58A0", Offset = "0x16A4CA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60004B5")]
	internal void set_clamped(bool value) { }

	[Address(RVA = "0x16A5880", Offset = "0x16A4C80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004B7")]
	private void set_clampedDragger(ClampedDragger<TValueType> value) { }

	[Address(RVA = "0x16A58B0", Offset = "0x16A4CB0", Length = "0x1DC")]
	[Token(Token = "0x60004C3")]
	public void set_direction(SliderDirection value) { }

	[Address(RVA = "0x16A5A90", Offset = "0x16A4E90", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004A2")]
	private void set_dragBorderElement(VisualElement value) { }

	[Address(RVA = "0x16A5AB0", Offset = "0x16A4EB0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600049C")]
	private void set_dragContainer(VisualElement value) { }

	[Address(RVA = "0x16A5AD0", Offset = "0x16A4ED0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600049E")]
	private void set_dragElement(VisualElement value) { }

	[Address(RVA = "0x16A5B10", Offset = "0x16A4F10", Length = "0xE2")]
	[Token(Token = "0x60004B3")]
	public void set_fill(bool value) { }

	[Address(RVA = "0x16A5AF0", Offset = "0x16A4EF0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004A6")]
	private void set_fillElement(VisualElement value) { }

	[Address(RVA = "0x16A5C00", Offset = "0x16A5000", Length = "0x144")]
	[Token(Token = "0x60004AB")]
	public void set_highValue(TValueType value) { }

	[Address(RVA = "0x16A5D50", Offset = "0x16A5150", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004A4")]
	private void set_inputTextField(TextField value) { }

	[Address(RVA = "0x16A5D70", Offset = "0x16A5170", Length = "0xAB")]
	[Token(Token = "0x60004C5")]
	public void set_inverted(bool value) { }

	[Address(RVA = "0x16A5E20", Offset = "0x16A5220", Length = "0x13D")]
	[Token(Token = "0x60004A9")]
	public void set_lowValue(TValueType value) { }

	[Address(RVA = "0x16A5F60", Offset = "0x16A5360", Length = "0x9C")]
	[Token(Token = "0x60004AF")]
	public override void set_pageSize(float value) { }

	[Address(RVA = "0x16A6000", Offset = "0x16A5400", Length = "0xAE")]
	[Token(Token = "0x60004B1")]
	public override void set_showInputField(bool value) { }

	[Address(RVA = "0x16A60B0", Offset = "0x16A54B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60004A0")]
	private void set_trackElement(VisualElement value) { }

	[Address(RVA = "0x16A60D0", Offset = "0x16A54D0", Length = "0x53")]
	[Token(Token = "0x60004BB")]
	public virtual void set_value(TValueType value) { }

	[Address(RVA = "0x16A1130", Offset = "0x16A0530", Length = "0x92")]
	[Token(Token = "0x60004AC")]
	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }

	[Address(RVA = "0x16A11D0", Offset = "0x16A05D0", Length = "0x7F7")]
	[Token(Token = "0x60004D2")]
	private void SetSliderValueFromClick() { }

	[Address(RVA = "0x16A19D0", Offset = "0x16A0DD0", Length = "0x1D6")]
	[Token(Token = "0x60004D0")]
	private void SetSliderValueFromDrag() { }

	[Address(RVA = "0x16A1BB0", Offset = "0x16A0FB0", Length = "0xAB")]
	[Token(Token = "0x60004C1")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x16A1C60", Offset = "0x16A1060", Length = "0x4C")]
	[Token(Token = "0x60004CF")]
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	[Token(Token = "0x60004CA")]
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	[Token(Token = "0x60004CB")]
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	[Token(Token = "0x60004CC")]
	internal abstract TValueType SliderRange() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004BD")]
	private override void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004BE")]
	private override void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	[Address(RVA = "0x16A1CB0", Offset = "0x16A10B0", Length = "0x176")]
	[Token(Token = "0x60004E8")]
	internal virtual void UnregisterEditingCallbacks() { }

	[Address(RVA = "0x16A1E30", Offset = "0x16A1230", Length = "0x4F9")]
	[Token(Token = "0x60004DB")]
	private void UpdateDragElementPosition() { }

	[Address(RVA = "0x16A2330", Offset = "0x16A1730", Length = "0xC7")]
	[Token(Token = "0x60004D8")]
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	[Address(RVA = "0x16A2400", Offset = "0x16A1800", Length = "0x7DD")]
	[Token(Token = "0x60004DC")]
	private void UpdateFill(float normalizedValue) { }

	[Address(RVA = "0x16A2BE0", Offset = "0x16A1FE0", Length = "0xB8")]
	[Token(Token = "0x60004E6")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0x16A2CA0", Offset = "0x16A20A0", Length = "0xFB")]
	[Token(Token = "0x60004E0")]
	private void UpdateTextFieldValue() { }

	[Address(RVA = "0x16A2DA0", Offset = "0x16A21A0", Length = "0x44B")]
	[Token(Token = "0x60004DF")]
	private void UpdateTextFieldVisibility() { }

}

