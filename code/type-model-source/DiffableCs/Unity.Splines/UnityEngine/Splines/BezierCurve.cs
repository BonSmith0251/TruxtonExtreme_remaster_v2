namespace UnityEngine.Splines;

[Token(Token = "0x2000005")]
public struct BezierCurve : IEquatable<BezierCurve>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public float3 P0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000007")]
	public float3 P1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000008")]
	public float3 P2; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000009")]
	public float3 P3; //Field offset: 0x24

	[Token(Token = "0x17000001")]
	public float3 Tangent0
	{
		[Address(RVA = "0x2A97CA0", Offset = "0x2A970A0", Length = "0x3F")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 63
		[Address(RVA = "0x2E549A0", Offset = "0x2E53DA0", Length = "0x3C")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 60
	}

	[Token(Token = "0x17000002")]
	public float3 Tangent1
	{
		[Address(RVA = "0x2E548F0", Offset = "0x2E53CF0", Length = "0x40")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 64
		[Address(RVA = "0x2E549E0", Offset = "0x2E53DE0", Length = "0x3D")]
		[Token(Token = "0x600000B")]
		 set { } //Length: 61
	}

	[Address(RVA = "0x2E544E0", Offset = "0x2E538E0", Length = "0x30")]
	[Token(Token = "0x600000C")]
	public BezierCurve(float3 p0, float3 p1) { }

	[Address(RVA = "0x2E54810", Offset = "0x2E53C10", Length = "0xD2")]
	[Token(Token = "0x600000D")]
	public BezierCurve(float3 p0, float3 p1, float3 p2) { }

	[Address(RVA = "0x2A86E40", Offset = "0x2A86240", Length = "0x45")]
	[Token(Token = "0x600000E")]
	public BezierCurve(float3 p0, float3 p1, float3 p2, float3 p3) { }

	[Address(RVA = "0x2E54510", Offset = "0x2E53910", Length = "0x2FB")]
	[Token(Token = "0x600000F")]
	public BezierCurve(BezierKnot a, BezierKnot b) { }

	[Address(RVA = "0x2ACA3E0", Offset = "0x2AC97E0", Length = "0xB30")]
	[Token(Token = "0x6000013")]
	public override bool Equals(BezierCurve other) { }

	[Address(RVA = "0x2E53E30", Offset = "0x2E53230", Length = "0xA2")]
	[Token(Token = "0x6000014")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E53EE0", Offset = "0x2E532E0", Length = "0xAB")]
	[Token(Token = "0x6000011")]
	public static BezierCurve FromTangent(float3 pointA, float3 tangentOutA, float3 pointB, float3 tangentInB) { }

	[Address(RVA = "0x2A97CA0", Offset = "0x2A970A0", Length = "0x3F")]
	[Token(Token = "0x6000008")]
	public float3 get_Tangent0() { }

	[Address(RVA = "0x2E548F0", Offset = "0x2E53CF0", Length = "0x40")]
	[Token(Token = "0x600000A")]
	public float3 get_Tangent1() { }

	[Address(RVA = "0x2E53F90", Offset = "0x2E53390", Length = "0x117")]
	[Token(Token = "0x6000015")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2E540B0", Offset = "0x2E534B0", Length = "0x42")]
	[Token(Token = "0x6000012")]
	public BezierCurve GetInvertedCurve() { }

	[Address(RVA = "0x2E54930", Offset = "0x2E53D30", Length = "0x30")]
	[Token(Token = "0x6000016")]
	public static bool op_Equality(BezierCurve left, BezierCurve right) { }

	[Address(RVA = "0x2E54960", Offset = "0x2E53D60", Length = "0x32")]
	[Token(Token = "0x6000017")]
	public static bool op_Inequality(BezierCurve left, BezierCurve right) { }

	[Address(RVA = "0x2E549A0", Offset = "0x2E53DA0", Length = "0x3C")]
	[Token(Token = "0x6000009")]
	public void set_Tangent0(float3 value) { }

	[Address(RVA = "0x2E549E0", Offset = "0x2E53DE0", Length = "0x3D")]
	[Token(Token = "0x600000B")]
	public void set_Tangent1(float3 value) { }

	[Address(RVA = "0x2E54100", Offset = "0x2E53500", Length = "0x3DD")]
	[Token(Token = "0x6000010")]
	public BezierCurve Transform(float4x4 matrix) { }

}

