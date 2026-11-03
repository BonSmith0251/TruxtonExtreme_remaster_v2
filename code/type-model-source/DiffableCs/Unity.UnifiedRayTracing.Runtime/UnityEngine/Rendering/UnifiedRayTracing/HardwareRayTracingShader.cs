namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200004F")]
internal class HardwareRayTracingShader : IRayTracingShader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CA")]
	private readonly RayTracingShader m_Shader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CB")]
	private readonly string m_ShaderDispatchFuncName; //Field offset: 0x18

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600014D")]
	internal HardwareRayTracingShader(RayTracingShader shader, string dispatchFuncName, GraphicsBuffer unused) { }

	[Address(RVA = "0x2F63260", Offset = "0x2F62660", Length = "0x42")]
	[Token(Token = "0x6000159")]
	public override void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, uint width, uint height, uint depth) { }

	[Address(RVA = "0x2F632B0", Offset = "0x2F626B0", Length = "0x36")]
	[Token(Token = "0x600015A")]
	public override void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer) { }

	[Address(RVA = "0x2F632F0", Offset = "0x2F626F0", Length = "0x18")]
	[Token(Token = "0x600014E")]
	public override uint3 GetThreadGroupSizes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600015B")]
	public override ulong GetTraceScratchBufferRequiredSizeInBytes(uint width, uint height, uint depth) { }

	[Address(RVA = "0x2F63310", Offset = "0x2F62710", Length = "0xED")]
	[Token(Token = "0x600014F")]
	public override void SetAccelerationStructure(CommandBuffer cmd, string name, IRayTracingAccelStruct accelStruct) { }

	[Address(RVA = "0x2F63400", Offset = "0x2F62800", Length = "0x2A")]
	[Token(Token = "0x6000155")]
	public override void SetBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2F63430", Offset = "0x2F62830", Length = "0x2A")]
	[Token(Token = "0x6000156")]
	public override void SetBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2F63460", Offset = "0x2F62860", Length = "0x2D")]
	[Token(Token = "0x6000157")]
	public override void SetConstantBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2F63490", Offset = "0x2F62890", Length = "0x2D")]
	[Token(Token = "0x6000158")]
	public override void SetConstantBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2F634C0", Offset = "0x2F628C0", Length = "0x2A")]
	[Token(Token = "0x6000151")]
	public override void SetFloatParam(CommandBuffer cmd, int nameID, float val) { }

	[Address(RVA = "0x2F634F0", Offset = "0x2F628F0", Length = "0x2A")]
	[Token(Token = "0x6000150")]
	public override void SetIntParam(CommandBuffer cmd, int nameID, int val) { }

	[Address(RVA = "0x2F63520", Offset = "0x2F62920", Length = "0x57")]
	[Token(Token = "0x6000153")]
	public override void SetMatrixParam(CommandBuffer cmd, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2F63580", Offset = "0x2F62980", Length = "0x4F")]
	[Token(Token = "0x6000154")]
	public override void SetTextureParam(CommandBuffer cmd, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2F635D0", Offset = "0x2F629D0", Length = "0x39")]
	[Token(Token = "0x6000152")]
	public override void SetVectorParam(CommandBuffer cmd, int nameID, Vector4 val) { }

}

