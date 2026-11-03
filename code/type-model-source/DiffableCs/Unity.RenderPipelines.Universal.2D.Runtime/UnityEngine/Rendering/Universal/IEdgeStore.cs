namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000070")]
internal interface IEdgeStore
{

	[Token(Token = "0x60002B5")]
	public NativeArray<ShadowEdge> GetOutsideEdges(NativeArray<Vector3> vertices, NativeArray<Int32> indices) { }

}

