namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000262")]
public class SceneManager
{
	[Token(Token = "0x40007D2")]
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40007D3")]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40007D4")]
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40007D5")]
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x18

	[Token(Token = "0x1400000D")]
	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[Address(RVA = "0x3087900", Offset = "0x3086D00", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6001878")]
		 add { } //Length: 261
		[Address(RVA = "0x3087B50", Offset = "0x3086F50", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6001879")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x1400000E")]
	public static event UnityAction<Scene> sceneUnloaded
	{
		[Address(RVA = "0x3087A10", Offset = "0x3086E10", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x600187A")]
		 add { } //Length: 261
		[Address(RVA = "0x3087C60", Offset = "0x3087060", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x600187B")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x17000398")]
	public static int sceneCount
	{
		[Address(RVA = "0x3087B20", Offset = "0x3086F20", Length = "0x2A")]
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[NativeMethod("GetSceneCount")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
		[Token(Token = "0x6001870")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x30878C0", Offset = "0x3086CC0", Length = "0x36")]
	[Token(Token = "0x6001883")]
	private static SceneManager() { }

	[Address(RVA = "0x3087900", Offset = "0x3086D00", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6001878")]
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[Address(RVA = "0x3087A10", Offset = "0x3086E10", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x600187A")]
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[Address(RVA = "0x3087B20", Offset = "0x3086F20", Length = "0x2A")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeMethod("GetSceneCount")]
	[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001870")]
	public static int get_sceneCount() { }

	[Address(RVA = "0x3086C90", Offset = "0x3086090", Length = "0x6C")]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001871")]
	public static Scene GetActiveScene() { }

	[Address(RVA = "0x3086C50", Offset = "0x3086050", Length = "0x33")]
	[Token(Token = "0x6001884")]
	private static void GetActiveScene_Injected(out Scene ret) { }

	[Address(RVA = "0x3086D40", Offset = "0x3086140", Length = "0x73")]
	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001873")]
	public static Scene GetSceneAt(int index) { }

	[Address(RVA = "0x3086D00", Offset = "0x3086100", Length = "0x40")]
	[Token(Token = "0x6001886")]
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	[Address(RVA = "0x3086E10", Offset = "0x3086210", Length = "0x1CC")]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001872")]
	public static Scene GetSceneByName(string name) { }

	[Address(RVA = "0x3086DC0", Offset = "0x30861C0", Length = "0x42")]
	[Token(Token = "0x6001885")]
	private static void GetSceneByName_Injected(ref ManagedSpanWrapper name, out Scene ret) { }

	[Address(RVA = "0x3086FE0", Offset = "0x30863E0", Length = "0x9C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001882")]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[Address(RVA = "0x3087080", Offset = "0x3086480", Length = "0x9C")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001880")]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[Address(RVA = "0x3087120", Offset = "0x3086520", Length = "0x94")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001881")]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[Address(RVA = "0x30871C0", Offset = "0x30865C0", Length = "0x6A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001877")]
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	[Address(RVA = "0x3087310", Offset = "0x3086710", Length = "0x129")]
	[Token(Token = "0x600187C")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[Address(RVA = "0x3087440", Offset = "0x3086840", Length = "0xFC")]
	[Token(Token = "0x600187D")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	[Address(RVA = "0x3087230", Offset = "0x3086630", Length = "0xDC")]
	[Token(Token = "0x6001875")]
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x3087B50", Offset = "0x3086F50", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6001879")]
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[Address(RVA = "0x3087C60", Offset = "0x3087060", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x600187B")]
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	[Address(RVA = "0x30876D0", Offset = "0x3086AD0", Length = "0xFE")]
	[Token(Token = "0x600187E")]
	public static AsyncOperation UnloadSceneAsync(string sceneName) { }

	[Address(RVA = "0x3087600", Offset = "0x3086A00", Length = "0xC1")]
	[Token(Token = "0x600187F")]
	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	[Address(RVA = "0x3087580", Offset = "0x3086980", Length = "0x7F")]
	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001874")]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	[Address(RVA = "0x3087540", Offset = "0x3086940", Length = "0x40")]
	[Token(Token = "0x6001887")]
	private static IntPtr UnloadSceneAsyncInternal_Injected(in Scene scene, UnloadSceneOptions options) { }

	[Address(RVA = "0x30877D0", Offset = "0x3086BD0", Length = "0xEE")]
	[Token(Token = "0x6001876")]
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

