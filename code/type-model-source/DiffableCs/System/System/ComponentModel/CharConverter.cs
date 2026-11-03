namespace System.ComponentModel;

[Token(Token = "0x2000162")]
public class CharConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000891")]
	public CharConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x600088E")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2642900", Offset = "0x2641D00", Length = "0x103")]
	[Token(Token = "0x6000890")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2642A10", Offset = "0x2641E10", Length = "0xFD")]
	[Token(Token = "0x600088F")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

