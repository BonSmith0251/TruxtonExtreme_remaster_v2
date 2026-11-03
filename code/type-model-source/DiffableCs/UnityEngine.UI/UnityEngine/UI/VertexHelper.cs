namespace UnityEngine.UI;

[Token(Token = "0x2000081")]
public class VertexHelper : IDisposable
{
	[Token(Token = "0x400026D")]
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x0
	[Token(Token = "0x400026E")]
	private static readonly Vector3 s_DefaultNormal; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000264")]
	private List<Vector3> m_Positions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000265")]
	private List<Color32> m_Colors; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000266")]
	private List<Vector4> m_Uv0S; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000267")]
	private List<Vector4> m_Uv1S; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000268")]
	private List<Vector4> m_Uv2S; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000269")]
	private List<Vector4> m_Uv3S; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400026A")]
	private List<Vector3> m_Normals; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400026B")]
	private List<Vector4> m_Tangents; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400026C")]
	private List<Int32> m_Indices; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400026F")]
	private bool m_ListsInitalized; //Field offset: 0x58

	[Token(Token = "0x17000154")]
	public int currentIndexCount
	{
		[Address(RVA = "0x3461210", Offset = "0x3460610", Length = "0x41")]
		[Token(Token = "0x6000525")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000153")]
	public int currentVertCount
	{
		[Address(RVA = "0x3461260", Offset = "0x3460660", Length = "0x41")]
		[Token(Token = "0x6000524")]
		 get { } //Length: 65
	}

	[Address(RVA = "0x3460F40", Offset = "0x3460340", Length = "0x88")]
	[Token(Token = "0x6000532")]
	private static VertexHelper() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600051F")]
	public VertexHelper() { }

	[Address(RVA = "0x3460FD0", Offset = "0x34603D0", Length = "0x239")]
	[Token(Token = "0x6000520")]
	public VertexHelper(Mesh m) { }

	[Address(RVA = "0x345F5E0", Offset = "0x345E9E0", Length = "0x166")]
	[Token(Token = "0x600052D")]
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	[Address(RVA = "0x345F750", Offset = "0x345EB50", Length = "0x283")]
	[Token(Token = "0x600052E")]
	public void AddUIVertexQuad(UIVertex[] verts) { }

	[Address(RVA = "0x345F9E0", Offset = "0x345EDE0", Length = "0xBF")]
	[Token(Token = "0x600052F")]
	public void AddUIVertexStream(List<UIVertex> verts, List<Int32> indices) { }

	[Address(RVA = "0x345FAA0", Offset = "0x345EEA0", Length = "0x7A")]
	[Token(Token = "0x6000530")]
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	[Address(RVA = "0x345FF30", Offset = "0x345F330", Length = "0x43D")]
	[Token(Token = "0x6000529")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	[Address(RVA = "0x345FE80", Offset = "0x345F280", Length = "0xA8")]
	[Token(Token = "0x600052C")]
	public void AddVert(UIVertex v) { }

	[Address(RVA = "0x345FD10", Offset = "0x345F110", Length = "0x167")]
	[Token(Token = "0x600052A")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	[Address(RVA = "0x345FB20", Offset = "0x345EF20", Length = "0x1EF")]
	[Token(Token = "0x600052B")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	[Address(RVA = "0x3460370", Offset = "0x345F770", Length = "0xEB")]
	[Token(Token = "0x6000523")]
	public void Clear() { }

	[Address(RVA = "0x3460460", Offset = "0x345F860", Length = "0x210")]
	[Token(Token = "0x6000522")]
	public override void Dispose() { }

	[Address(RVA = "0x3460670", Offset = "0x345FA70", Length = "0x15F")]
	[Token(Token = "0x6000528")]
	public void FillMesh(Mesh mesh) { }

	[Address(RVA = "0x3461210", Offset = "0x3460610", Length = "0x41")]
	[Token(Token = "0x6000525")]
	public int get_currentIndexCount() { }

	[Address(RVA = "0x3461260", Offset = "0x3460660", Length = "0x41")]
	[Token(Token = "0x6000524")]
	public int get_currentVertCount() { }

	[Address(RVA = "0x34607D0", Offset = "0x345FBD0", Length = "0x7A")]
	[Token(Token = "0x6000531")]
	public void GetUIVertexStream(List<UIVertex> stream) { }

	[Address(RVA = "0x3460850", Offset = "0x345FC50", Length = "0x1DD")]
	[Token(Token = "0x6000521")]
	private void InitializeListIfRequired() { }

	[Address(RVA = "0x3460A30", Offset = "0x345FE30", Length = "0x1B8")]
	[Token(Token = "0x6000526")]
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	[Address(RVA = "0x3460BF0", Offset = "0x345FFF0", Length = "0x346")]
	[Token(Token = "0x6000527")]
	public void SetUIVertex(UIVertex vertex, int i) { }

}

