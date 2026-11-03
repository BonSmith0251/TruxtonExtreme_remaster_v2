namespace System.Net;

[Token(Token = "0x2000231")]
internal class FtpDataStream : Stream, ICloseEx
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400086C")]
	private FtpWebRequest _request; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400086D")]
	private NetworkStream _networkStream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400086E")]
	private bool _writeable; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x400086F")]
	private bool _readable; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000870")]
	private bool _isFullyRead; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4000871")]
	private bool _closing; //Field offset: 0x3B

	[Token(Token = "0x170002F1")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[Token(Token = "0x6000ED8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002F2")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x1FE3DD0", Offset = "0x1FE31D0", Length = "0x2A")]
		[Token(Token = "0x6000ED9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002F6")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x26A0C30", Offset = "0x26A0030", Length = "0x2A")]
		[Token(Token = "0x6000EE7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002F3")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000EDA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002F4")]
	public virtual long Length
	{
		[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
		[Token(Token = "0x6000EDB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170002F5")]
	public virtual long Position
	{
		[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
		[Token(Token = "0x6000EDC")]
		 get { } //Length: 42
		[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
		[Token(Token = "0x6000EDD")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170002F7")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x26A0C60", Offset = "0x26A0060", Length = "0x2A")]
		[Token(Token = "0x6000EE8")]
		 get { } //Length: 42
		[Address(RVA = "0x1F2EC40", Offset = "0x1F2E040", Length = "0x2A")]
		[Token(Token = "0x6000EE9")]
		 set { } //Length: 42
	}

	[Token(Token = "0x170002F8")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x26A0C90", Offset = "0x26A0090", Length = "0x2A")]
		[Token(Token = "0x6000EEA")]
		 get { } //Length: 42
		[Address(RVA = "0x1F30950", Offset = "0x1F2FD50", Length = "0x2A")]
		[Token(Token = "0x6000EEB")]
		 set { } //Length: 42
	}

	[Address(RVA = "0x26A0B20", Offset = "0x269FF20", Length = "0x109")]
	[Token(Token = "0x6000ED4")]
	internal FtpDataStream(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	[Address(RVA = "0x269FDF0", Offset = "0x269F1F0", Length = "0x164")]
	[Token(Token = "0x6000EE1")]
	private void AsyncReadCallback(IAsyncResult ar) { }

	[Address(RVA = "0x269FF60", Offset = "0x269F360", Length = "0x175")]
	[Token(Token = "0x6000EE2")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26A00E0", Offset = "0x269F4E0", Length = "0xB3")]
	[Token(Token = "0x6000EE4")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x26A01A0", Offset = "0x269F5A0", Length = "0x4B")]
	[Token(Token = "0x6000ED7")]
	private void CheckError() { }

	[Address(RVA = "0x26A01F0", Offset = "0x269F5F0", Length = "0xBD")]
	[Token(Token = "0x6000ED5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26A02B0", Offset = "0x269F6B0", Length = "0x184")]
	[Token(Token = "0x6000EE3")]
	public virtual int EndRead(IAsyncResult ar) { }

	[Address(RVA = "0x26A0440", Offset = "0x269F840", Length = "0xA4")]
	[Token(Token = "0x6000EE5")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x26A04F0", Offset = "0x269F8F0", Length = "0x2A")]
	[Token(Token = "0x6000EE6")]
	public virtual void Flush() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[Token(Token = "0x6000ED8")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1FE3DD0", Offset = "0x1FE31D0", Length = "0x2A")]
	[Token(Token = "0x6000ED9")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x26A0C30", Offset = "0x26A0030", Length = "0x2A")]
	[Token(Token = "0x6000EE7")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000EDA")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1FE42F0", Offset = "0x1FE36F0", Length = "0x2A")]
	[Token(Token = "0x6000EDB")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1FE4320", Offset = "0x1FE3720", Length = "0x2A")]
	[Token(Token = "0x6000EDC")]
	public virtual long get_Position() { }

	[Address(RVA = "0x26A0C60", Offset = "0x26A0060", Length = "0x2A")]
	[Token(Token = "0x6000EE8")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x26A0C90", Offset = "0x26A0090", Length = "0x2A")]
	[Token(Token = "0x6000EEA")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x26A0520", Offset = "0x269F920", Length = "0xC8")]
	[Token(Token = "0x6000EDF")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x26A05F0", Offset = "0x269F9F0", Length = "0x93")]
	[Token(Token = "0x6000EDE")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x1F2EA90", Offset = "0x1F2DE90", Length = "0x2A")]
	[Token(Token = "0x6000EDD")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1F2EC40", Offset = "0x1F2E040", Length = "0x2A")]
	[Token(Token = "0x6000EE9")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x1F30950", Offset = "0x1F2FD50", Length = "0x2A")]
	[Token(Token = "0x6000EEB")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x26A0690", Offset = "0x269FA90", Length = "0x59")]
	[Token(Token = "0x6000EEC")]
	internal void SetSocketTimeoutOption(int timeout) { }

	[Address(RVA = "0x26A06F0", Offset = "0x269FAF0", Length = "0x38A")]
	[Token(Token = "0x6000ED6")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x26A0A80", Offset = "0x269FE80", Length = "0x99")]
	[Token(Token = "0x6000EE0")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

