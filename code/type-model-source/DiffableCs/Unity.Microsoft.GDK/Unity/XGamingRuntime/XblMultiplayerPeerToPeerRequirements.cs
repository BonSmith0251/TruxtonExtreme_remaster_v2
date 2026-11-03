namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200019A")]
public class XblMultiplayerPeerToPeerRequirements
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D5")]
	private readonly ulong <LatencyMaximum>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003D6")]
	private readonly ulong <BandwidthMinimumInKbps>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000155")]
	public ulong BandwidthMinimumInKbps
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000154")]
	public ulong LatencyMaximum
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008E1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2AA03E0", Offset = "0x2A9F7E0", Length = "0x31")]
	[Token(Token = "0x60008E0")]
	internal XblMultiplayerPeerToPeerRequirements(XblMultiplayerPeerToPeerRequirements interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E2")]
	public ulong get_BandwidthMinimumInKbps() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008E1")]
	public ulong get_LatencyMaximum() { }

}

