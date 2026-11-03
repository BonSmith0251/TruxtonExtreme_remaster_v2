namespace UnityEngine.Rendering;

[Token(Token = "0x2000006")]
internal struct AABB
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public float3 center; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000007")]
	public float3 extents; //Field offset: 0xC

	[Token(Token = "0x17000002")]
	public float3 max
	{
		[Address(RVA = "0x2CC0A10", Offset = "0x2CBFE10", Length = "0x3F")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000001")]
	public float3 min
	{
		[Address(RVA = "0x2CC0A50", Offset = "0x2CBFE50", Length = "0x3F")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 63
	}

	[Address(RVA = "0x2CC0A10", Offset = "0x2CBFE10", Length = "0x3F")]
	[Token(Token = "0x6000006")]
	public float3 get_max() { }

	[Address(RVA = "0x2CC0A50", Offset = "0x2CBFE50", Length = "0x3F")]
	[Token(Token = "0x6000005")]
	public float3 get_min() { }

	[Address(RVA = "0x2CC05B0", Offset = "0x2CBF9B0", Length = "0x15E")]
	[Token(Token = "0x6000008")]
	private static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2) { }

	[Address(RVA = "0x2CC0710", Offset = "0x2CBFB10", Length = "0x9D")]
	[Token(Token = "0x6000007")]
	public virtual string ToString() { }

	[Address(RVA = "0x2CC07B0", Offset = "0x2CBFBB0", Length = "0x259")]
	[Token(Token = "0x6000009")]
	public static AABB Transform(float4x4 transform, AABB localBounds) { }

}

