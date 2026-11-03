namespace UnityEngine.Rendering;

[Token(Token = "0x20000CE")]
internal struct OcclusionTestComputeShader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BA")]
	public ComputeShader cs; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003BB")]
	public LocalKeyword occlusionDebugKeyword; //Field offset: 0x8

	[Address(RVA = "0x2CFD8D0", Offset = "0x2CFCCD0", Length = "0x8A")]
	[Token(Token = "0x6000355")]
	public void Init(ComputeShader cs) { }

}

