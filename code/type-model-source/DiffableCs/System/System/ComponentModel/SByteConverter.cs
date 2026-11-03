namespace System.ComponentModel;

[Token(Token = "0x2000194")]
public class SByteConverter : BaseNumberConverter
{

	[Token(Token = "0x170001EA")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x2677F30", Offset = "0x2677330", Length = "0x32")]
		[Token(Token = "0x60009EA")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x60009EE")]
	public SByteConverter() { }

	[Address(RVA = "0x2677E00", Offset = "0x2677200", Length = "0x6E")]
	[Token(Token = "0x60009EB")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2677E70", Offset = "0x2677270", Length = "0x2E")]
	[Token(Token = "0x60009EC")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2677F30", Offset = "0x2677330", Length = "0x32")]
	[Token(Token = "0x60009EA")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2677EA0", Offset = "0x26772A0", Length = "0x86")]
	[Token(Token = "0x60009ED")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

