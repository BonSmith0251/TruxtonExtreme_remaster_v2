namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x200005C")]
public struct PhysicsShape : IEquatable<PhysicsShape>
{
	[Token(Token = "0x2000061")]
	internal struct ContactFilter
	{
		[Token(Token = "0x40001F5")]
		public static PhysicsMask DefaultCategories; //Field offset: 0x0
		[Token(Token = "0x40001F6")]
		public static PhysicsMask DefaultContacts; //Field offset: 0x8
		[Token(Token = "0x40001F7")]
		public static ContactFilter Everything; //Field offset: 0x10
		[Token(Token = "0x40001F8")]
		public static ContactFilter defaultFilter; //Field offset: 0x28
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x40001F9")]
		internal PhysicsMask m_Categories; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x40001FA")]
		internal PhysicsMask m_Contacts; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x40001FB")]
		internal int m_GroupIndex; //Field offset: 0x10

		[Address(RVA = "0x3124E80", Offset = "0x3124280", Length = "0x10E")]
		[Token(Token = "0x60001D9")]
		private static ContactFilter() { }

		[Address(RVA = "0x3124F90", Offset = "0x3124390", Length = "0xC")]
		[Token(Token = "0x60001D8")]
		public ContactFilter(PhysicsMask categories, PhysicsMask contacts, int groupIndex = 0) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000060")]
	internal struct ContactId
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F1")]
		private readonly int m_IndexId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001F2")]
		private readonly ushort m_WorldId; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40001F3")]
		private readonly ushort m_Padding; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001F4")]
		private readonly int m_GenerationId; //Field offset: 0x8

		[Token(Token = "0x17000090")]
		public bool isValid
		{
			[Address(RVA = "0x31250B0", Offset = "0x31244B0", Length = "0x40")]
			[Token(Token = "0x60001D7")]
			 get { } //Length: 64
		}

		[Address(RVA = "0x31250B0", Offset = "0x31244B0", Length = "0x40")]
		[Token(Token = "0x60001D7")]
		public bool get_isValid() { }

		[Address(RVA = "0x3124FA0", Offset = "0x31243A0", Length = "0x104")]
		[Token(Token = "0x60001D6")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000062")]
	internal struct MoverData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FC")]
		private float m_PushLimit; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001FD")]
		private bool m_ClipVelocity; //Field offset: 0x4

		[Address(RVA = "0x3126B70", Offset = "0x3125F70", Length = "0xB")]
		[Token(Token = "0x60001DA")]
		public MoverData() { }

	}

	[Token(Token = "0x200005F")]
	internal enum ShapeType : int
	{
		Circle = 0,
		Capsule = 1,
		Segment = 2,
		Polygon = 3,
		ChainSegment = 4,
	}

	[Token(Token = "0x200005D")]
	internal struct SurfaceMaterial
	{
		[Token(Token = "0x200005E")]
		internal enum MixingMode : int
		{
			Average = 0,
			Mean = 1,
			Multiply = 2,
			Minimum = 3,
			Maximum = 4,
		}

		[FieldOffset(Offset = "0x0")]
		[Min(0)]
		[SerializeField]
		[Token(Token = "0x40001DC")]
		private float m_Friction; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Min(0)]
		[SerializeField]
		[Token(Token = "0x40001DD")]
		private float m_Bounciness; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_FrictionCombine")]
		[SerializeField]
		[Token(Token = "0x40001DE")]
		private MixingMode m_FrictionMixing; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[FormerlySerializedAs("m_BouncinessCombine")]
		[SerializeField]
		[Token(Token = "0x40001DF")]
		private MixingMode m_BouncinessMixing; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Range(0, 65535)]
		[SerializeField]
		[Token(Token = "0x40001E0")]
		private ushort m_FrictionPriority; //Field offset: 0x10
		[FieldOffset(Offset = "0x12")]
		[Range(0, 65535)]
		[SerializeField]
		[Token(Token = "0x40001E1")]
		private ushort m_BouncinessPriority; //Field offset: 0x12
		[FieldOffset(Offset = "0x14")]
		[Min(0)]
		[SerializeField]
		[Token(Token = "0x40001E2")]
		private float m_RollingResistance; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x40001E3")]
		private float m_TangentSpeed; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x40001E4")]
		private Color32 m_CustomColor; //Field offset: 0x1C

		[Token(Token = "0x1700008F")]
		public static SurfaceMaterial Default
		{
			[Address(RVA = "0x3133A10", Offset = "0x3132E10", Length = "0x56")]
			[Token(Token = "0x60001D5")]
			 get { } //Length: 86
		}

		[Address(RVA = "0x31339B0", Offset = "0x3132DB0", Length = "0x53")]
		[Token(Token = "0x60001D4")]
		public SurfaceMaterial() { }

		[Address(RVA = "0x3133A10", Offset = "0x3132E10", Length = "0x56")]
		[Token(Token = "0x60001D5")]
		public static SurfaceMaterial get_Default() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D9")]
	private readonly int m_Index1; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001DA")]
	private readonly ushort m_World0; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x40001DB")]
	private readonly ushort m_Generation; //Field offset: 0x6

	[Token(Token = "0x1700008E")]
	public object callbackTarget
	{
		[Address(RVA = "0x312F430", Offset = "0x312E830", Length = "0x37")]
		[Token(Token = "0x60001D3")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700008C")]
	public bool isValid
	{
		[Address(RVA = "0x312F470", Offset = "0x312E870", Length = "0x37")]
		[Token(Token = "0x60001D1")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700008D")]
	public ShapeType shapeType
	{
		[Address(RVA = "0x312F4B0", Offset = "0x312E8B0", Length = "0x37")]
		[Token(Token = "0x60001D2")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x312F0A0", Offset = "0x312E4A0", Length = "0x5E")]
	[Token(Token = "0x60001CE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3128840", Offset = "0x3127C40", Length = "0x20")]
	[Token(Token = "0x60001CF")]
	public override bool Equals(PhysicsShape other) { }

	[Address(RVA = "0x312F430", Offset = "0x312E830", Length = "0x37")]
	[Token(Token = "0x60001D3")]
	public object get_callbackTarget() { }

	[Address(RVA = "0x312F470", Offset = "0x312E870", Length = "0x37")]
	[Token(Token = "0x60001D1")]
	public bool get_isValid() { }

	[Address(RVA = "0x312F4B0", Offset = "0x312E8B0", Length = "0x37")]
	[Token(Token = "0x60001D2")]
	public ShapeType get_shapeType() { }

	[Address(RVA = "0x312F100", Offset = "0x312E500", Length = "0x7D")]
	[Token(Token = "0x60001D0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x312F180", Offset = "0x312E580", Length = "0x2A0")]
	[Token(Token = "0x60001CD")]
	public virtual string ToString() { }

}

