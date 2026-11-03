namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x200001D")]
public struct PhysicsFixedJointDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000074")]
	private PhysicsBody m_BodyA; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000075")]
	private PhysicsBody m_BodyB; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000076")]
	private PhysicsTransform m_LocalAnchorA; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000077")]
	private PhysicsTransform m_LocalAnchorB; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000078")]
	private float m_LinearFrequency; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000079")]
	private float m_LinearDamping; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400007A")]
	private float m_AngularFrequency; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400007B")]
	private float m_AngularDamping; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400007C")]
	private float m_ForceThreshold; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400007D")]
	private float m_TorqueThreshold; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(0, 1000)]
	[SerializeField]
	[Token(Token = "0x400007E")]
	private float m_TuningFrequency; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x400007F")]
	private float m_TuningDamping; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x4000080")]
	private float m_DrawScale; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000081")]
	private bool m_CollideConnected; //Field offset: 0x54

	[Token(Token = "0x17000036")]
	public static PhysicsFixedJointDefinition defaultDefinition
	{
		[Address(RVA = "0x31295F0", Offset = "0x31289F0", Length = "0x9A")]
		[Token(Token = "0x6000115")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x31294A0", Offset = "0x31288A0", Length = "0x97")]
	[Token(Token = "0x6000113")]
	public PhysicsFixedJointDefinition() { }

	[Address(RVA = "0x3129540", Offset = "0x3128940", Length = "0xA8")]
	[Token(Token = "0x6000114")]
	public PhysicsFixedJointDefinition(bool useSettings) { }

	[Address(RVA = "0x31295F0", Offset = "0x31289F0", Length = "0x9A")]
	[Token(Token = "0x6000115")]
	public static PhysicsFixedJointDefinition get_defaultDefinition() { }

}

