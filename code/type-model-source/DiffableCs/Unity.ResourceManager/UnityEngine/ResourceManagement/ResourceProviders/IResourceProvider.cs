namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200005C")]
public interface IResourceProvider
{

	[Token(Token = "0x17000057")]
	public ProviderBehaviourFlags BehaviourFlags
	{
		[Token(Token = "0x600021C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000056")]
	public string ProviderId
	{
		[Token(Token = "0x6000217")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000219")]
	public bool CanProvide(Type type, IResourceLocation location) { }

	[Token(Token = "0x600021C")]
	public ProviderBehaviourFlags get_BehaviourFlags() { }

	[Token(Token = "0x6000217")]
	public string get_ProviderId() { }

	[Token(Token = "0x6000218")]
	public Type GetDefaultType(IResourceLocation location) { }

	[Token(Token = "0x600021A")]
	public void Provide(ProvideHandle provideHandle) { }

	[Token(Token = "0x600021B")]
	public void Release(IResourceLocation location, object asset) { }

}

