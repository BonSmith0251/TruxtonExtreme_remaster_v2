namespace UnityEngine.ResourceManagement.Exceptions;

[Token(Token = "0x2000018")]
public class RemoteProviderException : ProviderException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000053")]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x1700001C")]
	public virtual string Message
	{
		[Address(RVA = "0x1FCFE00", Offset = "0x1FCF200", Length = "0x14")]
		[Token(Token = "0x60000BB")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700001D")]
	public UnityWebRequestResult WebRequestResult
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2E48520", Offset = "0x2E47920", Length = "0xA4")]
	[Token(Token = "0x60000BA")]
	public RemoteProviderException(string message, IResourceLocation location = null, UnityWebRequestResult uwrResult = null, Exception innerException = null) { }

	[Address(RVA = "0x1FCFE00", Offset = "0x1FCF200", Length = "0x14")]
	[Token(Token = "0x60000BB")]
	public virtual string get_Message() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000BC")]
	public UnityWebRequestResult get_WebRequestResult() { }

	[Address(RVA = "0x2E482B0", Offset = "0x2E476B0", Length = "0x26D")]
	[Token(Token = "0x60000BD")]
	public virtual string ToString() { }

}

