namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000379")]
public sealed class GraphicsSettings : object
{
	[Token(Token = "0x4000A7B")]
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; //Field offset: 0x0

	[Token(Token = "0x170003D4")]
	public static RenderPipelineAsset currentRenderPipeline
	{
		[Address(RVA = "0x30B5B70", Offset = "0x30B4F70", Length = "0x93")]
		[Token(Token = "0x6001A42")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170003D6")]
	public static Type currentRenderPipelineAssetType
	{
		[Address(RVA = "0x30B5A80", Offset = "0x30B4E80", Length = "0xE1")]
		[Token(Token = "0x6001A44")]
		 get { } //Length: 225
	}

	[NativeName("CurrentRenderPipeline")]
	[Token(Token = "0x170003D3")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		[Address(RVA = "0x30B5A00", Offset = "0x30B4E00", Length = "0x75")]
		[Token(Token = "0x6001A41")]
		private get { } //Length: 117
	}

	[Token(Token = "0x170003D5")]
	public static bool isScriptableRenderPipelineEnabled
	{
		[Address(RVA = "0x30B5C10", Offset = "0x30B5010", Length = "0x74")]
		[Token(Token = "0x6001A43")]
		 get { } //Length: 116
	}

	[Token(Token = "0x170003D1")]
	public static bool lightsUseColorTemperature
	{
		[Address(RVA = "0x30B5CC0", Offset = "0x30B50C0", Length = "0x33")]
		[Token(Token = "0x6001A3D")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170003D0")]
	public static bool lightsUseLinearIntensity
	{
		[Address(RVA = "0x30B5C90", Offset = "0x30B5090", Length = "0x2A")]
		[Token(Token = "0x6001A3B")]
		 get { } //Length: 42
		[Address(RVA = "0x30B5D00", Offset = "0x30B5100", Length = "0x33")]
		[Token(Token = "0x6001A3C")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170003D2")]
	public static bool useScriptableRenderPipelineBatching
	{
		[Address(RVA = "0x30B5D40", Offset = "0x30B5140", Length = "0x33")]
		[Token(Token = "0x6001A3E")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x30B5900", Offset = "0x30B4D00", Length = "0xCB")]
	[Token(Token = "0x6001A4D")]
	private static GraphicsSettings() { }

	[Address(RVA = "0x30B5B70", Offset = "0x30B4F70", Length = "0x93")]
	[Token(Token = "0x6001A42")]
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	[Address(RVA = "0x30B5A80", Offset = "0x30B4E80", Length = "0xE1")]
	[Token(Token = "0x6001A44")]
	public static Type get_currentRenderPipelineAssetType() { }

	[Address(RVA = "0x30B5A00", Offset = "0x30B4E00", Length = "0x75")]
	[Token(Token = "0x6001A41")]
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	[Address(RVA = "0x30B59D0", Offset = "0x30B4DD0", Length = "0x2A")]
	[Token(Token = "0x6001A4E")]
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	[Address(RVA = "0x30B5C10", Offset = "0x30B5010", Length = "0x74")]
	[Token(Token = "0x6001A43")]
	public static bool get_isScriptableRenderPipelineEnabled() { }

	[Address(RVA = "0x30B5C90", Offset = "0x30B5090", Length = "0x2A")]
	[Token(Token = "0x6001A3B")]
	public static bool get_lightsUseLinearIntensity() { }

	[Address(RVA = "0x30B4DD0", Offset = "0x30B41D0", Length = "0xA0")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001A46")]
	[VisibleToOtherModules]
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	[Address(RVA = "0x30B50D0", Offset = "0x30B44D0", Length = "0xA0")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001A45")]
	[VisibleToOtherModules]
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	[Address(RVA = "0x814BA0", Offset = "0x813FA0", Length = "0x165")]
	[Token(Token = "0x6001A4B")]
	public static T GetRenderPipelineSettings() { }

	[Address(RVA = "0x814D10", Offset = "0x814110", Length = "0xF0")]
	[Token(Token = "0x6001A48")]
	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline() { }

	[Address(RVA = "0x30B5410", Offset = "0x30B4810", Length = "0x3E")]
	[Token(Token = "0x6001A3F")]
	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	[Address(RVA = "0x30B5450", Offset = "0x30B4850", Length = "0x97")]
	[Token(Token = "0x6001A40")]
	public static bool HasShaderDefine(BuiltinShaderDefine defineHash) { }

	[Address(RVA = "0x30B54F0", Offset = "0x30B48F0", Length = "0x10A")]
	[Token(Token = "0x6001A49")]
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	[Address(RVA = "0x30B5640", Offset = "0x30B4A40", Length = "0x1FB")]
	[NativeName("GetSettingsForRenderPipeline")]
	[Token(Token = "0x6001A47")]
	private static object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	[Address(RVA = "0x30B5600", Offset = "0x30B4A00", Length = "0x33")]
	[Token(Token = "0x6001A4F")]
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }

	[Address(RVA = "0x30B5CC0", Offset = "0x30B50C0", Length = "0x33")]
	[Token(Token = "0x6001A3D")]
	public static void set_lightsUseColorTemperature(bool value) { }

	[Address(RVA = "0x30B5D00", Offset = "0x30B5100", Length = "0x33")]
	[Token(Token = "0x6001A3C")]
	public static void set_lightsUseLinearIntensity(bool value) { }

	[Address(RVA = "0x30B5D40", Offset = "0x30B5140", Length = "0x33")]
	[Token(Token = "0x6001A3E")]
	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	[Address(RVA = "0x30B5840", Offset = "0x30B4C40", Length = "0xB4")]
	[Token(Token = "0x6001A4A")]
	public static bool TryGetCurrentRenderPipelineGlobalSettings(out RenderPipelineGlobalSettings asset) { }

	[Address(RVA = "0x814E10", Offset = "0x814210", Length = "0x147")]
	[Token(Token = "0x6001A4C")]
	public static bool TryGetRenderPipelineSettings(out T settings) { }

}

