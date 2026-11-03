namespace Unity.Mathematics.Geometry;

[DebuggerDisplay("{Normal}, {Distance}")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000065")]
public struct Plane
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400017D")]
	public float4 NormalAndDistance; //Field offset: 0x0

	[Token(Token = "0x17000B90")]
	public float Distance
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x60024CB")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x60024CC")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000B91")]
	public Plane Flipped
	{
		[Address(RVA = "0x2A98350", Offset = "0x2A97750", Length = "0x57")]
		[Token(Token = "0x60024D1")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000B8F")]
	public float3 Normal
	{
		[Address(RVA = "0x2A983B0", Offset = "0x2A977B0", Length = "0x1E")]
		[Token(Token = "0x60024C9")]
		 get { } //Length: 30
		[Address(RVA = "0x2A983D0", Offset = "0x2A977D0", Length = "0x27")]
		[Token(Token = "0x60024CA")]
		 set { } //Length: 39
	}

	[Address(RVA = "0x2A982B0", Offset = "0x2A976B0", Length = "0x9C")]
	[Token(Token = "0x60024C3")]
	public Plane(float coefficientA, float coefficientB, float coefficientC, float coefficientD) { }

	[Address(RVA = "0x2A95F80", Offset = "0x2A95380", Length = "0xBB")]
	[Token(Token = "0x60024C4")]
	public Plane(float3 normal, float distance) { }

	[Address(RVA = "0x2A98160", Offset = "0x2A97560", Length = "0x5C")]
	[Token(Token = "0x60024C5")]
	public Plane(float3 normal, float3 pointInPlane) { }

	[Address(RVA = "0x2A981C0", Offset = "0x2A975C0", Length = "0xE4")]
	[Token(Token = "0x60024C6")]
	public Plane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane) { }

	[Address(RVA = "0x2A97DD0", Offset = "0x2A971D0", Length = "0x93")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60024D3")]
	private void CheckPlaneIsNormalized() { }

	[Address(RVA = "0x2A97E70", Offset = "0x2A97270", Length = "0x3B")]
	[Token(Token = "0x60024C7")]
	public static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance) { }

	[Address(RVA = "0x2A97EB0", Offset = "0x2A972B0", Length = "0x7C")]
	[Token(Token = "0x60024C8")]
	public static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane) { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x60024CB")]
	public float get_Distance() { }

	[Address(RVA = "0x2A98350", Offset = "0x2A97750", Length = "0x57")]
	[Token(Token = "0x60024D1")]
	public Plane get_Flipped() { }

	[Address(RVA = "0x2A983B0", Offset = "0x2A977B0", Length = "0x1E")]
	[Token(Token = "0x60024C9")]
	public float3 get_Normal() { }

	[Address(RVA = "0x2A97F30", Offset = "0x2A97330", Length = "0xB1")]
	[Token(Token = "0x60024CD")]
	public static Plane Normalize(Plane plane) { }

	[Address(RVA = "0x2A97FF0", Offset = "0x2A973F0", Length = "0x8E")]
	[Token(Token = "0x60024CE")]
	public static float4 Normalize(float4 planeCoefficients) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x60024D2")]
	public static float4 op_Implicit(Plane plane) { }

	[Address(RVA = "0x2A98080", Offset = "0x2A97480", Length = "0x87")]
	[Token(Token = "0x60024D0")]
	public float3 Projection(float3 point) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x60024CC")]
	public void set_Distance(float value) { }

	[Address(RVA = "0x2A983D0", Offset = "0x2A977D0", Length = "0x27")]
	[Token(Token = "0x60024CA")]
	public void set_Normal(float3 value) { }

	[Address(RVA = "0x2A98110", Offset = "0x2A97510", Length = "0x48")]
	[Token(Token = "0x60024CF")]
	public float SignedDistanceToPoint(float3 point) { }

}

