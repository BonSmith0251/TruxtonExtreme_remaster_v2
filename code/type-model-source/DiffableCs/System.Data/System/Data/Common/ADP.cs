namespace System.Data.Common;

[Token(Token = "0x20000C3")]
internal static class ADP
{
	[Token(Token = "0x400042D")]
	private static readonly Type s_stackOverflowType; //Field offset: 0x0
	[Token(Token = "0x400042E")]
	private static readonly Type s_outOfMemoryType; //Field offset: 0x8
	[Token(Token = "0x400042F")]
	private static readonly Type s_threadAbortType; //Field offset: 0x10
	[Token(Token = "0x4000430")]
	private static readonly Type s_nullReferenceType; //Field offset: 0x18
	[Token(Token = "0x4000431")]
	private static readonly Type s_accessViolationType; //Field offset: 0x20
	[Token(Token = "0x4000432")]
	private static readonly Type s_securityType; //Field offset: 0x28
	[Token(Token = "0x4000433")]
	internal static readonly string StrEmpty; //Field offset: 0x30
	[Token(Token = "0x4000434")]
	internal static readonly String[] AzureSqlServerEndpoints; //Field offset: 0x38
	[Token(Token = "0x4000435")]
	internal static readonly IntPtr PtrZero; //Field offset: 0x40
	[Token(Token = "0x4000436")]
	internal static readonly int PtrSize; //Field offset: 0x48

	[Address(RVA = "0x23A8720", Offset = "0x23A7B20", Length = "0x39D")]
	[Token(Token = "0x6000AC0")]
	private static ADP() { }

	[Address(RVA = "0x23A7AF0", Offset = "0x23A6EF0", Length = "0x7F")]
	[Token(Token = "0x6000AB3")]
	internal static ArgumentException Argument(string error) { }

	[Address(RVA = "0x23A79E0", Offset = "0x23A6DE0", Length = "0x7F")]
	[Token(Token = "0x6000AB4")]
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	[Address(RVA = "0x23A7A60", Offset = "0x23A6E60", Length = "0x8F")]
	[Token(Token = "0x6000AB5")]
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	[Address(RVA = "0x23A7B70", Offset = "0x23A6F70", Length = "0x89")]
	[Token(Token = "0x6000ABC")]
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	[Address(RVA = "0x23A7C00", Offset = "0x23A7000", Length = "0xF8")]
	[Token(Token = "0x6000ABA")]
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	[Address(RVA = "0x23A7D00", Offset = "0x23A7100", Length = "0x89")]
	[Token(Token = "0x6000ABD")]
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	[Address(RVA = "0x23A7D90", Offset = "0x23A7190", Length = "0x7F")]
	[Token(Token = "0x6000AB6")]
	internal static InvalidOperationException InvalidOperation(string error) { }

	[Address(RVA = "0x23A7E10", Offset = "0x23A7210", Length = "0x89")]
	[Token(Token = "0x6000ABE")]
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	[Address(RVA = "0x23A7EA0", Offset = "0x23A72A0", Length = "0x5D")]
	[Token(Token = "0x6000ABB")]
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	[Address(RVA = "0x23A7F00", Offset = "0x23A7300", Length = "0x248")]
	[Token(Token = "0x6000AB8")]
	internal static bool IsCatchableExceptionType(Exception e) { }

	[Address(RVA = "0x23A8150", Offset = "0x23A7550", Length = "0x1F5")]
	[Token(Token = "0x6000AB9")]
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	[Address(RVA = "0x23A8350", Offset = "0x23A7750", Length = "0x7F")]
	[Token(Token = "0x6000AB7")]
	internal static NotSupportedException NotSupported(string error) { }

	[Address(RVA = "0x23A8570", Offset = "0x23A7970", Length = "0x8D")]
	[Token(Token = "0x6000AB0")]
	private static void TraceException(string trace, Exception e) { }

	[Address(RVA = "0x23A83D0", Offset = "0x23A77D0", Length = "0xCE")]
	[Token(Token = "0x6000AB1")]
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	[Address(RVA = "0x23A84A0", Offset = "0x23A78A0", Length = "0xCE")]
	[Token(Token = "0x6000AB2")]
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	[Address(RVA = "0x23A8600", Offset = "0x23A7A00", Length = "0x11E")]
	[Token(Token = "0x6000ABF")]
	internal static Exception WrongType(Type got, Type expected) { }

}

