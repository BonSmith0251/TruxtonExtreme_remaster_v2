namespace UnityEngine.InputSystem;

[Token(Token = "0x2000019")]
public interface IInputInteraction
{

	[Token(Token = "0x600012D")]
	public void Process(ref InputInteractionContext context) { }

	[Token(Token = "0x600012E")]
	public void Reset() { }

}

