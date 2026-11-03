namespace Unity.IntegerTime;

[Token(Token = "0x200001F")]
public struct DiscreteTime : IEquatable<DiscreteTime>, IFormattable, IComparable<DiscreteTime>
{
	[Token(Token = "0x400001F")]
	public static readonly DiscreteTime Zero; //Field offset: 0x0
	[Token(Token = "0x4000020")]
	public static readonly DiscreteTime MinValue; //Field offset: 0x8
	[Token(Token = "0x4000021")]
	public static readonly DiscreteTime MaxValue; //Field offset: 0x10
	[Token(Token = "0x4000022")]
	private static readonly int TicksPerSecondBits; //Field offset: 0x18
	[Token(Token = "0x4000023")]
	private static readonly int NonPow2TpsBits; //Field offset: 0x1C
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	public long Value; //Field offset: 0x0

	[Address(RVA = "0x2FDFDC0", Offset = "0x2FDF1C0", Length = "0x13F")]
	[Token(Token = "0x6000060")]
	private static DiscreteTime() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000051")]
	private DiscreteTime(long v, int _) { }

	[Address(RVA = "0x2FDFF70", Offset = "0x2FDF370", Length = "0x69")]
	[Token(Token = "0x600004F")]
	public DiscreteTime(float v) { }

	[Address(RVA = "0x2FDFF00", Offset = "0x2FDF300", Length = "0x65")]
	[Token(Token = "0x6000050")]
	public DiscreteTime(double v) { }

	[Address(RVA = "0x2FDFC10", Offset = "0x2FDF010", Length = "0xA")]
	[IsReadOnly]
	[Token(Token = "0x600005F")]
	public override int CompareTo(DiscreteTime other) { }

	[Address(RVA = "0xFD2260", Offset = "0xFD1660", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x600005A")]
	public override bool Equals(DiscreteTime rhs) { }

	[Address(RVA = "0x2FDFC20", Offset = "0x2FDF020", Length = "0x84")]
	[IsReadOnly]
	[Token(Token = "0x600005B")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6000052")]
	public static DiscreteTime FromTicks(long v) { }

	[Address(RVA = "0x2FDFCB0", Offset = "0x2FDF0B0", Length = "0x9")]
	[IsReadOnly]
	[Token(Token = "0x600005C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FDFFE0", Offset = "0x2FDF3E0", Length = "0x50")]
	[Token(Token = "0x6000058")]
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2FE0050", Offset = "0x2FDF450", Length = "0x17")]
	[Token(Token = "0x6000053")]
	public static float op_Explicit(DiscreteTime d) { }

	[Address(RVA = "0x2FE0030", Offset = "0x2FDF430", Length = "0x13")]
	[Token(Token = "0x6000054")]
	public static double op_Explicit(DiscreteTime d) { }

	[Address(RVA = "0x2FE0080", Offset = "0x2FDF480", Length = "0x9")]
	[Token(Token = "0x6000056")]
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2FE0070", Offset = "0x2FDF470", Length = "0x9")]
	[Token(Token = "0x6000057")]
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2FE0090", Offset = "0x2FDF490", Length = "0x9")]
	[Token(Token = "0x6000055")]
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2FE00A0", Offset = "0x2FDF4A0", Length = "0x52")]
	[Token(Token = "0x6000059")]
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	[Address(RVA = "0x2FDFD50", Offset = "0x2FDF150", Length = "0x6E")]
	[IsReadOnly]
	[Token(Token = "0x600005D")]
	public virtual string ToString() { }

	[Address(RVA = "0x2FDFCC0", Offset = "0x2FDF0C0", Length = "0x8E")]
	[IsReadOnly]
	[Token(Token = "0x600005E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

