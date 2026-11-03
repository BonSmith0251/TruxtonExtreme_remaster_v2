namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x200047A")]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001253")]
	private DateTime _date; //Field offset: 0x10

	[Token(Token = "0x170003FB")]
	public virtual object Value
	{
		[Address(RVA = "0x1F33C80", Offset = "0x1F33080", Length = "0x45")]
		[Token(Token = "0x60020D5")]
		 get { } //Length: 69
	}

	[Address(RVA = "0x1F33C80", Offset = "0x1F33080", Length = "0x45")]
	[Token(Token = "0x60020D5")]
	public virtual object get_Value() { }

}

