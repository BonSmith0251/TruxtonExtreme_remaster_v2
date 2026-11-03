namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002F3")]
internal struct XblMultiplayerActivityDetails
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000817")]
	internal XblMultiplayerSessionReference SessionReference; //Field offset: 0x0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000818")]
	internal Byte[] HandleId; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000819")]
	internal uint TitleId; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x400081A")]
	internal XblMultiplayerSessionVisibility Visibility; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400081B")]
	internal XblMultiplayerSessionRestriction JoinRestriction; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400081C")]
	internal bool Closed; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400081D")]
	internal ulong OwnerXuid; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400081E")]
	internal uint MaxMembersCount; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x400081F")]
	internal uint MembersCount; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000820")]
	internal UTF8StringPtr CustomSessionPropertiesJson; //Field offset: 0x118

	[Address(RVA = "0x2BB6370", Offset = "0x2BB5770", Length = "0x45")]
	[Token(Token = "0x600114D")]
	internal string GetHandleId() { }

}

