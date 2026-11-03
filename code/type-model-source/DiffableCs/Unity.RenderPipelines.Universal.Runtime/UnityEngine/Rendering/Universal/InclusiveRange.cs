namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001B7")]
internal struct InclusiveRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000973")]
	public short start; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000974")]
	public short end; //Field offset: 0x2

	[Token(Token = "0x17000232")]
	public static InclusiveRange empty
	{
		[Address(RVA = "0x2DE81A0", Offset = "0x2DE75A0", Length = "0xD")]
		[Token(Token = "0x600097C")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000231")]
	public bool isEmpty
	{
		[Address(RVA = "0x2DE81B0", Offset = "0x2DE75B0", Length = "0xB")]
		[Token(Token = "0x6000979")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2AF0460", Offset = "0x2AEF860", Length = "0x8")]
	[Token(Token = "0x6000975")]
	public InclusiveRange(short startEnd) { }

	[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
	[Token(Token = "0x6000976")]
	public InclusiveRange(short start, short end) { }

	[Address(RVA = "0x2DE7F80", Offset = "0x2DE7380", Length = "0x8B")]
	[Token(Token = "0x6000978")]
	public void Clamp(short min, short max) { }

	[Address(RVA = "0x2DE8010", Offset = "0x2DE7410", Length = "0x10")]
	[Token(Token = "0x600097A")]
	public bool Contains(short index) { }

	[Address(RVA = "0x2DE8020", Offset = "0x2DE7420", Length = "0x7D")]
	[Token(Token = "0x6000977")]
	public void Expand(short index) { }

	[Address(RVA = "0x2DE81A0", Offset = "0x2DE75A0", Length = "0xD")]
	[Token(Token = "0x600097C")]
	public static InclusiveRange get_empty() { }

	[Address(RVA = "0x2DE81B0", Offset = "0x2DE75B0", Length = "0xB")]
	[Token(Token = "0x6000979")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x2DE80A0", Offset = "0x2DE74A0", Length = "0x80")]
	[Token(Token = "0x600097B")]
	public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b) { }

	[Address(RVA = "0x2DE8120", Offset = "0x2DE7520", Length = "0x7F")]
	[Token(Token = "0x600097D")]
	public virtual string ToString() { }

}

