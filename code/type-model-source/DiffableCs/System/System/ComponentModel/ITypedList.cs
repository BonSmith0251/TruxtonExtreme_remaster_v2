namespace System.ComponentModel;

[Token(Token = "0x200017F")]
public interface ITypedList
{

	[Token(Token = "0x6000950")]
	public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) { }

	[Token(Token = "0x600094F")]
	public string GetListName(PropertyDescriptor[] listAccessors) { }

}

