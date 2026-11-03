namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001D6")]
public struct BitVector32
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F4")]
	private uint _data; //Field offset: 0x0

	[Token(Token = "0x1700022D")]
	public bool Item
	{
		[Address(RVA = "0x2679C20", Offset = "0x2679020", Length = "0x12")]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 18
		[Address(RVA = "0x2679C40", Offset = "0x2679040", Length = "0x13")]
		[Token(Token = "0x6000BAC")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000BAD")]
	public static int CreateMask() { }

	[Address(RVA = "0x2679910", Offset = "0x2678D10", Length = "0x74")]
	[Token(Token = "0x6000BAE")]
	public static int CreateMask(int previous) { }

	[Address(RVA = "0x2679990", Offset = "0x2678D90", Length = "0x7F")]
	[Token(Token = "0x6000BAF")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2679C20", Offset = "0x2679020", Length = "0x12")]
	[Token(Token = "0x6000BAB")]
	public bool get_Item(int bit) { }

	[Address(RVA = "0x2679A10", Offset = "0x2678E10", Length = "0x4C")]
	[Token(Token = "0x6000BB0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2679C40", Offset = "0x2679040", Length = "0x13")]
	[Token(Token = "0x6000BAC")]
	public void set_Item(int bit, bool value) { }

	[Address(RVA = "0x2679B40", Offset = "0x2678F40", Length = "0xD9")]
	[Token(Token = "0x6000BB1")]
	public static string ToString(BitVector32 value) { }

	[Address(RVA = "0x2679A60", Offset = "0x2678E60", Length = "0xD9")]
	[Token(Token = "0x6000BB2")]
	public virtual string ToString() { }

}

