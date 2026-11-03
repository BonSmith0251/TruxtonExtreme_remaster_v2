namespace System.Linq.Expressions;

[Token(Token = "0x2000049")]
public abstract class Expression
{
	[Token(Token = "0x200004A")]
	public class BinaryExpressionProxy
	{

	}

	[Token(Token = "0x200004B")]
	public class BlockExpressionProxy
	{

	}

	[Token(Token = "0x200004C")]
	public class CatchBlockProxy
	{

	}

	[Token(Token = "0x200004D")]
	public class ConditionalExpressionProxy
	{

	}

	[Token(Token = "0x200004E")]
	public class ConstantExpressionProxy
	{

	}

	[Token(Token = "0x200004F")]
	public class DebugInfoExpressionProxy
	{

	}

	[Token(Token = "0x2000050")]
	public class DefaultExpressionProxy
	{

	}

	[Token(Token = "0x2000064")]
	private class ExtensionInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D9")]
		internal readonly ExpressionType NodeType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000DA")]
		internal readonly Type Type; //Field offset: 0x18

	}

	[Token(Token = "0x2000051")]
	public class GotoExpressionProxy
	{

	}

	[Token(Token = "0x2000052")]
	public class IndexExpressionProxy
	{

	}

	[Token(Token = "0x2000053")]
	public class InvocationExpressionProxy
	{

	}

	[Token(Token = "0x2000054")]
	public class LabelExpressionProxy
	{

	}

	[Token(Token = "0x2000055")]
	public class LambdaExpressionProxy
	{

	}

	[Token(Token = "0x2000056")]
	public class ListInitExpressionProxy
	{

	}

	[Token(Token = "0x2000057")]
	public class LoopExpressionProxy
	{

	}

	[Token(Token = "0x2000058")]
	public class MemberExpressionProxy
	{

	}

	[Token(Token = "0x2000059")]
	public class MemberInitExpressionProxy
	{

	}

	[Token(Token = "0x200005A")]
	public class MethodCallExpressionProxy
	{

	}

	[Token(Token = "0x200005B")]
	public class NewArrayExpressionProxy
	{

	}

	[Token(Token = "0x200005C")]
	public class NewExpressionProxy
	{

	}

	[Token(Token = "0x200005D")]
	public class ParameterExpressionProxy
	{

	}

	[Token(Token = "0x200005E")]
	public class RuntimeVariablesExpressionProxy
	{

	}

	[Token(Token = "0x200005F")]
	public class SwitchCaseProxy
	{

	}

	[Token(Token = "0x2000060")]
	public class SwitchExpressionProxy
	{

	}

	[Token(Token = "0x2000061")]
	public class TryExpressionProxy
	{

	}

	[Token(Token = "0x2000062")]
	public class TypeBinaryExpressionProxy
	{

	}

	[Token(Token = "0x2000063")]
	public class UnaryExpressionProxy
	{

	}

	[Token(Token = "0x40000D6")]
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; //Field offset: 0x0
	[Token(Token = "0x40000D7")]
	private static CacheDict<Type, Func`5<Expression, String, Boolean, ReadOnlyCollection`1<ParameterExpression>, LambdaExpression>> s_lambdaFactories; //Field offset: 0x8
	[Token(Token = "0x40000D8")]
	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable; //Field offset: 0x10

	[Token(Token = "0x17000055")]
	public override bool CanReduce
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000215")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000053")]
	public override ExpressionType NodeType
	{
		[Address(RVA = "0x224E800", Offset = "0x224DC00", Length = "0xEA")]
		[Token(Token = "0x6000213")]
		 get { } //Length: 234
	}

	[Token(Token = "0x17000054")]
	public override Type Type
	{
		[Address(RVA = "0x224E8F0", Offset = "0x224DCF0", Length = "0xEB")]
		[Token(Token = "0x6000214")]
		 get { } //Length: 235
	}

	[Address(RVA = "0x224E770", Offset = "0x224DB70", Length = "0x89")]
	[Token(Token = "0x600028E")]
	private static Expression() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000212")]
	protected Expression() { }

	[Address(RVA = "0x2234400", Offset = "0x2233800", Length = "0x2F")]
	[Token(Token = "0x6000218")]
	protected private override Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x2234BE0", Offset = "0x2233FE0", Length = "0x242")]
	[Token(Token = "0x60001DC")]
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x22346E0", Offset = "0x2233AE0", Length = "0x2A8")]
	[Token(Token = "0x60001DD")]
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2234430", Offset = "0x2233830", Length = "0x2A8")]
	[Token(Token = "0x60001DF")]
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2234990", Offset = "0x2233D90", Length = "0x248")]
	[Token(Token = "0x60001E0")]
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2235690", Offset = "0x2234A90", Length = "0x248")]
	[Token(Token = "0x60001F3")]
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2234E30", Offset = "0x2234230", Length = "0x540")]
	[Token(Token = "0x60001D8")]
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2235380", Offset = "0x2234780", Length = "0x5C")]
	[Token(Token = "0x60001D7")]
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	[Address(RVA = "0x22353E0", Offset = "0x22347E0", Length = "0x2A8")]
	[Token(Token = "0x60001F4")]
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x22358E0", Offset = "0x2234CE0", Length = "0xC3")]
	[Token(Token = "0x6000262")]
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	[Address(RVA = "0x2235A10", Offset = "0x2234E10", Length = "0x3CB")]
	[Token(Token = "0x6000227")]
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	[Address(RVA = "0x22359B0", Offset = "0x2234DB0", Length = "0x59")]
	[Token(Token = "0x6000226")]
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	[Address(RVA = "0x2235DE0", Offset = "0x22351E0", Length = "0x21D")]
	[Token(Token = "0x60001FB")]
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	[Address(RVA = "0x2236000", Offset = "0x2235400", Length = "0x1F5")]
	[Token(Token = "0x6000283")]
	public static UnaryExpression ArrayLength(Expression array) { }

	[Address(RVA = "0x2236200", Offset = "0x2235600", Length = "0x1FE")]
	[Token(Token = "0x60001B8")]
	public static BinaryExpression Assign(Expression left, Expression right) { }

	[Address(RVA = "0x2236CD0", Offset = "0x22360D0", Length = "0x106")]
	[Token(Token = "0x60001FE")]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x2236DE0", Offset = "0x22361E0", Length = "0xA0")]
	[Token(Token = "0x60001FC")]
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	[Address(RVA = "0x2237270", Offset = "0x2236670", Length = "0x8B")]
	[Token(Token = "0x6000200")]
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	[Address(RVA = "0x2236BE0", Offset = "0x2235FE0", Length = "0xEA")]
	[Token(Token = "0x6000201")]
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	[Address(RVA = "0x2236B40", Offset = "0x2235F40", Length = "0x9B")]
	[Token(Token = "0x6000202")]
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	[Address(RVA = "0x2237300", Offset = "0x2236700", Length = "0x59")]
	[Token(Token = "0x6000203")]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	[Address(RVA = "0x2236E80", Offset = "0x2236280", Length = "0x69")]
	[Token(Token = "0x6000204")]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	[Address(RVA = "0x2237100", Offset = "0x2236500", Length = "0x161")]
	[Token(Token = "0x6000205")]
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	[Address(RVA = "0x2237020", Offset = "0x2236420", Length = "0xD4")]
	[Token(Token = "0x60001FD")]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x2236920", Offset = "0x2235D20", Length = "0x21C")]
	[Token(Token = "0x6000206")]
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	[Address(RVA = "0x2236EF0", Offset = "0x22362F0", Length = "0x12D")]
	[Token(Token = "0x60001FF")]
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x2236400", Offset = "0x2235800", Length = "0x510")]
	[Token(Token = "0x6000207")]
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x2237360", Offset = "0x2236760", Length = "0x8F")]
	[Token(Token = "0x600021D")]
	public static GotoExpression Break(LabelTarget target) { }

	[Address(RVA = "0x2238FB0", Offset = "0x22383B0", Length = "0x69")]
	[Token(Token = "0x6000252")]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	[Address(RVA = "0x2238880", Offset = "0x2237C80", Length = "0xBC")]
	[Token(Token = "0x6000249")]
	internal static MethodCallExpression Call(MethodInfo method) { }

	[Address(RVA = "0x2238C00", Offset = "0x2238000", Length = "0x146")]
	[Token(Token = "0x600024A")]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	[Address(RVA = "0x2238D50", Offset = "0x2238150", Length = "0x1C5")]
	[Token(Token = "0x600024B")]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x2237D50", Offset = "0x2237150", Length = "0x23D")]
	[Token(Token = "0x600024C")]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x2238940", Offset = "0x2237D40", Length = "0x2B6")]
	[Token(Token = "0x600024D")]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x22381B0", Offset = "0x22375B0", Length = "0x329")]
	[Token(Token = "0x600024E")]
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x2238F20", Offset = "0x2238320", Length = "0x8C")]
	[Token(Token = "0x600024F")]
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	[Address(RVA = "0x2239320", Offset = "0x2238720", Length = "0x5B")]
	[Token(Token = "0x6000250")]
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	[Address(RVA = "0x2238770", Offset = "0x2237B70", Length = "0x10E")]
	[Token(Token = "0x6000251")]
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	[Address(RVA = "0x2239020", Offset = "0x2238420", Length = "0x198")]
	[Token(Token = "0x6000253")]
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	[Address(RVA = "0x2237F90", Offset = "0x2237390", Length = "0x212")]
	[Token(Token = "0x6000254")]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x22384E0", Offset = "0x22378E0", Length = "0x28A")]
	[Token(Token = "0x6000255")]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x22391C0", Offset = "0x22385C0", Length = "0x15B")]
	[Token(Token = "0x6000256")]
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	[Address(RVA = "0x22373F0", Offset = "0x22367F0", Length = "0x954")]
	[Token(Token = "0x6000257")]
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	[Address(RVA = "0x2239380", Offset = "0x2238780", Length = "0x69B")]
	[Token(Token = "0x60001DA")]
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	[Address(RVA = "0x2239C90", Offset = "0x2239090", Length = "0x207")]
	[Token(Token = "0x600020B")]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	[Address(RVA = "0x2239A20", Offset = "0x2238E20", Length = "0x26A")]
	[Token(Token = "0x600020C")]
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[Address(RVA = "0x223A0E0", Offset = "0x22394E0", Length = "0x54")]
	[Token(Token = "0x600020E")]
	public static ConstantExpression Constant(object value) { }

	[Address(RVA = "0x2239EA0", Offset = "0x22392A0", Length = "0x237")]
	[Token(Token = "0x600020F")]
	public static ConstantExpression Constant(object value, Type type) { }

	[Address(RVA = "0x223A380", Offset = "0x2239780", Length = "0x205")]
	[Token(Token = "0x6000281")]
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	[Address(RVA = "0x223A590", Offset = "0x2239990", Length = "0x5C")]
	[Token(Token = "0x6000280")]
	public static UnaryExpression Convert(Expression expression, Type type) { }

	[Address(RVA = "0x223A140", Offset = "0x2239540", Length = "0x231")]
	[Token(Token = "0x6000282")]
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	[Address(RVA = "0x223A5F0", Offset = "0x22399F0", Length = "0x555")]
	[Token(Token = "0x600023B")]
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	[Address(RVA = "0x223AB50", Offset = "0x2239F50", Length = "0x190")]
	[Token(Token = "0x6000287")]
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x223ACF0", Offset = "0x223A0F0", Length = "0xA5")]
	[Token(Token = "0x6000211")]
	public static DefaultExpression Default(Type type) { }

	[Address(RVA = "0x223B050", Offset = "0x223A450", Length = "0x248")]
	[Token(Token = "0x60001E5")]
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x223ADA0", Offset = "0x223A1A0", Length = "0x2A8")]
	[Token(Token = "0x60001E6")]
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x223B2A0", Offset = "0x223A6A0", Length = "0x7B")]
	[Token(Token = "0x6000210")]
	public static DefaultExpression Empty() { }

	[Address(RVA = "0x223B390", Offset = "0x223A790", Length = "0x116")]
	[Token(Token = "0x60001CC")]
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x223B320", Offset = "0x223A720", Length = "0x66")]
	[Token(Token = "0x60001CB")]
	public static BinaryExpression Equal(Expression left, Expression right) { }

	[Address(RVA = "0x223B760", Offset = "0x223AB60", Length = "0x248")]
	[Token(Token = "0x60001F7")]
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x223B4B0", Offset = "0x223A8B0", Length = "0x2A8")]
	[Token(Token = "0x60001F8")]
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x223BB40", Offset = "0x223AF40", Length = "0x1F5")]
	[Token(Token = "0x6000244")]
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	[Address(RVA = "0x223B9B0", Offset = "0x223ADB0", Length = "0x181")]
	[Token(Token = "0x6000245")]
	public static MemberExpression Field(Expression expression, string fieldName) { }

	[Address(RVA = "0x223BD40", Offset = "0x223B140", Length = "0x31E")]
	[Token(Token = "0x6000260")]
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000215")]
	public override bool get_CanReduce() { }

	[Address(RVA = "0x224E800", Offset = "0x224DC00", Length = "0xEA")]
	[Token(Token = "0x6000213")]
	public override ExpressionType get_NodeType() { }

	[Address(RVA = "0x224E8F0", Offset = "0x224DCF0", Length = "0xEB")]
	[Token(Token = "0x6000214")]
	public override Type get_Type() { }

	[Address(RVA = "0x223C060", Offset = "0x223B460", Length = "0x23B")]
	[Token(Token = "0x60001D6")]
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	[Address(RVA = "0x223C2A0", Offset = "0x223B6A0", Length = "0x46E")]
	[Token(Token = "0x60001D1")]
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	[Address(RVA = "0x223C710", Offset = "0x223BB10", Length = "0x208")]
	[Token(Token = "0x6000234")]
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	[Address(RVA = "0x223C920", Offset = "0x223BD20", Length = "0x2B9")]
	[Token(Token = "0x60001BB")]
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	[Address(RVA = "0x223CBE0", Offset = "0x223BFE0", Length = "0x68A")]
	[Token(Token = "0x60001BA")]
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	[Address(RVA = "0x223D270", Offset = "0x223C670", Length = "0x405")]
	[Token(Token = "0x6000275")]
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	[Address(RVA = "0x223D680", Offset = "0x223CA80", Length = "0x424")]
	[Token(Token = "0x6000272")]
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	[Address(RVA = "0x223DAB0", Offset = "0x223CEB0", Length = "0xF0")]
	[Token(Token = "0x6000209")]
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	[Address(RVA = "0x223DF10", Offset = "0x223D310", Length = "0x8")]
	[Token(Token = "0x600025C")]
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	[Address(RVA = "0x223DF20", Offset = "0x223D320", Length = "0x163")]
	[Token(Token = "0x60001EE")]
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	[Address(RVA = "0x223E090", Offset = "0x223D490", Length = "0x2B9")]
	[Token(Token = "0x60001BD")]
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	[Address(RVA = "0x223E5B0", Offset = "0x223D9B0", Length = "0x406")]
	[Token(Token = "0x60001B9")]
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	[Address(RVA = "0x223E9C0", Offset = "0x223DDC0", Length = "0x2BA")]
	[Token(Token = "0x60001BE")]
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	[Address(RVA = "0x223E350", Offset = "0x223D750", Length = "0x25B")]
	[Token(Token = "0x60001BC")]
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	[Address(RVA = "0x223EDF0", Offset = "0x223E1F0", Length = "0xF9")]
	[Token(Token = "0x6000274")]
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	[Address(RVA = "0x223EC80", Offset = "0x223E080", Length = "0x169")]
	[Token(Token = "0x6000273")]
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	[Address(RVA = "0x223F090", Offset = "0x223E490", Length = "0x34A")]
	[Token(Token = "0x6000271")]
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	[Address(RVA = "0x223EEF0", Offset = "0x223E2F0", Length = "0x193")]
	[Token(Token = "0x6000270")]
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	[Address(RVA = "0x223F3E0", Offset = "0x223E7E0", Length = "0x99")]
	[Token(Token = "0x6000221")]
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	[Address(RVA = "0x223F480", Offset = "0x223E880", Length = "0x65")]
	[Token(Token = "0x6000220")]
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	[Address(RVA = "0x223F610", Offset = "0x223EA10", Length = "0x116")]
	[Token(Token = "0x60001D2")]
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x223F4F0", Offset = "0x223E8F0", Length = "0x116")]
	[Token(Token = "0x60001D4")]
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x223F730", Offset = "0x223EB30", Length = "0x104")]
	[Token(Token = "0x600020D")]
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	[Address(RVA = "0x223F840", Offset = "0x223EC40", Length = "0x190")]
	[Token(Token = "0x6000286")]
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2240090", Offset = "0x223F490", Length = "0xFC")]
	[Token(Token = "0x600022D")]
	internal static InvocationExpression Invoke(Expression expression) { }

	[Address(RVA = "0x22408C0", Offset = "0x223FCC0", Length = "0x17E")]
	[Token(Token = "0x600022E")]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	[Address(RVA = "0x2240190", Offset = "0x223F590", Length = "0x1E1")]
	[Token(Token = "0x600022F")]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	[Address(RVA = "0x2240380", Offset = "0x223F780", Length = "0x23A")]
	[Token(Token = "0x6000230")]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	[Address(RVA = "0x2240A40", Offset = "0x223FE40", Length = "0x29C")]
	[Token(Token = "0x6000231")]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	[Address(RVA = "0x22405C0", Offset = "0x223F9C0", Length = "0x2FD")]
	[Token(Token = "0x6000232")]
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	[Address(RVA = "0x223F9E0", Offset = "0x223EDE0", Length = "0x690")]
	[Token(Token = "0x6000233")]
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	[Address(RVA = "0x2240CE0", Offset = "0x22400E0", Length = "0x24A")]
	[Token(Token = "0x6000261")]
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	[Address(RVA = "0x2240F30", Offset = "0x2240330", Length = "0x190")]
	[Token(Token = "0x600027B")]
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x22410D0", Offset = "0x22404D0", Length = "0xBB")]
	[Token(Token = "0x60001BF")]
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	[Address(RVA = "0x2241190", Offset = "0x2240590", Length = "0x222")]
	[Token(Token = "0x60001C4")]
	private static bool IsNullComparison(Expression left, Expression right) { }

	[Address(RVA = "0x22413C0", Offset = "0x22407C0", Length = "0x6B")]
	[Token(Token = "0x60001C5")]
	private static bool IsNullConstant(Expression e) { }

	[Address(RVA = "0x2241430", Offset = "0x2240830", Length = "0xBB")]
	[Token(Token = "0x60001ED")]
	private static bool IsSimpleShift(Type left, Type right) { }

	[Address(RVA = "0x22414F0", Offset = "0x22408F0", Length = "0x190")]
	[Token(Token = "0x600027C")]
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2241690", Offset = "0x2240A90", Length = "0x105")]
	[Token(Token = "0x60001C8")]
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	[Address(RVA = "0x22418F0", Offset = "0x2240CF0", Length = "0xFA")]
	[Token(Token = "0x6000235")]
	public static LabelExpression Label(LabelTarget target) { }

	[Address(RVA = "0x2241A70", Offset = "0x2240E70", Length = "0xB5")]
	[Token(Token = "0x600023A")]
	public static LabelTarget Label(Type type, string name) { }

	[Address(RVA = "0x2241B30", Offset = "0x2240F30", Length = "0x4C")]
	[Token(Token = "0x6000239")]
	public static LabelTarget Label(Type type) { }

	[Address(RVA = "0x22417A0", Offset = "0x2240BA0", Length = "0x80")]
	[Token(Token = "0x6000238")]
	public static LabelTarget Label(string name) { }

	[Address(RVA = "0x22419F0", Offset = "0x2240DF0", Length = "0x73")]
	[Token(Token = "0x6000237")]
	public static LabelTarget Label() { }

	[Address(RVA = "0x2241820", Offset = "0x2240C20", Length = "0xCB")]
	[Token(Token = "0x6000236")]
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	[Address(RVA = "0x7EF890", Offset = "0x7EEC90", Length = "0x19E")]
	[Token(Token = "0x600023D")]
	public static Expression<TDelegate> Lambda(Expression body, IEnumerable<ParameterExpression> parameters) { }

	[Address(RVA = "0x7EF590", Offset = "0x7EE990", Length = "0x76")]
	[Token(Token = "0x600023C")]
	public static Expression<TDelegate> Lambda(Expression body, ParameterExpression[] parameters) { }

	[Address(RVA = "0x2241C80", Offset = "0x2241080", Length = "0xD7")]
	[Token(Token = "0x6000241")]
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[Address(RVA = "0x2241B80", Offset = "0x2240F80", Length = "0xF4")]
	[Token(Token = "0x6000240")]
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	[Address(RVA = "0x7EF690", Offset = "0x7EEA90", Length = "0x8A")]
	[Token(Token = "0x600023E")]
	public static Expression<TDelegate> Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[Address(RVA = "0x7EF720", Offset = "0x7EEB20", Length = "0x16F")]
	[Token(Token = "0x600023F")]
	public static Expression<TDelegate> Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	[Address(RVA = "0x2242000", Offset = "0x2241400", Length = "0x23F")]
	[Token(Token = "0x60001EF")]
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2241D60", Offset = "0x2241160", Length = "0x29C")]
	[Token(Token = "0x60001F0")]
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2242360", Offset = "0x2241760", Length = "0x116")]
	[Token(Token = "0x60001D3")]
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x2242240", Offset = "0x2241640", Length = "0x116")]
	[Token(Token = "0x60001D5")]
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x2242480", Offset = "0x2241880", Length = "0x114")]
	[Token(Token = "0x6000243")]
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	[Address(RVA = "0x2243370", Offset = "0x2242770", Length = "0x8D")]
	[Token(Token = "0x60001C9")]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x22425A0", Offset = "0x22419A0", Length = "0x58")]
	[Token(Token = "0x60001CA")]
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2243400", Offset = "0x2242800", Length = "0x27C")]
	[Token(Token = "0x600020A")]
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	[Address(RVA = "0x2243680", Offset = "0x2242A80", Length = "0xE7")]
	[Token(Token = "0x6000222")]
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[Address(RVA = "0x2243840", Offset = "0x2242C40", Length = "0x190")]
	[Token(Token = "0x6000225")]
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	[Address(RVA = "0x2243770", Offset = "0x2242B70", Length = "0xC1")]
	[Token(Token = "0x6000229")]
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	[Address(RVA = "0x22439D0", Offset = "0x2242DD0", Length = "0x1AB")]
	[Token(Token = "0x6000248")]
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	[Address(RVA = "0x2243B80", Offset = "0x2242F80", Length = "0x2A0")]
	[Token(Token = "0x600028D")]
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2243E30", Offset = "0x2243230", Length = "0x246")]
	[Token(Token = "0x600026B")]
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	[Address(RVA = "0x2244080", Offset = "0x2243480", Length = "0x1020")]
	[Token(Token = "0x600026F")]
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	[Address(RVA = "0x2245390", Offset = "0x2244790", Length = "0x248")]
	[Token(Token = "0x60001E7")]
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x22450E0", Offset = "0x22444E0", Length = "0x2A8")]
	[Token(Token = "0x60001E8")]
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2245D90", Offset = "0x2245190", Length = "0x248")]
	[Token(Token = "0x60001E9")]
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2245890", Offset = "0x2244C90", Length = "0x2A8")]
	[Token(Token = "0x60001EA")]
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x22455E0", Offset = "0x22449E0", Length = "0x2A8")]
	[Token(Token = "0x60001EB")]
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2245B40", Offset = "0x2244F40", Length = "0x248")]
	[Token(Token = "0x60001EC")]
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x22461C0", Offset = "0x22455C0", Length = "0x1D0")]
	[Token(Token = "0x6000276")]
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2245FE0", Offset = "0x22453E0", Length = "0x1D0")]
	[Token(Token = "0x6000278")]
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x22463A0", Offset = "0x22457A0", Length = "0x2BC")]
	[Token(Token = "0x6000265")]
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	[Address(RVA = "0x2246AE0", Offset = "0x2245EE0", Length = "0x59")]
	[Token(Token = "0x6000263")]
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	[Address(RVA = "0x2246660", Offset = "0x2245A60", Length = "0x475")]
	[Token(Token = "0x6000264")]
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	[Address(RVA = "0x2246D20", Offset = "0x2246120", Length = "0x1D1")]
	[Token(Token = "0x600027A")]
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2246CD0", Offset = "0x22460D0", Length = "0x4C")]
	[Token(Token = "0x6000279")]
	public static UnaryExpression Not(Expression expression) { }

	[Address(RVA = "0x2246BB0", Offset = "0x2245FB0", Length = "0x116")]
	[Token(Token = "0x60001CF")]
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	[Address(RVA = "0x2246B40", Offset = "0x2245F40", Length = "0x66")]
	[Token(Token = "0x60001CE")]
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	[Address(RVA = "0x2246F00", Offset = "0x2246300", Length = "0x190")]
	[Token(Token = "0x600027D")]
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x22478B0", Offset = "0x2246CB0", Length = "0x248")]
	[Token(Token = "0x60001F5")]
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x22470A0", Offset = "0x22464A0", Length = "0x2A8")]
	[Token(Token = "0x60001F6")]
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2247350", Offset = "0x2246750", Length = "0x55C")]
	[Token(Token = "0x60001D9")]
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2247BB0", Offset = "0x2246FB0", Length = "0xCC")]
	[Token(Token = "0x6000266")]
	public static ParameterExpression Parameter(Type type) { }

	[Address(RVA = "0x2247C80", Offset = "0x2247080", Length = "0xA9")]
	[Token(Token = "0x6000267")]
	public static ParameterExpression Parameter(Type type, string name) { }

	[Address(RVA = "0x2247B00", Offset = "0x2246F00", Length = "0xA8")]
	[Token(Token = "0x60001C0")]
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	[Address(RVA = "0x2247D30", Offset = "0x2247130", Length = "0x5E")]
	[Token(Token = "0x600028C")]
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2247D90", Offset = "0x2247190", Length = "0x5E")]
	[Token(Token = "0x600028B")]
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2247F90", Offset = "0x2247390", Length = "0x3EF")]
	[Token(Token = "0x60001F9")]
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2247DF0", Offset = "0x22471F0", Length = "0x197")]
	[Token(Token = "0x60001FA")]
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2248380", Offset = "0x2247780", Length = "0x5E")]
	[Token(Token = "0x600028A")]
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x2248440", Offset = "0x2247840", Length = "0x52")]
	[Token(Token = "0x6000288")]
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	[Address(RVA = "0x22483E0", Offset = "0x22477E0", Length = "0x5E")]
	[Token(Token = "0x6000289")]
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x22484A0", Offset = "0x22478A0", Length = "0x364")]
	[Token(Token = "0x6000247")]
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	[Address(RVA = "0x2248810", Offset = "0x2247C10", Length = "0x17B")]
	[Token(Token = "0x6000246")]
	public static MemberExpression Property(Expression expression, string propertyName) { }

	[Address(RVA = "0x2248990", Offset = "0x2247D90", Length = "0x123")]
	[Token(Token = "0x6000228")]
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	[Address(RVA = "0x2248AC0", Offset = "0x2247EC0", Length = "0x114")]
	[Token(Token = "0x6000284")]
	public static UnaryExpression Quote(Expression expression) { }

	[Address(RVA = "0x2248D30", Offset = "0x2248130", Length = "0x4A")]
	[Token(Token = "0x6000216")]
	public override Expression Reduce() { }

	[Address(RVA = "0x2248BE0", Offset = "0x2247FE0", Length = "0x14B")]
	[Token(Token = "0x6000219")]
	public Expression ReduceAndCheck() { }

	[Address(RVA = "0x2248D80", Offset = "0x2248180", Length = "0x184")]
	[Token(Token = "0x60001CD")]
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	[Address(RVA = "0x2248F10", Offset = "0x2248310", Length = "0x184")]
	[Token(Token = "0x60001D0")]
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	[Address(RVA = "0x22490A0", Offset = "0x22484A0", Length = "0x115")]
	[Token(Token = "0x600021B")]
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	[Address(RVA = "0x22491C0", Offset = "0x22485C0", Length = "0x299")]
	[Token(Token = "0x600021C")]
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	[Address(RVA = "0x22494F0", Offset = "0x22488F0", Length = "0x9C")]
	[Token(Token = "0x600021F")]
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	[Address(RVA = "0x2249460", Offset = "0x2248860", Length = "0x8F")]
	[Token(Token = "0x600021E")]
	public static GotoExpression Return(LabelTarget target) { }

	[Address(RVA = "0x2249830", Offset = "0x2248C30", Length = "0x23F")]
	[Token(Token = "0x60001F1")]
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2249590", Offset = "0x2248990", Length = "0x29C")]
	[Token(Token = "0x60001F2")]
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x224A220", Offset = "0x2249620", Length = "0x248")]
	[Token(Token = "0x60001E1")]
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x2249D20", Offset = "0x2249120", Length = "0x2A8")]
	[Token(Token = "0x60001E2")]
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2249A70", Offset = "0x2248E70", Length = "0x2A8")]
	[Token(Token = "0x60001E3")]
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	[Address(RVA = "0x2249FD0", Offset = "0x22493D0", Length = "0x248")]
	[Token(Token = "0x60001E4")]
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	[Address(RVA = "0x224A470", Offset = "0x2249870", Length = "0x149")]
	[Token(Token = "0x6000285")]
	public static UnaryExpression Throw(Expression value, Type type) { }

	[Address(RVA = "0x224A5C0", Offset = "0x22499C0", Length = "0x7")]
	[Token(Token = "0x600021A")]
	public virtual string ToString() { }

	[Address(RVA = "0x224A5D0", Offset = "0x22499D0", Length = "0x68")]
	[Token(Token = "0x600026A")]
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	[Address(RVA = "0x224A640", Offset = "0x2249A40", Length = "0x8")]
	[Token(Token = "0x600025F")]
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	[Address(RVA = "0x224A650", Offset = "0x2249A50", Length = "0x151")]
	[Token(Token = "0x600027E")]
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	[Address(RVA = "0x224A7B0", Offset = "0x2249BB0", Length = "0xF5")]
	[Token(Token = "0x600026E")]
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	[Address(RVA = "0x224A8B0", Offset = "0x2249CB0", Length = "0xF5")]
	[Token(Token = "0x600026D")]
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	[Address(RVA = "0x224A9B0", Offset = "0x2249DB0", Length = "0x190")]
	[Token(Token = "0x6000277")]
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	[Address(RVA = "0x224AB50", Offset = "0x2249F50", Length = "0x1F5")]
	[Token(Token = "0x600027F")]
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	[Address(RVA = "0x224E260", Offset = "0x224D660", Length = "0xF2")]
	[Token(Token = "0x6000269")]
	private static void Validate(Type type, bool allowByRef) { }

	[Address(RVA = "0x224B260", Offset = "0x224A660", Length = "0x266")]
	[Token(Token = "0x600022B")]
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	[Address(RVA = "0x224AD50", Offset = "0x224A150", Length = "0x501")]
	[Token(Token = "0x600022C")]
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression>& arguments, string paramName) { }

	[Address(RVA = "0x224B4D0", Offset = "0x224A8D0", Length = "0xE")]
	[Token(Token = "0x600025D")]
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	[Address(RVA = "0x224B4E0", Offset = "0x224A8E0", Length = "0xE")]
	[Token(Token = "0x600025B")]
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression>& arguments, string methodParamName) { }

	[Address(RVA = "0x224B4F0", Offset = "0x224A8F0", Length = "0x9E")]
	[Token(Token = "0x600025A")]
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	[Address(RVA = "0x224B590", Offset = "0x224A990", Length = "0x1AB")]
	[Token(Token = "0x60001DB")]
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	[Address(RVA = "0x224B890", Offset = "0x224AC90", Length = "0x29D")]
	[Token(Token = "0x6000223")]
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	[Address(RVA = "0x224B740", Offset = "0x224AB40", Length = "0x14D")]
	[Token(Token = "0x6000224")]
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	[Address(RVA = "0x224BB30", Offset = "0x224AF30", Length = "0x66F")]
	[Token(Token = "0x600022A")]
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression>& argList) { }

	[Address(RVA = "0x224C1A0", Offset = "0x224B5A0", Length = "0x742")]
	[Token(Token = "0x6000242")]
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	[Address(RVA = "0x224C8F0", Offset = "0x224BCF0", Length = "0x1C0")]
	[Token(Token = "0x6000258")]
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	[Address(RVA = "0x224CAC0", Offset = "0x224BEC0", Length = "0x85")]
	[Token(Token = "0x60001C3")]
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	[Address(RVA = "0x224CB50", Offset = "0x224BF50", Length = "0x33")]
	[Token(Token = "0x600025E")]
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	[Address(RVA = "0x224CB90", Offset = "0x224BF90", Length = "0x2C9")]
	[Token(Token = "0x60001DE")]
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	[Address(RVA = "0x224CE60", Offset = "0x224C260", Length = "0x1A6")]
	[Token(Token = "0x60001C2")]
	private static void ValidateOperator(MethodInfo method) { }

	[Address(RVA = "0x224D010", Offset = "0x224C410", Length = "0xDC")]
	[Token(Token = "0x60001C1")]
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	[Address(RVA = "0x224D0F0", Offset = "0x224C4F0", Length = "0xF9")]
	[Token(Token = "0x6000259")]
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	[Address(RVA = "0x224D1F0", Offset = "0x224C5F0", Length = "0x628")]
	[Token(Token = "0x600026C")]
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	[Address(RVA = "0x224D820", Offset = "0x224CC20", Length = "0x88E")]
	[Token(Token = "0x60001C6")]
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	[Address(RVA = "0x224E0B0", Offset = "0x224D4B0", Length = "0x1A5")]
	[Token(Token = "0x6000208")]
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	[Address(RVA = "0x224E360", Offset = "0x224D760", Length = "0x69")]
	[Token(Token = "0x6000268")]
	public static ParameterExpression Variable(Type type, string name) { }

	[Address(RVA = "0x224E3D0", Offset = "0x224D7D0", Length = "0x1DC")]
	[Token(Token = "0x60001C7")]
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	[Address(RVA = "0x224E5B0", Offset = "0x224D9B0", Length = "0x1B5")]
	[Token(Token = "0x6000217")]
	protected private override Expression VisitChildren(ExpressionVisitor visitor) { }

}

