namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006E")]
internal struct EdgeDictionary : IEdgeStore
{
	[Token(Token = "0x200006F")]
	private class EdgeComparer : IEqualityComparer<ShadowEdge>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002B4")]
		public EdgeComparer() { }

		[Address(RVA = "0x2D347B0", Offset = "0x2D33BB0", Length = "0x34")]
		[Token(Token = "0x60002B2")]
		public override bool Equals(ShadowEdge edge0, ShadowEdge edge1) { }

		[Address(RVA = "0x2D347F0", Offset = "0x2D33BF0", Length = "0x34")]
		[Token(Token = "0x60002B3")]
		public override int GetHashCode(ShadowEdge edge) { }

	}

	[Token(Token = "0x400026D")]
	private static Dictionary<ShadowEdge, Int32> m_EdgeDictionary; //Field offset: 0x0

	[Address(RVA = "0x2D34EA0", Offset = "0x2D342A0", Length = "0xB5")]
	[Token(Token = "0x60002B1")]
	private static EdgeDictionary() { }

	[Address(RVA = "0x2D34830", Offset = "0x2D33C30", Length = "0x665")]
	[Token(Token = "0x60002B0")]
	public override NativeArray<ShadowEdge> GetOutsideEdges(NativeArray<Vector3> vertices, NativeArray<Int32> indices) { }

}

