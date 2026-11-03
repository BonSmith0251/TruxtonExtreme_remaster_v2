namespace System.Net;

[Token(Token = "0x2000283")]
internal sealed class FileWebStream : FileStream, ICloseEx
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A55")]
	private FileWebRequest m_request; //Field offset: 0x70

	[Address(RVA = "0x26C3F20", Offset = "0x26C3320", Length = "0x99")]
	[Token(Token = "0x60010EF")]
	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	[Address(RVA = "0x26C3FC0", Offset = "0x26C33C0", Length = "0xB0")]
	[Token(Token = "0x60010F0")]
	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	[Address(RVA = "0x26C3AA0", Offset = "0x26C2EA0", Length = "0xA0")]
	[Token(Token = "0x60010F5")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C3B50", Offset = "0x26C2F50", Length = "0xA0")]
	[Token(Token = "0x60010F7")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26C3C00", Offset = "0x26C3000", Length = "0x99")]
	[Token(Token = "0x60010F9")]
	private void CheckError() { }

	[Address(RVA = "0x26C3CA0", Offset = "0x26C30A0", Length = "0x80")]
	[Token(Token = "0x60010F1")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26C3D30", Offset = "0x26C3130", Length = "0x3D")]
	[Token(Token = "0x60010F6")]
	public virtual int EndRead(IAsyncResult ar) { }

	[Address(RVA = "0x26C3D70", Offset = "0x26C3170", Length = "0x3D")]
	[Token(Token = "0x60010F8")]
	public virtual void EndWrite(IAsyncResult ar) { }

	[Address(RVA = "0x26C3DB0", Offset = "0x26C31B0", Length = "0x85")]
	[Token(Token = "0x60010F3")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x26C3E40", Offset = "0x26C3240", Length = "0x49")]
	[Token(Token = "0x60010F2")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x26C3E90", Offset = "0x26C3290", Length = "0x85")]
	[Token(Token = "0x60010F4")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

