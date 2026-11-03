namespace UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200007A")]
internal interface ICachable
{

	[Token(Token = "0x17000081")]
	public IOperationCacheKey Key
	{
		[Token(Token = "0x60002AB")]
		 get { } //Length: 0
		[Token(Token = "0x60002AC")]
		 set { } //Length: 0
	}

	[Token(Token = "0x60002AB")]
	public IOperationCacheKey get_Key() { }

	[Token(Token = "0x60002AC")]
	public void set_Key(IOperationCacheKey value) { }

}

