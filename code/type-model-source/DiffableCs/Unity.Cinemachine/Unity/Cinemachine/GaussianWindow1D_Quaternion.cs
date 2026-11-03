namespace Unity.Cinemachine;

[Token(Token = "0x20000BA")]
internal class GaussianWindow1D_Quaternion : GaussianWindow1d<Quaternion>
{

	[Address(RVA = "0x2845400", Offset = "0x2844800", Length = "0x58")]
	[Token(Token = "0x60003A8")]
	public GaussianWindow1D_Quaternion(float sigma, int maxKernelRadius = 10) { }

	[Address(RVA = "0x2844E80", Offset = "0x2844280", Length = "0x57E")]
	[Token(Token = "0x60003A9")]
	protected virtual Quaternion Compute(int windowPos) { }

}

