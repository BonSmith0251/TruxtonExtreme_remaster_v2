namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001C8")]
public enum XblPrivilege : uint
{
	Unknown = 0,
	AllowIngameVoiceCommunications = 205,
	AllowVideoCommunications = 235,
	AllowProfileViewing = 249,
	AllowCommunications = 252,
	AllowMultiplayer = 254,
	AllowAddFriend = 255,
}

