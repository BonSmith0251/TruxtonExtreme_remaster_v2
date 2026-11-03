namespace System.Globalization;

[Token(Token = "0x2000557")]
internal static class TimeSpanParse
{
	[Token(Token = "0x2000558")]
	private enum ParseFailureKind : byte
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200055D")]
	private struct TimeSpanRawInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160E")]
		internal TTT _lastSeenTTT; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400160F")]
		internal int _tokenCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001610")]
		internal int _sepCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4001611")]
		internal int _numCount; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001612")]
		private FormatLiterals _posLoc; //Field offset: 0x10
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001613")]
		private FormatLiterals _negLoc; //Field offset: 0x38
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001614")]
		private bool _posLocInit; //Field offset: 0x60
		[FieldOffset(Offset = "0x61")]
		[Token(Token = "0x4001615")]
		private bool _negLocInit; //Field offset: 0x61
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001616")]
		private string _fullPosPattern; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4001617")]
		private string _fullNegPattern; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001618")]
		internal TimeSpanToken _numbers0; //Field offset: 0x78
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4001619")]
		internal TimeSpanToken _numbers1; //Field offset: 0x98
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400161A")]
		internal TimeSpanToken _numbers2; //Field offset: 0xB8
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400161B")]
		internal TimeSpanToken _numbers3; //Field offset: 0xD8
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400161C")]
		internal TimeSpanToken _numbers4; //Field offset: 0xF8
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x400161D")]
		internal ReadOnlySpan<Char> _literals0; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x400161E")]
		internal ReadOnlySpan<Char> _literals1; //Field offset: 0x128
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x400161F")]
		internal ReadOnlySpan<Char> _literals2; //Field offset: 0x138
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4001620")]
		internal ReadOnlySpan<Char> _literals3; //Field offset: 0x148
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x4001621")]
		internal ReadOnlySpan<Char> _literals4; //Field offset: 0x158
		[FieldOffset(Offset = "0x168")]
		[Token(Token = "0x4001622")]
		internal ReadOnlySpan<Char> _literals5; //Field offset: 0x168

		[Token(Token = "0x1700057B")]
		internal FormatLiterals NegativeInvariant
		{
			[Address(RVA = "0x1F87000", Offset = "0x1F86400", Length = "0x6D")]
			[Token(Token = "0x60026E7")]
			internal get { } //Length: 109
		}

		[Token(Token = "0x1700057D")]
		internal FormatLiterals NegativeLocalized
		{
			[Address(RVA = "0x1F87070", Offset = "0x1F86470", Length = "0xC6")]
			[Token(Token = "0x60026E9")]
			internal get { } //Length: 198
		}

		[Token(Token = "0x1700057A")]
		internal FormatLiterals PositiveInvariant
		{
			[Address(RVA = "0x1F87140", Offset = "0x1F86540", Length = "0x6C")]
			[Token(Token = "0x60026E6")]
			internal get { } //Length: 108
		}

		[Token(Token = "0x1700057C")]
		internal FormatLiterals PositiveLocalized
		{
			[Address(RVA = "0x1F871B0", Offset = "0x1F865B0", Length = "0xC6")]
			[Token(Token = "0x60026E8")]
			internal get { } //Length: 198
		}

