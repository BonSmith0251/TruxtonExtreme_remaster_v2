namespace System.Runtime.Remoting;

[Token(Token = "0x2000348")]
internal class EnvoyInfo : IEnvoyInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DD2")]
	private IMessageSink envoySinks; //Field offset: 0x10

	[Token(Token = "0x170002BD")]
	public override IMessageSink EnvoySinks
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001A78")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001A77")]
	public EnvoyInfo(IMessageSink sinks) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001A78")]
	public override IMessageSink get_EnvoySinks() { }

}

