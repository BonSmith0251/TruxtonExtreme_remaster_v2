namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001B2")]
public struct BitArray64 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400085B")]
	private ulong data; //Field offset: 0x0

	[Token(Token = "0x170001B1")]
	public override bool allFalse
	{
		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x6000D0A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B2")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3C440", Offset = "0x2C3B840", Length = "0x8")]
		[Token(Token = "0x6000D0B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001B0")]
	public override uint capacity
	{
		[Address(RVA = "0x9DCC30", Offset = "0x9DC030", Length = "0x6")]
		[Token(Token = "0x6000D09")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001B3")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3C450", Offset = "0x2C3B850", Length = "0x13C")]
		[Token(Token = "0x6000D0C")]
		 get { } //Length: 316
	}

	[Token(Token = "0x170001B4")]
	public override bool Item
	{
		[Address(RVA = "0x2C3C420", Offset = "0x2C3B820", Length = "0x18")]
		[Token(Token = "0x6000D0D")]
		 get { } //Length: 24
		[Address(RVA = "0x2C3C5C0", Offset = "0x2C3B9C0", Length = "0x1B")]
		[Token(Token = "0x6000D0E")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000D0F")]
	public BitArray64(ulong initValue) { }

	[Address(RVA = "0x2C3C380", Offset = "0x2C3B780", Length = "0x9A")]
	[Token(Token = "0x6000D10")]
	public BitArray64(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x2C3C170", Offset = "0x2C3B570", Length = "0x82")]
	[Token(Token = "0x6000D14")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3C200", Offset = "0x2C3B600", Length = "0x47")]
	[Token(Token = "0x6000D16")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3C250", Offset = "0x2C3B650", Length = "0x7F")]
	[Token(Token = "0x6000D15")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3C2D0", Offset = "0x2C3B6D0", Length = "0x81")]
	[Token(Token = "0x6000D19")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
	[Token(Token = "0x6000D0A")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3C440", Offset = "0x2C3B840", Length = "0x8")]
	[Token(Token = "0x6000D0B")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9DCC30", Offset = "0x9DC030", Length = "0x6")]
	[Token(Token = "0x6000D09")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3C450", Offset = "0x2C3B850", Length = "0x13C")]
	[Token(Token = "0x6000D0C")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3C420", Offset = "0x2C3B820", Length = "0x18")]
	[Token(Token = "0x6000D0D")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3C360", Offset = "0x2C3B760", Length = "0x15")]
	[Token(Token = "0x6000D1A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3C590", Offset = "0x2C3B990", Length = "0x7")]
	[Token(Token = "0x6000D13")]
	public static BitArray64 op_BitwiseAnd(BitArray64 a, BitArray64 b) { }

	[Address(RVA = "0x2C3C5A0", Offset = "0x2C3B9A0", Length = "0x7")]
	[Token(Token = "0x6000D12")]
	public static BitArray64 op_BitwiseOr(BitArray64 a, BitArray64 b) { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x6000D17")]
	public static bool op_Equality(BitArray64 a, BitArray64 b) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x6000D18")]
	public static bool op_Inequality(BitArray64 a, BitArray64 b) { }

	[Address(RVA = "0x2C3C5B0", Offset = "0x2C3B9B0", Length = "0x7")]
	[Token(Token = "0x6000D11")]
	public static BitArray64 op_OnesComplement(BitArray64 a) { }

	[Address(RVA = "0x2C3C5C0", Offset = "0x2C3B9C0", Length = "0x1B")]
	[Token(Token = "0x6000D0E")]
	public override void set_Item(uint index, bool value) { }

}

