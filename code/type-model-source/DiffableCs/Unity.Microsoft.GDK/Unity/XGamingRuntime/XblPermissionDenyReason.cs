namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001C1")]
public enum XblPermissionDenyReason : uint
{
	Unknown = 0,
	NotAllowed = 2,
	MissingPrivilege = 3,
	PrivilegeRestrictsTarget = 4,
	BlockListRestrictsTarget = 5,
	MuteListRestrictsTarget = 7,
	PrivacySettingsRestrictsTarget = 9,
}

