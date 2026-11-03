namespace System.Globalization;

[Token(Token = "0x2000554")]
internal static class TimeSpanFormat
{
	[Token(Token = "0x2000556")]
	public struct FormatLiterals
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40015EF")]
		internal string AppCompatLiteral; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40015F0")]
		internal int dd; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40015F1")]
		internal int hh; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40015F2")]
		internal int mm; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40015F3")]
		internal int ss; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40015F4")]
		internal int ff; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40015F5")]
		private String[] _literals; //Field offset: 0x20

		[Token(Token = "0x17000575")]
		internal string DayHourSep
		{
			[Address(RVA = "0x1F73F30", Offset = "0x1F73330", Length = "0x27")]
			[Token(Token = "0x60026CE")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000579")]
		internal string End
		{
			[Address(RVA = "0x1F73F60", Offset = "0x1F73360", Length = "0x27")]
			[Token(Token = "0x60026D2")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000576")]
		internal string HourMinuteSep
		{
			[Address(RVA = "0x1F73F90", Offset = "0x1F73390", Length = "0x27")]
			[Token(Token = "0x60026CF")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000577")]
		internal string MinuteSecondSep
		{
			[Address(RVA = "0x1F73FC0", Offset = "0x1F733C0", Length = "0x27")]
			[Token(Token = "0x60026D0")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000578")]
		internal string SecondFractionSep
		{
			[Address(RVA = "0x1F73FF0", Offset = "0x1F733F0", Length = "0x27")]
			[Token(Token = "0x60026D1")]
			internal get { } //Length: 39
		}

		[Token(Token = "0x17000574")]
		internal string Start
		{
			[Address(RVA = "0x1F74020", Offset = "0x1F73420", Length = "0x27")]
			[Token(Token = "0x60026CD")]
			internal get { } //Length: 39
		}

		[Address(RVA = "0x1F73F30", Offset = "0x1F73330", Length = "0x27")]
		[Token(Token = "0x60026CE")]
		internal string get_DayHourSep() { }

		[Address(RVA = "0x1F73F60", Offset = "0x1F73360", Length = "0x27")]
		[Token(Token = "0x60026D2")]
		internal string get_End() { }

		[Address(RVA = "0x1F73F90", Offset = "0x1F73390", Length = "0x27")]
		[Token(Token = "0x60026CF")]
		internal string get_HourMinuteSep() { }

		[Address(RVA = "0x1F73FC0", Offset = "0x1F733C0", Length = "0x27")]
		[Token(Token = "0x60026D0")]
		internal string get_MinuteSecondSep() { }

		[Address(RVA = "0x1F73FF0", Offset = "0x1F733F0", Length = "0x27")]
		[Token(Token = "0x60026D1")]
		internal string get_SecondFractionSep() { }

		[Address(RVA = "0x1F74020", Offset = "0x1F73420", Length = "0x27")]
		[Token(Token = "0x60026CD")]
		internal string get_Start() { }

		[Address(RVA = "0x1F73B60", Offset = "0x1F72F60", Length = "0x3CD")]
		[Token(Token = "0x60026D4")]
		internal void Init(ReadOnlySpan<Char> format, bool useInvariantFieldLengths) { }

		[Address(RVA = "0x1F73910", Offset = "0x1F72D10", Length = "0x247")]
		[Token(Token = "0x60026D3")]
		internal static FormatLiterals InitInvariant(bool isNegative) { }

	}

	[Token(Token = "0x2000555")]
	public enum Pattern : int
	{
		None = 0,
		Minimum = 1,
		Full = 2,
	}

	[Token(Token = "0x40015E9")]
	internal static readonly FormatLiterals PositiveInvariantFormatLiterals; //Field offset: 0x0
	[Token(Token = "0x40015EA")]
	internal static readonly FormatLiterals NegativeInvariantFormatLiterals; //Field offset: 0x28

	[Address(RVA = "0x1F7FDC0", Offset = "0x1F7F1C0", Length = "0xBD")]
	[Token(Token = "0x60026CC")]
	private static TimeSpanFormat() { }

	[Address(RVA = "0x1F7EAA0", Offset = "0x1F7DEA0", Length = "0xEA")]
	[Token(Token = "0x60026C6")]
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	[Address(RVA = "0x1F7FBE0", Offset = "0x1F7EFE0", Length = "0xCE")]
	[Token(Token = "0x60026C7")]
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1F7EB90", Offset = "0x1F7DF90", Length = "0x7D7")]
	[Token(Token = "0x60026CB")]
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<Char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	[Address(RVA = "0x1F7F370", Offset = "0x1F7E770", Length = "0x565")]
	[Token(Token = "0x60026CA")]
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<Char> format, Pattern pattern) { }

	[Address(RVA = "0x1F7F8E0", Offset = "0x1F7ECE0", Length = "0x2FD")]
	[Token(Token = "0x60026C9")]
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1F7FCB0", Offset = "0x1F7F0B0", Length = "0x100")]
	[Token(Token = "0x60026C8")]
	internal static bool TryFormat(TimeSpan value, Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider formatProvider) { }

}

