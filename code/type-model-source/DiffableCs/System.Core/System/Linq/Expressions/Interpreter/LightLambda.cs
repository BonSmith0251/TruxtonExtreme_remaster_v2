namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200019C")]
internal class LightLambda
{
	[CompilerGenerated]
	[Token(Token = "0x200019E")]
	private sealed class <>c__DisplayClass74_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400036E")]
		public MethodInfo targetMethod; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036F")]
		public Type delegateType; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000925")]
		public <>c__DisplayClass74_0() { }

		[Address(RVA = "0x22AC6A0", Offset = "0x22ABAA0", Length = "0x34")]
		[Token(Token = "0x6000926")]
		internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }

	}

	[Token(Token = "0x200019D")]
	private class DebugViewPrinter
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000369")]
		private readonly Interpreter _interpreter; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400036A")]
		private readonly Dictionary<Int32, Int32> _tryStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400036B")]
		private readonly Dictionary<Int32, String> _handlerEnter; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400036C")]
		private readonly Dictionary<Int32, Int32> _handlerExit; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400036D")]
		private string _indent; //Field offset: 0x30

		[Address(RVA = "0x2294EB0", Offset = "0x22942B0", Length = "0x139")]
		[Token(Token = "0x600091D")]
		public DebugViewPrinter(Interpreter interpreter) { }

		[Address(RVA = "0x22942A0", Offset = "0x22936A0", Length = "0x9D")]
		[Token(Token = "0x6000920")]
		private void AddHandlerExit(int index) { }

		[Address(RVA = "0x2294340", Offset = "0x2293740", Length = "0xB7")]
		[Token(Token = "0x600091F")]
		private void AddTryStart(int index) { }

		[Address(RVA = "0x2294400", Offset = "0x2293800", Length = "0x320")]
		[Token(Token = "0x600091E")]
		private void Analyze() { }

		[Address(RVA = "0x2294730", Offset = "0x2293B30", Length = "0x43")]
		[Token(Token = "0x6000922")]
		private void Dedent() { }

		[Address(RVA = "0x2294780", Offset = "0x2293B80", Length = "0xF2")]
		[Token(Token = "0x6000924")]
		private void EmitExits(StringBuilder sb, int index) { }

		[Address(RVA = "0x2294880", Offset = "0x2293C80", Length = "0x43")]
		[Token(Token = "0x6000921")]
		private void Indent() { }

		[Address(RVA = "0x22948D0", Offset = "0x2293CD0", Length = "0x5D6")]
		[Token(Token = "0x6000923")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x4000367")]
	private static readonly CacheDict<Type, Func`2<LightLambda, Delegate>> _runCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000365")]
	private readonly IStrongBox[] _closure; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000366")]
	private readonly Interpreter _interpreter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000368")]
	private readonly LightDelegateCreator _delegateCreator; //Field offset: 0x20

	[Token(Token = "0x170001D0")]
	internal string DebugView
	{
		[Address(RVA = "0x229D090", Offset = "0x229C490", Length = "0x186")]
		[Token(Token = "0x6000913")]
		internal get { } //Length: 390
	}

	[Address(RVA = "0x229CF90", Offset = "0x229C390", Length = "0x89")]
	[Token(Token = "0x600091C")]
	private static LightLambda() { }

	[Address(RVA = "0x229D020", Offset = "0x229C420", Length = "0x69")]
	[Token(Token = "0x6000912")]
	internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	[Address(RVA = "0x229B670", Offset = "0x229AA70", Length = "0x7C6")]
	[Token(Token = "0x6000916")]
	private Delegate CreateCustomDelegate(Type delegateType) { }

	[Address(RVA = "0x229D090", Offset = "0x229C490", Length = "0x186")]
	[Token(Token = "0x6000913")]
	internal string get_DebugView() { }

	[Address(RVA = "0x229BE40", Offset = "0x229B240", Length = "0x188")]
	[Token(Token = "0x6000914")]
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	[Address(RVA = "0x229BFD0", Offset = "0x229B3D0", Length = "0x7D")]
	[Token(Token = "0x6000917")]
	internal Delegate MakeDelegate(Type delegateType) { }

	[Address(RVA = "0x229C050", Offset = "0x229B450", Length = "0x69")]
	[Token(Token = "0x6000918")]
	private InterpretedFrame MakeFrame() { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008D4")]
	internal static Delegate MakeRun0(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008D8")]
	internal static Delegate MakeRun1(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008FC")]
	internal static Delegate MakeRun10(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000900")]
	internal static Delegate MakeRun11(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000904")]
	internal static Delegate MakeRun12(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000908")]
	internal static Delegate MakeRun13(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x600090C")]
	internal static Delegate MakeRun14(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000910")]
	internal static Delegate MakeRun15(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008DC")]
	internal static Delegate MakeRun2(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E0")]
	internal static Delegate MakeRun3(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E4")]
	internal static Delegate MakeRun4(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E8")]
	internal static Delegate MakeRun5(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008EC")]
	internal static Delegate MakeRun6(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F0")]
	internal static Delegate MakeRun7(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F4")]
	internal static Delegate MakeRun8(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F8")]
	internal static Delegate MakeRun9(LightLambda lambda) { }

	[Address(RVA = "0x229C0C0", Offset = "0x229B4C0", Length = "0x94D")]
	[Token(Token = "0x6000915")]
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	[Address(RVA = "0x229CA10", Offset = "0x229BE10", Length = "0x67")]
	[Token(Token = "0x60008D5")]
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008D9")]
	internal static Delegate MakeRunVoid1(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008FD")]
	internal static Delegate MakeRunVoid10(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000901")]
	internal static Delegate MakeRunVoid11(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000905")]
	internal static Delegate MakeRunVoid12(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000909")]
	internal static Delegate MakeRunVoid13(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x600090D")]
	internal static Delegate MakeRunVoid14(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x6000911")]
	internal static Delegate MakeRunVoid15(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008DD")]
	internal static Delegate MakeRunVoid2(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E1")]
	internal static Delegate MakeRunVoid3(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E5")]
	internal static Delegate MakeRunVoid4(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008E9")]
	internal static Delegate MakeRunVoid5(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008ED")]
	internal static Delegate MakeRunVoid6(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F1")]
	internal static Delegate MakeRunVoid7(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F5")]
	internal static Delegate MakeRunVoid8(LightLambda lambda) { }

	[Address(RVA = "0x853840", Offset = "0x852C40", Length = "0x72")]
	[Token(Token = "0x60008F9")]
	internal static Delegate MakeRunVoid9(LightLambda lambda) { }

	[Address(RVA = "0x229CD90", Offset = "0x229C190", Length = "0x1F9")]
	[Token(Token = "0x600091A")]
	public object Run(Object[] arguments) { }

	[Address(RVA = "0x8538C0", Offset = "0x852CC0", Length = "0x199")]
	[Token(Token = "0x60008D2")]
	internal TRet Run0() { }

	[Address(RVA = "0x8584F0", Offset = "0x8578F0", Length = "0x276")]
	[Token(Token = "0x60008D6")]
	internal TRet Run1(T0 arg0) { }

	[Address(RVA = "0x853A60", Offset = "0x852E60", Length = "0xA29")]
	[Token(Token = "0x60008FA")]
	internal TRet Run10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	[Address(RVA = "0x854490", Offset = "0x853890", Length = "0xB0A")]
	[Token(Token = "0x60008FE")]
	internal TRet Run11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	[Address(RVA = "0x854FA0", Offset = "0x8543A0", Length = "0xBED")]
	[Token(Token = "0x6000902")]
	internal TRet Run12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	[Address(RVA = "0x855B90", Offset = "0x854F90", Length = "0xCD9")]
	[Token(Token = "0x6000906")]
	internal TRet Run13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	[Address(RVA = "0x856870", Offset = "0x855C70", Length = "0xDC2")]
	[Token(Token = "0x600090A")]
	internal TRet Run14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	[Address(RVA = "0x857640", Offset = "0x856A40", Length = "0xEAE")]
	[Token(Token = "0x600090E")]
	internal TRet Run15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	[Address(RVA = "0x858770", Offset = "0x857B70", Length = "0x354")]
	[Token(Token = "0x60008DA")]
	internal TRet Run2(T0 arg0, T1 arg1) { }

	[Address(RVA = "0x858AD0", Offset = "0x857ED0", Length = "0x418")]
	[Token(Token = "0x60008DE")]
	internal TRet Run3(T0 arg0, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x858EF0", Offset = "0x8582F0", Length = "0x4E8")]
	[Token(Token = "0x60008E2")]
	internal TRet Run4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[Address(RVA = "0x8593E0", Offset = "0x8587E0", Length = "0x5BA")]
	[Token(Token = "0x60008E6")]
	internal TRet Run5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[Address(RVA = "0x8599A0", Offset = "0x858DA0", Length = "0x68F")]
	[Token(Token = "0x60008EA")]
	internal TRet Run6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	[Address(RVA = "0x85A030", Offset = "0x859430", Length = "0x770")]
	[Token(Token = "0x60008EE")]
	internal TRet Run7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	[Address(RVA = "0x85A7B0", Offset = "0x859BB0", Length = "0x856")]
	[Token(Token = "0x60008F2")]
	internal TRet Run8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	[Address(RVA = "0x85B010", Offset = "0x85A410", Length = "0x942")]
	[Token(Token = "0x60008F6")]
	internal TRet Run9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	[Address(RVA = "0x229CBA0", Offset = "0x229BFA0", Length = "0x1E7")]
	[Token(Token = "0x600091B")]
	public object RunVoid(Object[] arguments) { }

	[Address(RVA = "0x229CA80", Offset = "0x229BE80", Length = "0x116")]
	[Token(Token = "0x60008D3")]
	internal void RunVoid0() { }

	[Address(RVA = "0x8600E0", Offset = "0x85F4E0", Length = "0x1B4")]
	[Token(Token = "0x60008D7")]
	internal void RunVoid1(T0 arg0) { }

	[Address(RVA = "0x85B960", Offset = "0x85AD60", Length = "0x996")]
	[Token(Token = "0x60008FB")]
	internal void RunVoid10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

	[Address(RVA = "0x85C300", Offset = "0x85B700", Length = "0xA7F")]
	[Token(Token = "0x60008FF")]
	internal void RunVoid11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

	[Address(RVA = "0x85CD80", Offset = "0x85C180", Length = "0xB68")]
	[Token(Token = "0x6000903")]
	internal void RunVoid12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

	[Address(RVA = "0x85D8F0", Offset = "0x85CCF0", Length = "0xC57")]
	[Token(Token = "0x6000907")]
	internal void RunVoid13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

	[Address(RVA = "0x85E550", Offset = "0x85D950", Length = "0xD46")]
	[Token(Token = "0x600090B")]
	internal void RunVoid14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

	[Address(RVA = "0x85F2A0", Offset = "0x85E6A0", Length = "0xE32")]
	[Token(Token = "0x600090F")]
	internal void RunVoid15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

	[Address(RVA = "0x8602A0", Offset = "0x85F6A0", Length = "0x2B3")]
	[Token(Token = "0x60008DB")]
	internal void RunVoid2(T0 arg0, T1 arg1) { }

	[Address(RVA = "0x860560", Offset = "0x85F960", Length = "0x38B")]
	[Token(Token = "0x60008DF")]
	internal void RunVoid3(T0 arg0, T1 arg1, T2 arg2) { }

	[Address(RVA = "0x8608F0", Offset = "0x85FCF0", Length = "0x468")]
	[Token(Token = "0x60008E3")]
	internal void RunVoid4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[Address(RVA = "0x860D60", Offset = "0x860160", Length = "0x53B")]
	[Token(Token = "0x60008E7")]
	internal void RunVoid5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[Address(RVA = "0x8612A0", Offset = "0x8606A0", Length = "0x614")]
	[Token(Token = "0x60008EB")]
	internal void RunVoid6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }

	[Address(RVA = "0x8618C0", Offset = "0x860CC0", Length = "0x6E3")]
	[Token(Token = "0x60008EF")]
	internal void RunVoid7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	[Address(RVA = "0x861FB0", Offset = "0x8613B0", Length = "0x7C0")]
	[Token(Token = "0x60008F3")]
	internal void RunVoid8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }

	[Address(RVA = "0x862780", Offset = "0x861B80", Length = "0x8A6")]
	[Token(Token = "0x60008F7")]
	internal void RunVoid9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }

	[Address(RVA = "0x863030", Offset = "0x862430", Length = "0x2F6")]
	[Token(Token = "0x6000919")]
	internal void RunVoidRef2(ref T0 arg0, ref T1 arg1) { }

}

