namespace System.Linq.Expressions;

[Token(Token = "0x20000B8")]
internal class TypedParameterExpression : ParameterExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BC")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000E0")]
	public virtual Type Type
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004B4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226BF70", Offset = "0x226B370", Length = "0x82")]
	[Token(Token = "0x60004B3")]
	internal TypedParameterExpression(Type type, string name) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004B4")]
	public virtual Type get_Type() { }

}

