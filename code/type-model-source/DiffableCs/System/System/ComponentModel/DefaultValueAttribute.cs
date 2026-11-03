namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000145")]
public class DefaultValueAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D0")]
	private object _value; //Field offset: 0x10

	[Token(Token = "0x1700017D")]
	public override object Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000818")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2647B40", Offset = "0x2646F40", Length = "0x46")]
	[Token(Token = "0x6000813")]
	public DefaultValueAttribute(int value) { }

	[Address(RVA = "0x2647AF0", Offset = "0x2646EF0", Length = "0x48")]
	[Token(Token = "0x6000814")]
	public DefaultValueAttribute(long value) { }

	[Address(RVA = "0x2647AA0", Offset = "0x2646EA0", Length = "0x47")]
	[Token(Token = "0x6000815")]
	public DefaultValueAttribute(bool value) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000816")]
	public DefaultValueAttribute(string value) { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000817")]
	public DefaultValueAttribute(object value) { }

	[Address(RVA = "0x2647960", Offset = "0x2646D60", Length = "0x12B")]
	[Token(Token = "0x6000819")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000818")]
	public override object get_Value() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x600081A")]
	public virtual int GetHashCode() { }

}

