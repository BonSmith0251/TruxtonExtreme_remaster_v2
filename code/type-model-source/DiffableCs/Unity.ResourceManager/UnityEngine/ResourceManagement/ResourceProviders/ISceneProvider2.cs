namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000060")]
internal interface ISceneProvider2 : ISceneProvider
{

	[Token(Token = "0x6000228")]
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

}

