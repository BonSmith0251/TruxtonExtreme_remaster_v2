namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200037F")]
internal struct XPersistentLocalStorageSpaceInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009EC")]
	internal ulong availableFreeBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009ED")]
	internal ulong totalFreeBytes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009EE")]
	internal ulong usedBytes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009EF")]
	internal ulong totalBytes; //Field offset: 0x18

}

