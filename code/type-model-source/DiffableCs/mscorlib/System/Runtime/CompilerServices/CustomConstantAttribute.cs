namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x2000479")]
public abstract class CustomConstantAttribute : Attribute
{

	[Token(Token = "0x170003FA")]
	public abstract object Value
	{
		[Token(Token = "0x60020D3")]
		 get { } //Length: 0
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60020D4")]
	protected CustomConstantAttribute() { }

	[Token(Token = "0x60020D3")]
	public abstract object get_Value() { }

}

