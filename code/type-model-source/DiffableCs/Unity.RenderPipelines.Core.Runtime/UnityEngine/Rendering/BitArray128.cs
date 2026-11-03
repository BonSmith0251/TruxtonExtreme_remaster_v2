namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001B3")]
public struct BitArray128 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400085C")]
	private ulong data1; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400085D")]
	private ulong data2; //Field offset: 0x8

	[Token(Token = "0x170001B6")]
	public override bool allFalse
	{
		[Address(RVA = "0x2C3AB20", Offset = "0x2C39F20", Length = "0x12")]
		[Token(Token = "0x6000D1C")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170001B7")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3AB40", Offset = "0x2C39F40", Length = "0x12")]
		[Token(Token = "0x6000D1D")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170001B5")]
	public override uint capacity
	{
		[Address(RVA = "0x9DCD50", Offset = "0x9DC150", Length = "0x6")]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001B8")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3AB60", Offset = "0x2C39F60", Length = "0x1DE")]
		[Token(Token = "0x6000D1E")]
		 get { } //Length: 478
	}

	[Token(Token = "0x170001B9")]
	public override bool Item
	{
		[Address(RVA = "0x2C3AAF0", Offset = "0x2C39EF0", Length = "0x21")]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 33
		[Address(RVA = "0x2C3AD60", Offset = "0x2C3A160", Length = "0x3F")]
		[Token(Token = "0x6000D20")]
		 set { } //Length: 63
	}

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6000D21")]
	public BitArray128(ulong initValue1, ulong initValue2) { }

	[Address(RVA = "0x2C3AA30", Offset = "0x2C39E30", Length = "0xB5")]
	[Token(Token = "0x6000D22")]
	public BitArray128(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x2C3A760", Offset = "0x2C39B60", Length = "0xB8")]
	[Token(Token = "0x6000D26")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3A820", Offset = "0x2C39C20", Length = "0x5E")]
	[Token(Token = "0x6000D28")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3A880", Offset = "0x2C39C80", Length = "0xB8")]
	[Token(Token = "0x6000D27")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3A940", Offset = "0x2C39D40", Length = "0xAE")]
	[Token(Token = "0x6000D2B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2C3AB20", Offset = "0x2C39F20", Length = "0x12")]
	[Token(Token = "0x6000D1C")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3AB40", Offset = "0x2C39F40", Length = "0x12")]
	[Token(Token = "0x6000D1D")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9DCD50", Offset = "0x9DC150", Length = "0x6")]
	[Token(Token = "0x6000D1B")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3AB60", Offset = "0x2C39F60", Length = "0x1DE")]
	[Token(Token = "0x6000D1E")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3AAF0", Offset = "0x2C39EF0", Length = "0x21")]
	[Token(Token = "0x6000D1F")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3A9F0", Offset = "0x2C39DF0", Length = "0x3B")]
	[Token(Token = "0x6000D2C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x27F7C50", Offset = "0x27F7050", Length = "0x19")]
	[Token(Token = "0x6000D25")]
	public static BitArray128 op_BitwiseAnd(BitArray128 a, BitArray128 b) { }

	[Address(RVA = "0x27F9A30", Offset = "0x27F8E30", Length = "0x19")]
	[Token(Token = "0x6000D24")]
	public static BitArray128 op_BitwiseOr(BitArray128 a, BitArray128 b) { }

	[Address(RVA = "0x289CB10", Offset = "0x289BF10", Length = "0x17")]
	[Token(Token = "0x6000D29")]
	public static bool op_Equality(BitArray128 a, BitArray128 b) { }

	[Address(RVA = "0x289CB30", Offset = "0x289BF30", Length = "0x17")]
	[Token(Token = "0x6000D2A")]
	public static bool op_Inequality(BitArray128 a, BitArray128 b) { }

	[Address(RVA = "0x2C3AD40", Offset = "0x2C3A140", Length = "0x18")]
	[Token(Token = "0x6000D23")]
	public static BitArray128 op_OnesComplement(BitArray128 a) { }

	[Address(RVA = "0x2C3AD60", Offset = "0x2C3A160", Length = "0x3F")]
	[Token(Token = "0x6000D20")]
	public override void set_Item(uint index, bool value) { }

}

