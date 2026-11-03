namespace UnityEngine;

[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfoRendering.h")]
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Misc/SystemInfoAudio.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[Token(Token = "0x20001EB")]
public sealed class SystemInfo
{

	[Token(Token = "0x17000316")]
	public static CopyTextureSupport copyTextureSupport
	{
		[Address(RVA = "0x308A170", Offset = "0x3089570", Length = "0x2A")]
		[Token(Token = "0x600157F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700030B")]
	public static string deviceModel
	{
		[Address(RVA = "0x308AFA0", Offset = "0x308A3A0", Length = "0x9")]
		[Token(Token = "0x6001574")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700030A")]
	public static string deviceName
	{
		[Address(RVA = "0x308AFB0", Offset = "0x308A3B0", Length = "0x9")]
		[Token(Token = "0x6001573")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700030C")]
	public static DeviceType deviceType
	{
		[Address(RVA = "0x308A340", Offset = "0x3089740", Length = "0x2A")]
		[Token(Token = "0x6001575")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000313")]
	public static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[Address(RVA = "0x308A370", Offset = "0x3089770", Length = "0x2A")]
		[Token(Token = "0x600157C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700030D")]
	public static string graphicsDeviceName
	{
		[Address(RVA = "0x308AFC0", Offset = "0x308A3C0", Length = "0x9")]
		[Token(Token = "0x6001576")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000310")]
	public static GraphicsDeviceType graphicsDeviceType
	{
		[Address(RVA = "0x308A470", Offset = "0x3089870", Length = "0x2A")]
		[Token(Token = "0x6001579")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700030E")]
	public static string graphicsDeviceVendor
	{
		[Address(RVA = "0x308AFD0", Offset = "0x308A3D0", Length = "0x9")]
		[Token(Token = "0x6001577")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700030F")]
	public static int graphicsDeviceVendorID
	{
		[Address(RVA = "0x308A4A0", Offset = "0x30898A0", Length = "0x2A")]
		[Token(Token = "0x6001578")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000312")]
	public static int graphicsShaderLevel
	{
		[Address(RVA = "0x308A5E0", Offset = "0x30899E0", Length = "0x2A")]
		[Token(Token = "0x600157B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000311")]
	public static bool graphicsUVStartsAtTop
	{
		[Address(RVA = "0x308A610", Offset = "0x3089A10", Length = "0x2A")]
		[Token(Token = "0x600157A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000314")]
	public static bool hasHiddenSurfaceRemovalOnGPU
	{
		[Address(RVA = "0x308A890", Offset = "0x3089C90", Length = "0x2A")]
		[Token(Token = "0x600157D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000327")]
	public static HDRDisplaySupportFlags hdrDisplaySupportFlags
	{
		[Address(RVA = "0x308A640", Offset = "0x3089A40", Length = "0x2A")]
		[Token(Token = "0x6001593")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000326")]
	public static long maxGraphicsBufferSize
	{
		[Address(RVA = "0x308A9A0", Offset = "0x3089DA0", Length = "0x2A")]
		[Token(Token = "0x6001592")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000323")]
	internal static int maxRenderTextureSize
	{
		[Address(RVA = "0x308A670", Offset = "0x3089A70", Length = "0x2A")]
		[Token(Token = "0x600158F")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x17000322")]
	public static int maxTextureSize
	{
		[Address(RVA = "0x308A6A0", Offset = "0x3089AA0", Length = "0x2A")]
		[Token(Token = "0x600158E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000321")]
	public static int maxTiledPixelStorageSize
	{
		[Address(RVA = "0x308A9D0", Offset = "0x3089DD0", Length = "0x2A")]
		[Token(Token = "0x600158A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000308")]
	public static string operatingSystem
	{
		[Address(RVA = "0x308AFE0", Offset = "0x308A3E0", Length = "0x9")]
		[Token(Token = "0x6001571")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000309")]
	public static OperatingSystemFamily operatingSystemFamily
	{
		[Address(RVA = "0x308A6D0", Offset = "0x3089AD0", Length = "0x2A")]
		[Token(Token = "0x6001572")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031A")]
	public static int supportedRenderTargetCount
	{
		[Address(RVA = "0x308AA00", Offset = "0x3089E00", Length = "0x2A")]
		[Token(Token = "0x6001583")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000317")]
	public static bool supportsComputeShaders
	{
		[Address(RVA = "0x308AA30", Offset = "0x3089E30", Length = "0x2A")]
		[Token(Token = "0x6001580")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000324")]
	public static bool supportsGraphicsFence
	{
		[Address(RVA = "0x308AA60", Offset = "0x3089E60", Length = "0x2A")]
		[Token(Token = "0x6001590")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700032C")]
	public static bool supportsIndirectArgumentsBuffer
	{
		[Address(RVA = "0x308AA90", Offset = "0x3089E90", Length = "0x2A")]
		[Token(Token = "0x6001598")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000319")]
	public static bool supportsInstancing
	{
		[Address(RVA = "0x308AAC0", Offset = "0x3089EC0", Length = "0x2A")]
		[Token(Token = "0x6001582")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031D")]
	public static bool supportsMemorylessTextures
	{
		[Address(RVA = "0x308AAF0", Offset = "0x3089EF0", Length = "0x2A")]
		[Token(Token = "0x6001586")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031E")]
	public static bool supportsMultisampleAutoResolve
	{
		[Address(RVA = "0x308AB20", Offset = "0x3089F20", Length = "0x2A")]
		[Token(Token = "0x6001587")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031C")]
	public static bool supportsMultisampledBackBuffer
	{
		[Address(RVA = "0x308ABB0", Offset = "0x3089FB0", Length = "0x2A")]
		[Token(Token = "0x6001585")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031F")]
	public static bool supportsMultisampledShaderResolve
	{
		[Address(RVA = "0x308ABE0", Offset = "0x3089FE0", Length = "0x2A")]
		[Token(Token = "0x6001588")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700031B")]
	public static int supportsMultisampledTextures
	{
		[Address(RVA = "0x308AC10", Offset = "0x308A010", Length = "0x2A")]
		[Token(Token = "0x6001584")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700032A")]
	public static bool supportsMultisampleResolveDepth
	{
		[Address(RVA = "0x308AB50", Offset = "0x3089F50", Length = "0x2A")]
		[Token(Token = "0x6001596")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700032B")]
	public static bool supportsMultisampleResolveStencil
	{
		[Address(RVA = "0x308AB80", Offset = "0x3089F80", Length = "0x2A")]
		[Token(Token = "0x6001597")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000328")]
	public static bool supportsMultiview
	{
		[Address(RVA = "0x308AC40", Offset = "0x308A040", Length = "0x2A")]
		[Token(Token = "0x6001594")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000325")]
	public static bool supportsRayTracing
	{
		[Address(RVA = "0x308AC70", Offset = "0x308A070", Length = "0x2A")]
		[Token(Token = "0x6001591")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000318")]
	public static bool supportsRenderTargetArrayIndexFromVertexShader
	{
		[Address(RVA = "0x308ACA0", Offset = "0x308A0A0", Length = "0x2A")]
		[Token(Token = "0x6001581")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000315")]
	public static bool supportsShadows
	{
		[Address(RVA = "0x308ADD0", Offset = "0x308A1D0", Length = "0x2A")]
		[Token(Token = "0x600157E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000329")]
	public static bool supportsStoreAndResolveAction
	{
		[Address(RVA = "0x308AE00", Offset = "0x308A200", Length = "0x2A")]
		[Token(Token = "0x6001595")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000320")]
	public static bool usesReversedZBuffer
	{
		[Address(RVA = "0x308AF70", Offset = "0x308A370", Length = "0x2A")]
		[Token(Token = "0x6001589")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x308A170", Offset = "0x3089570", Length = "0x2A")]
	[Token(Token = "0x600157F")]
	public static CopyTextureSupport get_copyTextureSupport() { }

	[Address(RVA = "0x308AFA0", Offset = "0x308A3A0", Length = "0x9")]
	[Token(Token = "0x6001574")]
	public static string get_deviceModel() { }

	[Address(RVA = "0x308AFB0", Offset = "0x308A3B0", Length = "0x9")]
	[Token(Token = "0x6001573")]
	public static string get_deviceName() { }

	[Address(RVA = "0x308A340", Offset = "0x3089740", Length = "0x2A")]
	[Token(Token = "0x6001575")]
	public static DeviceType get_deviceType() { }

	[Address(RVA = "0x308A370", Offset = "0x3089770", Length = "0x2A")]
	[Token(Token = "0x600157C")]
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[Address(RVA = "0x308AFC0", Offset = "0x308A3C0", Length = "0x9")]
	[Token(Token = "0x6001576")]
	public static string get_graphicsDeviceName() { }

	[Address(RVA = "0x308A470", Offset = "0x3089870", Length = "0x2A")]
	[Token(Token = "0x6001579")]
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	[Address(RVA = "0x308AFD0", Offset = "0x308A3D0", Length = "0x9")]
	[Token(Token = "0x6001577")]
	public static string get_graphicsDeviceVendor() { }

	[Address(RVA = "0x308A4A0", Offset = "0x30898A0", Length = "0x2A")]
	[Token(Token = "0x6001578")]
	public static int get_graphicsDeviceVendorID() { }

	[Address(RVA = "0x308A5E0", Offset = "0x30899E0", Length = "0x2A")]
	[Token(Token = "0x600157B")]
	public static int get_graphicsShaderLevel() { }

	[Address(RVA = "0x308A610", Offset = "0x3089A10", Length = "0x2A")]
	[Token(Token = "0x600157A")]
	public static bool get_graphicsUVStartsAtTop() { }

	[Address(RVA = "0x308A890", Offset = "0x3089C90", Length = "0x2A")]
	[Token(Token = "0x600157D")]
	public static bool get_hasHiddenSurfaceRemovalOnGPU() { }

	[Address(RVA = "0x308A640", Offset = "0x3089A40", Length = "0x2A")]
	[Token(Token = "0x6001593")]
	public static HDRDisplaySupportFlags get_hdrDisplaySupportFlags() { }

	[Address(RVA = "0x308A9A0", Offset = "0x3089DA0", Length = "0x2A")]
	[Token(Token = "0x6001592")]
	public static long get_maxGraphicsBufferSize() { }

	[Address(RVA = "0x308A670", Offset = "0x3089A70", Length = "0x2A")]
	[Token(Token = "0x600158F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_maxRenderTextureSize() { }

	[Address(RVA = "0x308A6A0", Offset = "0x3089AA0", Length = "0x2A")]
	[Token(Token = "0x600158E")]
	public static int get_maxTextureSize() { }

	[Address(RVA = "0x308A9D0", Offset = "0x3089DD0", Length = "0x2A")]
	[Token(Token = "0x600158A")]
	public static int get_maxTiledPixelStorageSize() { }

	[Address(RVA = "0x308AFE0", Offset = "0x308A3E0", Length = "0x9")]
	[Token(Token = "0x6001571")]
	public static string get_operatingSystem() { }

	[Address(RVA = "0x308A6D0", Offset = "0x3089AD0", Length = "0x2A")]
	[Token(Token = "0x6001572")]
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	[Address(RVA = "0x308AA00", Offset = "0x3089E00", Length = "0x2A")]
	[Token(Token = "0x6001583")]
	public static int get_supportedRenderTargetCount() { }

	[Address(RVA = "0x308AA30", Offset = "0x3089E30", Length = "0x2A")]
	[Token(Token = "0x6001580")]
	public static bool get_supportsComputeShaders() { }

	[Address(RVA = "0x308AA60", Offset = "0x3089E60", Length = "0x2A")]
	[Token(Token = "0x6001590")]
	public static bool get_supportsGraphicsFence() { }

	[Address(RVA = "0x308AA90", Offset = "0x3089E90", Length = "0x2A")]
	[Token(Token = "0x6001598")]
	public static bool get_supportsIndirectArgumentsBuffer() { }

	[Address(RVA = "0x308AAC0", Offset = "0x3089EC0", Length = "0x2A")]
	[Token(Token = "0x6001582")]
	public static bool get_supportsInstancing() { }

	[Address(RVA = "0x308AAF0", Offset = "0x3089EF0", Length = "0x2A")]
	[Token(Token = "0x6001586")]
	public static bool get_supportsMemorylessTextures() { }

	[Address(RVA = "0x308AB20", Offset = "0x3089F20", Length = "0x2A")]
	[Token(Token = "0x6001587")]
	public static bool get_supportsMultisampleAutoResolve() { }

	[Address(RVA = "0x308ABB0", Offset = "0x3089FB0", Length = "0x2A")]
	[Token(Token = "0x6001585")]
	public static bool get_supportsMultisampledBackBuffer() { }

	[Address(RVA = "0x308ABE0", Offset = "0x3089FE0", Length = "0x2A")]
	[Token(Token = "0x6001588")]
	public static bool get_supportsMultisampledShaderResolve() { }

	[Address(RVA = "0x308AC10", Offset = "0x308A010", Length = "0x2A")]
	[Token(Token = "0x6001584")]
	public static int get_supportsMultisampledTextures() { }

	[Address(RVA = "0x308AB50", Offset = "0x3089F50", Length = "0x2A")]
	[Token(Token = "0x6001596")]
	public static bool get_supportsMultisampleResolveDepth() { }

	[Address(RVA = "0x308AB80", Offset = "0x3089F80", Length = "0x2A")]
	[Token(Token = "0x6001597")]
	public static bool get_supportsMultisampleResolveStencil() { }

	[Address(RVA = "0x308AC40", Offset = "0x308A040", Length = "0x2A")]
	[Token(Token = "0x6001594")]
	public static bool get_supportsMultiview() { }

	[Address(RVA = "0x308AC70", Offset = "0x308A070", Length = "0x2A")]
	[Token(Token = "0x6001591")]
	public static bool get_supportsRayTracing() { }

	[Address(RVA = "0x308ACA0", Offset = "0x308A0A0", Length = "0x2A")]
	[Token(Token = "0x6001581")]
	public static bool get_supportsRenderTargetArrayIndexFromVertexShader() { }

	[Address(RVA = "0x308ADD0", Offset = "0x308A1D0", Length = "0x2A")]
	[Token(Token = "0x600157E")]
	public static bool get_supportsShadows() { }

	[Address(RVA = "0x308AE00", Offset = "0x308A200", Length = "0x2A")]
	[Token(Token = "0x6001595")]
	public static bool get_supportsStoreAndResolveAction() { }

	[Address(RVA = "0x308AF70", Offset = "0x308A370", Length = "0x2A")]
	[Token(Token = "0x6001589")]
	public static bool get_usesReversedZBuffer() { }

	[Address(RVA = "0x308A130", Offset = "0x3089530", Length = "0x3E")]
	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	[Token(Token = "0x60015BA")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[Address(RVA = "0x308A170", Offset = "0x3089570", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	[Token(Token = "0x60015A7")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[Address(RVA = "0x308A1E0", Offset = "0x30895E0", Length = "0x82")]
	[FreeFunction("systeminfo::GetDeviceModel")]
	[Token(Token = "0x600159C")]
	private static string GetDeviceModel() { }

	[Address(RVA = "0x308A1A0", Offset = "0x30895A0", Length = "0x33")]
	[Token(Token = "0x60015C7")]
	private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308A2B0", Offset = "0x30896B0", Length = "0x82")]
	[FreeFunction("systeminfo::GetDeviceName")]
	[Token(Token = "0x600159B")]
	private static string GetDeviceName() { }

	[Address(RVA = "0x308A270", Offset = "0x3089670", Length = "0x33")]
	[Token(Token = "0x60015C6")]
	private static void GetDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308A340", Offset = "0x3089740", Length = "0x2A")]
	[FreeFunction("systeminfo::GetDeviceType")]
	[Token(Token = "0x600159D")]
	private static DeviceType GetDeviceType() { }

	[Address(RVA = "0x308A370", Offset = "0x3089770", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetFoveatedRenderingCaps")]
	[Token(Token = "0x60015A4")]
	private static FoveatedRenderingCaps GetFoveatedRenderingCaps() { }

	[Address(RVA = "0x308A3E0", Offset = "0x30897E0", Length = "0x82")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	[Token(Token = "0x600159E")]
	private static string GetGraphicsDeviceName() { }

	[Address(RVA = "0x308A3A0", Offset = "0x30897A0", Length = "0x33")]
	[Token(Token = "0x60015C8")]
	private static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308A470", Offset = "0x3089870", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	[Token(Token = "0x60015A1")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[Address(RVA = "0x308A510", Offset = "0x3089910", Length = "0x82")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
	[Token(Token = "0x600159F")]
	private static string GetGraphicsDeviceVendor() { }

	[Address(RVA = "0x308A4D0", Offset = "0x30898D0", Length = "0x33")]
	[Token(Token = "0x60015C9")]
	private static void GetGraphicsDeviceVendor_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308A4A0", Offset = "0x30898A0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
	[Token(Token = "0x60015A0")]
	private static int GetGraphicsDeviceVendorID() { }

	[Address(RVA = "0x308A5A0", Offset = "0x30899A0", Length = "0x31")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	[Token(Token = "0x60015BB")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[Address(RVA = "0x308A5E0", Offset = "0x30899E0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	[Token(Token = "0x60015A3")]
	private static int GetGraphicsShaderLevel() { }

	[Address(RVA = "0x308A610", Offset = "0x3089A10", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	[Token(Token = "0x60015A2")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[Address(RVA = "0x308A640", Offset = "0x3089A40", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetHDRDisplaySupportFlags")]
	[Token(Token = "0x60015BE")]
	private static HDRDisplaySupportFlags GetHDRDisplaySupportFlags() { }

	[Address(RVA = "0x308A670", Offset = "0x3089A70", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	[Token(Token = "0x60015B5")]
	private static int GetMaxRenderTextureSize() { }

	[Address(RVA = "0x308A6A0", Offset = "0x3089AA0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	[Token(Token = "0x60015B4")]
	private static int GetMaxTextureSize() { }

	[Address(RVA = "0x308A740", Offset = "0x3089B40", Length = "0x82")]
	[FreeFunction("systeminfo::GetOperatingSystem")]
	[Token(Token = "0x6001599")]
	private static string GetOperatingSystem() { }

	[Address(RVA = "0x308A700", Offset = "0x3089B00", Length = "0x33")]
	[Token(Token = "0x60015C5")]
	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x308A6D0", Offset = "0x3089AD0", Length = "0x2A")]
	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	[Token(Token = "0x600159A")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[Address(RVA = "0x308A810", Offset = "0x3089C10", Length = "0x33")]
	[FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
	[Token(Token = "0x60015BC")]
	public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc) { }

	[Address(RVA = "0x308A7D0", Offset = "0x3089BD0", Length = "0x33")]
	[Token(Token = "0x60015CA")]
	private static int GetRenderTextureSupportedMSAASampleCount_Injected(in RenderTextureDescriptor desc) { }

	[Address(RVA = "0x308A850", Offset = "0x3089C50", Length = "0x3E")]
	[FreeFunction("ScriptingGraphicsCaps::GetTiledRenderTargetStorageSize")]
	[Token(Token = "0x60015BD")]
	public static int GetTiledRenderTargetStorageSize(GraphicsFormat format, int sampleCount) { }

	[Address(RVA = "0x308A890", Offset = "0x3089C90", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::HasHiddenSurfaceRemovalOnGPU")]
	[Token(Token = "0x60015A5")]
	private static bool HasHiddenSurfaceRemovalOnGPU() { }

	[Address(RVA = "0x308A8C0", Offset = "0x3089CC0", Length = "0x31")]
	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	[Token(Token = "0x60015B2")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[Address(RVA = "0x308A900", Offset = "0x3089D00", Length = "0x3E")]
	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	[Token(Token = "0x60015B9")]
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[Address(RVA = "0x308A940", Offset = "0x3089D40", Length = "0x50")]
	[Token(Token = "0x600158B")]
	private static bool IsValidEnumValue(Enum value) { }

	[Address(RVA = "0x308A9A0", Offset = "0x3089DA0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	[Token(Token = "0x60015B8")]
	private static long MaxGraphicsBufferSize() { }

	[Address(RVA = "0x308A9D0", Offset = "0x3089DD0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::MaxTiledPixelStorageSize")]
	[Token(Token = "0x60015C4")]
	private static int MaxTiledPixelStorageSize() { }

	[Address(RVA = "0x308AA00", Offset = "0x3089E00", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	[Token(Token = "0x60015AB")]
	private static int SupportedRenderTargetCount() { }

	[Address(RVA = "0x308AA30", Offset = "0x3089E30", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	[Token(Token = "0x60015A8")]
	private static bool SupportsComputeShaders() { }

	[Address(RVA = "0x308AA60", Offset = "0x3089E60", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsGPUFence")]
	[Token(Token = "0x60015B6")]
	private static bool SupportsGPUFence() { }

	[Address(RVA = "0x308AA90", Offset = "0x3089E90", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsIndirectArgumentsBuffer")]
	[Token(Token = "0x60015C3")]
	private static bool SupportsIndirectArgumentsBuffer() { }

	[Address(RVA = "0x308AAC0", Offset = "0x3089EC0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	[Token(Token = "0x60015AA")]
	private static bool SupportsInstancing() { }

	[Address(RVA = "0x308AAF0", Offset = "0x3089EF0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMemorylessTextures")]
	[Token(Token = "0x60015AE")]
	private static bool SupportsMemorylessTextures() { }

	[Address(RVA = "0x308AB20", Offset = "0x3089F20", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleAutoResolve")]
	[Token(Token = "0x60015AF")]
	private static bool SupportsMultisampleAutoResolve() { }

	[Address(RVA = "0x308ABB0", Offset = "0x3089FB0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledBackBuffer")]
	[Token(Token = "0x60015AD")]
	private static bool SupportsMultisampledBackBuffer() { }

	[Address(RVA = "0x308ABE0", Offset = "0x3089FE0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledShaderResolve")]
	[Token(Token = "0x60015B0")]
	private static bool SupportsMultisampledShaderResolve() { }

	[Address(RVA = "0x308AC10", Offset = "0x308A010", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledTextures")]
	[Token(Token = "0x60015AC")]
	private static int SupportsMultisampledTextures() { }

	[Address(RVA = "0x308AB50", Offset = "0x3089F50", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveDepth")]
	[Token(Token = "0x60015C1")]
	private static bool SupportsMultisampleResolveDepth() { }

	[Address(RVA = "0x308AB80", Offset = "0x3089F80", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveStencil")]
	[Token(Token = "0x60015C2")]
	private static bool SupportsMultisampleResolveStencil() { }

	[Address(RVA = "0x308AC40", Offset = "0x308A040", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsMultiview")]
	[Token(Token = "0x60015BF")]
	private static bool SupportsMultiview() { }

	[Address(RVA = "0x308AC70", Offset = "0x308A070", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsRayTracing")]
	[Token(Token = "0x60015B7")]
	private static bool SupportsRayTracing() { }

	[Address(RVA = "0x308ACA0", Offset = "0x308A0A0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsRenderTargetArrayIndexFromVertexShader")]
	[Token(Token = "0x60015A9")]
	private static bool SupportsRenderTargetArrayIndexFromVertexShader() { }

	[Address(RVA = "0x308ACD0", Offset = "0x308A0D0", Length = "0xFF")]
	[Token(Token = "0x600158C")]
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	[Address(RVA = "0x308ADD0", Offset = "0x308A1D0", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
	[Token(Token = "0x60015A6")]
	private static bool SupportsShadows() { }

	[Address(RVA = "0x308AE00", Offset = "0x308A200", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsStoreAndResolveAction")]
	[Token(Token = "0x60015C0")]
	private static bool SupportsStoreAndResolveAction() { }

	[Address(RVA = "0x308AE70", Offset = "0x308A270", Length = "0xFF")]
	[Token(Token = "0x600158D")]
	public static bool SupportsTextureFormat(TextureFormat format) { }

	[Address(RVA = "0x308AE30", Offset = "0x308A230", Length = "0x31")]
	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	[Token(Token = "0x60015B3")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[Address(RVA = "0x308AF70", Offset = "0x308A370", Length = "0x2A")]
	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	[Token(Token = "0x60015B1")]
	private static bool UsesReversedZBuffer() { }

}

