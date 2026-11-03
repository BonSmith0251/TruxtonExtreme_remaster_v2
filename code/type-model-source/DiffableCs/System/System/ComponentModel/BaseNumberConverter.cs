namespace System.ComponentModel;

[Token(Token = "0x200015F")]
public abstract class BaseNumberConverter : TypeConverter
{

	[Token(Token = "0x17000199")]
	internal override bool AllowHex
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600087A")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700019A")]
	internal abstract Type TargetType
	{
		[Token(Token = "0x600087B")]
		internal get { } //Length: 0
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000879")]
	internal BaseNumberConverter() { }

	[Address(RVA = "0x2641BB0", Offset = "0x2640FB0", Length = "0x80")]
	[Token(Token = "0x600087F")]
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	[Address(RVA = "0x2641C30", Offset = "0x2641030", Length = "0x36")]
	[Token(Token = "0x6000882")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x2641C70", Offset = "0x2641070", Length = "0x35B")]
	[Token(Token = "0x6000880")]
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	[Address(RVA = "0x2641FD0", Offset = "0x26413D0", Length = "0x28E")]
	[Token(Token = "0x6000881")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Token(Token = "0x600087C")]
	internal abstract object FromString(string value, int radix) { }

	[Token(Token = "0x600087D")]
	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600087A")]
	internal override bool get_AllowHex() { }

	[Token(Token = "0x600087B")]
	internal abstract Type get_TargetType() { }

	[Token(Token = "0x600087E")]
	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

}

