namespace InGame.Kernel;

[Token(Token = "0x200008C")]
public interface IRuinObject
{

	[Token(Token = "0x6000563")]
	public bool CheckTimeout(float dt) { }

	[Token(Token = "0x6000562")]
	public void FinishRuin() { }

	[Token(Token = "0x6000560")]
	public void Initialize() { }

	[Token(Token = "0x6000561")]
	public void StartRuin(Vector3 pos, float aliveTime, bool isGround, Action _callback) { }

}

