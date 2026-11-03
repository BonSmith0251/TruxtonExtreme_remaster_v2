namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002E1")]
internal struct XblAchievementTitleAssociation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DA")]
	internal readonly UTF8StringPtr name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007DB")]
	internal readonly uint titleId; //Field offset: 0x8

}

