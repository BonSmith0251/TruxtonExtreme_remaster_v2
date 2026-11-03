namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000199")]
public class XblMultiplayerPeerToHostRequirements
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003D1")]
	private readonly ulong <LatencyMaximum>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003D2")]
	private readonly ulong <BandwidthDownMinimumInKbps>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D3")]
	private readonly ulong <BandwidthUpMinimumInKbps>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D4")]
	private readonly XblMultiplayerMetrics <HostSelectionMetric>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000151")]
	public ulong BandwidthDownMinimumInKbps
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000152")]
	public ulong BandwidthUpMinimumInKbps
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000153")]
	public XblMultiplayerMetrics HostSelectionMetric
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008DF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000150")]
	public ulong LatencyMaximum
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008DC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B87A50", Offset = "0x2B86E50", Length = "0x3F")]
	[Token(Token = "0x60008DB")]
	internal XblMultiplayerPeerToHostRequirements(XblMultiplayerPeerToHostRequirements interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008DD")]
	public ulong get_BandwidthDownMinimumInKbps() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008DE")]
	public ulong get_BandwidthUpMinimumInKbps() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008DF")]
	public XblMultiplayerMetrics get_HostSelectionMetric() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008DC")]
	public ulong get_LatencyMaximum() { }

}

