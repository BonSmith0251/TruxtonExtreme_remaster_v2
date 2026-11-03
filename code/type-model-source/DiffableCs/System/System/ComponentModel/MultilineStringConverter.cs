namespace System.ComponentModel;

[Token(Token = "0x2000189")]
public class MultilineStringConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600097A")]
	public MultilineStringConverter() { }

	[Address(RVA = "0x2665DD0", Offset = "0x26651D0", Length = "0x14B")]
	[Token(Token = "0x6000977")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000978")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000979")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

