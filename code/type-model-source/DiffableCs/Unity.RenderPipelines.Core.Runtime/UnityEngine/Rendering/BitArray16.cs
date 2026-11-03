namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001B0")]
public struct BitArray16 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000859")]
	private ushort data; //Field offset: 0x0

	[Token(Token = "0x170001A6")]
	public override bool allFalse
	{
		[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
		[Token(Token = "0x6000CE5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001A7")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3B070", Offset = "0x2C3A470", Length = "0xC")]
		[Token(Token = "0x6000CE6")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170001A5")]
	public override uint capacity
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x6000CE4")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A8")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3B080", Offset = "0x2C3A480", Length = "0x13B")]
		[Token(Token = "0x6000CE7")]
		 get { } //Length: 315
	}

	[Token(Token = "0x170001A9")]
	public override bool Item
	{
		[Address(RVA = "0x2C3B050", Offset = "0x2C3A450", Length = "0x19")]
		[Token(Token = "0x6000CE8")]
		 get { } //Length: 25
		[Address(RVA = "0x2C3B1F0", Offset = "0x2C3A5F0", Length = "0x19")]
		[Token(Token = "0x6000CE9")]
		 set { } //Length: 25
	}

	[Address(RVA = "0x60A350", Offset = "0x609750", Length = "0x4")]
	[Token(Token = "0x6000CEA")]
	public BitArray16(ushort initValue) { }

	[Address(RVA = "0x2C3AFB0", Offset = "0x2C3A3B0", Length = "0x99")]
	[Token(Token = "0x6000CEB")]
	public BitArray16(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x2C3ADA0", Offset = "0x2C3A1A0", Length = "0x82")]
	[Token(Token = "0x6000CEF")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3AE30", Offset = "0x2C3A230", Length = "0x47")]
	[Token(Token = "0x6000CF1")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3AE80", Offset = "0x2C3A280", Length = "0x7F")]
	[Token(Token = "0x6000CF0")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3AF00", Offset = "0x2C3A300", Length = "0x81")]
	[Token(Token = "0x6000CF4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x28B1540", Offset = "0x28B0940", Length = "0x8")]
	[Token(Token = "0x6000CE5")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3B070", Offset = "0x2C3A470", Length = "0xC")]
	[Token(Token = "0x6000CE6")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6000CE4")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3B080", Offset = "0x2C3A480", Length = "0x13B")]
	[Token(Token = "0x6000CE7")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3B050", Offset = "0x2C3A450", Length = "0x19")]
	[Token(Token = "0x6000CE8")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3AF90", Offset = "0x2C3A390", Length = "0x15")]
	[Token(Token = "0x6000CF5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3B1C0", Offset = "0x2C3A5C0", Length = "0x7")]
	[Token(Token = "0x6000CEE")]
	public static BitArray16 op_BitwiseAnd(BitArray16 a, BitArray16 b) { }

	[Address(RVA = "0x2C3B1D0", Offset = "0x2C3A5D0", Length = "0x7")]
	[Token(Token = "0x6000CED")]
	public static BitArray16 op_BitwiseOr(BitArray16 a, BitArray16 b) { }

	[Address(RVA = "0x60A360", Offset = "0x609760", Length = "0x7")]
	[Token(Token = "0x6000CF2")]
	public static bool op_Equality(BitArray16 a, BitArray16 b) { }

	[Address(RVA = "0x28A8280", Offset = "0x28A7680", Length = "0x7")]
	[Token(Token = "0x6000CF3")]
	public static bool op_Inequality(BitArray16 a, BitArray16 b) { }

	[Address(RVA = "0x2C3B1E0", Offset = "0x2C3A5E0", Length = "0x7")]
	[Token(Token = "0x6000CEC")]
	public static BitArray16 op_OnesComplement(BitArray16 a) { }

	[Address(RVA = "0x2C3B1F0", Offset = "0x2C3A5F0", Length = "0x19")]
	[Token(Token = "0x6000CE9")]
	public override void set_Item(uint index, bool value) { }

}

