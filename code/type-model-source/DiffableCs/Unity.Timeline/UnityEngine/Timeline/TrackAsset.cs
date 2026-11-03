namespace UnityEngine.Timeline;

[IgnoreOnPlayableTrack]
[Token(Token = "0x2000024")]
public abstract class TrackAsset : PlayableAsset, ISerializationCallbackReceiver, IPropertyPreview, ICurvesOwner
{
	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <>c
	{
		[Token(Token = "0x40000CE")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000CF")]
		public static Comparison<TimelineClip> <>9__125_0; //Field offset: 0x8

		[Address(RVA = "0x2F3F010", Offset = "0x2F3E410", Length = "0x67")]
		[Token(Token = "0x60001B6")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001B7")]
		public <>c() { }

		[Address(RVA = "0x2F3EFD0", Offset = "0x2F3E3D0", Length = "0x38")]
		[Token(Token = "0x60001B8")]
		internal int <SortClips>b__125_0(TimelineClip clip1, TimelineClip clip2) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <get_outputs>d__69 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D1")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000D2")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000D3")]
		public TrackAsset <>4__this; //Field offset: 0x40

		[Token(Token = "0x17000088")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x60001BC")]
			private get { } //Length: 19
		}

		[Token(Token = "0x17000089")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F400A0", Offset = "0x2F3F4A0", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x60001BE")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60001B9")]
		public <get_outputs>d__69(int <>1__state) { }

		[Address(RVA = "0x2F3FD60", Offset = "0x2F3F160", Length = "0x253")]
		[Token(Token = "0x60001BB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3FFC0", Offset = "0x2F3F3C0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001BF")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x60001BC")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3FFC0", Offset = "0x2F3F3C0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001C0")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F400A0", Offset = "0x2F3F4A0", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x60001BE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F40060", Offset = "0x2F3F460", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001BD")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001BA")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000026")]
	private static class TrackAssetUpgrade
	{

	}

	[Token(Token = "0x2000027")]
	private struct TransientBuildData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CB")]
		public List<TrackAsset> trackList; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CC")]
		public List<TimelineClip> clipList; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CD")]
		public List<IMarker> markerList; //Field offset: 0x10

		[Address(RVA = "0x2F3EBB0", Offset = "0x2F3DFB0", Length = "0xCE")]
		[Token(Token = "0x60001B5")]
		public void Clear() { }

		[Address(RVA = "0x2F3EC80", Offset = "0x2F3E080", Length = "0x116")]
		[Token(Token = "0x60001B4")]
		public static TransientBuildData Create() { }

	}

	[Token(Token = "0x2000025")]
	public enum Versions : int
	{
		Initial = 0,
		RotationAsEuler = 1,
		RootMotionUpgrade = 2,
		AnimatedTrackProperties = 3,
	}

	[Token(Token = "0x40000AD")]
	private const int k_LatestVersion = 3; //Field offset: 0x0
	[Token(Token = "0x40000B0")]
	private static TransientBuildData s_BuildData; //Field offset: 0x0
	[Token(Token = "0x40000B1")]
	internal const string kDefaultCurvesName = "Track Parameters"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40000B2")]
	private static Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x40000B3")]
	private static Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate; //Field offset: 0x20
	[Token(Token = "0x40000C1")]
	private static TrackAsset[] s_EmptyCache; //Field offset: 0x28
	[Token(Token = "0x40000C3")]
	private static Dictionary<Type, TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000AE")]
	private int m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_animClip")]
	[HideInInspector]
	[Obsolete("Please use m_InfiniteClip (on AnimationTrack) instead.", False)]
	[SerializeField]
	[Token(Token = "0x40000AF")]
	internal AnimationClip m_AnimClip; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B4")]
	private bool m_Locked; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B5")]
	private bool m_Muted; //Field offset: 0x29
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B6")]
	private string m_CustomPlayableFullTypename; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B7")]
	private AnimationClip m_Curves; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private PlayableAsset m_Parent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000B9")]
	private List<ScriptableObject> m_Children; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000BA")]
	private int m_ItemsHash; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000BB")]
	private TimelineClip[] m_ClipsCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BC")]
	private DiscreteTime m_Start; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000BD")]
	private DiscreteTime m_End; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000BE")]
	private bool m_CacheSorted; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40000BF")]
	private bool m_BlendsValid; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40000C0")]
	private Nullable<Boolean> m_SupportsNotifications; //Field offset: 0x72
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000C2")]
	private IEnumerable<TrackAsset> m_ChildTrackCache; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000C4")]
	protected private List<TimelineClip> m_Clips; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000C5")]
	private MarkerList m_Markers; //Field offset: 0x88

