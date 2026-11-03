namespace Unity.Cinemachine;

[Token(Token = "0x20000C4")]
public interface IInputAxisResetSource
{

	[Token(Token = "0x170000D1")]
	public bool HasResetHandler
	{
		[Token(Token = "0x60003BC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60003BC")]
	public bool get_HasResetHandler() { }

	[Token(Token = "0x60003BA")]
	public void RegisterResetHandler(Action handler) { }

	[Token(Token = "0x60003BB")]
	public void UnregisterResetHandler(Action handler) { }

}

