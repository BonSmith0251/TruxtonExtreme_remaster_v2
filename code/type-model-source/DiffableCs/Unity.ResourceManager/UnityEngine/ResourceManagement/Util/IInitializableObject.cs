namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000035")]
public interface IInitializableObject
{

	[Token(Token = "0x6000143")]
	public bool Initialize(string id, string data) { }

	[Token(Token = "0x6000144")]
	public AsyncOperationHandle<Boolean> InitializeAsync(ResourceManager rm, string id, string data) { }

}

