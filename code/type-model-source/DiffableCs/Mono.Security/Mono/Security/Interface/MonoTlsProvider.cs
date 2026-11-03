namespace Mono.Security.Interface;

[Token(Token = "0x2000042")]
public abstract class MonoTlsProvider
{

	[Token(Token = "0x17000065")]
	public abstract Guid ID
	{
		[Token(Token = "0x6000153")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000066")]
	public abstract string Name
	{
		[Token(Token = "0x6000154")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700006A")]
	public abstract SslProtocols SupportedProtocols
	{
		[Token(Token = "0x6000158")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700006B")]
	internal abstract bool SupportsCleanShutdown
	{
		[Token(Token = "0x6000159")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000068")]
	public abstract bool SupportsConnectionInfo
	{
		[Token(Token = "0x6000156")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000069")]
	public abstract bool SupportsMonoExtensions
	{
		[Token(Token = "0x6000157")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000067")]
	public abstract bool SupportsSslStream
	{
		[Token(Token = "0x6000155")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000152")]
	internal MonoTlsProvider() { }

	[Token(Token = "0x6000153")]
	public abstract Guid get_ID() { }

	[Token(Token = "0x6000154")]
	public abstract string get_Name() { }

	[Token(Token = "0x6000158")]
	public abstract SslProtocols get_SupportedProtocols() { }

	[Token(Token = "0x6000159")]
	internal abstract bool get_SupportsCleanShutdown() { }

	[Token(Token = "0x6000156")]
	public abstract bool get_SupportsConnectionInfo() { }

	[Token(Token = "0x6000157")]
	public abstract bool get_SupportsMonoExtensions() { }

	[Token(Token = "0x6000155")]
	public abstract bool get_SupportsSslStream() { }

}

