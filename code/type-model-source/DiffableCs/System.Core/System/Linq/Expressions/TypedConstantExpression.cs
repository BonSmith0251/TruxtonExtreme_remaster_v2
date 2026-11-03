namespace System.Linq.Expressions;

[Token(Token = "0x2000079")]
internal class TypedConstantExpression : ConstantExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000102")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000077")]
	public virtual Type Type
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002FA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226BEE0", Offset = "0x226B2E0", Length = "0x82")]
	[Token(Token = "0x60002F9")]
	internal TypedConstantExpression(object value, Type type) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002FA")]
	public virtual Type get_Type() { }

}

