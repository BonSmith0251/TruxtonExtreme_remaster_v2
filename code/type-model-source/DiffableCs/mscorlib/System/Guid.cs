namespace System;

[NonVersionable]
[Token(Token = "0x20000EA")]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
{
	[Token(Token = "0x20000EC")]
	private enum GuidParseThrowStyle : int
	{
		None = 0,
		All = 1,
		AllButOverflow = 2,
	}

	[Token(Token = "0x20000EE")]
	private struct GuidResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003DF")]
		internal Guid _parsedGuid; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E0")]
		internal GuidParseThrowStyle _throwStyle; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40003E1")]
		private ParseFailureKind _failure; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E2")]
		private string _failureMessageID; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40003E3")]
		private object _failureMessageFormatArgument; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40003E4")]
		private string _failureArgumentName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003E5")]
		private Exception _innerException; //Field offset: 0x30

		[Address(RVA = "0x2021AC0", Offset = "0x2020EC0", Length = "0x19B")]
		[Token(Token = "0x600077E")]
		internal Exception GetGuidParseException() { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000779")]
		internal void Init(GuidParseThrowStyle canThrow) { }

		[Address(RVA = "0x2021D80", Offset = "0x2021180", Length = "0x14")]
		[Token(Token = "0x600077A")]
		internal void SetFailure(Exception nativeException) { }

		[Address(RVA = "0x2021DA0", Offset = "0x20211A0", Length = "0x85")]
		[Token(Token = "0x600077B")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		[Address(RVA = "0x2021CF0", Offset = "0x20210F0", Length = "0x87")]
		[Token(Token = "0x600077C")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		[Address(RVA = "0x2021C60", Offset = "0x2021060", Length = "0x8C")]
		[Token(Token = "0x600077D")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	}

	[Flags]
	[Token(Token = "0x20000EB")]
	private enum GuidStyles : int
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 16,
		RequireBraces = 32,
		RequireDashes = 64,
		RequireHexPrefix = 128,
		HexFormat = 160,
		NumberFormat = 0,
		DigitFormat = 64,
		BraceFormat = 96,
		ParenthesisFormat = 80,
		Any = 15,
	}

	[Token(Token = "0x20000ED")]
	private enum ParseFailureKind : int
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5,
	}

	[Token(Token = "0x40003B8")]
	public static readonly Guid Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003B9")]
	private int _a; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40003BA")]
	private short _b; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x40003BB")]
	private short _c; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003BC")]
	private byte _d; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x40003BD")]
	private byte _e; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40003BE")]
	private byte _f; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x40003BF")]
	private byte _g; //Field offset: 0xB
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40003C0")]
	private byte _h; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40003C1")]
	private byte _i; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40003C2")]
	private byte _j; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x40003C3")]
	private byte _k; //Field offset: 0xF

	[Address(RVA = "0x2025410", Offset = "0x2024810", Length = "0xB7")]
	[Token(Token = "0x6000752")]
	public Guid(Byte[] b) { }

	[Address(RVA = "0x2025240", Offset = "0x2024640", Length = "0x1C3")]
	[Token(Token = "0x6000753")]
	public Guid(ReadOnlySpan<Byte> b) { }

	[Address(RVA = "0x20255F0", Offset = "0x20249F0", Length = "0x4D")]
	[Token(Token = "0x6000754")]
	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	[Address(RVA = "0x20254D0", Offset = "0x20248D0", Length = "0x11E")]
	[Token(Token = "0x6000755")]
	public Guid(string g) { }

	[Address(RVA = "0x2022100", Offset = "0x2021500", Length = "0x19A")]
	[Token(Token = "0x600076F")]
	public override int CompareTo(Guid value) { }

	[Address(RVA = "0x2021E30", Offset = "0x2021230", Length = "0x2C0")]
	[Token(Token = "0x600076E")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x20222A0", Offset = "0x20216A0", Length = "0x289")]
	[Token(Token = "0x6000765")]
	private static ReadOnlySpan<Char> EatAllWhitespace(ReadOnlySpan<Char> str) { }

	[Address(RVA = "0x2022560", Offset = "0x2021960", Length = "0xA6")]
	[Token(Token = "0x600076B")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2022530", Offset = "0x2021930", Length = "0x23")]
	[Token(Token = "0x600076C")]
	public override bool Equals(Guid g) { }

	[Address(RVA = "0x2022610", Offset = "0x2021A10", Length = "0xC")]
	[Token(Token = "0x600076A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2022620", Offset = "0x2021A20", Length = "0x11")]
	[Token(Token = "0x600076D")]
	private int GetResult(uint me, uint them) { }

	[Address(RVA = "0x2022700", Offset = "0x2021B00", Length = "0x80")]
	[Token(Token = "0x6000774")]
	private static int HexsToChars(Char* guidChars, int a, int b) { }

	[Address(RVA = "0x2022660", Offset = "0x2021A60", Length = "0xA0")]
	[Token(Token = "0x6000775")]
	private static int HexsToCharsHexOutput(Char* guidChars, int a, int b) { }

	[Address(RVA = "0x2022640", Offset = "0x2021A40", Length = "0x18")]
	[Token(Token = "0x6000773")]
	private static char HexToChar(int a) { }

	[Address(RVA = "0x2022780", Offset = "0x2021B80", Length = "0xAB")]
	[Token(Token = "0x6000766")]
	private static bool IsHexPrefix(ReadOnlySpan<Char> str, int i) { }

	[Address(RVA = "0x2022830", Offset = "0x2021C30", Length = "0x44")]
	[Token(Token = "0x6000751")]
	public static Guid NewGuid() { }

	[Address(RVA = "0x2025640", Offset = "0x2024A40", Length = "0x23")]
	[Token(Token = "0x6000770")]
	public static bool op_Equality(Guid a, Guid b) { }

	[Address(RVA = "0x2025670", Offset = "0x2024A70", Length = "0x23")]
	[Token(Token = "0x6000771")]
	public static bool op_Inequality(Guid a, Guid b) { }

	[Address(RVA = "0x2022880", Offset = "0x2021C80", Length = "0x84")]
	[Token(Token = "0x6000757")]
	public static Guid Parse(ReadOnlySpan<Char> input) { }

	[Address(RVA = "0x2022910", Offset = "0x2021D10", Length = "0x122")]
	[Token(Token = "0x6000756")]
	public static Guid Parse(string input) { }

	[Address(RVA = "0x2022A40", Offset = "0x2021E40", Length = "0x43")]
	[Token(Token = "0x6000762")]
	private static bool StringToInt(ReadOnlySpan<Char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[Address(RVA = "0x2022A90", Offset = "0x2021E90", Length = "0x188")]
	[Token(Token = "0x6000763")]
	private static bool StringToInt(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[Address(RVA = "0x2022C20", Offset = "0x2022020", Length = "0xFF")]
	[Token(Token = "0x6000764")]
	private static bool StringToLong(ReadOnlySpan<Char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) { }

	[Address(RVA = "0x2022D80", Offset = "0x2022180", Length = "0x5E")]
	[Token(Token = "0x6000760")]
	private static bool StringToShort(ReadOnlySpan<Char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[Address(RVA = "0x2022D20", Offset = "0x2022120", Length = "0x53")]
	[Token(Token = "0x6000761")]
	private static bool StringToShort(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[Address(RVA = "0x2022DE0", Offset = "0x20221E0", Length = "0x32")]
	[Token(Token = "0x6000778")]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x2022E20", Offset = "0x2022220", Length = "0x86")]
	[Token(Token = "0x6000768")]
	public Byte[] ToByteArray() { }

	[Address(RVA = "0x2022EB0", Offset = "0x20222B0", Length = "0x3F")]
	[Token(Token = "0x6000769")]
	public virtual string ToString() { }

	[Address(RVA = "0x2023160", Offset = "0x2022560", Length = "0xB")]
	[Token(Token = "0x6000772")]
	public string ToString(string format) { }

	[Address(RVA = "0x2022EF0", Offset = "0x20222F0", Length = "0x260")]
	[Token(Token = "0x6000776")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x2023170", Offset = "0x2022570", Length = "0xA54")]
	[Token(Token = "0x6000777")]
	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null) { }

	[Address(RVA = "0x20251D0", Offset = "0x20245D0", Length = "0x61")]
	[Token(Token = "0x6000759")]
	public static bool TryParse(ReadOnlySpan<Char> input, out Guid result) { }

	[Address(RVA = "0x20250F0", Offset = "0x20244F0", Length = "0xD4")]
	[Token(Token = "0x6000758")]
	public static bool TryParse(string input, out Guid result) { }

	[Address(RVA = "0x2023DC0", Offset = "0x20231C0", Length = "0x11E")]
	[Token(Token = "0x600075B")]
	public static bool TryParseExact(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, out Guid result) { }

	[Address(RVA = "0x2023BD0", Offset = "0x2022FD0", Length = "0x1E0")]
	[Token(Token = "0x600075A")]
	public static bool TryParseExact(string input, string format, out Guid result) { }

	[Address(RVA = "0x2024F20", Offset = "0x2024320", Length = "0x1CB")]
	[Token(Token = "0x600075C")]
	private static bool TryParseGuid(ReadOnlySpan<Char> guidString, GuidStyles flags, ref GuidResult result) { }

	[Address(RVA = "0x2023EE0", Offset = "0x20232E0", Length = "0x348")]
	[Token(Token = "0x600075F")]
	private static bool TryParseGuidWithDashes(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x2024230", Offset = "0x2023630", Length = "0x8A6")]
	[Token(Token = "0x600075D")]
	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x2024AE0", Offset = "0x2023EE0", Length = "0x436")]
	[Token(Token = "0x600075E")]
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[Address(RVA = "0x20214D0", Offset = "0x20208D0", Length = "0x3D5")]
	[Token(Token = "0x6000767")]
	private void WriteByteHelper(Span<Byte> destination) { }

}

