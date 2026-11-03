namespace UnityEngine.Rendering;

[Token(Token = "0x2000070")]
internal struct GPUInstanceDataBufferGrower : IDisposable
{
	[Token(Token = "0x2000071")]
	private static class CopyInstancesKernelIDs
	{
		[Token(Token = "0x40001FD")]
		public static readonly int _InputValidComponentCounts; //Field offset: 0x0
		[Token(Token = "0x40001FE")]
		public static readonly int _InstanceCounts; //Field offset: 0x4
		[Token(Token = "0x40001FF")]
		public static readonly int _InstanceOffset; //Field offset: 0x8
		[Token(Token = "0x4000200")]
		public static readonly int _OutputInstanceOffset; //Field offset: 0xC
		[Token(Token = "0x4000201")]
		public static readonly int _ValidComponentIndices; //Field offset: 0x10
		[Token(Token = "0x4000202")]
		public static readonly int _ComponentByteCounts; //Field offset: 0x14
		[Token(Token = "0x4000203")]
		public static readonly int _InputComponentAddresses; //Field offset: 0x18
		[Token(Token = "0x4000204")]
		public static readonly int _OutputComponentAddresses; //Field offset: 0x1C
		[Token(Token = "0x4000205")]
		public static readonly int _InputComponentInstanceIndexRanges; //Field offset: 0x20
		[Token(Token = "0x4000206")]
		public static readonly int _InputBuffer; //Field offset: 0x24
		[Token(Token = "0x4000207")]
		public static readonly int _OutputBuffer; //Field offset: 0x28

		[Address(RVA = "0x2CDEA80", Offset = "0x2CDDE80", Length = "0x201")]
		[Token(Token = "0x60001E6")]
		private static CopyInstancesKernelIDs() { }

	}

	[Token(Token = "0x2000072")]
	internal struct GPUResources : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000208")]
		public ComputeShader cs; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000209")]
		public int kernelId; //Field offset: 0x8

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60001E8")]
		public void CreateResources() { }

		[Address(RVA = "0x2373D70", Offset = "0x2373170", Length = "0xE")]
		[Token(Token = "0x60001E9")]
		public override void Dispose() { }

		[Address(RVA = "0x2CE2590", Offset = "0x2CE1990", Length = "0xA9")]
		[Token(Token = "0x60001E7")]
		public void LoadShaders(GPUResidentDrawerResources resources) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001FB")]
	private GPUInstanceDataBuffer m_SrcBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001FC")]
	private GPUInstanceDataBuffer m_DstBuffer; //Field offset: 0x8

	[Address(RVA = "0x2CE0BC0", Offset = "0x2CDFFC0", Length = "0x2C7")]
	[Token(Token = "0x60001E3")]
	public GPUInstanceDataBufferGrower(GPUInstanceDataBuffer sourceBuffer, in InstanceNumInfo instanceNumInfo) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001E5")]
	public override void Dispose() { }

	[Address(RVA = "0x2CE07F0", Offset = "0x2CDFBF0", Length = "0x3C5")]
	[Token(Token = "0x60001E4")]
	public GPUInstanceDataBuffer SubmitToGpu(ref GPUResources gpuResources) { }

}

