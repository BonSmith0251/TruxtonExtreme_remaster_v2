namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x2000280")]
internal static class ExpressionUtils
{

	[Address(RVA = "0x22AE350", Offset = "0x22AD750", Length = "0x75")]
	[Token(Token = "0x6000C7B")]
	internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	[Address(RVA = "0x22AE3D0", Offset = "0x22AD7D0", Length = "0xE")]
	[Token(Token = "0x6000C78")]
	public static void RequiresCanRead(Expression expression, string paramName) { }

	[Address(RVA = "0x22AE3E0", Offset = "0x22AD7E0", Length = "0x24B")]
	[Token(Token = "0x6000C79")]
	public static void RequiresCanRead(Expression expression, string paramName, int idx) { }

	[Address(RVA = "0x7EE300", Offset = "0x7ED700", Length = "0x115")]
	[Token(Token = "0x6000C74")]
	public static T ReturnObject(object collectionOrT) { }

	[Address(RVA = "0x7EE530", Offset = "0x7ED930", Length = "0xFD")]
	[Token(Token = "0x6000C73")]
	public static ReadOnlyCollection<T> ReturnReadOnly(ref IReadOnlyList<T>& collection) { }

	[Address(RVA = "0x7EE850", Offset = "0x7EDC50", Length = "0x109")]
	[Token(Token = "0x6000C7C")]
	internal static bool SameElements(ref IEnumerable<T>& replacement, IReadOnlyList<T> current) { }

	[Address(RVA = "0x7EE630", Offset = "0x7EDA30", Length = "0x218")]
	[Token(Token = "0x6000C7D")]
	private static bool SameElementsInCollection(ICollection<T> replacement, IReadOnlyList<T> current) { }

	[Address(RVA = "0x22AE630", Offset = "0x22ADA30", Length = "0x1A5")]
	[Token(Token = "0x6000C7A")]
	public static bool TryQuote(Type parameterType, ref Expression argument) { }

	[Address(RVA = "0x22AE860", Offset = "0x22ADC60", Length = "0xDF")]
	[Token(Token = "0x6000C76")]
	public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	[Address(RVA = "0x22AE7E0", Offset = "0x22ADBE0", Length = "0x72")]
	[Extension]
	[Token(Token = "0x6000C7E")]
	public static void ValidateArgumentCount(LambdaExpression lambda) { }

	[Address(RVA = "0x22AE940", Offset = "0x22ADD40", Length = "0x456")]
	[Token(Token = "0x6000C75")]
	public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression>& arguments, string methodParamName) { }

	[Address(RVA = "0x22AEDA0", Offset = "0x22AE1A0", Length = "0x48C")]
	[Token(Token = "0x6000C77")]
	public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1) { }

}

