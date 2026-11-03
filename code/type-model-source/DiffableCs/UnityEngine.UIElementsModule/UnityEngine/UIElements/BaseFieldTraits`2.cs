namespace UnityEngine.UIElements;

[Obsolete("BaseFieldTraits<TValueType, TValueUxmlAttributeType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20000ED")]
public class BaseFieldTraits : UxmlTraits<TValueType>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000489")]
	private TValueUxmlAttributeType m_Value; //Field offset: 0x0

	[Address(RVA = "0x1660320", Offset = "0x165F720", Length = "0xA2")]
	[Token(Token = "0x6000734")]
	public BaseFieldTraits`2() { }

	[Address(RVA = "0x165F320", Offset = "0x165E720", Length = "0x20C")]
	[Token(Token = "0x6000733")]
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

