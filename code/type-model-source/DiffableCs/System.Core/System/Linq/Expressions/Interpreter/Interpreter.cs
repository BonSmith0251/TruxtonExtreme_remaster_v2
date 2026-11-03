namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000164")]
internal sealed class Interpreter
{
	[Token(Token = "0x40002DD")]
	internal static readonly object NoValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DE")]
	private readonly InstructionArray _instructions; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002DF")]
	internal readonly Object[] _objects; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002E0")]
	internal readonly RuntimeLabel[] _labels; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002E1")]
	internal readonly DebugInfo[] _debugInfos; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002E2")]
	private readonly string <Name>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002E3")]
	private readonly int <LocalCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002E4")]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170001BC")]
	internal int ClosureSize
	{
		[Address(RVA = "0x227A690", Offset = "0x2279A90", Length = "0x47")]
		[Token(Token = "0x60007DA")]
		internal get { } //Length: 71
	}

	[Token(Token = "0x170001BE")]
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007DC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001BD")]
	internal InstructionArray Instructions
	{
		[Address(RVA = "0x195BD90", Offset = "0x195B190", Length = "0x1D")]
		[Token(Token = "0x60007DB")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001BB")]
	internal int LocalCount
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007D9")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170001BA")]
	internal string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007D8")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x227A540", Offset = "0x2279940", Length = "0x73")]
	[Token(Token = "0x60007DE")]
	private static Interpreter() { }

	[Address(RVA = "0x227A5C0", Offset = "0x22799C0", Length = "0xC9")]
	[Token(Token = "0x60007D7")]
	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[Address(RVA = "0x227A690", Offset = "0x2279A90", Length = "0x47")]
	[Token(Token = "0x60007DA")]
	internal int get_ClosureSize() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007DC")]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	[Address(RVA = "0x195BD90", Offset = "0x195B190", Length = "0x1D")]
	[Token(Token = "0x60007DB")]
	internal InstructionArray get_Instructions() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007D9")]
	internal int get_LocalCount() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007D8")]
	internal string get_Name() { }

	[Address(RVA = "0x227A4D0", Offset = "0x22798D0", Length = "0x6F")]
	[Token(Token = "0x60007DD")]
	public void Run(InterpretedFrame frame) { }

}

