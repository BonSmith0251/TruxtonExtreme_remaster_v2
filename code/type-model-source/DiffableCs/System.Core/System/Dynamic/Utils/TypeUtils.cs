namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x2000283")]
internal static class TypeUtils
{
	[CompilerGenerated]
	[Token(Token = "0x2000284")]
	private sealed class <>c
	{
		[Token(Token = "0x4000487")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x22B95F0", Offset = "0x22B89F0", Length = "0x67")]
		[Token(Token = "0x6000CB3")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CB4")]
		public <>c() { }

		[Address(RVA = "0x22B9550", Offset = "0x22B8950", Length = "0x2C")]
		[Token(Token = "0x6000CB5")]
		internal bool <.cctor>b__44_0(Type i) { }

		[Address(RVA = "0x22B9580", Offset = "0x22B8980", Length = "0x2C")]
		[Token(Token = "0x6000CB6")]
		internal Type <.cctor>b__44_1(Type i) { }

	}

	[Token(Token = "0x4000486")]
	private static readonly Type[] s_arrayAssignableInterfaces; //Field offset: 0x0

	[Address(RVA = "0x22B8AA0", Offset = "0x22B7EA0", Length = "0x1D1")]
	[Token(Token = "0x6000CB2")]
	private static TypeUtils() { }

	[Address(RVA = "0x22B49E0", Offset = "0x22B3DE0", Length = "0x6F")]
	[Token(Token = "0x6000CAB")]
	public static bool AreEquivalent(Type t1, Type t2) { }

	[Address(RVA = "0x22B4A50", Offset = "0x22B3E50", Length = "0xF6")]
	[Token(Token = "0x6000CAC")]
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	[Address(RVA = "0x22B4B50", Offset = "0x22B3F50", Length = "0x1DE")]
	[Token(Token = "0x6000CA3")]
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	[Address(RVA = "0x22B4D30", Offset = "0x22B4130", Length = "0x307")]
	[Token(Token = "0x6000CA8")]
	public static Type FindGenericType(Type definition, Type type) { }

	[Address(RVA = "0x22B5040", Offset = "0x22B4440", Length = "0x1F2")]
	[Token(Token = "0x6000CA9")]
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[Address(RVA = "0x22B5240", Offset = "0x22B4640", Length = "0x4C")]
	[Extension]
	[Token(Token = "0x6000CB1")]
	public static MethodInfo GetInvokeMethod(Type delegateType) { }

	[Address(RVA = "0x22B5290", Offset = "0x22B4690", Length = "0x8C")]
	[Extension]
	[Token(Token = "0x6000C88")]
	public static Type GetNonNullableType(Type type) { }

	[Address(RVA = "0x22B5320", Offset = "0x22B4720", Length = "0x43")]
	[Extension]
	[Token(Token = "0x6000CAA")]
	public static Type GetNonRefType(Type type) { }

	[Address(RVA = "0x22B5370", Offset = "0x22B4770", Length = "0x151")]
	[Extension]
	[Token(Token = "0x6000C89")]
	public static Type GetNullableType(Type type) { }

	[Address(RVA = "0x22B54D0", Offset = "0x22B48D0", Length = "0x3A0")]
	[Token(Token = "0x6000CA2")]
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	[Address(RVA = "0x22B5880", Offset = "0x22B4C80", Length = "0x223")]
	[Token(Token = "0x6000C97")]
	private static bool HasArrayToInterfaceConversion(Type source, Type dest) { }

	[Address(RVA = "0x22B5AB0", Offset = "0x22B4EB0", Length = "0x218")]
	[Token(Token = "0x6000CA0")]
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[Address(RVA = "0x22B5CD0", Offset = "0x22B50D0", Length = "0x316")]
	[Extension]
	[Token(Token = "0x6000C94")]
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[Address(RVA = "0x22B5FF0", Offset = "0x22B53F0", Length = "0x223")]
	[Token(Token = "0x6000C98")]
	private static bool HasInterfaceToArrayConversion(Type source, Type dest) { }

	[Address(RVA = "0x22B6220", Offset = "0x22B5620", Length = "0x205")]
	[Extension]
	[Token(Token = "0x6000C95")]
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	[Address(RVA = "0x22B6430", Offset = "0x22B5830", Length = "0xED")]
	[Token(Token = "0x6000C9F")]
	public static bool HasReferenceEquality(Type left, Type right) { }

	[Address(RVA = "0x22B6520", Offset = "0x22B5920", Length = "0x128")]
	[Extension]
	[Token(Token = "0x6000C8F")]
	public static bool IsArithmetic(Type type) { }

	[Address(RVA = "0x22B6650", Offset = "0x22B5A50", Length = "0xF2")]
	[Extension]
	[Token(Token = "0x6000C8C")]
	public static bool IsBool(Type type) { }

	[Address(RVA = "0x22B6750", Offset = "0x22B5B50", Length = "0x2B")]
	[Token(Token = "0x6000C9A")]
	private static bool IsContravariant(Type t) { }

	[Address(RVA = "0x22B6780", Offset = "0x22B5B80", Length = "0x129")]
	[Extension]
	[Token(Token = "0x6000C9E")]
	public static bool IsConvertible(Type type) { }

	[Address(RVA = "0x22B68B0", Offset = "0x22B5CB0", Length = "0x28")]
	[Token(Token = "0x6000C99")]
	private static bool IsCovariant(Type t) { }

	[Address(RVA = "0x22B68E0", Offset = "0x22B5CE0", Length = "0x7D")]
	[Token(Token = "0x6000C9C")]
	private static bool IsDelegate(Type t) { }

	[Address(RVA = "0x22B6960", Offset = "0x22B5D60", Length = "0x124")]
	[Token(Token = "0x6000CA6")]
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	[Address(RVA = "0x22B6E00", Offset = "0x22B6200", Length = "0x13C")]
	[Extension]
	[Token(Token = "0x6000CA1")]
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	[Address(RVA = "0x22B6A90", Offset = "0x22B5E90", Length = "0x170")]
	[Token(Token = "0x6000CA7")]
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	[Address(RVA = "0x22B6C10", Offset = "0x22B6010", Length = "0x14C")]
	[Token(Token = "0x6000CA4")]
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	[Address(RVA = "0x22B6DD0", Offset = "0x22B61D0", Length = "0x2F")]
	[Token(Token = "0x6000CA5")]
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	[Address(RVA = "0x22B7420", Offset = "0x22B6820", Length = "0x128")]
	[Extension]
	[Token(Token = "0x6000C8E")]
	public static bool IsInteger(Type type) { }

	[Address(RVA = "0x22B72E0", Offset = "0x22B66E0", Length = "0x13D")]
	[Extension]
	[Token(Token = "0x6000C91")]
	public static bool IsIntegerOrBool(Type type) { }

	[Address(RVA = "0x22B7550", Offset = "0x22B6950", Length = "0x2B")]
	[Token(Token = "0x6000C9B")]
	private static bool IsInvariant(Type t) { }

	[Address(RVA = "0x22B7580", Offset = "0x22B6980", Length = "0x434")]
	[Token(Token = "0x6000C9D")]
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[Address(RVA = "0x22B79C0", Offset = "0x22B6DC0", Length = "0x69")]
	[Extension]
	[Token(Token = "0x6000C8B")]
	public static bool IsNullableOrReferenceType(Type type) { }

	[Address(RVA = "0x22B7A30", Offset = "0x22B6E30", Length = "0xAB")]
	[Extension]
	[Token(Token = "0x6000C8A")]
	public static bool IsNullableType(Type type) { }

	[Address(RVA = "0x22B7C30", Offset = "0x22B7030", Length = "0x128")]
	[Extension]
	[Token(Token = "0x6000C8D")]
	public static bool IsNumeric(Type type) { }

	[Address(RVA = "0x22B7AE0", Offset = "0x22B6EE0", Length = "0x14E")]
	[Extension]
	[Token(Token = "0x6000C92")]
	public static bool IsNumericOrBool(Type type) { }

	[Address(RVA = "0x22B7D60", Offset = "0x22B7160", Length = "0xC4")]
	[Token(Token = "0x6000CAD")]
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	[Address(RVA = "0x22B7E30", Offset = "0x22B7230", Length = "0x142")]
	[Extension]
	[Token(Token = "0x6000C90")]
	public static bool IsUnsignedInt(Type type) { }

	[Address(RVA = "0x22B7F80", Offset = "0x22B7380", Length = "0x4F4")]
	[Token(Token = "0x6000C93")]
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[Address(RVA = "0x22B8480", Offset = "0x22B7880", Length = "0x31F")]
	[Extension]
	[Token(Token = "0x6000C96")]
	private static bool StrictHasReferenceConversionTo(Type source, Type dest, bool skipNonArray) { }

	[Address(RVA = "0x22B8940", Offset = "0x22B7D40", Length = "0x66")]
	[Token(Token = "0x6000CAE")]
	public static void ValidateType(Type type, string paramName) { }

	[Address(RVA = "0x22B87A0", Offset = "0x22B7BA0", Length = "0x19C")]
	[Token(Token = "0x6000CAF")]
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	[Address(RVA = "0x22B89B0", Offset = "0x22B7DB0", Length = "0xE5")]
	[Token(Token = "0x6000CB0")]
	public static bool ValidateType(Type type, string paramName, int index) { }

}

