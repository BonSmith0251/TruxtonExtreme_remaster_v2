namespace System;

[Token(Token = "0x200015A")]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A1")]
	private readonly int _Major; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004A2")]
	private readonly int _Minor; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A3")]
	private readonly int _Build; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004A4")]
	private readonly int _Revision; //Field offset: 0x1C

	[Token(Token = "0x170000FE")]
	public int Build
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000100")]
	private int DefaultFormatFieldCount
	{
		[Address(RVA = "0x2059050", Offset = "0x2058450", Length = "0x19")]
		[Token(Token = "0x6000C46")]
		private get { } //Length: 25
	}

	[Token(Token = "0x170000FC")]
	public int Major
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000C38")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000FD")]
	public int Minor
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000C39")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000FF")]
	public int Revision
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000C3B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2058DF0", Offset = "0x20581F0", Length = "0x1D6")]
	[Token(Token = "0x6000C31")]
	public Version(int major, int minor, int build, int revision) { }

	[Address(RVA = "0x2058C80", Offset = "0x2058080", Length = "0x16C")]
	[Token(Token = "0x6000C32")]
	public Version(int major, int minor, int build) { }

	[Address(RVA = "0x2058A90", Offset = "0x2057E90", Length = "0xF9")]
	[Token(Token = "0x6000C33")]
	public Version(int major, int minor) { }

	[Address(RVA = "0x2058B90", Offset = "0x2057F90", Length = "0xEE")]
	[Token(Token = "0x6000C34")]
	public Version(string version) { }

	[Address(RVA = "0x2059020", Offset = "0x2058420", Length = "0x24")]
	[Token(Token = "0x6000C35")]
	public Version() { }

	[Address(RVA = "0x2058FD0", Offset = "0x20583D0", Length = "0x4C")]
	[Token(Token = "0x6000C36")]
	private Version(Version version) { }

	[Address(RVA = "0x2057540", Offset = "0x2056940", Length = "0x7A")]
	[Token(Token = "0x6000C37")]
	public override object Clone() { }

	[Address(RVA = "0x20576B0", Offset = "0x2056AB0", Length = "0x58")]
	[Token(Token = "0x6000C3D")]
	public override int CompareTo(Version value) { }

	[Address(RVA = "0x20575C0", Offset = "0x20569C0", Length = "0xE1")]
	[Token(Token = "0x6000C3C")]
	public override int CompareTo(object version) { }

	[Address(RVA = "0x2057750", Offset = "0x2056B50", Length = "0x91")]
	[Token(Token = "0x6000C3E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2057710", Offset = "0x2056B10", Length = "0x32")]
	[Token(Token = "0x6000C3F")]
	public override bool Equals(Version obj) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C3A")]
	public int get_Build() { }

	[Address(RVA = "0x2059050", Offset = "0x2058450", Length = "0x19")]
	[Token(Token = "0x6000C46")]
	private int get_DefaultFormatFieldCount() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000C38")]
	public int get_Major() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000C39")]
	public int get_Minor() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000C3B")]
	public int get_Revision() { }

	[Address(RVA = "0x20577F0", Offset = "0x2056BF0", Length = "0x24")]
	[Token(Token = "0x6000C40")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2059070", Offset = "0x2058470", Length = "0x3E")]
	[Token(Token = "0x6000C4C")]
	public static bool op_Equality(Version v1, Version v2) { }

	[Address(RVA = "0x20590B0", Offset = "0x20584B0", Length = "0x4E")]
	[Token(Token = "0x6000C4D")]
	public static bool op_Inequality(Version v1, Version v2) { }

	[Address(RVA = "0x2059100", Offset = "0x2058500", Length = "0x94")]
	[Token(Token = "0x6000C4E")]
	public static bool op_LessThan(Version v1, Version v2) { }

	[Address(RVA = "0x2058230", Offset = "0x2057630", Length = "0xB0")]
	[Token(Token = "0x6000C48")]
	public static Version Parse(string input) { }

	[Address(RVA = "0x2057820", Offset = "0x2056C20", Length = "0xA09")]
	[Token(Token = "0x6000C4A")]
	private static Version ParseVersion(ReadOnlySpan<Char> input, bool throwOnFailure) { }

	[Address(RVA = "0x20582F0", Offset = "0x20576F0", Length = "0xFB")]
	[Token(Token = "0x6000C45")]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[Address(RVA = "0x20583F0", Offset = "0x20577F0", Length = "0x306")]
	[Token(Token = "0x6000C47")]
	private StringBuilder ToCachedStringBuilder(int fieldCount) { }

	[Address(RVA = "0x2058700", Offset = "0x2057B00", Length = "0x48")]
	[Token(Token = "0x6000C42")]
	public string ToString(int fieldCount) { }

	[Address(RVA = "0x2058750", Offset = "0x2057B50", Length = "0x33")]
	[Token(Token = "0x6000C41")]
	public virtual string ToString() { }

	[Address(RVA = "0x20582F0", Offset = "0x20576F0", Length = "0xFB")]
	[Token(Token = "0x6000C43")]
	public bool TryFormat(Span<Char> destination, out int charsWritten) { }

	[Address(RVA = "0x2058790", Offset = "0x2057B90", Length = "0x114")]
	[Token(Token = "0x6000C44")]
	public bool TryFormat(Span<Char> destination, int fieldCount, out int charsWritten) { }

	[Address(RVA = "0x20589E0", Offset = "0x2057DE0", Length = "0xA9")]
	[Token(Token = "0x6000C49")]
	public static bool TryParse(string input, out Version result) { }

	[Address(RVA = "0x20588B0", Offset = "0x2057CB0", Length = "0x12D")]
	[Token(Token = "0x6000C4B")]
	private static bool TryParseComponent(ReadOnlySpan<Char> component, string componentName, bool throwOnFailure, out int parsedComponent) { }

}

