namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\GPUDriven\\OccluderDepthPyramidConstants.cs", needAccessors = False, generateCBuffer = True)]
[Token(Token = "0x20000C7")]
internal struct OccluderDepthPyramidConstants
{
	[CompilerGenerated]
	[Token(Token = "0x20000C8")]
	[UnsafeValueType]
	internal struct <_InvViewProjMatrix>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AE")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000C9")]
	[UnsafeValueType]
	internal struct <_MipOffsetAndSize>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AF")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	[UnsafeValueType]
	internal struct <_SilhouettePlanes>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B0")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CB")]
	[UnsafeValueType]
	internal struct <_SrcOffset>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B1")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(float), 96)]
	[HLSLArray(6, typeof(Matrix4x4))]
	[Token(Token = "0x40003A2")]
	public <_InvViewProjMatrix>e__FixedBuffer _InvViewProjMatrix; //Field offset: 0x0
	[FieldOffset(Offset = "0x180")]
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	[Token(Token = "0x40003A3")]
	public <_SilhouettePlanes>e__FixedBuffer _SilhouettePlanes; //Field offset: 0x180
	[FieldOffset(Offset = "0x1E0")]
	[FixedBuffer(typeof(uint), 24)]
	[HLSLArray(6, typeof(ShaderGenUInt4))]
	[Token(Token = "0x40003A4")]
	public <_SrcOffset>e__FixedBuffer _SrcOffset; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x240")]
	[FixedBuffer(typeof(uint), 20)]
	[HLSLArray(5, typeof(ShaderGenUInt4))]
	[Token(Token = "0x40003A5")]
	public <_MipOffsetAndSize>e__FixedBuffer _MipOffsetAndSize; //Field offset: 0x240
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40003A6")]
	public uint _OccluderMipLayoutSizeX; //Field offset: 0x290
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x40003A7")]
	public uint _OccluderMipLayoutSizeY; //Field offset: 0x294
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x40003A8")]
	public uint _OccluderDepthPyramidPad0; //Field offset: 0x298
	[FieldOffset(Offset = "0x29C")]
	[Token(Token = "0x40003A9")]
	public uint _OccluderDepthPyramidPad1; //Field offset: 0x29C
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x40003AA")]
	public uint _SrcSliceIndices; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A4")]
	[Token(Token = "0x40003AB")]
	public uint _DstSubviewIndices; //Field offset: 0x2A4
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x40003AC")]
	public uint _MipCount; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2AC")]
	[Token(Token = "0x40003AD")]
	public uint _SilhouettePlaneCount; //Field offset: 0x2AC

}

