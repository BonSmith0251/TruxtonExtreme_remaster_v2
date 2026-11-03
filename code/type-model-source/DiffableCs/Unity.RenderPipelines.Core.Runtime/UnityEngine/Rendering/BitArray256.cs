namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001B4")]
public struct BitArray256 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400085E")]
	private ulong data1; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400085F")]
	private ulong data2; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000860")]
	private ulong data3; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000861")]
	private ulong data4; //Field offset: 0x18

	[Token(Token = "0x170001BB")]
	public override bool allFalse
	{
		[Address(RVA = "0x2C3B7C0", Offset = "0x2C3ABC0", Length = "0x20")]
		[Token(Token = "0x6000D2E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170001BC")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3B7E0", Offset = "0x2C3ABE0", Length = "0x20")]
		[Token(Token = "0x6000D2F")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170001BA")]
	public override uint capacity
	{
		[Address(RVA = "0x9E18E0", Offset = "0x9E0CE0", Length = "0x6")]
		[Token(Token = "0x6000D2D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001BD")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3B800", Offset = "0x2C3AC00", Length = "0x303")]
		[Token(Token = "0x6000D30")]
		 get { } //Length: 771
	}

	[Token(Token = "0x170001BE")]
	public override bool Item
	{
		[Address(RVA = "0x2C3B770", Offset = "0x2C3AB70", Length = "0x41")]
		[Token(Token = "0x6000D31")]
		 get { } //Length: 65
		[Address(RVA = "0x2C3BC40", Offset = "0x2C3B040", Length = "0x83")]
		[Token(Token = "0x6000D32")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x27F6BF0", Offset = "0x27F5FF0", Length = "0x15")]
	[Token(Token = "0x6000D33")]
	public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) { }

	[Address(RVA = "0x2C3B670", Offset = "0x2C3AA70", Length = "0xF8")]
	[Token(Token = "0x6000D34")]
	public BitArray256(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x2C3B210", Offset = "0x2C3A610", Length = "0x115")]
	[Token(Token = "0x6000D38")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3B330", Offset = "0x2C3A730", Length = "0x9A")]
	[Token(Token = "0x6000D3A")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3B3D0", Offset = "0x2C3A7D0", Length = "0x115")]
	[Token(Token = "0x6000D39")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3B4F0", Offset = "0x2C3A8F0", Length = "0xF5")]
	[Token(Token = "0x6000D3D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2C3B7C0", Offset = "0x2C3ABC0", Length = "0x20")]
	[Token(Token = "0x6000D2E")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3B7E0", Offset = "0x2C3ABE0", Length = "0x20")]
	[Token(Token = "0x6000D2F")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9E18E0", Offset = "0x9E0CE0", Length = "0x6")]
	[Token(Token = "0x6000D2D")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3B800", Offset = "0x2C3AC00", Length = "0x303")]
	[Token(Token = "0x6000D30")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3B770", Offset = "0x2C3AB70", Length = "0x41")]
	[Token(Token = "0x6000D31")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3B5F0", Offset = "0x2C3A9F0", Length = "0x77")]
	[Token(Token = "0x6000D3E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3BB10", Offset = "0x2C3AF10", Length = "0x31")]
	[Token(Token = "0x6000D37")]
	public static BitArray256 op_BitwiseAnd(BitArray256 a, BitArray256 b) { }

	[Address(RVA = "0x2C3BB50", Offset = "0x2C3AF50", Length = "0x31")]
	[Token(Token = "0x6000D36")]
	public static BitArray256 op_BitwiseOr(BitArray256 a, BitArray256 b) { }

	[Address(RVA = "0x2C3BB90", Offset = "0x2C3AF90", Length = "0x3A")]
	[Token(Token = "0x6000D3B")]
	public static bool op_Equality(BitArray256 a, BitArray256 b) { }

	[Address(RVA = "0x2C3BBD0", Offset = "0x2C3AFD0", Length = "0x3A")]
	[Token(Token = "0x6000D3C")]
	public static bool op_Inequality(BitArray256 a, BitArray256 b) { }

	[Address(RVA = "0x2C3BC10", Offset = "0x2C3B010", Length = "0x2E")]
	[Token(Token = "0x6000D35")]
	public static BitArray256 op_OnesComplement(BitArray256 a) { }

	[Address(RVA = "0x2C3BC40", Offset = "0x2C3B040", Length = "0x83")]
	[Token(Token = "0x6000D32")]
	public override void set_Item(uint index, bool value) { }

}

