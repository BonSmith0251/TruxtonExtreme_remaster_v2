namespace UnityEngine.InputForUI;

[Token(Token = "0x2000022")]
internal interface IEventProviderImpl
{

	[Token(Token = "0x6000081")]
	public void Initialize() { }

	[Token(Token = "0x6000084")]
	public void OnFocusChanged(bool focus) { }

	[Token(Token = "0x6000082")]
	public void Shutdown() { }

	[Token(Token = "0x6000083")]
	public void Update() { }

}

