namespace System.ComponentModel;

[Token(Token = "0x200016B")]
public class DecimalConverter : BaseNumberConverter
{

	[Token(Token = "0x1700019F")]
	internal virtual bool AllowHex
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008B8")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001A0")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x265F120", Offset = "0x265E520", Length = "0x4D")]
		[Token(Token = "0x60008B9")]
		internal get { } //Length: 77
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x60008BF")]
	public DecimalConverter() { }

	[Address(RVA = "0x265EB30", Offset = "0x265DF30", Length = "0x9B")]
	[Token(Token = "0x60008BA")]
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	[Address(RVA = "0x265EBD0", Offset = "0x265DFD0", Length = "0x353")]
	[Token(Token = "0x60008BB")]
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	[Address(RVA = "0x265EFC0", Offset = "0x265E3C0", Length = "0xAC")]
	[Token(Token = "0x60008BC")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x265EF30", Offset = "0x265E330", Length = "0x84")]
	[Token(Token = "0x60008BD")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008B8")]
	internal virtual bool get_AllowHex() { }

	[Address(RVA = "0x265F120", Offset = "0x265E520", Length = "0x4D")]
	[Token(Token = "0x60008B9")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x265F070", Offset = "0x265E470", Length = "0xAB")]
	[Token(Token = "0x60008BE")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

