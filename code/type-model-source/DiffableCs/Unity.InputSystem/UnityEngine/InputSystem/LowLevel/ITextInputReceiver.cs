namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x200019A")]
public interface ITextInputReceiver
{

	[Token(Token = "0x6001005")]
	public void OnIMECompositionChanged(IMECompositionString compositionString) { }

	[Token(Token = "0x6001004")]
	public void OnTextInput(char character) { }

}

