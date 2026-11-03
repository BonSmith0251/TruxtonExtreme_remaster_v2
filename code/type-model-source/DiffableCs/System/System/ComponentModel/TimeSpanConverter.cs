namespace System.ComponentModel;

[Token(Token = "0x2000197")]
public class TimeSpanConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009FC")]
	public TimeSpanConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x60009F8")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2678180", Offset = "0x2677580", Length = "0x9B")]
	[Token(Token = "0x60009F9")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x2678220", Offset = "0x2677620", Length = "0x167")]
	[Token(Token = "0x60009FA")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2678390", Offset = "0x2677790", Length = "0x326")]
	[Token(Token = "0x60009FB")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

