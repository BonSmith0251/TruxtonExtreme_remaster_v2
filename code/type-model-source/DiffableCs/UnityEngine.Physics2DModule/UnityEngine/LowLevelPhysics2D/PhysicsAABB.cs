namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000024")]
public struct PhysicsAABB
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private Vector2 m_LowerBound; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	private Vector2 m_UpperBound; //Field offset: 0x8

	[Token(Token = "0x1700003E")]
	public bool isValid
	{
		[Address(RVA = "0x3128620", Offset = "0x3127A20", Length = "0x37")]
		[IsReadOnly]
		[Token(Token = "0x6000129")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700003F")]
	public Vector2 lowerBound
	{
		[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x600012A")]
		 get { } //Length: 18
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x600012B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000040")]
	public Vector2 upperBound
	{
		[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x600012C")]
		 get { } //Length: 19
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[Token(Token = "0x600012D")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x3128620", Offset = "0x3127A20", Length = "0x37")]
	[IsReadOnly]
	[Token(Token = "0x6000129")]
	public bool get_isValid() { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x600012A")]
	public Vector2 get_lowerBound() { }

	[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x600012C")]
	public Vector2 get_upperBound() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600012B")]
	public void set_lowerBound(Vector2 value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[Token(Token = "0x600012D")]
	public void set_upperBound(Vector2 value) { }

	[Address(RVA = "0x3128540", Offset = "0x3127940", Length = "0xD9")]
	[IsReadOnly]
	[Token(Token = "0x600012E")]
	public virtual string ToString() { }

}

