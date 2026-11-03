namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000359")]
internal struct XGameSaveContainerInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000997")]
	internal string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000998")]
	internal string displayName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000999")]
	internal uint blobCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400099A")]
	internal ulong totalSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400099B")]
	internal long lastModifiedTime; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400099C")]
	internal bool needsSync; //Field offset: 0x28

}

