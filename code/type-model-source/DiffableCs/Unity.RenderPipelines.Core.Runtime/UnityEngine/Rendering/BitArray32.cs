namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
[Token(Token = "0x20001B1")]
public struct BitArray32 : IBitArray
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400085A")]
	private uint data; //Field offset: 0x0

	[Token(Token = "0x170001AB")]
	public override bool allFalse
	{
		[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
		[Token(Token = "0x6000CF7")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001AC")]
	public override bool allTrue
	{
		[Address(RVA = "0x2C3BF80", Offset = "0x2C3B380", Length = "0x7")]
		[Token(Token = "0x6000CF8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001AA")]
	public override uint capacity
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6000CF6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AE")]
	public override string humanizedData
	{
		[Address(RVA = "0x2C3BF90", Offset = "0x2C3B390", Length = "0x13B")]
		[Token(Token = "0x6000CFA")]
		 get { } //Length: 315
	}

	[Token(Token = "0x170001AD")]
	private string humanizedVersion
	{
		[Address(RVA = "0x2C3C0D0", Offset = "0x2C3B4D0", Length = "0x51")]
		[Token(Token = "0x6000CF9")]
		private get { } //Length: 81
	}

	[Token(Token = "0x170001AF")]
	public override bool Item
	{
		[Address(RVA = "0x2C3BF60", Offset = "0x2C3B360", Length = "0x17")]
		[Token(Token = "0x6000CFB")]
		 get { } //Length: 23
		[Address(RVA = "0x2C3C150", Offset = "0x2C3B550", Length = "0x16")]
		[Token(Token = "0x6000CFC")]
		 set { } //Length: 22
	}

	[Address(RVA = "0x2C3BEC0", Offset = "0x2C3B2C0", Length = "0x95")]
	[Token(Token = "0x6000CFE")]
	public BitArray32(IEnumerable<UInt32> bitIndexTrue) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000CFD")]
	public BitArray32(uint initValue) { }

	[Address(RVA = "0x2C3BCD0", Offset = "0x2C3B0D0", Length = "0x7E")]
	[Token(Token = "0x6000CFF")]
	public override IBitArray BitAnd(IBitArray other) { }

	[Address(RVA = "0x2C3BD50", Offset = "0x2C3B150", Length = "0x44")]
	[Token(Token = "0x6000D01")]
	public override IBitArray BitNot() { }

	[Address(RVA = "0x2C3BDA0", Offset = "0x2C3B1A0", Length = "0x7C")]
	[Token(Token = "0x6000D00")]
	public override IBitArray BitOr(IBitArray other) { }

	[Address(RVA = "0x2C3BE20", Offset = "0x2C3B220", Length = "0x7F")]
	[Token(Token = "0x6000D07")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
	[Token(Token = "0x6000CF7")]
	public override bool get_allFalse() { }

	[Address(RVA = "0x2C3BF80", Offset = "0x2C3B380", Length = "0x7")]
	[Token(Token = "0x6000CF8")]
	public override bool get_allTrue() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000CF6")]
	public override uint get_capacity() { }

	[Address(RVA = "0x2C3BF90", Offset = "0x2C3B390", Length = "0x13B")]
	[Token(Token = "0x6000CFA")]
	public override string get_humanizedData() { }

	[Address(RVA = "0x2C3C0D0", Offset = "0x2C3B4D0", Length = "0x51")]
	[Token(Token = "0x6000CF9")]
	private string get_humanizedVersion() { }

	[Address(RVA = "0x2C3BF60", Offset = "0x2C3B360", Length = "0x17")]
	[Token(Token = "0x6000CFB")]
	public override bool get_Item(uint index) { }

	[Address(RVA = "0x2C3BEA0", Offset = "0x2C3B2A0", Length = "0x15")]
	[Token(Token = "0x6000D08")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20A0310", Offset = "0x209F710", Length = "0x5")]
	[Token(Token = "0x6000D04")]
	public static BitArray32 op_BitwiseAnd(BitArray32 a, BitArray32 b) { }

	[Address(RVA = "0x2C3C130", Offset = "0x2C3B530", Length = "0x5")]
	[Token(Token = "0x6000D03")]
	public static BitArray32 op_BitwiseOr(BitArray32 a, BitArray32 b) { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x6000D05")]
	public static bool op_Equality(BitArray32 a, BitArray32 b) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6000D06")]
	public static bool op_Inequality(BitArray32 a, BitArray32 b) { }

	[Address(RVA = "0x2C3C140", Offset = "0x2C3B540", Length = "0x5")]
	[Token(Token = "0x6000D02")]
	public static BitArray32 op_OnesComplement(BitArray32 a) { }

	[Address(RVA = "0x2C3C150", Offset = "0x2C3B550", Length = "0x16")]
	[Token(Token = "0x6000CFC")]
	public override void set_Item(uint index, bool value) { }

}

