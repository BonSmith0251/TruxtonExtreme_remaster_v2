namespace UnityEngine.LowLevelPhysics2D;

[Token(Token = "0x2000068")]
public struct PhysicsShapeDefinition
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020A")]
	public SurfaceMaterial surfaceMaterial; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400020B")]
	public ContactFilter contactFilter; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400020C")]
	public MoverData moverData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x400020D")]
	private float m_Density; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400020E")]
	private bool m_IsTrigger; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	[Token(Token = "0x400020F")]
	private bool m_TriggerEvents; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	[Token(Token = "0x4000210")]
	private bool m_ContactEvents; //Field offset: 0x46
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	[Token(Token = "0x4000211")]
	private bool m_HitEvents; //Field offset: 0x47
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000212")]
	private bool m_ContactFilterCallbacks; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	[Token(Token = "0x4000213")]
	private bool m_PreSolveCallbacks; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[SerializeField]
	[Token(Token = "0x4000214")]
	private bool m_StartStaticContacts; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[SerializeField]
	[Token(Token = "0x4000215")]
	private bool m_StartMassUpdate; //Field offset: 0x4B

	[Token(Token = "0x17000091")]
	public static PhysicsShapeDefinition defaultDefinition
	{
		[Address(RVA = "0x312ED90", Offset = "0x312E190", Length = "0x82")]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 130
	}

	[Address(RVA = "0x312EC80", Offset = "0x312E080", Length = "0x7F")]
	[Token(Token = "0x60001EB")]
	public PhysicsShapeDefinition() { }

	[Address(RVA = "0x312ED00", Offset = "0x312E100", Length = "0x90")]
	[Token(Token = "0x60001EC")]
	public PhysicsShapeDefinition(bool useSettings) { }

	[Address(RVA = "0x312ED90", Offset = "0x312E190", Length = "0x82")]
	[Token(Token = "0x60001ED")]
	public static PhysicsShapeDefinition get_defaultDefinition() { }

}

