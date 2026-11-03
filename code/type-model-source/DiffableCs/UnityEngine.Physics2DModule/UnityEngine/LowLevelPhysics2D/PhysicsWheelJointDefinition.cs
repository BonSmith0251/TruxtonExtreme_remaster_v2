namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000023")]
public struct PhysicsWheelJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000C9")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40000CA")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000CD")]
	private bool m_EnableSpring; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000CE")]
	private float m_SpringFrequency; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	private float m_SpringDamping; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	private bool m_EnableMotor; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	private float m_MotorSpeed; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	private float m_MaxMotorTorque; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	private bool m_EnableLimit; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	private float m_LowerTranslationLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	private float m_UpperTranslationLimit; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	private float m_ForceThreshold; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	private float m_TorqueThreshold; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	private float m_TuningFrequency; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	private float m_TuningDamping; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	private float m_DrawScale; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private bool m_CollideConnected; //Field offset: 0x68

	[Token(Token = "0x1700003D")]
	public static PhysicsWheelJointDefinition defaultDefinition
	{
		[Address(RVA = "0x312FAF0", Offset = "0x312EEF0", Length = "0xBA")]
		[Token(Token = "0x6000128")]
		 get { } //Length: 186
	}

	[Address(RVA = "0x312FA30", Offset = "0x312EE30", Length = "0xB7")]
	[Token(Token = "0x6000126")]
	public PhysicsWheelJointDefinition() { }

	[Address(RVA = "0x312F960", Offset = "0x312ED60", Length = "0xC8")]
	[Token(Token = "0x6000127")]
	public PhysicsWheelJointDefinition(bool useSettings) { }

	[Address(RVA = "0x312FAF0", Offset = "0x312EEF0", Length = "0xBA")]
	[Token(Token = "0x6000128")]
	public static PhysicsWheelJointDefinition get_defaultDefinition() { }

}

