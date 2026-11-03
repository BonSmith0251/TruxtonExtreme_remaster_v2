namespace System.Runtime.Remoting;

[Token(Token = "0x2000344")]
internal class ChannelInfo : IChannelInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DCA")]
	private Object[] channelData; //Field offset: 0x10

	[Token(Token = "0x170002B8")]
	public override Object[] ChannelData
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001A6E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1ED7C40", Offset = "0x1ED7040", Length = "0x60")]
	[Token(Token = "0x6001A6C")]
	public ChannelInfo() { }

	[Address(RVA = "0x1ED7CA0", Offset = "0x1ED70A0", Length = "0xBD")]
	[Token(Token = "0x6001A6D")]
	public ChannelInfo(object remoteChannelData) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001A6E")]
	public override Object[] get_ChannelData() { }

}

