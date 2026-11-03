namespace System;

[Token(Token = "0x20000D4")]
public class UriTypeConverter : TypeConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000444")]
	public UriTypeConverter() { }

	[Address(RVA = "0x262AF40", Offset = "0x262A340", Length = "0xB2")]
	[Token(Token = "0x6000445")]
	private bool CanConvert(Type type) { }

	[Address(RVA = "0x262AE40", Offset = "0x262A240", Length = "0x96")]
	[Token(Token = "0x6000446")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x262AEE0", Offset = "0x262A2E0", Length = "0x5B")]
	[Token(Token = "0x6000447")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x262B000", Offset = "0x262A400", Length = "0x1DE")]
	[Token(Token = "0x6000448")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x262B1E0", Offset = "0x262A5E0", Length = "0x28D")]
	[Token(Token = "0x6000449")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

