namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001AF")]
public struct BitArray8 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000858")]
	private byte data; //Field offset: 0x0

	[Token(Token = "0x170001A1")]
	public override bool allFalse
	{
		[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001A2")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3C8B0", Offset = "0x2C3BCB0", Length = "0x7")]
		[Token(Token = "0x6000CD4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001A0")]
	public override uint capacity
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x6000CD2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A3")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3C8C0", Offset = "0x2C3BCC0", Length = "0xD2")]
		[Token(Token = "0x6000CD5")]
		 get { } //Length: 210
	}

	[Token(Token = "0x170001A4")]
	public override bool Item
	{
		[Address(RVA = "0x2C3C890", Offset = "0x2C3BC90", Length = "0x19")]
		[Token(Token = "0x6000CD6")]
		 get { } //Length: 25
		[Address(RVA = "0x2C3C9F0", Offset = "0x2C3BDF0", Length = "0x17")]
		[Token(Token = "0x6000CD7")]
		 set { } //Length: 23
	}

	[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
	[Token(Token = "0x6000CD8")]
	public BitArray8(byte initValue) { }

	[Address(RVA = "0x2C3C7F0", Offset = "0x2C3BBF0", Length = "0x96")]
	[Token(Token = "0x6000CD9")]
	public BitArray8(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x2C3C5E0", Offset = "0x2C3B9E0", Length = "0x80")]
	[Token(Token = "0x6000CDD")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3C670", Offset = "0x2C3BA70", Length = "0x45")]
	[Token(Token = "0x6000CDF")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3C6C0", Offset = "0x2C3BAC0", Length = "0x7D")]
	[Token(Token = "0x6000CDE")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3C740", Offset = "0x2C3BB40", Length = "0x80")]
	[Token(Token = "0x6000CE2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2374F20", Offset = "0x2374320", Length = "0x7")]
	[Token(Token = "0x6000CD3")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3C8B0", Offset = "0x2C3BCB0", Length = "0x7")]
	[Token(Token = "0x6000CD4")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6000CD2")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3C8C0", Offset = "0x2C3BCC0", Length = "0xD2")]
	[Token(Token = "0x6000CD5")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3C890", Offset = "0x2C3BC90", Length = "0x19")]
	[Token(Token = "0x6000CD6")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3C7D0", Offset = "0x2C3BBD0", Length = "0x15")]
	[Token(Token = "0x6000CE3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2C3C9A0", Offset = "0x2C3BDA0", Length = "0x6")]
	[Token(Token = "0x6000CDC")]
	public static BitArray8 op_BitwiseAnd(BitArray8 a, BitArray8 b) { }

	[Address(RVA = "0x2C3C9B0", Offset = "0x2C3BDB0", Length = "0x6")]
	[Token(Token = "0x6000CDB")]
	public static BitArray8 op_BitwiseOr(BitArray8 a, BitArray8 b) { }

	[Address(RVA = "0x2C3C9C0", Offset = "0x2C3BDC0", Length = "0x6")]
	[Token(Token = "0x6000CE0")]
	public static bool op_Equality(BitArray8 a, BitArray8 b) { }

	[Address(RVA = "0x2C3C9D0", Offset = "0x2C3BDD0", Length = "0x6")]
	[Token(Token = "0x6000CE1")]
	public static bool op_Inequality(BitArray8 a, BitArray8 b) { }

	[Address(RVA = "0x2C3C9E0", Offset = "0x2C3BDE0", Length = "0x6")]
	[Token(Token = "0x6000CDA")]
	public static BitArray8 op_OnesComplement(BitArray8 a) { }

	[Address(RVA = "0x2C3C9F0", Offset = "0x2C3BDF0", Length = "0x17")]
	[Token(Token = "0x6000CD7")]
	public override void set_Item(uint index, bool value) { }

}

