namespace UnityEngine.Rendering.UnifiedRayTracing;

[CategoryInfo(Name = "R: Unified Ray Tracing", Order = 1000)]
[HideInInspector]
[MovedFrom(True, "UnityEngine.Rendering.UnifiedRayTracing", "Unity.Rendering.LightTransport.Runtime", null)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x200005A")]
internal class RayTracingRenderPipelineResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Runtime/UnifiedRayTracing/Common/GeometryPool/GeometryPoolKernels.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001E5")]
	private ComputeShader m_GeometryPoolKernels; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Runtime/UnifiedRayTracing/Common/Utilities/CopyBuffer.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001E6")]
	private ComputeShader m_CopyBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/copyPositions.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	private ComputeShader m_CopyPositions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/bit_histogram.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001E8")]
	private ComputeShader m_BitHistogram; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/block_reduce_part.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001E9")]
	private ComputeShader m_BlockReducePart; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/block_scan.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001EA")]
	private ComputeShader m_BlockScan; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/build_hlbvh.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001EB")]
	private ComputeShader m_BuildHlbvh; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/restructure_bvh.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001EC")]
	private ComputeShader m_RestructureBvh; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[ResourcePath("Runtime/UnifiedRayTracing/Compute/RadeonRays/kernels/scatter.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40001ED")]
	private ComputeShader m_Scatter; //Field offset: 0x58

	[Token(Token = "0x17000029")]
	public ComputeShader BitHistogram
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000194")]
		 get { } //Length: 5
		[Address(RVA = "0x2F64270", Offset = "0x2F63670", Length = "0x65")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700002A")]
	public ComputeShader BlockReducePart
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 5
		[Address(RVA = "0x2F642E0", Offset = "0x2F636E0", Length = "0x65")]
		[Token(Token = "0x6000197")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700002B")]
	public ComputeShader BlockScan
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000198")]
		 get { } //Length: 5
		[Address(RVA = "0x2F64350", Offset = "0x2F63750", Length = "0x65")]
		[Token(Token = "0x6000199")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700002C")]
	public ComputeShader BuildHlbvh
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600019A")]
		 get { } //Length: 5
		[Address(RVA = "0x2F643C0", Offset = "0x2F637C0", Length = "0x65")]
		[Token(Token = "0x600019B")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000027")]
	public ComputeShader CopyBuffer
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 5
		[Address(RVA = "0x2F64430", Offset = "0x2F63830", Length = "0x65")]
		[Token(Token = "0x6000191")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000028")]
	public ComputeShader CopyPositions
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 5
		[Address(RVA = "0x2F644A0", Offset = "0x2F638A0", Length = "0x65")]
		[Token(Token = "0x6000193")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000026")]
	public ComputeShader GeometryPoolKernels
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600018E")]
		 get { } //Length: 5
		[Address(RVA = "0x2F64510", Offset = "0x2F63910", Length = "0x65")]
		[Token(Token = "0x600018F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700002D")]
	public ComputeShader RestructureBvh
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 5
		[Address(RVA = "0x2F64580", Offset = "0x2F63980", Length = "0x65")]
		[Token(Token = "0x600019D")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700002E")]
	public ComputeShader Scatter
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600019E")]
		 get { } //Length: 5
		[Address(RVA = "0x2F645F0", Offset = "0x2F639F0", Length = "0x65")]
		[Token(Token = "0x600019F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000025")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600018D")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1F29D20", Offset = "0x1F29120", Length = "0xE")]
	[Token(Token = "0x60001A0")]
	public RayTracingRenderPipelineResources() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000194")]
	public ComputeShader get_BitHistogram() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000196")]
	public ComputeShader get_BlockReducePart() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000198")]
	public ComputeShader get_BlockScan() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600019A")]
	public ComputeShader get_BuildHlbvh() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000190")]
	public ComputeShader get_CopyBuffer() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000192")]
	public ComputeShader get_CopyPositions() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600018E")]
	public ComputeShader get_GeometryPoolKernels() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600019C")]
	public ComputeShader get_RestructureBvh() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600019E")]
	public ComputeShader get_Scatter() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600018D")]
	public override int get_version() { }

	[Address(RVA = "0x2F64270", Offset = "0x2F63670", Length = "0x65")]
	[Token(Token = "0x6000195")]
	public void set_BitHistogram(ComputeShader value) { }

	[Address(RVA = "0x2F642E0", Offset = "0x2F636E0", Length = "0x65")]
	[Token(Token = "0x6000197")]
	public void set_BlockReducePart(ComputeShader value) { }

	[Address(RVA = "0x2F64350", Offset = "0x2F63750", Length = "0x65")]
	[Token(Token = "0x6000199")]
	public void set_BlockScan(ComputeShader value) { }

	[Address(RVA = "0x2F643C0", Offset = "0x2F637C0", Length = "0x65")]
	[Token(Token = "0x600019B")]
	public void set_BuildHlbvh(ComputeShader value) { }

	[Address(RVA = "0x2F64430", Offset = "0x2F63830", Length = "0x65")]
	[Token(Token = "0x6000191")]
	public void set_CopyBuffer(ComputeShader value) { }

	[Address(RVA = "0x2F644A0", Offset = "0x2F638A0", Length = "0x65")]
	[Token(Token = "0x6000193")]
	public void set_CopyPositions(ComputeShader value) { }

	[Address(RVA = "0x2F64510", Offset = "0x2F63910", Length = "0x65")]
	[Token(Token = "0x600018F")]
	public void set_GeometryPoolKernels(ComputeShader value) { }

	[Address(RVA = "0x2F64580", Offset = "0x2F63980", Length = "0x65")]
	[Token(Token = "0x600019D")]
	public void set_RestructureBvh(ComputeShader value) { }

	[Address(RVA = "0x2F645F0", Offset = "0x2F639F0", Length = "0x65")]
	[Token(Token = "0x600019F")]
	public void set_Scatter(ComputeShader value) { }

}

