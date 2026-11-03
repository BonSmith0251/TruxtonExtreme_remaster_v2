namespace UnityEngine.UIElements;

[Token(Token = "0x200006E")]
internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
{

	[Token(Token = "0x17000085")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003CC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x32277A0", Offset = "0x3226BA0", Length = "0x127")]
	[Token(Token = "0x60003CF")]
	public ReusableMultiColumnTreeViewItem() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003CC")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003CD")]
	public virtual void Init(VisualElement item) { }

	[Address(RVA = "0x3227540", Offset = "0x3226940", Length = "0x259")]
	[Token(Token = "0x60003CE")]
	public void Init(VisualElement container, Columns columns) { }

}

