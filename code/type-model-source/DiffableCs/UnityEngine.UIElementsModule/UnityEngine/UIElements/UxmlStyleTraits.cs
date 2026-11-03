namespace UnityEngine.UIElements;

[Obsolete("UxmlStyleTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004E2")]
public class UxmlStyleTraits : UxmlTraits
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400106C")]
	private UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400106D")]
	private UxmlStringAttributeDescription m_Path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400106E")]
	private UxmlStringAttributeDescription m_Src; //Field offset: 0x28

	[Address(RVA = "0x32C6440", Offset = "0x32C5840", Length = "0x135")]
	[Token(Token = "0x6002511")]
	public UxmlStyleTraits() { }

}

