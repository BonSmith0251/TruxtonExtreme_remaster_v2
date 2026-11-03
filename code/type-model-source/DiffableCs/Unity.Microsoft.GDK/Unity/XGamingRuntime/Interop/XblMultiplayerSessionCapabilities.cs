namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200031D")]
internal struct XblMultiplayerSessionCapabilities
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C1")]
	internal readonly NativeBool Connectivity; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x40008C2")]
	internal readonly NativeBool Team; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40008C3")]
	internal readonly NativeBool Arbitration; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x40008C4")]
	internal readonly NativeBool SuppressPresenceActivityCheck; //Field offset: 0x3
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40008C5")]
	internal readonly NativeBool Gameplay; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40008C6")]
	internal readonly NativeBool Large; //Field offset: 0x5
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x40008C7")]
	internal readonly NativeBool ConnectionRequiredForActiveMembers; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x40008C8")]
	internal readonly NativeBool UserAuthorizationStyle; //Field offset: 0x7
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008C9")]
	internal readonly NativeBool Crossplay; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x40008CA")]
	internal readonly NativeBool Searchable; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x40008CB")]
	internal readonly NativeBool HasOwners; //Field offset: 0xA

	[Address(RVA = "0x2BB6930", Offset = "0x2BB5D30", Length = "0x80")]
	[Token(Token = "0x6001182")]
	internal XblMultiplayerSessionCapabilities(XblMultiplayerSessionCapabilities publicObject) { }

}

