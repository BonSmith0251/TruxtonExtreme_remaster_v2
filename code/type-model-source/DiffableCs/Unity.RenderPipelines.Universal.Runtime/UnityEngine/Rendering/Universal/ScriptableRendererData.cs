namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000B0")]
public abstract class ScriptableRendererData : ScriptableObject
{
	[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x20000B1")]
	internal sealed class DebugShaderResources
	{
		[FieldOffset(Offset = "0x10")]
		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
		[Reload("Shaders/Debug/DebugReplacement.shader", Package::Root (1))]
		[Token(Token = "0x4000383")]
		public Shader debugReplacementPS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
		[Reload("Shaders/Debug/HDRDebugView.shader", Package::Root (1))]
		[Token(Token = "0x4000384")]
		public Shader hdrDebugViewPS; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600043B")]
		public DebugShaderResources() { }

	}

	[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class. #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x20000B2")]
	internal sealed class ProbeVolumeResources
	{
		[FieldOffset(Offset = "0x10")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x4000385")]
		public Shader probeVolumeDebugShader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x4000386")]
		public Shader probeVolumeFragmentationDebugShader; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x4000387")]
		public Shader probeVolumeOffsetDebugShader; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x4000388")]
		public Shader probeVolumeSamplingDebugShader; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x4000389")]
		public Mesh probeSamplingDebugMesh; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Obsolete("This shader is now in the ProbeVolumeDebugResources class. #from(2023.3)")]
		[Token(Token = "0x400038A")]
		public Texture2D probeSamplingDebugTexture; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Obsolete("This shader is now in the ProbeVolumeRuntimeResources class. #from(2023.3)")]
		[Token(Token = "0x400038B")]
		public ComputeShader probeVolumeBlendStatesCS; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600043C")]
		public ProbeVolumeResources() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("Moved to UniversalRenderPipelineDebugShaders on GraphicsSettings. #from(2023.3)")]
	[Token(Token = "0x400037B")]
	public DebugShaderResources debugShaders; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Obsolete("Probe volume debug resource are now in the ProbeVolumeDebugResources class. #from(2023.3)")]
	[Token(Token = "0x400037C")]
	public ProbeVolumeResources probeVolumeResources; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400037D")]
	private bool <isInvalidated>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400037E")]
	internal List<ScriptableRendererFeature> m_RendererFeatures; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400037F")]
	internal List<Int64> m_RendererFeatureMap; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000380")]
	private bool m_UseNativeRenderPass; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000381")]
	private bool m_StripShadowsOffVariants; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000382")]
	private bool m_StripAdditionalLightOffVariants; //Field offset: 0x42

	[Token(Token = "0x17000104")]
	internal bool isInvalidated
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600042B")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600042C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000107")]
	public List<ScriptableRendererFeature> rendererFeatures
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000432")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000106")]
	internal override bool stripAdditionalLightOffVariants
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[Token(Token = "0x600042F")]
		internal get { } //Length: 5
		[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
		[Token(Token = "0x6000430")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000105")]
	internal override bool stripShadowsOffVariants
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x600042D")]
		internal get { } //Length: 5
		[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
		[Token(Token = "0x600042E")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000108")]
	public bool useNativeRenderPass
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000437")]
		 get { } //Length: 5
		[Address(RVA = "0x2D82690", Offset = "0x2D81A90", Length = "0x8")]
		[Token(Token = "0x6000438")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2D825C0", Offset = "0x2D819C0", Length = "0xC7")]
	[Token(Token = "0x600043A")]
	protected ScriptableRendererData() { }

	[Token(Token = "0x6000431")]
	protected abstract ScriptableRenderer Create() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600042B")]
	internal bool get_isInvalidated() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000432")]
	public List<ScriptableRendererFeature> get_rendererFeatures() { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[Token(Token = "0x600042F")]
	internal override bool get_stripAdditionalLightOffVariants() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x600042D")]
	internal override bool get_stripShadowsOffVariants() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000437")]
	public bool get_useNativeRenderPass() { }

	[Address(RVA = "0x2D825A0", Offset = "0x2D819A0", Length = "0x18")]
	[Token(Token = "0x6000434")]
	internal ScriptableRenderer InternalCreateRenderer() { }

	[Address(RVA = "0x2845AA0", Offset = "0x2844EA0", Length = "0x5")]
	[Token(Token = "0x6000436")]
	protected override void OnEnable() { }

	[Address(RVA = "0x2845AA0", Offset = "0x2844EA0", Length = "0x5")]
	[Token(Token = "0x6000435")]
	protected override void OnValidate() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600042C")]
	internal void set_isInvalidated(bool value) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[Token(Token = "0x6000430")]
	internal override void set_stripAdditionalLightOffVariants(bool value) { }

	[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
	[Token(Token = "0x600042E")]
	internal override void set_stripShadowsOffVariants(bool value) { }

	[Address(RVA = "0x2D82690", Offset = "0x2D81A90", Length = "0x8")]
	[Token(Token = "0x6000438")]
	public void set_useNativeRenderPass(bool value) { }

	[Address(RVA = "0x2845AA0", Offset = "0x2844EA0", Length = "0x5")]
	[Token(Token = "0x6000433")]
	public void SetDirty() { }

	[Address(RVA = "0x8EFC60", Offset = "0x8EF060", Length = "0x200")]
	[Token(Token = "0x6000439")]
	public bool TryGetRendererFeature(out T rendererFeature) { }

}

