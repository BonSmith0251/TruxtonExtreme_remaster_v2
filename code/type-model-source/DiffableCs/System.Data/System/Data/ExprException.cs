namespace System.Data;

[Token(Token = "0x200006A")]
internal sealed class ExprException
{

	[Address(RVA = "0x233B0F0", Offset = "0x233A4F0", Length = "0x5E")]
	[Token(Token = "0x60005CD")]
	private static EvaluateException _Eval(string error) { }

	[Address(RVA = "0x233B090", Offset = "0x233A490", Length = "0x5E")]
	[Token(Token = "0x60005CE")]
	private static EvaluateException _Eval(string error, Exception innerException) { }

	[Address(RVA = "0x233B150", Offset = "0x233A550", Length = "0x5E")]
	[Token(Token = "0x60005CB")]
	private static InvalidExpressionException _Expr(string error) { }

	[Address(RVA = "0x233B1B0", Offset = "0x233A5B0", Length = "0x5E")]
	[Token(Token = "0x60005CA")]
	private static OverflowException _Overflow(string error) { }

	[Address(RVA = "0x233B210", Offset = "0x233A610", Length = "0x5E")]
	[Token(Token = "0x60005CC")]
	private static SyntaxErrorException _Syntax(string error) { }

	[Address(RVA = "0x2339300", Offset = "0x2338700", Length = "0x7E")]
	[Token(Token = "0x60005F2")]
	public static Exception AggregateArgument() { }

	[Address(RVA = "0x2339380", Offset = "0x2338780", Length = "0x8F")]
	[Token(Token = "0x60005F3")]
	public static Exception AggregateUnbound(string expr) { }

	[Address(RVA = "0x2339410", Offset = "0x2338810", Length = "0x11F")]
	[Token(Token = "0x60005EB")]
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	[Address(RVA = "0x2339600", Offset = "0x2338A00", Length = "0x10C")]
	[Token(Token = "0x60005E8")]
	public static Exception ArgumentType(string function, int arg, Type type) { }

	[Address(RVA = "0x2339530", Offset = "0x2338930", Length = "0xCE")]
	[Token(Token = "0x60005E9")]
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	[Address(RVA = "0x2339710", Offset = "0x2338B10", Length = "0x8F")]
	[Token(Token = "0x60005F1")]
	internal static EvaluateException BindFailure(string relationName) { }

	[Address(RVA = "0x23397A0", Offset = "0x2338BA0", Length = "0x8F")]
	[Token(Token = "0x60005F6")]
	public static Exception ComputeNotAggregate(string expr) { }

	[Address(RVA = "0x2339830", Offset = "0x2338C30", Length = "0xDC")]
	[Token(Token = "0x60005DE")]
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	[Address(RVA = "0x2339910", Offset = "0x2338D10", Length = "0xDC")]
	[Token(Token = "0x60005DF")]
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	[Address(RVA = "0x23399F0", Offset = "0x2338DF0", Length = "0x7E")]
	[Token(Token = "0x60005F4")]
	public static Exception EvalNoContext() { }

	[Address(RVA = "0x2339A70", Offset = "0x2338E70", Length = "0x7E")]
	[Token(Token = "0x60005D5")]
	public static Exception ExpressionTooComplex() { }

	[Address(RVA = "0x2339AF0", Offset = "0x2338EF0", Length = "0x8F")]
	[Token(Token = "0x60005F5")]
	public static Exception ExpressionUnbound(string expr) { }

	[Address(RVA = "0x2339B80", Offset = "0x2338F80", Length = "0x8F")]
	[Token(Token = "0x60005F7")]
	public static Exception FilterConvertion(string expr) { }

	[Address(RVA = "0x2339C10", Offset = "0x2339010", Length = "0x8F")]
	[Token(Token = "0x60005DA")]
	public static Exception FunctionArgumentCount(string name) { }

	[Address(RVA = "0x2339CA0", Offset = "0x23390A0", Length = "0x56")]
	[Token(Token = "0x60005D4")]
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	[Address(RVA = "0x2339E00", Offset = "0x2339200", Length = "0x8F")]
	[Token(Token = "0x60005E1")]
	public static Exception InvalidDate(string date) { }

	[Address(RVA = "0x2339E90", Offset = "0x2339290", Length = "0x7E")]
	[Token(Token = "0x60005FA")]
	public static Exception InvalidHoursArgument() { }

	[Address(RVA = "0x2339F10", Offset = "0x2339310", Length = "0x7E")]
	[Token(Token = "0x60005E6")]
	public static Exception InvalidIsSyntax() { }

	[Address(RVA = "0x2339F90", Offset = "0x2339390", Length = "0x7E")]
	[Token(Token = "0x60005FB")]
	public static Exception InvalidMinutesArgument() { }

	[Address(RVA = "0x233A0A0", Offset = "0x23394A0", Length = "0x8F")]
	[Token(Token = "0x60005E0")]
	public static Exception InvalidName(string name) { }

	[Address(RVA = "0x233A010", Offset = "0x2339410", Length = "0x8F")]
	[Token(Token = "0x60005ED")]
	public static Exception InvalidNameBracketing(string name) { }

