namespace Steamworks;

[Token(Token = "0x200001A")]
public static class SteamMusic
{

	[Address(RVA = "0x5F7270", Offset = "0x5F6670", Length = "0x44")]
	[Token(Token = "0x60002FA")]
	public static bool BIsEnabled() { }

	[Address(RVA = "0x5F72C0", Offset = "0x5F66C0", Length = "0x44")]
	[Token(Token = "0x60002FB")]
	public static bool BIsPlaying() { }

	[Address(RVA = "0x5F7310", Offset = "0x5F6710", Length = "0x44")]
	[Token(Token = "0x60002FC")]
	public static AudioPlayback_Status GetPlaybackStatus() { }

	[Address(RVA = "0x5F7360", Offset = "0x5F6760", Length = "0x44")]
	[Token(Token = "0x6000302")]
	public static float GetVolume() { }

	[Address(RVA = "0x5F73B0", Offset = "0x5F67B0", Length = "0x44")]
	[Token(Token = "0x60002FE")]
	public static void Pause() { }

	[Address(RVA = "0x5F74A0", Offset = "0x5F68A0", Length = "0x44")]
	[Token(Token = "0x60002FD")]
	public static void Play() { }

	[Address(RVA = "0x5F7400", Offset = "0x5F6800", Length = "0x44")]
	[Token(Token = "0x6000300")]
	public static void PlayNext() { }

	[Address(RVA = "0x5F7450", Offset = "0x5F6850", Length = "0x44")]
	[Token(Token = "0x60002FF")]
	public static void PlayPrevious() { }

	[Address(RVA = "0x5F74F0", Offset = "0x5F68F0", Length = "0x55")]
	[Token(Token = "0x6000301")]
	public static void SetVolume(float flVolume) { }

}

