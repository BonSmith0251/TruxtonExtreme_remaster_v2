namespace UnityEngine.Rendering;

[Token(Token = "0x20001E4")]
internal class MeshGizmo : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20001E5")]
	private struct <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000950")]
		public MeshGizmo <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000951")]
		public Color color; //Field offset: 0x8

	}

	[Token(Token = "0x4000948")]
	public static readonly int vertexCountPerCube; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000949")]
	public Mesh mesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400094A")]
	private List<Vector3> vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094B")]
	private List<Int32> indices; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400094C")]
	private List<Color> colors; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400094D")]
	private Material wireMaterial; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400094E")]
	private Material dottedWireMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400094F")]
	private Material solidMaterial; //Field offset: 0x40

	[Address(RVA = "0x2C62CF0", Offset = "0x2C620F0", Length = "0x39")]
	[Token(Token = "0x6000E8A")]
	private static MeshGizmo() { }

	[Address(RVA = "0x2C62D30", Offset = "0x2C62130", Length = "0x174")]
	[Token(Token = "0x6000E84")]
	public MeshGizmo(int capacity = 0) { }

	[Address(RVA = "0x2C629E0", Offset = "0x2C61DE0", Length = "0x30E")]
	[CompilerGenerated]
	[Token(Token = "0x6000E8B")]
	private void <AddWireCube>g__AddEdge|10_0(Vector3 p1, Vector3 p2, ref <>c__DisplayClass10_0 unnamed_param_2) { }

	[Address(RVA = "0x2C61D70", Offset = "0x2C61170", Length = "0x7E3")]
	[Token(Token = "0x6000E86")]
	public void AddWireCube(Vector3 center, Vector3 size, Color color) { }

	[Address(RVA = "0x2C62560", Offset = "0x2C61960", Length = "0x7B")]
	[Token(Token = "0x6000E85")]
	public void Clear() { }

	[Address(RVA = "0x2C625E0", Offset = "0x2C619E0", Length = "0x4D")]
	[Token(Token = "0x6000E89")]
	public override void Dispose() { }

	[Address(RVA = "0x2C62630", Offset = "0x2C61A30", Length = "0x1D2")]
	[Token(Token = "0x6000E87")]
	private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName) { }

	[Address(RVA = "0x2C62810", Offset = "0x2C61C10", Length = "0x1C9")]
	[Token(Token = "0x6000E88")]
	public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = 4, string gizmoName = null) { }

}

