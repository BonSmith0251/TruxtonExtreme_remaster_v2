namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x200005B")]
public struct PhysicsWorldDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001BB")]
	private Vector2 m_Gravity; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[FormerlySerializedAs("m_SimulationMode")]
	[SerializeField]
	[Token(Token = "0x40001BC")]
	private SimulationType m_SimulationType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Min(1)]
	[SerializeField]
	[Token(Token = "0x40001BD")]
	private int m_SimulationSubSteps; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Range(0, 64)]
	[SerializeField]
	[Token(Token = "0x40001BE")]
	private int m_SimulationWorkers; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40001BF")]
	private TransformWriteMode m_TransformWriteMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001C0")]
	private TransformPlane m_TransformPlane; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40001C1")]
	private bool m_TransformTweening; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[SerializeField]
	[Token(Token = "0x40001C2")]
	private bool m_SleepingAllowed; //Field offset: 0x1D
	[FieldOffset(Offset = "0x1E")]
	[SerializeField]
	[Token(Token = "0x40001C3")]
	private bool m_ContinuousAllowed; //Field offset: 0x1E
	[FieldOffset(Offset = "0x1F")]
	[SerializeField]
	[Token(Token = "0x40001C4")]
	private bool m_ContactFilterCallbacks; //Field offset: 0x1F
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001C5")]
	private bool m_PreSolveCallbacks; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	[Token(Token = "0x40001C6")]
	private bool m_AutoBodyUpdateCallbacks; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	[Token(Token = "0x40001C7")]
	private bool m_AutoContactCallbacks; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[SerializeField]
	[Token(Token = "0x40001C8")]
	private bool m_AutoTriggerCallbacks; //Field offset: 0x23
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40001C9")]
	private bool m_AutoJointThresholdCallbacks; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CA")]
	private float m_BounceThreshold; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CB")]
	private float m_ContactHitEventThreshold; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CC")]
	private float m_ContactFrequency; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CD")]
	private float m_ContactDamping; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CE")]
	private float m_ContactSpeed; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001CF")]
	private float m_MaximumLinearSpeed; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001D0")]
	private DrawOptions m_DrawOptions; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x40001D1")]
	private DrawFillOptions m_DrawFillOptions; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(1, 10)]
	[SerializeField]
	[Token(Token = "0x40001D2")]
	private float m_DrawThickness; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40001D3")]
	private float m_DrawFillAlpha; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40001D4")]
	private float m_DrawPointScale; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40001D5")]
	private float m_DrawNormalScale; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Range(0.001, 10)]
	[SerializeField]
	[Token(Token = "0x40001D6")]
	private float m_DrawImpulseScale; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40001D7")]
	private int m_DrawCapacity; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40001D8")]
	private DrawColors m_DrawColors; //Field offset: 0x60

	[Token(Token = "0x1700008B")]
	public static PhysicsWorldDefinition defaultDefinition
	{
		[Address(RVA = "0x312FD60", Offset = "0x312F160", Length = "0xD5")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 213
	}

	[Address(RVA = "0x312FC90", Offset = "0x312F090", Length = "0xC2")]
	[Token(Token = "0x60001CA")]
	public PhysicsWorldDefinition() { }

	[Address(RVA = "0x312FBB0", Offset = "0x312EFB0", Length = "0xDA")]
	[Token(Token = "0x60001CB")]
	public PhysicsWorldDefinition(bool useSettings) { }

	[Address(RVA = "0x312FD60", Offset = "0x312F160", Length = "0xD5")]
	[Token(Token = "0x60001CC")]
	public static PhysicsWorldDefinition get_defaultDefinition() { }

}

