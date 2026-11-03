namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000004")]
internal class AABB
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	public float3 Min; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000007")]
	public float3 Max; //Field offset: 0x1C

	[Address(RVA = "0x2F4ACB0", Offset = "0x2F4A0B0", Length = "0x46")]
	[Token(Token = "0x6000003")]
	public AABB() { }

	[Address(RVA = "0x2F4AD00", Offset = "0x2F4A100", Length = "0x4D")]
	[Token(Token = "0x6000004")]
	public AABB(float3 min, float3 max) { }

	[Address(RVA = "0x2F4A9D0", Offset = "0x2F49DD0", Length = "0x5D")]
	[Token(Token = "0x6000007")]
	public bool Contains(AABB rhs) { }

	[Address(RVA = "0x2F4AA30", Offset = "0x2F49E30", Length = "0x123")]
	[Token(Token = "0x6000005")]
	public void Encapsulate(AABB aabb) { }

	[Address(RVA = "0x2F4AB60", Offset = "0x2F49F60", Length = "0x111")]
	[Token(Token = "0x6000006")]
	public void Encapsulate(float3 point) { }

	[Address(RVA = "0x2F4AC80", Offset = "0x2F4A080", Length = "0x26")]
	[Token(Token = "0x6000008")]
	public bool IsValid() { }

}

