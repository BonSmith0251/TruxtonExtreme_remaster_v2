namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000042")]
public struct PhysicsChainDefinition
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000124")]
	private SurfaceMaterial m_SurfaceMaterial; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000125")]
	private ContactFilter m_ContactFilter; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000126")]
	private bool m_IsLoop; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000127")]
	private bool m_TriggerEvents; //Field offset: 0x39

	[Token(Token = "0x1700006C")]
	public static PhysicsChainDefinition defaultDefinition
	{
		[Address(RVA = "0x3128E20", Offset = "0x3128220", Length = "0x74")]
		[Token(Token = "0x6000189")]
		 get { } //Length: 116
	}

	[Address(RVA = "0x3128D20", Offset = "0x3128120", Length = "0x71")]
	[Token(Token = "0x6000187")]
	public PhysicsChainDefinition() { }

	[Address(RVA = "0x3128DA0", Offset = "0x31281A0", Length = "0x7F")]
	[Token(Token = "0x6000188")]
	public PhysicsChainDefinition(bool useSettings) { }

	[Address(RVA = "0x3128E20", Offset = "0x3128220", Length = "0x74")]
	[Token(Token = "0x6000189")]
	public static PhysicsChainDefinition get_defaultDefinition() { }

}

