namespace System.ComponentModel;

[Token(Token = "0x2000171")]
public class DoubleConverter : BaseNumberConverter
{

	[Token(Token = "0x170001A6")]
	internal virtual bool AllowHex
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008DF")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001A7")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x265FAF0", Offset = "0x265EEF0", Length = "0x32")]
		[Token(Token = "0x60008E0")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x60008E4")]
	public DoubleConverter() { }

	[Address(RVA = "0x265F990", Offset = "0x265ED90", Length = "0x99")]
	[Token(Token = "0x60008E1")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x265FA30", Offset = "0x265EE30", Length = "0x30")]
	[Token(Token = "0x60008E2")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008DF")]
	internal virtual bool get_AllowHex() { }

	[Address(RVA = "0x265FAF0", Offset = "0x265EEF0", Length = "0x32")]
	[Token(Token = "0x60008E0")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x265FA60", Offset = "0x265EE60", Length = "0x8D")]
	[Token(Token = "0x60008E3")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

