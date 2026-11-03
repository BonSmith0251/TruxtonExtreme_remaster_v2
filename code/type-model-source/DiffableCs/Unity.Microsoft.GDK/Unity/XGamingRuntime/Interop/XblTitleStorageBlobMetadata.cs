namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000346")]
internal struct XblTitleStorageBlobMetadata
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000972")]
	internal string blobPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000973")]
	internal XblTitleStorageBlobType blobType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000974")]
	internal XblTitleStorageType storageType; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000975")]
	internal string displayName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000976")]
	internal string eTag; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000977")]
	internal TimeT clientTimestamp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000978")]
	internal SizeT length; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000979")]
	internal string serviceConfigurationId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400097A")]
	internal ulong xboxUserId; //Field offset: 0x38

}

