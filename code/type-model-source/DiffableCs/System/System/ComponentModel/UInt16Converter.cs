namespace System.ComponentModel;

[Token(Token = "0x200019D")]
public class UInt16Converter : BaseNumberConverter
{

	[Token(Token = "0x170001EF")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x2679580", Offset = "0x2678980", Length = "0x32")]
		[Token(Token = "0x6000A19")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000A1D")]
	public UInt16Converter() { }

	[Address(RVA = "0x2679450", Offset = "0x2678850", Length = "0x6F")]
	[Token(Token = "0x6000A1A")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x26794C0", Offset = "0x26788C0", Length = "0x2F")]
	[Token(Token = "0x6000A1B")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2679580", Offset = "0x2678980", Length = "0x32")]
	[Token(Token = "0x6000A19")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x26794F0", Offset = "0x26788F0", Length = "0x89")]
	[Token(Token = "0x6000A1C")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

