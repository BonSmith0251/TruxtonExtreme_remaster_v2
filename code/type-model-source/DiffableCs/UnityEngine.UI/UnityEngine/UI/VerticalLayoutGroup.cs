namespace UnityEngine.UI;

[AddComponentMenu("Layout/Vertical Layout Group", 151)]
[Token(Token = "0x2000054")]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
{

	[Address(RVA = "0x3436280", Offset = "0x3435680", Length = "0xE")]
	[Token(Token = "0x6000339")]
	protected VerticalLayoutGroup() { }

	[Address(RVA = "0x344A650", Offset = "0x3449A50", Length = "0x25")]
	[Token(Token = "0x600033A")]
	public virtual void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x344A680", Offset = "0x3449A80", Length = "0x10")]
	[Token(Token = "0x600033B")]
	public virtual void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x344A690", Offset = "0x3449A90", Length = "0xD")]
	[Token(Token = "0x600033C")]
	public virtual void SetLayoutHorizontal() { }

	[Address(RVA = "0x344A6A0", Offset = "0x3449AA0", Length = "0x10")]
	[Token(Token = "0x600033D")]
	public virtual void SetLayoutVertical() { }

}

