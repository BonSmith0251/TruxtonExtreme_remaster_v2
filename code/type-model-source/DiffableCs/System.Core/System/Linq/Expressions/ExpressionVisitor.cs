namespace System.Linq.Expressions;

[Token(Token = "0x2000080")]
public abstract class ExpressionVisitor
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60003AF")]
	protected ExpressionVisitor() { }

	[Address(RVA = "0x2262390", Offset = "0x2261790", Length = "0x196")]
	[Token(Token = "0x60003CD")]
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	[Address(RVA = "0x2262530", Offset = "0x2261930", Length = "0xC4")]
	[Token(Token = "0x60003CE")]
	private static void ValidateChildType(Type before, Type after, string methodName) { }

	[Address(RVA = "0x2262600", Offset = "0x2261A00", Length = "0x11E")]
	[Token(Token = "0x60003CC")]
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	[Address(RVA = "0x7EF2E0", Offset = "0x7EE6E0", Length = "0x2A0")]
	[Token(Token = "0x60003B4")]
	public static ReadOnlyCollection<T> Visit(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }

	[Address(RVA = "0x2263760", Offset = "0x2262B60", Length = "0x25")]
	[Token(Token = "0x60003B0")]
	public override Expression Visit(Expression node) { }

	[Address(RVA = "0x2263790", Offset = "0x2262B90", Length = "0x2F7")]
	[Token(Token = "0x60003B1")]
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	[Address(RVA = "0x7EE960", Offset = "0x7EDD60", Length = "0xD4")]
	[Token(Token = "0x60003B5")]
	public T VisitAndConvert(T node, string callerName) { }

	[Address(RVA = "0x7EEA40", Offset = "0x7EDE40", Length = "0x2CE")]
	[Token(Token = "0x60003B6")]
	public ReadOnlyCollection<T> VisitAndConvert(ReadOnlyCollection<T> nodes, string callerName) { }

	[Address(RVA = "0x2262720", Offset = "0x2261B20", Length = "0x8")]
	[Token(Token = "0x60003B2")]
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	[Address(RVA = "0x2262730", Offset = "0x2261B30", Length = "0xEC")]
	[Token(Token = "0x60003B7")]
	protected private override Expression VisitBinary(BinaryExpression node) { }

	[Address(RVA = "0x2262820", Offset = "0x2261C20", Length = "0xEF")]
	[Token(Token = "0x60003B8")]
	protected private override Expression VisitBlock(BlockExpression node) { }

	[Address(RVA = "0x2262910", Offset = "0x2261D10", Length = "0x131")]
	[Token(Token = "0x60003C8")]
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	[Address(RVA = "0x2262A50", Offset = "0x2261E50", Length = "0x146")]
	[Token(Token = "0x60003B9")]
	protected private override Expression VisitConditional(ConditionalExpression node) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60003BA")]
	protected private override Expression VisitConstant(ConstantExpression node) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60003BB")]
	protected private override Expression VisitDefault(DefaultExpression node) { }

	[Address(RVA = "0x2255BA0", Offset = "0x2254FA0", Length = "0x2F")]
	[Token(Token = "0x60003BC")]
	protected private override Expression VisitExtension(Expression node) { }

	[Address(RVA = "0x2262BA0", Offset = "0x2261FA0", Length = "0xED")]
	[Token(Token = "0x60003BD")]
	protected private override Expression VisitGoto(GotoExpression node) { }

	[Address(RVA = "0x2262C90", Offset = "0x2262090", Length = "0xCA")]
	[Token(Token = "0x60003C4")]
	protected private override Expression VisitIndex(IndexExpression node) { }

	[Address(RVA = "0x2262D60", Offset = "0x2262160", Length = "0x91")]
	[Token(Token = "0x60003BE")]
	protected private override Expression VisitInvocation(InvocationExpression node) { }

	[Address(RVA = "0x2262E00", Offset = "0x2262200", Length = "0xBC")]
	[Token(Token = "0x60003C0")]
	protected private override Expression VisitLabel(LabelExpression node) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60003BF")]
	protected override LabelTarget VisitLabelTarget(LabelTarget node) { }

	[Address(RVA = "0x7EEDD0", Offset = "0x7EE1D0", Length = "0xBB")]
	[Token(Token = "0x60003C1")]
	protected private override Expression VisitLambda(Expression<T> node) { }

	[Address(RVA = "0x2262EC0", Offset = "0x22622C0", Length = "0xED")]
	[Token(Token = "0x60003C2")]
	protected private override Expression VisitLoop(LoopExpression node) { }

	[Address(RVA = "0x2262FB0", Offset = "0x22623B0", Length = "0xA5")]
	[Token(Token = "0x60003C3")]
	protected private override Expression VisitMember(MemberExpression node) { }

	[Address(RVA = "0x2263060", Offset = "0x2262460", Length = "0xC7")]
	[Token(Token = "0x60003C5")]
	protected private override Expression VisitMethodCall(MethodCallExpression node) { }

	[Address(RVA = "0x2263130", Offset = "0x2262530", Length = "0x17E")]
	[Token(Token = "0x60003C6")]
	protected private override Expression VisitNewArray(NewArrayExpression node) { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60003C7")]
	protected private override Expression VisitParameter(ParameterExpression node) { }

	[Address(RVA = "0x22632B0", Offset = "0x22626B0", Length = "0x8")]
	[Token(Token = "0x60003B3")]
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	[Address(RVA = "0x22632C0", Offset = "0x22626C0", Length = "0x1C2")]
	[Token(Token = "0x60003C9")]
	protected private override Expression VisitTry(TryExpression node) { }

	[Address(RVA = "0x2263490", Offset = "0x2262890", Length = "0xD1")]
	[Token(Token = "0x60003CA")]
	protected private override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	[Address(RVA = "0x2263570", Offset = "0x2262970", Length = "0x1E5")]
	[Token(Token = "0x60003CB")]
	protected private override Expression VisitUnary(UnaryExpression node) { }

}

