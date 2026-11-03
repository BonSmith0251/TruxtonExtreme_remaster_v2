//Type is in global namespace

[Token(Token = "0x2000003")]
internal struct VertexDictionary
{
	[Token(Token = "0x4000001")]
	private static Dictionary<Vector3, Int32> m_VertexDictionary; //Field offset: 0x0

	[Address(RVA = "0x2D19160", Offset = "0x2D18560", Length = "0x1AF")]
	[Token(Token = "0x6000004")]
	private static VertexDictionary() { }

	[Address(RVA = "0x2D18E40", Offset = "0x2D18240", Length = "0x311")]
	[Token(Token = "0x6000003")]
	public NativeArray<Int32> GetIndexRemap(NativeArray<Vector3> vertices, NativeArray<Int32> indices) { }

}

