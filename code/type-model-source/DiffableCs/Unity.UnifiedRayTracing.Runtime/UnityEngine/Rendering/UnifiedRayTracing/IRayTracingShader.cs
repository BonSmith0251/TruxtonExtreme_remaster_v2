namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000053")]
public interface IRayTracingShader
{

	[Token(Token = "0x6000170")]
	public void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, uint width, uint height, uint depth) { }

	[Token(Token = "0x6000171")]
	public void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer) { }

	[Token(Token = "0x6000175")]
	public uint3 GetThreadGroupSizes() { }

	[Token(Token = "0x6000174")]
	public ulong GetTraceScratchBufferRequiredSizeInBytes(uint width, uint height, uint depth) { }

	[Token(Token = "0x6000168")]
	public void SetAccelerationStructure(CommandBuffer cmd, string name, IRayTracingAccelStruct accelStruct) { }

	[Token(Token = "0x600016E")]
	public void SetBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer) { }

	[Token(Token = "0x600016F")]
	public void SetBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer) { }

	[Token(Token = "0x6000172")]
	public void SetConstantBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Token(Token = "0x6000173")]
	public void SetConstantBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Token(Token = "0x600016A")]
	public void SetFloatParam(CommandBuffer cmd, int nameID, float val) { }

	[Token(Token = "0x6000169")]
	public void SetIntParam(CommandBuffer cmd, int nameID, int val) { }

	[Token(Token = "0x600016C")]
	public void SetMatrixParam(CommandBuffer cmd, int nameID, Matrix4x4 val) { }

	[Token(Token = "0x600016D")]
	public void SetTextureParam(CommandBuffer cmd, int nameID, RenderTargetIdentifier rt) { }

	[Token(Token = "0x600016B")]
	public void SetVectorParam(CommandBuffer cmd, int nameID, Vector4 val) { }

}

