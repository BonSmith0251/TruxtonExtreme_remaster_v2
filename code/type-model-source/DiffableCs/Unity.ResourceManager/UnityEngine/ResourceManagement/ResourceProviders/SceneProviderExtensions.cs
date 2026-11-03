namespace UnityEngine.ResourceManagement.ResourceProviders;

[Extension]
[Token(Token = "0x2000061")]
internal static class SceneProviderExtensions
{

	[Address(RVA = "0x2E4F200", Offset = "0x2E4E600", Length = "0x262")]
	[Extension]
	[Token(Token = "0x6000229")]
	public static AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

}

