namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001DF")]
public enum XblSocialManagerEventType : uint
{
	UsersAddedToSocialGraph = 0,
	UsersRemovedFromSocialGraph = 1,
	PresenceChanged = 2,
	ProfilesChanged = 3,
	SocialRelationshipsChanged = 4,
	LocalUserAdded = 5,
	SocialUserGroupLoaded = 6,
	SocialUserGroupUpdated = 7,
	UnknownEvent = 8,
}

