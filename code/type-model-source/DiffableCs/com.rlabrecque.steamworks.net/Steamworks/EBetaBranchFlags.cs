namespace Steamworks;

[Flags]
[Token(Token = "0x200015F")]
public enum EBetaBranchFlags : int
{
	k_EBetaBranch_None = 0,
	k_EBetaBranch_Default = 1,
	k_EBetaBranch_Available = 2,
	k_EBetaBranch_Private = 4,
	k_EBetaBranch_Selected = 8,
	k_EBetaBranch_Installed = 16,
}

