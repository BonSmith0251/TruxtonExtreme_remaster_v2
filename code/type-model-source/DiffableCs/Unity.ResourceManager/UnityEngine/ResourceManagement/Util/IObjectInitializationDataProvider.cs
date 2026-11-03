namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000036")]
public interface IObjectInitializationDataProvider
{

	[Token(Token = "0x17000026")]
	public string Name
	{
		[Token(Token = "0x6000145")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000146")]
	public ObjectInitializationData CreateObjectInitializationData() { }

	[Token(Token = "0x6000145")]
	public string get_Name() { }

}

