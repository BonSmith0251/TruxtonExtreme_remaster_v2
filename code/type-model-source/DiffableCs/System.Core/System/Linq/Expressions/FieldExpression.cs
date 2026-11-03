namespace System.Linq.Expressions;

[Token(Token = "0x200009F")]
internal sealed class FieldExpression : MemberExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000198")]
	private readonly FieldInfo _field; //Field offset: 0x18

	[Token(Token = "0x170000C0")]
	public virtual Type Type
	{
		[Address(RVA = "0x2263B20", Offset = "0x2262F20", Length = "0x2A")]
		[Token(Token = "0x6000459")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2263A90", Offset = "0x2262E90", Length = "0x82")]
	[Token(Token = "0x6000457")]
	public FieldExpression(Expression expression, FieldInfo member) { }

	[Address(RVA = "0x2263B20", Offset = "0x2262F20", Length = "0x2A")]
	[Token(Token = "0x6000459")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000458")]
	internal virtual MemberInfo GetMember() { }

}

