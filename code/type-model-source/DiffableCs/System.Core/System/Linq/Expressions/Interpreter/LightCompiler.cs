namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000192")]
internal sealed class LightCompiler
{
	[CompilerGenerated]
	[Token(Token = "0x2000194")]
	private sealed class <>c
	{
		[Token(Token = "0x4000354")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000355")]
		public static Func<Expression, Boolean> <>9__56_1; //Field offset: 0x8
		[Token(Token = "0x4000356")]
		public static Func<SwitchCase, Boolean> <>9__56_0; //Field offset: 0x10
		[Token(Token = "0x4000357")]
		public static Action<LightCompiler, Expression> <>9__101_0; //Field offset: 0x18

		[Address(RVA = "0x22AC750", Offset = "0x22ABB50", Length = "0x67")]
		[Token(Token = "0x60008B8")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60008B9")]
		public <>c() { }

		[Address(RVA = "0x22AC4A0", Offset = "0x22AB8A0", Length = "0x26")]
		[Token(Token = "0x60008BC")]
		internal void <CompileNoLabelPush>b__101_0(LightCompiler this, Expression e) { }

		[Address(RVA = "0x22AC4D0", Offset = "0x22AB8D0", Length = "0x120")]
		[Token(Token = "0x60008BA")]
		internal bool <CompileSwitchExpression>b__56_0(SwitchCase c) { }

		[Address(RVA = "0x22AC600", Offset = "0x22ABA00", Length = "0x71")]
		[Token(Token = "0x60008BB")]
		internal bool <CompileSwitchExpression>b__56_1(Expression t) { }

	}

	[Token(Token = "0x2000193")]
	private sealed class QuoteVisitor : ExpressionVisitor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000352")]
		private readonly Dictionary<ParameterExpression, Int32> _definedParameters; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000353")]
		public readonly HashSet<ParameterExpression> _hoistedParameters; //Field offset: 0x18

		[Address(RVA = "0x22A7B50", Offset = "0x22A6F50", Length = "0xBD")]
		[Token(Token = "0x60008B7")]
		public QuoteVisitor() { }

		[Address(RVA = "0x22A7440", Offset = "0x22A6840", Length = "0x248")]
		[Token(Token = "0x60008B6")]
		private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

		[Address(RVA = "0x22A7690", Offset = "0x22A6A90", Length = "0x23F")]
		[Token(Token = "0x60008B5")]
		private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

		[Address(RVA = "0x22A78D0", Offset = "0x22A6CD0", Length = "0x66")]
		[Token(Token = "0x60008B2")]
		protected private virtual Expression VisitBlock(BlockExpression node) { }

		[Address(RVA = "0x22A7940", Offset = "0x22A6D40", Length = "0x186")]
		[Token(Token = "0x60008B3")]
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

		[Address(RVA = "0x9F3060", Offset = "0x9F2460", Length = "0x1B5")]
		[Token(Token = "0x60008B4")]
		protected private virtual Expression VisitLambda(Expression<T> node) { }

		[Address(RVA = "0x22A7AD0", Offset = "0x22A6ED0", Length = "0x7F")]
		[Token(Token = "0x60008B1")]
		protected private virtual Expression VisitParameter(ParameterExpression node) { }

	}

	[Token(Token = "0x4000351")]
	private static readonly LocalDefinition[] s_emptyLocals; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000349")]
	private readonly InstructionList _instructions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034A")]
	private readonly LocalVariables _locals; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400034B")]
	private readonly List<DebugInfo> _debugInfos; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400034C")]
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400034D")]
	private LabelScopeInfo _labelBlock; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400034E")]
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400034F")]
	private readonly LightCompiler _parent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000350")]
	private readonly StackGuard _guard; //Field offset: 0x48

