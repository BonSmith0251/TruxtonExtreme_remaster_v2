namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000168")]
internal sealed class LabelScopeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F6")]
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F7")]
	internal readonly LabelScopeKind Kind; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F8")]
	internal readonly LabelScopeInfo Parent; //Field offset: 0x20

	[Token(Token = "0x170001C1")]
	internal bool CanJumpInto
	{
		[Address(RVA = "0x227B770", Offset = "0x227AB70", Length = "0x8")]
		[Token(Token = "0x60007F0")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x227B720", Offset = "0x227AB20", Length = "0x42")]
	[Token(Token = "0x60007EF")]
	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) { }

	[Address(RVA = "0x227B570", Offset = "0x227A970", Length = "0xBA")]
	[Token(Token = "0x60007F3")]
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }

	[Address(RVA = "0x227B630", Offset = "0x227AA30", Length = "0x5D")]
	[Token(Token = "0x60007F1")]
	internal bool ContainsTarget(LabelTarget target) { }

	[Address(RVA = "0x227B770", Offset = "0x227AB70", Length = "0x8")]
	[Token(Token = "0x60007F0")]
	internal bool get_CanJumpInto() { }

	[Address(RVA = "0x227B690", Offset = "0x227AA90", Length = "0x83")]
	[Token(Token = "0x60007F2")]
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

}

