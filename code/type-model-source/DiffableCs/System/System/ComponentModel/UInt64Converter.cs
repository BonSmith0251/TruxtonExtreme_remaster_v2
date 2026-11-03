namespace System.ComponentModel;

[Token(Token = "0x200019F")]
public class UInt64Converter : BaseNumberConverter
{

	[Token(Token = "0x170001F1")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x2679860", Offset = "0x2678C60", Length = "0x32")]
		[Token(Token = "0x6000A23")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6000A27")]
	public UInt64Converter() { }

	[Address(RVA = "0x2679760", Offset = "0x2678B60", Length = "0x6F")]
	[Token(Token = "0x6000A24")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2679730", Offset = "0x2678B30", Length = "0x2F")]
	[Token(Token = "0x6000A25")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2679860", Offset = "0x2678C60", Length = "0x32")]
	[Token(Token = "0x6000A23")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x26797D0", Offset = "0x2678BD0", Length = "0x8B")]
	[Token(Token = "0x6000A26")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

