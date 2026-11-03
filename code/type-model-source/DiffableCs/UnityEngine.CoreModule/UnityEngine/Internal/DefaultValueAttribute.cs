namespace UnityEngine.Internal;

[AttributeUsage(18432)]
[Token(Token = "0x2000310")]
public class DefaultValueAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400080D")]
	private object DefaultValue; //Field offset: 0x10

	[Token(Token = "0x1700039F")]
	public object Value
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60018D9")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60018D8")]
	public DefaultValueAttribute(string value) { }

	[Address(RVA = "0x3078670", Offset = "0x3077A70", Length = "0xA7")]
	[Token(Token = "0x60018DA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60018D9")]
	public object get_Value() { }

	[Address(RVA = "0x3078720", Offset = "0x3077B20", Length = "0x33")]
	[Token(Token = "0x60018DB")]
	public virtual int GetHashCode() { }

}

