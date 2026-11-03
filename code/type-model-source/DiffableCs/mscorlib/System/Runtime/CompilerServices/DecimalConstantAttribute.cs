namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x200047B")]
public sealed class DecimalConstantAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001254")]
	private decimal _dec; //Field offset: 0x10

	[Token(Token = "0x170003FC")]
	public decimal Value
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x60020D7")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1F33CD0", Offset = "0x1F330D0", Length = "0x81")]
	[CLSCompliant(False)]
	[Token(Token = "0x60020D6")]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x60020D7")]
	public decimal get_Value() { }

}

