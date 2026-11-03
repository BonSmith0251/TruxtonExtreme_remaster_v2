namespace System.Runtime.Remoting.Channels;

[Token(Token = "0x2000384")]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
{
	[Token(Token = "0x4000E70")]
	private static object s_lock; //Field offset: 0x0

	[Token(Token = "0x17000303")]
	public override object ChannelData
	{
		[Address(RVA = "0x1F00D60", Offset = "0x1F00160", Length = "0xCA")]
		[Token(Token = "0x6001BEE")]
		 get { } //Length: 202
	}

	[Token(Token = "0x17000301")]
	public override string ChannelName
	{
		[Address(RVA = "0x1F00E30", Offset = "0x1F00230", Length = "0x2C")]
		[Token(Token = "0x6001BEC")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000302")]
	public override int ChannelPriority
	{
		[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
		[Token(Token = "0x6001BED")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1F00CE0", Offset = "0x1F000E0", Length = "0x73")]
	[Token(Token = "0x6001BF2")]
	private static CrossAppDomainChannel() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001BF1")]
	public CrossAppDomainChannel() { }

	[Address(RVA = "0x1F00A20", Offset = "0x1EFFE20", Length = "0x174")]
	[Token(Token = "0x6001BF0")]
	public override IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	[Address(RVA = "0x1F00D60", Offset = "0x1F00160", Length = "0xCA")]
	[Token(Token = "0x6001BEE")]
	public override object get_ChannelData() { }

	[Address(RVA = "0x1F00E30", Offset = "0x1F00230", Length = "0x2C")]
	[Token(Token = "0x6001BEC")]
	public override string get_ChannelName() { }

	[Address(RVA = "0x9E1890", Offset = "0x9E0C90", Length = "0x6")]
	[Token(Token = "0x6001BED")]
	public override int get_ChannelPriority() { }

	[Address(RVA = "0x1F00BA0", Offset = "0x1EFFFA0", Length = "0x13F")]
	[Token(Token = "0x6001BEB")]
	internal static void RegisterCrossAppDomainChannel() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001BEF")]
	public override void StartListening(object data) { }

}

