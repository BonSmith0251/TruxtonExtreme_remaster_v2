namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000317")]
internal struct XblMultiplayerManagerMember
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008A6")]
	internal readonly uint MemberId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008A7")]
	internal readonly UTF8StringPtr TeamId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A8")]
	internal readonly UTF8StringPtr InitialTeam; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008A9")]
	internal readonly ulong Xuid; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008AA")]
	internal readonly UTF8StringPtr DebugGamertag; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008AB")]
	internal readonly NativeBool IsLocal; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40008AC")]
	internal readonly NativeBool IsInLobby; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40008AD")]
	internal readonly NativeBool IsInGame; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40008AE")]
	internal readonly XblMultiplayerSessionMemberStatus Status; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008AF")]
	internal readonly UTF8StringPtr ConnectionAddress; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008B0")]
	internal readonly UTF8StringPtr PropertiesJson; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008B1")]
	internal readonly UTF8StringPtr DeviceToken; //Field offset: 0x40

	[Address(RVA = "0x2BB65E0", Offset = "0x2BB59E0", Length = "0x13C")]
	[Token(Token = "0x6001179")]
	internal XblMultiplayerManagerMember(XblMultiplayerManagerMember publicObject, DisposableCollection disposableCollection) { }

}

