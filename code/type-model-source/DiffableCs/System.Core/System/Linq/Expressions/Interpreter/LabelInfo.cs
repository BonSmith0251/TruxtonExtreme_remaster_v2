namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000165")]
internal sealed class LabelInfo
{
	[CompilerGenerated]
	[Token(Token = "0x2000166")]
	private sealed class <>c
	{
		[Token(Token = "0x40002EA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40002EB")]
		public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; //Field offset: 0x8

		[Address(RVA = "0x22909F0", Offset = "0x228FDF0", Length = "0x281")]
		[Token(Token = "0x60007EC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007ED")]
		public <>c() { }

		[Address(RVA = "0x22909D0", Offset = "0x228FDD0", Length = "0x17")]
		[Token(Token = "0x60007EE")]
		internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E5")]
	private readonly LabelTarget _node; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E6")]
	private BranchLabel _label; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E7")]
	private object _definitions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E8")]
	private readonly List<LabelScopeInfo> _references; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002E9")]
	private bool _acrossBlockJump; //Field offset: 0x30

	[Token(Token = "0x170001BF")]
	private bool HasDefinitions
	{
		[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
		[Token(Token = "0x60007E7")]
		private get { } //Length: 9
	}

	[Token(Token = "0x170001C0")]
	private bool HasMultipleDefinitions
	{
		[Address(RVA = "0x227B4F0", Offset = "0x227A8F0", Length = "0x75")]
		[Token(Token = "0x60007EA")]
		private get { } //Length: 117
	}

	[Address(RVA = "0x227B440", Offset = "0x227A840", Length = "0x94")]
	[Token(Token = "0x60007DF")]
	internal LabelInfo(LabelTarget node) { }

	[Address(RVA = "0x227A6E0", Offset = "0x2279AE0", Length = "0x134")]
	[Token(Token = "0x60007E9")]
	private void AddDefinition(LabelScopeInfo scope) { }

	[Address(RVA = "0x8507D0", Offset = "0x84FBD0", Length = "0x24F")]
	[Token(Token = "0x60007EB")]
	internal static T CommonNode(T first, T second, Func<T, T> parent) { }

	[Address(RVA = "0x227A820", Offset = "0x2279C20", Length = "0x3E2")]
	[Token(Token = "0x60007E2")]
	internal void Define(LabelScopeInfo block) { }

	[Address(RVA = "0x227AC10", Offset = "0x227A010", Length = "0xA6")]
	[Token(Token = "0x60007E6")]
	private bool DefinedIn(LabelScopeInfo scope) { }

	[Address(RVA = "0x227ACC0", Offset = "0x227A0C0", Length = "0x45")]
	[Token(Token = "0x60007E5")]
	private void EnsureLabel(LightCompiler compiler) { }

	[Address(RVA = "0x227AD10", Offset = "0x227A110", Length = "0x1D5")]
	[Token(Token = "0x60007E8")]
	private LabelScopeInfo FirstDefinition() { }

	[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
	[Token(Token = "0x60007E7")]
	private bool get_HasDefinitions() { }

	[Address(RVA = "0x227B4F0", Offset = "0x227A8F0", Length = "0x75")]
	[Token(Token = "0x60007EA")]
	private bool get_HasMultipleDefinitions() { }

	[Address(RVA = "0x227AEF0", Offset = "0x227A2F0", Length = "0x44")]
	[Token(Token = "0x60007E0")]
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	[Address(RVA = "0x227AF40", Offset = "0x227A340", Length = "0xB7")]
	[Token(Token = "0x60007E1")]
	internal void Reference(LabelScopeInfo block) { }

	[Address(RVA = "0x227B000", Offset = "0x227A400", Length = "0x81")]
	[Token(Token = "0x60007E4")]
	internal void ValidateFinish() { }

	[Address(RVA = "0x227B090", Offset = "0x227A490", Length = "0x3AD")]
	[Token(Token = "0x60007E3")]
	private void ValidateJump(LabelScopeInfo reference) { }

}

