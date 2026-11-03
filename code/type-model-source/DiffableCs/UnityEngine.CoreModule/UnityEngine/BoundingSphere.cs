namespace UnityEngine;

[Token(Token = "0x20000AE")]
public struct BoundingSphere
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000202")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000203")]
	public float radius; //Field offset: 0xC

	[Address(RVA = "0x2FCEFD0", Offset = "0x2FCE3D0", Length = "0x14")]
	[Token(Token = "0x6000479")]
	public BoundingSphere(Vector3 pos, float rad) { }

}

