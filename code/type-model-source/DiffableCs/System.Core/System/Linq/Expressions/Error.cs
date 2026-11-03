namespace System.Linq.Expressions;

[Token(Token = "0x200007D")]
internal static class Error
{

	[Address(RVA = "0x225A750", Offset = "0x2259B50", Length = "0x8C")]
	[Token(Token = "0x600031C")]
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	[Address(RVA = "0x225A7E0", Offset = "0x2259BE0", Length = "0x84")]
	[Token(Token = "0x600031B")]
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	[Address(RVA = "0x225A870", Offset = "0x2259C70", Length = "0x84")]
	[Token(Token = "0x600031A")]
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	[Address(RVA = "0x225A900", Offset = "0x2259D00", Length = "0x85")]
	[Token(Token = "0x600036C")]
	internal static Exception AmbiguousJump(object p0) { }

	[Address(RVA = "0x225A990", Offset = "0x2259D90", Length = "0x85")]
	[Token(Token = "0x6000309")]
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	[Address(RVA = "0x225AA20", Offset = "0x2259E20", Length = "0x84")]
	[Token(Token = "0x6000366")]
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	[Address(RVA = "0x225AB40", Offset = "0x2259F40", Length = "0x84")]
	[Token(Token = "0x6000342")]
	internal static Exception ArgumentMustBeArray(string paramName) { }

	[Address(RVA = "0x225AAB0", Offset = "0x2259EB0", Length = "0x84")]
	[Token(Token = "0x6000346")]
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	[Address(RVA = "0x225ABD0", Offset = "0x2259FD0", Length = "0x84")]
	[Token(Token = "0x6000343")]
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	[Address(RVA = "0x225AC60", Offset = "0x225A060", Length = "0x84")]
	[Token(Token = "0x6000344")]
	private static Exception ArgumentMustBeInteger(string paramName) { }

	[Address(RVA = "0x225ACF0", Offset = "0x225A0F0", Length = "0x8C")]
	[Token(Token = "0x6000345")]
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	[Address(RVA = "0x225AD80", Offset = "0x225A180", Length = "0x84")]
	[Token(Token = "0x6000347")]
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	[Address(RVA = "0x225AE10", Offset = "0x225A210", Length = "0x84")]
	[Token(Token = "0x600032C")]
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	[Address(RVA = "0x225AEA0", Offset = "0x225A2A0", Length = "0x54")]
	[Token(Token = "0x6000375")]
	internal static Exception ArgumentOutOfRange(string paramName) { }

	[Address(RVA = "0x225AF00", Offset = "0x225A300", Length = "0x74")]
	[Token(Token = "0x6000348")]
	internal static Exception ArgumentTypesMustMatch() { }

	[Address(RVA = "0x225AF80", Offset = "0x225A380", Length = "0xA1")]
	[Token(Token = "0x600033D")]
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	[Address(RVA = "0x225B030", Offset = "0x225A430", Length = "0xA1")]
	[Token(Token = "0x600030F")]
	internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	[Address(RVA = "0x225B0E0", Offset = "0x225A4E0", Length = "0x74")]
	[Token(Token = "0x6000313")]
	internal static Exception BindingCannotBeNull() { }

	[Address(RVA = "0x225B160", Offset = "0x225A560", Length = "0x74")]
	[Token(Token = "0x6000337")]
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	[Address(RVA = "0x225B1E0", Offset = "0x225A5E0", Length = "0x84")]
	[Token(Token = "0x6000325")]
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	[Address(RVA = "0x225B270", Offset = "0x225A670", Length = "0x84")]
	[Token(Token = "0x600031F")]
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	[Address(RVA = "0x225B300", Offset = "0x225A700", Length = "0x85")]
	[Token(Token = "0x6000349")]
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	[Address(RVA = "0x225B390", Offset = "0x225A790", Length = "0x74")]
	[Token(Token = "0x600034B")]
	internal static Exception CoalesceUsedOnNonNullType() { }

	[Address(RVA = "0x225B410", Offset = "0x225A810", Length = "0x8B")]
	[Token(Token = "0x600033B")]
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	[Address(RVA = "0x225B4A0", Offset = "0x225A8A0", Length = "0x74")]
	[Token(Token = "0x600030C")]
	internal static Exception CollectionModifiedWhileEnumerating() { }

