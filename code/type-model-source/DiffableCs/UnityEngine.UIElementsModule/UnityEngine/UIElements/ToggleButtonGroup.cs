namespace UnityEngine.UIElements;

[Token(Token = "0x2000168")]
[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Button)})]
public class ToggleButtonGroup : BaseField<ToggleButtonGroupState>
{
	[Token(Token = "0x200016B")]
	private class ButtonGroupContainer : VisualElement
	{
		[FieldOffset(Offset = "0x2C8")]
		[Token(Token = "0x4000729")]
		private readonly ToggleButtonGroup m_Group; //Field offset: 0x2C8

		[Address(RVA = "0x33AC620", Offset = "0x33ABA20", Length = "0x6B")]
		[Token(Token = "0x6000AFA")]
		public ButtonGroupContainer(ToggleButtonGroup group) { }

		[Address(RVA = "0x33AC5C0", Offset = "0x33AB9C0", Length = "0x21")]
		[Token(Token = "0x6000AFB")]
		internal virtual void OnChildAdded(VisualElement ve) { }

		[Address(RVA = "0x33AC5F0", Offset = "0x33AB9F0", Length = "0x21")]
		[Token(Token = "0x6000AFC")]
		internal virtual void OnChildRemoved(VisualElement ve) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000169")]
	internal class UxmlFactory : UxmlFactory<ToggleButtonGroup, UxmlTraits>
	{

