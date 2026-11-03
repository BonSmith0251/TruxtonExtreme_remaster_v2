namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[Obsolete("ForwardRendererData has been deprecated #from(2021.2) #breakingFrom(2021.2) (UnityUpgradable) -> UniversalRendererData", True)]
[ReloadGroup]
[Token(Token = "0x20000D6")]
public class ForwardRendererData : ScriptableRendererData
{
	[ReloadGroup]
	[Token(Token = "0x20000D7")]
	internal sealed class ShaderResources
	{
		[FieldOffset(Offset = "0x10")]
		[Reload("Shaders/Utils/Blit.shader", Package::Root (1))]
		[Token(Token = "0x40004D6")]
		public Shader blitPS; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Reload("Shaders/Utils/CopyDepth.shader", Package::Root (1))]
		[Token(Token = "0x40004D7")]
		public Shader copyDepthPS; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature. #from(2021.1) #breakingFrom(2023.1)", True)]
		[Token(Token = "0x40004D8")]
		public Shader screenSpaceShadowPS; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Reload("Shaders/Utils/Sampling.shader", Package::Root (1))]
		[Token(Token = "0x40004D9")]
		public Shader samplingPS; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Reload("Shaders/Utils/StencilDeferred.shader", Package::Root (1))]
		[Token(Token = "0x40004DA")]
		public Shader stencilDeferredPS; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Reload("Shaders/Utils/FallbackError.shader", Package::Root (1))]
		[Token(Token = "0x40004DB")]
		public Shader fallbackErrorPS; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Reload("Shaders/Utils/FallbackLoading.shader", Package::Root (1))]
		[Token(Token = "0x40004DC")]
		public Shader fallbackLoadingPS; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Obsolete("Use fallbackErrorPS instead. #from(2022.2) #breakingFrom(2023.1)", True)]
		[Reload("Shaders/Utils/MaterialError.shader", Package::Root (1))]
		[Token(Token = "0x40004DD")]
		public Shader materialErrorPS; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Reload("Shaders/Utils/CoreBlit.shader", Package::Root (1))]
		[SerializeField]
		[Token(Token = "0x40004DE")]
		internal Shader coreBlitPS; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", Package::Root (1))]
		[SerializeField]
		[Token(Token = "0x40004DF")]
		internal Shader coreBlitColorAndDepthPS; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Reload("Shaders/CameraMotionVectors.shader", Package::Root (1))]
		[Token(Token = "0x40004E0")]
		public Shader cameraMotionVector; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Reload("Shaders/ObjectMotionVectors.shader", Package::Root (1))]
		[Token(Token = "0x40004E1")]
		public Shader objectMotionVector; //Field offset: 0x68

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005A8")]
		public ShaderResources() { }

	}

	[Token(Token = "0x40004C9")]
	private const string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead"; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004CA")]
	public ShaderResources shaders; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004CB")]
	public PostProcessData postProcessData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004CC")]
	public XRSystemData xrSystemData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40004CD")]
	private LayerMask m_OpaqueLayerMask; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40004CE")]
	private LayerMask m_TransparentLayerMask; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40004CF")]
	private StencilStateData m_DefaultStencilState; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40004D0")]
	private bool m_ShadowTransparentReceive; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40004D1")]
	private RenderingMode m_RenderingMode; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40004D2")]
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40004D3")]
	private bool m_AccurateGbufferNormals; //Field offset: 0x7C
	[FieldOffset(Offset = "0x7D")]
	[SerializeField]
	[Token(Token = "0x40004D4")]
	private bool m_ClusteredRendering; //Field offset: 0x7D
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40004D5")]
	private TileSize m_TileSize; //Field offset: 0x80

	[Token(Token = "0x17000189")]
	public bool accurateGbufferNormals
	{
		[Address(RVA = "0x2D8FCC0", Offset = "0x2D8F0C0", Length = "0x4E")]
		[Token(Token = "0x60005A5")]
		 get { } //Length: 78
		[Address(RVA = "0x2D8FEA0", Offset = "0x2D8F2A0", Length = "0x4E")]
		[Token(Token = "0x60005A6")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000186")]
	public StencilStateData defaultStencilState
	{
		[Address(RVA = "0x2D8FD10", Offset = "0x2D8F110", Length = "0x4E")]
		[Token(Token = "0x600059F")]
		 get { } //Length: 78
		[Address(RVA = "0x2D8FEF0", Offset = "0x2D8F2F0", Length = "0x4E")]
		[Token(Token = "0x60005A0")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000184")]
	public LayerMask opaqueLayerMask
	{
		[Address(RVA = "0x2D8FD60", Offset = "0x2D8F160", Length = "0x4E")]
		[Token(Token = "0x600059B")]
		 get { } //Length: 78
		[Address(RVA = "0x2D8FF40", Offset = "0x2D8F340", Length = "0x4E")]
		[Token(Token = "0x600059C")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000188")]
	public RenderingMode renderingMode
	{
		[Address(RVA = "0x2D8FDB0", Offset = "0x2D8F1B0", Length = "0x4E")]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 78
		[Address(RVA = "0x2D8FF90", Offset = "0x2D8F390", Length = "0x4E")]
		[Token(Token = "0x60005A4")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000187")]
	public bool shadowTransparentReceive
	{
		[Address(RVA = "0x2D8FE00", Offset = "0x2D8F200", Length = "0x4E")]
		[Token(Token = "0x60005A1")]
		 get { } //Length: 78
		[Address(RVA = "0x2D8FFE0", Offset = "0x2D8F3E0", Length = "0x4E")]
		[Token(Token = "0x60005A2")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000185")]
	public LayerMask transparentLayerMask
	{
		[Address(RVA = "0x2D8FE50", Offset = "0x2D8F250", Length = "0x4E")]
		[Token(Token = "0x600059D")]
		 get { } //Length: 78
		[Address(RVA = "0x2D90030", Offset = "0x2D8F430", Length = "0x4E")]
		[Token(Token = "0x600059E")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x2D8FCB0", Offset = "0x2D8F0B0", Length = "0x7")]
	[Token(Token = "0x60005A7")]
	public ForwardRendererData() { }

	[Address(RVA = "0x2D8FC20", Offset = "0x2D8F020", Length = "0x8A")]
	[Token(Token = "0x600059A")]
	protected virtual ScriptableRenderer Create() { }

	[Address(RVA = "0x2D8FCC0", Offset = "0x2D8F0C0", Length = "0x4E")]
	[Token(Token = "0x60005A5")]
	public bool get_accurateGbufferNormals() { }

	[Address(RVA = "0x2D8FD10", Offset = "0x2D8F110", Length = "0x4E")]
	[Token(Token = "0x600059F")]
	public StencilStateData get_defaultStencilState() { }

	[Address(RVA = "0x2D8FD60", Offset = "0x2D8F160", Length = "0x4E")]
	[Token(Token = "0x600059B")]
	public LayerMask get_opaqueLayerMask() { }

	[Address(RVA = "0x2D8FDB0", Offset = "0x2D8F1B0", Length = "0x4E")]
	[Token(Token = "0x60005A3")]
	public RenderingMode get_renderingMode() { }

	[Address(RVA = "0x2D8FE00", Offset = "0x2D8F200", Length = "0x4E")]
	[Token(Token = "0x60005A1")]
	public bool get_shadowTransparentReceive() { }

	[Address(RVA = "0x2D8FE50", Offset = "0x2D8F250", Length = "0x4E")]
	[Token(Token = "0x600059D")]
	public LayerMask get_transparentLayerMask() { }

	[Address(RVA = "0x2D8FEA0", Offset = "0x2D8F2A0", Length = "0x4E")]
	[Token(Token = "0x60005A6")]
	public void set_accurateGbufferNormals(bool value) { }

	[Address(RVA = "0x2D8FEF0", Offset = "0x2D8F2F0", Length = "0x4E")]
	[Token(Token = "0x60005A0")]
	public void set_defaultStencilState(StencilStateData value) { }

	[Address(RVA = "0x2D8FF40", Offset = "0x2D8F340", Length = "0x4E")]
	[Token(Token = "0x600059C")]
	public void set_opaqueLayerMask(LayerMask value) { }

	[Address(RVA = "0x2D8FF90", Offset = "0x2D8F390", Length = "0x4E")]
	[Token(Token = "0x60005A4")]
	public void set_renderingMode(RenderingMode value) { }

	[Address(RVA = "0x2D8FFE0", Offset = "0x2D8F3E0", Length = "0x4E")]
	[Token(Token = "0x60005A2")]
	public void set_shadowTransparentReceive(bool value) { }

	[Address(RVA = "0x2D90030", Offset = "0x2D8F430", Length = "0x4E")]
	[Token(Token = "0x600059E")]
	public void set_transparentLayerMask(LayerMask value) { }

}

