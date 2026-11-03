namespace UnityEngine;

[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[Token(Token = "0x20000EE")]
public sealed class Shader : object
{

	[Token(Token = "0x17000180")]
	internal DisableBatchingType disableBatching
	{
		[Address(RVA = "0x301ACA0", Offset = "0x301A0A0", Length = "0x76")]
		[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
		[Token(Token = "0x60007E8")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700017C")]
	public static GlobalKeyword[] enabledGlobalKeywords
	{
		[Address(RVA = "0x301AD20", Offset = "0x301A120", Length = "0x9")]
		[Token(Token = "0x60007D4")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700017D")]
	public static GlobalKeyword[] globalKeywords
	{
		[Address(RVA = "0x301AD30", Offset = "0x301A130", Length = "0x9")]
		[Token(Token = "0x60007D5")]
		 get { } //Length: 9
	}

	[NativeProperty("GlobalMaximumShaderLOD")]
	[Token(Token = "0x17000179")]
	public static int globalMaximumLOD
	{
		[Address(RVA = "0x301AD40", Offset = "0x301A140", Length = "0x2A")]
		[Token(Token = "0x60007CF")]
		 get { } //Length: 42
		[Address(RVA = "0x301B390", Offset = "0x301A790", Length = "0x31")]
		[Token(Token = "0x60007D0")]
		 set { } //Length: 49
	}

	[Token(Token = "0x1700017B")]
	public static string globalRenderPipeline
	{
		[Address(RVA = "0x301ADB0", Offset = "0x301A1B0", Length = "0xA4")]
		[Token(Token = "0x60007D2")]
		 get { } //Length: 164
		[Address(RVA = "0x301B410", Offset = "0x301A810", Length = "0x178")]
		[Token(Token = "0x60007D3")]
		 set { } //Length: 376
	}

	[Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", True)]
	[Token(Token = "0x17000176")]
	public static ShaderHardwareTier globalShaderHardwareTier
	{
		[Address(RVA = "0x301AE60", Offset = "0x301A260", Length = "0x5B")]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 91
		[Address(RVA = "0x301B590", Offset = "0x301A990", Length = "0x62")]
		[Token(Token = "0x60007C7")]
		 set { } //Length: 98
	}

	[Token(Token = "0x1700017A")]
	public bool isSupported
	{
		[Address(RVA = "0x301AF00", Offset = "0x301A300", Length = "0x76")]
		[NativeMethod("IsSupported")]
		[Token(Token = "0x60007D1")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700017E")]
	public LocalKeywordSpace keywordSpace
	{
		[Address(RVA = "0x301AFD0", Offset = "0x301A3D0", Length = "0x89")]
		[Token(Token = "0x60007D6")]
		 get { } //Length: 137
	}

	[NativeProperty("MaxChunksRuntimeOverride")]
	[Token(Token = "0x17000177")]
	public static int maximumChunksOverride
	{
		[Address(RVA = "0x301B060", Offset = "0x301A460", Length = "0x2A")]
		[Token(Token = "0x60007CB")]
		 get { } //Length: 42
		[Address(RVA = "0x301B600", Offset = "0x301AA00", Length = "0x31")]
		[Token(Token = "0x60007CC")]
		 set { } //Length: 49
	}

	[NativeProperty("MaximumShaderLOD")]
	[Token(Token = "0x17000178")]
	public int maximumLOD
	{
		[Address(RVA = "0x301B0D0", Offset = "0x301A4D0", Length = "0x76")]
		[Token(Token = "0x60007CD")]
		 get { } //Length: 118
		[Address(RVA = "0x301B680", Offset = "0x301AA80", Length = "0x83")]
		[Token(Token = "0x60007CE")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000181")]
	public int passCount
	{
		[Address(RVA = "0x301B190", Offset = "0x301A590", Length = "0x76")]
		[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
		[Token(Token = "0x60007EE")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700017F")]
	public int renderQueue
	{
		[Address(RVA = "0x301B250", Offset = "0x301A650", Length = "0x76")]
		[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
		[Token(Token = "0x60007E7")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000182")]
	public int subshaderCount
	{
		[Address(RVA = "0x301B310", Offset = "0x301A710", Length = "0x76")]
		[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
		[Token(Token = "0x60007EF")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x301AC10", Offset = "0x301A010", Length = "0x49")]
	[Token(Token = "0x600085B")]
	private Shader() { }

	[Address(RVA = "0x3013C40", Offset = "0x3013040", Length = "0xD6")]
	[Token(Token = "0x6000867")]
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	[Address(RVA = "0x3013D70", Offset = "0x3013170", Length = "0xE6")]
	[FreeFunction("ShaderScripting::CreateFromCompiledData")]
	[Token(Token = "0x60007CA")]
	internal static Shader CreateFromCompiledData(Byte[] compiledData, Shader[] dependencies) { }

	[Address(RVA = "0x3013D20", Offset = "0x3013120", Length = "0x42")]
	[Token(Token = "0x6000878")]
	private static IntPtr CreateFromCompiledData_Injected(ref ManagedSpanWrapper compiledData, Shader[] dependencies) { }

	[Address(RVA = "0x30140A0", Offset = "0x30134A0", Length = "0x35")]
	[Token(Token = "0x60007E1")]
	public static void DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x3013F20", Offset = "0x3013320", Length = "0x178")]
	[FreeFunction("ShaderScripting::DisableKeyword")]
	[Token(Token = "0x60007DA")]
	public static void DisableKeyword(string keyword) { }

	[Address(RVA = "0x3013EE0", Offset = "0x30132E0", Length = "0x33")]
	[Token(Token = "0x6000882")]
	private static void DisableKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x3013EA0", Offset = "0x30132A0", Length = "0x33")]
	[FreeFunction("ShaderScripting::DisableKeyword")]
	[Token(Token = "0x60007DD")]
	internal static void DisableKeywordFast(GlobalKeyword keyword) { }

	[Address(RVA = "0x3013E60", Offset = "0x3013260", Length = "0x33")]
	[Token(Token = "0x6000885")]
	private static void DisableKeywordFast_Injected(in GlobalKeyword keyword) { }

	[Address(RVA = "0x3014320", Offset = "0x3013720", Length = "0x35")]
	[Token(Token = "0x60007E0")]
	public static void EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x30141A0", Offset = "0x30135A0", Length = "0x178")]
	[FreeFunction("ShaderScripting::EnableKeyword")]
	[Token(Token = "0x60007D9")]
	public static void EnableKeyword(string keyword) { }

	[Address(RVA = "0x3014160", Offset = "0x3013560", Length = "0x33")]
	[Token(Token = "0x6000881")]
	private static void EnableKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x3014120", Offset = "0x3013520", Length = "0x33")]
	[FreeFunction("ShaderScripting::EnableKeyword")]
	[Token(Token = "0x60007DC")]
	internal static void EnableKeywordFast(GlobalKeyword keyword) { }

	[Address(RVA = "0x30140E0", Offset = "0x30134E0", Length = "0x33")]
	[Token(Token = "0x6000884")]
	private static void EnableKeywordFast_Injected(in GlobalKeyword keyword) { }

	[Address(RVA = "0x30144A0", Offset = "0x30138A0", Length = "0x12A")]
	[Token(Token = "0x6000816")]
	private static void ExtractGlobalFloatArray(int name, List<Single> values) { }

	[Address(RVA = "0x30143A0", Offset = "0x30137A0", Length = "0xF2")]
	[FreeFunction("ShaderScripting::ExtractGlobalFloatArray")]
	[Token(Token = "0x6000810")]
	private static void ExtractGlobalFloatArrayImpl(int name, out Single[] val) { }

	[Address(RVA = "0x3014360", Offset = "0x3013760", Length = "0x40")]
	[Token(Token = "0x60008A6")]
	private static void ExtractGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3014710", Offset = "0x3013B10", Length = "0x12A")]
	[Token(Token = "0x6000818")]
	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	[Address(RVA = "0x3014610", Offset = "0x3013A10", Length = "0xF2")]
	[FreeFunction("ShaderScripting::ExtractGlobalMatrixArray")]
	[Token(Token = "0x6000812")]
	private static void ExtractGlobalMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	[Address(RVA = "0x30145D0", Offset = "0x30139D0", Length = "0x40")]
	[Token(Token = "0x60008A8")]
	private static void ExtractGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3014880", Offset = "0x3013C80", Length = "0x15D")]
	[Token(Token = "0x6000819")]
	private static void ExtractGlobalPropertyNames(MaterialPropertyType type, List<String> names) { }

	[Address(RVA = "0x3014840", Offset = "0x3013C40", Length = "0x40")]
	[FreeFunction("ShaderScripting::ExtractGlobalPropertyNames")]
	[Token(Token = "0x60007E6")]
	private static void ExtractGlobalPropertyNamesImpl(int propertyType, out String[] names) { }

	[Address(RVA = "0x3014B20", Offset = "0x3013F20", Length = "0x12A")]
	[Token(Token = "0x6000817")]
	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	[Address(RVA = "0x3014A20", Offset = "0x3013E20", Length = "0xF2")]
	[FreeFunction("ShaderScripting::ExtractGlobalVectorArray")]
	[Token(Token = "0x6000811")]
	private static void ExtractGlobalVectorArrayImpl(int name, out Vector4[] val) { }

	[Address(RVA = "0x30149E0", Offset = "0x3013DE0", Length = "0x40")]
	[Token(Token = "0x60008A7")]
	private static void ExtractGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3015900", Offset = "0x3014D00", Length = "0x6A")]
	[Token(Token = "0x60007C8")]
	public static Shader Find(string name) { }

	[Address(RVA = "0x3014C90", Offset = "0x3014090", Length = "0x1DA")]
	[FreeFunction("GetBuiltinResource<Shader>")]
	[Token(Token = "0x60007C9")]
	internal static Shader FindBuiltin(string name) { }

	[Address(RVA = "0x3014C50", Offset = "0x3014050", Length = "0x33")]
	[Token(Token = "0x6000877")]
	private static IntPtr FindBuiltin_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30150A0", Offset = "0x30144A0", Length = "0x166")]
	[Token(Token = "0x60007F1")]
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[Address(RVA = "0x3014E70", Offset = "0x3014270", Length = "0x225")]
	[Token(Token = "0x60007F2")]
	public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName) { }

	[Address(RVA = "0x3015260", Offset = "0x3014660", Length = "0x1CD")]
	[Token(Token = "0x6000869")]
	public int FindPropertyIndex(string propertyName) { }

	[Address(RVA = "0x3015210", Offset = "0x3014610", Length = "0x42")]
	[Token(Token = "0x60008B5")]
	private static int FindPropertyIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper propertyName) { }

	[Address(RVA = "0x3015430", Offset = "0x3014830", Length = "0x1B4")]
	[Token(Token = "0x60007F3")]
	public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName) { }

	[Address(RVA = "0x30157B0", Offset = "0x3014BB0", Length = "0x143")]
	[Token(Token = "0x6000876")]
	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex) { }

	[Address(RVA = "0x3015650", Offset = "0x3014A50", Length = "0x150")]
	[FreeFunction("ShaderScripting::FindTextureStack")]
	[Token(Token = "0x6000866")]
	private static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex) { }

	[Address(RVA = "0x30155F0", Offset = "0x30149F0", Length = "0x60")]
	[Token(Token = "0x60008B3")]
	private static bool FindTextureStackImpl_Injected(IntPtr s, int propertyIdx, out ManagedSpanWrapper stackName, out int layerIndex) { }

	[Address(RVA = "0x301ACA0", Offset = "0x301A0A0", Length = "0x76")]
	[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
	[Token(Token = "0x60007E8")]
	internal DisableBatchingType get_disableBatching() { }

	[Address(RVA = "0x301AC60", Offset = "0x301A060", Length = "0x33")]
	[Token(Token = "0x6000889")]
	private static DisableBatchingType get_disableBatching_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301AD20", Offset = "0x301A120", Length = "0x9")]
	[Token(Token = "0x60007D4")]
	public static GlobalKeyword[] get_enabledGlobalKeywords() { }

	[Address(RVA = "0x301AD30", Offset = "0x301A130", Length = "0x9")]
	[Token(Token = "0x60007D5")]
	public static GlobalKeyword[] get_globalKeywords() { }

	[Address(RVA = "0x301AD40", Offset = "0x301A140", Length = "0x2A")]
	[Token(Token = "0x60007CF")]
	public static int get_globalMaximumLOD() { }

	[Address(RVA = "0x301ADB0", Offset = "0x301A1B0", Length = "0xA4")]
	[Token(Token = "0x60007D2")]
	public static string get_globalRenderPipeline() { }

	[Address(RVA = "0x301AD70", Offset = "0x301A170", Length = "0x33")]
	[Token(Token = "0x600087C")]
	private static void get_globalRenderPipeline_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x301AE60", Offset = "0x301A260", Length = "0x5B")]
	[Token(Token = "0x60007C6")]
	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	[Address(RVA = "0x301AF00", Offset = "0x301A300", Length = "0x76")]
	[NativeMethod("IsSupported")]
	[Token(Token = "0x60007D1")]
	public bool get_isSupported() { }

	[Address(RVA = "0x301AEC0", Offset = "0x301A2C0", Length = "0x33")]
	[Token(Token = "0x600087B")]
	private static bool get_isSupported_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301AFD0", Offset = "0x301A3D0", Length = "0x89")]
	[Token(Token = "0x60007D6")]
	public LocalKeywordSpace get_keywordSpace() { }

	[Address(RVA = "0x301AF80", Offset = "0x301A380", Length = "0x42")]
	[Token(Token = "0x600087E")]
	private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret) { }

	[Address(RVA = "0x301B060", Offset = "0x301A460", Length = "0x2A")]
	[Token(Token = "0x60007CB")]
	public static int get_maximumChunksOverride() { }

	[Address(RVA = "0x301B0D0", Offset = "0x301A4D0", Length = "0x76")]
	[Token(Token = "0x60007CD")]
	public int get_maximumLOD() { }

	[Address(RVA = "0x301B090", Offset = "0x301A490", Length = "0x33")]
	[Token(Token = "0x6000879")]
	private static int get_maximumLOD_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B190", Offset = "0x301A590", Length = "0x76")]
	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	[Token(Token = "0x60007EE")]
	public int get_passCount() { }

	[Address(RVA = "0x301B150", Offset = "0x301A550", Length = "0x33")]
	[Token(Token = "0x600088E")]
	private static int get_passCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B250", Offset = "0x301A650", Length = "0x76")]
	[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
	[Token(Token = "0x60007E7")]
	public int get_renderQueue() { }

	[Address(RVA = "0x301B210", Offset = "0x301A610", Length = "0x33")]
	[Token(Token = "0x6000888")]
	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301B310", Offset = "0x301A710", Length = "0x76")]
	[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
	[Token(Token = "0x60007EF")]
	public int get_subshaderCount() { }

	[Address(RVA = "0x301B2D0", Offset = "0x301A6D0", Length = "0x33")]
	[Token(Token = "0x600088F")]
	private static int get_subshaderCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30159B0", Offset = "0x3014DB0", Length = "0xE0")]
	[FreeFunction("keywords::GetAllGlobalKeywords")]
	[Token(Token = "0x60007D8")]
	internal static GlobalKeyword[] GetAllGlobalKeywords() { }

	[Address(RVA = "0x3015970", Offset = "0x3014D70", Length = "0x33")]
	[Token(Token = "0x6000880")]
	private static void GetAllGlobalKeywords_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3015AF0", Offset = "0x3014EF0", Length = "0x214")]
	[Token(Token = "0x60007ED")]
	public Shader GetDependency(string name) { }

	[Address(RVA = "0x3015AA0", Offset = "0x3014EA0", Length = "0x42")]
	[Token(Token = "0x600088D")]
	private static IntPtr GetDependency_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x3015D50", Offset = "0x3015150", Length = "0xE0")]
	[FreeFunction("keywords::GetEnabledGlobalKeywords")]
	[Token(Token = "0x60007D7")]
	internal static GlobalKeyword[] GetEnabledGlobalKeywords() { }

	[Address(RVA = "0x3015D10", Offset = "0x3015110", Length = "0x33")]
	[Token(Token = "0x600087F")]
	private static void GetEnabledGlobalKeywords_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3015E40", Offset = "0x3015240", Length = "0x5D")]
	[Token(Token = "0x6000849")]
	public static Color GetGlobalColor(int nameID) { }

	[Address(RVA = "0x3015EA0", Offset = "0x30152A0", Length = "0x6A")]
	[Token(Token = "0x6000848")]
	public static Color GetGlobalColor(string name) { }

	[Address(RVA = "0x30161B0", Offset = "0x30155B0", Length = "0x38")]
	[Token(Token = "0x6000842")]
	public static float GetGlobalFloat(string name) { }

	[Address(RVA = "0x3016170", Offset = "0x3015570", Length = "0x31")]
	[Token(Token = "0x6000843")]
	public static float GetGlobalFloat(int nameID) { }

	[Address(RVA = "0x30160E0", Offset = "0x30154E0", Length = "0x8")]
	[Token(Token = "0x6000855")]
	public static void GetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x30160F0", Offset = "0x30154F0", Length = "0x22")]
	[Token(Token = "0x6000854")]
	public static void GetGlobalFloatArray(string name, List<Single> values) { }

	[Address(RVA = "0x3016120", Offset = "0x3015520", Length = "0x46")]
	[Token(Token = "0x600084F")]
	public static Single[] GetGlobalFloatArray(int nameID) { }

	[Address(RVA = "0x3016090", Offset = "0x3015490", Length = "0x4D")]
	[Token(Token = "0x600084E")]
	public static Single[] GetGlobalFloatArray(string name) { }

	[Address(RVA = "0x3015F10", Offset = "0x3015310", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalFloatArrayCount")]
	[Token(Token = "0x600080D")]
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[Address(RVA = "0x3015F90", Offset = "0x3015390", Length = "0xF9")]
	[FreeFunction("ShaderScripting::GetGlobalFloatArray")]
	[Token(Token = "0x600080A")]
	private static Single[] GetGlobalFloatArrayImpl(int name) { }

	[Address(RVA = "0x3015F50", Offset = "0x3015350", Length = "0x40")]
	[Token(Token = "0x60008A3")]
	private static void GetGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3016170", Offset = "0x3015570", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalFloat")]
	[Token(Token = "0x6000803")]
	private static float GetGlobalFloatImpl(int name) { }

	[Address(RVA = "0x3016270", Offset = "0x3015670", Length = "0x3C")]
	[Token(Token = "0x6000840")]
	public static int GetGlobalInt(string name) { }

	[Address(RVA = "0x3016230", Offset = "0x3015630", Length = "0x35")]
	[Token(Token = "0x6000841")]
	public static int GetGlobalInt(int nameID) { }

	[Address(RVA = "0x30161F0", Offset = "0x30155F0", Length = "0x31")]
	[Token(Token = "0x6000845")]
	public static int GetGlobalInteger(int nameID) { }

	[Address(RVA = "0x30162B0", Offset = "0x30156B0", Length = "0x38")]
	[Token(Token = "0x6000844")]
	public static int GetGlobalInteger(string name) { }

	[Address(RVA = "0x30161F0", Offset = "0x30155F0", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalInt")]
	[Token(Token = "0x6000802")]
	private static int GetGlobalIntImpl(int name) { }

	[Address(RVA = "0x3016690", Offset = "0x3015A90", Length = "0x8E")]
	[Token(Token = "0x600084B")]
	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	[Address(RVA = "0x30165F0", Offset = "0x30159F0", Length = "0x9B")]
	[Token(Token = "0x600084A")]
	public static Matrix4x4 GetGlobalMatrix(string name) { }

	[Address(RVA = "0x3016500", Offset = "0x3015900", Length = "0x4D")]
	[Token(Token = "0x6000852")]
	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	[Address(RVA = "0x30164C0", Offset = "0x30158C0", Length = "0x22")]
	[Token(Token = "0x6000858")]
	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	[Address(RVA = "0x30164F0", Offset = "0x30158F0", Length = "0x8")]
	[Token(Token = "0x6000859")]
	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x3016470", Offset = "0x3015870", Length = "0x46")]
	[Token(Token = "0x6000853")]
	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	[Address(RVA = "0x30162F0", Offset = "0x30156F0", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalMatrixArrayCount")]
	[Token(Token = "0x600080F")]
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[Address(RVA = "0x3016370", Offset = "0x3015770", Length = "0xF9")]
	[FreeFunction("ShaderScripting::GetGlobalMatrixArray")]
	[Token(Token = "0x600080C")]
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[Address(RVA = "0x3016330", Offset = "0x3015730", Length = "0x40")]
	[Token(Token = "0x60008A5")]
	private static void GetGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3016590", Offset = "0x3015990", Length = "0x55")]
	[FreeFunction("ShaderScripting::GetGlobalMatrix")]
	[Token(Token = "0x6000805")]
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	[Address(RVA = "0x3016550", Offset = "0x3015950", Length = "0x40")]
	[Token(Token = "0x600089E")]
	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	[Address(RVA = "0x3016760", Offset = "0x3015B60", Length = "0x2A")]
	[FreeFunction("ShaderScripting::GetGlobalPropertyCount")]
	[Token(Token = "0x60007E4")]
	internal static int GetGlobalPropertyCount() { }

	[Address(RVA = "0x3016720", Offset = "0x3015B20", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalPropertyCount")]
	[Token(Token = "0x60007E5")]
	private static int GetGlobalPropertyCountImpl(int propertyType) { }

	[Address(RVA = "0x3014880", Offset = "0x3013C80", Length = "0x15D")]
	[Token(Token = "0x600085A")]
	internal static void GetGlobalPropertyNames(MaterialPropertyType type, List<String> names) { }

	[Address(RVA = "0x3016830", Offset = "0x3015C30", Length = "0x62")]
	[Token(Token = "0x600084C")]
	public static Texture GetGlobalTexture(string name) { }

	[Address(RVA = "0x30167D0", Offset = "0x3015BD0", Length = "0x5B")]
	[Token(Token = "0x600084D")]
	public static Texture GetGlobalTexture(int nameID) { }

	[Address(RVA = "0x30167D0", Offset = "0x3015BD0", Length = "0x5B")]
	[FreeFunction("ShaderScripting::GetGlobalTexture")]
	[Token(Token = "0x6000806")]
	private static Texture GetGlobalTextureImpl(int name) { }

	[Address(RVA = "0x3016790", Offset = "0x3015B90", Length = "0x31")]
	[Token(Token = "0x600089F")]
	private static IntPtr GetGlobalTextureImpl_Injected(int name) { }

	[Address(RVA = "0x3016B90", Offset = "0x3015F90", Length = "0x58")]
	[Token(Token = "0x6000847")]
	public static Vector4 GetGlobalVector(int nameID) { }

	[Address(RVA = "0x3016BF0", Offset = "0x3015FF0", Length = "0x65")]
	[Token(Token = "0x6000846")]
	public static Vector4 GetGlobalVector(string name) { }

	[Address(RVA = "0x3016AB0", Offset = "0x3015EB0", Length = "0x4D")]
	[Token(Token = "0x6000850")]
	public static Vector4[] GetGlobalVectorArray(string name) { }

	[Address(RVA = "0x3016A80", Offset = "0x3015E80", Length = "0x22")]
	[Token(Token = "0x6000856")]
	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	[Address(RVA = "0x3016A70", Offset = "0x3015E70", Length = "0x8")]
	[Token(Token = "0x6000857")]
	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x3016A20", Offset = "0x3015E20", Length = "0x46")]
	[Token(Token = "0x6000851")]
	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	[Address(RVA = "0x30168A0", Offset = "0x3015CA0", Length = "0x31")]
	[FreeFunction("ShaderScripting::GetGlobalVectorArrayCount")]
	[Token(Token = "0x600080E")]
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[Address(RVA = "0x3016920", Offset = "0x3015D20", Length = "0xF9")]
	[FreeFunction("ShaderScripting::GetGlobalVectorArray")]
	[Token(Token = "0x600080B")]
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[Address(RVA = "0x30168E0", Offset = "0x3015CE0", Length = "0x40")]
	[Token(Token = "0x60008A4")]
	private static void GetGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3016B40", Offset = "0x3015F40", Length = "0x49")]
	[FreeFunction("ShaderScripting::GetGlobalVector")]
	[Token(Token = "0x6000804")]
	private static Vector4 GetGlobalVectorImpl(int name) { }

	[Address(RVA = "0x3016B00", Offset = "0x3015F00", Length = "0x40")]
	[Token(Token = "0x600089D")]
	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	[Address(RVA = "0x3016CA0", Offset = "0x30160A0", Length = "0x83")]
	[FreeFunction(Name = "ShaderScripting::GetPassCountInSubshader", HasExplicitThis = True)]
	[Token(Token = "0x60007F0")]
	public int GetPassCountInSubshader(int subshaderIndex) { }

	[Address(RVA = "0x3016C60", Offset = "0x3016060", Length = "0x40")]
	[Token(Token = "0x6000890")]
	private static int GetPassCountInSubshader_Injected(IntPtr _unity_self, int subshaderIndex) { }

	[Address(RVA = "0x3016E30", Offset = "0x3016230", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyAttributes")]
	[Token(Token = "0x6000861")]
	private static String[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3016D70", Offset = "0x3016170", Length = "0xB0")]
	[Token(Token = "0x600086F")]
	public String[] GetPropertyAttributes(int propertyIndex) { }

	[Address(RVA = "0x3016D30", Offset = "0x3016130", Length = "0x40")]
	[Token(Token = "0x60008AE")]
	private static String[] GetPropertyAttributes_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3016F20", Offset = "0x3016320", Length = "0x76")]
	[Token(Token = "0x6000868")]
	public int GetPropertyCount() { }

	[Address(RVA = "0x3016EE0", Offset = "0x30162E0", Length = "0x33")]
	[Token(Token = "0x60008B4")]
	private static int GetPropertyCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3016FA0", Offset = "0x30163A0", Length = "0x194")]
	[Token(Token = "0x6000870")]
	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	[Address(RVA = "0x3017300", Offset = "0x3016700", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyDefaultIntValue")]
	[Token(Token = "0x6000862")]
	private static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017180", Offset = "0x3016580", Length = "0x178")]
	[Token(Token = "0x6000873")]
	public int GetPropertyDefaultIntValue(int propertyIndex) { }

	[Address(RVA = "0x3017140", Offset = "0x3016540", Length = "0x40")]
	[Token(Token = "0x60008AF")]
	private static int GetPropertyDefaultIntValue_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3017400", Offset = "0x3016800", Length = "0xC2")]
	[FreeFunction("ShaderScripting::GetPropertyDefaultValue")]
	[Token(Token = "0x6000863")]
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x30173B0", Offset = "0x30167B0", Length = "0x50")]
	[Token(Token = "0x60008B0")]
	private static void GetPropertyDefaultValue_Injected(IntPtr shader, int propertyIndex, out Vector4 ret) { }

	[Address(RVA = "0x30174D0", Offset = "0x30168D0", Length = "0x1B2")]
	[Token(Token = "0x6000871")]
	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	[Address(RVA = "0x30176E0", Offset = "0x3016AE0", Length = "0x2E")]
	[Token(Token = "0x600086D")]
	public string GetPropertyDescription(int propertyIndex) { }

	[Address(RVA = "0x3017710", Offset = "0x3016B10", Length = "0x13D")]
	[FreeFunction("ShaderScripting::GetPropertyDescription")]
	[Token(Token = "0x600085F")]
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017690", Offset = "0x3016A90", Length = "0x50")]
	[Token(Token = "0x60008AC")]
	private static void GetPropertyDescription_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3017950", Offset = "0x3016D50", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyFlags")]
	[Token(Token = "0x6000860")]
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017890", Offset = "0x3016C90", Length = "0xB0")]
	[Token(Token = "0x600086E")]
	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	[Address(RVA = "0x3017850", Offset = "0x3016C50", Length = "0x40")]
	[Token(Token = "0x60008AD")]
	private static ShaderPropertyFlags GetPropertyFlags_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3017D40", Offset = "0x3017140", Length = "0x2E")]
	[Token(Token = "0x600086A")]
	public string GetPropertyName(int propertyIndex) { }

	[Address(RVA = "0x3017C00", Offset = "0x3017000", Length = "0x13D")]
	[FreeFunction("ShaderScripting::GetPropertyName")]
	[Token(Token = "0x600085C")]
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017BB0", Offset = "0x3016FB0", Length = "0x50")]
	[Token(Token = "0x60008A9")]
	private static void GetPropertyName_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3017A40", Offset = "0x3016E40", Length = "0xB0")]
	[Token(Token = "0x600086B")]
	public int GetPropertyNameId(int propertyIndex) { }

	[Address(RVA = "0x3017B00", Offset = "0x3016F00", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyNameId")]
	[Token(Token = "0x600085D")]
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017A00", Offset = "0x3016E00", Length = "0x40")]
	[Token(Token = "0x60008AA")]
	private static int GetPropertyNameId_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3017D70", Offset = "0x3017170", Length = "0x19D")]
	[Token(Token = "0x6000872")]
	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	[Address(RVA = "0x30180A0", Offset = "0x30174A0", Length = "0x11B")]
	[Token(Token = "0x6000875")]
	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	[Address(RVA = "0x3017F60", Offset = "0x3017360", Length = "0x13D")]
	[FreeFunction("ShaderScripting::GetPropertyTextureDefaultName")]
	[Token(Token = "0x6000865")]
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3017F10", Offset = "0x3017310", Length = "0x50")]
	[Token(Token = "0x60008B2")]
	private static void GetPropertyTextureDefaultName_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3018200", Offset = "0x3017600", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyTextureDimension")]
	[Token(Token = "0x6000864")]
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x30182B0", Offset = "0x30176B0", Length = "0x178")]
	[Token(Token = "0x6000874")]
	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	[Address(RVA = "0x30181C0", Offset = "0x30175C0", Length = "0x40")]
	[Token(Token = "0x60008B1")]
	private static TextureDimension GetPropertyTextureDimension_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3018470", Offset = "0x3017870", Length = "0xA8")]
	[FreeFunction("ShaderScripting::GetPropertyType")]
	[Token(Token = "0x600085E")]
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[Address(RVA = "0x3018520", Offset = "0x3017920", Length = "0xB0")]
	[Token(Token = "0x600086C")]
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	[Address(RVA = "0x3018430", Offset = "0x3017830", Length = "0x40")]
	[Token(Token = "0x60008AB")]
	private static ShaderPropertyType GetPropertyType_Injected(IntPtr shader, int propertyIndex) { }

	[Address(RVA = "0x3018620", Offset = "0x3017A20", Length = "0xAA")]
	[FreeFunction("ShaderScripting::IDToTag")]
	[Token(Token = "0x60007EB")]
	internal static string IDToTag(int name) { }

	[Address(RVA = "0x30185E0", Offset = "0x30179E0", Length = "0x40")]
	[Token(Token = "0x600088B")]
	private static void IDToTag_Injected(int name, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3018830", Offset = "0x3017C30", Length = "0x93")]
	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	[Token(Token = "0x60007F4")]
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[Address(RVA = "0x30187E0", Offset = "0x3017BE0", Length = "0x50")]
	[Token(Token = "0x6000891")]
	private static int Internal_FindPassTagValue_Injected(IntPtr _unity_self, int passIndex, int tagName) { }

	[Address(RVA = "0x3018730", Offset = "0x3017B30", Length = "0xA7")]
	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	[Token(Token = "0x60007F5")]
	private int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName) { }

	[Address(RVA = "0x30186D0", Offset = "0x3017AD0", Length = "0x60")]
	[Token(Token = "0x6000892")]
	private static int Internal_FindPassTagValueInSubShader_Injected(IntPtr _unity_self, int subShaderIndex, int passIndex, int tagName) { }

	[Address(RVA = "0x3018920", Offset = "0x3017D20", Length = "0x93")]
	[FreeFunction(Name = "ShaderScripting::FindSubshaderTagValue", HasExplicitThis = True)]
	[Token(Token = "0x60007F6")]
	private int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName) { }

	[Address(RVA = "0x30188D0", Offset = "0x3017CD0", Length = "0x50")]
	[Token(Token = "0x6000893")]
	private static int Internal_FindSubshaderTagValue_Injected(IntPtr _unity_self, int subShaderIndex, int tagName) { }

	[Address(RVA = "0x3018C10", Offset = "0x3018010", Length = "0x35")]
	[Token(Token = "0x60007E3")]
	public static bool IsKeywordEnabled(in GlobalKeyword keyword) { }

	[Address(RVA = "0x3018A80", Offset = "0x3017E80", Length = "0x18D")]
	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	[Token(Token = "0x60007DB")]
	public static bool IsKeywordEnabled(string keyword) { }

	[Address(RVA = "0x3018A40", Offset = "0x3017E40", Length = "0x33")]
	[Token(Token = "0x6000883")]
	private static bool IsKeywordEnabled_Injected(ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x3018A00", Offset = "0x3017E00", Length = "0x33")]
	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	[Token(Token = "0x60007DF")]
	internal static bool IsKeywordEnabledFast(GlobalKeyword keyword) { }

	[Address(RVA = "0x30189C0", Offset = "0x3017DC0", Length = "0x33")]
	[Token(Token = "0x6000887")]
	private static bool IsKeywordEnabledFast_Injected(in GlobalKeyword keyword) { }

	[Address(RVA = "0x3018C90", Offset = "0x3018090", Length = "0x18C")]
	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	[Token(Token = "0x60007EC")]
	public static int PropertyToID(string name) { }

	[Address(RVA = "0x3018C50", Offset = "0x3018050", Length = "0x33")]
	[Token(Token = "0x600088C")]
	private static int PropertyToID_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x301B390", Offset = "0x301A790", Length = "0x31")]
	[Token(Token = "0x60007D0")]
	public static void set_globalMaximumLOD(int value) { }

	[Address(RVA = "0x301B410", Offset = "0x301A810", Length = "0x178")]
	[Token(Token = "0x60007D3")]
	public static void set_globalRenderPipeline(string value) { }

	[Address(RVA = "0x301B3D0", Offset = "0x301A7D0", Length = "0x33")]
	[Token(Token = "0x600087D")]
	private static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x301B590", Offset = "0x301A990", Length = "0x62")]
	[Token(Token = "0x60007C7")]
	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	[Address(RVA = "0x301B600", Offset = "0x301AA00", Length = "0x31")]
	[Token(Token = "0x60007CC")]
	public static void set_maximumChunksOverride(int value) { }

	[Address(RVA = "0x301B680", Offset = "0x301AA80", Length = "0x83")]
	[Token(Token = "0x60007CE")]
	public void set_maximumLOD(int value) { }

	[Address(RVA = "0x301B640", Offset = "0x301AA40", Length = "0x40")]
	[Token(Token = "0x600087A")]
	private static void set_maximumLOD_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x3018EB0", Offset = "0x30182B0", Length = "0x4A")]
	[Token(Token = "0x600082D")]
	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x3018F60", Offset = "0x3018360", Length = "0x52")]
	[Token(Token = "0x600082C")]
	public static void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x3018E60", Offset = "0x3018260", Length = "0x4A")]
	[Token(Token = "0x600082B")]
	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x3018F00", Offset = "0x3018300", Length = "0x52")]
	[Token(Token = "0x600082A")]
	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x3018E60", Offset = "0x3018260", Length = "0x4A")]
	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	[Token(Token = "0x60007FD")]
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	[Address(RVA = "0x3018E20", Offset = "0x3018220", Length = "0x40")]
	[Token(Token = "0x6000898")]
	private static void SetGlobalBufferImpl_Injected(int name, IntPtr value) { }

	[Address(RVA = "0x3019030", Offset = "0x3018430", Length = "0x6A")]
	[Token(Token = "0x6000822")]
	public static void SetGlobalColor(string name, Color value) { }

	[Address(RVA = "0x3018FC0", Offset = "0x30183C0", Length = "0x63")]
	[Token(Token = "0x6000823")]
	public static void SetGlobalColor(int nameID, Color value) { }

	[Address(RVA = "0x30191F0", Offset = "0x30185F0", Length = "0x72")]
	[Token(Token = "0x600082E")]
	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x3019100", Offset = "0x3018500", Length = "0x6A")]
	[Token(Token = "0x600082F")]
	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x3019170", Offset = "0x3018570", Length = "0x72")]
	[Token(Token = "0x6000830")]
	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x3019270", Offset = "0x3018670", Length = "0x6A")]
	[Token(Token = "0x6000831")]
	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x3019100", Offset = "0x3018500", Length = "0x6A")]
	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	[Token(Token = "0x60007FF")]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x30190A0", Offset = "0x30184A0", Length = "0x60")]
	[Token(Token = "0x600089A")]
	private static void SetGlobalConstantBufferImpl_Injected(int name, IntPtr value, int offset, int size) { }

	[Address(RVA = "0x3019270", Offset = "0x3018670", Length = "0x6A")]
	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	[Token(Token = "0x6000800")]
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x30192E0", Offset = "0x30186E0", Length = "0x60")]
	[Token(Token = "0x600089B")]
	private static void SetGlobalConstantGraphicsBufferImpl_Injected(int name, IntPtr value, int offset, int size) { }

	[Address(RVA = "0x3019830", Offset = "0x3018C30", Length = "0x48")]
	[Token(Token = "0x600081C")]
	public static void SetGlobalFloat(string name, float value) { }

	[Address(RVA = "0x30197E0", Offset = "0x3018BE0", Length = "0x41")]
	[Token(Token = "0x600081D")]
	public static void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x30194D0", Offset = "0x30188D0", Length = "0x92")]
	[Token(Token = "0x6000835")]
	public static void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x3019470", Offset = "0x3018870", Length = "0x1E")]
	[Token(Token = "0x6000837")]
	public static void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x3019490", Offset = "0x3018890", Length = "0x30")]
	[Token(Token = "0x6000836")]
	public static void SetGlobalFloatArray(string name, Single[] values) { }

	[Address(RVA = "0x3019570", Offset = "0x3018970", Length = "0x1C3")]
	[Token(Token = "0x6000813")]
	private static void SetGlobalFloatArray(int name, Single[] values, int count) { }

	[Address(RVA = "0x3019740", Offset = "0x3018B40", Length = "0x9F")]
	[Token(Token = "0x6000834")]
	public static void SetGlobalFloatArray(string name, List<Single> values) { }

	[Address(RVA = "0x3019390", Offset = "0x3018790", Length = "0xD9")]
	[FreeFunction("ShaderScripting::SetGlobalFloatArray")]
	[Token(Token = "0x6000807")]
	private static void SetGlobalFloatArrayImpl(int name, Single[] values, int count) { }

	[Address(RVA = "0x3019340", Offset = "0x3018740", Length = "0x50")]
	[Token(Token = "0x60008A0")]
	private static void SetGlobalFloatArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x30197E0", Offset = "0x3018BE0", Length = "0x41")]
	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	[Token(Token = "0x60007F8")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	[Address(RVA = "0x3018EB0", Offset = "0x30182B0", Length = "0x4A")]
	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	[Token(Token = "0x60007FE")]
	private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[Address(RVA = "0x3019880", Offset = "0x3018C80", Length = "0x40")]
	[Token(Token = "0x6000899")]
	private static void SetGlobalGraphicsBufferImpl_Injected(int name, IntPtr value) { }

	[Address(RVA = "0x3019950", Offset = "0x3018D50", Length = "0x43")]
	[Token(Token = "0x600081B")]
	public static void SetGlobalInt(int nameID, int value) { }

	[Address(RVA = "0x3019900", Offset = "0x3018D00", Length = "0x4A")]
	[Token(Token = "0x600081A")]
	public static void SetGlobalInt(string name, int value) { }

	[Address(RVA = "0x30198C0", Offset = "0x3018CC0", Length = "0x3E")]
	[Token(Token = "0x600081F")]
	public static void SetGlobalInteger(int nameID, int value) { }

	[Address(RVA = "0x30199A0", Offset = "0x3018DA0", Length = "0x45")]
	[Token(Token = "0x600081E")]
	public static void SetGlobalInteger(string name, int value) { }

	[Address(RVA = "0x30198C0", Offset = "0x3018CC0", Length = "0x3E")]
	[FreeFunction("ShaderScripting::SetGlobalInt")]
	[Token(Token = "0x60007F7")]
	private static void SetGlobalIntImpl(int name, int value) { }

	[Address(RVA = "0x3019F80", Offset = "0x3019380", Length = "0x59")]
	[Token(Token = "0x6000825")]
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x3019F10", Offset = "0x3019310", Length = "0x6C")]
	[Token(Token = "0x6000824")]
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x3019DF0", Offset = "0x30191F0", Length = "0x9F")]
	[Token(Token = "0x600083C")]
	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	[Address(RVA = "0x3019D10", Offset = "0x3019110", Length = "0x30")]
	[Token(Token = "0x600083E")]
	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	[Address(RVA = "0x3019B20", Offset = "0x3018F20", Length = "0x1E")]
	[Token(Token = "0x600083F")]
	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x3019D50", Offset = "0x3019150", Length = "0x92")]
	[Token(Token = "0x600083D")]
	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x3019B40", Offset = "0x3018F40", Length = "0x1C3")]
	[Token(Token = "0x6000815")]
	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x3019A40", Offset = "0x3018E40", Length = "0xD9")]
	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	[Token(Token = "0x6000809")]
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x30199F0", Offset = "0x3018DF0", Length = "0x50")]
	[Token(Token = "0x60008A2")]
	private static void SetGlobalMatrixArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x3019ED0", Offset = "0x30192D0", Length = "0x40")]
	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	[Token(Token = "0x60007FA")]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[Address(RVA = "0x3019E90", Offset = "0x3019290", Length = "0x40")]
	[Token(Token = "0x6000895")]
	private static void SetGlobalMatrixImpl_Injected(int name, in Matrix4x4 value) { }

	[Address(RVA = "0x301A070", Offset = "0x3019470", Length = "0x52")]
	[Token(Token = "0x6000832")]
	public static void SetGlobalRayTracingAccelerationStructure(string name, RayTracingAccelerationStructure value) { }

	[Address(RVA = "0x301A020", Offset = "0x3019420", Length = "0x4A")]
	[Token(Token = "0x6000833")]
	public static void SetGlobalRayTracingAccelerationStructure(int nameID, RayTracingAccelerationStructure value) { }

	[Address(RVA = "0x301A020", Offset = "0x3019420", Length = "0x4A")]
	[FreeFunction("ShaderScripting::SetGlobalRayTracingAccelerationStructure")]
	[Token(Token = "0x6000801")]
	private static void SetGlobalRayTracingAccelerationStructureImpl(int name, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x3019FE0", Offset = "0x30193E0", Length = "0x40")]
	[Token(Token = "0x600089C")]
	private static void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, IntPtr accelerationStructure) { }

	[Address(RVA = "0x301A120", Offset = "0x3019520", Length = "0x88")]
	[FreeFunction("ShaderScripting::SetGlobalRenderTexture")]
	[Token(Token = "0x60007FC")]
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x301A0D0", Offset = "0x30194D0", Length = "0x50")]
	[Token(Token = "0x6000897")]
	private static void SetGlobalRenderTextureImpl_Injected(int name, IntPtr value, RenderTextureSubElement element) { }

	[Address(RVA = "0x301A300", Offset = "0x3019700", Length = "0x7F")]
	[Token(Token = "0x6000826")]
	public static void SetGlobalTexture(string name, Texture value) { }

	[Address(RVA = "0x301A1F0", Offset = "0x30195F0", Length = "0x78")]
	[Token(Token = "0x6000827")]
	public static void SetGlobalTexture(int nameID, Texture value) { }

	[Address(RVA = "0x301A270", Offset = "0x3019670", Length = "0x8F")]
	[Token(Token = "0x6000828")]
	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x301A120", Offset = "0x3019520", Length = "0x88")]
	[Token(Token = "0x6000829")]
	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x301A1F0", Offset = "0x30195F0", Length = "0x78")]
	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	[Token(Token = "0x60007FB")]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[Address(RVA = "0x301A1B0", Offset = "0x30195B0", Length = "0x40")]
	[Token(Token = "0x6000896")]
	private static void SetGlobalTextureImpl_Injected(int name, IntPtr value) { }

	[Address(RVA = "0x301A8A0", Offset = "0x3019CA0", Length = "0x51")]
	[Token(Token = "0x6000820")]
	public static void SetGlobalVector(string name, Vector4 value) { }

	[Address(RVA = "0x301A900", Offset = "0x3019D00", Length = "0x3E")]
	[Token(Token = "0x6000821")]
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x301A590", Offset = "0x3019990", Length = "0x1C3")]
	[Token(Token = "0x6000814")]
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x301A4F0", Offset = "0x30198F0", Length = "0x9F")]
	[Token(Token = "0x6000838")]
	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	[Address(RVA = "0x301A780", Offset = "0x3019B80", Length = "0x92")]
	[Token(Token = "0x6000839")]
	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x301A4B0", Offset = "0x30198B0", Length = "0x30")]
	[Token(Token = "0x600083A")]
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	[Address(RVA = "0x301A760", Offset = "0x3019B60", Length = "0x1E")]
	[Token(Token = "0x600083B")]
	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x301A3D0", Offset = "0x30197D0", Length = "0xD9")]
	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	[Token(Token = "0x6000808")]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x301A380", Offset = "0x3019780", Length = "0x50")]
	[Token(Token = "0x60008A1")]
	private static void SetGlobalVectorArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x301A860", Offset = "0x3019C60", Length = "0x40")]
	[FreeFunction("ShaderScripting::SetGlobalVector")]
	[Token(Token = "0x60007F9")]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[Address(RVA = "0x301A820", Offset = "0x3019C20", Length = "0x40")]
	[Token(Token = "0x6000894")]
	private static void SetGlobalVectorImpl_Injected(int name, in Vector4 value) { }

	[Address(RVA = "0x301A9D0", Offset = "0x3019DD0", Length = "0x3E")]
	[Token(Token = "0x60007E2")]
	public static void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x301A990", Offset = "0x3019D90", Length = "0x3B")]
	[FreeFunction("ShaderScripting::SetKeyword")]
	[Token(Token = "0x60007DE")]
	internal static void SetKeywordFast(GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x301A940", Offset = "0x3019D40", Length = "0x42")]
	[Token(Token = "0x6000886")]
	private static void SetKeywordFast_Injected(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x301AA50", Offset = "0x3019E50", Length = "0x18C")]
	[FreeFunction("ShaderScripting::TagToID")]
	[Token(Token = "0x60007EA")]
	internal static int TagToID(string name) { }

	[Address(RVA = "0x301AA10", Offset = "0x3019E10", Length = "0x33")]
	[Token(Token = "0x600088A")]
	private static int TagToID_Injected(ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x301ABE0", Offset = "0x3019FE0", Length = "0x2A")]
	[FreeFunction]
	[Token(Token = "0x60007E9")]
	public static void WarmupAllShaders() { }

}

