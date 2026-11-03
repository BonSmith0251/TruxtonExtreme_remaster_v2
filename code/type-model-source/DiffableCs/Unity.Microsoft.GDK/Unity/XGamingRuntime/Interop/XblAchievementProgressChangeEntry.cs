namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D4")]
internal struct XblAchievementProgressChangeEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007A8")]
	internal UTF8StringPtr achievementId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007A9")]
	internal XblAchievementProgressState progressState; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007AA")]
	internal XblAchievementProgression progression; //Field offset: 0x10

}

