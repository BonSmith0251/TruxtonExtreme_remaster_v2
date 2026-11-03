namespace Unity.Cinemachine;

[Token(Token = "0x20000CA")]
public struct DefaultInputAxisDriver
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000302")]
	private float m_CurrentSpeed; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000303")]
	[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
	public float AccelTime; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000304")]
	[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
	public float DecelTime; //Field offset: 0x8

	[Token(Token = "0x170000D5")]
	public static DefaultInputAxisDriver Default
	{
		[Address(RVA = "0x2844970", Offset = "0x2843D70", Length = "0x18")]
		[Token(Token = "0x60003CE")]
		 get { } //Length: 24
	}

	[Address(RVA = "0x2844970", Offset = "0x2843D70", Length = "0x18")]
	[Token(Token = "0x60003CE")]
	public static DefaultInputAxisDriver get_Default() { }

	[Address(RVA = "0x2844670", Offset = "0x2843A70", Length = "0x280")]
	[Token(Token = "0x60003CF")]
	public void ProcessInput(ref InputAxis axis, float inputValue, float deltaTime) { }

	[Address(RVA = "0x28448F0", Offset = "0x2843CF0", Length = "0x60")]
	[Token(Token = "0x60003D0")]
	public void Reset(ref InputAxis axis) { }

	[Address(RVA = "0x2844950", Offset = "0x2843D50", Length = "0x1D")]
	[Token(Token = "0x60003CD")]
	public void Validate() { }

}

