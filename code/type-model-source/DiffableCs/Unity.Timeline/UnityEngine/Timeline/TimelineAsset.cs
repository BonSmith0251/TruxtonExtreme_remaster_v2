namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[Token(Token = "0x200001D")]
public class TimelineAsset : PlayableAsset, ISerializationCallbackReceiver, ITimelineClipAsset, IPropertyPreview
{
	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <get_outputs>d__27 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000A7")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A8")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000A9")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000AA")]
		public TimelineAsset <>4__this; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40000AB")]
		private IEnumerator<TrackAsset> <>7__wrap1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40000AC")]
		private IEnumerator<PlayableBinding> <>7__wrap2; //Field offset: 0x50

		[Token(Token = "0x1700006E")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x6000146")]
			private get { } //Length: 19
		}

		[Token(Token = "0x1700006F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F3F700", Offset = "0x2F3EB00", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x6000148")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000141")]
		public <get_outputs>d__27(int <>1__state) { }

		[Address(RVA = "0x2F3F8A0", Offset = "0x2F3ECA0", Length = "0x50")]
		[Token(Token = "0x6000144")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x2F3F8F0", Offset = "0x2F3ECF0", Length = "0x50")]
		[Token(Token = "0x6000145")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x2F3F270", Offset = "0x2F3E670", Length = "0x3A5")]
		[Token(Token = "0x6000143")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3F620", Offset = "0x2F3EA20", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000149")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x6000146")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3F620", Offset = "0x2F3EA20", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600014A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F3F700", Offset = "0x2F3EB00", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x6000148")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3F6C0", Offset = "0x2F3EAC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000147")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2F3F750", Offset = "0x2F3EB50", Length = "0x14A")]
		[DebuggerHidden]
		[Token(Token = "0x6000142")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000021")]
	internal enum DurationMode : int
	{
		BasedOnClips = 0,
		FixedLength = 1,
	}

	[Token(Token = "0x2000022")]
	internal class EditorSettings
	{
		[Token(Token = "0x40000A2")]
		internal static readonly double kMinFrameRate; //Field offset: 0x0
		[Token(Token = "0x40000A3")]
		internal static readonly double kMaxFrameRate; //Field offset: 0x8
		[Token(Token = "0x40000A4")]
		internal static readonly double kDefaultFrameRate; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[FrameRateField]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x40000A5")]
		private double m_Framerate; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		[Token(Token = "0x40000A6")]
		private bool m_ScenePreview; //Field offset: 0x18

		[Obsolete("EditorSettings.fps has been deprecated. Use editorSettings.frameRate instead.", False)]
		[Token(Token = "0x1700006B")]
		public float fps
		{
			[Address(RVA = "0x2F2E7D0", Offset = "0x2F2DBD0", Length = "0xA")]
			[Token(Token = "0x6000138")]
			 get { } //Length: 10
			[Address(RVA = "0x2F2E7E0", Offset = "0x2F2DBE0", Length = "0xA8")]
			[Token(Token = "0x6000139")]
			 set { } //Length: 168
		}

		[Token(Token = "0x1700006C")]
		public double frameRate
		{
			[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
			[Token(Token = "0x600013A")]
			 get { } //Length: 6
			[Address(RVA = "0x2F2E890", Offset = "0x2F2DC90", Length = "0x1E")]
			[Token(Token = "0x600013B")]
			 set { } //Length: 30
		}

		[Token(Token = "0x1700006D")]
		public bool scenePreview
		{
			[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
			[Token(Token = "0x600013D")]
			 get { } //Length: 5
			[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
			[Token(Token = "0x600013E")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x2F2E6B0", Offset = "0x2F2DAB0", Length = "0xA4")]
		[Token(Token = "0x6000140")]
		private static EditorSettings() { }

		[Address(RVA = "0x2F2E760", Offset = "0x2F2DB60", Length = "0x66")]
		[Token(Token = "0x600013F")]
		public EditorSettings() { }

		[Address(RVA = "0x2F2E7D0", Offset = "0x2F2DBD0", Length = "0xA")]
		[Token(Token = "0x6000138")]
		public float get_fps() { }

		[Address(RVA = "0x1964090", Offset = "0x1963490", Length = "0x6")]
		[Token(Token = "0x600013A")]
		public double get_frameRate() { }

		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x600013D")]
		public bool get_scenePreview() { }

		[Address(RVA = "0x2F2E7E0", Offset = "0x2F2DBE0", Length = "0xA8")]
		[Token(Token = "0x6000139")]
		public void set_fps(float value) { }

		[Address(RVA = "0x2F2E890", Offset = "0x2F2DC90", Length = "0x1E")]
		[Token(Token = "0x600013B")]
		public void set_frameRate(double value) { }

		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x600013E")]
		public void set_scenePreview(bool value) { }

		[Address(RVA = "0x2F2E560", Offset = "0x2F2D960", Length = "0x141")]
		[Token(Token = "0x600013C")]
		public void SetStandardFrameRate(StandardFrameRates enumValue) { }

	}

	[Obsolete("MediaType has been deprecated. It is no longer required, and will be removed in a future release.", False)]
	[Token(Token = "0x2000020")]
	internal enum MediaType : int
	{
		Animation = 0,
		Audio = 1,
		Texture = 2,
		Video = 2,
		Script = 3,
		Hybrid = 4,
		Group = 5,
	}

	[Token(Token = "0x200001F")]
	private static class TimelineAssetUpgrade
	{

	}

	[Token(Token = "0x200001E")]
	private enum Versions : int
	{
		Initial = 0,
	}

	[Token(Token = "0x400008B")]
	private const int k_LatestVersion = 0; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400008C")]
	private int m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400008D")]
	private List<ScriptableObject> m_Tracks; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private double m_FixedDuration; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[Token(Token = "0x400008F")]
	private TrackAsset[] m_CacheOutputTracks; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[Token(Token = "0x4000090")]
	private List<TrackAsset> m_CacheRootTracks; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[Token(Token = "0x4000091")]
	private TrackAsset[] m_CacheFlattenedTracks; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000092")]
	private EditorSettings m_EditorSettings; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000093")]
	private DurationMode m_DurationMode; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000094")]
	private MarkerTrack m_MarkerTrack; //Field offset: 0x58

	[Token(Token = "0x17000065")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x2F34BA0", Offset = "0x2F33FA0", Length = "0x1A5")]
		[Token(Token = "0x6000112")]
		 get { } //Length: 421
	}

	[Token(Token = "0x17000061")]
	public virtual double duration
	{
		[Address(RVA = "0x2F34D50", Offset = "0x2F34150", Length = "0xCE")]
		[Token(Token = "0x600010C")]
		 get { } //Length: 206
	}

	[Token(Token = "0x17000063")]
	public DurationMode durationMode
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600010F")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x6000110")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public EditorSettings editorSettings
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600010B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000062")]
	public double fixedDuration
	{
		[Address(RVA = "0x2F34E20", Offset = "0x2F34220", Length = "0x103")]
		[Token(Token = "0x600010D")]
		 get { } //Length: 259
		[Address(RVA = "0x2F351B0", Offset = "0x2F345B0", Length = "0x60")]
		[Token(Token = "0x600010E")]
		 set { } //Length: 96
	}

	[Token(Token = "0x17000068")]
	internal TrackAsset[] flattenedTracks
	{
		[Address(RVA = "0x2F34F30", Offset = "0x2F34330", Length = "0x17A")]
		[Token(Token = "0x600011D")]
		internal get { } //Length: 378
	}

	[Token(Token = "0x17000069")]
	public MarkerTrack markerTrack
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600011E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000064")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F350E0", Offset = "0x2F344E0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__27))]
		[Token(Token = "0x6000111")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000066")]
	public int outputTrackCount
	{
		[Address(RVA = "0x2F350B0", Offset = "0x2F344B0", Length = "0x27")]
		[Token(Token = "0x6000113")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000067")]
	public int rootTrackCount
	{
		[Address(RVA = "0x2F35160", Offset = "0x2F34560", Length = "0x46")]
		[Token(Token = "0x6000114")]
		 get { } //Length: 70
	}

	[Token(Token = "0x1700006A")]
	internal List<ScriptableObject> trackObjects
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600011F")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2F34960", Offset = "0x2F33D60", Length = "0x17C")]
	[Token(Token = "0x6000125")]
	private void __internalAwake() { }

	[Address(RVA = "0x2F34AE0", Offset = "0x2F33EE0", Length = "0xB4")]
	[Token(Token = "0x6000137")]
	public TimelineAsset() { }

	[Address(RVA = "0x2F32190", Offset = "0x2F31590", Length = "0x23B")]
	[Token(Token = "0x600012C")]
	private static void AddSubTracksRecursive(TrackAsset track, ref List<TrackAsset>& allTracks) { }

	[Address(RVA = "0x2F323D0", Offset = "0x2F317D0", Length = "0xED")]
	[Token(Token = "0x6000120")]
	internal void AddTrackInternal(TrackAsset track) { }

	[Address(RVA = "0x2F324C0", Offset = "0x2F318C0", Length = "0x2A6")]
	[Token(Token = "0x6000134")]
	private TrackAsset AllocateTrack(TrackAsset trackAssetParent, string trackName, Type trackType) { }

	[Address(RVA = "0x2F32770", Offset = "0x2F31B70", Length = "0x273")]
	[Token(Token = "0x600012B")]
	private DiscreteTime CalculateItemsDuration() { }

	[Address(RVA = "0x2F329F0", Offset = "0x2F31DF0", Length = "0x10A")]
	[Token(Token = "0x6000127")]
	public void CreateMarkerTrack() { }

	[Address(RVA = "0x2F32B00", Offset = "0x2F31F00", Length = "0x1EC")]
	[Token(Token = "0x6000122")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x945140", Offset = "0x944540", Length = "0xCF")]
	[Token(Token = "0x600012E")]
	public T CreateTrack(TrackAsset parent, string trackName) { }

	[Address(RVA = "0x2F32CF0", Offset = "0x2F320F0", Length = "0x337")]
	[Token(Token = "0x600012D")]
	public TrackAsset CreateTrack(Type type, TrackAsset parent, string name) { }

	[Address(RVA = "0x9452E0", Offset = "0x9446E0", Length = "0xD0")]
	[Token(Token = "0x600012F")]
	public T CreateTrack(string trackName) { }

	[Address(RVA = "0x945210", Offset = "0x944610", Length = "0xC1")]
	[Token(Token = "0x6000130")]
	public T CreateTrack() { }

	[Address(RVA = "0x2F33030", Offset = "0x2F32430", Length = "0x305")]
	[Token(Token = "0x6000131")]
	public bool DeleteClip(TimelineClip clip) { }

	[Address(RVA = "0x2F33340", Offset = "0x2F32740", Length = "0x14D")]
	[Token(Token = "0x6000135")]
	private void DeleteRecordedAnimation(TrackAsset track) { }

	[Address(RVA = "0x2F33490", Offset = "0x2F32890", Length = "0x156")]
	[Token(Token = "0x6000136")]
	private void DeleteRecordedAnimation(TimelineClip clip) { }

	[Address(RVA = "0x2F335F0", Offset = "0x2F329F0", Length = "0x543")]
	[Token(Token = "0x6000132")]
	public bool DeleteTrack(TrackAsset track) { }

	[Address(RVA = "0x2F33B40", Offset = "0x2F32F40", Length = "0x1FA")]
	[Token(Token = "0x6000126")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x2F34BA0", Offset = "0x2F33FA0", Length = "0x1A5")]
	[Token(Token = "0x6000112")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x2F34D50", Offset = "0x2F34150", Length = "0xCE")]
	[Token(Token = "0x600010C")]
	public virtual double get_duration() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x600010F")]
	public DurationMode get_durationMode() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600010B")]
	public EditorSettings get_editorSettings() { }

	[Address(RVA = "0x2F34E20", Offset = "0x2F34220", Length = "0x103")]
	[Token(Token = "0x600010D")]
	public double get_fixedDuration() { }

	[Address(RVA = "0x2F34F30", Offset = "0x2F34330", Length = "0x17A")]
	[Token(Token = "0x600011D")]
	internal TrackAsset[] get_flattenedTracks() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600011E")]
	public MarkerTrack get_markerTrack() { }

	[Address(RVA = "0x2F350E0", Offset = "0x2F344E0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__27))]
	[Token(Token = "0x6000111")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x2F350B0", Offset = "0x2F344B0", Length = "0x27")]
	[Token(Token = "0x6000113")]
	public int get_outputTrackCount() { }

	[Address(RVA = "0x2F35160", Offset = "0x2F34560", Length = "0x46")]
	[Token(Token = "0x6000114")]
	public int get_rootTrackCount() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600011F")]
	internal List<ScriptableObject> get_trackObjects() { }

	[Address(RVA = "0x2F33D40", Offset = "0x2F33140", Length = "0x40")]
	[Token(Token = "0x6000118")]
	public TrackAsset GetOutputTrack(int index) { }

	[Address(RVA = "0x2F33D90", Offset = "0x2F33190", Length = "0x1A")]
	[Token(Token = "0x6000119")]
	public IEnumerable<TrackAsset> GetOutputTracks() { }

	[Address(RVA = "0x2F33DB0", Offset = "0x2F331B0", Length = "0x5B")]
	[Token(Token = "0x6000116")]
	public TrackAsset GetRootTrack(int index) { }

	[Address(RVA = "0x2F33E10", Offset = "0x2F33210", Length = "0x1A")]
	[Token(Token = "0x6000117")]
	public IEnumerable<TrackAsset> GetRootTracks() { }

	[Address(RVA = "0x2F33E30", Offset = "0x2F33230", Length = "0xAF")]
	[Token(Token = "0x600011A")]
	private static double GetValidFrameRate(double frameRate) { }

	[Address(RVA = "0x2F33EE0", Offset = "0x2F332E0", Length = "0x47")]
	[Token(Token = "0x6000129")]
	internal void Invalidate() { }

	[Address(RVA = "0x2F33F30", Offset = "0x2F33330", Length = "0x1F8")]
	[Token(Token = "0x6000133")]
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	[Address(RVA = "0x2F34130", Offset = "0x2F33530", Length = "0x32")]
	[Token(Token = "0x6000115")]
	private void OnValidate() { }

	[Address(RVA = "0x2F34170", Offset = "0x2F33570", Length = "0xB8")]
	[Token(Token = "0x6000128")]
	internal void RemoveMarkerTrack() { }

	[Address(RVA = "0x2F34230", Offset = "0x2F33630", Length = "0x176")]
	[Token(Token = "0x6000121")]
	internal void RemoveTrack(TrackAsset track) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x6000110")]
	public void set_durationMode(DurationMode value) { }

	[Address(RVA = "0x2F351B0", Offset = "0x2F345B0", Length = "0x60")]
	[Token(Token = "0x600010E")]
	public void set_fixedDuration(double value) { }

	[Address(RVA = "0x2F343B0", Offset = "0x2F337B0", Length = "0x48")]
	[Token(Token = "0x6000124")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3F80", Length = "0x8")]
	[Token(Token = "0x6000123")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x2F34400", Offset = "0x2F33800", Length = "0x9C")]
	[Token(Token = "0x600012A")]
	internal void UpdateFixedDurationWithItemsDuration() { }

	[Address(RVA = "0x2F344A0", Offset = "0x2F338A0", Length = "0x1E6")]
	[Token(Token = "0x600011C")]
	private void UpdateOutputTrackCache() { }

	[Address(RVA = "0x2F34690", Offset = "0x2F33A90", Length = "0x2CE")]
	[Token(Token = "0x600011B")]
	private void UpdateRootTrackCache() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600010A")]
	private void UpgradeToLatestVersion() { }

}

