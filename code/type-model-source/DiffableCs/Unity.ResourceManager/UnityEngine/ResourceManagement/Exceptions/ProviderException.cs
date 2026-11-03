namespace UnityEngine.ResourceManagement.Exceptions;

[Token(Token = "0x2000017")]
public class ProviderException : OperationException
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000052")]
	private readonly IResourceLocation <Location>k__BackingField; //Field offset: 0x90

	[Token(Token = "0x1700001B")]
	public IResourceLocation Location
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000B9")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2E46840", Offset = "0x2E45C40", Length = "0x8C")]
	[Token(Token = "0x60000B8")]
	public ProviderException(string message, IResourceLocation location = null, Exception innerException = null) { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000B9")]
	public IResourceLocation get_Location() { }

}