	[Address(RVA = "0x233A130", Offset = "0x2339530", Length = "0x8F")]
	[Token(Token = "0x60005E3")]
	public static Exception InvalidPattern(string pat) { }

	[Address(RVA = "0x233A1C0", Offset = "0x23395C0", Length = "0x8F")]
	[Token(Token = "0x60005D7")]
	public static Exception InvalidString(string str) { }

	[Address(RVA = "0x233A250", Offset = "0x2339650", Length = "0x7E")]
	[Token(Token = "0x60005FC")]
	public static Exception InvalidTimeZoneRange() { }

	[Address(RVA = "0x233A2D0", Offset = "0x23396D0", Length = "0x8F")]
	[Token(Token = "0x60005F9")]
	public static Exception InvalidType(string typeName) { }

	[Address(RVA = "0x233A360", Offset = "0x2339760", Length = "0x32")]
	[Token(Token = "0x60005CF")]
	public static Exception InvokeArgument() { }

	[Address(RVA = "0x2339D00", Offset = "0x2339100", Length = "0x7E")]
	[Token(Token = "0x60005E5")]
	public static Exception InWithoutList() { }

	[Address(RVA = "0x2339D80", Offset = "0x2339180", Length = "0x7E")]
	[Token(Token = "0x60005E4")]
	public static Exception InWithoutParentheses() { }

	[Address(RVA = "0x233A3A0", Offset = "0x23397A0", Length = "0x7E")]
	[Token(Token = "0x60005F8")]
	public static Exception LookupArgument() { }

	[Address(RVA = "0x233A420", Offset = "0x2339820", Length = "0x7E")]
	[Token(Token = "0x60005FD")]
	public static Exception MismatchKindandTimeSpan() { }

	[Address(RVA = "0x233A530", Offset = "0x2339930", Length = "0xCB")]
	[Token(Token = "0x60005D1")]
	public static Exception MissingOperand(OperatorInfo before) { }

	[Address(RVA = "0x233A4A0", Offset = "0x23398A0", Length = "0x8F")]
	[Token(Token = "0x60005EE")]
	public static Exception MissingOperandBefore(string op) { }

	[Address(RVA = "0x233A600", Offset = "0x2339A00", Length = "0x8F")]
	[Token(Token = "0x60005D2")]
	public static Exception MissingOperator(string token) { }

	[Address(RVA = "0x233A690", Offset = "0x2339A90", Length = "0x7E")]
	[Token(Token = "0x60005DB")]
	public static Exception MissingRightParen() { }

	[Address(RVA = "0x233A7A0", Offset = "0x2339BA0", Length = "0x7E")]
	[Token(Token = "0x60005E2")]
	public static Exception NonConstantArgument() { }

	[Address(RVA = "0x233A710", Offset = "0x2339B10", Length = "0x8F")]
	[Token(Token = "0x60005D0")]
	public static Exception NYI(string moreinfo) { }

	[Address(RVA = "0x233A820", Offset = "0x2339C20", Length = "0xB4")]
	[Token(Token = "0x60005E7")]
	public static Exception Overflow(Type type) { }

	[Address(RVA = "0x233A8E0", Offset = "0x2339CE0", Length = "0x7E")]
	[Token(Token = "0x60005D9")]
	public static Exception SyntaxError() { }

	[Address(RVA = "0x233A960", Offset = "0x2339D60", Length = "0x7E")]
	[Token(Token = "0x60005EF")]
	public static Exception TooManyRightParentheses() { }

	[Address(RVA = "0x233AB00", Offset = "0x2339F00", Length = "0x8F")]
	[Token(Token = "0x60005D3")]
	public static Exception TypeMismatch(string expr) { }

	[Address(RVA = "0x233A9E0", Offset = "0x2339DE0", Length = "0x11F")]
	[Token(Token = "0x60005EA")]
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	[Address(RVA = "0x233AB90", Offset = "0x2339F90", Length = "0x8F")]
	[Token(Token = "0x60005D6")]
	public static Exception UnboundName(string name) { }

	[Address(RVA = "0x233AC20", Offset = "0x233A020", Length = "0x8F")]
	[Token(Token = "0x60005D8")]
	public static Exception UndefinedFunction(string name) { }

	[Address(RVA = "0x233ACB0", Offset = "0x233A0B0", Length = "0x138")]
	[Token(Token = "0x60005DD")]
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	[Address(RVA = "0x233ADF0", Offset = "0x233A1F0", Length = "0xCE")]
	[Token(Token = "0x60005DC")]
	public static Exception UnknownToken(string token, int position) { }

	[Address(RVA = "0x233AEC0", Offset = "0x233A2C0", Length = "0x95")]
	[Token(Token = "0x60005F0")]
	public static Exception UnresolvedRelation(string name, string expr) { }

	[Address(RVA = "0x233AF60", Offset = "0x233A360", Length = "0x66")]
	[Token(Token = "0x60005FE")]
	public static Exception UnsupportedDataType(Type type) { }

	[Address(RVA = "0x233AFD0", Offset = "0x233A3D0", Length = "0xB8")]
	[Token(Token = "0x60005EC")]
	public static Exception UnsupportedOperator(int op) { }

}

