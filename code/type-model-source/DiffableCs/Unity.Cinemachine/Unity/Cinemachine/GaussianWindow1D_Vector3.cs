namespace Unity.Cinemachine;

[Token(Token = "0x20000B9")]
internal class GaussianWindow1D_Vector3 : GaussianWindow1d<Vector3>
{

	[Address(RVA = "0x2845610", Offset = "0x2844A10", Length = "0x58")]
	[Token(Token = "0x60003A6")]
	public GaussianWindow1D_Vector3(float sigma, int maxKernelRadius = 10) { }

	[Address(RVA = "0x2845460", Offset = "0x2844860", Length = "0x1A0")]
	[Token(Token = "0x60003A7")]
	protected virtual Vector3 Compute(int windowPos) { }

}