		[Address(RVA = "0x33C3C60", Offset = "0x33C3060", Length = "0x39")]
		[Token(Token = "0x6000AF7")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200016A")]
	internal class UxmlTraits : UxmlTraits<ToggleButtonGroupState>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000727")]
		private UxmlBoolAttributeDescription m_IsMultipleSelection; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000728")]
		private UxmlBoolAttributeDescription m_AllowEmptySelection; //Field offset: 0xA0

		[Address(RVA = "0x33C4C60", Offset = "0x33C4060", Length = "0xFF")]
		[Token(Token = "0x6000AF9")]
		public UxmlTraits() { }

		[Address(RVA = "0x33C44F0", Offset = "0x33C38F0", Length = "0x1A2")]
		[Token(Token = "0x6000AF8")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000716")]
	private static readonly string k_MaxToggleButtonGroupMessage; //Field offset: 0x0
	[Token(Token = "0x4000717")]
	internal static readonly BindingId isMultipleSelectionProperty; //Field offset: 0x8
	[Token(Token = "0x4000718")]
	internal static readonly BindingId allowEmptySelectionProperty; //Field offset: 0xA0
	[Token(Token = "0x4000719")]
	public static readonly string ussClassName; //Field offset: 0x138
	[Token(Token = "0x400071A")]
	public static readonly string containerUssClassName; //Field offset: 0x140
	[Token(Token = "0x400071B")]
	public static readonly string buttonGroupClassName; //Field offset: 0x148
	[Token(Token = "0x400071C")]
	public static readonly string buttonClassName; //Field offset: 0x150
	[Token(Token = "0x400071D")]
	public static readonly string buttonLeftClassName; //Field offset: 0x158
	[Token(Token = "0x400071E")]
	public static readonly string buttonMidClassName; //Field offset: 0x160
	[Token(Token = "0x400071F")]
	public static readonly string buttonRightClassName; //Field offset: 0x168
	[Token(Token = "0x4000720")]
	public static readonly string buttonStandaloneClassName; //Field offset: 0x170
	[Token(Token = "0x4000721")]
	public static readonly string emptyStateLabelClassName; //Field offset: 0x178
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000722")]
	private VisualElement m_ButtonGroupContainer; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000723")]
	private List<Button> m_Buttons; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000724")]
	private VisualElement m_EmptyLabel; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000725")]
	private bool m_IsMultipleSelection; //Field offset: 0x378
	[FieldOffset(Offset = "0x379")]
	[Token(Token = "0x4000726")]
	private bool m_AllowEmptySelection; //Field offset: 0x379

	[CreateProperty]
	[Token(Token = "0x170001E0")]
	public bool allowEmptySelection
	{
		[Address(RVA = "0x33BB830", Offset = "0x33BAC30", Length = "0x8")]
		[Token(Token = "0x6000AE8")]
		 get { } //Length: 8
		[Address(RVA = "0x33BB850", Offset = "0x33BAC50", Length = "0x25F")]
		[Token(Token = "0x6000AE9")]
		 set { } //Length: 607
	}

	[Token(Token = "0x170001E1")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x33974A0", Offset = "0x33968A0", Length = "0x12")]
		[Token(Token = "0x6000AED")]
		 get { } //Length: 18
	}

	[CreateProperty]
	[Token(Token = "0x170001DF")]
	public bool isMultipleSelection
	{
		[Address(RVA = "0x33BB840", Offset = "0x33BAC40", Length = "0x8")]
		[Token(Token = "0x6000AE6")]
		 get { } //Length: 8
		[Address(RVA = "0x33BBAB0", Offset = "0x33BAEB0", Length = "0x1DD")]
		[Token(Token = "0x6000AE7")]
		 set { } //Length: 477
	}

	[Address(RVA = "0x33BAF60", Offset = "0x33BA360", Length = "0x58C")]
	[Token(Token = "0x6000AF6")]
	private static ToggleButtonGroup() { }

	[Address(RVA = "0x33BB570", Offset = "0x33BA970", Length = "0x2BD")]
	[Token(Token = "0x6000AEC")]
	public ToggleButtonGroup(string label, ToggleButtonGroupState toggleButtonGroupState) { }

	[Address(RVA = "0x33BB4F0", Offset = "0x33BA8F0", Length = "0x33")]
	[Token(Token = "0x6000AEA")]
	public ToggleButtonGroup() { }

	[Address(RVA = "0x33BB530", Offset = "0x33BA930", Length = "0x31")]
	[Token(Token = "0x6000AEB")]
	public ToggleButtonGroup(string label) { }

	[Address(RVA = "0x33BB830", Offset = "0x33BAC30", Length = "0x8")]
	[Token(Token = "0x6000AE8")]
	public bool get_allowEmptySelection() { }

	[Address(RVA = "0x33974A0", Offset = "0x33968A0", Length = "0x12")]
	[Token(Token = "0x6000AED")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x33BB840", Offset = "0x33BAC40", Length = "0x8")]
	[Token(Token = "0x6000AE6")]
	public bool get_isMultipleSelection() { }

	[Address(RVA = "0x33B9B40", Offset = "0x33B8F40", Length = "0x441")]
	[Token(Token = "0x6000AF1")]
	private void OnButtonGroupContainerElementAdded(VisualElement ve) { }

	[Address(RVA = "0x33B9F90", Offset = "0x33B9390", Length = "0x402")]
	[Token(Token = "0x6000AF2")]
	private void OnButtonGroupContainerElementRemoved(VisualElement ve) { }

	[Address(RVA = "0x33BA3A0", Offset = "0x33B97A0", Length = "0x306")]
	[Token(Token = "0x6000AF4")]
	private void OnOptionChange(EventBase evt) { }

	[Address(RVA = "0x33BA6B0", Offset = "0x33B9AB0", Length = "0x6D")]
	[Token(Token = "0x6000AEE")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x33BB850", Offset = "0x33BAC50", Length = "0x25F")]
	[Token(Token = "0x6000AE9")]
	public void set_allowEmptySelection(bool value) { }

	[Address(RVA = "0x33BBAB0", Offset = "0x33BAEB0", Length = "0x1DD")]
	[Token(Token = "0x6000AE7")]
	public void set_isMultipleSelection(bool value) { }

	[Address(RVA = "0x33BA720", Offset = "0x33B9B20", Length = "0x1CD")]
	[Token(Token = "0x6000AF0")]
	public virtual void SetValueWithoutNotify(ToggleButtonGroupState newValue) { }

	[Address(RVA = "0x33BABF0", Offset = "0x33B9FF0", Length = "0x1C5")]
	[Token(Token = "0x6000AF5")]
	private void UpdateButtonsStyling() { }

	[Address(RVA = "0x33BA8F0", Offset = "0x33B9CF0", Length = "0x2F0")]
	[Token(Token = "0x6000AF3")]
	private void UpdateButtonStates(ToggleButtonGroupState options) { }

	[Address(RVA = "0x33BADC0", Offset = "0x33BA1C0", Length = "0x193")]
	[Token(Token = "0x6000AEF")]
	protected virtual void UpdateMixedValueContent() { }

}

