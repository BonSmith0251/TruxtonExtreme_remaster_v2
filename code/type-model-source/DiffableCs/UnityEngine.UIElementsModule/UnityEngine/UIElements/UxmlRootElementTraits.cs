namespace UnityEngine.UIElements;

[Obsolete("UxmlRootElementTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E0")]
public class UxmlRootElementTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400106A")]
	protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400106B")]
	private UxmlStringAttributeDescription m_Class; //Field offset: 0x20

	[Address(RVA = "0x32C5E60", Offset = "0x32C5260", Length = "0xE3")]
	[Token(Token = "0x600250C")]
	public UxmlRootElementTraits() { }

}

