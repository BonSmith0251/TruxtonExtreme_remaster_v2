namespace Unity.Cinemachine;

[Token(Token = "0x20000BB")]
internal class GaussianWindow1D_CameraRotation : GaussianWindow1d<Vector2>
{

	[Address(RVA = "0x2844E20", Offset = "0x2844220", Length = "0x58")]
	[Token(Token = "0x60003AA")]
	public GaussianWindow1D_CameraRotation(float sigma, int maxKernelRadius = 10) { }

	[Address(RVA = "0x2844BE0", Offset = "0x2843FE0", Length = "0x238")]
	[Token(Token = "0x60003AB")]
	protected virtual Vector2 Compute(int windowPos) { }

}

