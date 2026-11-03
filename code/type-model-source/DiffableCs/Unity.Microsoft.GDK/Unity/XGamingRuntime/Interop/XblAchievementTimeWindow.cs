namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E0")]
internal struct XblAchievementTimeWindow
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007D8")]
	internal readonly TimeT startDate; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007D9")]
	internal readonly TimeT endDate; //Field offset: 0x8

}

