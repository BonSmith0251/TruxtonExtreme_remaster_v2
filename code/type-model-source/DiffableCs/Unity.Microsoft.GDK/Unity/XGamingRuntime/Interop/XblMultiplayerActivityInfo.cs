namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200030E")]
internal struct XblMultiplayerActivityInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000890")]
	internal readonly ulong xuid; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000891")]
	internal readonly UTF8StringPtr connectionString; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000892")]
	internal readonly XblMultiplayerActivityJoinRestriction joinRestriction; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000893")]
	internal readonly SizeT maxPlayers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000894")]
	internal readonly SizeT currentPlayers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000895")]
	internal readonly UTF8StringPtr groupId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000896")]
	internal readonly XblMultiplayerActivityPlatform platform; //Field offset: 0x30

	[Address(RVA = "0x2BB63C0", Offset = "0x2BB57C0", Length = "0x148")]
	[Token(Token = "0x6001172")]
	internal XblMultiplayerActivityInfo(XblMultiplayerActivityInfo publicObject, DisposableCollection disposableCollection) { }

}

