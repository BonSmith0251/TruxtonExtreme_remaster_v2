namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x200004E")]
public static class TrackAssetExtensions
{

	[Address(RVA = "0x2F37BD0", Offset = "0x2F36FD0", Length = "0x44")]
	[Extension]
	[Token(Token = "0x60002BB")]
	internal static void ComputeBlendsFromOverlaps(TrackAsset asset, bool force = false) { }

	[Address(RVA = "0x2F37C20", Offset = "0x2F37020", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x60002B9")]
	public static GroupTrack GetGroup(TrackAsset asset) { }

	[Address(RVA = "0x2F37CE0", Offset = "0x2F370E0", Length = "0x357")]
	[Extension]
	[Token(Token = "0x60002BA")]
	public static void SetGroup(TrackAsset asset, GroupTrack group) { }

}

