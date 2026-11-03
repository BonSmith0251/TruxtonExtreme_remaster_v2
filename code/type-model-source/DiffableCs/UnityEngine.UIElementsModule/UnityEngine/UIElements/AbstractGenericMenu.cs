namespace UnityEngine.UIElements;

[Token(Token = "0x20000D5")]
public abstract class AbstractGenericMenu
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000693")]
	protected AbstractGenericMenu() { }

	[Token(Token = "0x600068F")]
	public abstract void AddItem(string itemName, bool isChecked, Action action) { }

	[Token(Token = "0x6000690")]
	public abstract void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	[Token(Token = "0x6000691")]
	public abstract void AddSeparator(string path) { }

	[Token(Token = "0x6000692")]
	public abstract void DropDown(Rect position, VisualElement targetElement, DropdownMenuSizeMode dropdownMenuSizeMode = 0) { }

}

