namespace System.ComponentModel;

[Token(Token = "0x2000195")]
public class SingleConverter : BaseNumberConverter
{

	[Token(Token = "0x170001EB")]
	internal virtual bool AllowHex
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60009EF")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001EC")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x26780D0", Offset = "0x26774D0", Length = "0x32")]
		[Token(Token = "0x60009F0")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x60009F4")]
	public SingleConverter() { }

	[Address(RVA = "0x2677FA0", Offset = "0x26773A0", Length = "0x99")]
	[Token(Token = "0x60009F1")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2677F70", Offset = "0x2677370", Length = "0x30")]
	[Token(Token = "0x60009F2")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60009EF")]
	internal virtual bool get_AllowHex() { }

	[Address(RVA = "0x26780D0", Offset = "0x26774D0", Length = "0x32")]
	[Token(Token = "0x60009F0")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2678040", Offset = "0x2677440", Length = "0x8C")]
	[Token(Token = "0x60009F3")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

