namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002D7")]
internal struct XblAchievementRequirement
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007B0")]
	internal readonly UTF8StringPtr id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007B1")]
	internal readonly UTF8StringPtr currentProgressValue; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B2")]
	internal readonly UTF8StringPtr targetProgressValue; //Field offset: 0x10

}

