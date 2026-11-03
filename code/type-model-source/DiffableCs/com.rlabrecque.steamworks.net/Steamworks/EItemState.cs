namespace Steamworks;

[Flags]
[Token(Token = "0x200013D")]
public enum EItemState : int
{
	k_EItemStateNone = 0,
	k_EItemStateSubscribed = 1,
	k_EItemStateLegacyItem = 2,
	k_EItemStateInstalled = 4,
	k_EItemStateNeedsUpdate = 8,
	k_EItemStateDownloading = 16,
	k_EItemStateDownloadPending = 32,
	k_EItemStateDisabledLocally = 64,
}