	[Token(Token = "0x170001CE")]
	public InstructionList Instructions
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000856")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x228FA70", Offset = "0x228EE70", Length = "0xBA")]
	[Token(Token = "0x60008B0")]
	private static LightCompiler() { }

	[Address(RVA = "0x228FB70", Offset = "0x228EF70", Length = "0x251")]
	[Token(Token = "0x6000854")]
	public LightCompiler() { }

	[Address(RVA = "0x228FB30", Offset = "0x228EF30", Length = "0x31")]
	[Token(Token = "0x6000855")]
	private LightCompiler(LightCompiler parent) { }

	[Address(RVA = "0x2280520", Offset = "0x227F920", Length = "0x57")]
	[Token(Token = "0x600088E")]
	private void CheckRethrow() { }

	[Address(RVA = "0x228E240", Offset = "0x228D640", Length = "0x15")]
	[Token(Token = "0x60008AC")]
	private void Compile(Expression expr, bool asVoid) { }

	[Address(RVA = "0x228E1D0", Offset = "0x228D5D0", Length = "0x63")]
	[Token(Token = "0x60008AF")]
	private void Compile(Expression expr) { }

	[Address(RVA = "0x2280580", Offset = "0x227F980", Length = "0xB5A")]
	[Token(Token = "0x6000897")]
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	[Address(RVA = "0x22810E0", Offset = "0x22804E0", Length = "0x7F")]
	[Token(Token = "0x600087A")]
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	[Address(RVA = "0x2281160", Offset = "0x2280560", Length = "0x287")]
	[Token(Token = "0x6000873")]
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	[Address(RVA = "0x22813F0", Offset = "0x22807F0", Length = "0x30D")]
	[Token(Token = "0x6000894")]
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	[Address(RVA = "0x2281870", Offset = "0x2280C70", Length = "0x26F")]
	[Token(Token = "0x600086E")]
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	[Address(RVA = "0x2281700", Offset = "0x2280B00", Length = "0x169")]
	[Token(Token = "0x60008AD")]
	private void CompileAsVoid(Expression expr) { }

	[Address(RVA = "0x2281AE0", Offset = "0x2280EE0", Length = "0x344")]
	[Token(Token = "0x600086F")]
	private void CompileBinaryExpression(Expression expr) { }

	[Address(RVA = "0x2282B30", Offset = "0x2281F30", Length = "0xC6")]
	[Token(Token = "0x6000867")]
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	[Address(RVA = "0x2282C00", Offset = "0x2282000", Length = "0x1D6")]
	[Token(Token = "0x6000865")]
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	[Address(RVA = "0x2282DE0", Offset = "0x22821E0", Length = "0x50B")]
	[Token(Token = "0x6000866")]
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	[Address(RVA = "0x22832F0", Offset = "0x22826F0", Length = "0x7B9")]
	[Token(Token = "0x60008A0")]
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	[Address(RVA = "0x2283AB0", Offset = "0x2282EB0", Length = "0x1E0")]
	[Token(Token = "0x6000872")]
	private void CompileComparison(BinaryExpression node) { }

	[Address(RVA = "0x2283CB0", Offset = "0x22830B0", Length = "0x287")]
	[Token(Token = "0x6000880")]
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	[Address(RVA = "0x2283F40", Offset = "0x2283340", Length = "0xAF")]
	[Token(Token = "0x6000859")]
	private void CompileConstantExpression(Expression expr) { }

	[Address(RVA = "0x2283FF0", Offset = "0x22833F0", Length = "0x69C")]
	[Token(Token = "0x6000875")]
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	[Address(RVA = "0x2284690", Offset = "0x2283A90", Length = "0x790")]
	[Token(Token = "0x6000874")]
	private void CompileConvertUnaryExpression(Expression expr) { }

	[Address(RVA = "0x2284E30", Offset = "0x2284230", Length = "0x1DF")]
	[Token(Token = "0x600089D")]
	private void CompileDebugInfoExpression(Expression expr) { }

	[Address(RVA = "0x2285010", Offset = "0x2284410", Length = "0xF2")]
	[Token(Token = "0x600085B")]
	private void CompileDefaultExpression(Type type) { }

	[Address(RVA = "0x2285110", Offset = "0x2284510", Length = "0x11C")]
	[Token(Token = "0x600085A")]
	private void CompileDefaultExpression(Expression expr) { }

	[Address(RVA = "0x2285230", Offset = "0x2284630", Length = "0x91")]
	[Token(Token = "0x6000870")]
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	[Address(RVA = "0x22852D0", Offset = "0x22846D0", Length = "0xA6")]
	[Token(Token = "0x6000862")]
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	[Address(RVA = "0x2285380", Offset = "0x2284780", Length = "0xDE")]
	[Token(Token = "0x600085E")]
	private void CompileGetVariable(ParameterExpression variable) { }

	[Address(RVA = "0x2285460", Offset = "0x2284860", Length = "0x30E")]
	[Token(Token = "0x6000886")]
	private void CompileGotoExpression(Expression expr) { }

	[Address(RVA = "0x2285770", Offset = "0x2284B70", Length = "0x3A2")]
	[Token(Token = "0x600086A")]
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	[Address(RVA = "0x2285B20", Offset = "0x2284F20", Length = "0xD2")]
	[Token(Token = "0x6000868")]
	private void CompileIndexExpression(Expression expr) { }

	[Address(RVA = "0x852D70", Offset = "0x852170", Length = "0x560")]
	[Token(Token = "0x6000883")]
	private void CompileIntSwitchExpression(SwitchExpression node) { }

	[Address(RVA = "0x2285C00", Offset = "0x2285000", Length = "0x274")]
	[Token(Token = "0x60008A1")]
	private void CompileInvocationExpression(Expression expr) { }

	[Address(RVA = "0x2285E80", Offset = "0x2285280", Length = "0x2B3")]
	[Token(Token = "0x6000885")]
	private void CompileLabelExpression(Expression expr) { }

	[Address(RVA = "0x2286140", Offset = "0x2285540", Length = "0x25C")]
	[Token(Token = "0x600089F")]
	private void CompileLambdaExpression(Expression expr) { }

	[Address(RVA = "0x22863A0", Offset = "0x22857A0", Length = "0x995")]
	[Token(Token = "0x600087E")]
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	[Address(RVA = "0x2286DD0", Offset = "0x22861D0", Length = "0x2CF")]
	[Token(Token = "0x60008A3")]
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	[Address(RVA = "0x2286D40", Offset = "0x2286140", Length = "0x8C")]
	[Token(Token = "0x60008A2")]
	private void CompileListInitExpression(Expression expr) { }

	[Address(RVA = "0x22870A0", Offset = "0x22864A0", Length = "0x22B")]
	[Token(Token = "0x600087C")]
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	[Address(RVA = "0x22872D0", Offset = "0x22866D0", Length = "0x2F4")]
	[Token(Token = "0x6000881")]
	private void CompileLoopExpression(Expression expr) { }

	[Address(RVA = "0x22881B0", Offset = "0x22875B0", Length = "0x379")]
	[Token(Token = "0x600089B")]
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	[Address(RVA = "0x2287B50", Offset = "0x2286F50", Length = "0xDF")]
	[Token(Token = "0x600086B")]
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	[Address(RVA = "0x22875D0", Offset = "0x22869D0", Length = "0x570")]
	[Token(Token = "0x600086C")]
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	[Address(RVA = "0x2287C30", Offset = "0x2287030", Length = "0xA7")]
	[Token(Token = "0x600089A")]
	private void CompileMemberExpression(Expression expr) { }

	[Address(RVA = "0x2287D70", Offset = "0x2287170", Length = "0x43A")]
	[Token(Token = "0x60008A5")]
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	[Address(RVA = "0x2287CE0", Offset = "0x22870E0", Length = "0x8C")]
	[Token(Token = "0x60008A4")]
	private void CompileMemberInitExpression(Expression expr) { }

	[Address(RVA = "0x2288530", Offset = "0x2287930", Length = "0x539")]
	[Token(Token = "0x6000893")]
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	[Address(RVA = "0x2288A70", Offset = "0x2287E70", Length = "0x9A")]
	[Token(Token = "0x6000892")]
	private void CompileMethodCallExpression(Expression expr) { }

	[Address(RVA = "0x2288B10", Offset = "0x2287F10", Length = "0x1D1")]
	[Token(Token = "0x600087D")]
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	[Address(RVA = "0x2288CF0", Offset = "0x22880F0", Length = "0x5C2")]
	[Token(Token = "0x6000898")]
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	[Address(RVA = "0x22892C0", Offset = "0x22886C0", Length = "0x3A7")]
	[Token(Token = "0x600089C")]
	private void CompileNewArrayExpression(Expression expr) { }

	[Address(RVA = "0x2289670", Offset = "0x2288A70", Length = "0x3D8")]
	[Token(Token = "0x6000899")]
	private void CompileNewExpression(Expression expr) { }

	[Address(RVA = "0x2289A50", Offset = "0x2288E50", Length = "0xA48")]
	[Token(Token = "0x60008AE")]
	private void CompileNoLabelPush(Expression expr) { }

	[Address(RVA = "0x228A580", Offset = "0x2289980", Length = "0x91")]
	[Token(Token = "0x6000871")]
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	[Address(RVA = "0x228A620", Offset = "0x2289A20", Length = "0x6D")]
	[Token(Token = "0x6000876")]
	private void CompileNotExpression(UnaryExpression node) { }

	[Address(RVA = "0x228A690", Offset = "0x2289A90", Length = "0x7F")]
	[Token(Token = "0x600087B")]
	private void CompileOrElseBinaryExpression(Expression expr) { }

	[Address(RVA = "0x228A710", Offset = "0x2289B10", Length = "0x7C")]
	[Token(Token = "0x6000864")]
	private void CompileParameterExpression(Expression expr) { }

	[Address(RVA = "0x228A790", Offset = "0x2289B90", Length = "0x324")]
	[Token(Token = "0x60008A7")]
	private void CompileQuoteUnaryExpression(Expression expr) { }

	[Address(RVA = "0x228AAC0", Offset = "0x2289EC0", Length = "0x286")]
	[Token(Token = "0x600089E")]
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	[Address(RVA = "0x228AD50", Offset = "0x228A150", Length = "0x200")]
	[Token(Token = "0x6000863")]
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	[Address(RVA = "0x228AF60", Offset = "0x228A360", Length = "0x635")]
	[Token(Token = "0x6000884")]
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	[Address(RVA = "0x228B5A0", Offset = "0x228A9A0", Length = "0x290")]
	[Token(Token = "0x6000882")]
	private void CompileSwitchExpression(Expression expr) { }

	[Address(RVA = "0x228BD90", Offset = "0x228B190", Length = "0x2E7")]
	[Token(Token = "0x600088F")]
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	[Address(RVA = "0x228C080", Offset = "0x228B480", Length = "0x304")]
	[Token(Token = "0x6000857")]
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	[Address(RVA = "0x228C390", Offset = "0x228B790", Length = "0xC6D")]
	[Token(Token = "0x6000890")]
	private void CompileTryExpression(Expression expr) { }

	[Address(RVA = "0x228D000", Offset = "0x228C400", Length = "0x45F")]
	[Token(Token = "0x6000891")]
	private void CompileTryFaultExpression(TryExpression expr) { }

	[Address(RVA = "0x228D460", Offset = "0x228C860", Length = "0xA7")]
	[Token(Token = "0x60008AA")]
	private void CompileTypeAsExpression(UnaryExpression node) { }

	[Address(RVA = "0x228D510", Offset = "0x228C910", Length = "0x214")]
	[Token(Token = "0x60008A9")]
	private void CompileTypeEqualExpression(Expression expr) { }

	[Address(RVA = "0x228D730", Offset = "0x228CB30", Length = "0x280")]
	[Token(Token = "0x60008AB")]
	private void CompileTypeIsExpression(Expression expr) { }

	[Address(RVA = "0x228D9C0", Offset = "0x228CDC0", Length = "0x4CC")]
	[Token(Token = "0x6000877")]
	private void CompileUnaryExpression(Expression expr) { }

	[Address(RVA = "0x228DEB0", Offset = "0x228D2B0", Length = "0x13E")]
	[Token(Token = "0x60008A8")]
	private void CompileUnboxUnaryExpression(Expression expr) { }

	[Address(RVA = "0x228DFF0", Offset = "0x228D3F0", Length = "0x127")]
	[Token(Token = "0x600087F")]
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	[Address(RVA = "0x228E120", Offset = "0x228D520", Length = "0xAC")]
	[Token(Token = "0x600086D")]
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	[Address(RVA = "0x228E260", Offset = "0x228D660", Length = "0x139")]
	[Token(Token = "0x600088D")]
	private void DefineBlockLabels(Expression node) { }

	[Address(RVA = "0x228E3A0", Offset = "0x228D7A0", Length = "0x93")]
	[Token(Token = "0x600088B")]
	private LabelInfo DefineLabel(LabelTarget node) { }

	[Address(RVA = "0x228E440", Offset = "0x228D840", Length = "0xB4")]
	[Token(Token = "0x600085F")]
	private void EmitCopyValueType(Type valueType) { }

	[Address(RVA = "0x228E500", Offset = "0x228D900", Length = "0xF6")]
	[Token(Token = "0x6000869")]
	private void EmitIndexGet(IndexExpression index) { }

	[Address(RVA = "0x228E600", Offset = "0x228DA00", Length = "0xE")]
	[Token(Token = "0x6000895")]
	private void EmitThisForMethodCall(Expression node) { }

	[Address(RVA = "0x228E610", Offset = "0x228DA10", Length = "0x1F5")]
	[Token(Token = "0x6000879")]
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	[Address(RVA = "0x228E810", Offset = "0x228DC10", Length = "0x10A")]
	[Token(Token = "0x6000878")]
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	[Address(RVA = "0x228E920", Offset = "0x228DD20", Length = "0x156")]
	[Token(Token = "0x600085C")]
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	[Address(RVA = "0x228EA80", Offset = "0x228DE80", Length = "0xCD")]
	[Token(Token = "0x6000889")]
	private LabelInfo EnsureLabel(LabelTarget node) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000856")]
	public InstructionList get_Instructions() { }

	[Address(RVA = "0x228EB50", Offset = "0x228DF50", Length = "0x17A")]
	[Token(Token = "0x60008A6")]
	private static Type GetMemberType(MemberInfo member) { }

	[Address(RVA = "0x228ECD0", Offset = "0x228E0D0", Length = "0x13E")]
	[Token(Token = "0x6000860")]
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	[Address(RVA = "0x228EE10", Offset = "0x228E210", Length = "0x474")]
	[Token(Token = "0x6000858")]
	private Interpreter MakeInterpreter(string lambdaName) { }

	[Address(RVA = "0x228F290", Offset = "0x228E690", Length = "0x55")]
	[Token(Token = "0x6000861")]
	private bool MaybeMutableValueType(Type type) { }

	[Address(RVA = "0x228F2F0", Offset = "0x228E6F0", Length = "0x27")]
	[Token(Token = "0x6000888")]
	private void PopLabelBlock(LabelScopeKind kind) { }

	[Address(RVA = "0x228F320", Offset = "0x228E720", Length = "0x89")]
	[Token(Token = "0x6000887")]
	private void PushLabelBlock(LabelScopeKind type) { }

	[Address(RVA = "0x228F3B0", Offset = "0x228E7B0", Length = "0xCF")]
	[Token(Token = "0x600088A")]
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	[Address(RVA = "0x228F480", Offset = "0x228E880", Length = "0x61")]
	[Token(Token = "0x600085D")]
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	[Address(RVA = "0x228F4F0", Offset = "0x228E8F0", Length = "0x1BF")]
	[Token(Token = "0x6000896")]
	private static bool ShouldWritebackNode(Expression node) { }

	[Address(RVA = "0x228F6B0", Offset = "0x228EAB0", Length = "0x114")]
	[Token(Token = "0x600088C")]
	private bool TryPushLabelBlock(Expression node) { }

}

