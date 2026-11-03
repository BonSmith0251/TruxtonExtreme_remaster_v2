namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001B7")]
internal sealed class LocalVariables
{
	[Token(Token = "0x20001B8")]
	private sealed class VariableScope
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400037F")]
		public readonly int Start; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000380")]
		public int Stop; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000381")]
		public readonly LocalVariable Variable; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000382")]
		public readonly VariableScope Parent; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000383")]
		public List<VariableScope> ChildScopes; //Field offset: 0x28

		[Address(RVA = "0x22AD6F0", Offset = "0x22ACAF0", Length = "0x2D5")]
		[Token(Token = "0x600098E")]
		public VariableScope(LocalVariable variable, int start, VariableScope parent) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037B")]
	private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400037C")]
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400037D")]
	private int _localCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400037E")]
	private int _maxLocalCount; //Field offset: 0x24

	[Token(Token = "0x170001F9")]
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600098B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001F8")]
	public int LocalCount
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000989")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x229E5B0", Offset = "0x229D9B0", Length = "0x77")]
	[Token(Token = "0x600098D")]
	public LocalVariables() { }

	[Address(RVA = "0x229DEC0", Offset = "0x229D2C0", Length = "0x10D")]
	[Token(Token = "0x600098C")]
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	[Address(RVA = "0x229DFD0", Offset = "0x229D3D0", Length = "0x14F")]
	[Token(Token = "0x6000988")]
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	[Address(RVA = "0x229E120", Offset = "0x229D520", Length = "0x2BE")]
	[Token(Token = "0x6000986")]
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600098B")]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000989")]
	public int get_LocalCount() { }

	[Address(RVA = "0x229E3E0", Offset = "0x229D7E0", Length = "0xE2")]
	[Token(Token = "0x600098A")]
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	[Address(RVA = "0x229E4D0", Offset = "0x229D8D0", Length = "0xD1")]
	[Token(Token = "0x6000987")]
	public void UndefineLocal(LocalDefinition definition, int end) { }

}

