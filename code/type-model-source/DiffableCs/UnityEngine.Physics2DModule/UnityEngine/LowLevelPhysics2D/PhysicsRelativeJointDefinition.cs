namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000021")]
public struct PhysicsRelativeJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40000A1")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40000A2")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000A3")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000A4")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000A5")]
	private Vector2 m_LinearVelocity; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000A6")]
	private float m_AngularVelocity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000A7")]
	private float m_MaxForce; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000A8")]
	private float m_MaxTorque; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000A9")]
	private float m_SpringLinearFrequency; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AA")]
	private float m_SpringAngularFrequency; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AB")]
	private float m_SpringLinearDamping; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AC")]
	private float m_SpringAngularDamping; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AD")]
	private float m_SpringMaxForce; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AE")]
	private float m_SpringMaxTorque; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000AF")]
	private float m_ForceThreshold; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40000B0")]
	private float m_TorqueThreshold; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x40000B1")]
	private float m_TuningFrequency; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x40000B2")]
	private float m_TuningDamping; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40000B3")]
	private float m_DrawScale; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40000B4")]
	private bool m_CollideConnected; //Field offset: 0x70

	[Token(Token = "0x1700003B")]
	public static PhysicsRelativeJointDefinition defaultDefinition
	{
		[Address(RVA = "0x312D660", Offset = "0x312CA60", Length = "0xBD")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 189
	}

	[Address(RVA = "0x312D4D0", Offset = "0x312C8D0", Length = "0xBA")]
	[Token(Token = "0x6000120")]
	public PhysicsRelativeJointDefinition() { }

	[Address(RVA = "0x312D590", Offset = "0x312C990", Length = "0xC7")]
	[Token(Token = "0x6000121")]
	public PhysicsRelativeJointDefinition(bool useSettings) { }

	[Address(RVA = "0x312D660", Offset = "0x312CA60", Length = "0xBD")]
	[Token(Token = "0x6000122")]
	public static PhysicsRelativeJointDefinition get_defaultDefinition() { }

}

