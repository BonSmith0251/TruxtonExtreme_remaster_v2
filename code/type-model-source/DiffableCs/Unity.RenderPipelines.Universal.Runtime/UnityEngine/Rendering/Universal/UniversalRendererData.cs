namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[ReloadGroup]
[Token(Token = "0x20000B6")]
public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
{
	[Token(Token = "0x400039D")]
	private const int k_LatestAssetVersion = 3; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeXRResources on GraphicsSettings. #from(2023.3)")]
	[Token(Token = "0x400039B")]
	public XRSystemData xrSystemData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400039C")]
	public PostProcessData postProcessData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400039E")]
	private int m_AssetVersion; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400039F")]
	private LayerMask m_PrepassLayerMask; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40003A0")]
	private LayerMask m_OpaqueLayerMask; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40003A1")]
	private LayerMask m_TransparentLayerMask; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40003A2")]
	private StencilStateData m_DefaultStencilState; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40003A3")]
	private bool m_ShadowTransparentReceive; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40003A4")]
	private RenderingMode m_RenderingMode; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40003A5")]
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40003A6")]
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40003A7")]
	private DepthFormat m_DepthAttachmentFormat; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40003A8")]
	private DepthFormat m_DepthTextureFormat; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40003A9")]
	private bool m_AccurateGbufferNormals; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x40003AA")]
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003AB")]
	private bool m_StripShadowsOffVariants; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x40003AC")]
	private bool m_StripAdditionalLightOffVariants; //Field offset: 0x91

	[Token(Token = "0x17000113")]
	public bool accurateGbufferNormals
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000457")]
		 get { } //Length: 8
		[Address(RVA = "0x2D956B0", Offset = "0x2D94AB0", Length = "0x29")]
		[Token(Token = "0x6000458")]
		 set { } //Length: 41
	}

	[Token(Token = "0x17000110")]
	public CopyDepthMode copyDepthMode
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x6000451")]
		 get { } //Length: 4
		[Address(RVA = "0x2D956E0", Offset = "0x2D94AE0", Length = "0x24")]
		[Token(Token = "0x6000452")]
		 set { } //Length: 36
	}

	[Token(Token = "0x1700010C")]
	public StencilStateData defaultStencilState
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000449")]
		 get { } //Length: 5
		[Address(RVA = "0x2D95710", Offset = "0x2D94B10", Length = "0x31")]
		[Token(Token = "0x600044A")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000111")]
	public DepthFormat depthAttachmentFormat
	{
		[Address(RVA = "0x2D954F0", Offset = "0x2D948F0", Length = "0x88")]
		[Token(Token = "0x6000453")]
		 get { } //Length: 136
		[Address(RVA = "0x2D95750", Offset = "0x2D94B50", Length = "0xBE")]
		[Token(Token = "0x6000454")]
		 set { } //Length: 190
	}

	[Token(Token = "0x1700010F")]
	public DepthPrimingMode depthPrimingMode
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x600044F")]
		 get { } //Length: 4
		[Address(RVA = "0x2D95810", Offset = "0x2D94C10", Length = "0x24")]
		[Token(Token = "0x6000450")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000112")]
	public DepthFormat depthTextureFormat
	{
		[Address(RVA = "0x2D95580", Offset = "0x2D94980", Length = "0xE7")]
		[Token(Token = "0x6000455")]
		 get { } //Length: 231
		[Address(RVA = "0x2D95840", Offset = "0x2D94C40", Length = "0x27")]
		[Token(Token = "0x6000456")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000114")]
	public IntermediateTextureMode intermediateTextureMode
	{
		[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
		[Token(Token = "0x6000459")]
		 get { } //Length: 7
		[Address(RVA = "0x2D95870", Offset = "0x2D94C70", Length = "0x27")]
		[Token(Token = "0x600045A")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700010A")]
	public LayerMask opaqueLayerMask
	{
		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[Token(Token = "0x6000445")]
		 get { } //Length: 4
		[Address(RVA = "0x2D958A0", Offset = "0x2D94CA0", Length = "0x24")]
		[Token(Token = "0x6000446")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000109")]
	public LayerMask prepassLayerMask
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x6000443")]
		 get { } //Length: 4
		[Address(RVA = "0x2D958D0", Offset = "0x2D94CD0", Length = "0x24")]
		[Token(Token = "0x6000444")]
		 set { } //Length: 36
	}

	[Token(Token = "0x1700010E")]
	public RenderingMode renderingMode
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x600044D")]
		 get { } //Length: 4
		[Address(RVA = "0x2D95900", Offset = "0x2D94D00", Length = "0x24")]
		[Token(Token = "0x600044E")]
		 set { } //Length: 36
	}

	[Token(Token = "0x1700010D")]
	public bool shadowTransparentReceive
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x600044B")]
		 get { } //Length: 5
		[Address(RVA = "0x2D95930", Offset = "0x2D94D30", Length = "0x26")]
		[Token(Token = "0x600044C")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000118")]
	internal virtual bool stripAdditionalLightOffVariants
	{
		[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
		[Token(Token = "0x600045F")]
		internal get { } //Length: 8
		[Address(RVA = "0x2A05DA0", Offset = "0x2A051A0", Length = "0x7")]
		[Token(Token = "0x6000460")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000117")]
	internal virtual bool stripShadowsOffVariants
	{
		[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
		[Token(Token = "0x600045D")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
		[Token(Token = "0x600045E")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700010B")]
	public LayerMask transparentLayerMask
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x6000447")]
		 get { } //Length: 4
		[Address(RVA = "0x2D95960", Offset = "0x2D94D60", Length = "0x24")]
		[Token(Token = "0x6000448")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000116")]
	public bool usesClusterLightLoop
	{
		[Address(RVA = "0x2D95670", Offset = "0x2D94A70", Length = "0x11")]
		[Token(Token = "0x600045C")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000115")]
	public bool usesDeferredLighting
	{
		[Address(RVA = "0x2D95690", Offset = "0x2D94A90", Length = "0x11")]
		[Token(Token = "0x600045B")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x2D95420", Offset = "0x2D94820", Length = "0xC2")]
	[Token(Token = "0x6000465")]
	public UniversalRendererData() { }

	[Address(RVA = "0x2D95350", Offset = "0x2D94750", Length = "0x7C")]
	[Token(Token = "0x6000442")]
	protected virtual ScriptableRenderer Create() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000457")]
	public bool get_accurateGbufferNormals() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x6000451")]
	public CopyDepthMode get_copyDepthMode() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000449")]
	public StencilStateData get_defaultStencilState() { }

	[Address(RVA = "0x2D954F0", Offset = "0x2D948F0", Length = "0x88")]
	[Token(Token = "0x6000453")]
	public DepthFormat get_depthAttachmentFormat() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x600044F")]
	public DepthPrimingMode get_depthPrimingMode() { }

	[Address(RVA = "0x2D95580", Offset = "0x2D94980", Length = "0xE7")]
	[Token(Token = "0x6000455")]
	public DepthFormat get_depthTextureFormat() { }

	[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
	[Token(Token = "0x6000459")]
	public IntermediateTextureMode get_intermediateTextureMode() { }

	[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
	[Token(Token = "0x6000445")]
	public LayerMask get_opaqueLayerMask() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x6000443")]
	public LayerMask get_prepassLayerMask() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x600044D")]
	public RenderingMode get_renderingMode() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x600044B")]
	public bool get_shadowTransparentReceive() { }

	[Address(RVA = "0x22F0F70", Offset = "0x22F0370", Length = "0x8")]
	[Token(Token = "0x600045F")]
	internal virtual bool get_stripAdditionalLightOffVariants() { }

	[Address(RVA = "0xE26950", Offset = "0xE25D50", Length = "0x8")]
	[Token(Token = "0x600045D")]
	internal virtual bool get_stripShadowsOffVariants() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x6000447")]
	public LayerMask get_transparentLayerMask() { }

	[Address(RVA = "0x2D95670", Offset = "0x2D94A70", Length = "0x11")]
	[Token(Token = "0x600045C")]
	public bool get_usesClusterLightLoop() { }

	[Address(RVA = "0x2D95690", Offset = "0x2D94A90", Length = "0x11")]
	[Token(Token = "0x600045B")]
	public bool get_usesDeferredLighting() { }

	[Address(RVA = "0x2D953D0", Offset = "0x2D947D0", Length = "0x7")]
	[Token(Token = "0x6000461")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000462")]
	private void ReloadAllNullProperties() { }

	[Address(RVA = "0x2D956B0", Offset = "0x2D94AB0", Length = "0x29")]
	[Token(Token = "0x6000458")]
	public void set_accurateGbufferNormals(bool value) { }

	[Address(RVA = "0x2D956E0", Offset = "0x2D94AE0", Length = "0x24")]
	[Token(Token = "0x6000452")]
	public void set_copyDepthMode(CopyDepthMode value) { }

	[Address(RVA = "0x2D95710", Offset = "0x2D94B10", Length = "0x31")]
	[Token(Token = "0x600044A")]
	public void set_defaultStencilState(StencilStateData value) { }

	[Address(RVA = "0x2D95750", Offset = "0x2D94B50", Length = "0xBE")]
	[Token(Token = "0x6000454")]
	public void set_depthAttachmentFormat(DepthFormat value) { }

	[Address(RVA = "0x2D95810", Offset = "0x2D94C10", Length = "0x24")]
	[Token(Token = "0x6000450")]
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	[Address(RVA = "0x2D95840", Offset = "0x2D94C40", Length = "0x27")]
	[Token(Token = "0x6000456")]
	public void set_depthTextureFormat(DepthFormat value) { }

	[Address(RVA = "0x2D95870", Offset = "0x2D94C70", Length = "0x27")]
	[Token(Token = "0x600045A")]
	public void set_intermediateTextureMode(IntermediateTextureMode value) { }

	[Address(RVA = "0x2D958A0", Offset = "0x2D94CA0", Length = "0x24")]
	[Token(Token = "0x6000446")]
	public void set_opaqueLayerMask(LayerMask value) { }

	[Address(RVA = "0x2D958D0", Offset = "0x2D94CD0", Length = "0x24")]
	[Token(Token = "0x6000444")]
	public void set_prepassLayerMask(LayerMask value) { }

	[Address(RVA = "0x2D95900", Offset = "0x2D94D00", Length = "0x24")]
	[Token(Token = "0x600044E")]
	public void set_renderingMode(RenderingMode value) { }

	[Address(RVA = "0x2D95930", Offset = "0x2D94D30", Length = "0x26")]
	[Token(Token = "0x600044C")]
	public void set_shadowTransparentReceive(bool value) { }

	[Address(RVA = "0x2A05DA0", Offset = "0x2A051A0", Length = "0x7")]
	[Token(Token = "0x6000460")]
	internal virtual void set_stripAdditionalLightOffVariants(bool value) { }

	[Address(RVA = "0xE26D90", Offset = "0xE26190", Length = "0x7")]
	[Token(Token = "0x600045E")]
	internal virtual void set_stripShadowsOffVariants(bool value) { }

	[Address(RVA = "0x2D95960", Offset = "0x2D94D60", Length = "0x24")]
	[Token(Token = "0x6000448")]
	public void set_transparentLayerMask(LayerMask value) { }

	[Address(RVA = "0x2D953E0", Offset = "0x2D947E0", Length = "0x21")]
	[Token(Token = "0x6000464")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2D95410", Offset = "0x2D94810", Length = "0x8")]
	[Token(Token = "0x6000463")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

