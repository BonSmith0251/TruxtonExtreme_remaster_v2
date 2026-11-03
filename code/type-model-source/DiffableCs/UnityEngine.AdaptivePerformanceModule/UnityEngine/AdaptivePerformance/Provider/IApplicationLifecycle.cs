namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000052")]
public interface IApplicationLifecycle
{

	[Token(Token = "0x600025F")]
	public void ApplicationPause() { }

	[Token(Token = "0x6000260")]
	public void ApplicationResume() { }

}

