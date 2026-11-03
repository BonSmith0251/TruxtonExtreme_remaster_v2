namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000319")]
internal struct XblMultiplayerPeerToHostRequirements
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008B7")]
	internal readonly ulong LatencyMaximum; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008B8")]
	internal readonly ulong BandwidthDownMinimumInKbps; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008B9")]
	internal readonly ulong BandwidthUpMinimumInKbps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008BA")]
	internal readonly XblMultiplayerMetrics HostSelectionMetric; //Field offset: 0x18

	[Address(RVA = "0x2BB6760", Offset = "0x2BB5B60", Length = "0x30")]
	[Token(Token = "0x600117B")]
	internal XblMultiplayerPeerToHostRequirements(XblMultiplayerPeerToHostRequirements publicObject) { }

}

