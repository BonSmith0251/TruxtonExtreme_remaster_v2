namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D5")]
internal struct XblAchievementProgressChangeEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007AB")]
	internal readonly IntPtr updatedAchievementEntries; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007AC")]
	internal readonly uint entryCount; //Field offset: 0x8

}

