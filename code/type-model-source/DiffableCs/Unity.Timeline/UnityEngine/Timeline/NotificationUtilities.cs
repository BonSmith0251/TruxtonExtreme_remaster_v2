namespace UnityEngine.Timeline;

[Token(Token = "0x2000079")]
internal static class NotificationUtilities
{

	[Address(RVA = "0x2F418F0", Offset = "0x2F40CF0", Length = "0x40")]
	[Token(Token = "0x6000362")]
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, PlayableDirector director) { }

	[Address(RVA = "0x2F418B0", Offset = "0x2F40CB0", Length = "0x3B")]
	[Token(Token = "0x6000363")]
	public static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, TimelineAsset timelineAsset) { }

	[Address(RVA = "0x2F41260", Offset = "0x2F40660", Length = "0x64F")]
	[Token(Token = "0x6000364")]
	private static ScriptPlayable<TimeNotificationBehaviour> CreateNotificationsPlayable(PlayableGraph graph, IEnumerable<IMarker> markers, IPlayableAsset asset, PlayableDirector director) { }

	[Address(RVA = "0x2F41930", Offset = "0x2F40D30", Length = "0x189")]
	[Token(Token = "0x6000365")]
	public static bool TrackTypeSupportsNotifications(Type type) { }

}

