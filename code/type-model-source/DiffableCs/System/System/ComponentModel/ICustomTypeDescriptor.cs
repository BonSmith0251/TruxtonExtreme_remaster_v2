namespace System.ComponentModel;

[Token(Token = "0x200017B")]
public interface ICustomTypeDescriptor
{

	[Token(Token = "0x6000940")]
	public AttributeCollection GetAttributes() { }

	[Token(Token = "0x6000941")]
	public string GetClassName() { }

	[Token(Token = "0x6000942")]
	public string GetComponentName() { }

	[Token(Token = "0x6000943")]
	public TypeConverter GetConverter() { }

	[Token(Token = "0x6000944")]
	public EventDescriptor GetDefaultEvent() { }

	[Token(Token = "0x6000945")]
	public PropertyDescriptor GetDefaultProperty() { }

	[Token(Token = "0x6000946")]
	public object GetEditor(Type editorBaseType) { }

	[Token(Token = "0x6000947")]
	public EventDescriptorCollection GetEvents() { }

	[Token(Token = "0x6000948")]
	public EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	[Token(Token = "0x6000949")]
	public PropertyDescriptorCollection GetProperties() { }

	[Token(Token = "0x600094A")]
	public PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	[Token(Token = "0x600094B")]
	public object GetPropertyOwner(PropertyDescriptor pd) { }

}

