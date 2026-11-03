namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200005B")]
public class RayTracingResources
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EE")]
	private ComputeShader <geometryPoolKernels>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001EF")]
	private ComputeShader <copyBuffer>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001F0")]
	private ComputeShader <copyPositions>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F1")]
	private ComputeShader <bitHistogram>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F2")]
	private ComputeShader <blockReducePart>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F3")]
	private ComputeShader <blockScan>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F4")]
	private ComputeShader <buildHlbvh>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001F5")]
	private ComputeShader <restructureBvh>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001F6")]
	private ComputeShader <scatter>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000032")]
	internal ComputeShader bitHistogram
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A7")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001A8")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000033")]
	internal ComputeShader blockReducePart
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A9")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001AA")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000034")]
	internal ComputeShader blockScan
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001AB")]
		internal get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001AC")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000035")]
	internal ComputeShader buildHlbvh
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001AD")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001AE")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000030")]
	internal ComputeShader copyBuffer
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A3")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001A4")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000031")]
	internal ComputeShader copyPositions
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A5")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001A6")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700002F")]
	internal ComputeShader geometryPoolKernels
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001A1")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001A2")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000036")]
	internal ComputeShader restructureBvh
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001AF")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001B0")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000037")]
	internal ComputeShader scatter
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001B1")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60001B2")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001B5")]
	public RayTracingResources() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A7")]
	internal ComputeShader get_bitHistogram() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A9")]
	internal ComputeShader get_blockReducePart() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001AB")]
	internal ComputeShader get_blockScan() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001AD")]
	internal ComputeShader get_buildHlbvh() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A3")]
	internal ComputeShader get_copyBuffer() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A5")]
	internal ComputeShader get_copyPositions() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001A1")]
	internal ComputeShader get_geometryPoolKernels() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001AF")]
	internal ComputeShader get_restructureBvh() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001B1")]
	internal ComputeShader get_scatter() { }

	[Address(RVA = "0x2F64660", Offset = "0x2F63A60", Length = "0x206")]
	[Token(Token = "0x60001B3")]
	public void LoadFromAssetBundle(AssetBundle assetBundle) { }

	[Address(RVA = "0x2F64870", Offset = "0x2F63C70", Length = "0x184")]
	[Token(Token = "0x60001B4")]
	public bool LoadFromRenderPipelineResources() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001A8")]
	internal void set_bitHistogram(ComputeShader value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001AA")]
	internal void set_blockReducePart(ComputeShader value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001AC")]
	internal void set_blockScan(ComputeShader value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001AE")]
	internal void set_buildHlbvh(ComputeShader value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001A4")]
	internal void set_copyBuffer(ComputeShader value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001A6")]
	internal void set_copyPositions(ComputeShader value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001A2")]
	internal void set_geometryPoolKernels(ComputeShader value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001B0")]
	internal void set_restructureBvh(ComputeShader value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001B2")]
	internal void set_scatter(ComputeShader value) { }

}

