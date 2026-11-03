namespace Unity.Cinemachine;

[Token(Token = "0x20000DA")]
public struct PositionPredictor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400034A")]
	private Vector3 m_Velocity; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400034B")]
	private Vector3 m_SmoothDampVelocity; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400034C")]
	private Vector3 m_Pos; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400034D")]
	private bool m_HavePos; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400034E")]
	public float Smoothing; //Field offset: 0x28

	[Token(Token = "0x170000DD")]
	public Vector3 CurrentPosition
	{
		[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
		[Token(Token = "0x60003FD")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170000DC")]
	public bool IsEmpty
	{
		[Address(RVA = "0x1F6B0F0", Offset = "0x1F6A4F0", Length = "0x8")]
		[Token(Token = "0x60003FC")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2847770", Offset = "0x2846B70", Length = "0x1B8")]
	[Token(Token = "0x6000401")]
	public void AddPosition(Vector3 pos, float deltaTime) { }

	[Address(RVA = "0x2847930", Offset = "0x2846D30", Length = "0x99")]
	[Token(Token = "0x60003FF")]
	public void ApplyRotationDelta(Quaternion rotationDelta) { }

	[Address(RVA = "0x28479D0", Offset = "0x2846DD0", Length = "0x3D")]
	[Token(Token = "0x60003FE")]
	public void ApplyTransformDelta(Vector3 positionDelta) { }

	[Address(RVA = "0x1410A50", Offset = "0x140FE50", Length = "0x13")]
	[Token(Token = "0x60003FD")]
	public Vector3 get_CurrentPosition() { }

	[Address(RVA = "0x1F6B0F0", Offset = "0x1F6A4F0", Length = "0x8")]
	[Token(Token = "0x60003FC")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x2847A10", Offset = "0x2846E10", Length = "0x35")]
	[Token(Token = "0x6000402")]
	public Vector3 PredictPositionDelta(float lookaheadTime) { }

	[Address(RVA = "0x2847A50", Offset = "0x2846E50", Length = "0x84")]
	[Token(Token = "0x6000400")]
	public void Reset() { }

}

