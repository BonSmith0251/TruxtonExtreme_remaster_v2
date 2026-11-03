namespace UnityEngine.UI;

[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
[Token(Token = "0x2000046")]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	[Address(RVA = "0x3436280", Offset = "0x3435680", Length = "0xE")]
	[Token(Token = "0x600029D")]
	protected HorizontalLayoutGroup() { }

	[Address(RVA = "0x3436220", Offset = "0x3435620", Length = "0x25")]
	[Token(Token = "0x600029E")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x3436250", Offset = "0x3435650", Length = "0x10")]
	[Token(Token = "0x600029F")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x3436260", Offset = "0x3435660", Length = "0xD")]
	[Token(Token = "0x60002A0")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x3436270", Offset = "0x3435670", Length = "0x10")]
	[Token(Token = "0x60002A1")]
	public virtual void SetLayoutVertical() { }

}

