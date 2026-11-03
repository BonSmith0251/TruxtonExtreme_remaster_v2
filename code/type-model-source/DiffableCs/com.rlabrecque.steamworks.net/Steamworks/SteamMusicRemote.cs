namespace Steamworks;

[Token(Token = "0x200001B")]
public static class SteamMusicRemote
{

	[Address(RVA = "0x5F6350", Offset = "0x5F5750", Length = "0x51")]
	[Token(Token = "0x6000306")]
	public static bool BActivationSuccess(bool bValue) { }

	[Address(RVA = "0x5F63B0", Offset = "0x5F57B0", Length = "0x47")]
	[Token(Token = "0x6000305")]
	public static bool BIsCurrentMusicRemote() { }

	[Address(RVA = "0x5F6400", Offset = "0x5F5800", Length = "0x47")]
	[Token(Token = "0x6000318")]
	public static bool CurrentEntryDidChange() { }

	[Address(RVA = "0x5F6450", Offset = "0x5F5850", Length = "0x51")]
	[Token(Token = "0x6000314")]
	public static bool CurrentEntryIsAvailable(bool bAvailable) { }

	[Address(RVA = "0x5F64B0", Offset = "0x5F58B0", Length = "0x47")]
	[Token(Token = "0x6000313")]
	public static bool CurrentEntryWillChange() { }

	[Address(RVA = "0x5F6500", Offset = "0x5F5900", Length = "0x47")]
	[Token(Token = "0x6000304")]
	public static bool DeregisterSteamMusicRemote() { }

	[Address(RVA = "0x5F6550", Offset = "0x5F5950", Length = "0x51")]
	[Token(Token = "0x600030C")]
	public static bool EnableLooped(bool bValue) { }

	[Address(RVA = "0x5F6670", Offset = "0x5F5A70", Length = "0x51")]
	[Token(Token = "0x600030E")]
	public static bool EnablePlaylists(bool bValue) { }

	[Address(RVA = "0x5F65B0", Offset = "0x5F59B0", Length = "0x51")]
	[Token(Token = "0x600030A")]
	public static bool EnablePlayNext(bool bValue) { }

	[Address(RVA = "0x5F6610", Offset = "0x5F5A10", Length = "0x51")]
	[Token(Token = "0x6000309")]
	public static bool EnablePlayPrevious(bool bValue) { }

	[Address(RVA = "0x5F66D0", Offset = "0x5F5AD0", Length = "0x51")]
	[Token(Token = "0x600030D")]
	public static bool EnableQueue(bool bValue) { }

	[Address(RVA = "0x5F6730", Offset = "0x5F5B30", Length = "0x51")]
	[Token(Token = "0x600030B")]
	public static bool EnableShuffled(bool bValue) { }

	[Address(RVA = "0x5F6790", Offset = "0x5F5B90", Length = "0x47")]
	[Token(Token = "0x6000322")]
	public static bool PlaylistDidChange() { }

	[Address(RVA = "0x5F67E0", Offset = "0x5F5BE0", Length = "0x47")]
	[Token(Token = "0x600031E")]
	public static bool PlaylistWillChange() { }

	[Address(RVA = "0x5F6830", Offset = "0x5F5C30", Length = "0x47")]
	[Token(Token = "0x600031D")]
	public static bool QueueDidChange() { }

	[Address(RVA = "0x5F6880", Offset = "0x5F5C80", Length = "0x47")]
	[Token(Token = "0x6000319")]
	public static bool QueueWillChange() { }

	[Address(RVA = "0x5F68D0", Offset = "0x5F5CD0", Length = "0x118")]
	[Token(Token = "0x6000303")]
	public static bool RegisterSteamMusicRemote(string pchName) { }

	[Address(RVA = "0x5F69F0", Offset = "0x5F5DF0", Length = "0x47")]
	[Token(Token = "0x600031F")]
	public static bool ResetPlaylistEntries() { }

	[Address(RVA = "0x5F6A40", Offset = "0x5F5E40", Length = "0x47")]
	[Token(Token = "0x600031A")]
	public static bool ResetQueueEntries() { }

	[Address(RVA = "0x5F6A90", Offset = "0x5F5E90", Length = "0x4F")]
	[Token(Token = "0x6000321")]
	public static bool SetCurrentPlaylistEntry(int nID) { }

	[Address(RVA = "0x5F6AE0", Offset = "0x5F5EE0", Length = "0x4F")]
	[Token(Token = "0x600031C")]
	public static bool SetCurrentQueueEntry(int nID) { }

	[Address(RVA = "0x5F6B30", Offset = "0x5F5F30", Length = "0x118")]
	[Token(Token = "0x6000307")]
	public static bool SetDisplayName(string pchDisplayName) { }

	[Address(RVA = "0x5F6CB0", Offset = "0x5F60B0", Length = "0x13F")]
	[Token(Token = "0x6000320")]
	public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText) { }

	[Address(RVA = "0x5F6C50", Offset = "0x5F6050", Length = "0x5F")]
	[Token(Token = "0x6000308")]
	public static bool SetPNGIcon_64x64(Byte[] pvBuffer, uint cbBufferLength) { }

	[Address(RVA = "0x5F6DF0", Offset = "0x5F61F0", Length = "0x13F")]
	[Token(Token = "0x600031B")]
	public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText) { }

	[Address(RVA = "0x5F6F30", Offset = "0x5F6330", Length = "0x5F")]
	[Token(Token = "0x6000317")]
	public static bool UpdateCurrentEntryCoverArt(Byte[] pvBuffer, uint cbBufferLength) { }

	[Address(RVA = "0x5F6F90", Offset = "0x5F6390", Length = "0x4F")]
	[Token(Token = "0x6000316")]
	public static bool UpdateCurrentEntryElapsedSeconds(int nValue) { }

	[Address(RVA = "0x5F6FE0", Offset = "0x5F63E0", Length = "0x118")]
	[Token(Token = "0x6000315")]
	public static bool UpdateCurrentEntryText(string pchText) { }

	[Address(RVA = "0x5F7100", Offset = "0x5F6500", Length = "0x51")]
	[Token(Token = "0x6000311")]
	public static bool UpdateLooped(bool bValue) { }

	[Address(RVA = "0x5F7160", Offset = "0x5F6560", Length = "0x4F")]
	[Token(Token = "0x600030F")]
	public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) { }

	[Address(RVA = "0x5F71B0", Offset = "0x5F65B0", Length = "0x51")]
	[Token(Token = "0x6000310")]
	public static bool UpdateShuffled(bool bValue) { }

	[Address(RVA = "0x5F7210", Offset = "0x5F6610", Length = "0x58")]
	[Token(Token = "0x6000312")]
	public static bool UpdateVolume(float flValue) { }

}

