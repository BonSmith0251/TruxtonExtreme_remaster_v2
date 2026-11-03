namespace UnityEngine;

[Token(Token = "0x2000164")]
internal interface IPlayerEditorConnectionNative
{

	[Token(Token = "0x60011C9")]
	public void DisconnectAll() { }

	[Token(Token = "0x60011C8")]
	public void Initialize() { }

	[Token(Token = "0x60011CF")]
	public bool IsConnected() { }

	[Token(Token = "0x60011CC")]
	public void Poll() { }

	[Token(Token = "0x60011CD")]
	public void RegisterInternal(Guid messageId) { }

	[Token(Token = "0x60011CA")]
	public void SendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Token(Token = "0x60011CB")]
	public bool TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Token(Token = "0x60011CE")]
	public void UnregisterInternal(Guid messageId) { }

}

