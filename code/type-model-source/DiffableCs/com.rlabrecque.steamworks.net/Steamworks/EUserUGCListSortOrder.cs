namespace Steamworks;

[Token(Token = "0x200013A")]
public enum EUserUGCListSortOrder : int
{
	k_EUserUGCListSortOrder_CreationOrderDesc = 0,
	k_EUserUGCListSortOrder_CreationOrderAsc = 1,
	k_EUserUGCListSortOrder_TitleAsc = 2,
	k_EUserUGCListSortOrder_LastUpdatedDesc = 3,
	k_EUserUGCListSortOrder_SubscriptionDateDesc = 4,
	k_EUserUGCListSortOrder_VoteScoreDesc = 5,
	k_EUserUGCListSortOrder_ForModeration = 6,
}

