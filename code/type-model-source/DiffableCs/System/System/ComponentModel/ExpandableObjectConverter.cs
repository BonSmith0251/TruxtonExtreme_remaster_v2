namespace System.ComponentModel;

[Token(Token = "0x2000176")]
public class ExpandableObjectConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000914")]
	public ExpandableObjectConverter() { }

	[Address(RVA = "0x2662C80", Offset = "0x2662080", Length = "0x59")]
	[Token(Token = "0x6000915")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000916")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

