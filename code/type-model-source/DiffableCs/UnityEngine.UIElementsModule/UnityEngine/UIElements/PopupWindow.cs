namespace UnityEngine.UIElements;

[Token(Token = "0x200012E")]
public class PopupWindow : TextElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200012F")]
	internal class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits>
	{

		[Address(RVA = "0x33A7FC0", Offset = "0x33A73C0", Length = "0x39")]
		[Token(Token = "0x600095B")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000130")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x3392170", Offset = "0x3391570", Length = "0x7")]
		[Token(Token = "0x600095C")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40005DB")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x40005DC")]
	public static readonly string contentUssClassName; //Field offset: 0x8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x40005DA")]
	private VisualElement m_ContentContainer; //Field offset: 0x3D0

	[Token(Token = "0x17000195")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x333A690", Offset = "0x3339A90", Length = "0xA")]
		[Token(Token = "0x6000959")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x3395500", Offset = "0x3394900", Length = "0xBA")]
	[Token(Token = "0x600095A")]
	private static PopupWindow() { }

	[Address(RVA = "0x33955C0", Offset = "0x33949C0", Length = "0x145")]
	[Token(Token = "0x6000958")]
	public PopupWindow() { }

	[Address(RVA = "0x333A690", Offset = "0x3339A90", Length = "0xA")]
	[Token(Token = "0x6000959")]
	public virtual VisualElement get_contentContainer() { }

}

