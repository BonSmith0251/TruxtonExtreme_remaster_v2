namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000241")]
internal sealed class QuoteInstruction : Instruction
{
	[Token(Token = "0x2000242")]
	private sealed class ExpressionQuoter : ExpressionVisitor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400040D")]
		private readonly Dictionary<ParameterExpression, LocalVariable> _variables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400040E")]
		private readonly InterpretedFrame _frame; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400040F")]
		private readonly Stack<HashSet`1<ParameterExpression>> _shadowedVars; //Field offset: 0x20

		[Address(RVA = "0x2299C10", Offset = "0x2299010", Length = "0xB1")]
		[Token(Token = "0x6000B05")]
		internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

		[Address(RVA = "0x2299600", Offset = "0x2298A00", Length = "0x123")]
		[Token(Token = "0x6000B0A")]
		private IStrongBox GetBox(ParameterExpression variable) { }

		[Address(RVA = "0x2299730", Offset = "0x2298B30", Length = "0x17F")]
		[Token(Token = "0x6000B07")]
		protected private virtual Expression VisitBlock(BlockExpression node) { }

		[Address(RVA = "0x22998B0", Offset = "0x2298CB0", Length = "0x194")]
		[Token(Token = "0x6000B08")]
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		[Address(RVA = "0x9F1900", Offset = "0x9F0D00", Length = "0x1C3")]
		[Token(Token = "0x6000B06")]
		protected private virtual Expression VisitLambda(Expression<T> node) { }

		[Address(RVA = "0x2299A50", Offset = "0x2298E50", Length = "0x1BC")]
		[Token(Token = "0x6000B09")]
		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400040B")]
	private readonly Expression _operand; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400040C")]
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; //Field offset: 0x18

	[Token(Token = "0x17000245")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A7410", Offset = "0x22A6810", Length = "0x2C")]
		[Token(Token = "0x6000B03")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000244")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000B02")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x6000B01")]
	public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	[Address(RVA = "0x22A7410", Offset = "0x22A6810", Length = "0x2C")]
	[Token(Token = "0x6000B03")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000B02")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22A72D0", Offset = "0x22A66D0", Length = "0x135")]
	[Token(Token = "0x6000B04")]
	public virtual int Run(InterpretedFrame frame) { }

}