	[Token(Token = "0x14000001")]
	internal static event Action<TimelineClip, GameObject, Playable> OnClipPlayableCreate
	{
		[Address(RVA = "0x2F3DBC0", Offset = "0x2F3CFC0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000151")]
		internal add { } //Length: 261
		[Address(RVA = "0x2F3E920", Offset = "0x2F3DD20", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000152")]
		internal remove { } //Length: 261
	}

	[Token(Token = "0x14000002")]
	internal static event Action<TrackAsset, GameObject, Playable> OnTrackAnimationPlayableCreate
	{
		[Address(RVA = "0x2F3DCD0", Offset = "0x2F3D0D0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000153")]
		internal add { } //Length: 261
		[Address(RVA = "0x2F3EA30", Offset = "0x2F3DE30", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x6000154")]
		internal remove { } //Length: 261
	}

	[Token(Token = "0x17000078")]
	internal bool blendsValid
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x6000160")]
		internal get { } //Length: 5
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[Token(Token = "0x6000161")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000077")]
	internal TimelineClip[] clips
	{
		[Address(RVA = "0x2F3DDE0", Offset = "0x2F3D1E0", Length = "0xC7")]
		[Token(Token = "0x600015F")]
		internal get { } //Length: 199
	}

	[Token(Token = "0x1700007F")]
	public internal override AnimationClip curves
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600016A")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600016B")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700007E")]
	internal string customPlayableTypename
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000168")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000169")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000072")]
	public virtual double duration
	{
		[Address(RVA = "0x2F3DEB0", Offset = "0x2F3D2B0", Length = "0x9F")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 159
	}

	[Token(Token = "0x17000071")]
	public double end
	{
		[Address(RVA = "0x2F3DF50", Offset = "0x2F3D350", Length = "0x8F")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700007A")]
	public bool hasClips
	{
		[Address(RVA = "0x2F3DFE0", Offset = "0x2F3D3E0", Length = "0x4B")]
		[Token(Token = "0x6000163")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700007B")]
	public override bool hasCurves
	{
		[Address(RVA = "0x2F3E030", Offset = "0x2F3D430", Length = "0x80")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 128
	}

	[Token(Token = "0x17000079")]
	public override bool isEmpty
	{
		[Address(RVA = "0x2F3E0C0", Offset = "0x2F3D4C0", Length = "0x9A")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 154
	}

	[Token(Token = "0x1700007C")]
	public bool isSubTrack
	{
		[Address(RVA = "0x2F3E160", Offset = "0x2F3D560", Length = "0xFB")]
		[Token(Token = "0x6000165")]
		 get { } //Length: 251
	}

	[Token(Token = "0x17000085")]
	public bool locked
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000171")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000172")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000086")]
	public bool lockedInHierarchy
	{
		[Address(RVA = "0x2F3E260", Offset = "0x2F3D660", Length = "0x1B0")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 432
	}

	[Token(Token = "0x17000073")]
	public bool muted
	{
		[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 5
		[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000074")]
	public bool mutedInHierarchy
	{
		[Address(RVA = "0x2F3E420", Offset = "0x2F3D820", Length = "0x1B0")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 432
	}

	[Token(Token = "0x1700007D")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F3E5E0", Offset = "0x2F3D9E0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__69))]
		[Token(Token = "0x6000166")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000076")]
	public internal PlayableAsset parent
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x600015D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000070")]
	public double start
	{
		[Address(RVA = "0x2F3E660", Offset = "0x2F3DA60", Length = "0x8F")]
		[Token(Token = "0x6000155")]
		 get { } //Length: 143
	}

	[Token(Token = "0x17000084")]
	internal List<ScriptableObject> subTracksObjects
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000170")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000087")]
	public bool supportsNotifications
	{
		[Address(RVA = "0x2F3E6F0", Offset = "0x2F3DAF0", Length = "0x90")]
		[Token(Token = "0x6000174")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000075")]
	public TimelineAsset timelineAsset
	{
		[Address(RVA = "0x2F3E780", Offset = "0x2F3DB80", Length = "0x19E")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 414
	}

	[Token(Token = "0x17000081")]
	private override object UnityEngine.Timeline.ICurvesOwner.asset
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x600016D")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000082")]
	private override object UnityEngine.Timeline.ICurvesOwner.assetOwner
	{
		[Address(RVA = "0x2F3D1B0", Offset = "0x2F3C5B0", Length = "0x7")]
		[Token(Token = "0x600016E")]
		private get { } //Length: 7
	}

	[Token(Token = "0x17000080")]
	private override string UnityEngine.Timeline.ICurvesOwner.defaultCurvesName
	{
		[Address(RVA = "0x2F3D1C0", Offset = "0x2F3C5C0", Length = "0x2C")]
		[Token(Token = "0x600016C")]
		private get { } //Length: 44
	}

	[Token(Token = "0x17000083")]
	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.targetTrack
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x600016F")]
		private get { } //Length: 4
	}

	[Address(RVA = "0x2F3D7E0", Offset = "0x2F3CBE0", Length = "0xDF")]
	[Token(Token = "0x6000175")]
	private void __internalAwake() { }

	[Address(RVA = "0x2F3D8C0", Offset = "0x2F3CCC0", Length = "0x20B")]
	[Token(Token = "0x60001B3")]
	private static TrackAsset() { }

	[Address(RVA = "0x2F3DAD0", Offset = "0x2F3CED0", Length = "0xE6")]
	[Token(Token = "0x60001B2")]
	protected TrackAsset() { }

	[Address(RVA = "0x2F3DBC0", Offset = "0x2F3CFC0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000151")]
	internal static void add_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[Address(RVA = "0x2F3DCD0", Offset = "0x2F3D0D0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000153")]
	internal static void add_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[Address(RVA = "0x2F38040", Offset = "0x2F37440", Length = "0xA5")]
	[Token(Token = "0x6000199")]
	internal void AddChild(TrackAsset child) { }

	[Address(RVA = "0x2F380F0", Offset = "0x2F374F0", Length = "0x106")]
	[Token(Token = "0x600018C")]
	internal void AddClip(TimelineClip newClip) { }

	[Address(RVA = "0x2F38200", Offset = "0x2F37600", Length = "0xF")]
	[Token(Token = "0x6000189")]
	internal void AddMarker(ScriptableObject e) { }

	[Address(RVA = "0x2F38210", Offset = "0x2F37610", Length = "0x87")]
	[Token(Token = "0x60001A4")]
	protected private override int CalculateItemsHash() { }

	[Address(RVA = "0x2F382A0", Offset = "0x2F376A0", Length = "0x53")]
	[Token(Token = "0x60001A8")]
	internal override bool CanCompileClips() { }

	[Address(RVA = "0x2F38300", Offset = "0x2F37700", Length = "0x35")]
	[Token(Token = "0x60001B0")]
	private bool CanCompileNotifications() { }

	[Address(RVA = "0x2F38340", Offset = "0x2F37740", Length = "0x183")]
	[Token(Token = "0x60001B1")]
	private bool CanCreateMixerRecursive() { }

	[Address(RVA = "0x2F384D0", Offset = "0x2F378D0", Length = "0x14")]
	[Token(Token = "0x60001A9")]
	public override bool CanCreateTrackMixer() { }

	[Address(RVA = "0x2F384F0", Offset = "0x2F378F0", Length = "0x86")]
	[Token(Token = "0x6000195")]
	internal void ClearClipsInternal() { }

	[Address(RVA = "0x2F38580", Offset = "0x2F37980", Length = "0x64")]
	[Token(Token = "0x6000188")]
	internal void ClearMarkers() { }

	[Address(RVA = "0x2F385F0", Offset = "0x2F379F0", Length = "0x77")]
	[Token(Token = "0x6000196")]
	internal void ClearSubTracksInternal() { }

	[Address(RVA = "0x2F38670", Offset = "0x2F37A70", Length = "0x42B")]
	[Token(Token = "0x600018F")]
	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	[Address(RVA = "0x2F38AA0", Offset = "0x2F37EA0", Length = "0x166")]
	[Token(Token = "0x6000193")]
	internal void ConfigureTrackAnimation(IntervalTree<RuntimeElement> tree, GameObject go, Playable blend) { }

	[Address(RVA = "0x2F38C10", Offset = "0x2F38010", Length = "0x34")]
	[Token(Token = "0x6000183")]
	internal TimelineClip CreateAndAddNewClipOfType(Type requestedType) { }

	[Address(RVA = "0x946580", Offset = "0x945980", Length = "0x5D")]
	[Token(Token = "0x600017A")]
	public TimelineClip CreateClip() { }

	[Address(RVA = "0x2F39360", Offset = "0x2F38760", Length = "0x133")]
	[Token(Token = "0x6000182")]
	internal TimelineClip CreateClip(Type requestedType) { }

	[Address(RVA = "0x2F38C50", Offset = "0x2F38050", Length = "0x209")]
	[Token(Token = "0x6000186")]
	private TimelineClip CreateClipFromAsset(ScriptableObject playableAsset) { }

	[Address(RVA = "0x2F38E60", Offset = "0x2F38260", Length = "0x2AD")]
	[Token(Token = "0x6000185")]
	internal TimelineClip CreateClipFromPlayableAsset(IPlayableAsset asset) { }

	[Address(RVA = "0x2F39110", Offset = "0x2F38510", Length = "0x240")]
	[Token(Token = "0x6000184")]
	internal TimelineClip CreateClipOfType(Type requestedType) { }

	[Address(RVA = "0x2F394A0", Offset = "0x2F388A0", Length = "0xAC")]
	[Token(Token = "0x6000176")]
	public override void CreateCurves(string curvesClipName) { }

	[Address(RVA = "0x2F39550", Offset = "0x2F38950", Length = "0x2D7")]
	[Token(Token = "0x6000179")]
	public TimelineClip CreateDefaultClip() { }

	[Address(RVA = "0x2F39830", Offset = "0x2F38C30", Length = "0x21")]
	[Token(Token = "0x600017C")]
	public IMarker CreateMarker(Type type, double time) { }

	[Address(RVA = "0x9465E0", Offset = "0x9459E0", Length = "0xB9")]
	[Token(Token = "0x600017D")]
	public T CreateMarker(double time) { }

	[Address(RVA = "0x2F39860", Offset = "0x2F38C60", Length = "0x70A")]
	[Token(Token = "0x6000192")]
	internal override Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	[Address(RVA = "0x2F39F70", Offset = "0x2F39370", Length = "0x2D6")]
	[Token(Token = "0x6000198")]
	internal TimelineClip CreateNewClipContainerInternal() { }

	[Address(RVA = "0x2F3A250", Offset = "0x2F39650", Length = "0x35E")]
	[Token(Token = "0x600018D")]
	private Playable CreateNotificationsPlayable(PlayableGraph graph, Playable mixerPlayable, GameObject go, Playable timelinePlayable) { }

	[Address(RVA = "0x2F3A920", Offset = "0x2F39D20", Length = "0x55")]
	[Token(Token = "0x6000178")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x2F3A980", Offset = "0x2F39D80", Length = "0x310")]
	[Token(Token = "0x60001A5")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip) { }

	[Address(RVA = "0x2F3A5B0", Offset = "0x2F399B0", Length = "0x36A")]
	[Token(Token = "0x600018E")]
	internal Playable CreatePlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	[Address(RVA = "0x2F3ACA0", Offset = "0x2F3A0A0", Length = "0x74")]
	[Token(Token = "0x6000177")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x2F3AD20", Offset = "0x2F3A120", Length = "0x118")]
	[Token(Token = "0x600017B")]
	public bool DeleteClip(TimelineClip clip) { }

	[Address(RVA = "0x2F3AE80", Offset = "0x2F3A280", Length = "0xF")]
	[Token(Token = "0x600017E")]
	public bool DeleteMarker(IMarker marker) { }

	[Address(RVA = "0x2F3AE40", Offset = "0x2F3A240", Length = "0x40")]
	[Token(Token = "0x600018A")]
	internal bool DeleteMarkerRaw(ScriptableObject marker) { }

	[Address(RVA = "0x2F3AE90", Offset = "0x2F3A290", Length = "0x266")]
	[Token(Token = "0x6000190")]
	private void GatherCompilableTracks(IList<TrackAsset> tracks) { }

	[Address(RVA = "0x2F3B100", Offset = "0x2F3A500", Length = "0x276")]
	[Token(Token = "0x6000191")]
	private void GatherNotifications(List<IMarker> markers) { }

	[Address(RVA = "0x2F3B380", Offset = "0x2F3A780", Length = "0x510")]
	[Token(Token = "0x600019F")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x6000160")]
	internal bool get_blendsValid() { }

	[Address(RVA = "0x2F3DDE0", Offset = "0x2F3D1E0", Length = "0xC7")]
	[Token(Token = "0x600015F")]
	internal TimelineClip[] get_clips() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600016A")]
	public override AnimationClip get_curves() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000168")]
	internal string get_customPlayableTypename() { }

	[Address(RVA = "0x2F3DEB0", Offset = "0x2F3D2B0", Length = "0x9F")]
	[Token(Token = "0x6000157")]
	public virtual double get_duration() { }

	[Address(RVA = "0x2F3DF50", Offset = "0x2F3D350", Length = "0x8F")]
	[Token(Token = "0x6000156")]
	public double get_end() { }

	[Address(RVA = "0x2F3DFE0", Offset = "0x2F3D3E0", Length = "0x4B")]
	[Token(Token = "0x6000163")]
	public bool get_hasClips() { }

	[Address(RVA = "0x2F3E030", Offset = "0x2F3D430", Length = "0x80")]
	[Token(Token = "0x6000164")]
	public override bool get_hasCurves() { }

	[Address(RVA = "0x2F3E0C0", Offset = "0x2F3D4C0", Length = "0x9A")]
	[Token(Token = "0x6000162")]
	public override bool get_isEmpty() { }

	[Address(RVA = "0x2F3E160", Offset = "0x2F3D560", Length = "0xFB")]
	[Token(Token = "0x6000165")]
	public bool get_isSubTrack() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000171")]
	public bool get_locked() { }

	[Address(RVA = "0x2F3E260", Offset = "0x2F3D660", Length = "0x1B0")]
	[Token(Token = "0x6000173")]
	public bool get_lockedInHierarchy() { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[Token(Token = "0x6000158")]
	public bool get_muted() { }

	[Address(RVA = "0x2F3E420", Offset = "0x2F3D820", Length = "0x1B0")]
	[Token(Token = "0x600015A")]
	public bool get_mutedInHierarchy() { }

	[Address(RVA = "0x2F3E5E0", Offset = "0x2F3D9E0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__69))]
	[Token(Token = "0x6000166")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600015C")]
	public PlayableAsset get_parent() { }

	[Address(RVA = "0x2F3E660", Offset = "0x2F3DA60", Length = "0x8F")]
	[Token(Token = "0x6000155")]
	public double get_start() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000170")]
	internal List<ScriptableObject> get_subTracksObjects() { }

	[Address(RVA = "0x2F3E6F0", Offset = "0x2F3DAF0", Length = "0x90")]
	[Token(Token = "0x6000174")]
	public bool get_supportsNotifications() { }

	[Address(RVA = "0x2F3E780", Offset = "0x2F3DB80", Length = "0x19E")]
	[Token(Token = "0x600015B")]
	public TimelineAsset get_timelineAsset() { }

	[Address(RVA = "0x2F3B8A0", Offset = "0x2F3ACA0", Length = "0xD1")]
	[Token(Token = "0x60001AE")]
	protected static int GetAnimationClipHash(AnimationClip clip) { }

	[Address(RVA = "0x2F3B980", Offset = "0x2F3AD80", Length = "0x1A")]
	[Token(Token = "0x6000167")]
	public IEnumerable<TrackAsset> GetChildTracks() { }

	[Address(RVA = "0x2F3BC00", Offset = "0x2F3B000", Length = "0x7")]
	[Token(Token = "0x600015E")]
	public IEnumerable<TimelineClip> GetClips() { }

	[Address(RVA = "0x2F3B9A0", Offset = "0x2F3ADA0", Length = "0x252")]
	[Token(Token = "0x60001AD")]
	private int GetClipsHash() { }

	[Address(RVA = "0x2F3BC10", Offset = "0x2F3B010", Length = "0x233")]
	[Token(Token = "0x600019D")]
	internal override void GetEvaluationTime(out double outStart, out double outDuration) { }

	[Address(RVA = "0x2F3BE50", Offset = "0x2F3B250", Length = "0x186")]
	[Token(Token = "0x60001A0")]
	internal GameObject GetGameObjectBinding(PlayableDirector director) { }

	[Address(RVA = "0x2F3C030", Offset = "0x2F3B430", Length = "0x5F")]
	[Token(Token = "0x6000181")]
	public IMarker GetMarker(int idx) { }

	[Address(RVA = "0x2F3BFE0", Offset = "0x2F3B3E0", Length = "0x4A")]
	[Token(Token = "0x6000180")]
	public int GetMarkerCount() { }

	[Address(RVA = "0x2F3C090", Offset = "0x2F3B490", Length = "0x21")]
	[Token(Token = "0x600017F")]
	public IEnumerable<IMarker> GetMarkers() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6000187")]
	internal IEnumerable<ScriptableObject> GetMarkersRaw() { }

	[Address(RVA = "0x2F3C0C0", Offset = "0x2F3B4C0", Length = "0x18A")]
	[Token(Token = "0x60001A7")]
	internal double GetNotificationDuration() { }

	[Address(RVA = "0x2F3C250", Offset = "0x2F3B650", Length = "0x14")]
	[Token(Token = "0x600019E")]
	internal override void GetSequenceTime(out double outStart, out double outDuration) { }

	[Address(RVA = "0x2F3C270", Offset = "0x2F3B670", Length = "0x211")]
	[Token(Token = "0x600018B")]
	private int GetTimeRangeHash() { }

	[Address(RVA = "0x2F3C4C0", Offset = "0x2F3B8C0", Length = "0x6B")]
	[Token(Token = "0x60001AC")]
	internal override int Hash() { }

	[Address(RVA = "0x2F3C490", Offset = "0x2F3B890", Length = "0x21")]
	[Token(Token = "0x60001AF")]
	private bool HasNotifications() { }

	[Address(RVA = "0x2F3C530", Offset = "0x2F3B930", Length = "0xAE")]
	[Token(Token = "0x60001A6")]
	internal void Invalidate() { }

	[Address(RVA = "0x2F3C5E0", Offset = "0x2F3B9E0", Length = "0x283")]
	[Token(Token = "0x60001AA")]
	internal bool IsCompilable() { }

	[Address(RVA = "0x2F3C870", Offset = "0x2F3BC70", Length = "0x1F8")]
	[Token(Token = "0x600019A")]
	internal void MoveLastTrackBefore(TrackAsset asset) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600014C")]
	protected override void OnAfterTrackDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600014B")]
	protected override void OnBeforeTrackSerialize() { }

	[Address(RVA = "0x2F3CA70", Offset = "0x2F3BE70", Length = "0x59")]
	[Token(Token = "0x6000197")]
	internal void OnClipMove(ITimelineClipAsset clip) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001A2")]
	protected override void OnCreateClip(TimelineClip clip) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600014D")]
	internal override void OnUpgradeFromVersion(int oldVersion) { }

	[Address(RVA = "0x2F3E920", Offset = "0x2F3DD20", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000152")]
	internal static void remove_OnClipPlayableCreate(Action<TimelineClip, GameObject, Playable> value) { }

	[Address(RVA = "0x2F3EA30", Offset = "0x2F3DE30", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x6000154")]
	internal static void remove_OnTrackAnimationPlayableCreate(Action<TrackAsset, GameObject, Playable> value) { }

	[Address(RVA = "0x2F3CAD0", Offset = "0x2F3BED0", Length = "0x81")]
	[Token(Token = "0x600019C")]
	internal void RemoveClip(TimelineClip clip) { }

	[Address(RVA = "0x2F3CB60", Offset = "0x2F3BF60", Length = "0x87")]
	[Token(Token = "0x600019B")]
	internal bool RemoveSubTrack(TrackAsset child) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[Token(Token = "0x6000161")]
	internal void set_blendsValid(bool value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600016B")]
	internal void set_curves(AnimationClip value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000169")]
	internal void set_customPlayableTypename(string value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000172")]
	public void set_locked(bool value) { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[Token(Token = "0x6000159")]
	public void set_muted(bool value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600015D")]
	internal void set_parent(PlayableAsset value) { }

	[Address(RVA = "0x2F3CBF0", Offset = "0x2F3BFF0", Length = "0x144")]
	[Token(Token = "0x6000194")]
	internal void SortClips() { }

	[Address(RVA = "0x2F3CD40", Offset = "0x2F3C140", Length = "0x2B9")]
	[Token(Token = "0x600014F")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2F3D000", Offset = "0x2F3C400", Length = "0x1A4")]
	[Token(Token = "0x600014E")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600016D")]
	private override object UnityEngine.Timeline.ICurvesOwner.get_asset() { }

	[Address(RVA = "0x2F3D1B0", Offset = "0x2F3C5B0", Length = "0x7")]
	[Token(Token = "0x600016E")]
	private override object UnityEngine.Timeline.ICurvesOwner.get_assetOwner() { }

	[Address(RVA = "0x2F3D1C0", Offset = "0x2F3C5C0", Length = "0x2C")]
	[Token(Token = "0x600016C")]
	private override string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600016F")]
	private override TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack() { }

	[Address(RVA = "0x2F3D1F0", Offset = "0x2F3C5F0", Length = "0x1F9")]
	[Token(Token = "0x60001AB")]
	private void UpdateChildTrackCache() { }

	[Address(RVA = "0x2F3D3F0", Offset = "0x2F3C7F0", Length = "0x156")]
	[Token(Token = "0x60001A3")]
	private void UpdateDuration() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000150")]
	private void UpgradeToLatestVersion() { }

	[Address(RVA = "0x2F3D550", Offset = "0x2F3C950", Length = "0x28E")]
	[Token(Token = "0x60001A1")]
	internal bool ValidateClipType(Type clipType) { }

}

