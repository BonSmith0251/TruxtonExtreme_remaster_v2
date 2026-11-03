namespace System.ComponentModel;

[Token(Token = "0x200016A")]
public class DateTimeConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60008B7")]
	public DateTimeConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x60008B3")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x265D220", Offset = "0x265C620", Length = "0x9B")]
	[Token(Token = "0x60008B4")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x265D2C0", Offset = "0x265C6C0", Length = "0x289")]
	[Token(Token = "0x60008B5")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x265D550", Offset = "0x265C950", Length = "0x3E1")]
	[Token(Token = "0x60008B6")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

