namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000051")]
public interface IRayTracingAccelStruct : IDisposable
{

	[Token(Token = "0x600015D")]
	public int AddInstance(MeshInstanceDesc meshInstance) { }

	[Token(Token = "0x6000163")]
	public void Build(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Token(Token = "0x600015F")]
	public void ClearInstances() { }

	[Token(Token = "0x6000164")]
	public ulong GetBuildScratchBufferRequiredSizeInBytes() { }

	[Token(Token = "0x600015E")]
	public void RemoveInstance(int instanceHandle) { }

	[Token(Token = "0x6000161")]
	public void UpdateInstanceID(int instanceHandle, uint instanceID) { }

	[Token(Token = "0x6000162")]
	public void UpdateInstanceMask(int instanceHandle, uint mask) { }

	[Token(Token = "0x6000160")]
	public void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix) { }

}

