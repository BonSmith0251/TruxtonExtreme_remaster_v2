namespace UnityEngine.UIElements;

[Token(Token = "0x20000EB")]
public abstract class BaseField : BindableElement, INotifyValueChanged<TValueType>, IEditableElement
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000EC")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000488")]
		private UxmlStringAttributeDescription m_Label; //Field offset: 0x0

		[Address(RVA = "0x11EA7D0", Offset = "0x11E9BD0", Length = "0xCC")]
		[Token(Token = "0x6000731")]
		public UxmlTraits() { }

		[Address(RVA = "0x11E7A50", Offset = "0x11E6E50", Length = "0x18F")]
		[Token(Token = "0x6000732")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000467")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static readonly BindingId valueProperty; //Field offset: 0x0
	[Token(Token = "0x4000476")]
	private static CustomStyleProperty<Single> s_LabelBaseMinWidthProperty; //Field offset: 0x0
	[Token(Token = "0x4000475")]
	private static CustomStyleProperty<Single> s_LabelExtraPaddingProperty; //Field offset: 0x0
	[Token(Token = "0x4000474")]
	private static CustomStyleProperty<Single> s_LabelWidthRatioProperty; //Field offset: 0x0
	[Token(Token = "0x4000473")]
	protected private static readonly PropertyName serializedPropertyCopyName; //Field offset: 0x0
	[Token(Token = "0x4000471")]
	private static readonly string inspectorFieldUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000470")]
	public static readonly string alignedFieldUssClassName; //Field offset: 0x0
	[Token(Token = "0x400046F")]
	public static readonly string mixedValueLabelUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000472")]
	protected private static readonly string mixedValueString; //Field offset: 0x0
	[Token(Token = "0x400046D")]
	public static readonly string noLabelVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x400046C")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x400046B")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x400046A")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000469")]
	internal static readonly BindingId showMixedValueProperty; //Field offset: 0x0
	[Token(Token = "0x4000468")]
	internal static readonly BindingId labelProperty; //Field offset: 0x0
	[Token(Token = "0x400046E")]
	public static readonly string labelDraggerVariantUssClassName; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000480")]
	private Label <labelElement>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000485")]
	private VisualElement m_CachedInspectorElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000484")]
	private VisualElement m_CachedContextWidthElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000483")]
	private bool m_SkipValidation; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000482")]
	private Label m_MixedValueLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000481")]
	private bool m_ShowMixedValue; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047F")]
	private DispatchMode <dispatchMode>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000477")]
	private float m_LabelWidthRatio; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400047D")]
	private TValueType m_Value; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047C")]
	private Action viewDataRestored; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047B")]
	internal Action<Expression> expressionEvaluated; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047A")]
	private VisualElement m_VisualInput; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000479")]
	private float m_LabelBaseMinWidth; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000478")]
	private float m_LabelExtraPadding; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000486")]
	private Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047E")]
	private Func<TValueType, TValueType> onValidateValue; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000487")]
	private Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x14000013")]
	internal event Func<TValueType, TValueType> onValidateValue
	{
		[Address(RVA = "0x16654D0", Offset = "0x16648D0", Length = "0xC2")]
		[CompilerGenerated]
		[Token(Token = "0x600070E")]
		internal add { } //Length: 194
		[Address(RVA = "0x1665B80", Offset = "0x1664F80", Length = "0xC2")]
		[CompilerGenerated]
		[Token(Token = "0x600070F")]
		internal remove { } //Length: 194
	}

	[Token(Token = "0x14000012")]
	internal event Action viewDataRestored
	{
		[Address(RVA = "0x16655A0", Offset = "0x16649A0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000708")]
		internal add { } //Length: 162
		[Address(RVA = "0x1665DD0", Offset = "0x16651D0", Length = "0xA2")]
		[CompilerGenerated]
		[Token(Token = "0x6000709")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x17000114")]
	override bool canSwitchToMixedValue
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600071A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700010F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal DispatchMode dispatchMode
	{
		[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000710")]
		internal get { } //Length: 7
		[Address(RVA = "0x1665E80", Offset = "0x1665280", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000711")]
		internal set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x17000112")]
	public override string label
	{
		[Address(RVA = "0x1665740", Offset = "0x1664B40", Length = "0x2D")]
		[Token(Token = "0x6000716")]
		 get { } //Length: 45
		[Address(RVA = "0x1666150", Offset = "0x1665550", Length = "0x260")]
		[Token(Token = "0x6000717")]
		 set { } //Length: 608
	}

	[Token(Token = "0x17000111")]
	public private override Label labelElement
	{
		[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000714")]
		 get { } //Length: 8
		[Address(RVA = "0x1665EA0", Offset = "0x16652A0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000715")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000115")]
	protected Label mixedValueLabel
	{
		[Address(RVA = "0x1665960", Offset = "0x1664D60", Length = "0x1B3")]
		[Token(Token = "0x600071B")]
		 get { } //Length: 435
	}

	[Token(Token = "0x1700010E")]
	protected TValueType rawValue
	{
		[Address(RVA = "0x1665B40", Offset = "0x1664F40", Length = "0xA")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 10
		[Address(RVA = "0x16663E0", Offset = "0x16657E0", Length = "0x7")]
		[Token(Token = "0x600070D")]
		 set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x17000113")]
	public override bool showMixedValue
	{
		[Address(RVA = "0x1665B50", Offset = "0x1664F50", Length = "0x8")]
		[Token(Token = "0x6000718")]
		 get { } //Length: 8
		[Address(RVA = "0x16663F0", Offset = "0x16657F0", Length = "0xDA")]
		[Token(Token = "0x6000719")]
		 set { } //Length: 218
	}

	[Token(Token = "0x17000117")]
	private override Action UnityEngine.UIElements.IEditableElement.editingEnded
	{
		[Address(RVA = "0x1662BD0", Offset = "0x1661FD0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600071D")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000116")]
	private override Action UnityEngine.UIElements.IEditableElement.editingStarted
	{
		[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600071C")]
		private get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000110")]
	public override TValueType value
	{
		[Address(RVA = "0x1665B40", Offset = "0x1664F40", Length = "0xA")]
		[Token(Token = "0x6000712")]
		 get { } //Length: 10
		[Address(RVA = "0x1666910", Offset = "0x1665D10", Length = "0x2BB")]
		[Token(Token = "0x6000713")]
		 set { } //Length: 699
	}

	[Token(Token = "0x1700010D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement visualInput
	{
		[Address(RVA = "0x1665B70", Offset = "0x1664F70", Length = "0xA")]
		[Token(Token = "0x600070A")]
		internal get { } //Length: 10
		[Address(RVA = "0x1666BD0", Offset = "0x1665FD0", Length = "0x192")]
		[Token(Token = "0x600070B")]
		internal set { } //Length: 402
	}

	[Address(RVA = "0x1662EC0", Offset = "0x16622C0", Length = "0xF07")]
	[Token(Token = "0x6000730")]
	private static BaseField`1() { }

	[Address(RVA = "0x1664CE0", Offset = "0x16640E0", Length = "0x5B")]
	[Token(Token = "0x600071F")]
	protected BaseField`1(string label, VisualElement visualInput) { }

	[Address(RVA = "0x16650D0", Offset = "0x16644D0", Length = "0x321")]
	[Token(Token = "0x600071E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal BaseField`1(string label) { }

	[Address(RVA = "0x16654D0", Offset = "0x16648D0", Length = "0xC2")]
	[CompilerGenerated]
	[Token(Token = "0x600070E")]
	internal void add_onValidateValue(Func<TValueType, TValueType> value) { }

	[Address(RVA = "0x16655A0", Offset = "0x16649A0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000708")]
	internal void add_viewDataRestored(Action value) { }

	[Address(RVA = "0x1660530", Offset = "0x165F930", Length = "0x464")]
	[Token(Token = "0x6000729")]
	private void AlignLabel() { }

	[Address(RVA = "0x1660E10", Offset = "0x1660210", Length = "0x9B")]
	[Token(Token = "0x600072A")]
	private Rect ComputeTooltipRect() { }

	[Address(RVA = "0x1660FC0", Offset = "0x16603C0", Length = "0x62")]
	[Token(Token = "0x6000726")]
	internal void EndEditing(EventBase e) { }

	[Address(RVA = "0x16610C0", Offset = "0x16604C0", Length = "0x5D")]
	[Token(Token = "0x6000720")]
	internal override bool EqualsCurrentValue(TValueType value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600071A")]
	override bool get_canSwitchToMixedValue() { }

	[Address(RVA = "0x1665700", Offset = "0x1664B00", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000710")]
	internal DispatchMode get_dispatchMode() { }

	[Address(RVA = "0x1665740", Offset = "0x1664B40", Length = "0x2D")]
	[Token(Token = "0x6000716")]
	public override string get_label() { }

	[Address(RVA = "0x1665730", Offset = "0x1664B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000714")]
	public override Label get_labelElement() { }

	[Address(RVA = "0x1665960", Offset = "0x1664D60", Length = "0x1B3")]
	[Token(Token = "0x600071B")]
	protected Label get_mixedValueLabel() { }

	[Address(RVA = "0x1665B40", Offset = "0x1664F40", Length = "0xA")]
	[Token(Token = "0x600070C")]
	protected TValueType get_rawValue() { }

	[Address(RVA = "0x1665B50", Offset = "0x1664F50", Length = "0x8")]
	[Token(Token = "0x6000718")]
	public override bool get_showMixedValue() { }

	[Address(RVA = "0x1665B40", Offset = "0x1664F40", Length = "0xA")]
	[Token(Token = "0x6000712")]
	public override TValueType get_value() { }

	[Address(RVA = "0x1665B70", Offset = "0x1664F70", Length = "0xA")]
	[Token(Token = "0x600070A")]
	internal VisualElement get_visualInput() { }

	[Address(RVA = "0x16612A0", Offset = "0x16606A0", Length = "0x17C")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(TooltipEvent)})]
	[Token(Token = "0x600072C")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x1661760", Offset = "0x1660B60", Length = "0x33D")]
	[Token(Token = "0x6000721")]
	private void OnAttachToPanel(AttachToPanelEvent e) { }

	[Address(RVA = "0x1661AA0", Offset = "0x1660EA0", Length = "0x3AA")]
	[Token(Token = "0x6000727")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x1662200", Offset = "0x1661600", Length = "0x3A")]
	[Token(Token = "0x6000722")]
	private void OnDetachFromPanel(DetachFromPanelEvent e) { }

	[Address(RVA = "0x1662280", Offset = "0x1661680", Length = "0x17")]
	[Token(Token = "0x6000728")]
	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x16622C0", Offset = "0x16616C0", Length = "0x20F")]
	[Token(Token = "0x600072F")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1662890", Offset = "0x1661C90", Length = "0xF6")]
	[Token(Token = "0x6000723")]
	internal override void RegisterEditingCallbacks() { }

	[Address(RVA = "0x1665B80", Offset = "0x1664F80", Length = "0xC2")]
	[CompilerGenerated]
	[Token(Token = "0x600070F")]
	internal void remove_onValidateValue(Func<TValueType, TValueType> value) { }

	[Address(RVA = "0x1665DD0", Offset = "0x16651D0", Length = "0xA2")]
	[CompilerGenerated]
	[Token(Token = "0x6000709")]
	internal void remove_viewDataRestored(Action value) { }

	[Address(RVA = "0x1665E80", Offset = "0x1665280", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000711")]
	internal void set_dispatchMode(DispatchMode value) { }

	[Address(RVA = "0x1666150", Offset = "0x1665550", Length = "0x260")]
	[Token(Token = "0x6000717")]
	public void set_label(string value) { }

	[Address(RVA = "0x1665EA0", Offset = "0x16652A0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000715")]
	private void set_labelElement(Label value) { }

	[Address(RVA = "0x16663E0", Offset = "0x16657E0", Length = "0x7")]
	[Token(Token = "0x600070D")]
	protected void set_rawValue(TValueType value) { }

	[Address(RVA = "0x16663F0", Offset = "0x16657F0", Length = "0xDA")]
	[Token(Token = "0x6000719")]
	public override void set_showMixedValue(bool value) { }

	[Address(RVA = "0x1666910", Offset = "0x1665D10", Length = "0x2BB")]
	[Token(Token = "0x6000713")]
	public override void set_value(TValueType value) { }

	[Address(RVA = "0x1666BD0", Offset = "0x1665FD0", Length = "0x192")]
	[Token(Token = "0x600070B")]
	internal void set_visualInput(VisualElement value) { }

	[Address(RVA = "0x1662A80", Offset = "0x1661E80", Length = "0x88")]
	[Token(Token = "0x600072E")]
	public override void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x1662B70", Offset = "0x1661F70", Length = "0x5F")]
	[Token(Token = "0x6000725")]
	internal void StartEditing(EventBase e) { }

	[Address(RVA = "0x1662BD0", Offset = "0x1661FD0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600071D")]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600071C")]
	private override Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	[Address(RVA = "0x1662CF0", Offset = "0x16620F0", Length = "0xF6")]
	[Token(Token = "0x6000724")]
	internal override void UnregisterEditingCallbacks() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x600072D")]
	protected override void UpdateMixedValueContent() { }

	[Address(RVA = "0x1662DF0", Offset = "0x16621F0", Length = "0x30")]
	[Token(Token = "0x600072B")]
	internal TValueType ValidatedValue(TValueType value) { }

}

