namespace UnityEngine.AddressableAssets.ResourceLocators;

[Token(Token = "0x2000059")]
public interface IResourceLocator
{

	[Token(Token = "0x1700005B")]
	public IEnumerable<IResourceLocation> AllLocations
	{
		[Token(Token = "0x600022E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700005A")]
	public IEnumerable<Object> Keys
	{
		[Token(Token = "0x600022D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000059")]
	public string LocatorId
	{
		[Token(Token = "0x600022C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600022E")]
	public IEnumerable<IResourceLocation> get_AllLocations() { }

	[Token(Token = "0x600022D")]
	public IEnumerable<Object> get_Keys() { }

	[Token(Token = "0x600022C")]
	public string get_LocatorId() { }

	[Token(Token = "0x600022F")]
	public bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

}

