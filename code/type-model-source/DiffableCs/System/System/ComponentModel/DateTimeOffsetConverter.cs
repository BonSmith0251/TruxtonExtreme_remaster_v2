namespace System.ComponentModel;

[Token(Token = "0x20001AC")]
public class DateTimeOffsetConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000A4F")]
	public DateTimeOffsetConverter() { }

	[Address(RVA = "0x2642FB0", Offset = "0x26423B0", Length = "0x80")]
	[Token(Token = "0x6000A4B")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x265D940", Offset = "0x265CD40", Length = "0x9B")]
	[Token(Token = "0x6000A4C")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x265D9E0", Offset = "0x265CDE0", Length = "0x325")]
	[Token(Token = "0x6000A4D")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x265DD10", Offset = "0x265D110", Length = "0xE1A")]
	[Token(Token = "0x6000A4E")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

