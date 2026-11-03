namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Obsolete("TextValueFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x2000164")]
public class TextValueFieldTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070A")]
	private UxmlStringAttributeDescription m_PlaceholderText; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070B")]
	private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070C")]
	private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070D")]
	private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0

	[Address(RVA = "0x10749E0", Offset = "0x1073DE0", Length = "0xEDC")]
	[Token(Token = "0x6000ADD")]
	public TextValueFieldTraits`2() { }

	[Address(RVA = "0x1073740", Offset = "0x1072B40", Length = "0x2F2")]
	[Token(Token = "0x6000ADC")]
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

