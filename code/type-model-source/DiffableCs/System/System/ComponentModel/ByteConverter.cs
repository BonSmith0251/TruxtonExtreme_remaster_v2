namespace System.ComponentModel;

[Token(Token = "0x2000161")]
public class ByteConverter : BaseNumberConverter
{

	[Token(Token = "0x1700019B")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x26428C0", Offset = "0x2641CC0", Length = "0x32")]
		[Token(Token = "0x6000889")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600088D")]
	public ByteConverter() { }

	[Address(RVA = "0x2642790", Offset = "0x2641B90", Length = "0x6E")]
	[Token(Token = "0x600088A")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x2642800", Offset = "0x2641C00", Length = "0x2E")]
	[Token(Token = "0x600088B")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x26428C0", Offset = "0x2641CC0", Length = "0x32")]
	[Token(Token = "0x6000889")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x2642830", Offset = "0x2641C30", Length = "0x86")]
	[Token(Token = "0x600088C")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

