namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\GPUDriven\\OcclusionCullingCommonShaderVariables.cs", needAccessors = False, generateCBuffer = True)]
[Token(Token = "0x20000DA")]
internal struct OcclusionCullingCommonShaderVariables
{
	[CompilerGenerated]
	[Token(Token = "0x20000DB")]
	[UnsafeValueType]
	internal struct <_FacingDirWorldSpace>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000400")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DC")]
	[UnsafeValueType]
	internal struct <_OccluderMipBounds>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000401")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DD")]
	[UnsafeValueType]
	internal struct <_RadialDirWorldSpace>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000402")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DE")]
	[UnsafeValueType]
	internal struct <_ViewOriginWorldSpace>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000403")]
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DF")]
	[UnsafeValueType]
	internal struct <_ViewProjMatrix>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000404")]
		public float FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[FixedBuffer(typeof(uint), 32)]
	[HLSLArray(8, typeof(ShaderGenUInt4))]
	[Token(Token = "0x40003F1")]
	public <_OccluderMipBounds>e__FixedBuffer _OccluderMipBounds; //Field offset: 0x0
	[FieldOffset(Offset = "0x80")]
	[FixedBuffer(typeof(float), 96)]
	[HLSLArray(6, typeof(Matrix4x4))]
	[Token(Token = "0x40003F2")]
	public <_ViewProjMatrix>e__FixedBuffer _ViewProjMatrix; //Field offset: 0x80
	[FieldOffset(Offset = "0x200")]
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	[Token(Token = "0x40003F3")]
	public <_ViewOriginWorldSpace>e__FixedBuffer _ViewOriginWorldSpace; //Field offset: 0x200
	[FieldOffset(Offset = "0x260")]
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	[Token(Token = "0x40003F4")]
	public <_FacingDirWorldSpace>e__FixedBuffer _FacingDirWorldSpace; //Field offset: 0x260
	[FieldOffset(Offset = "0x2C0")]
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	[Token(Token = "0x40003F5")]
	public <_RadialDirWorldSpace>e__FixedBuffer _RadialDirWorldSpace; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x40003F6")]
	public Vector4 _DepthSizeInOccluderPixels; //Field offset: 0x320
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x40003F7")]
	public Vector4 _OccluderDepthPyramidSize; //Field offset: 0x330
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x40003F8")]
	public uint _OccluderMipLayoutSizeX; //Field offset: 0x340
	[FieldOffset(Offset = "0x344")]
	[Token(Token = "0x40003F9")]
	public uint _OccluderMipLayoutSizeY; //Field offset: 0x344
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x40003FA")]
	public uint _OcclusionTestDebugFlags; //Field offset: 0x348
	[FieldOffset(Offset = "0x34C")]
	[Token(Token = "0x40003FB")]
	public uint _OcclusionCullingCommonPad0; //Field offset: 0x34C
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x40003FC")]
	public int _OcclusionTestCount; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[Token(Token = "0x40003FD")]
	public int _OccluderSubviewIndices; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x40003FE")]
	public int _CullingSplitIndices; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x40003FF")]
	public int _CullingSplitMask; //Field offset: 0x35C

	[Address(RVA = "0x2CF9920", Offset = "0x2CF8D20", Length = "0x422")]
	[Token(Token = "0x600037D")]
	internal OcclusionCullingCommonShaderVariables(in OccluderContext occluderCtx, in InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass) { }

}

