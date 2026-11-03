namespace System.Security;

[ComVisible(True)]
[Token(Token = "0x20002D4")]
public class SecurityException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C28")]
	private string permissionState; //Field offset: 0x90

	[Address(RVA = "0x1EAD370", Offset = "0x1EAC770", Length = "0x4E")]
	[Token(Token = "0x60017CC")]
	public SecurityException() { }

	[Address(RVA = "0x1EAD330", Offset = "0x1EAC730", Length = "0x1E")]
	[Token(Token = "0x60017CD")]
	public SecurityException(string message) { }

	[Address(RVA = "0x1EAD3C0", Offset = "0x1EAC7C0", Length = "0x131")]
	[Token(Token = "0x60017CE")]
	protected SecurityException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EAD350", Offset = "0x1EAC750", Length = "0x1E")]
	[Token(Token = "0x60017CF")]
	public SecurityException(string message, Exception inner) { }

	[Address(RVA = "0x1EAD290", Offset = "0x1EAC690", Length = "0x87")]
	[Token(Token = "0x60017D0")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EAD320", Offset = "0x1EAC720", Length = "0x7")]
	[Token(Token = "0x60017D1")]
	public virtual string ToString() { }

}

