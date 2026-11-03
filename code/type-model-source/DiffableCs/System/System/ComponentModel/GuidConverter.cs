namespace System.ComponentModel;

[Token(Token = "0x2000179")]
public class GuidConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000930")]
	public GuidConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x600092C")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2663630", Offset = "0x2662A30", Length = "0x9B")]
	[Token(Token = "0x600092D")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x26636D0", Offset = "0x2662AD0", Length = "0xC2")]
	[Token(Token = "0x600092E")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x26637A0", Offset = "0x2662BA0", Length = "0x334")]
	[Token(Token = "0x600092F")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

