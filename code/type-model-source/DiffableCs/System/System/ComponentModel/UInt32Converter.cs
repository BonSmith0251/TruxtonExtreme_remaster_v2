namespace System.ComponentModel;

[Token(Token = "0x200019E")]
public class UInt32Converter : BaseNumberConverter
{

	[Token(Token = "0x170001F0")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x26796F0", Offset = "0x2678AF0", Length = "0x32")]
		[Token(Token = "0x6000A1E")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000A22")]
	public UInt32Converter() { }

	[Address(RVA = "0x26795C0", Offset = "0x26789C0", Length = "0x6E")]
	[Token(Token = "0x6000A1F")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2679630", Offset = "0x2678A30", Length = "0x2E")]
	[Token(Token = "0x6000A20")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x26796F0", Offset = "0x2678AF0", Length = "0x32")]
	[Token(Token = "0x6000A1E")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2679660", Offset = "0x2678A60", Length = "0x88")]
	[Token(Token = "0x6000A21")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

