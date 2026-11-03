namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[Token(Token = "0x200013B")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	[Token(Token = "0x17000250")]
	public static RenderTexture active
	{
		[Address(RVA = "0x3036000", Offset = "0x3035400", Length = "0x54")]
		[Token(Token = "0x6000F0D")]
		 get { } //Length: 84
		[Address(RVA = "0x3036E20", Offset = "0x3036220", Length = "0x6B")]
		[Token(Token = "0x6000F0E")]
		 set { } //Length: 107
	}

	[Token(Token = "0x1700024A")]
	public int antiAliasing
	{
		[Address(RVA = "0x3038990", Offset = "0x3037D90", Length = "0x76")]
		[Token(Token = "0x6000F03")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000248")]
	public bool autoGenerateMips
	{
		[Address(RVA = "0x3039710", Offset = "0x3038B10", Length = "0x86")]
		[Token(Token = "0x6000F00")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700024B")]
	public bool bindTextureMS
	{
		[Address(RVA = "0x3038A50", Offset = "0x3037E50", Length = "0x76")]
		[Token(Token = "0x6000F04")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000251")]
	public RenderBuffer colorBuffer
	{
		[Address(RVA = "0x3038AD0", Offset = "0x3037ED0", Length = "0xA0")]
		[Token(Token = "0x6000F13")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000252")]
	public RenderBuffer depthBuffer
	{
		[Address(RVA = "0x3038B80", Offset = "0x3037F80", Length = "0xA0")]
		[Token(Token = "0x6000F14")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000247")]
	public GraphicsFormat depthStencilFormat
	{
		[Address(RVA = "0x3038C70", Offset = "0x3038070", Length = "0x76")]
		[Token(Token = "0x6000EFE")]
		 get { } //Length: 118
		[Address(RVA = "0x30397E0", Offset = "0x3038BE0", Length = "0x83")]
		[Token(Token = "0x6000EFF")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000253")]
	public RenderTextureDescriptor descriptor
	{
		[Address(RVA = "0x3038CF0", Offset = "0x30380F0", Length = "0xD5")]
		[Token(Token = "0x6000F2F")]
		 get { } //Length: 213
	}

	[Token(Token = "0x17000242")]
	public virtual TextureDimension dimension
	{
		[Address(RVA = "0x3038E10", Offset = "0x3038210", Length = "0x76")]
		[Token(Token = "0x6000EF4")]
		 get { } //Length: 118
		[Address(RVA = "0x30398B0", Offset = "0x3038CB0", Length = "0x83")]
		[Token(Token = "0x6000EF5")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700024C")]
	public bool enableRandomWrite
	{
		[Address(RVA = "0x3039990", Offset = "0x3038D90", Length = "0x86")]
		[Token(Token = "0x6000F05")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700024F")]
	public bool enableShadingRate
	{
		[Address(RVA = "0x3038ED0", Offset = "0x30382D0", Length = "0x76")]
		[Token(Token = "0x6000F09")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000246")]
	public RenderTextureFormat format
	{
		[Address(RVA = "0x3038F50", Offset = "0x3038350", Length = "0x1A1")]
		[Token(Token = "0x6000EFD")]
		 get { } //Length: 417
	}

	[Token(Token = "0x17000243")]
	public GraphicsFormat graphicsFormat
	{
		[Address(RVA = "0x3039100", Offset = "0x3038500", Length = "0x78")]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 120
		[Address(RVA = "0x3036ED0", Offset = "0x30362D0", Length = "0x83")]
		[Token(Token = "0x6000EF9")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000241")]
	public virtual int height
	{
		[Address(RVA = "0x30391C0", Offset = "0x30385C0", Length = "0x76")]
		[Token(Token = "0x6000EF2")]
		 get { } //Length: 118
		[Address(RVA = "0x3039A60", Offset = "0x3038E60", Length = "0x83")]
		[Token(Token = "0x6000EF3")]
		 set { } //Length: 131
	}

	[NativeProperty("SRGBReadWrite")]
	[Token(Token = "0x17000245")]
	public bool sRGB
	{
		[Address(RVA = "0x3039280", Offset = "0x3038680", Length = "0x76")]
		[Token(Token = "0x6000EFC")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700024D")]
	public bool useDynamicScale
	{
		[Address(RVA = "0x3039400", Offset = "0x3038800", Length = "0x76")]
		[Token(Token = "0x6000F06")]
		 get { } //Length: 118
		[Address(RVA = "0x3039B40", Offset = "0x3038F40", Length = "0x86")]
		[Token(Token = "0x6000F07")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700024E")]
	public bool useDynamicScaleExplicit
	{
		[Address(RVA = "0x3039340", Offset = "0x3038740", Length = "0x76")]
		[Token(Token = "0x6000F08")]
		 get { } //Length: 118
	}

	[NativeProperty("MipMap")]
	[Token(Token = "0x17000244")]
	public bool useMipMap
	{
		[Address(RVA = "0x30394C0", Offset = "0x30388C0", Length = "0x76")]
		[Token(Token = "0x6000EFA")]
		 get { } //Length: 118
		[Address(RVA = "0x3039C20", Offset = "0x3039020", Length = "0x86")]
		[Token(Token = "0x6000EFB")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000249")]
	public int volumeDepth
	{
		[Address(RVA = "0x3039580", Offset = "0x3038980", Length = "0x76")]
		[Token(Token = "0x6000F01")]
		 get { } //Length: 118
		[Address(RVA = "0x3039CF0", Offset = "0x30390F0", Length = "0x83")]
		[Token(Token = "0x6000F02")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000240")]
	public virtual int width
	{
		[Address(RVA = "0x3039640", Offset = "0x3038A40", Length = "0x76")]
		[Token(Token = "0x6000EF0")]
		 get { } //Length: 118
		[Address(RVA = "0x3039DC0", Offset = "0x30391C0", Length = "0x83")]
		[Token(Token = "0x6000EF1")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x3037E60", Offset = "0x3037260", Length = "0x116")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F26")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	[Address(RVA = "0x30386C0", Offset = "0x3037AC0", Length = "0x289")]
	[Token(Token = "0x6000F1F")]
	public RenderTexture(RenderTexture textureToCopy) { }

	[Address(RVA = "0x3038350", Offset = "0x3037750", Length = "0x176")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F20")]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[Address(RVA = "0x3037890", Offset = "0x3036C90", Length = "0x9D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F21")]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	[Address(RVA = "0x3037F80", Offset = "0x3037380", Length = "0x2ED")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F22")]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[Address(RVA = "0x3037930", Offset = "0x3036D30", Length = "0x2C4")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F23")]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[Address(RVA = "0x3038620", Offset = "0x3037A20", Length = "0x9D")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F24")]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[Address(RVA = "0x3038270", Offset = "0x3037670", Length = "0xDD")]
	[Token(Token = "0x6000F25")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x3037D40", Offset = "0x3037140", Length = "0x116")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F27")]
	public RenderTexture(int width, int height, int depth) { }

	[Address(RVA = "0x3038550", Offset = "0x3037950", Length = "0xCB")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000F28")]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	[Address(RVA = "0x3037C00", Offset = "0x3037000", Length = "0x138")]
	[Token(Token = "0x6000F1E")]
	public RenderTexture(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x30384D0", Offset = "0x30378D0", Length = "0x7A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000F1D")]
	protected private RenderTexture() { }

	[Address(RVA = "0x3035E90", Offset = "0x3035290", Length = "0x76")]
	[Token(Token = "0x6000F0A")]
	public void ApplyDynamicScale() { }

	[Address(RVA = "0x3035E50", Offset = "0x3035250", Length = "0x33")]
	[Token(Token = "0x6000F4F")]
	private static void ApplyDynamicScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3035F50", Offset = "0x3035350", Length = "0x76")]
	[Token(Token = "0x6000F15")]
	public bool Create() { }

	[Address(RVA = "0x3035F10", Offset = "0x3035310", Length = "0x33")]
	[Token(Token = "0x6000F56")]
	private static bool Create_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3036000", Offset = "0x3035400", Length = "0x54")]
	[Token(Token = "0x6000F0D")]
	public static RenderTexture get_active() { }

	[Address(RVA = "0x3038990", Offset = "0x3037D90", Length = "0x76")]
	[Token(Token = "0x6000F03")]
	public int get_antiAliasing() { }

	[Address(RVA = "0x3038950", Offset = "0x3037D50", Length = "0x33")]
	[Token(Token = "0x6000F48")]
	private static int get_antiAliasing_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3038A50", Offset = "0x3037E50", Length = "0x76")]
	[Token(Token = "0x6000F04")]
	public bool get_bindTextureMS() { }

	[Address(RVA = "0x3038A10", Offset = "0x3037E10", Length = "0x33")]
	[Token(Token = "0x6000F49")]
	private static bool get_bindTextureMS_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3038AD0", Offset = "0x3037ED0", Length = "0xA0")]
	[Token(Token = "0x6000F13")]
	public RenderBuffer get_colorBuffer() { }

	[Address(RVA = "0x3038B80", Offset = "0x3037F80", Length = "0xA0")]
	[Token(Token = "0x6000F14")]
	public RenderBuffer get_depthBuffer() { }

	[Address(RVA = "0x3038C70", Offset = "0x3038070", Length = "0x76")]
	[Token(Token = "0x6000EFE")]
	public GraphicsFormat get_depthStencilFormat() { }

	[Address(RVA = "0x3038C30", Offset = "0x3038030", Length = "0x33")]
	[Token(Token = "0x6000F43")]
	private static GraphicsFormat get_depthStencilFormat_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3038CF0", Offset = "0x30380F0", Length = "0xD5")]
	[Token(Token = "0x6000F2F")]
	public RenderTextureDescriptor get_descriptor() { }

	[Address(RVA = "0x3038E10", Offset = "0x3038210", Length = "0x76")]
	[Token(Token = "0x6000EF4")]
	public virtual TextureDimension get_dimension() { }

	[Address(RVA = "0x3038DD0", Offset = "0x30381D0", Length = "0x33")]
	[Token(Token = "0x6000F3C")]
	private static TextureDimension get_dimension_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3038ED0", Offset = "0x30382D0", Length = "0x76")]
	[Token(Token = "0x6000F09")]
	public bool get_enableShadingRate() { }

	[Address(RVA = "0x3038E90", Offset = "0x3038290", Length = "0x33")]
	[Token(Token = "0x6000F4E")]
	private static bool get_enableShadingRate_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3038F50", Offset = "0x3038350", Length = "0x1A1")]
	[Token(Token = "0x6000EFD")]
	public RenderTextureFormat get_format() { }

	[Address(RVA = "0x3039100", Offset = "0x3038500", Length = "0x78")]
	[Token(Token = "0x6000EF8")]
	public GraphicsFormat get_graphicsFormat() { }

	[Address(RVA = "0x30391C0", Offset = "0x30385C0", Length = "0x76")]
	[Token(Token = "0x6000EF2")]
	public virtual int get_height() { }

	[Address(RVA = "0x3039180", Offset = "0x3038580", Length = "0x33")]
	[Token(Token = "0x6000F3A")]
	private static int get_height_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3039280", Offset = "0x3038680", Length = "0x76")]
	[Token(Token = "0x6000EFC")]
	public bool get_sRGB() { }

	[Address(RVA = "0x3039240", Offset = "0x3038640", Length = "0x33")]
	[Token(Token = "0x6000F42")]
	private static bool get_sRGB_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3039400", Offset = "0x3038800", Length = "0x76")]
	[Token(Token = "0x6000F06")]
	public bool get_useDynamicScale() { }

	[Address(RVA = "0x30393C0", Offset = "0x30387C0", Length = "0x33")]
	[Token(Token = "0x6000F4B")]
	private static bool get_useDynamicScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3039340", Offset = "0x3038740", Length = "0x76")]
	[Token(Token = "0x6000F08")]
	public bool get_useDynamicScaleExplicit() { }

	[Address(RVA = "0x3039300", Offset = "0x3038700", Length = "0x33")]
	[Token(Token = "0x6000F4D")]
	private static bool get_useDynamicScaleExplicit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30394C0", Offset = "0x30388C0", Length = "0x76")]
	[Token(Token = "0x6000EFA")]
	public bool get_useMipMap() { }

	[Address(RVA = "0x3039480", Offset = "0x3038880", Length = "0x33")]
	[Token(Token = "0x6000F40")]
	private static bool get_useMipMap_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3039580", Offset = "0x3038980", Length = "0x76")]
	[Token(Token = "0x6000F01")]
	public int get_volumeDepth() { }

	[Address(RVA = "0x3039540", Offset = "0x3038940", Length = "0x33")]
	[Token(Token = "0x6000F46")]
	private static int get_volumeDepth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3039640", Offset = "0x3038A40", Length = "0x76")]
	[Token(Token = "0x6000EF0")]
	public virtual int get_width() { }

	[Address(RVA = "0x3039600", Offset = "0x3038A00", Length = "0x33")]
	[Token(Token = "0x6000F38")]
	private static int get_width_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3036000", Offset = "0x3035400", Length = "0x54")]
	[FreeFunction("RenderTexture::GetActiveAsRenderTexture")]
	[Token(Token = "0x6000F0B")]
	private static RenderTexture GetActive() { }

	[Address(RVA = "0x3035FD0", Offset = "0x30353D0", Length = "0x2A")]
	[Token(Token = "0x6000F50")]
	private static IntPtr GetActive_Injected() { }

	[Address(RVA = "0x30360B0", Offset = "0x30354B0", Length = "0x8E")]
	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6000F0F")]
	private RenderBuffer GetColorBuffer() { }

	[Address(RVA = "0x3036060", Offset = "0x3035460", Length = "0x42")]
	[Token(Token = "0x6000F52")]
	private static void GetColorBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	[Address(RVA = "0x3036190", Offset = "0x3035590", Length = "0x86")]
	[NativeName("GetColorFormat")]
	[Token(Token = "0x6000EF6")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	[Address(RVA = "0x3036140", Offset = "0x3035540", Length = "0x42")]
	[Token(Token = "0x6000F3E")]
	private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings) { }

	[Address(RVA = "0x3036220", Offset = "0x3035620", Length = "0x128")]
	[Token(Token = "0x6000F36")]
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	[Address(RVA = "0x3036350", Offset = "0x3035750", Length = "0x1F")]
	[Token(Token = "0x6000F31")]
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	[Address(RVA = "0x3036370", Offset = "0x3035770", Length = "0x30")]
	[Token(Token = "0x6000F32")]
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[Address(RVA = "0x30363F0", Offset = "0x30357F0", Length = "0x8E")]
	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6000F10")]
	private RenderBuffer GetDepthBuffer() { }

	[Address(RVA = "0x30363A0", Offset = "0x30357A0", Length = "0x42")]
	[Token(Token = "0x6000F53")]
	private static void GetDepthBuffer_Injected(IntPtr _unity_self, out RenderBuffer ret) { }

	[Address(RVA = "0x30364D0", Offset = "0x30358D0", Length = "0xFD")]
	[Token(Token = "0x6000F2E")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	[Address(RVA = "0x3036480", Offset = "0x3035880", Length = "0x10")]
	[Token(Token = "0x6000F2D")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode) { }

	[Address(RVA = "0x30365E0", Offset = "0x30359E0", Length = "0x10")]
	[Token(Token = "0x6000F2C")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	[Address(RVA = "0x3036490", Offset = "0x3035890", Length = "0x3D")]
	[Token(Token = "0x6000F2B")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = false) { }

	[Address(RVA = "0x30365D0", Offset = "0x30359D0", Length = "0xC")]
	[Token(Token = "0x6000F2A")]
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	[Address(RVA = "0x3036640", Offset = "0x3035A40", Length = "0x9B")]
	[NativeName("GetRenderTextureDesc")]
	[Token(Token = "0x6000F1A")]
	private RenderTextureDescriptor GetDescriptor() { }

	[Address(RVA = "0x30365F0", Offset = "0x30359F0", Length = "0x42")]
	[Token(Token = "0x6000F5A")]
	private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret) { }

	[Address(RVA = "0x30366E0", Offset = "0x3035AE0", Length = "0x10")]
	[Token(Token = "0x6000F33")]
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	[Address(RVA = "0x30366E0", Offset = "0x3035AE0", Length = "0x10")]
	[Token(Token = "0x6000F34")]
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	[Address(RVA = "0x3036790", Offset = "0x3035B90", Length = "0x95")]
	[Token(Token = "0x6000F37")]
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x3036730", Offset = "0x3035B30", Length = "0x5E")]
	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	[Token(Token = "0x6000F1B")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x30366F0", Offset = "0x3035AF0", Length = "0x33")]
	[Token(Token = "0x6000F5B")]
	private static IntPtr GetTemporary_Internal_Injected(in RenderTextureDescriptor desc) { }

	[Address(RVA = "0x3036830", Offset = "0x3035C30", Length = "0x3FC")]
	[Token(Token = "0x6000F29")]
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[Address(RVA = "0x3036C30", Offset = "0x3036030", Length = "0x33")]
	[FreeFunction("RenderTextureScripting::Create")]
	[Token(Token = "0x6000F18")]
	private static void Internal_Create(RenderTexture rt) { }

	[Address(RVA = "0x3036D60", Offset = "0x3036160", Length = "0x76")]
	[Token(Token = "0x6000F16")]
	public void Release() { }

	[Address(RVA = "0x3036D20", Offset = "0x3036120", Length = "0x33")]
	[Token(Token = "0x6000F57")]
	private static void Release_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3036CB0", Offset = "0x30360B0", Length = "0x6B")]
	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	[Token(Token = "0x6000F1C")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	[Address(RVA = "0x3036C70", Offset = "0x3036070", Length = "0x33")]
	[Token(Token = "0x6000F5C")]
	private static void ReleaseTemporary_Injected(IntPtr temp) { }

	[Address(RVA = "0x3036E20", Offset = "0x3036220", Length = "0x6B")]
	[Token(Token = "0x6000F0E")]
	public static void set_active(RenderTexture value) { }

	[Address(RVA = "0x3039710", Offset = "0x3038B10", Length = "0x86")]
	[Token(Token = "0x6000F00")]
	public void set_autoGenerateMips(bool value) { }

	[Address(RVA = "0x30396C0", Offset = "0x3038AC0", Length = "0x42")]
	[Token(Token = "0x6000F45")]
	private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30397E0", Offset = "0x3038BE0", Length = "0x83")]
	[Token(Token = "0x6000EFF")]
	public void set_depthStencilFormat(GraphicsFormat value) { }

	[Address(RVA = "0x30397A0", Offset = "0x3038BA0", Length = "0x40")]
	[Token(Token = "0x6000F44")]
	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	[Address(RVA = "0x30398B0", Offset = "0x3038CB0", Length = "0x83")]
	[Token(Token = "0x6000EF5")]
	public virtual void set_dimension(TextureDimension value) { }

	[Address(RVA = "0x3039870", Offset = "0x3038C70", Length = "0x40")]
	[Token(Token = "0x6000F3D")]
	private static void set_dimension_Injected(IntPtr _unity_self, TextureDimension value) { }

	[Address(RVA = "0x3039990", Offset = "0x3038D90", Length = "0x86")]
	[Token(Token = "0x6000F05")]
	public void set_enableRandomWrite(bool value) { }

	[Address(RVA = "0x3039940", Offset = "0x3038D40", Length = "0x42")]
	[Token(Token = "0x6000F4A")]
	private static void set_enableRandomWrite_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3036ED0", Offset = "0x30362D0", Length = "0x83")]
	[Token(Token = "0x6000EF9")]
	public void set_graphicsFormat(GraphicsFormat value) { }

	[Address(RVA = "0x3039A60", Offset = "0x3038E60", Length = "0x83")]
	[Token(Token = "0x6000EF3")]
	public virtual void set_height(int value) { }

	[Address(RVA = "0x3039A20", Offset = "0x3038E20", Length = "0x40")]
	[Token(Token = "0x6000F3B")]
	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3039B40", Offset = "0x3038F40", Length = "0x86")]
	[Token(Token = "0x6000F07")]
	public void set_useDynamicScale(bool value) { }

	[Address(RVA = "0x3039AF0", Offset = "0x3038EF0", Length = "0x42")]
	[Token(Token = "0x6000F4C")]
	private static void set_useDynamicScale_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3039C20", Offset = "0x3039020", Length = "0x86")]
	[Token(Token = "0x6000EFB")]
	public void set_useMipMap(bool value) { }

	[Address(RVA = "0x3039BD0", Offset = "0x3038FD0", Length = "0x42")]
	[Token(Token = "0x6000F41")]
	private static void set_useMipMap_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3039CF0", Offset = "0x30390F0", Length = "0x83")]
	[Token(Token = "0x6000F02")]
	public void set_volumeDepth(int value) { }

	[Address(RVA = "0x3039CB0", Offset = "0x30390B0", Length = "0x40")]
	[Token(Token = "0x6000F47")]
	private static void set_volumeDepth_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3039DC0", Offset = "0x30391C0", Length = "0x83")]
	[Token(Token = "0x6000EF1")]
	public virtual void set_width(int value) { }

	[Address(RVA = "0x3039D80", Offset = "0x3039180", Length = "0x40")]
	[Token(Token = "0x6000F39")]
	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3036E20", Offset = "0x3036220", Length = "0x6B")]
	[FreeFunction("RenderTextureScripting::SetActive")]
	[Token(Token = "0x6000F0C")]
	private static void SetActive(RenderTexture rt) { }

	[Address(RVA = "0x3036DE0", Offset = "0x30361E0", Length = "0x33")]
	[Token(Token = "0x6000F51")]
	private static void SetActive_Injected(IntPtr rt) { }

	[Address(RVA = "0x3036ED0", Offset = "0x30362D0", Length = "0x83")]
	[NativeName("SetColorFormat")]
	[Token(Token = "0x6000EF7")]
	private void SetColorFormat(GraphicsFormat format) { }

	[Address(RVA = "0x3036E90", Offset = "0x3036290", Length = "0x40")]
	[Token(Token = "0x6000F3F")]
	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	[Address(RVA = "0x3036FA0", Offset = "0x30363A0", Length = "0x83")]
	[Token(Token = "0x6000F11")]
	private void SetMipMapCount(int count) { }

	[Address(RVA = "0x3036F60", Offset = "0x3036360", Length = "0x40")]
	[Token(Token = "0x6000F54")]
	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	[Address(RVA = "0x3037080", Offset = "0x3036480", Length = "0x85")]
	[NativeName("SetRenderTextureDescFromScript")]
	[Token(Token = "0x6000F19")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x3037030", Offset = "0x3036430", Length = "0x42")]
	[Token(Token = "0x6000F59")]
	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, in RenderTextureDescriptor desc) { }

	[Address(RVA = "0x3037230", Offset = "0x3036630", Length = "0x83")]
	[Token(Token = "0x6000F12")]
	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	[Address(RVA = "0x30371F0", Offset = "0x30365F0", Length = "0x40")]
	[Token(Token = "0x6000F55")]
	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	[Address(RVA = "0x3037160", Offset = "0x3036560", Length = "0x86")]
	[Token(Token = "0x6000F17")]
	internal void SetSRGBReadWrite(bool srgb) { }

	[Address(RVA = "0x3037110", Offset = "0x3036510", Length = "0x42")]
	[Token(Token = "0x6000F58")]
	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	[Address(RVA = "0x30372C0", Offset = "0x30366C0", Length = "0x532")]
	[Token(Token = "0x6000F30")]
	private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc) { }

	[Address(RVA = "0x3037800", Offset = "0x3036C00", Length = "0x8B")]
	[Token(Token = "0x6000F35")]
	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

}

