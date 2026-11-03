namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
[Token(Token = "0x20000EF")]
public class Material : object
{
	[Token(Token = "0x4000288")]
	private static readonly int k_ColorId; //Field offset: 0x0
	[Token(Token = "0x4000289")]
	private static readonly int k_MainTexId; //Field offset: 0x4

	[Token(Token = "0x17000184")]
	public Color color
	{
		[Address(RVA = "0x300D560", Offset = "0x300C960", Length = "0x193")]
		[Token(Token = "0x60008C1")]
		 get { } //Length: 403
		[Address(RVA = "0x300E040", Offset = "0x300D440", Length = "0x181")]
		[Token(Token = "0x60008C2")]
		 set { } //Length: 385
	}

	[Token(Token = "0x1700018C")]
	public bool doubleSidedGI
	{
		[Address(RVA = "0x300D740", Offset = "0x300CB40", Length = "0x97")]
		[Token(Token = "0x60008F9")]
		 get { } //Length: 151
		[Address(RVA = "0x300E220", Offset = "0x300D620", Length = "0xA7")]
		[Token(Token = "0x60008FA")]
		 set { } //Length: 167
	}

	[Token(Token = "0x1700018A")]
	public LocalKeyword[] enabledKeywords
	{
		[Address(RVA = "0x30052E0", Offset = "0x30046E0", Length = "0x97")]
		[Token(Token = "0x60008F5")]
		 get { } //Length: 151
		[Address(RVA = "0x300A5F0", Offset = "0x30099F0", Length = "0xA6")]
		[Token(Token = "0x60008F6")]
		 set { } //Length: 166
	}

	[NativeProperty("EnableInstancingVariants")]
	[Token(Token = "0x1700018D")]
	public bool enableInstancing
	{
		[Address(RVA = "0x300D820", Offset = "0x300CC20", Length = "0x97")]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 151
		[Address(RVA = "0x300E320", Offset = "0x300D720", Length = "0xA7")]
		[Token(Token = "0x60008FC")]
		 set { } //Length: 167
	}

	[Token(Token = "0x1700018B")]
	public MaterialGlobalIlluminationFlags globalIlluminationFlags
	{
		[Address(RVA = "0x300D900", Offset = "0x300CD00", Length = "0x97")]
		[Token(Token = "0x60008F7")]
		 get { } //Length: 151
		[Address(RVA = "0x300E410", Offset = "0x300D810", Length = "0xA4")]
		[Token(Token = "0x60008F8")]
		 set { } //Length: 164
	}

	[Token(Token = "0x17000185")]
	public Texture mainTexture
	{
		[Address(RVA = "0x300DBA0", Offset = "0x300CFA0", Length = "0xF5")]
		[Token(Token = "0x60008C3")]
		 get { } //Length: 245
		[Address(RVA = "0x300E720", Offset = "0x300DB20", Length = "0x11E")]
		[Token(Token = "0x60008C4")]
		 set { } //Length: 286
	}

	[Token(Token = "0x17000186")]
	public Vector2 mainTextureOffset
	{
		[Address(RVA = "0x300D9A0", Offset = "0x300CDA0", Length = "0xF5")]
		[Token(Token = "0x60008C5")]
		 get { } //Length: 245
		[Address(RVA = "0x300E4C0", Offset = "0x300D8C0", Length = "0x125")]
		[Token(Token = "0x60008C6")]
		 set { } //Length: 293
	}

	[Token(Token = "0x17000187")]
	public Vector2 mainTextureScale
	{
		[Address(RVA = "0x300DAA0", Offset = "0x300CEA0", Length = "0xF5")]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 245
		[Address(RVA = "0x300E5F0", Offset = "0x300D9F0", Length = "0x125")]
		[Token(Token = "0x60008C8")]
		 set { } //Length: 293
	}

