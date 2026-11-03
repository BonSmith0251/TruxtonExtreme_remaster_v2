namespace System.Data;

[Token(Token = "0x2000058")]
internal sealed class DefaultValueTypeConverter : StringConverter
{

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000547")]
	public DefaultValueTypeConverter() { }

	[Address(RVA = "0x2338FE0", Offset = "0x23383E0", Length = "0x166")]
	[Token(Token = "0x6000549")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2339150", Offset = "0x2338550", Length = "0x182")]
	[Token(Token = "0x6000548")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

