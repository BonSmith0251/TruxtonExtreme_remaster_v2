namespace Steamworks;

[Flags]
[Token(Token = "0x200012B")]
public enum ERemoteStoragePlatform : int
{
	k_ERemoteStoragePlatformNone = 0,
	k_ERemoteStoragePlatformWindows = 1,
	k_ERemoteStoragePlatformOSX = 2,
	k_ERemoteStoragePlatformPS3 = 4,
	k_ERemoteStoragePlatformLinux = 8,
	k_ERemoteStoragePlatformSwitch = 16,
	k_ERemoteStoragePlatformAndroid = 32,
	k_ERemoteStoragePlatformIOS = 64,
	k_ERemoteStoragePlatformAll = -1,
}

