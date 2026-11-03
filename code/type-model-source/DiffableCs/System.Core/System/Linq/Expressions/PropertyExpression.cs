namespace System.Linq.Expressions;

[Token(Token = "0x20000A0")]
internal sealed class PropertyExpression : MemberExpression
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000199")]
	private readonly PropertyInfo _property; //Field offset: 0x18

	[Token(Token = "0x170000C1")]
	public virtual Type Type
	{
		[Address(RVA = "0x2268DC0", Offset = "0x22681C0", Length = "0x2A")]
		[Token(Token = "0x600045C")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2263A90", Offset = "0x2262E90", Length = "0x82")]
	[Token(Token = "0x600045A")]
	public PropertyExpression(Expression expression, PropertyInfo member) { }

	[Address(RVA = "0x2268DC0", Offset = "0x22681C0", Length = "0x2A")]
	[Token(Token = "0x600045C")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600045B")]
	internal virtual MemberInfo GetMember() { }

}

