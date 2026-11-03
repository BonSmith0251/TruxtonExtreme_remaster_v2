namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000030")]
public struct PhysicsBodyDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000108")]
	private BodyType m_BodyType; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x4000109")]
	private BodyConstraints m_BodyConstraints; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400010A")]
	private TransformWriteMode m_TransformWriteMode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x400010B")]
	private Vector2 m_Position; //Field offset: 0xC
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x400010C")]
	private PhysicsRotate m_Rotation; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x400010D")]
	private Vector2 m_LinearVelocity; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400010E")]
	private float m_AngularVelocity; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400010F")]
	private float m_LinearDamping; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000110")]
	private float m_AngularDamping; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000111")]
	private float m_GravityScale; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000112")]
	private float m_SleepThreshold; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000113")]
	private bool m_FastRotationAllowed; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000114")]
	private bool m_FastCollisionsAllowed; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private bool m_SleepingAllowed; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[SerializeField]
	[Token(Token = "0x4000116")]
	private bool m_Awake; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000117")]
	private bool m_Enabled; //Field offset: 0x3C

	[Token(Token = "0x17000055")]
	public static PhysicsBodyDefinition defaultDefinition
	{
		[Address(RVA = "0x3128760", Offset = "0x3127B60", Length = "0x74")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 116
	}

	[Address(RVA = "0x3128660", Offset = "0x3127A60", Length = "0x71")]
	[Token(Token = "0x6000162")]
	public PhysicsBodyDefinition() { }

	[Address(RVA = "0x31286E0", Offset = "0x3127AE0", Length = "0x7F")]
	[Token(Token = "0x6000163")]
	public PhysicsBodyDefinition(bool useSettings) { }

	[Address(RVA = "0x3128760", Offset = "0x3127B60", Length = "0x74")]
	[Token(Token = "0x6000164")]
	public static PhysicsBodyDefinition get_defaultDefinition() { }

}

