namespace System.Linq.Expressions;

[Token(Token = "0x200007E")]
internal sealed class ExpressionStringBuilder : ExpressionVisitor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000107")]
	private readonly StringBuilder _out; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000108")]
	private Dictionary<Object, Int32> _ids; //Field offset: 0x18

	[Address(RVA = "0x2262320", Offset = "0x2261720", Length = "0x66")]
	[Token(Token = "0x600038D")]
	private ExpressionStringBuilder() { }

	[Address(RVA = "0x2255250", Offset = "0x2254650", Length = "0xD5")]
	[Token(Token = "0x6000395")]
	internal static string CatchBlockToString(CatchBlock node) { }

	[Address(RVA = "0x225FC80", Offset = "0x225F080", Length = "0xBC")]
	[Token(Token = "0x60003AD")]
	private void DumpLabel(LabelTarget target) { }

	[Address(RVA = "0x225FD40", Offset = "0x225F140", Length = "0xD5")]
	[Token(Token = "0x6000394")]
	internal static string ExpressionToString(Expression node) { }

	[Address(RVA = "0x225FE20", Offset = "0x225F220", Length = "0x10C")]
	[Token(Token = "0x6000391")]
	private int GetId(object o) { }

	[Address(RVA = "0x225FF30", Offset = "0x225F330", Length = "0x8")]
	[Token(Token = "0x600038F")]
	private int GetLabelId(LabelTarget label) { }

	[Address(RVA = "0x225FF30", Offset = "0x225F330", Length = "0x8")]
	[Token(Token = "0x6000390")]
	private int GetParamId(ParameterExpression p) { }

	[Address(RVA = "0x225FF40", Offset = "0x225F340", Length = "0xF8")]
	[Token(Token = "0x60003AE")]
	private static bool IsBool(Expression node) { }

	[Address(RVA = "0x2260120", Offset = "0x225F520", Length = "0x1E")]
	[Token(Token = "0x6000392")]
	private void Out(string s) { }

	[Address(RVA = "0x2260140", Offset = "0x225F540", Length = "0x1E")]
	[Token(Token = "0x6000393")]
	private void Out(char c) { }

	[Address(RVA = "0x2260040", Offset = "0x225F440", Length = "0xD1")]
	[Token(Token = "0x600039D")]
	private void OutMember(Expression instance, MemberInfo member) { }

	[Address(RVA = "0x2260160", Offset = "0x225F560", Length = "0x2A")]
	[Token(Token = "0x600038E")]
	public virtual string ToString() { }

	[Address(RVA = "0x2260190", Offset = "0x225F590", Length = "0x230")]
	[Token(Token = "0x6000398")]
	protected private virtual Expression VisitBinary(BinaryExpression node) { }

	[Address(RVA = "0x22607C0", Offset = "0x225FBC0", Length = "0x2CC")]
	[Token(Token = "0x60003A4")]
	protected private virtual Expression VisitBlock(BlockExpression node) { }

	[Address(RVA = "0x2260A90", Offset = "0x225FE90", Length = "0x108")]
	[Token(Token = "0x60003A9")]
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	[Address(RVA = "0x2260BA0", Offset = "0x225FFA0", Length = "0x11E")]
	[Token(Token = "0x600039B")]
	protected private virtual Expression VisitConditional(ConditionalExpression node) { }

	[Address(RVA = "0x2260CC0", Offset = "0x22600C0", Length = "0x1B2")]
	[Token(Token = "0x600039C")]
	protected private virtual Expression VisitConstant(ConstantExpression node) { }

	[Address(RVA = "0x2260E80", Offset = "0x2260280", Length = "0xB8")]
	[Token(Token = "0x60003A5")]
	protected private virtual Expression VisitDefault(DefaultExpression node) { }

	[Address(RVA = "0x7EDF00", Offset = "0x7ED300", Length = "0x94")]
	[Token(Token = "0x6000396")]
	private void VisitExpressions(char open, ReadOnlyCollection<T> expressions, char close) { }

	[Address(RVA = "0x7EDCB0", Offset = "0x7ED0B0", Length = "0x24A")]
	[Token(Token = "0x6000397")]
	private void VisitExpressions(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }

	[Address(RVA = "0x2260F40", Offset = "0x2260340", Length = "0x211")]
	[Token(Token = "0x60003AC")]
	protected private virtual Expression VisitExtension(Expression node) { }

	[Address(RVA = "0x2261160", Offset = "0x2260560", Length = "0x184")]
	[Token(Token = "0x60003A7")]
	protected private virtual Expression VisitGoto(GotoExpression node) { }

	[Address(RVA = "0x22612F0", Offset = "0x22606F0", Length = "0x1F3")]
	[Token(Token = "0x60003AB")]
	protected private virtual Expression VisitIndex(IndexExpression node) { }

	[Address(RVA = "0x22614F0", Offset = "0x22608F0", Length = "0x134")]
	[Token(Token = "0x600039F")]
	protected private virtual Expression VisitInvocation(InvocationExpression node) { }

	[Address(RVA = "0x2261630", Offset = "0x2260A30", Length = "0x81")]
	[Token(Token = "0x60003A6")]
	protected private virtual Expression VisitLabel(LabelExpression node) { }

	[Address(RVA = "0x7EE150", Offset = "0x7ED550", Length = "0x1AB")]
	[Token(Token = "0x600039A")]
	protected private virtual Expression VisitLambda(Expression<T> node) { }

	[Address(RVA = "0x22616C0", Offset = "0x2260AC0", Length = "0x57")]
	[Token(Token = "0x60003A8")]
	protected private virtual Expression VisitLoop(LoopExpression node) { }

	[Address(RVA = "0x2261720", Offset = "0x2260B20", Length = "0x11A")]
	[Token(Token = "0x600039E")]
	protected private virtual Expression VisitMember(MemberExpression node) { }

	[Address(RVA = "0x2261840", Offset = "0x2260C40", Length = "0x1F8")]
	[Token(Token = "0x60003A0")]
	protected private virtual Expression VisitMethodCall(MethodCallExpression node) { }

	[Address(RVA = "0x2261A40", Offset = "0x2260E40", Length = "0x132")]
	[Token(Token = "0x60003A1")]
	protected private virtual Expression VisitNewArray(NewArrayExpression node) { }

	[Address(RVA = "0x2261B80", Offset = "0x2260F80", Length = "0xF1")]
	[Token(Token = "0x6000399")]
	protected private virtual Expression VisitParameter(ParameterExpression node) { }

	[Address(RVA = "0x2261C80", Offset = "0x2261080", Length = "0x57")]
	[Token(Token = "0x60003AA")]
	protected private virtual Expression VisitTry(TryExpression node) { }

	[Address(RVA = "0x2261CE0", Offset = "0x22610E0", Length = "0x118")]
	[Token(Token = "0x60003A2")]
	protected private virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	[Address(RVA = "0x2261E00", Offset = "0x2261200", Length = "0x164")]
	[Token(Token = "0x60003A3")]
	protected private virtual Expression VisitUnary(UnaryExpression node) { }

}

