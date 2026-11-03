namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x2000307")]
public interface IEditorPlayerConnection
{

	[Token(Token = "0x60018B0")]
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	[Token(Token = "0x60018B1")]
	public void RegisterConnection(UnityAction<Int32> callback) { }

	[Token(Token = "0x60018B2")]
	public void RegisterDisconnection(UnityAction<Int32> callback) { }

	[Token(Token = "0x60018B3")]
	public void Send(Guid messageId, Byte[] data) { }

}

