namespace UnityEngine.UIElements;

[Token(Token = "0x200005F")]
public class ListViewController : BaseListViewController
{

	[Token(Token = "0x1700006E")]
	protected ListView listView
	{
		[Address(RVA = "0x32248C0", Offset = "0x3223CC0", Length = "0x72")]
		[Token(Token = "0x600032B")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000330")]
	public ListViewController() { }

	[Address(RVA = "0x32244D0", Offset = "0x32238D0", Length = "0x24D")]
	[Token(Token = "0x600032D")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x3224720", Offset = "0x3223B20", Length = "0x43")]
	[Token(Token = "0x600032F")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x32248C0", Offset = "0x3223CC0", Length = "0x72")]
	[Token(Token = "0x600032B")]
	protected ListView get_listView() { }

	[Address(RVA = "0x3224770", Offset = "0x3223B70", Length = "0xF0")]
	[Token(Token = "0x600032C")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x3224870", Offset = "0x3223C70", Length = "0x4C")]
	[Token(Token = "0x600032E")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

