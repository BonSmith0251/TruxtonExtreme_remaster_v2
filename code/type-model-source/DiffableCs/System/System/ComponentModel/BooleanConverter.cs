namespace System.ComponentModel;

[Token(Token = "0x2000160")]
public class BooleanConverter : TypeConverter
{
	[Token(Token = "0x4000606")]
	private static StandardValuesCollection s_values; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000888")]
	public BooleanConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x6000883")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2642260", Offset = "0x2641660", Length = "0x13A")]
	[Token(Token = "0x6000884")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x26423A0", Offset = "0x26417A0", Length = "0x19D")]
	[Token(Token = "0x6000885")]
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000886")]
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000887")]
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

