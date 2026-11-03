namespace UnityEngine;

[Token(Token = "0x20000C9")]
[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable
{
	[Token(Token = "0x400024B")]
	private static readonly RectInt kZero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000247")]
	private int m_XMin; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000248")]
	private int m_YMin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000249")]
	private int m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400024A")]
	private int m_Height; //Field offset: 0xC

	[Token(Token = "0x17000100")]
	public int height
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60005D0")]
		 get { } //Length: 4
		[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
		[Token(Token = "0x60005D1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000FF")]
	public int width
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60005CE")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x60005CF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000FD")]
	public int x
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[IsReadOnly]
		[Token(Token = "0x60005CA")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x60005CB")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000103")]
	public int xMax
	{
		[Address(RVA = "0x300FB50", Offset = "0x300EF50", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000101")]
	public int xMin
	{
		[Address(RVA = "0x300FB70", Offset = "0x300EF70", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170000FE")]
	public int y
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x60005CC")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x60005CD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000104")]
	public int yMax
	{
		[Address(RVA = "0x300FB90", Offset = "0x300EF90", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000102")]
	public int yMin
	{
		[Address(RVA = "0x300FBB0", Offset = "0x300EFB0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000105")]
	public static RectInt zero
	{
		[Address(RVA = "0x300FBD0", Offset = "0x300EFD0", Length = "0x5A")]
		[Token(Token = "0x60005D7")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x300FB10", Offset = "0x300EF10", Length = "0x39")]
	[Token(Token = "0x60005E1")]
	private static RectInt() { }

	[Address(RVA = "0x27F6A90", Offset = "0x27F5E90", Length = "0x12")]
	[Token(Token = "0x60005D6")]
	public RectInt(int xMin, int yMin, int width, int height) { }

	[Address(RVA = "0x300F620", Offset = "0x300EA20", Length = "0x27")]
	[IsReadOnly]
	[Token(Token = "0x60005DF")]
	public override bool Equals(RectInt other) { }

	[Address(RVA = "0x300F520", Offset = "0x300E920", Length = "0xF4")]
	[IsReadOnly]
	[Token(Token = "0x60005DE")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x300F620", Offset = "0x300EA20", Length = "0x27")]
	[IsReadOnly]
	[Token(Token = "0x60005E0")]
	public bool Equals(in RectInt other) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60005D0")]
	public int get_height() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60005CE")]
	public int get_width() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[IsReadOnly]
	[Token(Token = "0x60005CA")]
	public int get_x() { }

	[Address(RVA = "0x300FB50", Offset = "0x300EF50", Length = "0x11")]
	[IsReadOnly]
	[Token(Token = "0x60005D4")]
	public int get_xMax() { }

	[Address(RVA = "0x300FB70", Offset = "0x300EF70", Length = "0x11")]
	[IsReadOnly]
	[Token(Token = "0x60005D2")]
	public int get_xMin() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x60005CC")]
	public int get_y() { }

	[Address(RVA = "0x300FB90", Offset = "0x300EF90", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x60005D5")]
	public int get_yMax() { }

	[Address(RVA = "0x300FBB0", Offset = "0x300EFB0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x60005D3")]
	public int get_yMin() { }

	[Address(RVA = "0x300FBD0", Offset = "0x300EFD0", Length = "0x5A")]
	[Token(Token = "0x60005D7")]
	public static RectInt get_zero() { }

	[Address(RVA = "0x300F650", Offset = "0x300EA50", Length = "0x74")]
	[IsReadOnly]
	[Token(Token = "0x60005DD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x300F620", Offset = "0x300EA20", Length = "0x27")]
	[Token(Token = "0x60005DC")]
	public static bool op_Equality(RectInt lhs, RectInt rhs) { }

	[Address(RVA = "0x300FC30", Offset = "0x300F030", Length = "0x8E")]
	[Token(Token = "0x60005DB")]
	public static bool op_Inequality(RectInt lhs, RectInt rhs) { }

	[Address(RVA = "0x300F6D0", Offset = "0x300EAD0", Length = "0x14D")]
	[IsReadOnly]
	[Token(Token = "0x60005D8")]
	public bool Overlaps(RectInt other) { }

	[Address(RVA = "0x672EB0", Offset = "0x6722B0", Length = "0x4")]
	[Token(Token = "0x60005D1")]
	public void set_height(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60005CF")]
	public void set_width(int value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60005CB")]
	public void set_x(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x60005CD")]
	public void set_y(int value) { }

	[Address(RVA = "0x300FAC0", Offset = "0x300EEC0", Length = "0x4F")]
	[IsReadOnly]
	[Token(Token = "0x60005D9")]
	public virtual string ToString() { }

	[Address(RVA = "0x300F820", Offset = "0x300EC20", Length = "0x294")]
	[IsReadOnly]
	[Token(Token = "0x60005DA")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

