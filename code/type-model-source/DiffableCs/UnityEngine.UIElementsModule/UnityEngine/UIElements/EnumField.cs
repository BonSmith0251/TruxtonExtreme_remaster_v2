namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x20000C9")]
public class EnumField : BaseField<Enum>
{
	[CompilerGenerated]
	[Token(Token = "0x20000CC")]
	private sealed class <>c
	{
		[Token(Token = "0x40003FB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003FC")]
		public static EventCallback<MouseDownEvent> <>9__31_0; //Field offset: 0x8

		[Address(RVA = "0x3346370", Offset = "0x3345770", Length = "0x67")]
		[Token(Token = "0x6000666")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000667")]
		public <>c() { }

		[Address(RVA = "0x3346110", Offset = "0x3345510", Length = "0x4D")]
		[Token(Token = "0x6000668")]
		internal void <.ctor>b__31_0(MouseDownEvent e) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CA")]
	internal class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{

		[Address(RVA = "0x3346C60", Offset = "0x3346060", Length = "0x39")]
		[Token(Token = "0x6000663")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000CB")]
	internal class UxmlTraits : UxmlTraits<Enum>
	{
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40003F8")]
		private UxmlTypeAttributeDescription<Enum> m_Type; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40003F9")]
		private UxmlStringAttributeDescription m_Value; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40003FA")]
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues; //Field offset: 0xA8

		[Address(RVA = "0x334B160", Offset = "0x334A560", Length = "0xCB")]
		[Token(Token = "0x6000665")]
		public UxmlTraits() { }

		[Address(RVA = "0x3347EE0", Offset = "0x33472E0", Length = "0x3A1")]
		[Token(Token = "0x6000664")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40003EC")]
	internal static readonly BindingId textProperty; //Field offset: 0x0
	[Token(Token = "0x40003F3")]
	public static readonly string ussClassName; //Field offset: 0x98
	[Token(Token = "0x40003F4")]
	public static readonly string textUssClassName; //Field offset: 0xA0
	[Token(Token = "0x40003F5")]
	public static readonly string arrowUssClassName; //Field offset: 0xA8
	[Token(Token = "0x40003F6")]
	public static readonly string labelUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40003F7")]
	public static readonly string inputUssClassName; //Field offset: 0xB8
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x40003ED")]
	private Type m_EnumType; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x40003EE")]
	private bool m_IncludeObsoleteValues; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x40003EF")]
	private TextElement m_TextElement; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x40003F0")]
	private VisualElement m_ArrowElement; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x40003F1")]
	private EnumData m_EnumData; //Field offset: 0x378
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x40003F2")]
	internal Func<AbstractGenericMenu> createMenuCallback; //Field offset: 0x3B8

	[Token(Token = "0x170000EE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool includeObsoleteValues
	{
		[Address(RVA = "0x333D1C0", Offset = "0x333C5C0", Length = "0x8")]
		[Token(Token = "0x600064F")]
		internal get { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000EF")]
	public string text
	{
		[Address(RVA = "0x333D1D0", Offset = "0x333C5D0", Length = "0x2D")]
		[Token(Token = "0x6000650")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x333CB70", Offset = "0x333BF70", Length = "0x2F0")]
	[Token(Token = "0x6000661")]
	private static EnumField() { }

	[Address(RVA = "0x333D1B0", Offset = "0x333C5B0", Length = "0xD")]
	[Token(Token = "0x6000652")]
	public EnumField() { }

	[Address(RVA = "0x333CE60", Offset = "0x333C260", Length = "0x347")]
	[Token(Token = "0x6000653")]
	public EnumField(string label, Enum defaultValue = null) { }

	[Address(RVA = "0x333BFC0", Offset = "0x333B3C0", Length = "0x5D")]
	[CompilerGenerated]
	[Token(Token = "0x6000662")]
	private void <ShowMenu>b__42_0(object contentView) { }

	[Address(RVA = "0x333BFC0", Offset = "0x333B3C0", Length = "0x5D")]
	[Token(Token = "0x600065F")]
	private void ChangeValueFromMenu(object menuItem) { }

	[Address(RVA = "0x333C020", Offset = "0x333B420", Length = "0x84")]
	[Token(Token = "0x600065B")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x333D1C0", Offset = "0x333C5C0", Length = "0x8")]
	[Token(Token = "0x600064F")]
	internal bool get_includeObsoleteValues() { }

	[Address(RVA = "0x333D1D0", Offset = "0x333C5D0", Length = "0x2D")]
	[Token(Token = "0x6000650")]
	public string get_text() { }

	[Address(RVA = "0x333C0B0", Offset = "0x333B4B0", Length = "0xB")]
	[Token(Token = "0x6000654")]
	public void Init(Enum defaultValue) { }

	[Address(RVA = "0x333C0C0", Offset = "0x333B4C0", Length = "0x107")]
	[Token(Token = "0x6000655")]
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	[Address(RVA = "0x333C1D0", Offset = "0x333B5D0", Length = "0x1D9")]
	[Token(Token = "0x6000651")]
	private void Initialize(Enum defaultValue) { }

	[Address(RVA = "0x333C3B0", Offset = "0x333B7B0", Length = "0x29")]
	[Token(Token = "0x600065D")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	[Address(RVA = "0x333C3E0", Offset = "0x333B7E0", Length = "0x48")]
	[Token(Token = "0x6000659")]
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	[Address(RVA = "0x333C430", Offset = "0x333B830", Length = "0x7D")]
	[Token(Token = "0x600065A")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x333C4B0", Offset = "0x333B8B0", Length = "0x11A")]
	[Token(Token = "0x6000656")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void PopulateDataFromType(Type enumType) { }

	[Address(RVA = "0x7D3280", Offset = "0x7D2680", Length = "0x167")]
	[Token(Token = "0x600065C")]
	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	[Address(RVA = "0x333C5D0", Offset = "0x333B9D0", Length = "0xBB")]
	[Token(Token = "0x6000657")]
	public virtual void SetValueWithoutNotify(Enum newValue) { }

	[Address(RVA = "0x333C690", Offset = "0x333BA90", Length = "0x264")]
	[Token(Token = "0x600065E")]
	internal void ShowMenu() { }

	[Address(RVA = "0x333C900", Offset = "0x333BD00", Length = "0x16B")]
	[Token(Token = "0x6000660")]
	protected virtual void UpdateMixedValueContent() { }

	[Address(RVA = "0x333CA70", Offset = "0x333BE70", Length = "0xF2")]
	[Token(Token = "0x6000658")]
	private void UpdateValueLabel(Enum value) { }

}

