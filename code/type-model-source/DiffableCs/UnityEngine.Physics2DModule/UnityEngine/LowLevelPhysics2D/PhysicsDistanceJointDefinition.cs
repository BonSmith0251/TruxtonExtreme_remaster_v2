namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x200001C")]
public struct PhysicsDistanceJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400005E")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400005F")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000060")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000061")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Min(1E-45)]
	[SerializeField]
	[Token(Token = "0x4000062")]
	private float m_Distance; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000063")]
	private bool m_EnableSpring; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000064")]
	private float m_SpringFrequency; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000065")]
	private float m_SpringDamping; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000066")]
	private float m_SpringLowerForce; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000067")]
	private float m_SpringUpperForce; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000068")]
	private bool m_EnableMotor; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000069")]
	private float m_MotorSpeed; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400006A")]
	private float m_MaxMotorForce; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400006B")]
	private bool m_EnableLimit; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400006C")]
	private float m_MinDistanceLimit; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400006D")]
	private float m_MaxDistanceLimit; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400006E")]
	private float m_ForceThreshold; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400006F")]
	private float m_TorqueThreshold; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x4000070")]
	private float m_TuningFrequency; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x4000071")]
	private float m_TuningDamping; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x4000072")]
	private float m_DrawScale; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x4000073")]
	private bool m_CollideConnected; //Field offset: 0x74

	[Token(Token = "0x17000035")]
	public static PhysicsDistanceJointDefinition defaultDefinition
	{
		[Address(RVA = "0x3129030", Offset = "0x3128430", Length = "0xBD")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 189
	}

	[Address(RVA = "0x3128F70", Offset = "0x3128370", Length = "0xBA")]
	[Token(Token = "0x6000110")]
	public PhysicsDistanceJointDefinition() { }

	[Address(RVA = "0x3128EA0", Offset = "0x31282A0", Length = "0xCB")]
	[Token(Token = "0x6000111")]
	public PhysicsDistanceJointDefinition(bool useSettings) { }

	[Address(RVA = "0x3129030", Offset = "0x3128430", Length = "0xBD")]
	[Token(Token = "0x6000112")]
	public static PhysicsDistanceJointDefinition get_defaultDefinition() { }

}

