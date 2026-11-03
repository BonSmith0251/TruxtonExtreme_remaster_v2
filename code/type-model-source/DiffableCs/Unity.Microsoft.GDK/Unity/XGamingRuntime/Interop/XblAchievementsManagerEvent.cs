namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E2")]
internal struct XblAchievementsManagerEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DC")]
	internal XblAchievementProgressChangeEntry progressInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007DD")]
	internal ulong xboxUserId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007DE")]
	internal XblAchievementsManagerEventType eventType; //Field offset: 0x30

}

