namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[IsReadOnly]
[Token(Token = "0x200015D")]
internal struct InstructionArray
{
	[Token(Token = "0x200015E")]
	public sealed class DebugView
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002AE")]
		private readonly InstructionArray _array; //Field offset: 0x10

		[Address(RVA = "0x226ED30", Offset = "0x226E130", Length = "0xB0")]
		[Token(Token = "0x600073C")]
		public DebugView(InstructionArray array) { }

		[Address(RVA = "0x226ED00", Offset = "0x226E100", Length = "0x2F")]
		[CompilerGenerated]
		[Token(Token = "0x600073E")]
		private int <GetInstructionViews>b__4_0(int index) { }

		[Address(RVA = "0x226EC40", Offset = "0x226E040", Length = "0xB4")]
		[Token(Token = "0x600073D")]
		public InstructionView[] GetInstructionViews(bool includeDebugCookies = false) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002A8")]
	internal readonly int MaxStackDepth; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40002A9")]
	internal readonly int MaxContinuationDepth; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40002AA")]
	internal readonly Instruction[] Instructions; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002AB")]
	internal readonly Object[] Objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002AC")]
	internal readonly RuntimeLabel[] Labels; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002AD")]
	internal readonly List<KeyValuePair`2<Int32, Object>> DebugCookies; //Field offset: 0x20

	[Address(RVA = "0x22743B0", Offset = "0x22737B0", Length = "0x5A")]
	[Token(Token = "0x600073B")]
	internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, Object[] objects, RuntimeLabel[] labels, List<KeyValuePair`2<Int32, Object>> debugCookies) { }

}

