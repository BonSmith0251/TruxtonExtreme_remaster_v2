namespace System.ComponentModel;

[Token(Token = "0x2000181")]
public class Int32Converter : BaseNumberConverter
{

	[Token(Token = "0x170001C8")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x2663D80", Offset = "0x2663180", Length = "0x32")]
		[Token(Token = "0x6000956")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x600095A")]
	public Int32Converter() { }

	[Address(RVA = "0x2663C50", Offset = "0x2663050", Length = "0x6E")]
	[Token(Token = "0x6000957")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2663CC0", Offset = "0x26630C0", Length = "0x2E")]
	[Token(Token = "0x6000958")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2663D80", Offset = "0x2663180", Length = "0x32")]
	[Token(Token = "0x6000956")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2663CF0", Offset = "0x26630F0", Length = "0x88")]
	[Token(Token = "0x6000959")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

