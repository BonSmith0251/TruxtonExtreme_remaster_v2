namespace System;

[Token(Token = "0x200011F")]
public class ObjectDisposedException : InvalidOperationException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000423")]
	private string _objectName; //Field offset: 0x90

	[Token(Token = "0x17000092")]
	public virtual string Message
	{
		[Address(RVA = "0x20439F0", Offset = "0x2042DF0", Length = "0xA9")]
		[Token(Token = "0x6000948")]
		 get { } //Length: 169
	}

	[Token(Token = "0x17000093")]
	public string ObjectName
	{
		[Address(RVA = "0x2043AA0", Offset = "0x2042EA0", Length = "0x24")]
		[Token(Token = "0x6000949")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x20438D0", Offset = "0x2042CD0", Length = "0x5C")]
	[Token(Token = "0x6000943")]
	private ObjectDisposedException() { }

	[Address(RVA = "0x2043980", Offset = "0x2042D80", Length = "0x65")]
	[Token(Token = "0x6000944")]
	public ObjectDisposedException(string objectName) { }

	[Address(RVA = "0x2043930", Offset = "0x2042D30", Length = "0x45")]
	[Token(Token = "0x6000945")]
	public ObjectDisposedException(string objectName, string message) { }

	[Address(RVA = "0x2043830", Offset = "0x2042C30", Length = "0x90")]
	[Token(Token = "0x6000946")]
	protected ObjectDisposedException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20439F0", Offset = "0x2042DF0", Length = "0xA9")]
	[Token(Token = "0x6000948")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2043AA0", Offset = "0x2042EA0", Length = "0x24")]
	[Token(Token = "0x6000949")]
	public string get_ObjectName() { }

	[Address(RVA = "0x2043740", Offset = "0x2042B40", Length = "0xE8")]
	[Token(Token = "0x6000947")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

