namespace Steamworks;

[Token(Token = "0x20001B0")]
public static class SteamAPI
{

	[Address(RVA = "0x63A240", Offset = "0x639640", Length = "0x18")]
	[Token(Token = "0x600097F")]
	public static HSteamPipe GetHSteamPipe() { }

	[Address(RVA = "0x63A260", Offset = "0x639660", Length = "0x70")]
	[Token(Token = "0x6000980")]
	public static HSteamUser GetHSteamUser() { }

	[Address(RVA = "0x63AB20", Offset = "0x639F20", Length = "0x23")]
	[Token(Token = "0x6000979")]
	public static bool Init() { }

	[Address(RVA = "0x63A2D0", Offset = "0x6396D0", Length = "0x843")]
	[Token(Token = "0x6000978")]
	public static ESteamAPIInitResult InitEx(out string OutSteamErrMsg) { }

	[Address(RVA = "0x6357A0", Offset = "0x634BA0", Length = "0x6D")]
	[Token(Token = "0x600097E")]
	public static bool IsSteamRunning() { }

	[Address(RVA = "0x635C10", Offset = "0x635010", Length = "0x68")]
	[Token(Token = "0x600097C")]
	public static void ReleaseCurrentThreadMemory() { }

	[Address(RVA = "0x635C80", Offset = "0x635080", Length = "0x7B")]
	[Token(Token = "0x600097B")]
	public static bool RestartAppIfNecessary(AppId_t unOwnAppID) { }

	[Address(RVA = "0x63AB50", Offset = "0x639F50", Length = "0x42")]
	[Token(Token = "0x600097D")]
	public static void RunCallbacks() { }

	[Address(RVA = "0x63ABA0", Offset = "0x639FA0", Length = "0x2EA")]
	[Token(Token = "0x600097A")]
	public static void Shutdown() { }

}

