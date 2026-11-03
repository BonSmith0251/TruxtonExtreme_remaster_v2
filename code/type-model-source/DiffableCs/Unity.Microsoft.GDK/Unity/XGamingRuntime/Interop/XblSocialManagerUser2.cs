namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000341")]
internal struct XblSocialManagerUser2
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000958")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000959")]
	internal readonly bool isFavorite; //Field offset: 0x8
	[FieldOffset(Offset = "0x9")]
	[Token(Token = "0x400095A")]
	internal readonly bool isFriend; //Field offset: 0x9
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x400095B")]
	internal readonly bool isFollowingUser; //Field offset: 0xA
	[FieldOffset(Offset = "0xB")]
	[Token(Token = "0x400095C")]
	internal readonly bool isFollowedByCaller; //Field offset: 0xB
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400095D")]
	internal readonly Byte[] displayName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400095E")]
	internal readonly Byte[] realName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400095F")]
	internal readonly Byte[] displayPicUrlRaw; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000960")]
	internal readonly bool useAvatar; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000961")]
	internal readonly Byte[] gamerscore; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000962")]
	internal readonly Byte[] gamertag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000963")]
	internal readonly Byte[] modernGamertag; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000964")]
	internal readonly Byte[] modernGamertagSuffix; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000965")]
	internal readonly Byte[] uniqueModernGamertag; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000966")]
	internal readonly XblSocialManagerPresenceRecord presenceRecord; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000967")]
	internal readonly XblTitleHistory titleHistory; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000968")]
	internal readonly XblPreferredColor preferredColor; //Field offset: 0x80

}

