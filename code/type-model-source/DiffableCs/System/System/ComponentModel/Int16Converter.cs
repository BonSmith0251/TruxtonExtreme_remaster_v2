namespace System.ComponentModel;

[Token(Token = "0x2000180")]
public class Int16Converter : BaseNumberConverter
{

	[Token(Token = "0x170001C7")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x2663C10", Offset = "0x2663010", Length = "0x32")]
		[Token(Token = "0x6000951")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000955")]
	public Int16Converter() { }

	[Address(RVA = "0x2663B10", Offset = "0x2662F10", Length = "0x6F")]
	[Token(Token = "0x6000952")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2663AE0", Offset = "0x2662EE0", Length = "0x2F")]
	[Token(Token = "0x6000953")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2663C10", Offset = "0x2663010", Length = "0x32")]
	[Token(Token = "0x6000951")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2663B80", Offset = "0x2662F80", Length = "0x89")]
	[Token(Token = "0x6000954")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

