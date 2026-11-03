namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000022")]
public struct PhysicsSliderJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000B5")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40000B6")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000B7")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000B9")]
	private bool m_EnableSpring; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x40000BA")]
	private float m_SpringTargetTranslation; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000BB")]
	private float m_SpringFrequency; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	private float m_SpringDamping; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000BD")]
	private bool m_EnableMotor; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40000BE")]
	private float m_MotorSpeed; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000BF")]
	private float m_MaxMotorForce; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000C0")]
	private bool m_EnableLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000C1")]
	private float m_LowerTranslationLimit; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40000C2")]
	private float m_UpperTranslationLimit; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000C3")]
	private float m_ForceThreshold; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000C4")]
	private float m_TorqueThreshold; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x40000C5")]
	private float m_TuningFrequency; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x40000C6")]
	private float m_TuningDamping; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40000C7")]
	private float m_DrawScale; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x40000C8")]
	private bool m_CollideConnected; //Field offset: 0x6C

	[Token(Token = "0x1700003C")]
	public static PhysicsSliderJointDefinition defaultDefinition
	{
		[Address(RVA = "0x312F640", Offset = "0x312EA40", Length = "0xA2")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x312F5A0", Offset = "0x312E9A0", Length = "0x9F")]
	[Token(Token = "0x6000123")]
	public PhysicsSliderJointDefinition() { }

	[Address(RVA = "0x312F4F0", Offset = "0x312E8F0", Length = "0xB0")]
	[Token(Token = "0x6000124")]
	public PhysicsSliderJointDefinition(bool useSettings) { }

	[Address(RVA = "0x312F640", Offset = "0x312EA40", Length = "0xA2")]
	[Token(Token = "0x6000125")]
	public static PhysicsSliderJointDefinition get_defaultDefinition() { }

}

