namespace UnityEngine.ResourceManagement.Exceptions;

[Token(Token = "0x2000015")]
public class UnknownResourceProviderException : ResourceManagerException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000051")]
	private IResourceLocation <Location>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x17000019")]
	public private IResourceLocation Location
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000AE")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700001A")]
	public virtual string Message
	{
		[Address(RVA = "0x2E513E0", Offset = "0x2E507E0", Length = "0x155")]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 341
	}

	[Address(RVA = "0x2E51370", Offset = "0x2E50770", Length = "0x6B")]
	[Token(Token = "0x60000AF")]
	public UnknownResourceProviderException(IResourceLocation location) { }

	[Address(RVA = "0x2E493D0", Offset = "0x2E487D0", Length = "0x49")]
	[Token(Token = "0x60000B0")]
	public UnknownResourceProviderException() { }

	[Address(RVA = "0x2E494A0", Offset = "0x2E488A0", Length = "0x59")]
	[Token(Token = "0x60000B1")]
	public UnknownResourceProviderException(string message) { }

	[Address(RVA = "0x2E49500", Offset = "0x2E48900", Length = "0x69")]
	[Token(Token = "0x60000B2")]
	public UnknownResourceProviderException(string message, Exception innerException) { }

	[Address(RVA = "0x2E49420", Offset = "0x2E48820", Length = "0x74")]
	[Token(Token = "0x60000B3")]
	protected UnknownResourceProviderException(SerializationInfo message, StreamingContext context) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000AD")]
	public IResourceLocation get_Location() { }

	[Address(RVA = "0x2E513E0", Offset = "0x2E507E0", Length = "0x155")]
	[Token(Token = "0x60000B4")]
	public virtual string get_Message() { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000AE")]
	private void set_Location(IResourceLocation value) { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x60000B5")]
	public virtual string ToString() { }

}

