namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2DRendererData-overview.html")]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.Universal", "Unity.RenderPipelines.Universal.Runtime", null)]
[ReloadGroup]
[Token(Token = "0x2000048")]
public class Renderer2DData : ScriptableRendererData
{
	[Token(Token = "0x2000049")]
	public enum Renderer2DDefaultMaterialType : int
	{
		Lit = 0,
		Unlit = 1,
		Custom = 2,
	}

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000193")]
	private LayerMask m_LayerMask; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000194")]
	private TransparencySortMode m_TransparencySortMode; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000195")]
	private Vector3 m_TransparencySortAxis; //Field offset: 0x50
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000196")]
	private float m_HDREmulationScale; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0.01, 1)]
	[SerializeField]
	[Token(Token = "0x4000197")]
	private float m_LightRenderTextureScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("m_LightOperations")]
	[SerializeField]
	[Token(Token = "0x4000198")]
	private Light2DBlendStyle[] m_LightBlendStyles; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000199")]
	private bool m_UseDepthStencilBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	[Token(Token = "0x400019A")]
	private bool m_UseCameraSortingLayersTexture; //Field offset: 0x71
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x400019B")]
	private int m_CameraSortingLayersTextureBound; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400019C")]
	private Downsampling m_CameraSortingLayerDownsamplingMethod; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400019D")]
	private uint m_MaxLightRenderTextureCount; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400019E")]
	private uint m_MaxShadowRenderTextureCount; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400019F")]
	private PostProcessData m_PostProcessData; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001A0")]
	private readonly Dictionary<UInt32, Material> <lightMaterials>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40001A1")]
	private Material <spriteSelfShadowMaterial>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001A2")]
	private Material <spriteUnshadowMaterial>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40001A3")]
	private Material <geometrySelfShadowMaterial>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001A4")]
	private Material <geometryUnshadowMaterial>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001A5")]
	private Material <projectedShadowMaterial>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001A6")]
	private Material <projectedUnshadowMaterial>k__BackingField; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001A7")]
	internal RTHandle normalsRenderTarget; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001A8")]
	internal RTHandle cameraSortingLayerRenderTarget; //Field offset: 0xD0
	[CompilerGenerated]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001A9")]
	private ILight2DCullResult <lightCullResult>k__BackingField; //Field offset: 0xD8

	[Token(Token = "0x17000073")]
	internal Downsampling cameraSortingLayerDownsamplingMethod
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x60001FC")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000072")]
	internal int cameraSortingLayerTextureBound
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x60001FB")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000078")]
	internal Material geometrySelfShadowMaterial
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000206")]
		internal get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000207")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000079")]
	internal Material geometryUnshadowMaterial
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000208")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000209")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000068")]
	public float hdrEmulationScale
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x60001F0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000074")]
	internal LayerMask layerMask
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60001FD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700006A")]
	public Light2DBlendStyle[] lightBlendStyles
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60001F2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007C")]
	internal ILight2DCullResult lightCullResult
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600020E")]
		internal get { } //Length: 8
		[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600020F")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000075")]
	internal Dictionary<UInt32, Material> lightMaterials
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000201")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700006F")]
	internal uint lightRenderTextureMemoryBudget
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x60001F8")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000069")]
	internal float lightRenderTextureScale
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x60001F1")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700006C")]
	internal PostProcessData postProcessData
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60001F4")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60001F5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700007A")]
	internal Material projectedShadowMaterial
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600020A")]
		internal get { } //Length: 8
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600020B")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700007B")]
	internal Material projectedUnshadowMaterial
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600020C")]
		internal get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600020D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000070")]
	internal uint shadowRenderTextureMemoryBudget
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x60001F9")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000076")]
	internal Material spriteSelfShadowMaterial
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000202")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000203")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000077")]
	internal Material spriteUnshadowMaterial
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000204")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000205")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700006E")]
	internal Vector3 transparencySortAxis
	{
		[Address(RVA = "0x2D2CE60", Offset = "0x2D2C260", Length = "0x13")]
		[Token(Token = "0x60001F7")]
		internal get { } //Length: 19
	}

	[Token(Token = "0x1700006D")]
	internal TransparencySortMode transparencySortMode
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60001F6")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000071")]
	internal bool useCameraSortingLayerTexture
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x60001FA")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700006B")]
	internal bool useDepthStencilBuffer
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x60001F3")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2D2CD70", Offset = "0x2D2C170", Length = "0xE9")]
	[Token(Token = "0x6000210")]
	public Renderer2DData() { }

	[Address(RVA = "0x2D2CA60", Offset = "0x2D2BE60", Length = "0x5B")]
	[Token(Token = "0x60001FE")]
	protected virtual ScriptableRenderer Create() { }

	[Address(RVA = "0x2D2CAC0", Offset = "0x2D2BEC0", Length = "0x20B")]
	[Token(Token = "0x60001FF")]
	internal void Dispose() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x60001FC")]
	internal Downsampling get_cameraSortingLayerDownsamplingMethod() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x60001FB")]
	internal int get_cameraSortingLayerTextureBound() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000206")]
	internal Material get_geometrySelfShadowMaterial() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000208")]
	internal Material get_geometryUnshadowMaterial() { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x60001F0")]
	public float get_hdrEmulationScale() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60001FD")]
	internal LayerMask get_layerMask() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60001F2")]
	public Light2DBlendStyle[] get_lightBlendStyles() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600020E")]
	internal ILight2DCullResult get_lightCullResult() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000201")]
	internal Dictionary<UInt32, Material> get_lightMaterials() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x60001F8")]
	internal uint get_lightRenderTextureMemoryBudget() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x60001F1")]
	internal float get_lightRenderTextureScale() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60001F4")]
	internal PostProcessData get_postProcessData() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600020A")]
	internal Material get_projectedShadowMaterial() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600020C")]
	internal Material get_projectedUnshadowMaterial() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[Token(Token = "0x60001F9")]
	internal uint get_shadowRenderTextureMemoryBudget() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000202")]
	internal Material get_spriteSelfShadowMaterial() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000204")]
	internal Material get_spriteUnshadowMaterial() { }

	[Address(RVA = "0x2D2CE60", Offset = "0x2D2C260", Length = "0x13")]
	[Token(Token = "0x60001F7")]
	internal Vector3 get_transparencySortAxis() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60001F6")]
	internal TransparencySortMode get_transparencySortMode() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x60001FA")]
	internal bool get_useCameraSortingLayerTexture() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x60001F3")]
	internal bool get_useDepthStencilBuffer() { }

	[Address(RVA = "0x2D2CCD0", Offset = "0x2D2C0D0", Length = "0x9E")]
	[Token(Token = "0x6000200")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000207")]
	internal void set_geometrySelfShadowMaterial(Material value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000209")]
	internal void set_geometryUnshadowMaterial(Material value) { }

	[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600020F")]
	internal void set_lightCullResult(ILight2DCullResult value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60001F5")]
	internal void set_postProcessData(PostProcessData value) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600020B")]
	internal void set_projectedShadowMaterial(Material value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600020D")]
	internal void set_projectedUnshadowMaterial(Material value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000203")]
	internal void set_spriteSelfShadowMaterial(Material value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000205")]
	internal void set_spriteUnshadowMaterial(Material value) { }

}

