namespace System;

[Token(Token = "0x20001C9")]
internal static class ParameterizedStrings
{
	[Token(Token = "0x20001CA")]
	internal struct FormatParam
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000751")]
		private readonly int _int32; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000752")]
		private readonly string _string; //Field offset: 0x8

		[Token(Token = "0x1700016C")]
		public int Int32
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x600106F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700016E")]
		public object Object
		{
			[Address(RVA = "0x2081880", Offset = "0x2080C80", Length = "0x29")]
			[Token(Token = "0x6001071")]
			 get { } //Length: 41
		}

		[Token(Token = "0x1700016D")]
		public string String
		{
			[Address(RVA = "0x20818B0", Offset = "0x2080CB0", Length = "0x1B")]
			[Token(Token = "0x6001070")]
			 get { } //Length: 27
		}

		[Address(RVA = "0x2081860", Offset = "0x2080C60", Length = "0x15")]
		[Token(Token = "0x600106C")]
		public FormatParam(int value) { }

		[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
		[Token(Token = "0x600106D")]
		private FormatParam(int intValue, string stringValue) { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600106F")]
		public int get_Int32() { }

		[Address(RVA = "0x2081880", Offset = "0x2080C80", Length = "0x29")]
		[Token(Token = "0x6001071")]
		public object get_Object() { }

		[Address(RVA = "0x20818B0", Offset = "0x2080CB0", Length = "0x1B")]
		[Token(Token = "0x6001070")]
		public string get_String() { }

		[Address(RVA = "0x20818D0", Offset = "0x2080CD0", Length = "0x28")]
		[Token(Token = "0x600106E")]
		public static FormatParam op_Implicit(int value) { }

	}

	[Token(Token = "0x20001CB")]
	private sealed class LowLevelStack
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000753")]
		private FormatParam[] _arr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000754")]
		private int _count; //Field offset: 0x18

		[Address(RVA = "0x2081E00", Offset = "0x2081200", Length = "0x4B")]
		[Token(Token = "0x6001072")]
		public LowLevelStack() { }

		[Address(RVA = "0x2081C10", Offset = "0x2081010", Length = "0x28")]
		[Token(Token = "0x6001075")]
		public void Clear() { }

		[Address(RVA = "0x2081C40", Offset = "0x2081040", Length = "0xC1")]
		[Token(Token = "0x6001073")]
		public FormatParam Pop() { }

		[Address(RVA = "0x2081D10", Offset = "0x2081110", Length = "0xE9")]
		[Token(Token = "0x6001074")]
		public void Push(FormatParam item) { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000750")]
	private static LowLevelStack _cachedStack; //Field offset: 0x80000000

	[Address(RVA = "0x1F95350", Offset = "0x1F94750", Length = "0x6")]
	[Token(Token = "0x6001065")]
	private static bool AsBool(int i) { }

	[Address(RVA = "0x1F96CB0", Offset = "0x1F960B0", Length = "0x8")]
	[Token(Token = "0x6001066")]
	private static int AsInt(bool b) { }

	[Address(RVA = "0x20875B0", Offset = "0x20869B0", Length = "0x1DB")]
	[Token(Token = "0x6001063")]
	public static string Evaluate(string format, FormatParam[] args) { }

	[Address(RVA = "0x2086920", Offset = "0x2085D20", Length = "0xB88")]
	[Token(Token = "0x6001064")]
	private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) { }

	[Address(RVA = "0x2087790", Offset = "0x2086B90", Length = "0x2A0")]
	[Token(Token = "0x600106A")]
	private static string FormatPrintF(string format, object arg) { }

	[Address(RVA = "0x2087A40", Offset = "0x2086E40", Length = "0x107")]
	[Token(Token = "0x600106B")]
	private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) { }

	[Address(RVA = "0x2087C30", Offset = "0x2087030", Length = "0xDD")]
	[Token(Token = "0x6001068")]
	private static int snprintf(Byte* str, IntPtr size, string format, string arg1) { }

	[Address(RVA = "0x2087D10", Offset = "0x2087110", Length = "0xBF")]
	[Token(Token = "0x6001069")]
	private static int snprintf(Byte* str, IntPtr size, string format, int arg1) { }

	[Address(RVA = "0x2087B50", Offset = "0x2086F50", Length = "0xD8")]
	[Token(Token = "0x6001067")]
	private static string StringFromAsciiBytes(Byte[] buffer, int offset, int length) { }

}

