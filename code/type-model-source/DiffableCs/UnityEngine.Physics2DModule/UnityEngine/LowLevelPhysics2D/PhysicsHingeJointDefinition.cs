namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x200001E")]
public struct PhysicsHingeJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000082")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private bool m_EnableSpring; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private float m_SpringTargetAngle; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000088")]
	private float m_SpringFrequency; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000089")]
	private float m_SpringDamping; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400008A")]
	private bool m_EnableMotor; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400008B")]
	private float m_MotorSpeed; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private float m_MaxMotorTorque; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400008D")]
	private bool m_EnableLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(-178, 178)]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private float m_LowerAngleLimit; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(-178, 178)]
	[SerializeField]
	[Token(Token = "0x400008F")]
	private float m_UpperAngleLimit; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000090")]
	private float m_ForceThreshold; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private float m_TorqueThreshold; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private float m_TuningFrequency; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private float m_TuningDamping; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private float m_DrawScale; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000095")]
	private bool m_CollideConnected; //Field offset: 0x6C

	[Token(Token = "0x17000037")]
	public static PhysicsHingeJointDefinition defaultDefinition
	{
		[Address(RVA = "0x31297E0", Offset = "0x3128BE0", Length = "0xA2")]
		[Token(Token = "0x6000118")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x3129690", Offset = "0x3128A90", Length = "0x9F")]
	[Token(Token = "0x6000116")]
	public PhysicsHingeJointDefinition() { }

	[Address(RVA = "0x3129730", Offset = "0x3128B30", Length = "0xB0")]
	[Token(Token = "0x6000117")]
	public PhysicsHingeJointDefinition(bool useSettings) { }

	[Address(RVA = "0x31297E0", Offset = "0x3128BE0", Length = "0xA2")]
	[Token(Token = "0x6000118")]
	public static PhysicsHingeJointDefinition get_defaultDefinition() { }

}

