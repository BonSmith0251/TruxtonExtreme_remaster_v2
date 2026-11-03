namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000037")]
public struct half : IEquatable<half>, IFormattable
{
	[Token(Token = "0x40000E3")]
	public static readonly half zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E2")]
	public ushort value; //Field offset: 0x0

	[Token(Token = "0x170005C8")]
	public static float MaxValue
	{
		[Address(RVA = "0x2AF57C0", Offset = "0x2AF4BC0", Length = "0x9")]
		[Token(Token = "0x60015E7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170005CA")]
	public static half MaxValueAsHalf
	{
		[Address(RVA = "0x2AF57B0", Offset = "0x2AF4BB0", Length = "0xF")]
		[Token(Token = "0x60015E9")]
		 get { } //Length: 15
	}

	[Token(Token = "0x170005C9")]
	public static float MinValue
	{
		[Address(RVA = "0x2AF57E0", Offset = "0x2AF4BE0", Length = "0x9")]
		[Token(Token = "0x60015E8")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170005CB")]
	public static half MinValueAsHalf
	{
		[Address(RVA = "0x2AF57D0", Offset = "0x2AF4BD0", Length = "0xF")]
		[Token(Token = "0x60015EA")]
		 get { } //Length: 15
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60015F9")]
	private static half() { }

	[Address(RVA = "0x2AF5770", Offset = "0x2AF4B70", Length = "0x20")]
	[Token(Token = "0x60015ED")]
	public half(double v) { }

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x60015EB")]
	public half(half x) { }

	[Address(RVA = "0x2AF5790", Offset = "0x2AF4B90", Length = "0x1C")]
	[Token(Token = "0x60015EC")]
	public half(float v) { }

	[Address(RVA = "0x2AF5660", Offset = "0x2AF4A60", Length = "0x81")]
	[Token(Token = "0x60015F5")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x60A240", Offset = "0x609640", Length = "0x7")]
	[Token(Token = "0x60015F4")]
	public override bool Equals(half rhs) { }

	[Address(RVA = "0x2AF57C0", Offset = "0x2AF4BC0", Length = "0x9")]
	[Token(Token = "0x60015E7")]
	public static float get_MaxValue() { }

	[Address(RVA = "0x2AF57B0", Offset = "0x2AF4BB0", Length = "0xF")]
	[Token(Token = "0x60015E9")]
	public static half get_MaxValueAsHalf() { }

	[Address(RVA = "0x2AF57E0", Offset = "0x2AF4BE0", Length = "0x9")]
	[Token(Token = "0x60015E8")]
	public static float get_MinValue() { }

	[Address(RVA = "0x2AF57D0", Offset = "0x2AF4BD0", Length = "0xF")]
	[Token(Token = "0x60015EA")]
	public static half get_MinValueAsHalf() { }

	[Address(RVA = "0x646650", Offset = "0x645A50", Length = "0x4")]
	[Token(Token = "0x60015F6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x60A360", Offset = "0x609760", Length = "0x7")]
	[Token(Token = "0x60015F2")]
	public static bool op_Equality(half lhs, half rhs) { }

	[Address(RVA = "0x2A3A5E0", Offset = "0x2A399E0", Length = "0x7")]
	[Token(Token = "0x60015EE")]
	public static half op_Explicit(float v) { }

	[Address(RVA = "0x2A3A5D0", Offset = "0x2A399D0", Length = "0xB")]
	[Token(Token = "0x60015EF")]
	public static half op_Explicit(double v) { }

	[Address(RVA = "0x2AF57F0", Offset = "0x2AF4BF0", Length = "0x63")]
	[Token(Token = "0x60015F1")]
	public static double op_Implicit(half d) { }

	[Address(RVA = "0x2AF5860", Offset = "0x2AF4C60", Length = "0x60")]
	[Token(Token = "0x60015F0")]
	public static float op_Implicit(half d) { }

	[Address(RVA = "0x28A8280", Offset = "0x28A7680", Length = "0x7")]
	[Token(Token = "0x60015F3")]
	public static bool op_Inequality(half lhs, half rhs) { }

	[Address(RVA = "0x2AEF660", Offset = "0x2AEEA60", Length = "0xA26")]
	[Token(Token = "0x60015F8")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AF56F0", Offset = "0x2AF4AF0", Length = "0x75")]
	[Token(Token = "0x60015F7")]
	public virtual string ToString() { }

}

