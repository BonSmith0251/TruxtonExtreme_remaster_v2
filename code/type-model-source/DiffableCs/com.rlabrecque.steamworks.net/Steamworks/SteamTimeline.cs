namespace Steamworks;

[Token(Token = "0x2000024")]
public static class SteamTimeline
{

	[Address(RVA = "0x5FF340", Offset = "0x5FE740", Length = "0x27E")]
	[Token(Token = "0x60003DD")]
	public static void AddTimelineEvent(string pchIcon, string pchTitle, string pchDescription, uint unPriority, float flStartOffsetSeconds, float flDurationSeconds, ETimelineEventClipPriority ePossibleClip) { }

	[Address(RVA = "0x5FF5C0", Offset = "0x5FE9C0", Length = "0x58")]
	[Token(Token = "0x60003DC")]
	public static void ClearTimelineStateDescription(float flTimeDelta) { }

	[Address(RVA = "0x5FF620", Offset = "0x5FEA20", Length = "0x4F")]
	[Token(Token = "0x60003DE")]
	public static void SetTimelineGameMode(ETimelineGameMode eMode) { }

	[Address(RVA = "0x5FF670", Offset = "0x5FEA70", Length = "0x115")]
	[Token(Token = "0x60003DB")]
	public static void SetTimelineStateDescription(string pchDescription, float flTimeDelta) { }

}

