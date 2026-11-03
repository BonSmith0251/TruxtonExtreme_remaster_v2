namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeType("Runtime/Math/Vector2Int.h")]
[Token(Token = "0x200015A")]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	[Token(Token = "0x40005C4")]
	private static readonly Vector2Int s_Zero; //Field offset: 0x0
	[Token(Token = "0x40005C5")]
	private static readonly Vector2Int s_One; //Field offset: 0x8
	[Token(Token = "0x40005C6")]
	private static readonly Vector2Int s_Up; //Field offset: 0x10
	[Token(Token = "0x40005C7")]
	private static readonly Vector2Int s_Down; //Field offset: 0x18
	[Token(Token = "0x40005C8")]
	private static readonly Vector2Int s_Left; //Field offset: 0x20
	[Token(Token = "0x40005C9")]
	private static readonly Vector2Int s_Right; //Field offset: 0x28
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005C2")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40005C3")]
	private int m_Y; //Field offset: 0x4

	[Token(Token = "0x170002AF")]
	public float magnitude
	{
		[Address(RVA = "0x30751D0", Offset = "0x30745D0", Length = "0x2C")]
		[IsReadOnly]
		[Token(Token = "0x6001152")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170002B1")]
	public static Vector2Int one
	{
		[Address(RVA = "0x3075200", Offset = "0x3074600", Length = "0x37")]
		[Token(Token = "0x6001162")]
		 get { } //Length: 55
	}

	[Token(Token = "0x170002AD")]
	public int x
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[IsReadOnly]
		[Token(Token = "0x600114D")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600114E")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170002AE")]
	public int y
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x600114F")]
		 get { } //Length: 4
		[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
		[Token(Token = "0x6001150")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002B0")]
	public static Vector2Int zero
	{
		[Address(RVA = "0x3075240", Offset = "0x3074640", Length = "0x36")]
		[Token(Token = "0x6001161")]
		 get { } //Length: 54
	}

	[Address(RVA = "0x30750E0", Offset = "0x30744E0", Length = "0xEF")]
	[Token(Token = "0x6001163")]
	private static Vector2Int() { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6001151")]
	public Vector2Int(int x, int y) { }

	[Address(RVA = "0x3074EC0", Offset = "0x30742C0", Length = "0x1A")]
	[IsReadOnly]
	[Token(Token = "0x600115D")]
	public bool Equals(in Vector2Int other) { }

	[Address(RVA = "0x2FEFAC0", Offset = "0x2FEEEC0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x600115C")]
	public override bool Equals(Vector2Int other) { }

	[Address(RVA = "0x3074E10", Offset = "0x3074210", Length = "0xA0")]
	[IsReadOnly]
	[Token(Token = "0x600115B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3074EE0", Offset = "0x30742E0", Length = "0xB2")]
	[Token(Token = "0x6001155")]
	public static Vector2Int FloorToInt(Vector2 v) { }

	[Address(RVA = "0x30751D0", Offset = "0x30745D0", Length = "0x2C")]
	[IsReadOnly]
	[Token(Token = "0x6001152")]
	public float get_magnitude() { }

	[Address(RVA = "0x3075200", Offset = "0x3074600", Length = "0x37")]
	[Token(Token = "0x6001162")]
	public static Vector2Int get_one() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[IsReadOnly]
	[Token(Token = "0x600114D")]
	public int get_x() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x600114F")]
	public int get_y() { }

	[Address(RVA = "0x3075240", Offset = "0x3074640", Length = "0x36")]
	[Token(Token = "0x6001161")]
	public static Vector2Int get_zero() { }

	[Address(RVA = "0x3074FA0", Offset = "0x30743A0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x600115E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3074FC0", Offset = "0x30743C0", Length = "0x2B")]
	[Token(Token = "0x6001153")]
	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) { }

	[Address(RVA = "0x2AF5B80", Offset = "0x2AF4F80", Length = "0x1B")]
	[Token(Token = "0x6001156")]
	public static Vector2Int op_Addition(Vector2Int a, Vector2Int b) { }

	[Address(RVA = "0x2AF5D00", Offset = "0x2AF5100", Length = "0x21")]
	[Token(Token = "0x6001158")]
	public static Vector2Int op_Division(Vector2Int a, int b) { }

	[Address(RVA = "0x3075280", Offset = "0x3074680", Length = "0x15")]
	[Token(Token = "0x6001159")]
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	[Address(RVA = "0x2A345C0", Offset = "0x2A339C0", Length = "0x1B")]
	[Token(Token = "0x6001154")]
	public static Vector2 op_Implicit(Vector2Int v) { }

	[Address(RVA = "0x23DEF20", Offset = "0x23DE320", Length = "0x1DA")]
	[Token(Token = "0x600115A")]
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	[Address(RVA = "0x2AF60B0", Offset = "0x2AF54B0", Length = "0x1A")]
	[Token(Token = "0x6001157")]
	public static Vector2Int op_Multiply(int a, Vector2Int b) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600114E")]
	public void set_x(int value) { }

	[Address(RVA = "0x6466F0", Offset = "0x645AF0", Length = "0x4")]
	[Token(Token = "0x6001150")]
	public void set_y(int value) { }

	[Address(RVA = "0x30750D0", Offset = "0x30744D0", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x600115F")]
	public virtual string ToString() { }

	[Address(RVA = "0x3074FF0", Offset = "0x30743F0", Length = "0xD8")]
	[IsReadOnly]
	[Token(Token = "0x6001160")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

