namespace System.Net;

[Token(Token = "0x200025F")]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AC")]
	private bool m_IsCacheFresh; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40009AD")]
	private bool m_IsFromCache; //Field offset: 0x19

	[Token(Token = "0x1700034F")]
	public override WebHeaderCollection Headers
	{
		[Address(RVA = "0x26B2730", Offset = "0x26B1B30", Length = "0x27")]
		[Token(Token = "0x600100E")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700034D")]
	public override bool IsFromCache
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x600100B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700034E")]
	public override Uri ResponseUri
	{
		[Address(RVA = "0x26B2760", Offset = "0x26B1B60", Length = "0x17E")]
		[Token(Token = "0x600100D")]
		 get { } //Length: 382
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001004")]
	protected WebResponse() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001005")]
	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001008")]
	public override void Close() { }

	[Address(RVA = "0x26B2690", Offset = "0x26B1A90", Length = "0x61")]
	[Token(Token = "0x6001009")]
	public override void Dispose() { }

	[Address(RVA = "0x26B2660", Offset = "0x26B1A60", Length = "0x23")]
	[Token(Token = "0x600100A")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x26B2730", Offset = "0x26B1B30", Length = "0x27")]
	[Token(Token = "0x600100E")]
	public override WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[Token(Token = "0x600100B")]
	public override bool get_IsFromCache() { }

	[Address(RVA = "0x26B2760", Offset = "0x26B1B60", Length = "0x17E")]
	[Token(Token = "0x600100D")]
	public override Uri get_ResponseUri() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001007")]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x26B2700", Offset = "0x26B1B00", Length = "0x27")]
	[Token(Token = "0x600100C")]
	public override Stream GetResponseStream() { }

	[Address(RVA = "0x25C7480", Offset = "0x25C6880", Length = "0x2A")]
	[Token(Token = "0x6001006")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

