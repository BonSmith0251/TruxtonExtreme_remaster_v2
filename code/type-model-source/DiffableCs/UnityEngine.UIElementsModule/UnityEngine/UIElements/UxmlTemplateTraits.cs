namespace UnityEngine.UIElements;

[Obsolete("UxmlTemplateTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E4")]
public class UxmlTemplateTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400106F")]
	private UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001070")]
	private UxmlStringAttributeDescription m_Path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001071")]
	private UxmlStringAttributeDescription m_Src; //Field offset: 0x28

	[Address(RVA = "0x32C6670", Offset = "0x32C5A70", Length = "0x13C")]
	[Token(Token = "0x6002516")]
	public UxmlTemplateTraits() { }

}

