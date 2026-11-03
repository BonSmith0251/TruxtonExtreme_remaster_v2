namespace System.ComponentModel;

[Token(Token = "0x2000196")]
public class StringConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60009F7")]
	public StringConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x60009F5")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2678110", Offset = "0x2677510", Length = "0x68")]
	[Token(Token = "0x60009F6")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

}

