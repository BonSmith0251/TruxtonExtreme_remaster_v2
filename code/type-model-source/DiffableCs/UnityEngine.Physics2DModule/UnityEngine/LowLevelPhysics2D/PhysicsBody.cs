namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x200002B")]
public struct PhysicsBody : IEquatable<PhysicsBody>
{
	[Flags]
	[Token(Token = "0x200002D")]
	internal enum BodyConstraints : int
	{
		None = 0,
		PositionX = 1,
		PositionY = 2,
		Rotation = 4,
		Position = 3,
		All = 7,
	}

	[Token(Token = "0x200002C")]
	internal enum BodyType : int
	{
		Dynamic = 0,
		Kinematic = 1,
		Static = 2,
	}

	[Token(Token = "0x200002E")]
	internal enum TransformWriteMode : int
	{
		Current = 0,
		Interpolate = 1,
		Extrapolate = 2,
		Off = 3,
	}

	[Token(Token = "0x200002F")]
	internal struct TransformWriteTween
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000101")]
		private PhysicsBody m_Body; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000102")]
		private TransformWriteMode m_TransformWriteMode; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000103")]
		private PhysicsTransform m_PhysicsTransform; //Field offset: 0xC
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000104")]
		private Vector2 m_LinearVelocity; //Field offset: 0x1C
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000105")]
		private float m_AngularVelocity; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000106")]
		private Vector3 m_PositionFrom; //Field offset: 0x28
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000107")]
		private Quaternion m_RotationFrom; //Field offset: 0x34

		[Token(Token = "0x17000052")]
		public float angularVelocity
		{
			[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
			[IsReadOnly]
			[Token(Token = "0x600015D")]
			 get { } //Length: 6
		}

		[Token(Token = "0x1700004E")]
		public PhysicsBody body
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000159")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000051")]
		public Vector2 linearVelocity
		{
			[Address(RVA = "0x31329C0", Offset = "0x3131DC0", Length = "0x13")]
			[IsReadOnly]
			[Token(Token = "0x600015C")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000050")]
		public PhysicsTransform physicsTransform
		{
			[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
			[IsReadOnly]
			[Token(Token = "0x600015B")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000053")]
		public Vector3 positionFrom
		{
			[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
			[IsReadOnly]
			[Token(Token = "0x600015E")]
			 get { } //Length: 19
			[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
			[Token(Token = "0x600015F")]
			 set { } //Length: 16
		}

		[Token(Token = "0x17000054")]
		public Quaternion rotationFrom
		{
			[Address(RVA = "0x3133A70", Offset = "0x3132E70", Length = "0xB")]
			[IsReadOnly]
			[Token(Token = "0x6000160")]
			 get { } //Length: 11
			[Address(RVA = "0x3133A80", Offset = "0x3132E80", Length = "0x8")]
			[Token(Token = "0x6000161")]
			 set { } //Length: 8
		}

		[Token(Token = "0x1700004F")]
		public TransformWriteMode transformWriteMode
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x600015A")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x600015D")]
		public float get_angularVelocity() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000159")]
		public PhysicsBody get_body() { }

		[Address(RVA = "0x31329C0", Offset = "0x3131DC0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x600015C")]
		public Vector2 get_linearVelocity() { }

		[Address(RVA = "0x28A7D30", Offset = "0x28A7130", Length = "0xB")]
		[IsReadOnly]
		[Token(Token = "0x600015B")]
		public PhysicsTransform get_physicsTransform() { }

		[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x600015E")]
		public Vector3 get_positionFrom() { }

		[Address(RVA = "0x3133A70", Offset = "0x3132E70", Length = "0xB")]
		[IsReadOnly]
		[Token(Token = "0x6000160")]
		public Quaternion get_rotationFrom() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x600015A")]
		public TransformWriteMode get_transformWriteMode() { }

		[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
		[Token(Token = "0x600015F")]
		public void set_positionFrom(Vector3 value) { }

		[Address(RVA = "0x3133A80", Offset = "0x3132E80", Length = "0x8")]
		[Token(Token = "0x6000161")]
		public void set_rotationFrom(Quaternion value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EE")]
	private readonly int m_Index1; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000EF")]
	private readonly ushort m_World0; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x40000F0")]
	private readonly ushort m_Generation; //Field offset: 0x6

	[Token(Token = "0x1700004D")]
	public object callbackTarget
	{
		[Address(RVA = "0x3128B90", Offset = "0x3127F90", Length = "0x37")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700004B")]
	public bool isValid
	{
		[Address(RVA = "0x3128BD0", Offset = "0x3127FD0", Length = "0x37")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700004C")]
	public BodyType type
	{
		[Address(RVA = "0x3128C10", Offset = "0x3128010", Length = "0x37")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x31287E0", Offset = "0x3127BE0", Length = "0x5E")]
	[Token(Token = "0x6000153")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3128840", Offset = "0x3127C40", Length = "0x20")]
	[Token(Token = "0x6000154")]
	public override bool Equals(PhysicsBody other) { }

	[Address(RVA = "0x3128B90", Offset = "0x3127F90", Length = "0x37")]
	[Token(Token = "0x6000158")]
	public object get_callbackTarget() { }

	[Address(RVA = "0x3128BD0", Offset = "0x3127FD0", Length = "0x37")]
	[Token(Token = "0x6000156")]
	public bool get_isValid() { }

	[Address(RVA = "0x3128C10", Offset = "0x3128010", Length = "0x37")]
	[Token(Token = "0x6000157")]
	public BodyType get_type() { }

	[Address(RVA = "0x3128860", Offset = "0x3127C60", Length = "0x7D")]
	[Token(Token = "0x6000155")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31288E0", Offset = "0x3127CE0", Length = "0x2A0")]
	[Token(Token = "0x6000152")]
	public virtual string ToString() { }

}

