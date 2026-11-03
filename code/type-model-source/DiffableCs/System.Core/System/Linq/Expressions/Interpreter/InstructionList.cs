namespace System.Linq.Expressions.Interpreter;

[DebuggerTypeProxy(typeof(DebugView))]
[Token(Token = "0x200015F")]
internal sealed class InstructionList
{
	[Token(Token = "0x2000160")]
	public sealed class DebugView
	{
		[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
		[IsReadOnly]
		[Token(Token = "0x2000161")]
		public struct InstructionView
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40002C8")]
			private readonly int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x40002C9")]
			private readonly int _stackDepth; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x40002CA")]
			private readonly int _continuationsDepth; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002CB")]
			private readonly string _name; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002CC")]
			private readonly Instruction _instruction; //Field offset: 0x18

			[Address(RVA = "0x2279050", Offset = "0x2278450", Length = "0x55")]
			[Token(Token = "0x60007B3")]
			public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }

			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60007B2")]
			internal string GetValue() { }

		}


		[Address(RVA = "0x226E820", Offset = "0x226DC20", Length = "0x410")]
		[Token(Token = "0x60007B1")]
		internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<Object> objects, Func<Int32, Int32> labelIndexer, IReadOnlyList<KeyValuePair`2<Int32, Object>> debugCookies) { }

	}

	[Token(Token = "0x40002B8")]
	private static Instruction s_null; //Field offset: 0x0
	[Token(Token = "0x40002B9")]
	private static Instruction s_true; //Field offset: 0x8
	[Token(Token = "0x40002BA")]
	private static Instruction s_false; //Field offset: 0x10
	[Token(Token = "0x40002BB")]
	private static Instruction[] s_Ints; //Field offset: 0x18
	[Token(Token = "0x40002BC")]
	private static Instruction[] s_loadObjectCached; //Field offset: 0x20
	[Token(Token = "0x40002BD")]
	private static Instruction[] s_loadLocal; //Field offset: 0x28
	[Token(Token = "0x40002BE")]
	private static Instruction[] s_loadLocalBoxed; //Field offset: 0x30
	[Token(Token = "0x40002BF")]
	private static Instruction[] s_loadLocalFromClosure; //Field offset: 0x38
	[Token(Token = "0x40002C0")]
	private static Instruction[] s_loadLocalFromClosureBoxed; //Field offset: 0x40
	[Token(Token = "0x40002C1")]
	private static Instruction[] s_assignLocal; //Field offset: 0x48
	[Token(Token = "0x40002C2")]
	private static Instruction[] s_storeLocal; //Field offset: 0x50
	[Token(Token = "0x40002C3")]
	private static Instruction[] s_assignLocalBoxed; //Field offset: 0x58
	[Token(Token = "0x40002C4")]
	private static Instruction[] s_storeLocalBoxed; //Field offset: 0x60
	[Token(Token = "0x40002C5")]
	private static Instruction[] s_assignLocalToClosure; //Field offset: 0x68
	[Token(Token = "0x40002C6")]
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; //Field offset: 0x70
	[Token(Token = "0x40002C7")]
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; //Field offset: 0x78
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002AF")]
	private readonly List<Instruction> _instructions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B0")]
	private List<Object> _objects; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B1")]
	private int _currentStackDepth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002B2")]
	private int _maxStackDepth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B3")]
	private int _currentContinuationsDepth; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002B4")]
	private int _maxContinuationDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B5")]
	private int _runtimeLabelCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B6")]
	private List<BranchLabel> _labels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002B7")]
	private List<KeyValuePair`2<Int32, Object>> _debugCookies; //Field offset: 0x40

