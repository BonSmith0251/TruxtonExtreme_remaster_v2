namespace UnityEngine;

[MovedFrom(True, "UnityEditor", "UnityEditor", null)]
[Token(Token = "0x20000BC")]
public class ExpressionEvaluator
{
	[CompilerGenerated]
	[Token(Token = "0x20000C2")]
	private sealed class <>c
	{
		[Token(Token = "0x4000237")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000238")]
		public static Func<String, Boolean> <>9__14_0; //Field offset: 0x8

		[Address(RVA = "0x2FF02B0", Offset = "0x2FEF6B0", Length = "0x67")]
		[Token(Token = "0x6000554")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000555")]
		public <>c() { }

		[Address(RVA = "0x2FF00F0", Offset = "0x2FEF4F0", Length = "0xF9")]
		[Token(Token = "0x6000556")]
		internal bool <ExpressionToTokens>b__14_0(string f) { }

	}

	[Token(Token = "0x20000C0")]
	private enum Associativity : int
	{
		Left = 0,
		Right = 1,
	}

	[Token(Token = "0x20000BD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public class Expression
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400021B")]
		internal readonly String[] rpnTokens; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400021C")]
		internal readonly bool hasVariables; //Field offset: 0x18

		[Address(RVA = "0x2FE20C0", Offset = "0x2FE14C0", Length = "0x1EE")]
		[Token(Token = "0x6000549")]
		internal Expression(string expression) { }

		[Address(RVA = "0x2FE1FE0", Offset = "0x2FE13E0", Length = "0x93")]
		[Token(Token = "0x600054B")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x9F1AD0", Offset = "0x9F0ED0", Length = "0x9E")]
		[Token(Token = "0x600054A")]
		public bool Evaluate(ref T value, int index = 0, int count = 1) { }

		[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
		[Token(Token = "0x600054C")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2FE2080", Offset = "0x2FE1480", Length = "0x3D")]
		[Token(Token = "0x600054D")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x20000BF")]
	private enum Op : int
	{
		Add = 0,
		Sub = 1,
		Mul = 2,
		Div = 3,
		Mod = 4,
		Neg = 5,
		Pow = 6,
		Sqrt = 7,
		Sin = 8,
		Cos = 9,
		Tan = 10,
		Floor = 11,
		Ceil = 12,
		Round = 13,
		Rand = 14,
		Linear = 15,
	}

	[Token(Token = "0x20000C1")]
	private class Operator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000233")]
		public readonly Op op; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000234")]
		public readonly int precedence; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000235")]
		public readonly Associativity associativity; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000236")]
		public readonly int inputs; //Field offset: 0x1C

		[Address(RVA = "0x2FE3C40", Offset = "0x2FE3040", Length = "0x4B")]
		[Token(Token = "0x6000553")]
		public Operator(Op op, int precedence, int inputs, Associativity associativity) { }

	}

	[Token(Token = "0x20000BE")]
	private struct PcgRandom
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021D")]
		private readonly ulong increment; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400021E")]
		private ulong state; //Field offset: 0x8

		[Address(RVA = "0x2FE3D30", Offset = "0x2FE3130", Length = "0x24")]
		[Token(Token = "0x600054E")]
		public PcgRandom(ulong state = 0, ulong sequence = 0) { }

		[Address(RVA = "0x2FE3C90", Offset = "0x2FE3090", Length = "0x45")]
		[Token(Token = "0x600054F")]
		public uint GetUInt() { }

		[Address(RVA = "0x1ECFD20", Offset = "0x1ECF120", Length = "0x19")]
		[Token(Token = "0x6000550")]
		private static uint RotateRight(uint v, int rot) { }

		[Address(RVA = "0x2FE3CE0", Offset = "0x2FE30E0", Length = "0x1A")]
		[Token(Token = "0x6000552")]
		private void Step() { }

		[Address(RVA = "0x2FE3D00", Offset = "0x2FE3100", Length = "0x27")]
		[Token(Token = "0x6000551")]
		private static uint XshRr(ulong s) { }

	}

	[Token(Token = "0x4000219")]
	private static PcgRandom s_Random; //Field offset: 0x0
	[Token(Token = "0x400021A")]
	private static Dictionary<String, Operator> s_Operators; //Field offset: 0x10

	[Address(RVA = "0x2FE19A0", Offset = "0x2FE0DA0", Length = "0x638")]
	[Token(Token = "0x6000548")]
	private static ExpressionEvaluator() { }

	[Address(RVA = "0x7ECA50", Offset = "0x7EBE50", Length = "0x12F")]
	[Token(Token = "0x6000539")]
	internal static bool Evaluate(string expression, out T value, out Expression delayed) { }

	[Address(RVA = "0x2FE01D0", Offset = "0x2FDF5D0", Length = "0x4F4")]
	[Token(Token = "0x600053B")]
	private static bool EvaluateDouble(String[] tokens, ref double value, int index, int count) { }

	[Address(RVA = "0x2FE06D0", Offset = "0x2FDFAD0", Length = "0x34C")]
	[Token(Token = "0x6000546")]
	private static double EvaluateOp(Double[] values, Op op, int index, int count) { }

	[Address(RVA = "0x7EBD10", Offset = "0x7EB110", Length = "0x403")]
	[Token(Token = "0x600053A")]
	private static bool EvaluateTokens(String[] tokens, ref T value, int index, int count) { }

	[Address(RVA = "0x2FE0A60", Offset = "0x2FDFE60", Length = "0x3E3")]
	[Token(Token = "0x600053E")]
	private static String[] ExpressionToTokens(string expression, out bool hasVariables) { }

	[Address(RVA = "0x2FE0E50", Offset = "0x2FE0250", Length = "0x173")]
	[Token(Token = "0x6000545")]
	private static String[] FixUnaryOperators(String[] tokens) { }

	[Address(RVA = "0x2FE0FD0", Offset = "0x2FE03D0", Length = "0x4BA")]
	[Token(Token = "0x600053C")]
	private static String[] InfixToRPN(String[] tokens) { }

	[Address(RVA = "0x2FE1490", Offset = "0x2FE0890", Length = "0x7E")]
	[Token(Token = "0x600053F")]
	private static bool IsCommand(string token) { }

	[Address(RVA = "0x2FE1510", Offset = "0x2FE0910", Length = "0x65")]
	[Token(Token = "0x6000541")]
	private static bool IsDelayedFunction(string token) { }

	[Address(RVA = "0x2FE1580", Offset = "0x2FE0980", Length = "0x79")]
	[Token(Token = "0x6000542")]
	private static bool IsOperator(string token) { }

	[Address(RVA = "0x2FE1600", Offset = "0x2FE0A00", Length = "0x51")]
	[Token(Token = "0x6000540")]
	private static bool IsVariable(string token) { }

	[Address(RVA = "0x2FE1660", Offset = "0x2FE0A60", Length = "0xD6")]
	[Token(Token = "0x600053D")]
	private static bool NeedToPop(Stack<String> operatorStack, Operator newOperator) { }

	[Address(RVA = "0x2FE1740", Offset = "0x2FE0B40", Length = "0x1B0")]
	[Token(Token = "0x6000544")]
	private static string PreFormatExpression(string expression) { }

	[Address(RVA = "0x2FE1900", Offset = "0x2FE0D00", Length = "0x99")]
	[Token(Token = "0x6000543")]
	private static Operator TokenToOperator(string token) { }

	[Address(RVA = "0x7ECE10", Offset = "0x7EC210", Length = "0x7DD")]
	[Token(Token = "0x6000547")]
	private static bool TryParse(string expression, out T result) { }

}

