namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x2000152")]
internal sealed class BitSet
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000725")]
	private int count; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000726")]
	private UInt32[] bits; //Field offset: 0x18

	[Token(Token = "0x170003CE")]
	public int Count
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000EB5")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170003D0")]
	public bool IsEmpty
	{
		[Address(RVA = "0x257ED70", Offset = "0x257E170", Length = "0x50")]
		[Token(Token = "0x6000EC0")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170003CF")]
	public bool Item
	{
		[Address(RVA = "0x257EA10", Offset = "0x257DE10", Length = "0x4F")]
		[Token(Token = "0x6000EB6")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000EB3")]
	private BitSet() { }

	[Address(RVA = "0x257ED00", Offset = "0x257E100", Length = "0x64")]
	[Token(Token = "0x6000EB4")]
	public BitSet(int count) { }

	[Address(RVA = "0x257E580", Offset = "0x257D980", Length = "0xDB")]
	[Token(Token = "0x6000EBB")]
	public void And(BitSet other) { }

	[Address(RVA = "0x257E660", Offset = "0x257DA60", Length = "0x53")]
	[Token(Token = "0x6000EB7")]
	public void Clear() { }

	[Address(RVA = "0x257E6C0", Offset = "0x257DAC0", Length = "0xE7")]
	[Token(Token = "0x6000EBF")]
	public BitSet Clone() { }

	[Address(RVA = "0x257E7B0", Offset = "0x257DBB0", Length = "0x8E")]
	[Token(Token = "0x6000EC3")]
	private void EnsureLength(int nRequiredLength) { }

	[Address(RVA = "0x257E840", Offset = "0x257DC40", Length = "0x182")]
	[Token(Token = "0x6000EBE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x257EA10", Offset = "0x257DE10", Length = "0x4F")]
	[Token(Token = "0x6000EB9")]
	public bool Get(int index) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000EB5")]
	public int get_Count() { }

	[Address(RVA = "0x257ED70", Offset = "0x257E170", Length = "0x50")]
	[Token(Token = "0x6000EC0")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x257EA10", Offset = "0x257DE10", Length = "0x4F")]
	[Token(Token = "0x6000EB6")]
	public bool get_Item(int index) { }

	[Address(RVA = "0x257E9D0", Offset = "0x257DDD0", Length = "0x3C")]
	[Token(Token = "0x6000EBD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x257EA60", Offset = "0x257DE60", Length = "0xD8")]
	[Token(Token = "0x6000EC1")]
	public bool Intersects(BitSet other) { }

	[Address(RVA = "0x257EB40", Offset = "0x257DF40", Length = "0x9B")]
	[Token(Token = "0x6000EBA")]
	public int NextSet(int startFrom) { }

	[Address(RVA = "0x257EBE0", Offset = "0x257DFE0", Length = "0x9D")]
	[Token(Token = "0x6000EBC")]
	public void Or(BitSet other) { }

	[Address(RVA = "0x257EC80", Offset = "0x257E080", Length = "0x60")]
	[Token(Token = "0x6000EB8")]
	public void Set(int index) { }

	[Address(RVA = "0x257ECF0", Offset = "0x257E0F0", Length = "0x6")]
	[Token(Token = "0x6000EC2")]
	private int Subscript(int bitIndex) { }

}

