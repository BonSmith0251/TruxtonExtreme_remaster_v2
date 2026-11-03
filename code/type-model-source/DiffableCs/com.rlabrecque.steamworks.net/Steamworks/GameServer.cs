namespace Steamworks;

[Token(Token = "0x20001B1")]
public static class GameServer
{

	[Address(RVA = "0x60A6F0", Offset = "0x609AF0", Length = "0x6D")]
	[Token(Token = "0x6000986")]
	public static bool BSecure() { }

	[Address(RVA = "0x60A760", Offset = "0x609B60", Length = "0x18")]
	[Token(Token = "0x6000988")]
	public static HSteamPipe GetHSteamPipe() { }

	[Address(RVA = "0x60A780", Offset = "0x609B80", Length = "0x70")]
	[Token(Token = "0x6000989")]
	public static HSteamUser GetHSteamUser() { }

	[Address(RVA = "0x60A7F0", Offset = "0x609BF0", Length = "0xA2")]
	[Token(Token = "0x6000987")]
	public static CSteamID GetSteamID() { }

	[Address(RVA = "0x60AE70", Offset = "0x60A270", Length = "0x36")]
	[Token(Token = "0x6000982")]
	public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString) { }

	[Address(RVA = "0x60A8A0", Offset = "0x609CA0", Length = "0x5C7")]
	[Token(Token = "0x6000981")]
	public static ESteamAPIInitResult InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString, out string OutSteamErrMsg) { }

	[Address(RVA = "0x60AEB0", Offset = "0x60A2B0", Length = "0x68")]
	[Token(Token = "0x6000985")]
	public static void ReleaseCurrentThreadMemory() { }

	[Address(RVA = "0x60AF20", Offset = "0x60A320", Length = "0x42")]
	[Token(Token = "0x6000984")]
	public static void RunCallbacks() { }

	[Address(RVA = "0x60AF70", Offset = "0x60A370", Length = "0x182")]
	[Token(Token = "0x6000983")]
	public static void Shutdown() { }

}

