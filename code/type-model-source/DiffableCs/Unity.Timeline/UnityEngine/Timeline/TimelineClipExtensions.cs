namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x200007A")]
public static class TimelineClipExtensions
{
	[Token(Token = "0x4000187")]
	private static readonly string k_UndoSetParentTrackText; //Field offset: 0x0

	[Address(RVA = "0x2F46B80", Offset = "0x2F45F80", Length = "0x62")]
	[Token(Token = "0x6000369")]
	private static TimelineClipExtensions() { }

	[Address(RVA = "0x2F465B0", Offset = "0x2F459B0", Length = "0x3EA")]
	[Extension]
	[Token(Token = "0x6000366")]
	public static void MoveToTrack(TimelineClip clip, TrackAsset destinationTrack) { }

	[Address(RVA = "0x2F46430", Offset = "0x2F45830", Length = "0x173")]
	[Token(Token = "0x6000368")]
	private static void MoveToTrack_Impl(TimelineClip clip, TrackAsset destinationTrack, object asset, TrackAsset parentTrack) { }

	[Address(RVA = "0x2F469A0", Offset = "0x2F45DA0", Length = "0x1DD")]
	[Extension]
	[Token(Token = "0x6000367")]
	public static bool TryMoveToTrack(TimelineClip clip, TrackAsset destinationTrack) { }

}

