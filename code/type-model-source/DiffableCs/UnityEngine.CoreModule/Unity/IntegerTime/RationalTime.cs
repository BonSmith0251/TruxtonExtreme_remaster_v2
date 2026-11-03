namespace Unity.IntegerTime;

[NativeHeader("Runtime/Input/RationalTime.h")]
[Token(Token = "0x2000020")]
public struct RationalTime
{
	[Token(Token = "0x2000021")]
	internal struct TicksPerSecond : IEquatable<TicksPerSecond>
	{
		[Token(Token = "0x4000028")]
		public static readonly TicksPerSecond DefaultTicksPerSecond; //Field offset: 0x0
		[Token(Token = "0x4000029")]
		public static readonly TicksPerSecond TicksPerSecond24; //Field offset: 0x8
		[Token(Token = "0x400002A")]
		public static readonly TicksPerSecond TicksPerSecond25; //Field offset: 0x10
		[Token(Token = "0x400002B")]
		public static readonly TicksPerSecond TicksPerSecond30; //Field offset: 0x18
		[Token(Token = "0x400002C")]
		public static readonly TicksPerSecond TicksPerSecond50; //Field offset: 0x20
		[Token(Token = "0x400002D")]
		public static readonly TicksPerSecond TicksPerSecond60; //Field offset: 0x28
		[Token(Token = "0x400002E")]
		public static readonly TicksPerSecond TicksPerSecond120; //Field offset: 0x30
		[Token(Token = "0x400002F")]
		public static readonly TicksPerSecond TicksPerSecond2397; //Field offset: 0x38
		[Token(Token = "0x4000030")]
		public static readonly TicksPerSecond TicksPerSecond2425; //Field offset: 0x40
		[Token(Token = "0x4000031")]
		public static readonly TicksPerSecond TicksPerSecond2997; //Field offset: 0x48
		[Token(Token = "0x4000032")]
		public static readonly TicksPerSecond TicksPerSecond5994; //Field offset: 0x50
		[Token(Token = "0x4000033")]
		public static readonly TicksPerSecond TicksPerSecond11988; //Field offset: 0x58
		[Token(Token = "0x4000034")]
		internal static readonly TicksPerSecond DiscreteTimeRate; //Field offset: 0x60
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000026")]
		private uint m_Numerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x4000027")]
		private uint m_Denominator; //Field offset: 0x4

		[Address(RVA = "0x2FEFCE0", Offset = "0x2FEF0E0", Length = "0x2B2")]
		[Token(Token = "0x6000069")]
		private static TicksPerSecond() { }

		[Address(RVA = "0x2FEFFA0", Offset = "0x2FEF3A0", Length = "0xCE")]
		[Token(Token = "0x6000063")]
		public TicksPerSecond(uint num, uint den = 1) { }

		[Address(RVA = "0x2FEFAC0", Offset = "0x2FEEEC0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x6000064")]
		public override bool Equals(TicksPerSecond rhs) { }

		[Address(RVA = "0x2FEFAE0", Offset = "0x2FEEEE0", Length = "0xA6")]
		[IsReadOnly]
		[Token(Token = "0x6000065")]
		public virtual bool Equals(object rhs) { }

		[Address(RVA = "0x2FEFB90", Offset = "0x2FEEF90", Length = "0x2F")]
		[Token(Token = "0x6000068")]
		private static uint Gcd(uint a, uint b) { }

		[Address(RVA = "0x2FEFBC0", Offset = "0x2FEEFC0", Length = "0x69")]
		[IsReadOnly]
		[Token(Token = "0x6000066")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2FEFC30", Offset = "0x2FEF030", Length = "0xA2")]
		[Token(Token = "0x6000067")]
		private static void Simplify(ref uint num, ref uint den) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private long m_Count; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private TicksPerSecond m_TicksPerSecond; //Field offset: 0x8

	[Token(Token = "0x17000007")]
	public long Count
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000061")]
	public long get_Count() { }

	[Address(RVA = "0x2FE5570", Offset = "0x2FE4970", Length = "0xC0")]
	[Token(Token = "0x6000062")]
	public static DiscreteTime op_Explicit(RationalTime t) { }

}

