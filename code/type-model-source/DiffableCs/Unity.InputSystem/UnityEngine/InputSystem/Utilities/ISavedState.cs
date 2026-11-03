namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000267")]
internal interface ISavedState
{

	[Token(Token = "0x6001669")]
	public void RestoreSavedState() { }

	[Token(Token = "0x6001668")]
	public void StaticDisposeCurrentState() { }

}

