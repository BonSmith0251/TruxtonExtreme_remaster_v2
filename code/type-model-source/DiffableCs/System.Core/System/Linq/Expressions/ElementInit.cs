namespace System.Linq.Expressions;

[Token(Token = "0x200007C")]
public sealed class ElementInit : IArgumentProvider
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000105")]
	private readonly MethodInfo <AddMethod>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000106")]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700007E")]
	public MethodInfo AddMethod
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000303")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000080")]
	public override int ArgumentCount
	{
		[Address(RVA = "0x2257870", Offset = "0x2256C70", Length = "0x44")]
		[Token(Token = "0x6000306")]
		 get { } //Length: 68
	}

	[Token(Token = "0x1700007F")]
	public ReadOnlyCollection<Expression> Arguments
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000304")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000303")]
	public MethodInfo get_AddMethod() { }

	[Address(RVA = "0x2257870", Offset = "0x2256C70", Length = "0x44")]
	[Token(Token = "0x6000306")]
	public override int get_ArgumentCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000304")]
	public ReadOnlyCollection<Expression> get_Arguments() { }

	[Address(RVA = "0x2257810", Offset = "0x2256C10", Length = "0x51")]
	[Token(Token = "0x6000305")]
	public override Expression GetArgument(int index) { }

}

