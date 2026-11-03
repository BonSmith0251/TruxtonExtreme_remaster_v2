namespace UnityEngine.Timeline;

[Token(Token = "0x2000070")]
public class TimelinePlayable : PlayableBehaviour
{
	[IsReadOnly]
	[Token(Token = "0x2000071")]
	private struct TrackCacheManager : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000181")]
		public readonly HashSet<AnimationTrack> trackCache; //Field offset: 0x0

		[Address(RVA = "0x2F4A430", Offset = "0x2F49830", Length = "0x30")]
		[Token(Token = "0x600033E")]
		public TrackCacheManager(HashSet<AnimationTrack> cache, IReadOnlyList<RuntimeElement> activeRuntimeElements) { }

		[Address(RVA = "0x2F4A1B0", Offset = "0x2F495B0", Length = "0x43")]
		[Token(Token = "0x600033F")]
		public override void Dispose() { }

		[Address(RVA = "0x2F4A200", Offset = "0x2F49600", Length = "0x22B")]
		[Token(Token = "0x6000340")]
		private void GetTrackAssetsFromRuntimeElements(IReadOnlyList<RuntimeElement> activeRuntimeElements) { }

	}

	[Token(Token = "0x4000171")]
	private static ProfilerMarker k_CreateTimelineGraphMarker; //Field offset: 0x0
	[Token(Token = "0x4000172")]
	private static ProfilerMarker k_CreateTimelineTrackMarker; //Field offset: 0x8
	[Token(Token = "0x4000173")]
	private static ProfilerMarker k_CreateTimelineTrackOutputsMarker; //Field offset: 0x10
	[Token(Token = "0x4000174")]
	private static ProfilerMarker m_findActiveClipsMarker; //Field offset: 0x18
	[Token(Token = "0x4000175")]
	private static ProfilerMarker m_SetClipsLocalTimeMarker; //Field offset: 0x20
	[Token(Token = "0x400017B")]
	internal static bool muteAudioScrubbing; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000176")]
	private IntervalTree<RuntimeElement> m_IntervalTree; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000177")]
	private List<RuntimeElement> m_ActiveClips; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000178")]
	private List<RuntimeElement> m_CurrentListOfActiveClips; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000179")]
	private int m_ActiveBit; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400017A")]
	private Dictionary<TrackAsset, Playable> m_PlayableCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017C")]
	private readonly Dictionary<AnimationTrack, List`1<ITimelineEvaluateCallback>> m_EvaluateCallbacks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017D")]
	private readonly List<ITimelineEvaluateCallback> m_AlwaysEvaluateCallbacks; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400017E")]
	private readonly HashSet<ITimelineEvaluateCallback> m_ForceEvaluateNextEvaluate; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400017F")]
	private readonly HashSet<ITimelineEvaluateCallback> m_InvokedThisFrame; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000180")]
	private readonly HashSet<AnimationTrack> m_ActiveTracksToEvaluateCache; //Field offset: 0x58

	[Address(RVA = "0x2F49CA0", Offset = "0x2F490A0", Length = "0x1C0")]
	[Token(Token = "0x600033D")]
	private static TimelinePlayable() { }

	[Address(RVA = "0x2F49E60", Offset = "0x2F49260", Length = "0x24D")]
	[Token(Token = "0x600033C")]
	public TimelinePlayable() { }

	[Address(RVA = "0x2F47520", Offset = "0x2F46920", Length = "0x175")]
	[Token(Token = "0x6000339")]
	private void AddEvaluateCallback(AnimationTrack track, ITimelineEvaluateCallback callback) { }

	[Address(RVA = "0x2F476A0", Offset = "0x2F46AA0", Length = "0x223")]
	[Token(Token = "0x6000338")]
	private void AddOutputWeightProcessor(AnimationTrack track, AnimationPlayableOutput animOutput) { }

	[Address(RVA = "0x2F478D0", Offset = "0x2F46CD0", Length = "0x51")]
	[Token(Token = "0x6000337")]
	private void AddPlayableOutputCallbacks(AnimationTrack track, PlayableOutput playableOutput) { }

	[Address(RVA = "0x2F47930", Offset = "0x2F46D30", Length = "0x6E")]
	[Token(Token = "0x6000335")]
	private void CacheTrack(TrackAsset track, Playable playable) { }

	[Address(RVA = "0x2F47C40", Offset = "0x2F47040", Length = "0x2FA")]
	[Token(Token = "0x600032F")]
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	[Address(RVA = "0x2F479A0", Offset = "0x2F46DA0", Length = "0x294")]
	[Token(Token = "0x6000330")]
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	[Address(RVA = "0x2F489A0", Offset = "0x2F47DA0", Length = "0x272")]
	[Token(Token = "0x600032E")]
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	[Address(RVA = "0x2F47F40", Offset = "0x2F47340", Length = "0x598")]
	[Token(Token = "0x6000331")]
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	[Address(RVA = "0x2F484E0", Offset = "0x2F478E0", Length = "0x4BF")]
	[Token(Token = "0x6000332")]
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	[Address(RVA = "0x2F48C20", Offset = "0x2F48020", Length = "0x580")]
	[Token(Token = "0x6000334")]
	private void Evaluate(Playable playable, FrameData frameData) { }

	[Address(RVA = "0x2F491B0", Offset = "0x2F485B0", Length = "0x4B")]
	[Token(Token = "0x6000336")]
	private static void ForAOTCompilationOnly() { }

	[Address(RVA = "0x2F49200", Offset = "0x2F48600", Length = "0x904")]
	[Token(Token = "0x600033A")]
	private void InvokeOutputCallbacks(IReadOnlyList<RuntimeElement> activeRuntimeElements) { }

	[Address(RVA = "0x2F49B10", Offset = "0x2F48F10", Length = "0x46")]
	[Token(Token = "0x6000333")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F49B60", Offset = "0x2F48F60", Length = "0x139")]
	[Token(Token = "0x600033B")]
	private bool TryGetCallbackList(AnimationTrack track, out List<ITimelineEvaluateCallback>& list) { }

}

