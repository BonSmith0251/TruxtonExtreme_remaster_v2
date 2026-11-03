namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000340")]
internal struct XblSocialManagerUser
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000948")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000949")]
	internal readonly bool isFavorite; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400094A")]
	internal readonly bool isFollowingUser; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x400094B")]
	internal readonly bool isFollowedByCaller; //Field offset: 0xA
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400094C")]
	internal readonly Byte[] displayName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400094D")]
	internal readonly Byte[] realName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094E")]
	internal readonly Byte[] displayPicUrlRaw; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400094F")]
	internal readonly bool useAvatar; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000950")]
	internal readonly Byte[] gamerscore; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000951")]
	internal readonly Byte[] gamertag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000952")]
	internal readonly Byte[] modernGamertag; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000953")]
	internal readonly Byte[] modernGamertagSuffix; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000954")]
	internal readonly Byte[] uniqueModernGamertag; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000955")]
	internal readonly XblSocialManagerPresenceRecord presenceRecord; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000956")]
	internal readonly XblTitleHistory titleHistory; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000957")]
	internal readonly XblPreferredColor preferredColor; //Field offset: 0x80

}