	[Token(Token = "0x170001B3")]
	public int Count
	{
		[Address(RVA = "0x2279010", Offset = "0x2278410", Length = "0x3C")]
		[Token(Token = "0x6000742")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170001B5")]
	public int CurrentContinuationsDepth
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000744")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001B4")]
	public int CurrentStackDepth
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000743")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2278E60", Offset = "0x2278260", Length = "0x123")]
	[Token(Token = "0x60007B0")]
	private static InstructionList() { }

	[Address(RVA = "0x2278F90", Offset = "0x2278390", Length = "0x77")]
	[Token(Token = "0x60007AF")]
	public InstructionList() { }

	[Address(RVA = "0x2274410", Offset = "0x2273810", Length = "0x207")]
	[Token(Token = "0x6000755")]
	internal static Instruction AssignLocalBoxed(int index) { }

	[Address(RVA = "0x2274620", Offset = "0x2273A20", Length = "0x25C")]
	[Token(Token = "0x6000790")]
	private RuntimeLabel[] BuildRuntimeLabels() { }

	[Address(RVA = "0x2277E10", Offset = "0x2277210", Length = "0x145")]
	[Token(Token = "0x600073F")]
	public void Emit(Instruction instruction) { }

	[Address(RVA = "0x2274880", Offset = "0x2273C80", Length = "0x3F")]
	[Token(Token = "0x6000766")]
	public void EmitAdd(Type type, bool checked) { }

	[Address(RVA = "0x22748C0", Offset = "0x2273CC0", Length = "0x29")]
	[Token(Token = "0x600076C")]
	public void EmitAnd(Type type) { }

	[Address(RVA = "0x22748F0", Offset = "0x2273CF0", Length = "0x5E")]
	[Token(Token = "0x6000782")]
	public void EmitArrayLength() { }

	[Address(RVA = "0x2274BE0", Offset = "0x2273FE0", Length = "0x214")]
	[Token(Token = "0x6000752")]
	public void EmitAssignLocal(int index) { }

	[Address(RVA = "0x2274950", Offset = "0x2273D50", Length = "0x61")]
	[Token(Token = "0x6000754")]
	public void EmitAssignLocalBoxed(int index) { }

	[Address(RVA = "0x22749C0", Offset = "0x2273DC0", Length = "0x214")]
	[Token(Token = "0x6000758")]
	public void EmitAssignLocalToClosure(int index) { }

	[Address(RVA = "0x2275010", Offset = "0x2274410", Length = "0xD2")]
	[Token(Token = "0x6000799")]
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	[Address(RVA = "0x2274F60", Offset = "0x2274360", Length = "0xAB")]
	[Token(Token = "0x6000798")]
	public void EmitBranch(BranchLabel label) { }

	[Address(RVA = "0x22750F0", Offset = "0x22744F0", Length = "0x66")]
	[Token(Token = "0x6000797")]
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	[Address(RVA = "0x2274E00", Offset = "0x2274200", Length = "0xAB")]
	[Token(Token = "0x600079C")]
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	[Address(RVA = "0x2274EB0", Offset = "0x22742B0", Length = "0xAB")]
	[Token(Token = "0x600079B")]
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	[Address(RVA = "0x2275160", Offset = "0x2274560", Length = "0xBA")]
	[Token(Token = "0x600078E")]
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x2275220", Offset = "0x2274620", Length = "0x9E")]
	[Token(Token = "0x600077F")]
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	[Address(RVA = "0x22752C0", Offset = "0x22746C0", Length = "0x30")]
	[Token(Token = "0x600078D")]
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	[Address(RVA = "0x22752F0", Offset = "0x22746F0", Length = "0x71")]
	[Token(Token = "0x600078C")]
	public void EmitCall(MethodInfo method) { }

	[Address(RVA = "0x2275450", Offset = "0x2274850", Length = "0x29")]
	[Token(Token = "0x6000779")]
	public void EmitCast(Type toType) { }

	[Address(RVA = "0x2275370", Offset = "0x2274770", Length = "0x6B")]
	[Token(Token = "0x600077B")]
	public void EmitCastReferenceToEnum(Type toType) { }

	[Address(RVA = "0x22753E0", Offset = "0x22747E0", Length = "0x6B")]
	[Token(Token = "0x600077A")]
	public void EmitCastToEnum(Type toType) { }

	[Address(RVA = "0x2275480", Offset = "0x2274880", Length = "0xAB")]
	[Token(Token = "0x600079A")]
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	[Address(RVA = "0x2275530", Offset = "0x2274930", Length = "0x7B")]
	[Token(Token = "0x6000778")]
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x22755B0", Offset = "0x22749B0", Length = "0x6B")]
	[Token(Token = "0x6000780")]
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	[Address(RVA = "0x2275620", Offset = "0x2274A20", Length = "0x29")]
	[Token(Token = "0x6000786")]
	public void EmitDecrement(Type type) { }

	[Address(RVA = "0x2275650", Offset = "0x2274A50", Length = "0x6B")]
	[Token(Token = "0x600077D")]
	public void EmitDefaultValue(Type type) { }

	[Address(RVA = "0x22756C0", Offset = "0x2274AC0", Length = "0x29")]
	[Token(Token = "0x6000769")]
	public void EmitDiv(Type type) { }

	[Address(RVA = "0x22756F0", Offset = "0x2274AF0", Length = "0x5E")]
	[Token(Token = "0x600074A")]
	public void EmitDup() { }

	[Address(RVA = "0x2275750", Offset = "0x2274B50", Length = "0x5E")]
	[Token(Token = "0x60007A8")]
	public void EmitEnterExceptionFilter() { }

	[Address(RVA = "0x22757B0", Offset = "0x2274BB0", Length = "0x5F")]
	[Token(Token = "0x60007AA")]
	public void EmitEnterExceptionHandlerNonVoid() { }

	[Address(RVA = "0x2275810", Offset = "0x2274C10", Length = "0x5E")]
	[Token(Token = "0x60007AB")]
	public void EmitEnterExceptionHandlerVoid() { }

	[Address(RVA = "0x2275870", Offset = "0x2274C70", Length = "0x86")]
	[Token(Token = "0x60007A6")]
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	[Address(RVA = "0x2275900", Offset = "0x2274D00", Length = "0x86")]
	[Token(Token = "0x60007A4")]
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	[Address(RVA = "0x2275990", Offset = "0x2274D90", Length = "0x23")]
	[Token(Token = "0x60007A2")]
	public void EmitEnterTryCatch() { }

	[Address(RVA = "0x22759C0", Offset = "0x2274DC0", Length = "0x92")]
	[Token(Token = "0x60007A3")]
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	[Address(RVA = "0x2275A60", Offset = "0x2274E60", Length = "0x53")]
	[Token(Token = "0x60007A1")]
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	[Address(RVA = "0x2275AC0", Offset = "0x2274EC0", Length = "0x31")]
	[Token(Token = "0x6000770")]
	public void EmitEqual(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x2275B00", Offset = "0x2274F00", Length = "0x29")]
	[Token(Token = "0x600076B")]
	public void EmitExclusiveOr(Type type) { }

	[Address(RVA = "0x2275B30", Offset = "0x2274F30", Length = "0x5E")]
	[Token(Token = "0x6000761")]
	public void EmitGetArrayItem() { }

	[Address(RVA = "0x2275B90", Offset = "0x2274F90", Length = "0xB7")]
	[Token(Token = "0x6000796")]
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	[Address(RVA = "0x2275C90", Offset = "0x2275090", Length = "0x31")]
	[Token(Token = "0x6000774")]
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	[Address(RVA = "0x2275C50", Offset = "0x2275050", Length = "0x31")]
	[Token(Token = "0x6000775")]
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	[Address(RVA = "0x2275CD0", Offset = "0x22750D0", Length = "0x29")]
	[Token(Token = "0x6000785")]
	public void EmitIncrement(Type type) { }

	[Address(RVA = "0x2275D00", Offset = "0x2275100", Length = "0x13E")]
	[Token(Token = "0x600075A")]
	public void EmitInitializeLocal(int index, Type type) { }

	[Address(RVA = "0x2275E40", Offset = "0x2275240", Length = "0x9A")]
	[Token(Token = "0x600075B")]
	internal void EmitInitializeParameter(int index) { }

	[Address(RVA = "0x84C1F0", Offset = "0x84B5F0", Length = "0x85")]
	[Token(Token = "0x60007AD")]
	public void EmitIntSwitch(Dictionary<T, Int32> cases) { }

	[Address(RVA = "0x2275EE0", Offset = "0x22752E0", Length = "0x5E")]
	[Token(Token = "0x60007A9")]
	public void EmitLeaveExceptionFilter() { }

	[Address(RVA = "0x2275F40", Offset = "0x2275340", Length = "0x98")]
	[Token(Token = "0x60007AC")]
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	[Address(RVA = "0x2275FE0", Offset = "0x22753E0", Length = "0x5E")]
	[Token(Token = "0x60007A7")]
	public void EmitLeaveFault() { }

	[Address(RVA = "0x2276040", Offset = "0x2275440", Length = "0x5E")]
	[Token(Token = "0x60007A5")]
	public void EmitLeaveFinally() { }

	[Address(RVA = "0x22760A0", Offset = "0x22754A0", Length = "0x29")]
	[Token(Token = "0x600076E")]
	public void EmitLeftShift(Type type) { }

	[Address(RVA = "0x2276110", Offset = "0x2275510", Length = "0x31")]
	[Token(Token = "0x6000772")]
	public void EmitLessThan(Type type, bool liftedToNull) { }

	[Address(RVA = "0x22760D0", Offset = "0x22754D0", Length = "0x31")]
	[Token(Token = "0x6000773")]
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	[Address(RVA = "0x2276850", Offset = "0x2275C50", Length = "0x609")]
	[Token(Token = "0x6000749")]
	public void EmitLoad(object value, Type type) { }

	[Address(RVA = "0x2276E60", Offset = "0x2276260", Length = "0x1E7")]
	[Token(Token = "0x6000748")]
	public void EmitLoad(bool value) { }

	[Address(RVA = "0x2277050", Offset = "0x2276450", Length = "0xB")]
	[Token(Token = "0x6000747")]
	public void EmitLoad(object value) { }

	[Address(RVA = "0x2276150", Offset = "0x2275550", Length = "0x24")]
	[Token(Token = "0x6000789")]
	public void EmitLoadField(FieldInfo field) { }

	[Address(RVA = "0x2276630", Offset = "0x2275A30", Length = "0x214")]
	[Token(Token = "0x600074D")]
	public void EmitLoadLocal(int index) { }

	[Address(RVA = "0x2276180", Offset = "0x2275580", Length = "0x61")]
	[Token(Token = "0x600074E")]
	public void EmitLoadLocalBoxed(int index) { }

	[Address(RVA = "0x2276410", Offset = "0x2275810", Length = "0x214")]
	[Token(Token = "0x6000750")]
	public void EmitLoadLocalFromClosure(int index) { }

	[Address(RVA = "0x22761F0", Offset = "0x22755F0", Length = "0x214")]
	[Token(Token = "0x6000751")]
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	[Address(RVA = "0x2277060", Offset = "0x2276460", Length = "0x29")]
	[Token(Token = "0x600076A")]
	public void EmitModulo(Type type) { }

	[Address(RVA = "0x2277090", Offset = "0x2276490", Length = "0x3F")]
	[Token(Token = "0x6000768")]
	public void EmitMul(Type type, bool checked) { }

	[Address(RVA = "0x2277100", Offset = "0x2276500", Length = "0x29")]
	[Token(Token = "0x6000783")]
	public void EmitNegate(Type type) { }

	[Address(RVA = "0x22770D0", Offset = "0x22764D0", Length = "0x29")]
	[Token(Token = "0x6000784")]
	public void EmitNegateChecked(Type type) { }

	[Address(RVA = "0x2277310", Offset = "0x2276710", Length = "0x86")]
	[Token(Token = "0x600077E")]
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	[Address(RVA = "0x2277230", Offset = "0x2276630", Length = "0x6B")]
	[Token(Token = "0x6000763")]
	public void EmitNewArray(Type elementType) { }

	[Address(RVA = "0x2277130", Offset = "0x2276530", Length = "0x7B")]
	[Token(Token = "0x6000764")]
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	[Address(RVA = "0x22771B0", Offset = "0x22765B0", Length = "0x7B")]
	[Token(Token = "0x6000765")]
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	[Address(RVA = "0x22772A0", Offset = "0x22766A0", Length = "0x69")]
	[Token(Token = "0x6000760")]
	public void EmitNewRuntimeVariables(int count) { }

	[Address(RVA = "0x22773E0", Offset = "0x22767E0", Length = "0x29")]
	[Token(Token = "0x600077C")]
	public void EmitNot(Type type) { }

	[Address(RVA = "0x22773A0", Offset = "0x22767A0", Length = "0x31")]
	[Token(Token = "0x6000771")]
	public void EmitNotEqual(Type type, bool liftedToNull = false) { }

	[Address(RVA = "0x2277410", Offset = "0x2276810", Length = "0x6B")]
	[Token(Token = "0x600078F")]
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	[Address(RVA = "0x2277480", Offset = "0x2276880", Length = "0x93")]
	[Token(Token = "0x6000776")]
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x2277520", Offset = "0x2276920", Length = "0x93")]
	[Token(Token = "0x6000777")]
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	[Address(RVA = "0x22775C0", Offset = "0x22769C0", Length = "0x29")]
	[Token(Token = "0x600076D")]
	public void EmitOr(Type type) { }

	[Address(RVA = "0x22775F0", Offset = "0x22769F0", Length = "0x5E")]
	[Token(Token = "0x600074B")]
	public void EmitPop() { }

	[Address(RVA = "0x22776B0", Offset = "0x2276AB0", Length = "0x5F")]
	[Token(Token = "0x600079F")]
	public void EmitRethrow() { }

	[Address(RVA = "0x2277650", Offset = "0x2276A50", Length = "0x5F")]
	[Token(Token = "0x60007A0")]
	public void EmitRethrowVoid() { }

	[Address(RVA = "0x2277710", Offset = "0x2276B10", Length = "0x29")]
	[Token(Token = "0x600076F")]
	public void EmitRightShift(Type type) { }

	[Address(RVA = "0x2277740", Offset = "0x2276B40", Length = "0x5E")]
	[Token(Token = "0x6000762")]
	public void EmitSetArrayItem() { }

	[Address(RVA = "0x22777A0", Offset = "0x2276BA0", Length = "0xA2")]
	[Token(Token = "0x600078B")]
	public void EmitStoreField(FieldInfo field) { }

	[Address(RVA = "0x2277930", Offset = "0x2276D30", Length = "0x214")]
	[Token(Token = "0x6000753")]
	public void EmitStoreLocal(int index) { }

	[Address(RVA = "0x2277850", Offset = "0x2276C50", Length = "0x61")]
	[Token(Token = "0x6000756")]
	public void EmitStoreLocalBoxed(int index) { }

	[Address(RVA = "0x22778C0", Offset = "0x2276CC0", Length = "0x66")]
	[Token(Token = "0x6000759")]
	public void EmitStoreLocalToClosure(int index) { }

	[Address(RVA = "0x2277B50", Offset = "0x2276F50", Length = "0x7B")]
	[Token(Token = "0x60007AE")]
	public void EmitStringSwitch(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	[Address(RVA = "0x2277BD0", Offset = "0x2276FD0", Length = "0x3F")]
	[Token(Token = "0x6000767")]
	public void EmitSub(Type type, bool checked) { }

	[Address(RVA = "0x2277C70", Offset = "0x2277070", Length = "0x5E")]
	[Token(Token = "0x600079D")]
	public void EmitThrow() { }

	[Address(RVA = "0x2277C10", Offset = "0x2277010", Length = "0x5F")]
	[Token(Token = "0x600079E")]
	public void EmitThrowVoid() { }

	[Address(RVA = "0x2277CD0", Offset = "0x22770D0", Length = "0x6B")]
	[Token(Token = "0x6000788")]
	public void EmitTypeAs(Type type) { }

	[Address(RVA = "0x2277D40", Offset = "0x2277140", Length = "0x5E")]
	[Token(Token = "0x6000781")]
	public void EmitTypeEquals() { }

	[Address(RVA = "0x2277DA0", Offset = "0x22771A0", Length = "0x6B")]
	[Token(Token = "0x6000787")]
	public void EmitTypeIs(Type type) { }

	[Address(RVA = "0x2277F60", Offset = "0x2277360", Length = "0x3F")]
	[Token(Token = "0x6000793")]
	private int EnsureLabelIndex(BranchLabel label) { }

	[Address(RVA = "0x2277FA0", Offset = "0x22773A0", Length = "0xDE")]
	[Token(Token = "0x6000792")]
	internal void FixupBranch(int branchIndex, int offset) { }

	[Address(RVA = "0x2279010", Offset = "0x2278410", Length = "0x3C")]
	[Token(Token = "0x6000742")]
	public int get_Count() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000744")]
	public int get_CurrentContinuationsDepth() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000743")]
	public int get_CurrentStackDepth() { }

	[Address(RVA = "0x2278080", Offset = "0x2277480", Length = "0x51")]
	[Token(Token = "0x6000745")]
	internal Instruction GetInstruction(int index) { }

	[Address(RVA = "0x22780E0", Offset = "0x22774E0", Length = "0x247")]
	[Token(Token = "0x600078A")]
	private Instruction GetLoadField(FieldInfo field) { }

	[Address(RVA = "0x2278330", Offset = "0x2277730", Length = "0x52")]
	[Token(Token = "0x600075F")]
	internal static Instruction InitImmutableRefBox(int index) { }

	[Address(RVA = "0x2278390", Offset = "0x2277790", Length = "0x52")]
	[Token(Token = "0x600075E")]
	internal static Instruction InitReference(int index) { }

	[Address(RVA = "0x22783F0", Offset = "0x22777F0", Length = "0x207")]
	[Token(Token = "0x600074F")]
	internal static Instruction LoadLocalBoxed(int index) { }

	[Address(RVA = "0x2278600", Offset = "0x2277A00", Length = "0x123")]
	[Token(Token = "0x6000791")]
	public BranchLabel MakeLabel() { }

	[Address(RVA = "0x2278730", Offset = "0x2277B30", Length = "0x23")]
	[Token(Token = "0x6000795")]
	public void MarkLabel(BranchLabel label) { }

	[Address(RVA = "0x2278760", Offset = "0x2277B60", Length = "0x54")]
	[Token(Token = "0x6000794")]
	public int MarkRuntimeLabel() { }

	[Address(RVA = "0x2278820", Offset = "0x2277C20", Length = "0x52")]
	[Token(Token = "0x600075C")]
	internal static Instruction Parameter(int index) { }

	[Address(RVA = "0x22787C0", Offset = "0x2277BC0", Length = "0x52")]
	[Token(Token = "0x600075D")]
	internal static Instruction ParameterBox(int index) { }

	[Address(RVA = "0x2278880", Offset = "0x2277C80", Length = "0x207")]
	[Token(Token = "0x6000757")]
	internal static Instruction StoreLocalBoxed(int index) { }

	[Address(RVA = "0x2278A90", Offset = "0x2277E90", Length = "0xBE")]
	[Token(Token = "0x600074C")]
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	[Address(RVA = "0x2278B50", Offset = "0x2277F50", Length = "0x121")]
	[Token(Token = "0x6000746")]
	public InstructionArray ToArray() { }

	[Address(RVA = "0x2278C80", Offset = "0x2278080", Length = "0x11A")]
	[Token(Token = "0x6000741")]
	public void UnEmit() { }

	[Address(RVA = "0x2278DA0", Offset = "0x22781A0", Length = "0xB7")]
	[Token(Token = "0x6000740")]
	private void UpdateStackDepth(Instruction instruction) { }

}

