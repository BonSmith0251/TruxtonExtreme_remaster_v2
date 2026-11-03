namespace UnityEngine.Splines;

[Token(Token = "0x2000058")]
public struct SplineComputeBufferScope : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000153")]
	private T m_Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000154")]
	private int m_KnotCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000155")]
	private ComputeBuffer m_CurveBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000156")]
	private ComputeBuffer m_LengthBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000157")]
	private ComputeShader m_Shader; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000158")]
	private string m_Info; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000159")]
	private string m_Curves; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015A")]
	private string m_CurveLengths; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015B")]
	private int m_Kernel; //Field offset: 0x0

	[Token(Token = "0x170000C0")]
	public ComputeBuffer CurveLengths
	{
		[Address(RVA = "0xFAD150", Offset = "0xFAC550", Length = "0x45")]
		[Token(Token = "0x6000306")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170000BF")]
	public ComputeBuffer Curves
	{
		[Address(RVA = "0xFAD1A0", Offset = "0xFAC5A0", Length = "0x45")]
		[Token(Token = "0x6000305")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170000BE")]
	public Vector4 Info
	{
		[Address(RVA = "0xFAD1F0", Offset = "0xFAC5F0", Length = "0x37B")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 891
	}

	[Address(RVA = "0xFACD40", Offset = "0xFAC140", Length = "0x401")]
	[Token(Token = "0x6000300")]
	public SplineComputeBufferScope`1(T spline) { }

	[Address(RVA = "0xFABC10", Offset = "0xFAB010", Length = "0x5FF")]
	[Token(Token = "0x6000301")]
	public void Bind(ComputeShader shader, int kernel, string info, string curves, string lengths) { }

	[Address(RVA = "0xFAC210", Offset = "0xFAB610", Length = "0x9F")]
	[Token(Token = "0x6000302")]
	public override void Dispose() { }

	[Address(RVA = "0xFAD150", Offset = "0xFAC550", Length = "0x45")]
	[Token(Token = "0x6000306")]
	public ComputeBuffer get_CurveLengths() { }

	[Address(RVA = "0xFAD1A0", Offset = "0xFAC5A0", Length = "0x45")]
	[Token(Token = "0x6000305")]
	public ComputeBuffer get_Curves() { }

	[Address(RVA = "0xFAD1F0", Offset = "0xFAC5F0", Length = "0x37B")]
	[Token(Token = "0x6000304")]
	public Vector4 get_Info() { }

	[Address(RVA = "0xFAC2B0", Offset = "0xFAB6B0", Length = "0xA88")]
	[Token(Token = "0x6000303")]
	public void Upload() { }

}

