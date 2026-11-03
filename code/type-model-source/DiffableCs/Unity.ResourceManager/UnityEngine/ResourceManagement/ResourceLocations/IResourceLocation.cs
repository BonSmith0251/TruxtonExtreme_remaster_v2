namespace UnityEngine.ResourceManagement.ResourceLocations;

[Token(Token = "0x200006D")]
public interface IResourceLocation
{

	[Token(Token = "0x17000067")]
	public object Data
	{
		[Token(Token = "0x6000270")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000064")]
	public IList<IResourceLocation> Dependencies
	{
		[Token(Token = "0x600026C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000065")]
	public int DependencyHashCode
	{
		[Token(Token = "0x600026E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000066")]
	public bool HasDependencies
	{
		[Token(Token = "0x600026F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000062")]
	public string InternalId
	{
		[Token(Token = "0x600026A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000068")]
	public string PrimaryKey
	{
		[Token(Token = "0x6000271")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000063")]
	public string ProviderId
	{
		[Token(Token = "0x600026B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000069")]
	public Type ResourceType
	{
		[Token(Token = "0x6000272")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000270")]
	public object get_Data() { }

	[Token(Token = "0x600026C")]
	public IList<IResourceLocation> get_Dependencies() { }

	[Token(Token = "0x600026E")]
	public int get_DependencyHashCode() { }

	[Token(Token = "0x600026F")]
	public bool get_HasDependencies() { }

	[Token(Token = "0x600026A")]
	public string get_InternalId() { }

	[Token(Token = "0x6000271")]
	public string get_PrimaryKey() { }

	[Token(Token = "0x600026B")]
	public string get_ProviderId() { }

	[Token(Token = "0x6000272")]
	public Type get_ResourceType() { }

	[Token(Token = "0x600026D")]
	public int Hash(Type resultType) { }

}

