namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000058")]
public interface IInstanceProvider
{

	[Token(Token = "0x6000205")]
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	[Token(Token = "0x6000206")]
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

}

