namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000260")]
internal static class SceneManagerAPIInternal
{

	[Address(RVA = "0x30865A0", Offset = "0x30859A0", Length = "0x21F")]
	[NativeThrows]
	[Token(Token = "0x6001865")]
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x3086530", Offset = "0x3085930", Length = "0x62")]
	[Token(Token = "0x6001867")]
	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, in LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x3086830", Offset = "0x3085C30", Length = "0x23B")]
	[NativeThrows]
	[Token(Token = "0x6001866")]
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	[Address(RVA = "0x30867C0", Offset = "0x3085BC0", Length = "0x62")]
	[Token(Token = "0x6001868")]
	private static IntPtr UnloadSceneNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