	[Address(RVA = "0x225B520", Offset = "0x225A920", Length = "0x74")]
	[Token(Token = "0x600030D")]
	internal static Exception CollectionReadOnly() { }

	[Address(RVA = "0x225B5A0", Offset = "0x225A9A0", Length = "0x74")]
	[Token(Token = "0x600036E")]
	internal static Exception ControlCannotEnterExpression() { }

	[Address(RVA = "0x225B620", Offset = "0x225AA20", Length = "0x74")]
	[Token(Token = "0x600036D")]
	internal static Exception ControlCannotEnterTry() { }

	[Address(RVA = "0x225B6A0", Offset = "0x225AAA0", Length = "0x74")]
	[Token(Token = "0x600036B")]
	internal static Exception ControlCannotLeaveFilterTest() { }

	[Address(RVA = "0x225B720", Offset = "0x225AB20", Length = "0x74")]
	[Token(Token = "0x600036A")]
	internal static Exception ControlCannotLeaveFinally() { }

	[Address(RVA = "0x225B7A0", Offset = "0x225ABA0", Length = "0x74")]
	[Token(Token = "0x6000341")]
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	[Address(RVA = "0x225B820", Offset = "0x225AC20", Length = "0x95")]
	[Token(Token = "0x6000333")]
	private static Exception DuplicateVariable(object p0, string paramName) { }

