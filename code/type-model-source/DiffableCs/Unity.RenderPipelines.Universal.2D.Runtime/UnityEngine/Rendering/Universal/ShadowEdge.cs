namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000074")]
internal struct ShadowEdge
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400027D")]
	public int v0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400027E")]
	public int v1; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60002CD")]
	public ShadowEdge(int indexA, int indexB) { }

	[Address(RVA = "0x2D3DED0", Offset = "0x2D3D2D0", Length = "0xB")]
	[Token(Token = "0x60002CE")]
	public void Reverse() { }

}

