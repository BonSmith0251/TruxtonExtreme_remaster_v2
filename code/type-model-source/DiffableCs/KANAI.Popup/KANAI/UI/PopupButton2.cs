namespace KANAI.UI;

[Token(Token = "0x2000004")]
public class PopupButton2 : ButtonBase2
{

	[Address(RVA = "0x1E078F0", Offset = "0x1E06CF0", Length = "0x7")]
	[Token(Token = "0x6000006")]
	public PopupButton2() { }

	[Address(RVA = "0x1E07610", Offset = "0x1E06A10", Length = "0x149")]
	[Token(Token = "0x6000005")]
	protected virtual void RefreshImage() { }

	[Address(RVA = "0x1E07760", Offset = "0x1E06B60", Length = "0xF5")]
	[Token(Token = "0x6000003")]
	public void SetInformation(PopupButtonInfo infos) { }

	[Address(RVA = "0x1E07860", Offset = "0x1E06C60", Length = "0x82")]
	[Token(Token = "0x6000004")]
	public void SetText(string iText) { }

}

