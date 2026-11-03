namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000029")]
public struct PhysicsRotate : ISerializationCallbackReceiver
{
	[Token(Token = "0x40000E7")]
	private static readonly PhysicsRotate identityRotation; //Field offset: 0x0
	[Token(Token = "0x40000E8")]
	private static readonly PhysicsRotate leftRotation; //Field offset: 0x8
	[Token(Token = "0x40000E9")]
	private static readonly PhysicsRotate upRotation; //Field offset: 0x10
	[Token(Token = "0x40000EA")]
	private static readonly PhysicsRotate downRotation; //Field offset: 0x18
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E6")]
	public Vector2 direction; //Field offset: 0x0

	[Token(Token = "0x17000049")]
	public float angle
	{
		[Address(RVA = "0x312DD20", Offset = "0x312D120", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000148")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000046")]
	public float cos
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[IsReadOnly]
		[Token(Token = "0x6000142")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004A")]
	public static PhysicsRotate identity
	{
		[Address(RVA = "0x312DD60", Offset = "0x312D160", Length = "0x5C")]
		[Token(Token = "0x6000149")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000048")]
	public bool isValid
	{
		[Address(RVA = "0x312DDC0", Offset = "0x312D1C0", Length = "0x39")]
		[IsReadOnly]
		[Token(Token = "0x6000147")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000047")]
	public float sin
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[IsReadOnly]
		[Token(Token = "0x6000143")]
		 get { } //Length: 388
	}

	[Address(RVA = "0x312D9E0", Offset = "0x312CDE0", Length = "0x23E")]
	[Token(Token = "0x600014D")]
	private static PhysicsRotate() { }

	[Address(RVA = "0x312DC20", Offset = "0x312D020", Length = "0x4C")]
	[Token(Token = "0x6000144")]
	public PhysicsRotate() { }

	[Address(RVA = "0x312DCD0", Offset = "0x312D0D0", Length = "0x50")]
	[Token(Token = "0x6000145")]
	public PhysicsRotate(Vector2 direction) { }

	[Address(RVA = "0x312DC70", Offset = "0x312D070", Length = "0x56")]
	[Token(Token = "0x6000146")]
	public PhysicsRotate(float angle) { }

	[Address(RVA = "0x312DD20", Offset = "0x312D120", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000148")]
	public float get_angle() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x6000142")]
	public float get_cos() { }

	[Address(RVA = "0x312DD60", Offset = "0x312D160", Length = "0x5C")]
	[Token(Token = "0x6000149")]
	public static PhysicsRotate get_identity() { }

	[Address(RVA = "0x312DDC0", Offset = "0x312D1C0", Length = "0x39")]
	[IsReadOnly]
	[Token(Token = "0x6000147")]
	public bool get_isValid() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[IsReadOnly]
	[Token(Token = "0x6000143")]
	public float get_sin() { }

	[Address(RVA = "0x312D720", Offset = "0x312CB20", Length = "0xD8")]
	[Token(Token = "0x600014B")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x312D800", Offset = "0x312CC00", Length = "0xD8")]
	[Token(Token = "0x600014A")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x312D8E0", Offset = "0x312CCE0", Length = "0xF2")]
	[IsReadOnly]
	[Token(Token = "0x600014C")]
	public virtual string ToString() { }

}

