namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001E")]
internal class RadeonRaysAPI : IDisposable
{
	[Token(Token = "0x4000094")]
	public const Target BufferTarget = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000091")]
	private readonly HlbvhBuilder buildBvh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000092")]
	private readonly HlbvhTopLevelBuilder buildTopLevelBvh; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000093")]
	private readonly RestructureBvh restructureBvh; //Field offset: 0x20

	[Address(RVA = "0x2F5E220", Offset = "0x2F5D620", Length = "0x417")]
	[Token(Token = "0x6000038")]
	public RadeonRaysAPI(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5D070", Offset = "0x2F5C470", Length = "0x170")]
	[Token(Token = "0x600003E")]
	public void BuildMeshAccelStruct(CommandBuffer cmd, MeshBuildInfo buildInfo, BuildFlags buildFlags, GraphicsBuffer scratchBuffer, in BottomLevelLevelAccelStruct result) { }

	[Address(RVA = "0x2F5D1F0", Offset = "0x2F5C5F0", Length = "0x3A2")]
	[Token(Token = "0x6000040")]
	public TopLevelAccelStruct BuildSceneAccelStruct(CommandBuffer cmd, GraphicsBuffer meshAccelStructsBuffer, Instance[] instances, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F5D5A0", Offset = "0x2F5C9A0", Length = "0x51")]
	[Token(Token = "0x600003B")]
	public static int BvhInternalNodeSizeInBytes() { }

	[Address(RVA = "0x2F5D600", Offset = "0x2F5CA00", Length = "0x5B")]
	[Token(Token = "0x600003A")]
	public static int BvhInternalNodeSizeInDwords() { }

	[Address(RVA = "0x2F5D660", Offset = "0x2F5CA60", Length = "0x51")]
	[Token(Token = "0x600003C")]
	public static int BvhLeafNodeSizeInBytes() { }

	[Address(RVA = "0x2F5D6C0", Offset = "0x2F5CAC0", Length = "0x5B")]
	[Token(Token = "0x600003D")]
	public static int BvhLeafNodeSizeInDwords() { }

	[Address(RVA = "0x2F5D720", Offset = "0x2F5CB20", Length = "0x3D0")]
	[Token(Token = "0x6000041")]
	public TopLevelAccelStruct CreateSceneAccelStructBuffers(GraphicsBuffer meshAccelStructsBuffer, uint tlasSizeInDwords, Instance[] instances) { }

	[Address(RVA = "0x2F5DB00", Offset = "0x2F5CF00", Length = "0x26")]
	[Token(Token = "0x6000039")]
	public override void Dispose() { }

	[Address(RVA = "0x2F5DB30", Offset = "0x2F5CF30", Length = "0x187")]
	[Token(Token = "0x600003F")]
	public MeshBuildMemoryRequirements GetMeshBuildMemoryRequirements(MeshBuildInfo buildInfo, BuildFlags buildFlags) { }

	[Address(RVA = "0x2F5DCC0", Offset = "0x2F5D0C0", Length = "0x5F")]
	[Token(Token = "0x6000042")]
	public SceneBuildMemoryRequirements GetSceneBuildMemoryRequirements(uint instanceCount) { }

	[Address(RVA = "0x2F5DD20", Offset = "0x2F5D120", Length = "0x4E3")]
	[Token(Token = "0x6000043")]
	public SceneMemoryRequirements GetSceneMemoryRequirements(MeshBuildInfo[] buildInfos, BuildFlags buildFlags) { }

	[Address(RVA = "0x2F5E210", Offset = "0x2F5D610", Length = "0x6")]
	[Token(Token = "0x6000044")]
	public static ulong GetTraceMemoryRequirements(uint rayCount) { }

}

