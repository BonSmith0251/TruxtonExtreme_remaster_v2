namespace System.ComponentModel;

[Token(Token = "0x20001A9")]
public class CollectionConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A3C")]
	public CollectionConverter() { }

	[Address(RVA = "0x265C260", Offset = "0x265B660", Length = "0x158")]
	[Token(Token = "0x6000A39")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000A3A")]
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A3B")]
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

