namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@d6dfd1e235d5\\Runtime\\GPUDriven\\OcclusionCullingDebugShaderVariables.cs", needAccessors = False, generateCBuffer = True)]
[Token(Token = "0x20000E0")]
internal struct OcclusionCullingDebugShaderVariables
{
	[CompilerGenerated]
	[Token(Token = "0x20000E1")]
	[UnsafeValueType]
	internal struct <_OccluderMipBounds>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400040B")]
		public uint FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000405")]
	public Vector4 _DepthSizeInOccluderPixels; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FixedBuffer(typeof(uint), 32)]
	[HLSLArray(8, typeof(ShaderGenUInt4))]
	[Token(Token = "0x4000406")]
	public <_OccluderMipBounds>e__FixedBuffer _OccluderMipBounds; //Field offset: 0x10
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000407")]
	public uint _OccluderMipLayoutSizeX; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000408")]
	public uint _OccluderMipLayoutSizeY; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000409")]
	public uint _OcclusionCullingDebugPad0; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400040A")]
	public uint _OcclusionCullingDebugPad1; //Field offset: 0x9C

}