	[Token(Token = "0x1700018E")]
	public int passCount
	{
		[Address(RVA = "0x300DCE0", Offset = "0x300D0E0", Length = "0x97")]
		[NativeName("GetShader()->GetPassCount")]
		[Token(Token = "0x60008FD")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000189")]
	public int rawRenderQueue
	{
		[Address(RVA = "0x300DDC0", Offset = "0x300D1C0", Length = "0x97")]
		[NativeName("GetCustomRenderQueue")]
		[Token(Token = "0x60008E7")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000188")]
	public int renderQueue
	{
		[Address(RVA = "0x300DEA0", Offset = "0x300D2A0", Length = "0x97")]
		[NativeName("GetActualRenderQueue")]
		[Token(Token = "0x60008E5")]
		 get { } //Length: 151
		[Address(RVA = "0x300E880", Offset = "0x300DC80", Length = "0xA4")]
		[NativeName("SetCustomRenderQueue")]
		[Token(Token = "0x60008E6")]
		 set { } //Length: 164
	}

	[Token(Token = "0x17000183")]
	public Shader shader
	{
		[Address(RVA = "0x300DF80", Offset = "0x300D380", Length = "0xB1")]
		[Token(Token = "0x60008BF")]
		 get { } //Length: 177
		[Address(RVA = "0x300E980", Offset = "0x300DD80", Length = "0xDF")]
		[Token(Token = "0x60008C0")]
		 set { } //Length: 223
	}

	[Token(Token = "0x1700018F")]
	public String[] shaderKeywords
	{
		[Address(RVA = "0x3006970", Offset = "0x3005D70", Length = "0x97")]
		[Token(Token = "0x600090C")]
		 get { } //Length: 151
		[Address(RVA = "0x300C080", Offset = "0x300B480", Length = "0xA6")]
		[Token(Token = "0x600090D")]
		 set { } //Length: 166
	}

	[Address(RVA = "0x300D230", Offset = "0x300C630", Length = "0x7A")]
	[Token(Token = "0x6000994")]
	private static Material() { }

	[Address(RVA = "0x300D2B0", Offset = "0x300C6B0", Length = "0x127")]
	[Token(Token = "0x60008B9")]
	public Material(Shader shader) { }

	[Address(RVA = "0x300D430", Offset = "0x300C830", Length = "0x127")]
	[RequiredByNativeCode]
	[Token(Token = "0x60008BA")]
	public Material(Material source) { }

	[Address(RVA = "0x300D3E0", Offset = "0x300C7E0", Length = "0x49")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", True)]
	[Token(Token = "0x60008BB")]
	public Material(string contents) { }

	[Address(RVA = "0x30029C0", Offset = "0x3001DC0", Length = "0x97")]
	[Token(Token = "0x6000910")]
	public int ComputeCRC() { }

	[Address(RVA = "0x3002980", Offset = "0x3001D80", Length = "0x33")]
	[Token(Token = "0x60009C6")]
	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3002AB0", Offset = "0x3001EB0", Length = "0xDF")]
	[FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = True)]
	[Token(Token = "0x6000909")]
	public void CopyMatchingPropertiesFromMaterial(Material mat) { }

	[Address(RVA = "0x3002A60", Offset = "0x3001E60", Length = "0x42")]
	[Token(Token = "0x60009C1")]
	private static void CopyMatchingPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	[Address(RVA = "0x3002BE0", Offset = "0x3001FE0", Length = "0xDF")]
	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	[Token(Token = "0x6000908")]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[Address(RVA = "0x3002B90", Offset = "0x3001F90", Length = "0x42")]
	[Token(Token = "0x60009C0")]
	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	[Address(RVA = "0x3002F00", Offset = "0x3002300", Length = "0x75")]
	[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", True)]
	[Token(Token = "0x60008B6")]
	public static Material Create(string scriptContents) { }

	[Address(RVA = "0x3002D10", Offset = "0x3002110", Length = "0xCB")]
	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	[Token(Token = "0x60008B8")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[Address(RVA = "0x3002CC0", Offset = "0x30020C0", Length = "0x42")]
	[Token(Token = "0x6000996")]
	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	[Address(RVA = "0x3002E30", Offset = "0x3002230", Length = "0xCB")]
	[FreeFunction("MaterialScripting::CreateWithShader")]
	[Token(Token = "0x60008B7")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[Address(RVA = "0x3002DE0", Offset = "0x30021E0", Length = "0x42")]
	[Token(Token = "0x6000995")]
	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	[Address(RVA = "0x3003080", Offset = "0x3002480", Length = "0x1E8")]
	[Token(Token = "0x60008E9")]
	public void DisableKeyword(string keyword) { }

	[Address(RVA = "0x3002FD0", Offset = "0x30023D0", Length = "0xAF")]
	[Token(Token = "0x60008F0")]
	public void DisableKeyword(in LocalKeyword keyword) { }

	[Address(RVA = "0x3002F80", Offset = "0x3002380", Length = "0x42")]
	[Token(Token = "0x60009A9")]
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30032C0", Offset = "0x30026C0", Length = "0xA6")]
	[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x60008EC")]
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	[Address(RVA = "0x3003270", Offset = "0x3002670", Length = "0x42")]
	[Token(Token = "0x60009AC")]
	private static void DisableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x30033C0", Offset = "0x30027C0", Length = "0xAF")]
	[Token(Token = "0x60008EF")]
	public void EnableKeyword(in LocalKeyword keyword) { }

	[Address(RVA = "0x3003470", Offset = "0x3002870", Length = "0x1E8")]
	[Token(Token = "0x60008E8")]
	public void EnableKeyword(string keyword) { }

	[Address(RVA = "0x3003370", Offset = "0x3002770", Length = "0x42")]
	[Token(Token = "0x60009A8")]
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30036B0", Offset = "0x3002AB0", Length = "0xA6")]
	[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = True)]
	[Token(Token = "0x60008EB")]
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	[Address(RVA = "0x3003660", Offset = "0x3002A60", Length = "0x42")]
	[Token(Token = "0x60009AB")]
	private static void EnableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x3003920", Offset = "0x3002D20", Length = "0x124")]
	[Token(Token = "0x6000941")]
	private void ExtractColorArray(int name, List<Color> values) { }

	[Address(RVA = "0x30037B0", Offset = "0x3002BB0", Length = "0x16F")]
	[FreeFunction(Name = "MaterialScripting::ExtractColorArray", HasExplicitThis = True)]
	[Token(Token = "0x6000936")]
	private void ExtractColorArrayImpl(int name, out Color[] val) { }

	[Address(RVA = "0x3003760", Offset = "0x3002B60", Length = "0x50")]
	[Token(Token = "0x60009EA")]
	private static void ExtractColorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3003C10", Offset = "0x3003010", Length = "0x124")]
	[Token(Token = "0x600093F")]
	private void ExtractFloatArray(int name, List<Single> values) { }

	[Address(RVA = "0x3003AA0", Offset = "0x3002EA0", Length = "0x16F")]
	[FreeFunction(Name = "MaterialScripting::ExtractFloatArray", HasExplicitThis = True)]
	[Token(Token = "0x6000934")]
	private void ExtractFloatArrayImpl(int name, out Single[] val) { }

	[Address(RVA = "0x3003A50", Offset = "0x3002E50", Length = "0x50")]
	[Token(Token = "0x60009E8")]
	private static void ExtractFloatArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3003F00", Offset = "0x3003300", Length = "0x124")]
	[Token(Token = "0x6000942")]
	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	[Address(RVA = "0x3003D90", Offset = "0x3003190", Length = "0x16F")]
	[FreeFunction(Name = "MaterialScripting::ExtractMatrixArray", HasExplicitThis = True)]
	[Token(Token = "0x6000937")]
	private void ExtractMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	[Address(RVA = "0x3003D40", Offset = "0x3003140", Length = "0x50")]
	[Token(Token = "0x60009EB")]
	private static void ExtractMatrixArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x30041F0", Offset = "0x30035F0", Length = "0x124")]
	[Token(Token = "0x6000940")]
	private void ExtractVectorArray(int name, List<Vector4> values) { }

	[Address(RVA = "0x3004080", Offset = "0x3003480", Length = "0x16F")]
	[FreeFunction(Name = "MaterialScripting::ExtractVectorArray", HasExplicitThis = True)]
	[Token(Token = "0x6000935")]
	private void ExtractVectorArrayImpl(int name, out Vector4[] val) { }

	[Address(RVA = "0x3004030", Offset = "0x3003430", Length = "0x50")]
	[Token(Token = "0x60009E9")]
	private static void ExtractVectorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	[Address(RVA = "0x3004370", Offset = "0x3003770", Length = "0x1EE")]
	[Token(Token = "0x6000901")]
	public int FindPass(string passName) { }

	[Address(RVA = "0x3004320", Offset = "0x3003720", Length = "0x42")]
	[Token(Token = "0x60009BB")]
	private static int FindPass_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName) { }

	[Address(RVA = "0x300D560", Offset = "0x300C960", Length = "0x193")]
	[Token(Token = "0x60008C1")]
	public Color get_color() { }

	[Address(RVA = "0x300D740", Offset = "0x300CB40", Length = "0x97")]
	[Token(Token = "0x60008F9")]
	public bool get_doubleSidedGI() { }

	[Address(RVA = "0x300D700", Offset = "0x300CB00", Length = "0x33")]
	[Token(Token = "0x60009B3")]
	private static bool get_doubleSidedGI_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30052E0", Offset = "0x30046E0", Length = "0x97")]
	[Token(Token = "0x60008F5")]
	public LocalKeyword[] get_enabledKeywords() { }

	[Address(RVA = "0x300D820", Offset = "0x300CC20", Length = "0x97")]
	[Token(Token = "0x60008FB")]
	public bool get_enableInstancing() { }

	[Address(RVA = "0x300D7E0", Offset = "0x300CBE0", Length = "0x33")]
	[Token(Token = "0x60009B5")]
	private static bool get_enableInstancing_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300D900", Offset = "0x300CD00", Length = "0x97")]
	[Token(Token = "0x60008F7")]
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	[Address(RVA = "0x300D8C0", Offset = "0x300CCC0", Length = "0x33")]
	[Token(Token = "0x60009B1")]
	private static MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300DBA0", Offset = "0x300CFA0", Length = "0xF5")]
	[Token(Token = "0x60008C3")]
	public Texture get_mainTexture() { }

	[Address(RVA = "0x300D9A0", Offset = "0x300CDA0", Length = "0xF5")]
	[Token(Token = "0x60008C5")]
	public Vector2 get_mainTextureOffset() { }

	[Address(RVA = "0x300DAA0", Offset = "0x300CEA0", Length = "0xF5")]
	[Token(Token = "0x60008C7")]
	public Vector2 get_mainTextureScale() { }

	[Address(RVA = "0x300DCE0", Offset = "0x300D0E0", Length = "0x97")]
	[NativeName("GetShader()->GetPassCount")]
	[Token(Token = "0x60008FD")]
	public int get_passCount() { }

	[Address(RVA = "0x300DCA0", Offset = "0x300D0A0", Length = "0x33")]
	[Token(Token = "0x60009B7")]
	private static int get_passCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300DDC0", Offset = "0x300D1C0", Length = "0x97")]
	[NativeName("GetCustomRenderQueue")]
	[Token(Token = "0x60008E7")]
	public int get_rawRenderQueue() { }

	[Address(RVA = "0x300DD80", Offset = "0x300D180", Length = "0x33")]
	[Token(Token = "0x60009A7")]
	private static int get_rawRenderQueue_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300DEA0", Offset = "0x300D2A0", Length = "0x97")]
	[NativeName("GetActualRenderQueue")]
	[Token(Token = "0x60008E5")]
	public int get_renderQueue() { }

	[Address(RVA = "0x300DE60", Offset = "0x300D260", Length = "0x33")]
	[Token(Token = "0x60009A5")]
	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x300DF80", Offset = "0x300D380", Length = "0xB1")]
	[Token(Token = "0x60008BF")]
	public Shader get_shader() { }

	[Address(RVA = "0x300DF40", Offset = "0x300D340", Length = "0x33")]
	[Token(Token = "0x600099A")]
	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3006970", Offset = "0x3005D70", Length = "0x97")]
	[Token(Token = "0x600090C")]
	public String[] get_shaderKeywords() { }

	[Address(RVA = "0x3004670", Offset = "0x3003A70", Length = "0xC2")]
	[Token(Token = "0x6000979")]
	public GraphicsBufferHandle GetBuffer(string name) { }

	[Address(RVA = "0x30045B0", Offset = "0x30039B0", Length = "0xB5")]
	[NativeName("GetBufferFromScript")]
	[Token(Token = "0x6000926")]
	private GraphicsBufferHandle GetBufferImpl(int name) { }

	[Address(RVA = "0x3004560", Offset = "0x3003960", Length = "0x50")]
	[Token(Token = "0x60009DA")]
	private static void GetBufferImpl_Injected(IntPtr _unity_self, int name, out GraphicsBufferHandle ret) { }

	[Address(RVA = "0x3004CF0", Offset = "0x30040F0", Length = "0xD9")]
	[Token(Token = "0x6000971")]
	public Color GetColor(string name) { }

	[Address(RVA = "0x3004DD0", Offset = "0x30041D0", Length = "0xD0")]
	[Token(Token = "0x6000972")]
	public Color GetColor(int nameID) { }

	[Address(RVA = "0x3004AF0", Offset = "0x3003EF0", Length = "0x8")]
	[Token(Token = "0x6000986")]
	public void GetColorArray(int nameID, List<Color> values) { }

	[Address(RVA = "0x30049E0", Offset = "0x3003DE0", Length = "0x37")]
	[Token(Token = "0x6000985")]
	public void GetColorArray(string name, List<Color> values) { }

	[Address(RVA = "0x3004A20", Offset = "0x3003E20", Length = "0xCC")]
	[Token(Token = "0x600097E")]
	public Color[] GetColorArray(int nameID) { }

	[Address(RVA = "0x3004B00", Offset = "0x3003F00", Length = "0xD9")]
	[Token(Token = "0x600097D")]
	public Color[] GetColorArray(string name) { }

	[Address(RVA = "0x3004780", Offset = "0x3003B80", Length = "0xA4")]
	[FreeFunction(Name = "MaterialScripting::GetColorArrayCount", HasExplicitThis = True)]
	[Token(Token = "0x6000932")]
	private int GetColorArrayCountImpl(int name) { }

	[Address(RVA = "0x3004740", Offset = "0x3003B40", Length = "0x40")]
	[Token(Token = "0x60009E6")]
	private static int GetColorArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3004880", Offset = "0x3003C80", Length = "0x15C")]
	[FreeFunction(Name = "MaterialScripting::GetColorArray", HasExplicitThis = True)]
	[Token(Token = "0x600092E")]
	private Color[] GetColorArrayImpl(int name) { }

	[Address(RVA = "0x3004830", Offset = "0x3003C30", Length = "0x50")]
	[Token(Token = "0x60009E2")]
	private static void GetColorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3004C30", Offset = "0x3004030", Length = "0xBE")]
	[NativeName("GetColorFromScript")]
	[Token(Token = "0x6000923")]
	private Color GetColorImpl(int name) { }

	[Address(RVA = "0x3004BE0", Offset = "0x3003FE0", Length = "0x50")]
	[Token(Token = "0x60009D7")]
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	[Address(RVA = "0x3004FC0", Offset = "0x30043C0", Length = "0xC2")]
	[Token(Token = "0x600097A")]
	public GraphicsBufferHandle GetConstantBuffer(string name) { }

	[Address(RVA = "0x3004F00", Offset = "0x3004300", Length = "0xB5")]
	[NativeName("GetConstantBufferFromScript")]
	[Token(Token = "0x6000927")]
	private GraphicsBufferHandle GetConstantBufferImpl(int name) { }

	[Address(RVA = "0x3004EB0", Offset = "0x30042B0", Length = "0x50")]
	[Token(Token = "0x60009DB")]
	private static void GetConstantBufferImpl_Injected(IntPtr _unity_self, int name, out GraphicsBufferHandle ret) { }

	[Address(RVA = "0x30050C0", Offset = "0x30044C0", Length = "0x75")]
	[Token(Token = "0x60008BE")]
	internal static Material GetDefaultLineMaterial() { }

	[Address(RVA = "0x3005090", Offset = "0x3004490", Length = "0x2A")]
	[Token(Token = "0x6000999")]
	private static IntPtr GetDefaultLineMaterial_Injected() { }

	[Address(RVA = "0x3005170", Offset = "0x3004570", Length = "0x75")]
	[Token(Token = "0x60008BC")]
	internal static Material GetDefaultMaterial() { }

	[Address(RVA = "0x3005140", Offset = "0x3004540", Length = "0x2A")]
	[Token(Token = "0x6000997")]
	private static IntPtr GetDefaultMaterial_Injected() { }

	[Address(RVA = "0x3005220", Offset = "0x3004620", Length = "0x75")]
	[Token(Token = "0x60008BD")]
	internal static Material GetDefaultParticleMaterial() { }

	[Address(RVA = "0x30051F0", Offset = "0x30045F0", Length = "0x2A")]
	[Token(Token = "0x6000998")]
	private static IntPtr GetDefaultParticleMaterial_Injected() { }

	[Address(RVA = "0x30052E0", Offset = "0x30046E0", Length = "0x97")]
	[FreeFunction("MaterialScripting::GetEnabledKeywords", HasExplicitThis = True)]
	[Token(Token = "0x60008F3")]
	private LocalKeyword[] GetEnabledKeywords() { }

	[Address(RVA = "0x30052A0", Offset = "0x30046A0", Length = "0x33")]
	[Token(Token = "0x60009AF")]
	private static LocalKeyword[] GetEnabledKeywords_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30053C0", Offset = "0x30047C0", Length = "0xA4")]
	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	[Token(Token = "0x60008C9")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[Address(RVA = "0x3005380", Offset = "0x3004780", Length = "0x40")]
	[Token(Token = "0x600099C")]
	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	[Address(RVA = "0x3005A00", Offset = "0x3004E00", Length = "0xB1")]
	[Token(Token = "0x600096D")]
	public float GetFloat(string name) { }

	[Address(RVA = "0x3005950", Offset = "0x3004D50", Length = "0xA4")]
	[Token(Token = "0x600096E")]
	public float GetFloat(int nameID) { }

	[Address(RVA = "0x3005710", Offset = "0x3004B10", Length = "0xCC")]
	[Token(Token = "0x600097C")]
	public Single[] GetFloatArray(int nameID) { }

	[Address(RVA = "0x3005900", Offset = "0x3004D00", Length = "0x8")]
	[Token(Token = "0x6000984")]
	public void GetFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x30058C0", Offset = "0x3004CC0", Length = "0x37")]
	[Token(Token = "0x6000983")]
	public void GetFloatArray(string name, List<Single> values) { }

	[Address(RVA = "0x30057E0", Offset = "0x3004BE0", Length = "0xD9")]
	[Token(Token = "0x600097B")]
	public Single[] GetFloatArray(string name) { }

	[Address(RVA = "0x30054B0", Offset = "0x30048B0", Length = "0xA4")]
	[FreeFunction(Name = "MaterialScripting::GetFloatArrayCount", HasExplicitThis = True)]
	[Token(Token = "0x6000930")]
	private int GetFloatArrayCountImpl(int name) { }

	[Address(RVA = "0x3005470", Offset = "0x3004870", Length = "0x40")]
	[Token(Token = "0x60009E4")]
	private static int GetFloatArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x30055B0", Offset = "0x30049B0", Length = "0x15C")]
	[FreeFunction(Name = "MaterialScripting::GetFloatArray", HasExplicitThis = True)]
	[Token(Token = "0x600092C")]
	private Single[] GetFloatArrayImpl(int name) { }

	[Address(RVA = "0x3005560", Offset = "0x3004960", Length = "0x50")]
	[Token(Token = "0x60009E0")]
	private static void GetFloatArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3005950", Offset = "0x3004D50", Length = "0xA4")]
	[NativeName("GetFloatFromScript")]
	[Token(Token = "0x6000922")]
	private float GetFloatImpl(int name) { }

	[Address(RVA = "0x3005910", Offset = "0x3004D10", Length = "0x40")]
	[Token(Token = "0x60009D6")]
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3005BB0", Offset = "0x3004FB0", Length = "0xB5")]
	[Token(Token = "0x600096B")]
	public int GetInt(string name) { }

	[Address(RVA = "0x3005C70", Offset = "0x3005070", Length = "0xA8")]
	[Token(Token = "0x600096C")]
	public int GetInt(int nameID) { }

	[Address(RVA = "0x3005B00", Offset = "0x3004F00", Length = "0xA4")]
	[Token(Token = "0x6000970")]
	public int GetInteger(int nameID) { }

	[Address(RVA = "0x3005D20", Offset = "0x3005120", Length = "0xB1")]
	[Token(Token = "0x600096F")]
	public int GetInteger(string name) { }

	[Address(RVA = "0x3005B00", Offset = "0x3004F00", Length = "0xA4")]
	[NativeName("GetIntFromScript")]
	[Token(Token = "0x6000921")]
	private int GetIntImpl(int name) { }

	[Address(RVA = "0x3005AC0", Offset = "0x3004EC0", Length = "0x40")]
	[Token(Token = "0x60009D5")]
	private static int GetIntImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x30064C0", Offset = "0x30058C0", Length = "0x10D")]
	[Token(Token = "0x6000976")]
	public Matrix4x4 GetMatrix(int nameID) { }

	[Address(RVA = "0x30063A0", Offset = "0x30057A0", Length = "0x116")]
	[Token(Token = "0x6000975")]
	public Matrix4x4 GetMatrix(string name) { }

	[Address(RVA = "0x30061B0", Offset = "0x30055B0", Length = "0xCC")]
	[Token(Token = "0x6000982")]
	public Matrix4x4[] GetMatrixArray(int nameID) { }

	[Address(RVA = "0x30060C0", Offset = "0x30054C0", Length = "0xD9")]
	[Token(Token = "0x6000981")]
	public Matrix4x4[] GetMatrixArray(string name) { }

	[Address(RVA = "0x30061A0", Offset = "0x30055A0", Length = "0x8")]
	[Token(Token = "0x600098A")]
	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x3006080", Offset = "0x3005480", Length = "0x37")]
	[Token(Token = "0x6000989")]
	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	[Address(RVA = "0x3005E20", Offset = "0x3005220", Length = "0xA4")]
	[FreeFunction(Name = "MaterialScripting::GetMatrixArrayCount", HasExplicitThis = True)]
	[Token(Token = "0x6000933")]
	private int GetMatrixArrayCountImpl(int name) { }

	[Address(RVA = "0x3005DE0", Offset = "0x30051E0", Length = "0x40")]
	[Token(Token = "0x60009E7")]
	private static int GetMatrixArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3005F20", Offset = "0x3005320", Length = "0x15C")]
	[FreeFunction(Name = "MaterialScripting::GetMatrixArray", HasExplicitThis = True)]
	[Token(Token = "0x600092F")]
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[Address(RVA = "0x3005ED0", Offset = "0x30052D0", Length = "0x50")]
	[Token(Token = "0x60009E3")]
	private static void GetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x30062D0", Offset = "0x30056D0", Length = "0xCA")]
	[NativeName("GetMatrixFromScript")]
	[Token(Token = "0x6000924")]
	private Matrix4x4 GetMatrixImpl(int name) { }

	[Address(RVA = "0x3006280", Offset = "0x3005680", Length = "0x50")]
	[Token(Token = "0x60009D8")]
	private static void GetMatrixImpl_Injected(IntPtr _unity_self, int name, out Matrix4x4 ret) { }

	[Address(RVA = "0x3006620", Offset = "0x3005A20", Length = "0x134")]
	[Token(Token = "0x6000900")]
	public string GetPassName(int pass) { }

	[Address(RVA = "0x30065D0", Offset = "0x30059D0", Length = "0x50")]
	[Token(Token = "0x60009BA")]
	private static void GetPassName_Injected(IntPtr _unity_self, int pass, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30067A0", Offset = "0x3005BA0", Length = "0x97")]
	[FreeFunction("MaterialScripting::GetPropertyCount", HasExplicitThis = True)]
	[Token(Token = "0x600090F")]
	internal int GetPropertyCount() { }

	[Address(RVA = "0x3006760", Offset = "0x3005B60", Length = "0x33")]
	[Token(Token = "0x60009C5")]
	private static int GetPropertyCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3006880", Offset = "0x3005C80", Length = "0xA4")]
	[Token(Token = "0x6000993")]
	public String[] GetPropertyNames(MaterialPropertyType type) { }

	[Address(RVA = "0x3006880", Offset = "0x3005C80", Length = "0xA4")]
	[FreeFunction("MaterialScripting::GetPropertyNames", HasExplicitThis = True)]
	[Token(Token = "0x600090E")]
	private String[] GetPropertyNamesImpl(int propertyType) { }

	[Address(RVA = "0x3006840", Offset = "0x3005C40", Length = "0x40")]
	[Token(Token = "0x60009C4")]
	private static String[] GetPropertyNamesImpl_Injected(IntPtr _unity_self, int propertyType) { }

	[Address(RVA = "0x3006970", Offset = "0x3005D70", Length = "0x97")]
	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	[Token(Token = "0x600090A")]
	private String[] GetShaderKeywords() { }

	[Address(RVA = "0x3006930", Offset = "0x3005D30", Length = "0x33")]
	[Token(Token = "0x60009C2")]
	private static String[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3006A60", Offset = "0x3005E60", Length = "0x1EF")]
	[FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = True)]
	[Token(Token = "0x60008FF")]
	public bool GetShaderPassEnabled(string passName) { }

	[Address(RVA = "0x3006A10", Offset = "0x3005E10", Length = "0x42")]
	[Token(Token = "0x60009B9")]
	private static bool GetShaderPassEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName) { }

	[Address(RVA = "0x3007030", Offset = "0x3006430", Length = "0x67")]
	[Token(Token = "0x6000905")]
	public string GetTag(string tag, bool searchFallbacks) { }

	[Address(RVA = "0x30070A0", Offset = "0x30064A0", Length = "0x14")]
	[Token(Token = "0x6000904")]
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	[Address(RVA = "0x3006CC0", Offset = "0x30060C0", Length = "0x36F")]
	[NativeName("GetTag")]
	[Token(Token = "0x6000903")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	[Address(RVA = "0x3006C50", Offset = "0x3006050", Length = "0x64")]
	[Token(Token = "0x60009BD")]
	private static void GetTagImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag, bool currentSubShaderOnly, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3007B50", Offset = "0x3006F50", Length = "0xA")]
	[Token(Token = "0x6000978")]
	public Texture GetTexture(int nameID) { }

	[Address(RVA = "0x3007B20", Offset = "0x3006F20", Length = "0x28")]
	[Token(Token = "0x6000977")]
	public Texture GetTexture(string name) { }

	[Address(RVA = "0x3007100", Offset = "0x3006500", Length = "0xBE")]
	[NativeName("GetTextureFromScript")]
	[Token(Token = "0x6000925")]
	private Texture GetTextureImpl(int name) { }

	[Address(RVA = "0x30070C0", Offset = "0x30064C0", Length = "0x40")]
	[Token(Token = "0x60009D9")]
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3007290", Offset = "0x3006690", Length = "0x29")]
	[Token(Token = "0x600098F")]
	public Vector2 GetTextureOffset(string name) { }

	[Address(RVA = "0x30071C0", Offset = "0x30065C0", Length = "0xC5")]
	[Token(Token = "0x6000990")]
	public Vector2 GetTextureOffset(int nameID) { }

	[Address(RVA = "0x3007530", Offset = "0x3006930", Length = "0xFC")]
	[Token(Token = "0x6000916")]
	public void GetTexturePropertyNameIDs(List<Int32> outNames) { }

	[Address(RVA = "0x3007410", Offset = "0x3006810", Length = "0x11E")]
	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = True)]
	[Token(Token = "0x6000912")]
	public Int32[] GetTexturePropertyNameIDs() { }

	[Address(RVA = "0x30073C0", Offset = "0x30067C0", Length = "0x42")]
	[Token(Token = "0x60009C8")]
	private static void GetTexturePropertyNameIDs_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3007310", Offset = "0x3006710", Length = "0xA6")]
	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDsInternal", HasExplicitThis = True)]
	[Token(Token = "0x6000914")]
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	[Address(RVA = "0x30072C0", Offset = "0x30066C0", Length = "0x42")]
	[Token(Token = "0x60009CA")]
	private static void GetTexturePropertyNameIDsInternal_Injected(IntPtr _unity_self, object outNames) { }

	[Address(RVA = "0x3007770", Offset = "0x3006B70", Length = "0xFC")]
	[Token(Token = "0x6000915")]
	public void GetTexturePropertyNames(List<String> outNames) { }

	[Address(RVA = "0x3007870", Offset = "0x3006C70", Length = "0x97")]
	[FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = True)]
	[Token(Token = "0x6000911")]
	public String[] GetTexturePropertyNames() { }

	[Address(RVA = "0x3007730", Offset = "0x3006B30", Length = "0x33")]
	[Token(Token = "0x60009C7")]
	private static String[] GetTexturePropertyNames_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3007680", Offset = "0x3006A80", Length = "0xA6")]
	[FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = True)]
	[Token(Token = "0x6000913")]
	private void GetTexturePropertyNamesInternal(object outNames) { }

	[Address(RVA = "0x3007630", Offset = "0x3006A30", Length = "0x42")]
	[Token(Token = "0x60009C9")]
	private static void GetTexturePropertyNamesInternal_Injected(IntPtr _unity_self, object outNames) { }

	[Address(RVA = "0x3007A20", Offset = "0x3006E20", Length = "0xC5")]
	[Token(Token = "0x6000992")]
	public Vector2 GetTextureScale(int nameID) { }

	[Address(RVA = "0x3007AF0", Offset = "0x3006EF0", Length = "0x29")]
	[Token(Token = "0x6000991")]
	public Vector2 GetTextureScale(string name) { }

	[Address(RVA = "0x3007960", Offset = "0x3006D60", Length = "0xBE")]
	[NativeName("GetTextureScaleAndOffsetFromScript")]
	[Token(Token = "0x6000938")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[Address(RVA = "0x3007910", Offset = "0x3006D10", Length = "0x50")]
	[Token(Token = "0x60009EC")]
	private static void GetTextureScaleAndOffsetImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret) { }

	[Address(RVA = "0x30080E0", Offset = "0x30074E0", Length = "0xD5")]
	[Token(Token = "0x6000974")]
	public Vector4 GetVector(int nameID) { }

	[Address(RVA = "0x3008000", Offset = "0x3007400", Length = "0xDE")]
	[Token(Token = "0x6000973")]
	public Vector4 GetVector(string name) { }

	[Address(RVA = "0x3007E00", Offset = "0x3007200", Length = "0xD9")]
	[Token(Token = "0x600097F")]
	public Vector4[] GetVectorArray(string name) { }

	[Address(RVA = "0x3007EE0", Offset = "0x30072E0", Length = "0xCC")]
	[Token(Token = "0x6000980")]
	public Vector4[] GetVectorArray(int nameID) { }

	[Address(RVA = "0x3007FC0", Offset = "0x30073C0", Length = "0x37")]
	[Token(Token = "0x6000987")]
	public void GetVectorArray(string name, List<Vector4> values) { }

	[Address(RVA = "0x3007FB0", Offset = "0x30073B0", Length = "0x8")]
	[Token(Token = "0x6000988")]
	public void GetVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x3007BA0", Offset = "0x3006FA0", Length = "0xA4")]
	[FreeFunction(Name = "MaterialScripting::GetVectorArrayCount", HasExplicitThis = True)]
	[Token(Token = "0x6000931")]
	private int GetVectorArrayCountImpl(int name) { }

	[Address(RVA = "0x3007B60", Offset = "0x3006F60", Length = "0x40")]
	[Token(Token = "0x60009E5")]
	private static int GetVectorArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3007CA0", Offset = "0x30070A0", Length = "0x15C")]
	[FreeFunction(Name = "MaterialScripting::GetVectorArray", HasExplicitThis = True)]
	[Token(Token = "0x600092D")]
	private Vector4[] GetVectorArrayImpl(int name) { }

	[Address(RVA = "0x3007C50", Offset = "0x3007050", Length = "0x50")]
	[Token(Token = "0x60009E1")]
	private static void GetVectorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3008200", Offset = "0x3007600", Length = "0xA4")]
	[Token(Token = "0x60008E1")]
	public bool HasBuffer(int nameID) { }

	[Address(RVA = "0x30082B0", Offset = "0x30076B0", Length = "0xB1")]
	[Token(Token = "0x60008E0")]
	public bool HasBuffer(string name) { }

	[Address(RVA = "0x3008200", Offset = "0x3007600", Length = "0xA4")]
	[NativeName("HasBufferFromScript")]
	[Token(Token = "0x60008DF")]
	private bool HasBufferImpl(int name) { }

	[Address(RVA = "0x30081C0", Offset = "0x30075C0", Length = "0x40")]
	[Token(Token = "0x60009A3")]
	private static bool HasBufferImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3008370", Offset = "0x3007770", Length = "0xB1")]
	[Token(Token = "0x60008DD")]
	public bool HasColor(string name) { }

	[Address(RVA = "0x3008430", Offset = "0x3007830", Length = "0xA4")]
	[Token(Token = "0x60008DE")]
	public bool HasColor(int nameID) { }

	[Address(RVA = "0x3008520", Offset = "0x3007920", Length = "0xA4")]
	[Token(Token = "0x60008E4")]
	public bool HasConstantBuffer(int nameID) { }

	[Address(RVA = "0x30085D0", Offset = "0x30079D0", Length = "0xB1")]
	[Token(Token = "0x60008E3")]
	public bool HasConstantBuffer(string name) { }

	[Address(RVA = "0x3008520", Offset = "0x3007920", Length = "0xA4")]
	[NativeName("HasConstantBufferFromScript")]
	[Token(Token = "0x60008E2")]
	private bool HasConstantBufferImpl(int name) { }

	[Address(RVA = "0x30084E0", Offset = "0x30078E0", Length = "0x40")]
	[Token(Token = "0x60009A4")]
	private static bool HasConstantBufferImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x30086D0", Offset = "0x3007AD0", Length = "0xA4")]
	[Token(Token = "0x60008CE")]
	public bool HasFloat(int nameID) { }

	[Address(RVA = "0x3008780", Offset = "0x3007B80", Length = "0xB1")]
	[Token(Token = "0x60008CD")]
	public bool HasFloat(string name) { }

	[Address(RVA = "0x30086D0", Offset = "0x3007AD0", Length = "0xA4")]
	[NativeName("HasFloatFromScript")]
	[Token(Token = "0x60008CC")]
	private bool HasFloatImpl(int name) { }

	[Address(RVA = "0x3008690", Offset = "0x3007A90", Length = "0x40")]
	[Token(Token = "0x600099E")]
	private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3008780", Offset = "0x3007B80", Length = "0xB1")]
	[Token(Token = "0x60008CF")]
	public bool HasInt(string name) { }

	[Address(RVA = "0x30086D0", Offset = "0x3007AD0", Length = "0xA4")]
	[Token(Token = "0x60008D0")]
	public bool HasInt(int nameID) { }

	[Address(RVA = "0x3008930", Offset = "0x3007D30", Length = "0xB1")]
	[Token(Token = "0x60008D2")]
	public bool HasInteger(string name) { }

	[Address(RVA = "0x3008880", Offset = "0x3007C80", Length = "0xA4")]
	[Token(Token = "0x60008D3")]
	public bool HasInteger(int nameID) { }

	[Address(RVA = "0x3008880", Offset = "0x3007C80", Length = "0xA4")]
	[NativeName("HasIntegerFromScript")]
	[Token(Token = "0x60008D1")]
	private bool HasIntImpl(int name) { }

	[Address(RVA = "0x3008840", Offset = "0x3007C40", Length = "0x40")]
	[Token(Token = "0x600099F")]
	private static bool HasIntImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3008AE0", Offset = "0x3007EE0", Length = "0xB1")]
	[Token(Token = "0x60008D8")]
	public bool HasMatrix(string name) { }

	[Address(RVA = "0x3008A30", Offset = "0x3007E30", Length = "0xA4")]
	[Token(Token = "0x60008D9")]
	public bool HasMatrix(int nameID) { }

	[Address(RVA = "0x3008A30", Offset = "0x3007E30", Length = "0xA4")]
	[NativeName("HasMatrixFromScript")]
	[Token(Token = "0x60008D7")]
	private bool HasMatrixImpl(int name) { }

	[Address(RVA = "0x30089F0", Offset = "0x3007DF0", Length = "0x40")]
	[Token(Token = "0x60009A1")]
	private static bool HasMatrixImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3008BE0", Offset = "0x3007FE0", Length = "0xA4")]
	[NativeName("HasPropertyFromScript")]
	[Token(Token = "0x60008CA")]
	public bool HasProperty(int nameID) { }

	[Address(RVA = "0x3008C90", Offset = "0x3008090", Length = "0xB1")]
	[Token(Token = "0x60008CB")]
	public bool HasProperty(string name) { }

	[Address(RVA = "0x3008BA0", Offset = "0x3007FA0", Length = "0x40")]
	[Token(Token = "0x600099D")]
	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3008E40", Offset = "0x3008240", Length = "0xB1")]
	[Token(Token = "0x60008D5")]
	public bool HasTexture(string name) { }

	[Address(RVA = "0x3008D90", Offset = "0x3008190", Length = "0xA4")]
	[Token(Token = "0x60008D6")]
	public bool HasTexture(int nameID) { }

	[Address(RVA = "0x3008D90", Offset = "0x3008190", Length = "0xA4")]
	[NativeName("HasTextureFromScript")]
	[Token(Token = "0x60008D4")]
	private bool HasTextureImpl(int name) { }

	[Address(RVA = "0x3008D50", Offset = "0x3008150", Length = "0x40")]
	[Token(Token = "0x60009A0")]
	private static bool HasTextureImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3008430", Offset = "0x3007830", Length = "0xA4")]
	[Token(Token = "0x60008DC")]
	public bool HasVector(int nameID) { }

	[Address(RVA = "0x3008370", Offset = "0x3007770", Length = "0xB1")]
	[Token(Token = "0x60008DB")]
	public bool HasVector(string name) { }

	[Address(RVA = "0x3008430", Offset = "0x3007830", Length = "0xA4")]
	[NativeName("HasVectorFromScript")]
	[Token(Token = "0x60008DA")]
	private bool HasVectorImpl(int name) { }

	[Address(RVA = "0x3008F00", Offset = "0x3008300", Length = "0x40")]
	[Token(Token = "0x60009A2")]
	private static bool HasVectorImpl_Injected(IntPtr _unity_self, int name) { }

	[Address(RVA = "0x3009040", Offset = "0x3008440", Length = "0x1EF")]
	[Token(Token = "0x60008EA")]
	public bool IsKeywordEnabled(string keyword) { }

	[Address(RVA = "0x3008F90", Offset = "0x3008390", Length = "0xAF")]
	[Token(Token = "0x60008F2")]
	public bool IsKeywordEnabled(in LocalKeyword keyword) { }

	[Address(RVA = "0x3008F40", Offset = "0x3008340", Length = "0x42")]
	[Token(Token = "0x60009AA")]
	private static bool IsKeywordEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x3009280", Offset = "0x3008680", Length = "0xA6")]
	[FreeFunction("MaterialScripting::IsKeywordEnabled", HasExplicitThis = True)]
	[Token(Token = "0x60008EE")]
	private bool IsLocalKeywordEnabled(LocalKeyword keyword) { }

	[Address(RVA = "0x3009230", Offset = "0x3008630", Length = "0x42")]
	[Token(Token = "0x60009AE")]
	private static bool IsLocalKeywordEnabled_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[Address(RVA = "0x30093A0", Offset = "0x30087A0", Length = "0x120")]
	[FreeFunction("MaterialScripting::Lerp", HasExplicitThis = True)]
	[NativeThrows]
	[Token(Token = "0x6000906")]
	public void Lerp(Material start, Material end, float t) { }

	[Address(RVA = "0x3009330", Offset = "0x3008730", Length = "0x62")]
	[Token(Token = "0x60009BE")]
	private static void Lerp_Injected(IntPtr _unity_self, IntPtr start, IntPtr end, float t) { }

	[Address(RVA = "0x300E040", Offset = "0x300D440", Length = "0x181")]
	[Token(Token = "0x60008C2")]
	public void set_color(Color value) { }

	[Address(RVA = "0x300E220", Offset = "0x300D620", Length = "0xA7")]
	[Token(Token = "0x60008FA")]
	public void set_doubleSidedGI(bool value) { }

	[Address(RVA = "0x300E1D0", Offset = "0x300D5D0", Length = "0x42")]
	[Token(Token = "0x60009B4")]
	private static void set_doubleSidedGI_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x300A5F0", Offset = "0x30099F0", Length = "0xA6")]
	[Token(Token = "0x60008F6")]
	public void set_enabledKeywords(LocalKeyword[] value) { }

	[Address(RVA = "0x300E320", Offset = "0x300D720", Length = "0xA7")]
	[Token(Token = "0x60008FC")]
	public void set_enableInstancing(bool value) { }

	[Address(RVA = "0x300E2D0", Offset = "0x300D6D0", Length = "0x42")]
	[Token(Token = "0x60009B6")]
	private static void set_enableInstancing_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x300E410", Offset = "0x300D810", Length = "0xA4")]
	[Token(Token = "0x60008F8")]
	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	[Address(RVA = "0x300E3D0", Offset = "0x300D7D0", Length = "0x40")]
	[Token(Token = "0x60009B2")]
	private static void set_globalIlluminationFlags_Injected(IntPtr _unity_self, MaterialGlobalIlluminationFlags value) { }

	[Address(RVA = "0x300E720", Offset = "0x300DB20", Length = "0x11E")]
	[Token(Token = "0x60008C4")]
	public void set_mainTexture(Texture value) { }

	[Address(RVA = "0x300E4C0", Offset = "0x300D8C0", Length = "0x125")]
	[Token(Token = "0x60008C6")]
	public void set_mainTextureOffset(Vector2 value) { }

	[Address(RVA = "0x300E5F0", Offset = "0x300D9F0", Length = "0x125")]
	[Token(Token = "0x60008C8")]
	public void set_mainTextureScale(Vector2 value) { }

	[Address(RVA = "0x300E880", Offset = "0x300DC80", Length = "0xA4")]
	[NativeName("SetCustomRenderQueue")]
	[Token(Token = "0x60008E6")]
	public void set_renderQueue(int value) { }

	[Address(RVA = "0x300E840", Offset = "0x300DC40", Length = "0x40")]
	[Token(Token = "0x60009A6")]
	private static void set_renderQueue_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x300E980", Offset = "0x300DD80", Length = "0xDF")]
	[Token(Token = "0x60008C0")]
	public void set_shader(Shader value) { }

	[Address(RVA = "0x300E930", Offset = "0x300DD30", Length = "0x42")]
	[Token(Token = "0x600099B")]
	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x300C080", Offset = "0x300B480", Length = "0xA6")]
	[Token(Token = "0x600090D")]
	public void set_shaderKeywords(String[] value) { }

	[Address(RVA = "0x3009600", Offset = "0x3008A00", Length = "0xD3")]
	[Token(Token = "0x6000956")]
	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x30097D0", Offset = "0x3008BD0", Length = "0xE0")]
	[Token(Token = "0x6000955")]
	public void SetBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x30096E0", Offset = "0x3008AE0", Length = "0xE0")]
	[Token(Token = "0x6000953")]
	public void SetBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x3009520", Offset = "0x3008920", Length = "0xD3")]
	[Token(Token = "0x6000954")]
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x3009520", Offset = "0x3008920", Length = "0xD3")]
	[NativeName("SetBufferFromScript")]
	[Token(Token = "0x600091D")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[Address(RVA = "0x30094D0", Offset = "0x30088D0", Length = "0x50")]
	[Token(Token = "0x60009D1")]
	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x3009FB0", Offset = "0x30093B0", Length = "0xB2")]
	[Token(Token = "0x600094A")]
	public void SetColor(int nameID, Color value) { }

	[Address(RVA = "0x300A070", Offset = "0x3009470", Length = "0xC1")]
	[Token(Token = "0x6000949")]
	public void SetColor(string name, Color value) { }

	[Address(RVA = "0x3009A70", Offset = "0x3008E70", Length = "0x4C")]
	[Token(Token = "0x6000961")]
	public void SetColorArray(string name, Color[] values) { }

	[Address(RVA = "0x3009C60", Offset = "0x3009060", Length = "0x231")]
	[Token(Token = "0x600093D")]
	private void SetColorArray(int name, Color[] values, int count) { }

	[Address(RVA = "0x3009AF0", Offset = "0x3008EF0", Length = "0xA9")]
	[Token(Token = "0x6000960")]
	public void SetColorArray(int nameID, List<Color> values) { }

	[Address(RVA = "0x3009AC0", Offset = "0x3008EC0", Length = "0x25")]
	[Token(Token = "0x6000962")]
	public void SetColorArray(int nameID, Color[] values) { }

	[Address(RVA = "0x3009BA0", Offset = "0x3008FA0", Length = "0xB6")]
	[Token(Token = "0x600095F")]
	public void SetColorArray(string name, List<Color> values) { }

	[Address(RVA = "0x3009920", Offset = "0x3008D20", Length = "0x147")]
	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = True)]
	[Token(Token = "0x600092A")]
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[Address(RVA = "0x30098C0", Offset = "0x3008CC0", Length = "0x60")]
	[Token(Token = "0x60009DE")]
	private static void SetColorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x3009EF0", Offset = "0x30092F0", Length = "0xB4")]
	[NativeName("SetColorFromScript")]
	[Token(Token = "0x6000919")]
	private void SetColorImpl(int name, Color value) { }

	[Address(RVA = "0x3009EA0", Offset = "0x30092A0", Length = "0x50")]
	[Token(Token = "0x60009CD")]
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	[Address(RVA = "0x300A370", Offset = "0x3009770", Length = "0xD5")]
	[Token(Token = "0x600095A")]
	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A280", Offset = "0x3009680", Length = "0xE2")]
	[Token(Token = "0x6000959")]
	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A1A0", Offset = "0x30095A0", Length = "0xD5")]
	[Token(Token = "0x6000958")]
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A450", Offset = "0x3009850", Length = "0xE2")]
	[Token(Token = "0x6000957")]
	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A1A0", Offset = "0x30095A0", Length = "0xD5")]
	[NativeName("SetConstantBufferFromScript")]
	[Token(Token = "0x600091F")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A140", Offset = "0x3009540", Length = "0x60")]
	[Token(Token = "0x60009D3")]
	private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[Address(RVA = "0x300A370", Offset = "0x3009770", Length = "0xD5")]
	[NativeName("SetConstantBufferFromScript")]
	[Token(Token = "0x6000920")]
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[Address(RVA = "0x300A540", Offset = "0x3009940", Length = "0x60")]
	[Token(Token = "0x60009D4")]
	private static void SetConstantGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[Address(RVA = "0x300A5F0", Offset = "0x30099F0", Length = "0xA6")]
	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	[Token(Token = "0x60008F4")]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	[Address(RVA = "0x300A5A0", Offset = "0x30099A0", Length = "0x42")]
	[Token(Token = "0x60009B0")]
	private static void SetEnabledKeywords_Injected(IntPtr _unity_self, LocalKeyword[] keywords) { }

	[Address(RVA = "0x300ADA0", Offset = "0x300A1A0", Length = "0x38")]
	[Token(Token = "0x6000945")]
	public void SetFloat(string name, float value) { }

	[Address(RVA = "0x300AD90", Offset = "0x300A190", Length = "0x8")]
	[Token(Token = "0x6000946")]
	public void SetFloat(int nameID, float value) { }

	[Address(RVA = "0x300A980", Offset = "0x3009D80", Length = "0xB6")]
	[Token(Token = "0x600095B")]
	public void SetFloatArray(string name, List<Single> values) { }

	[Address(RVA = "0x300AA40", Offset = "0x3009E40", Length = "0x231")]
	[Token(Token = "0x600093B")]
	private void SetFloatArray(int name, Single[] values, int count) { }

	[Address(RVA = "0x300A850", Offset = "0x3009C50", Length = "0x25")]
	[Token(Token = "0x600095E")]
	public void SetFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x300A880", Offset = "0x3009C80", Length = "0x4C")]
	[Token(Token = "0x600095D")]
	public void SetFloatArray(string name, Single[] values) { }

	[Address(RVA = "0x300A8D0", Offset = "0x3009CD0", Length = "0xA9")]
	[Token(Token = "0x600095C")]
	public void SetFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x300A700", Offset = "0x3009B00", Length = "0x147")]
	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	[Token(Token = "0x6000928")]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	[Address(RVA = "0x300A6A0", Offset = "0x3009AA0", Length = "0x60")]
	[Token(Token = "0x60009DC")]
	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x300ACD0", Offset = "0x300A0D0", Length = "0xB4")]
	[NativeName("SetFloatFromScript")]
	[Token(Token = "0x6000918")]
	private void SetFloatImpl(int name, float value) { }

	[Address(RVA = "0x300AC80", Offset = "0x300A080", Length = "0x50")]
	[Token(Token = "0x60009CC")]
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	[Address(RVA = "0x3009600", Offset = "0x3008A00", Length = "0xD3")]
	[NativeName("SetBufferFromScript")]
	[Token(Token = "0x600091E")]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[Address(RVA = "0x300ADE0", Offset = "0x300A1E0", Length = "0x50")]
	[Token(Token = "0x60009D2")]
	private static void SetGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x300AF40", Offset = "0x300A340", Length = "0x3B")]
	[Token(Token = "0x6000943")]
	public void SetInt(string name, int value) { }

	[Address(RVA = "0x300AF80", Offset = "0x300A380", Length = "0x10")]
	[Token(Token = "0x6000944")]
	public void SetInt(int nameID, int value) { }

	[Address(RVA = "0x300AFD0", Offset = "0x300A3D0", Length = "0x8")]
	[Token(Token = "0x6000948")]
	public void SetInteger(int nameID, int value) { }

	[Address(RVA = "0x300AF90", Offset = "0x300A390", Length = "0x37")]
	[Token(Token = "0x6000947")]
	public void SetInteger(string name, int value) { }

	[Address(RVA = "0x300AE80", Offset = "0x300A280", Length = "0xB4")]
	[NativeName("SetIntFromScript")]
	[Token(Token = "0x6000917")]
	private void SetIntImpl(int name, int value) { }

	[Address(RVA = "0x300AE30", Offset = "0x300A230", Length = "0x50")]
	[Token(Token = "0x60009CB")]
	private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value) { }

	[Address(RVA = "0x300AFE0", Offset = "0x300A3E0", Length = "0xC0")]
	[Token(Token = "0x60008F1")]
	public void SetKeyword(in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x300B110", Offset = "0x300A510", Length = "0xB8")]
	[FreeFunction("MaterialScripting::SetKeyword", HasExplicitThis = True)]
	[Token(Token = "0x60008ED")]
	private void SetLocalKeyword(LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x300B0B0", Offset = "0x300A4B0", Length = "0x54")]
	[Token(Token = "0x60009AD")]
	private static void SetLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x300B9A0", Offset = "0x300ADA0", Length = "0xD0")]
	[Token(Token = "0x600094E")]
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x300B8C0", Offset = "0x300ACC0", Length = "0xDC")]
	[Token(Token = "0x600094D")]
	public void SetMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x300B440", Offset = "0x300A840", Length = "0x231")]
	[Token(Token = "0x600093E")]
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x300B680", Offset = "0x300AA80", Length = "0xA9")]
	[Token(Token = "0x6000968")]
	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x300B760", Offset = "0x300AB60", Length = "0x4C")]
	[Token(Token = "0x6000969")]
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	[Address(RVA = "0x300B380", Offset = "0x300A780", Length = "0xB6")]
	[Token(Token = "0x6000967")]
	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	[Address(RVA = "0x300B730", Offset = "0x300AB30", Length = "0x25")]
	[Token(Token = "0x600096A")]
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x300B230", Offset = "0x300A630", Length = "0x147")]
	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	[Token(Token = "0x600092B")]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[Address(RVA = "0x300B1D0", Offset = "0x300A5D0", Length = "0x60")]
	[Token(Token = "0x60009DF")]
	private static void SetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[Address(RVA = "0x300B800", Offset = "0x300AC00", Length = "0xB4")]
	[NativeName("SetMatrixFromScript")]
	[Token(Token = "0x600091A")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[Address(RVA = "0x300B7B0", Offset = "0x300ABB0", Length = "0x50")]
	[Token(Token = "0x60009CE")]
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	[Address(RVA = "0x300BAE0", Offset = "0x300AEE0", Length = "0x2F3")]
	[Token(Token = "0x6000902")]
	public void SetOverrideTag(string tag, string val) { }

	[Address(RVA = "0x300BA80", Offset = "0x300AE80", Length = "0x52")]
	[Token(Token = "0x60009BC")]
	private static void SetOverrideTag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag, ref ManagedSpanWrapper val) { }

	[Address(RVA = "0x300BE20", Offset = "0x300B220", Length = "0xA4")]
	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	[Token(Token = "0x6000907")]
	public bool SetPass(int pass) { }

	[Address(RVA = "0x300BDE0", Offset = "0x300B1E0", Length = "0x40")]
	[Token(Token = "0x60009BF")]
	private static bool SetPass_Injected(IntPtr _unity_self, int pass) { }

	[Address(RVA = "0x300BF30", Offset = "0x300B330", Length = "0xF3")]
	[NativeName("SetRenderTextureFromScript")]
	[Token(Token = "0x600091C")]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x300BED0", Offset = "0x300B2D0", Length = "0x60")]
	[Token(Token = "0x60009D0")]
	private static void SetRenderTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value, RenderTextureSubElement element) { }

	[Address(RVA = "0x300C080", Offset = "0x300B480", Length = "0xA6")]
	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	[Token(Token = "0x600090B")]
	private void SetShaderKeywords(String[] names) { }

	[Address(RVA = "0x300C030", Offset = "0x300B430", Length = "0x42")]
	[Token(Token = "0x60009C3")]
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, String[] names) { }

	[Address(RVA = "0x300C190", Offset = "0x300B590", Length = "0x1ED")]
	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	[Token(Token = "0x60008FE")]
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	[Address(RVA = "0x300C130", Offset = "0x300B530", Length = "0x54")]
	[Token(Token = "0x60009B8")]
	private static void SetShaderPassEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName, bool enabled) { }

	[Address(RVA = "0x300CA70", Offset = "0x300BE70", Length = "0xE")]
	[Token(Token = "0x6000952")]
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x300CA10", Offset = "0x300BE10", Length = "0x4D")]
	[Token(Token = "0x6000951")]
	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	[Address(RVA = "0x300C9D0", Offset = "0x300BDD0", Length = "0x37")]
	[Token(Token = "0x600094F")]
	public void SetTexture(string name, Texture value) { }

	[Address(RVA = "0x300CA60", Offset = "0x300BE60", Length = "0x8")]
	[Token(Token = "0x6000950")]
	public void SetTexture(int nameID, Texture value) { }

	[Address(RVA = "0x300C3D0", Offset = "0x300B7D0", Length = "0xF1")]
	[NativeName("SetTextureFromScript")]
	[Token(Token = "0x600091B")]
	private void SetTextureImpl(int name, Texture value) { }

	[Address(RVA = "0x300C380", Offset = "0x300B780", Length = "0x50")]
	[Token(Token = "0x60009CF")]
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	[Address(RVA = "0x300C6A0", Offset = "0x300BAA0", Length = "0xAE")]
	[Token(Token = "0x600098C")]
	public void SetTextureOffset(int nameID, Vector2 value) { }

	[Address(RVA = "0x300C5D0", Offset = "0x300B9D0", Length = "0xCB")]
	[Token(Token = "0x600098B")]
	public void SetTextureOffset(string name, Vector2 value) { }

	[Address(RVA = "0x300C520", Offset = "0x300B920", Length = "0xAE")]
	[NativeName("SetTextureOffsetFromScript")]
	[Token(Token = "0x6000939")]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[Address(RVA = "0x300C4D0", Offset = "0x300B8D0", Length = "0x50")]
	[Token(Token = "0x60009ED")]
	private static void SetTextureOffsetImpl_Injected(IntPtr _unity_self, int name, in Vector2 offset) { }

	[Address(RVA = "0x300C920", Offset = "0x300BD20", Length = "0xAE")]
	[Token(Token = "0x600098E")]
	public void SetTextureScale(int nameID, Vector2 value) { }

	[Address(RVA = "0x300C850", Offset = "0x300BC50", Length = "0xCB")]
	[Token(Token = "0x600098D")]
	public void SetTextureScale(string name, Vector2 value) { }

	[Address(RVA = "0x300C7A0", Offset = "0x300BBA0", Length = "0xAE")]
	[NativeName("SetTextureScaleFromScript")]
	[Token(Token = "0x600093A")]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	[Address(RVA = "0x300C750", Offset = "0x300BB50", Length = "0x50")]
	[Token(Token = "0x60009EE")]
	private static void SetTextureScaleImpl_Injected(IntPtr _unity_self, int name, in Vector2 scale) { }

	[Address(RVA = "0x300D060", Offset = "0x300C460", Length = "0xD7")]
	[Token(Token = "0x600094C")]
	public void SetVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x300D140", Offset = "0x300C540", Length = "0xE6")]
	[Token(Token = "0x600094B")]
	public void SetVector(string name, Vector4 value) { }

	[Address(RVA = "0x300CC30", Offset = "0x300C030", Length = "0xA9")]
	[Token(Token = "0x6000964")]
	public void SetVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x300D010", Offset = "0x300C410", Length = "0x4C")]
	[Token(Token = "0x6000965")]
	public void SetVectorArray(string name, Vector4[] values) { }

	[Address(RVA = "0x300CF20", Offset = "0x300C320", Length = "0x25")]
	[Token(Token = "0x6000966")]
	public void SetVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x300CCE0", Offset = "0x300C0E0", Length = "0x231")]
	[Token(Token = "0x600093C")]
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x300CF50", Offset = "0x300C350", Length = "0xB6")]
	[Token(Token = "0x6000963")]
	public void SetVectorArray(string name, List<Vector4> values) { }

	[Address(RVA = "0x300CAE0", Offset = "0x300BEE0", Length = "0x147")]
	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	[Token(Token = "0x6000929")]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[Address(RVA = "0x300CA80", Offset = "0x300BE80", Length = "0x60")]
	[Token(Token = "0x60009DD")]
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

}

