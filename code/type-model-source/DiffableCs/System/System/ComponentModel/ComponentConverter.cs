namespace System.ComponentModel;

[Token(Token = "0x20001AB")]
public class ComponentConverter : ReferenceConverter
{

	[Address(RVA = "0x265C420", Offset = "0x265B820", Length = "0x65")]
	[Token(Token = "0x6000A48")]
	public ComponentConverter(Type type) { }

	[Address(RVA = "0x265C3C0", Offset = "0x265B7C0", Length = "0x59")]
	[Token(Token = "0x6000A49")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A4A")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

