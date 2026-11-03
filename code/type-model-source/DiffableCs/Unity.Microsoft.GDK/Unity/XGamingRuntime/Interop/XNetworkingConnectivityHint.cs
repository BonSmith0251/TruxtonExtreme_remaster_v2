namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200036A")]
internal struct XNetworkingConnectivityHint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009BE")]
	internal XNetworkingConnectivityLevelHint connectivityLevel; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009BF")]
	internal XNetworkingConnectivityCostHint connectivityCost; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009C0")]
	internal uint ianaInterfaceType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009C1")]
	internal bool networkInitialized; //Field offset: 0xC
	[FieldOffset(Offset = "0xD")]
	[Token(Token = "0x40009C2")]
	internal bool approachingDataLimit; //Field offset: 0xD
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x40009C3")]
	internal bool overDataLimit; //Field offset: 0xE
	[FieldOffset(Offset = "0xF")]
	[Token(Token = "0x40009C4")]
	internal bool roaming; //Field offset: 0xF

}

