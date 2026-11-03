namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200015B")]
[UsedByNativeCode]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	[Token(Token = "0x40005CD")]
	private static readonly Vector3Int s_Zero; //Field offset: 0x0
	[Token(Token = "0x40005CE")]
	private static readonly Vector3Int s_One; //Field offset: 0xC
	[Token(Token = "0x40005CF")]
	private static readonly Vector3Int s_Up; //Field offset: 0x18
	[Token(Token = "0x40005D0")]
	private static readonly Vector3Int s_Down; //Field offset: 0x24
	[Token(Token = "0x40005D1")]
	private static readonly Vector3Int s_Left; //Field offset: 0x30
	[Token(Token = "0x40005D2")]
	private static readonly Vector3Int s_Right; //Field offset: 0x3C
	[Token(Token = "0x40005D3")]
	private static readonly Vector3Int s_Forward; //Field offset: 0x48
	[Token(Token = "0x40005D4")]
	private static readonly Vector3Int s_Back; //Field offset: 0x54
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005CA")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005CB")]
	private int m_Y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40005CC")]
	private int m_Z; //Field offset: 0x8

	[Token(Token = "0x170002B6")]
	public static Vector3Int one
	{
		[Address(RVA = "0x3075750", Offset = "0x3074B50", Length = "0x4B")]
		[Token(Token = "0x600117A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170002B2")]
	public int x
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[IsReadOnly]
		[Token(Token = "0x6001164")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6001165")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170002B3")]
	public int y
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6001166")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001167")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002B4")]
	public int z
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6001168")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6001169")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002B5")]
	public static Vector3Int zero
	{
		[Address(RVA = "0x30757A0", Offset = "0x3074BA0", Length = "0x4A")]
		[Token(Token = "0x6001179")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x3075600", Offset = "0x3074A00", Length = "0x150")]
	[Token(Token = "0x600117B")]
	private static Vector3Int() { }

	[Address(RVA = "0x12F4C60", Offset = "0x12F4060", Length = "0xB")]
	[Token(Token = "0x600116A")]
	public Vector3Int(int x, int y, int z) { }

	[Address(RVA = "0x3075390", Offset = "0x3074790", Length = "0x61")]
	[IsReadOnly]
	[Token(Token = "0x6001175")]
	public bool Equals(in Vector3Int other) { }

	[Address(RVA = "0x3075390", Offset = "0x3074790", Length = "0x61")]
	[IsReadOnly]
	[Token(Token = "0x6001174")]
	public override bool Equals(Vector3Int other) { }

	[Address(RVA = "0x30752A0", Offset = "0x30746A0", Length = "0xEF")]
	[IsReadOnly]
	[Token(Token = "0x6001173")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3075750", Offset = "0x3074B50", Length = "0x4B")]
	[Token(Token = "0x600117A")]
	public static Vector3Int get_one() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[IsReadOnly]
	[Token(Token = "0x6001164")]
	public int get_x() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6001166")]
	public int get_y() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6001168")]
	public int get_z() { }

	[Address(RVA = "0x30757A0", Offset = "0x3074BA0", Length = "0x4A")]
	[Token(Token = "0x6001179")]
	public static Vector3Int get_zero() { }

	[Address(RVA = "0x3075400", Offset = "0x3074800", Length = "0x5C")]
	[IsReadOnly]
	[Token(Token = "0x6001176")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3075460", Offset = "0x3074860", Length = "0x3B")]
	[Token(Token = "0x600116C")]
	public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) { }

	[Address(RVA = "0x30754A0", Offset = "0x30748A0", Length = "0x3B")]
	[Token(Token = "0x600116B")]
	public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) { }

	[Address(RVA = "0x2AFF4E0", Offset = "0x2AFE8E0", Length = "0x1F")]
	[Token(Token = "0x600116E")]
	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	[Address(RVA = "0x2AFF610", Offset = "0x2AFEA10", Length = "0x25")]
	[Token(Token = "0x6001171")]
	public static Vector3Int op_Division(Vector3Int a, int b) { }

	[Address(RVA = "0x30757F0", Offset = "0x3074BF0", Length = "0x1B")]
	[Token(Token = "0x6001172")]
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	[Address(RVA = "0x3075810", Offset = "0x3074C10", Length = "0x29")]
	[Token(Token = "0x600116D")]
	public static Vector3 op_Implicit(Vector3Int v) { }

	[Address(RVA = "0x2AFFAB0", Offset = "0x2AFEEB0", Length = "0x1F")]
	[Token(Token = "0x6001170")]
	public static Vector3Int op_Multiply(Vector3Int a, int b) { }

	[Address(RVA = "0x2AFFB80", Offset = "0x2AFEF80", Length = "0x1F")]
	[Token(Token = "0x600116F")]
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6001165")]
	public void set_x(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001167")]
	public void set_y(int value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6001169")]
	public void set_z(int value) { }

	[Address(RVA = "0x30754E0", Offset = "0x30748E0", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6001177")]
	public virtual string ToString() { }

	[Address(RVA = "0x30754F0", Offset = "0x30748F0", Length = "0x107")]
	[IsReadOnly]
	[Token(Token = "0x6001178")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

