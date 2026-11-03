namespace System.ComponentModel;

[Token(Token = "0x2000182")]
public class Int64Converter : BaseNumberConverter
{

	[Token(Token = "0x170001C9")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x22ED550", Offset = "0x22EC950", Length = "0x32")]
		[Token(Token = "0x600095B")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x600095F")]
	public Int64Converter() { }

	[Address(RVA = "0x2663DF0", Offset = "0x26631F0", Length = "0x6F")]
	[Token(Token = "0x600095C")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2663DC0", Offset = "0x26631C0", Length = "0x2F")]
	[Token(Token = "0x600095D")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x22ED550", Offset = "0x22EC950", Length = "0x32")]
	[Token(Token = "0x600095B")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2663E60", Offset = "0x2663260", Length = "0x8B")]
	[Token(Token = "0x600095E")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

