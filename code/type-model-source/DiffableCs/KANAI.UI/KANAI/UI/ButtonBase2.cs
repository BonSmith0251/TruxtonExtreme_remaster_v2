namespace KANAI.UI;

[AddComponentMenu("UI/ButtonBase2", 30)]
[Token(Token = "0x200000B")]
public class ButtonBase2 : ButtonBase
{
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	protected Image _iconImage; //Field offset: 0x160

	[Token(Token = "0x17000009")]
	public Image IconImage
	{
		[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
		[Token(Token = "0x600002C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1E15B30", Offset = "0x1E14F30", Length = "0x7")]
	[Token(Token = "0x600002D")]
	public ButtonBase2() { }

	[Address(RVA = "0x1D4E410", Offset = "0x1D4D810", Length = "0x8")]
	[Token(Token = "0x600002C")]
	public Image get_IconImage() { }

}

