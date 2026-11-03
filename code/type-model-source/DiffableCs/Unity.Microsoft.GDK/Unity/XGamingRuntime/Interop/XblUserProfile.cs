namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000332")]
internal struct XblUserProfile
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000915")]
	internal readonly ulong xboxUserId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000916")]
	internal Byte[] appDisplayName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000917")]
	internal Byte[] appDisplayPictureResizeUri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000918")]
	internal Byte[] gameDisplayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000919")]
	internal Byte[] gameDisplayPictureResizeUri; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400091A")]
	internal Byte[] gamerscore; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400091B")]
	internal Byte[] gamertag; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400091C")]
	internal Byte[] modernGamertag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400091D")]
	internal Byte[] modernGamertagSuffix; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400091E")]
	internal Byte[] uniqueModernGamertag; //Field offset: 0x48

}

