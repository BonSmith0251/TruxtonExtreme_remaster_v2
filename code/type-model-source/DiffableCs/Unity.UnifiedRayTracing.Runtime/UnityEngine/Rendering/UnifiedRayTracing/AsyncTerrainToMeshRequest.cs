namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200003C")]
internal struct AsyncTerrainToMeshRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000177")]
	private JobHandle m_JobHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000178")]
	private ComputeTerrainMeshJob m_Job; //Field offset: 0x10

	[Token(Token = "0x17000015")]
	public bool done
	{
		[Address(RVA = "0x2F4FC40", Offset = "0x2F4F040", Length = "0x7")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2F4FBF0", Offset = "0x2F4EFF0", Length = "0x4C")]
	[Token(Token = "0x60000C3")]
	internal AsyncTerrainToMeshRequest(ComputeTerrainMeshJob job, JobHandle jobHandle) { }

	[Address(RVA = "0x2F4FC40", Offset = "0x2F4F040", Length = "0x7")]
	[Token(Token = "0x60000C4")]
	public bool get_done() { }

	[Address(RVA = "0x2F4F850", Offset = "0x2F4EC50", Length = "0x155")]
	[Token(Token = "0x60000C5")]
	public Mesh GetMesh() { }

	[Address(RVA = "0x2F4F9B0", Offset = "0x2F4EDB0", Length = "0x22C")]
	[Token(Token = "0x60000C7")]
	private List<Int32> TriangleIndicesWithoutHoles() { }

	[Address(RVA = "0x2F4FBE0", Offset = "0x2F4EFE0", Length = "0x7")]
	[Token(Token = "0x60000C6")]
	public void WaitForCompletion() { }

}

