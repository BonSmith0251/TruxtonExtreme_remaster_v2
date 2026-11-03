namespace UnityEngine.UIElements;

[Token(Token = "0x2000063")]
public abstract class TreeViewController : BaseTreeViewController
{

	[Token(Token = "0x17000071")]
	protected TreeView treeView
	{
		[Address(RVA = "0x3228CF0", Offset = "0x32280F0", Length = "0x72")]
		[Token(Token = "0x6000350")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x3228CA0", Offset = "0x32280A0", Length = "0x49")]
	[Token(Token = "0x6000355")]
	protected TreeViewController() { }

	[Address(RVA = "0x3228940", Offset = "0x3227D40", Length = "0x1B8")]
	[Token(Token = "0x6000352")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x3228B00", Offset = "0x3227F00", Length = "0x43")]
	[Token(Token = "0x6000354")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x3228CF0", Offset = "0x32280F0", Length = "0x72")]
	[Token(Token = "0x6000350")]
	protected TreeView get_treeView() { }

	[Address(RVA = "0x3228B50", Offset = "0x3227F50", Length = "0xF0")]
	[Token(Token = "0x6000351")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x3228C50", Offset = "0x3228050", Length = "0x4C")]
	[Token(Token = "0x6000353")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

