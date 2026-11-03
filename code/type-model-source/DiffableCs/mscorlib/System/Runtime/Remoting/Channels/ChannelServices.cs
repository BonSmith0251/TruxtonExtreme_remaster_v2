namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
[Token(Token = "0x2000382")]
public sealed class ChannelServices
{
	[Token(Token = "0x4000E68")]
	private static ArrayList registeredChannels; //Field offset: 0x0
	[Token(Token = "0x4000E69")]
	private static ArrayList delayedClientChannels; //Field offset: 0x8
	[Token(Token = "0x4000E6A")]
	private static CrossContextChannel _crossContextSink; //Field offset: 0x10
	[Token(Token = "0x4000E6B")]
	internal static string CrossContextUrl; //Field offset: 0x18
	[Token(Token = "0x4000E6C")]
	private static IList oldStartModeTypes; //Field offset: 0x20

	[Token(Token = "0x170002FE")]
	internal static CrossContextChannel CrossContextChannel
	{
		[Address(RVA = "0x1EFEC60", Offset = "0x1EFE060", Length = "0x4F")]
		[Token(Token = "0x6001BDB")]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x1EFEA60", Offset = "0x1EFDE60", Length = "0x1F4")]
	[Token(Token = "0x6001BE7")]
	private static ChannelServices() { }

	[Address(RVA = "0x1EFC370", Offset = "0x1EFB770", Length = "0x1F2")]
	[Token(Token = "0x6001BE3")]
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	[Address(RVA = "0x1EFC570", Offset = "0x1EFB970", Length = "0x16B")]
	[Token(Token = "0x6001BE4")]
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	[Address(RVA = "0x1EFC800", Offset = "0x1EFBC00", Length = "0x5CA")]
	[Token(Token = "0x6001BDC")]
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	[Address(RVA = "0x1EFC6E0", Offset = "0x1EFBAE0", Length = "0x11B")]
	[Token(Token = "0x6001BDD")]
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Object[] channelDataArray, out string objectUri) { }

	[Address(RVA = "0x1EFCDD0", Offset = "0x1EFC1D0", Length = "0x324")]
	[Token(Token = "0x6001BE1")]
	private static object CreateProvider(ProviderData prov) { }

	[Address(RVA = "0x1EFEC60", Offset = "0x1EFE060", Length = "0x4F")]
	[Token(Token = "0x6001BDB")]
	internal static CrossContextChannel get_CrossContextChannel() { }

	[Address(RVA = "0x1EFD100", Offset = "0x1EFC500", Length = "0x38B")]
	[Token(Token = "0x6001BE6")]
	internal static Object[] GetCurrentChannelInfo() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001BE5")]
	private static bool IsLocalCall(IMessage callMsg) { }

	[Address(RVA = "0x1EFE940", Offset = "0x1EFDD40", Length = "0x4C")]
	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	[Token(Token = "0x6001BDE")]
	public static void RegisterChannel(IChannel chnl) { }

	[Address(RVA = "0x1EFE310", Offset = "0x1EFD710", Length = "0x62E")]
	[Token(Token = "0x6001BDF")]
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	[Address(RVA = "0x1EFD490", Offset = "0x1EFC890", Length = "0xE71")]
	[Token(Token = "0x6001BE0")]
	internal static void RegisterChannelConfig(ChannelData channel) { }

	[Address(RVA = "0x1EFE990", Offset = "0x1EFDD90", Length = "0xC0")]
	[Token(Token = "0x6001BE2")]
	public static IMessage SyncDispatchMessage(IMessage msg) { }

}

