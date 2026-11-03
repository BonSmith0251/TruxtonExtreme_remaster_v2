namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200031A")]
internal struct XblMultiplayerPeerToPeerRequirements
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008BB")]
	internal readonly ulong LatencyMaximum; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008BC")]
	internal readonly ulong BandwidthMinimumInKbps; //Field offset: 0x8

	[Address(RVA = "0x2BB67A0", Offset = "0x2BB5BA0", Length = "0x22")]
	[Token(Token = "0x600117C")]
	internal XblMultiplayerPeerToPeerRequirements(XblMultiplayerPeerToPeerRequirements publicObject) { }

}

