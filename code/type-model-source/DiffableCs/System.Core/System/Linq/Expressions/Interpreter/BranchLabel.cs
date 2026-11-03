namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000E7")]
internal sealed class BranchLabel
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000213")]
	private int _targetIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000214")]
	private int _stackDepth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000215")]
	private int _continuationStackDepth; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000216")]
	private List<Int32> _forwardBranchFixups; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000217")]
	private int <LabelIndex>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000151")]
	internal bool HasRuntimeLabel
	{
		[Address(RVA = "0x2254150", Offset = "0x2253550", Length = "0xB")]
		[Token(Token = "0x60005C4")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x17000150")]
	internal int LabelIndex
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C2")]
		internal get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005C3")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000152")]
	internal int TargetIndex
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60005C5")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x2254120", Offset = "0x2253520", Length = "0x23")]
	[Token(Token = "0x60005CA")]
	public BranchLabel() { }

	[Address(RVA = "0x2253E30", Offset = "0x2253230", Length = "0x12D")]
	[Token(Token = "0x60005C8")]
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	[Address(RVA = "0x2253F60", Offset = "0x2253360", Length = "0x2D")]
	[Token(Token = "0x60005C9")]
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	[Address(RVA = "0x2254150", Offset = "0x2253550", Length = "0xB")]
	[Token(Token = "0x60005C4")]
	internal bool get_HasRuntimeLabel() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C2")]
	internal int get_LabelIndex() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60005C5")]
	internal int get_TargetIndex() { }

	[Address(RVA = "0x2253F90", Offset = "0x2253390", Length = "0x163")]
	[Token(Token = "0x60005C7")]
	internal void Mark(InstructionList instructions) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005C3")]
	internal void set_LabelIndex(int value) { }

	[Address(RVA = "0x2254100", Offset = "0x2253500", Length = "0x15")]
	[Token(Token = "0x60005C6")]
	internal RuntimeLabel ToRuntimeLabel() { }

}

