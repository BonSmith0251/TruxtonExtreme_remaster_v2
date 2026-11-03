namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200031E")]
internal struct XblMultiplayerSessionConstants
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008CC")]
	internal readonly uint MaxMembersInSession; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40008CD")]
	internal readonly XblMultiplayerSessionVisibility Visibility; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008CE")]
	private readonly UInt64* InitiatorXuids; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008CF")]
	internal readonly SizeT InitiatorXuidsCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008D0")]
	internal readonly UTF8StringPtr CustomJson; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008D1")]
	internal readonly UTF8StringPtr SessionCloudComputePackageConstantsJson; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008D2")]
	internal readonly ulong MemberReservedTimeout; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008D3")]
	internal readonly ulong MemberInactiveTimeout; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008D4")]
	internal readonly ulong MemberReadyTimeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008D5")]
	internal readonly ulong SessionEmptyTimeout; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008D6")]
	internal readonly ulong ArbitrationTimeout; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008D7")]
	internal readonly ulong ForfeitTimeout; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008D8")]
	internal readonly NativeBool EnableMetricsLatency; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40008D9")]
	internal readonly NativeBool EnableMetricsBandwidthDown; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x40008DA")]
	internal readonly NativeBool EnableMetricsBandwidthUp; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5B")]
	[Token(Token = "0x40008DB")]
	internal readonly NativeBool EnableMetricsCustom; //Field offset: 0x5B
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008DC")]
	private readonly XblMultiplayerMemberInitialization* MemberInitialization; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008DD")]
	internal readonly XblMultiplayerPeerToPeerRequirements PeerToPeerRequirements; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008DE")]
	internal readonly XblMultiplayerPeerToHostRequirements PeerToHostRequirements; //Field offset: 0x78
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008DF")]
	internal readonly UTF8StringPtr MeasurementServerAddressesJson; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008E0")]
	internal readonly NativeBool ClientMatchmakingCapable; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x40008E1")]
	internal readonly XblMultiplayerSessionCapabilities SessionCapabilities; //Field offset: 0xA1

	[Address(RVA = "0x9E71D0", Offset = "0x9E65D0", Length = "0x58")]
	[Token(Token = "0x6001183")]
	internal T[] GetInitiatorXuids(Func<UInt64, T> ctor) { }

	[Address(RVA = "0x9E7230", Offset = "0x9E6630", Length = "0x54")]
	[Token(Token = "0x6001184")]
	internal T GetMemberInitialization(Func<XblMultiplayerMemberInitialization, T> ctor) { }

}

