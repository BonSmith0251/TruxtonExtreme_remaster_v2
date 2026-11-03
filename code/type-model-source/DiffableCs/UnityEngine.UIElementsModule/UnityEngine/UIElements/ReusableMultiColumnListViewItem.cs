namespace UnityEngine.UIElements;

[Token(Token = "0x200006D")]
internal class ReusableMultiColumnListViewItem : ReusableListViewItem
{

	[Token(Token = "0x17000084")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003C8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x32274F0", Offset = "0x32268F0", Length = "0x49")]
	[Token(Token = "0x60003CB")]
	public ReusableMultiColumnListViewItem() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003C8")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60003C9")]
	public virtual void Init(VisualElement item) { }

	[Address(RVA = "0x3227280", Offset = "0x3226680", Length = "0x26A")]
	[Token(Token = "0x60003CA")]
	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

}

