namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000308")]
internal struct XblMultiplayerSessionQueryResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000882")]
	internal TimeT StartTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000883")]
	internal XblMultiplayerSessionReference SessionReference; //Field offset: 0x8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000884")]
	internal XblMultiplayerSessionStatus Status; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000885")]
	internal XblMultiplayerSessionVisibility Visibility; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000886")]
	internal bool IsMyTurn; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000887")]
	internal ulong Xuid; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000888")]
	internal uint AcceptedMemberCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000889")]
	internal XblMultiplayerSessionRestriction JoinRestriction; //Field offset: 0x114

}

