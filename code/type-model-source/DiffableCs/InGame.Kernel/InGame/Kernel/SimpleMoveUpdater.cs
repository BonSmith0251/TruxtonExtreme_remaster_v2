namespace InGame.Kernel;

[Token(Token = "0x20000B3")]
public interface SimpleMoveUpdater
{

	[Token(Token = "0x6000677")]
	public void Initialize() { }

	[Token(Token = "0x6000679")]
	public void Progress(float dt) { }

	[Token(Token = "0x6000678")]
	public void Setup() { }

	[Token(Token = "0x600067A")]
	public void Terminate() { }

}

