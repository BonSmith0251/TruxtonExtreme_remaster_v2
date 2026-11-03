namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200004C")]
internal class ComputeRayTracingShader : IRayTracingShader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C0")]
	private readonly ComputeShader m_Shader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C1")]
	private readonly int m_KernelIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001C2")]
	private readonly int m_ComputeIndirectDispatchDimsKernelIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C3")]
	private uint3 m_ThreadGroupSizes; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C4")]
	private readonly GraphicsBuffer m_DispatchBuffer; //Field offset: 0x30

	[Address(RVA = "0x2F62910", Offset = "0x2F61D10", Length = "0xDC")]
	[Token(Token = "0x600012C")]
	internal ComputeRayTracingShader(ComputeShader shader, string dispatchFuncName, GraphicsBuffer dispatchBuffer) { }

	[Address(RVA = "0x2F62130", Offset = "0x2F61530", Length = "0x1C7")]
	[Token(Token = "0x6000139")]
	public override void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer) { }

	[Address(RVA = "0x2F62300", Offset = "0x2F61700", Length = "0x1D3")]
	[Token(Token = "0x6000138")]
	public override void Dispatch(CommandBuffer cmd, GraphicsBuffer scratchBuffer, uint width, uint height, uint depth) { }

	[Address(RVA = "0x2F62020", Offset = "0x2F61420", Length = "0x107")]
	[Token(Token = "0x600013B")]
	internal void DispatchIndirect(CommandBuffer cmd, GraphicsBuffer scratchBuffer, GraphicsBuffer argsBuffer) { }

	[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
	[Token(Token = "0x600012D")]
	public override uint3 GetThreadGroupSizes() { }

	[Address(RVA = "0x2F62000", Offset = "0x2F61400", Length = "0x1E")]
	[Token(Token = "0x600013C")]
	public override ulong GetTraceScratchBufferRequiredSizeInBytes(uint width, uint height, uint depth) { }

	[Address(RVA = "0x2F624E0", Offset = "0x2F618E0", Length = "0xC0")]
	[Token(Token = "0x600012E")]
	public override void SetAccelerationStructure(CommandBuffer cmd, string name, IRayTracingAccelStruct accelStruct) { }

	[Address(RVA = "0x2F625F0", Offset = "0x2F619F0", Length = "0x37")]
	[Token(Token = "0x6000135")]
	public override void SetBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2F625B0", Offset = "0x2F619B0", Length = "0x37")]
	[Token(Token = "0x6000134")]
	public override void SetBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2F62630", Offset = "0x2F61A30", Length = "0x2D")]
	[Token(Token = "0x6000136")]
	public override void SetConstantBufferParam(CommandBuffer cmd, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2F62660", Offset = "0x2F61A60", Length = "0x2D")]
	[Token(Token = "0x6000137")]
	public override void SetConstantBufferParam(CommandBuffer cmd, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2F62690", Offset = "0x2F61A90", Length = "0x2A")]
	[Token(Token = "0x6000130")]
	public override void SetFloatParam(CommandBuffer cmd, int nameID, float val) { }

	[Address(RVA = "0x2F626C0", Offset = "0x2F61AC0", Length = "0x119")]
	[Token(Token = "0x600013A")]
	internal void SetIndirectDispatchDimensions(CommandBuffer cmd, GraphicsBuffer argsBuffer) { }

	[Address(RVA = "0x2F627E0", Offset = "0x2F61BE0", Length = "0x2A")]
	[Token(Token = "0x600012F")]
	public override void SetIntParam(CommandBuffer cmd, int nameID, int val) { }

	[Address(RVA = "0x2F62810", Offset = "0x2F61C10", Length = "0x57")]
	[Token(Token = "0x6000132")]
	public override void SetMatrixParam(CommandBuffer cmd, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2F62870", Offset = "0x2F61C70", Length = "0x5B")]
	[Token(Token = "0x6000133")]
	public override void SetTextureParam(CommandBuffer cmd, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2F628D0", Offset = "0x2F61CD0", Length = "0x39")]
	[Token(Token = "0x6000131")]
	public override void SetVectorParam(CommandBuffer cmd, int nameID, Vector4 val) { }

}

