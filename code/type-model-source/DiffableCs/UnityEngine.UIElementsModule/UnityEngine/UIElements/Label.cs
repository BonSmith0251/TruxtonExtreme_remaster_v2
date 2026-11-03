namespace UnityEngine.UIElements;

[Token(Token = "0x20000FC")]
public class Label : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FD")]
	internal class UxmlFactory : UxmlFactory<Label, UxmlTraits>
	{

		[Address(RVA = "0x33913A0", Offset = "0x33907A0", Length = "0x39")]
		[Token(Token = "0x60007D8")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x20000FE")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x3392170", Offset = "0x3391570", Length = "0x7")]
		[Token(Token = "0x60007D9")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40004DF")]
	public static readonly string ussClassName; //Field offset: 0x0

	[Address(RVA = "0x3385F80", Offset = "0x3385380", Length = "0x62")]
	[Token(Token = "0x60007D7")]
	private static Label() { }

	[Address(RVA = "0x3385FF0", Offset = "0x33853F0", Length = "0xAF")]
	[Token(Token = "0x60007D6")]
	public Label(string text) { }

	[Address(RVA = "0x33860A0", Offset = "0x33854A0", Length = "0x19")]
	[Token(Token = "0x60007D5")]
	public Label() { }

}

