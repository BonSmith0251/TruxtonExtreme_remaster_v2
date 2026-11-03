namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200005F")]
public interface ISceneProvider
{

	[Token(Token = "0x6000224")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority) { }

	[Token(Token = "0x6000225")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	[Token(Token = "0x6000226")]
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority) { }

	[Token(Token = "0x6000227")]
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

}