		[Address(RVA = "0x1F85350", Offset = "0x1F84750", Length = "0x14B")]
		[Token(Token = "0x60026F6")]
		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result) { }

		[Address(RVA = "0x1F854A0", Offset = "0x1F848A0", Length = "0x148")]
		[Token(Token = "0x60026F5")]
		private bool AddSep(ReadOnlySpan<Char> sep, ref TimeSpanResult result) { }

		[Address(RVA = "0x1F855F0", Offset = "0x1F849F0", Length = "0x2FE")]
		[Token(Token = "0x60026EA")]
		internal bool FullAppCompatMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F858F0", Offset = "0x1F84CF0", Length = "0x27C")]
		[Token(Token = "0x60026EF")]
		internal bool FullDHMMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F85B70", Offset = "0x1F84F70", Length = "0x302")]
		[Token(Token = "0x60026F1")]
		internal bool FullDHMSMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F85E80", Offset = "0x1F85280", Length = "0x17A")]
		[Token(Token = "0x60026ED")]
		internal bool FullDMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F86000", Offset = "0x1F85400", Length = "0x1F2")]
		[Token(Token = "0x60026EE")]
		internal bool FullHMMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F86200", Offset = "0x1F85600", Length = "0x302")]
		[Token(Token = "0x60026F2")]
		internal bool FullHMSFMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F86510", Offset = "0x1F85910", Length = "0x27C")]
		[Token(Token = "0x60026F0")]
		internal bool FullHMSMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F86790", Offset = "0x1F85B90", Length = "0x388")]
		[Token(Token = "0x60026EC")]
		internal bool FullMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F87000", Offset = "0x1F86400", Length = "0x6D")]
		[Token(Token = "0x60026E7")]
		internal FormatLiterals get_NegativeInvariant() { }

		[Address(RVA = "0x1F87070", Offset = "0x1F86470", Length = "0xC6")]
		[Token(Token = "0x60026E9")]
		internal FormatLiterals get_NegativeLocalized() { }

		[Address(RVA = "0x1F87140", Offset = "0x1F86540", Length = "0x6C")]
		[Token(Token = "0x60026E6")]
		internal FormatLiterals get_PositiveInvariant() { }

		[Address(RVA = "0x1F871B0", Offset = "0x1F865B0", Length = "0xC6")]
		[Token(Token = "0x60026E8")]
		internal FormatLiterals get_PositiveLocalized() { }

		[Address(RVA = "0x1F86B20", Offset = "0x1F85F20", Length = "0x53")]
		[Token(Token = "0x60026F3")]
		internal void Init(DateTimeFormatInfo dtfi) { }

		[Address(RVA = "0x1F86B80", Offset = "0x1F85F80", Length = "0x278")]
		[Token(Token = "0x60026EB")]
		internal bool PartialAppCompatMatch(FormatLiterals pattern) { }

		[Address(RVA = "0x1F86E00", Offset = "0x1F86200", Length = "0x1FD")]
		[Token(Token = "0x60026F4")]
		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result) { }

	}

	[Token(Token = "0x200055E")]
	private struct TimeSpanResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001623")]
		internal TimeSpan parsedTimeSpan; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001624")]
		private readonly bool _throwOnFailure; //Field offset: 0x8

		[Address(RVA = "0x1F873F0", Offset = "0x1F867F0", Length = "0x9")]
		[Token(Token = "0x60026F7")]
		internal TimeSpanResult(bool throwOnFailure) { }

		[Address(RVA = "0x1F87280", Offset = "0x1F86680", Length = "0x162")]
		[Token(Token = "0x60026F8")]
		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null) { }

	}

	[Flags]
	[Token(Token = "0x2000559")]
	private enum TimeSpanStandardStyles : byte
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3,
	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200055B")]
	private struct TimeSpanToken
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001608")]
		internal TTT _ttt; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001609")]
		internal int _num; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400160A")]
		internal int _zeroes; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400160B")]
		internal ReadOnlySpan<Char> _sep; //Field offset: 0x10

		[Address(RVA = "0x1F87460", Offset = "0x1F86860", Length = "0x10")]
		[Token(Token = "0x60026DF")]
		public TimeSpanToken(TTT type) { }

		[Address(RVA = "0x1F87490", Offset = "0x1F86890", Length = "0x15")]
		[Token(Token = "0x60026E0")]
		public TimeSpanToken(int number) { }

		[Address(RVA = "0x1F87470", Offset = "0x1F86870", Length = "0x17")]
		[Token(Token = "0x60026E1")]
		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<Char> separator) { }

		[Address(RVA = "0x1F87400", Offset = "0x1F86800", Length = "0x5F")]
		[Token(Token = "0x60026E2")]
		public bool IsInvalidFraction() { }

	}

	[IsByRefLike]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	[Token(Token = "0x200055C")]
	private struct TimeSpanTokenizer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400160C")]
		private ReadOnlySpan<Char> _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400160D")]
		private int _pos; //Field offset: 0x10

		[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
		[Token(Token = "0x60026E3")]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input) { }

		[Address(RVA = "0xAEE4F0", Offset = "0xAED8F0", Length = "0xB")]
		[Token(Token = "0x60026E4")]
		internal TimeSpanTokenizer(ReadOnlySpan<Char> input, int startPosition) { }

		[Address(RVA = "0x1F874B0", Offset = "0x1F868B0", Length = "0x24B")]
		[Token(Token = "0x60026E5")]
		internal TimeSpanToken GetNextToken() { }

	}

	[Token(Token = "0x200055A")]
	private enum TTT : byte
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4,
	}


	[Address(RVA = "0x1F7FE80", Offset = "0x1F7F280", Length = "0x40")]
	[Token(Token = "0x60026D7")]
	internal static TimeSpan Parse(ReadOnlySpan<Char> input, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1F7FEC0", Offset = "0x1F7F2C0", Length = "0x34")]
	[Token(Token = "0x60026D5")]
	internal static long Pow10(int pow) { }

	[Address(RVA = "0x1F80550", Offset = "0x1F7F950", Length = "0x330")]
	[Token(Token = "0x60026DE")]
	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F80110", Offset = "0x1F7F510", Length = "0x43F")]
	[Token(Token = "0x60026DA")]
	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F83BB0", Offset = "0x1F82FB0", Length = "0x35D")]
	[Token(Token = "0x60026DD")]
	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F82440", Offset = "0x1F81840", Length = "0x176B")]
	[Token(Token = "0x60026DC")]
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F80880", Offset = "0x1F7FC80", Length = "0x1BBB")]
	[Token(Token = "0x60026DB")]
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F7FFB0", Offset = "0x1F7F3B0", Length = "0x15F")]
	[Token(Token = "0x60026D9")]
	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F83F10", Offset = "0x1F83310", Length = "0x1272")]
	[Token(Token = "0x60026D8")]
	private static bool TryParseTimeSpan(ReadOnlySpan<Char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result) { }

	[Address(RVA = "0x1F85190", Offset = "0x1F84590", Length = "0x1C0")]
	[Token(Token = "0x60026D6")]
	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result) { }

}

