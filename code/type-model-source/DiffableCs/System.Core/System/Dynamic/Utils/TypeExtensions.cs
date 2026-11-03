namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x2000282")]
internal static class TypeExtensions
{
	[Token(Token = "0x4000485")]
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; //Field offset: 0x0

	[Address(RVA = "0x22B4950", Offset = "0x22B3D50", Length = "0x89")]
	[Token(Token = "0x6000C87")]
	private static TypeExtensions() { }

	[Address(RVA = "0x22B4480", Offset = "0x22B3880", Length = "0xAB")]
	[Extension]
	[Token(Token = "0x6000C82")]
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[Address(RVA = "0x22B4530", Offset = "0x22B3930", Length = "0x119")]
	[Extension]
	[Token(Token = "0x6000C86")]
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	[Address(RVA = "0x22B4650", Offset = "0x22B3A50", Length = "0xA6")]
	[Extension]
	[Token(Token = "0x6000C84")]
	public static Type GetReturnType(MethodBase mi) { }

	[Address(RVA = "0x22B4700", Offset = "0x22B3B00", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x6000C85")]
	public static TypeCode GetTypeCode(Type type) { }

	[Address(RVA = "0x22B4730", Offset = "0x22B3B30", Length = "0x21B")]
	[Extension]
	[Token(Token = "0x6000C83")]
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

}

