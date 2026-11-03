namespace System.Data;

[Token(Token = "0x200000C")]
internal sealed class AutoIncrementBigInteger : AutoIncrementValue
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	private BigInteger _current; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000031")]
	private long _seed; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000032")]
	private BigInteger _step; //Field offset: 0x30

	[Token(Token = "0x17000034")]
	internal virtual object Current
	{
		[Address(RVA = "0x22ECE30", Offset = "0x22EC230", Length = "0x45")]
		[Token(Token = "0x6000096")]
		internal get { } //Length: 69
		[Address(RVA = "0x22ECF30", Offset = "0x22EC330", Length = "0x77")]
		[Token(Token = "0x6000097")]
		internal set { } //Length: 119
	}

	[Token(Token = "0x17000035")]
	internal virtual Type DataType
	{
		[Address(RVA = "0x22ECE80", Offset = "0x22EC280", Length = "0x4D")]
		[Token(Token = "0x6000098")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000036")]
	internal virtual long Seed
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000099")]
		internal get { } //Length: 5
		[Address(RVA = "0x22ECFB0", Offset = "0x22EC3B0", Length = "0xFE")]
		[Token(Token = "0x600009A")]
		internal set { } //Length: 254
	}

	[Token(Token = "0x17000037")]
	internal virtual long Step
	{
		[Address(RVA = "0x22ECED0", Offset = "0x22EC2D0", Length = "0x60")]
		[Token(Token = "0x600009B")]
		internal get { } //Length: 96
		[Address(RVA = "0x22ED0B0", Offset = "0x22EC4B0", Length = "0x1D0")]
		[Token(Token = "0x600009C")]
		internal set { } //Length: 464
	}

	[Address(RVA = "0x22ECDC0", Offset = "0x22EC1C0", Length = "0x6D")]
	[Token(Token = "0x60000A1")]
	public AutoIncrementBigInteger() { }

	[Address(RVA = "0x22ECAD0", Offset = "0x22EBED0", Length = "0x13D")]
	[Token(Token = "0x60000A0")]
	private bool BoundaryCheck(BigInteger value) { }

	[Address(RVA = "0x22ECE30", Offset = "0x22EC230", Length = "0x45")]
	[Token(Token = "0x6000096")]
	internal virtual object get_Current() { }

	[Address(RVA = "0x22ECE80", Offset = "0x22EC280", Length = "0x4D")]
	[Token(Token = "0x6000098")]
	internal virtual Type get_DataType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000099")]
	internal virtual long get_Seed() { }

	[Address(RVA = "0x22ECED0", Offset = "0x22EC2D0", Length = "0x60")]
	[Token(Token = "0x600009B")]
	internal virtual long get_Step() { }

	[Address(RVA = "0x22ECC10", Offset = "0x22EC010", Length = "0x90")]
	[Token(Token = "0x600009D")]
	internal virtual void MoveAfter() { }

	[Address(RVA = "0x22ECF30", Offset = "0x22EC330", Length = "0x77")]
	[Token(Token = "0x6000097")]
	internal virtual void set_Current(object value) { }

	[Address(RVA = "0x22ECFB0", Offset = "0x22EC3B0", Length = "0xFE")]
	[Token(Token = "0x600009A")]
	internal virtual void set_Seed(long value) { }

	[Address(RVA = "0x22ED0B0", Offset = "0x22EC4B0", Length = "0x1D0")]
	[Token(Token = "0x600009C")]
	internal virtual void set_Step(long value) { }

	[Address(RVA = "0x22ECD90", Offset = "0x22EC190", Length = "0x2D")]
	[Token(Token = "0x600009E")]
	internal virtual void SetCurrent(object value, IFormatProvider formatProvider) { }

	[Address(RVA = "0x22ECCA0", Offset = "0x22EC0A0", Length = "0xEF")]
	[Token(Token = "0x600009F")]
	internal virtual void SetCurrentAndIncrement(object value) { }

}

