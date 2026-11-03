namespace UnityEngine.Rendering;

[Token(Token = "0x2000019")]
public interface ICameraHistoryWriteAccess
{

	[Token(Token = "0x60000B9")]
	public Type GetHistoryForWrite() { }

	[Token(Token = "0x60000B8")]
	public bool IsAccessRequested() { }

	[Token(Token = "0x60000BA")]
	public bool IsWritten() { }

}