	[Address(RVA = "0x225B8C0", Offset = "0x225ACC0", Length = "0xA8")]
	[Token(Token = "0x6000334")]
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	[Address(RVA = "0x225B970", Offset = "0x225AD70", Length = "0xA1")]
	[Token(Token = "0x6000312")]
	internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	[Address(RVA = "0x225BA20", Offset = "0x225AE20", Length = "0x8B")]
	[Token(Token = "0x6000310")]
	internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) { }

	[Address(RVA = "0x225BAB0", Offset = "0x225AEB0", Length = "0x8E")]
	[Token(Token = "0x6000311")]
	internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	[Address(RVA = "0x225BB40", Offset = "0x225AF40", Length = "0x74")]
	[Token(Token = "0x6000379")]
	internal static Exception EnumerationIsDone() { }

	[Address(RVA = "0x225BBC0", Offset = "0x225AFC0", Length = "0x84")]
	[Token(Token = "0x6000387")]
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	[Address(RVA = "0x225BC50", Offset = "0x225B050", Length = "0x8C")]
	[Token(Token = "0x6000388")]
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	[Address(RVA = "0x225BCE0", Offset = "0x225B0E0", Length = "0x84")]
	[Token(Token = "0x600032B")]
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	[Address(RVA = "0x225BD70", Offset = "0x225B170", Length = "0x8B")]
	[Token(Token = "0x600034C")]
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	[Address(RVA = "0x225BE00", Offset = "0x225B200", Length = "0x8B")]
	[Token(Token = "0x600034E")]
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	[Address(RVA = "0x225BE90", Offset = "0x225B290", Length = "0x9B")]
	[Token(Token = "0x6000385")]
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	[Address(RVA = "0x225BF30", Offset = "0x225B330", Length = "0xAC")]
	[Token(Token = "0x6000386")]
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	[Address(RVA = "0x225BFE0", Offset = "0x225B3E0", Length = "0x8B")]
	[Token(Token = "0x600034F")]
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	[Address(RVA = "0x225C130", Offset = "0x225B530", Length = "0xC0")]
	[Token(Token = "0x6000380")]
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	[Address(RVA = "0x225C070", Offset = "0x225B470", Length = "0xB1")]
	[Token(Token = "0x600037F")]
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	[Address(RVA = "0x225C1F0", Offset = "0x225B5F0", Length = "0xAC")]
	[Token(Token = "0x6000382")]
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	[Address(RVA = "0x225C2A0", Offset = "0x225B6A0", Length = "0x9B")]
	[Token(Token = "0x6000381")]
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	[Address(RVA = "0x225C340", Offset = "0x225B740", Length = "0x8B")]
	[Token(Token = "0x600034D")]
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	[Address(RVA = "0x225C3D0", Offset = "0x225B7D0", Length = "0x95")]
	[Token(Token = "0x6000350")]
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	[Address(RVA = "0x225C470", Offset = "0x225B870", Length = "0x85")]
	[Token(Token = "0x6000338")]
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	[Address(RVA = "0x225C500", Offset = "0x225B900", Length = "0x84")]
	[Token(Token = "0x6000335")]
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	[Address(RVA = "0x225C590", Offset = "0x225B990", Length = "0xA1")]
	[Token(Token = "0x6000352")]
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	[Address(RVA = "0x225C640", Offset = "0x225BA40", Length = "0x74")]
	[Token(Token = "0x6000319")]
	internal static Exception FirstArgumentMustBeCallSite() { }

	[Address(RVA = "0x225C6C0", Offset = "0x225BAC0", Length = "0x8B")]
	[Token(Token = "0x6000364")]
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	[Address(RVA = "0x225C750", Offset = "0x225BB50", Length = "0x72")]
	[Token(Token = "0x600038C")]
	private static string GetParamName(string paramName, int index) { }

	[Address(RVA = "0x225C7D0", Offset = "0x225BBD0", Length = "0x74")]
	[Token(Token = "0x600037E")]
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	[Address(RVA = "0x225C850", Offset = "0x225BC50", Length = "0x74")]
	[Token(Token = "0x6000353")]
	internal static Exception IncorrectNumberOfIndexes() { }

	[Address(RVA = "0x225C8D0", Offset = "0x225BCD0", Length = "0x74")]
	[Token(Token = "0x6000383")]
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	[Address(RVA = "0x225C950", Offset = "0x225BD50", Length = "0x74")]
	[Token(Token = "0x6000354")]
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	[Address(RVA = "0x225C9D0", Offset = "0x225BDD0", Length = "0x95")]
	[Token(Token = "0x6000384")]
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	[Address(RVA = "0x225CA70", Offset = "0x225BE70", Length = "0x95")]
	[Token(Token = "0x600034A")]
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	[Address(RVA = "0x225CB10", Offset = "0x225BF10", Length = "0x84")]
	[Token(Token = "0x6000317")]
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	[Address(RVA = "0x225CBA0", Offset = "0x225BFA0", Length = "0xA1")]
	[Token(Token = "0x600035D")]
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	[Address(RVA = "0x225CC50", Offset = "0x225C050", Length = "0x8B")]
	[Token(Token = "0x6000351")]
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	[Address(RVA = "0x225CCE0", Offset = "0x225C0E0", Length = "0x9B")]
	[Token(Token = "0x600035C")]
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	[Address(RVA = "0x225CD80", Offset = "0x225C180", Length = "0x84")]
	[Token(Token = "0x6000389")]
	internal static Exception InvalidArgumentValue(string paramName) { }

	[Address(RVA = "0x225CE10", Offset = "0x225C210", Length = "0xA8")]
	[Token(Token = "0x6000370")]
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	[Address(RVA = "0x225CEC0", Offset = "0x225C2C0", Length = "0x85")]
	[Token(Token = "0x6000308")]
	internal static Exception InvalidMetaObjectCreated(object p0) { }

	[Address(RVA = "0x225CF50", Offset = "0x225C350", Length = "0x95")]
	[Token(Token = "0x600038A")]
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	[Address(RVA = "0x225CFF0", Offset = "0x225C3F0", Length = "0x44")]
	[Token(Token = "0x6000378")]
	internal static Exception InvalidProgram() { }

	[Address(RVA = "0x225D040", Offset = "0x225C440", Length = "0xC5")]
	[Token(Token = "0x600038B")]
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	[Address(RVA = "0x225D110", Offset = "0x225C510", Length = "0x84")]
	[Token(Token = "0x600032A")]
	internal static Exception InvalidUnboxType(string paramName) { }

	[Address(RVA = "0x225D1A0", Offset = "0x225C5A0", Length = "0x85")]
	[Token(Token = "0x600030B")]
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	[Address(RVA = "0x225D230", Offset = "0x225C630", Length = "0x84")]
	[Token(Token = "0x600032E")]
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	[Address(RVA = "0x225D2C0", Offset = "0x225C6C0", Length = "0x85")]
	[Token(Token = "0x6000368")]
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	[Address(RVA = "0x225D350", Offset = "0x225C750", Length = "0x85")]
	[Token(Token = "0x6000369")]
	internal static Exception LabelTargetUndefined(object p0) { }

	[Address(RVA = "0x225D3E0", Offset = "0x225C7E0", Length = "0x84")]
	[Token(Token = "0x600032F")]
	internal static Exception LabelTypeMustBeVoid(string paramName) { }

	[Address(RVA = "0x225D470", Offset = "0x225C870", Length = "0x84")]
	[Token(Token = "0x6000355")]
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	[Address(RVA = "0x225D500", Offset = "0x225C900", Length = "0x8B")]
	[Token(Token = "0x6000362")]
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	[Address(RVA = "0x225D590", Offset = "0x225C990", Length = "0x95")]
	[Token(Token = "0x6000356")]
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	[Address(RVA = "0x225D630", Offset = "0x225CA30", Length = "0x95")]
	[Token(Token = "0x6000357")]
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	[Address(RVA = "0x225D6D0", Offset = "0x225CAD0", Length = "0x95")]
	[Token(Token = "0x6000358")]
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	[Address(RVA = "0x225D770", Offset = "0x225CB70", Length = "0x8B")]
	[Token(Token = "0x6000363")]
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	[Address(RVA = "0x225D800", Offset = "0x225CC00", Length = "0x8B")]
	[Token(Token = "0x6000365")]
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	[Address(RVA = "0x225D890", Offset = "0x225CC90", Length = "0x74")]
	[Token(Token = "0x600032D")]
	internal static Exception MustBeReducible() { }

	[Address(RVA = "0x225D910", Offset = "0x225CD10", Length = "0x74")]
	[Token(Token = "0x600030E")]
	internal static Exception MustReduceToDifferent() { }

	[Address(RVA = "0x225D990", Offset = "0x225CD90", Length = "0xA1")]
	[Token(Token = "0x6000373")]
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	[Address(RVA = "0x225DA40", Offset = "0x225CE40", Length = "0xA1")]
	[Token(Token = "0x6000372")]
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	[Address(RVA = "0x225DAF0", Offset = "0x225CEF0", Length = "0x8B")]
	[Token(Token = "0x6000374")]
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	[Address(RVA = "0x225DC00", Offset = "0x225D000", Length = "0x74")]
	[Token(Token = "0x6000377")]
	internal static Exception NonAbstractConstructorRequired() { }

	[Address(RVA = "0x225DC80", Offset = "0x225D080", Length = "0x85")]
	[Token(Token = "0x600036F")]
	internal static Exception NonLocalJumpWithValue(object p0) { }

	[Address(RVA = "0x225DB80", Offset = "0x225CF80", Length = "0x74")]
	[Token(Token = "0x600031E")]
	internal static Exception NoOrInvalidRuleProduced() { }

	[Address(RVA = "0x225DD10", Offset = "0x225D110", Length = "0x44")]
	[Token(Token = "0x6000376")]
	internal static Exception NotSupported() { }

	[Address(RVA = "0x225DD60", Offset = "0x225D160", Length = "0x84")]
	[Token(Token = "0x6000326")]
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	[Address(RVA = "0x225DDF0", Offset = "0x225D1F0", Length = "0x74")]
	[Token(Token = "0x6000328")]
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	[Address(RVA = "0x225DE70", Offset = "0x225D270", Length = "0x84")]
	[Token(Token = "0x6000327")]
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	[Address(RVA = "0x225DF00", Offset = "0x225D300", Length = "0x8B")]
	[Token(Token = "0x600033F")]
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	[Address(RVA = "0x225DF90", Offset = "0x225D390", Length = "0x98")]
	[Token(Token = "0x6000367")]
	internal static Exception OutOfRange(string paramName, object p1) { }

	[Address(RVA = "0x225E030", Offset = "0x225D430", Length = "0x8B")]
	[Token(Token = "0x6000340")]
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	[Address(RVA = "0x225E0C0", Offset = "0x225D4C0", Length = "0x8B")]
	[Token(Token = "0x600035A")]
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	[Address(RVA = "0x225E150", Offset = "0x225D550", Length = "0x84")]
	[Token(Token = "0x6000316")]
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	[Address(RVA = "0x225E1E0", Offset = "0x225D5E0", Length = "0x95")]
	[Token(Token = "0x6000359")]
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	[Address(RVA = "0x225E280", Offset = "0x225D680", Length = "0x9B")]
	[Token(Token = "0x600035B")]
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	[Address(RVA = "0x225E320", Offset = "0x225D720", Length = "0x84")]
	[Token(Token = "0x6000329")]
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	[Address(RVA = "0x225E3B0", Offset = "0x225D7B0", Length = "0x84")]
	[Token(Token = "0x6000323")]
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	[Address(RVA = "0x225E440", Offset = "0x225D840", Length = "0x84")]
	[Token(Token = "0x6000324")]
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	[Address(RVA = "0x225E4D0", Offset = "0x225D8D0", Length = "0x84")]
	[Token(Token = "0x6000330")]
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	[Address(RVA = "0x225E560", Offset = "0x225D960", Length = "0x74")]
	[Token(Token = "0x6000314")]
	internal static Exception ReducedNotCompatible() { }

	[Address(RVA = "0x225E5E0", Offset = "0x225D9E0", Length = "0x74")]
	[Token(Token = "0x6000307")]
	internal static Exception ReducibleMustOverrideReduce() { }

	[Address(RVA = "0x225E660", Offset = "0x225DA60", Length = "0x8B")]
	[Token(Token = "0x600033E")]
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	[Address(RVA = "0x225E6F0", Offset = "0x225DAF0", Length = "0x74")]
	[Token(Token = "0x6000371")]
	internal static Exception RethrowRequiresCatch() { }

	[Address(RVA = "0x225E770", Offset = "0x225DB70", Length = "0x98")]
	[Token(Token = "0x600030A")]
	internal static Exception SameKeyExistsInExpando(object key) { }

	[Address(RVA = "0x225E810", Offset = "0x225DC10", Length = "0x84")]
	[Token(Token = "0x6000315")]
	internal static Exception SetterHasNoParams(string paramName) { }

	[Address(RVA = "0x225E8A0", Offset = "0x225DCA0", Length = "0x84")]
	[Token(Token = "0x6000322")]
	internal static Exception SetterMustBeVoid(string paramName) { }

	[Address(RVA = "0x225E930", Offset = "0x225DD30", Length = "0x74")]
	[Token(Token = "0x6000336")]
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	[Address(RVA = "0x225EA60", Offset = "0x225DE60", Length = "0x95")]
	[Token(Token = "0x600037A")]
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	[Address(RVA = "0x225E9B0", Offset = "0x225DDB0", Length = "0xA8")]
	[Token(Token = "0x600037B")]
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	[Address(RVA = "0x225EB00", Offset = "0x225DF00", Length = "0x95")]
	[Token(Token = "0x600037C")]
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	[Address(RVA = "0x225EBA0", Offset = "0x225DFA0", Length = "0xA8")]
	[Token(Token = "0x600037D")]
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	[Address(RVA = "0x225EC50", Offset = "0x225E050", Length = "0x74")]
	[Token(Token = "0x600031D")]
	internal static Exception TypeMustBeDerivedFromSystemDelegate() { }

	[Address(RVA = "0x225ECD0", Offset = "0x225E0D0", Length = "0x84")]
	[Token(Token = "0x6000320")]
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	[Address(RVA = "0x225ED60", Offset = "0x225E160", Length = "0x84")]
	[Token(Token = "0x6000321")]
	internal static Exception TypeMustNotBePointer(string paramName) { }

	[Address(RVA = "0x225EDF0", Offset = "0x225E1F0", Length = "0x85")]
	[Token(Token = "0x6000318")]
	internal static Exception TypeParameterIsNotDelegate(object p0) { }

	[Address(RVA = "0x225EE80", Offset = "0x225E280", Length = "0x8B")]
	[Token(Token = "0x600033C")]
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	[Address(RVA = "0x225EF10", Offset = "0x225E310", Length = "0x95")]
	[Token(Token = "0x600035E")]
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	[Address(RVA = "0x225EFB0", Offset = "0x225E3B0", Length = "0x95")]
	[Token(Token = "0x600035F")]
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	[Address(RVA = "0x225F170", Offset = "0x225E570", Length = "0x95")]
	[Token(Token = "0x6000339")]
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	[Address(RVA = "0x225F210", Offset = "0x225E610", Length = "0x95")]
	[Token(Token = "0x600033A")]
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	[Address(RVA = "0x225F050", Offset = "0x225E450", Length = "0x8B")]
	[Token(Token = "0x6000360")]
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	[Address(RVA = "0x225F0E0", Offset = "0x225E4E0", Length = "0x8B")]
	[Token(Token = "0x6000361")]
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	[Address(RVA = "0x225F360", Offset = "0x225E760", Length = "0x9B")]
	[Token(Token = "0x6000331")]
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	[Address(RVA = "0x225F2B0", Offset = "0x225E6B0", Length = "0xAC")]
	[Token(Token = "0x6000332")]
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

}

