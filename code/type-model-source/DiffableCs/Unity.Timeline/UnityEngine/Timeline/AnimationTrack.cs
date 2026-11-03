namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[Token(Token = "0x2000014")]
[TrackBindingType(typeof(Animator))]
[TrackClipType(typeof(AnimationPlayableAsset), False)]
public class AnimationTrack : TrackAsset, ILayerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000016")]
	private sealed class <get_outputs>d__49 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400005C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005D")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400005E")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400005F")]
		public AnimationTrack <>4__this; //Field offset: 0x40

		[Token(Token = "0x1700002D")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x60000A3")]
			private get { } //Length: 19
		}

		[Token(Token = "0x1700002E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F3FBE0", Offset = "0x2F3EFE0", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x60000A5")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A0")]
		public <get_outputs>d__49(int <>1__state) { }

		[Address(RVA = "0x2F3F940", Offset = "0x2F3ED40", Length = "0x8D")]
		[Token(Token = "0x60000A2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3FB00", Offset = "0x2F3EF00", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60000A6")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x60000A3")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3FB00", Offset = "0x2F3EF00", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60000A7")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F3FBE0", Offset = "0x2F3EFE0", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3FBA0", Offset = "0x2F3EFA0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60000A4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60000A1")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000015")]
	private static class AnimationTrackUpgrade
	{

		[Address(RVA = "0x2F23900", Offset = "0x2F22D00", Length = "0x42")]
		[Token(Token = "0x600009F")]
		public static void ConvertInfiniteTrack(AnimationTrack track) { }

		[Address(RVA = "0x2F23950", Offset = "0x2F22D50", Length = "0xAE")]
		[Token(Token = "0x600009E")]
		public static void ConvertRootMotion(AnimationTrack track) { }

		[Address(RVA = "0x2F23A00", Offset = "0x2F22E00", Length = "0x10D")]
		[Token(Token = "0x600009D")]
		public static void ConvertRotationsToEuler(AnimationTrack track) { }

	}

	[Token(Token = "0x4000047")]
	private const string k_DefaultInfiniteClipName = "Recorded"; //Field offset: 0x0
	[Token(Token = "0x4000048")]
	private const string k_DefaultRecordableClipName = "Recorded"; //Field offset: 0x0
	[Token(Token = "0x4000058")]
	private static readonly Queue<Transform> s_CachedQueue; //Field offset: 0x0
	[FieldOffset(Offset = "0xA0")]
	[FormerlySerializedAs("m_OpenClipPreExtrapolation")]
	[SerializeField]
	[Token(Token = "0x4000049")]
	private ClipExtrapolation m_InfiniteClipPreExtrapolation; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[FormerlySerializedAs("m_OpenClipPostExtrapolation")]
	[SerializeField]
	[Token(Token = "0x400004A")]
	private ClipExtrapolation m_InfiniteClipPostExtrapolation; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("m_OpenClipOffsetPosition")]
	[SerializeField]
	[Token(Token = "0x400004B")]
	private Vector3 m_InfiniteClipOffsetPosition; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB4")]
	[FormerlySerializedAs("m_OpenClipOffsetEulerAngles")]
	[SerializeField]
	[Token(Token = "0x400004C")]
	private Vector3 m_InfiniteClipOffsetEulerAngles; //Field offset: 0xB4
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_OpenClipTimeOffset")]
	[SerializeField]
	[Token(Token = "0x400004D")]
	private double m_InfiniteClipTimeOffset; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[FormerlySerializedAs("m_OpenClipRemoveOffset")]
	[SerializeField]
	[Token(Token = "0x400004E")]
	private bool m_InfiniteClipRemoveOffset; //Field offset: 0xC8
	[FieldOffset(Offset = "0xC9")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private bool m_InfiniteClipApplyFootIK; //Field offset: 0xC9
	[FieldOffset(Offset = "0xCC")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000050")]
	private LoopMode mInfiniteClipLoop; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000051")]
	private MatchTargetFields m_MatchTargetFields; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	[Token(Token = "0x4000052")]
	private Vector3 m_Position; //Field offset: 0xD4
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000053")]
	private Vector3 m_EulerAngles; //Field offset: 0xE0
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000054")]
	private AvatarMask m_AvatarMask; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000055")]
	private bool m_ApplyAvatarMask; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Token(Token = "0x4000056")]
	private TrackOffset m_TrackOffset; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000057")]
	private AnimationClip m_InfiniteClip; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[HideInInspector]
	[Obsolete("Use m_InfiniteClipOffsetEulerAngles Instead", False)]
	[SerializeField]
	[Token(Token = "0x4000059")]
	private Quaternion m_OpenClipOffsetRotation; //Field offset: 0x108
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	[Token(Token = "0x400005A")]
	private Quaternion m_Rotation; //Field offset: 0x118
	[FieldOffset(Offset = "0x128")]
	[HideInInspector]
	[Obsolete("Use m_RootTransformOffsetMode", False)]
	[SerializeField]
	[Token(Token = "0x400005B")]
	private bool m_ApplyOffsets; //Field offset: 0x128

	[Token(Token = "0x1700001D")]
	public bool applyAvatarMask
	{
		[Address(RVA = "0x2EF4600", Offset = "0x2EF3A00", Length = "0x8")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 8
		[Address(RVA = "0x2F27740", Offset = "0x2F26B40", Length = "0x7")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 7
	}

	[Obsolete("applyOffset is deprecated. Use trackOffset instead", True)]
	[Token(Token = "0x17000017")]
	public bool applyOffsets
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000052")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700001C")]
	public AvatarMask avatarMask
	{
		[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 8
		[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000016")]
	public Vector3 eulerAngles
	{
		[Address(RVA = "0x2F27530", Offset = "0x2F26930", Length = "0x19")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 25
		[Address(RVA = "0x2F27750", Offset = "0x2F26B50", Length = "0x16")]
		[Token(Token = "0x6000050")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700001F")]
	public bool inClipMode
	{
		[Address(RVA = "0x2F27550", Offset = "0x2F26950", Length = "0x3C")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700001A")]
	public internal AnimationClip infiniteClip
	{
		[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
		[Token(Token = "0x6000057")]
		 get { } //Length: 8
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[Token(Token = "0x6000058")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000023")]
	internal bool infiniteClipApplyFootIK
	{
		[Address(RVA = "0x2F27590", Offset = "0x2F26990", Length = "0x8")]
		[Token(Token = "0x6000068")]
		internal get { } //Length: 8
		[Address(RVA = "0x2F27770", Offset = "0x2F26B70", Length = "0x7")]
		[Token(Token = "0x6000069")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000027")]
	internal LoopMode infiniteClipLoop
	{
		[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
		[Token(Token = "0x6000070")]
		internal get { } //Length: 7
		[Address(RVA = "0x29E0BE0", Offset = "0x29DFFE0", Length = "0x7")]
		[Token(Token = "0x6000071")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000022")]
	public Vector3 infiniteClipOffsetEulerAngles
	{
		[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
		[Token(Token = "0x6000066")]
		 get { } //Length: 25
		[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
		[Token(Token = "0x6000067")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000020")]
	public Vector3 infiniteClipOffsetPosition
	{
		[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 25
		[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
		[Token(Token = "0x6000063")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000021")]
	public Quaternion infiniteClipOffsetRotation
	{
		[Address(RVA = "0x2F275A0", Offset = "0x2F269A0", Length = "0x6D")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 109
		[Address(RVA = "0x2F27780", Offset = "0x2F26B80", Length = "0x7F")]
		[Token(Token = "0x6000065")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000026")]
	public ClipExtrapolation infiniteClipPostExtrapolation
	{
		[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
		[Token(Token = "0x600006E")]
		 get { } //Length: 7
		[Address(RVA = "0x2F27800", Offset = "0x2F26C00", Length = "0x7")]
		[Token(Token = "0x600006F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000025")]
	public ClipExtrapolation infiniteClipPreExtrapolation
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x600006C")]
		 get { } //Length: 7
		[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
		[Token(Token = "0x600006D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700001B")]
	internal bool infiniteClipRemoveOffset
	{
		[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
		[Token(Token = "0x6000059")]
		internal get { } //Length: 8
		[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
		[Token(Token = "0x600005A")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000024")]
	internal double infiniteClipTimeOffset
	{
		[Address(RVA = "0x2F27610", Offset = "0x2F26A10", Length = "0x9")]
		[Token(Token = "0x600006A")]
		internal get { } //Length: 9
		[Address(RVA = "0x2F27810", Offset = "0x2F26C10", Length = "0x9")]
		[Token(Token = "0x600006B")]
		internal set { } //Length: 9
	}

	[Token(Token = "0x17000019")]
	public MatchTargetFields matchTargetFields
	{
		[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 7
		[Address(RVA = "0x2F27820", Offset = "0x2F26C20", Length = "0x66")]
		[Token(Token = "0x6000056")]
		 set { } //Length: 102
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetEulerAngles has been deprecated. Use infiniteClipOffsetEulerAngles instead. (UnityUpgradable) -> infiniteClipOffsetEulerAngles", True)]
	[Token(Token = "0x1700002A")]
	public Vector3 openClipOffsetEulerAngles
	{
		[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 25
		[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
		[Token(Token = "0x6000095")]
		 set { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetPosition has been deprecated. Use infiniteClipOffsetPosition instead. (UnityUpgradable) -> infiniteClipOffsetPosition", True)]
	[Token(Token = "0x17000028")]
	public Vector3 openClipOffsetPosition
	{
		[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
		[Token(Token = "0x6000090")]
		 get { } //Length: 25
		[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
		[Token(Token = "0x6000091")]
		 set { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipOffsetRotation has been deprecated. Use infiniteClipOffsetRotation instead. (UnityUpgradable) -> infiniteClipOffsetRotation", True)]
	[Token(Token = "0x17000029")]
	public Quaternion openClipOffsetRotation
	{
		[Address(RVA = "0x2F275A0", Offset = "0x2F269A0", Length = "0x6D")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 109
		[Address(RVA = "0x2F27890", Offset = "0x2F26C90", Length = "0x8C")]
		[Token(Token = "0x6000093")]
		 set { } //Length: 140
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipPostExtrapolation has been deprecated. Use infiniteClipPostExtrapolation instead. (UnityUpgradable) -> infiniteClipPostExtrapolation", True)]
	[Token(Token = "0x1700002C")]
	public ClipExtrapolation openClipPostExtrapolation
	{
		[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 7
		[Address(RVA = "0x2F27800", Offset = "0x2F26C00", Length = "0x7")]
		[Token(Token = "0x6000099")]
		 set { } //Length: 7
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("openClipPreExtrapolation has been deprecated. Use infiniteClipPreExtrapolation instead. (UnityUpgradable) -> infiniteClipPreExtrapolation", True)]
	[Token(Token = "0x1700002B")]
	public ClipExtrapolation openClipPreExtrapolation
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 7
		[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
		[Token(Token = "0x6000097")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700001E")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F27620", Offset = "0x2F26A20", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__49))]
		[Token(Token = "0x6000060")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000014")]
	public Vector3 position
	{
		[Address(RVA = "0x2F276A0", Offset = "0x2F26AA0", Length = "0x19")]
		[Token(Token = "0x600004B")]
		 get { } //Length: 25
		[Address(RVA = "0x2F27920", Offset = "0x2F26D20", Length = "0x16")]
		[Token(Token = "0x600004C")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000015")]
	public Quaternion rotation
	{
		[Address(RVA = "0x2F276C0", Offset = "0x2F26AC0", Length = "0x6D")]
		[Token(Token = "0x600004D")]
		 get { } //Length: 109
		[Address(RVA = "0x2F27940", Offset = "0x2F26D40", Length = "0x7F")]
		[Token(Token = "0x600004E")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000018")]
	public TrackOffset trackOffset
	{
		[Address(RVA = "0x2F27730", Offset = "0x2F26B30", Length = "0x7")]
		[Token(Token = "0x6000053")]
		 get { } //Length: 7
		[Address(RVA = "0x2F279C0", Offset = "0x2F26DC0", Length = "0x7")]
		[Token(Token = "0x6000054")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x2F272A0", Offset = "0x2F266A0", Length = "0x89")]
	[Token(Token = "0x600009C")]
	private static AnimationTrack() { }

	[Address(RVA = "0x2F27330", Offset = "0x2F26730", Length = "0x1F5")]
	[Token(Token = "0x600009B")]
	public AnimationTrack() { }

	[Address(RVA = "0x2F23B10", Offset = "0x2F22F10", Length = "0x2B4")]
	[Token(Token = "0x600008E")]
	internal bool AnimatesRootTransform() { }

	[Address(RVA = "0x2F23DD0", Offset = "0x2F231D0", Length = "0x1FF")]
	[Token(Token = "0x6000085")]
	private Playable ApplyTrackOffset(PlayableGraph graph, Playable root, GameObject go, AppliedOffsetMode mode) { }

	[Address(RVA = "0x2F23FD0", Offset = "0x2F233D0", Length = "0x2CF")]
	[Token(Token = "0x6000088")]
	private void AssignAnimationClip(TimelineClip clip, AnimationClip animClip) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600007D")]
	private void AttachDefaultBlend(PlayableGraph graph, AnimationLayerMixerPlayable mixer, bool requireOffset) { }

	[Address(RVA = "0x2F242A0", Offset = "0x2F236A0", Length = "0x15A")]
	[Token(Token = "0x600007E")]
	private Playable AttachOffsetPlayable(PlayableGraph graph, Playable playable, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2F24400", Offset = "0x2F23800", Length = "0xE1")]
	[Token(Token = "0x6000077")]
	protected private virtual int CalculateItemsHash() { }

	[Address(RVA = "0x2F244F0", Offset = "0x2F238F0", Length = "0xB0")]
	[Token(Token = "0x600005F")]
	internal virtual bool CanCompileClips() { }

	[Address(RVA = "0x2F245B0", Offset = "0x2F239B0", Length = "0x4D6")]
	[Token(Token = "0x6000079")]
	private Playable CompileTrackPlayable(PlayableGraph graph, AnimationTrack track, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	[Address(RVA = "0x2F24A90", Offset = "0x2F23E90", Length = "0xA6")]
	[Token(Token = "0x6000073")]
	public TimelineClip CreateClip(AnimationClip clip) { }

	[Address(RVA = "0x2F24B40", Offset = "0x2F23F40", Length = "0x88")]
	[Token(Token = "0x6000083")]
	private static AnimationLayerMixerPlayable CreateGroupMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x2F24BD0", Offset = "0x2F23FD0", Length = "0x127")]
	[Token(Token = "0x6000074")]
	public void CreateInfiniteClip(string infiniteClipName) { }

	[Address(RVA = "0x2F24D00", Offset = "0x2F24100", Length = "0x409")]
	[Token(Token = "0x6000084")]
	private Playable CreateInfiniteTrackPlayable(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree, AppliedOffsetMode mode) { }

	[Address(RVA = "0x2F25110", Offset = "0x2F24510", Length = "0x924")]
	[Token(Token = "0x600007B")]
	internal virtual Playable CreateMixerPlayableGraph(PlayableGraph graph, GameObject go, IntervalTree<RuntimeElement> tree) { }

	[Address(RVA = "0x2F25A40", Offset = "0x2F24E40", Length = "0x1C1")]
	[Token(Token = "0x6000075")]
	public TimelineClip CreateRecordableClip(string animClipName) { }

	[Address(RVA = "0x2F25C10", Offset = "0x2F25010", Length = "0x1F4")]
	[Token(Token = "0x600008F")]
	private static Transform FindInHierarchyBreadthFirst(Transform t, string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000089")]
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x2EF4600", Offset = "0x2EF3A00", Length = "0x8")]
	[Token(Token = "0x600005D")]
	public bool get_applyAvatarMask() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000051")]
	public bool get_applyOffsets() { }

	[Address(RVA = "0xE265E0", Offset = "0xE259E0", Length = "0x8")]
	[Token(Token = "0x600005B")]
	public AvatarMask get_avatarMask() { }

	[Address(RVA = "0x2F27530", Offset = "0x2F26930", Length = "0x19")]
	[Token(Token = "0x600004F")]
	public Vector3 get_eulerAngles() { }

	[Address(RVA = "0x2F27550", Offset = "0x2F26950", Length = "0x3C")]
	[Token(Token = "0x6000061")]
	public bool get_inClipMode() { }

	[Address(RVA = "0x1CF27C0", Offset = "0x1CF1BC0", Length = "0x8")]
	[Token(Token = "0x6000057")]
	public AnimationClip get_infiniteClip() { }

	[Address(RVA = "0x2F27590", Offset = "0x2F26990", Length = "0x8")]
	[Token(Token = "0x6000068")]
	internal bool get_infiniteClipApplyFootIK() { }

	[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
	[Token(Token = "0x6000070")]
	internal LoopMode get_infiniteClipLoop() { }

	[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
	[Token(Token = "0x6000066")]
	public Vector3 get_infiniteClipOffsetEulerAngles() { }

	[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
	[Token(Token = "0x6000062")]
	public Vector3 get_infiniteClipOffsetPosition() { }

	[Address(RVA = "0x2F275A0", Offset = "0x2F269A0", Length = "0x6D")]
	[Token(Token = "0x6000064")]
	public Quaternion get_infiniteClipOffsetRotation() { }

	[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
	[Token(Token = "0x600006E")]
	public ClipExtrapolation get_infiniteClipPostExtrapolation() { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x600006C")]
	public ClipExtrapolation get_infiniteClipPreExtrapolation() { }

	[Address(RVA = "0x1D239B0", Offset = "0x1D22DB0", Length = "0x8")]
	[Token(Token = "0x6000059")]
	internal bool get_infiniteClipRemoveOffset() { }

	[Address(RVA = "0x2F27610", Offset = "0x2F26A10", Length = "0x9")]
	[Token(Token = "0x600006A")]
	internal double get_infiniteClipTimeOffset() { }

	[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
	[Token(Token = "0x6000055")]
	public MatchTargetFields get_matchTargetFields() { }

	[Address(RVA = "0xE26920", Offset = "0xE25D20", Length = "0x19")]
	[Token(Token = "0x6000094")]
	public Vector3 get_openClipOffsetEulerAngles() { }

	[Address(RVA = "0xE26960", Offset = "0xE25D60", Length = "0x19")]
	[Token(Token = "0x6000090")]
	public Vector3 get_openClipOffsetPosition() { }

	[Address(RVA = "0x2F275A0", Offset = "0x2F269A0", Length = "0x6D")]
	[Token(Token = "0x6000092")]
	public Quaternion get_openClipOffsetRotation() { }

	[Address(RVA = "0x240F970", Offset = "0x240ED70", Length = "0x7")]
	[Token(Token = "0x6000098")]
	public ClipExtrapolation get_openClipPostExtrapolation() { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x6000096")]
	public ClipExtrapolation get_openClipPreExtrapolation() { }

	[Address(RVA = "0x2F27620", Offset = "0x2F26A20", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__49))]
	[Token(Token = "0x6000060")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x2F276A0", Offset = "0x2F26AA0", Length = "0x19")]
	[Token(Token = "0x600004B")]
	public Vector3 get_position() { }

	[Address(RVA = "0x2F276C0", Offset = "0x2F26AC0", Length = "0x6D")]
	[Token(Token = "0x600004D")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x2F27730", Offset = "0x2F26B30", Length = "0x7")]
	[Token(Token = "0x6000053")]
	public TrackOffset get_trackOffset() { }

	[Address(RVA = "0x2F25E10", Offset = "0x2F25210", Length = "0x49D")]
	[Token(Token = "0x600008A")]
	private void GetAnimationClips(List<AnimationClip> animClips) { }

	[Address(RVA = "0x2F262B0", Offset = "0x2F256B0", Length = "0x1E2")]
	[Token(Token = "0x6000082")]
	internal Animator GetBinding(PlayableDirector director) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600007C")]
	private int GetDefaultBlendCount() { }

	[Address(RVA = "0x2F264A0", Offset = "0x2F258A0", Length = "0xC1")]
	[Token(Token = "0x6000086")]
	internal virtual void GetEvaluationTime(out double outStart, out double outDuration) { }

	[Address(RVA = "0x2F26570", Offset = "0x2F25970", Length = "0x1D3")]
	[Token(Token = "0x600008D")]
	private Transform GetGenericRootNode(GameObject gameObject) { }

	[Address(RVA = "0x2F26750", Offset = "0x2F25B50", Length = "0x1F0")]
	[Token(Token = "0x600008B")]
	private AppliedOffsetMode GetOffsetMode(GameObject go, bool animatesRootTransform) { }

	[Address(RVA = "0x2F26950", Offset = "0x2F25D50", Length = "0x121")]
	[Token(Token = "0x6000087")]
	internal virtual void GetSequenceTime(out double outStart, out double outDuration) { }

	[Address(RVA = "0x2F26A80", Offset = "0x2F25E80", Length = "0x108")]
	[Token(Token = "0x6000081")]
	private bool HasController(GameObject gameObject) { }

	[Address(RVA = "0x2F26B90", Offset = "0x2F25F90", Length = "0x286")]
	[Token(Token = "0x600008C")]
	private bool IsRootTransformDisabledByMask(GameObject gameObject, Transform genericRootNode) { }

	[Address(RVA = "0x2F26E20", Offset = "0x2F26220", Length = "0x6A")]
	[Token(Token = "0x6000076")]
	protected virtual void OnCreateClip(TimelineClip clip) { }

	[Address(RVA = "0x2F26E90", Offset = "0x2F26290", Length = "0x1FA")]
	[Token(Token = "0x600009A")]
	internal virtual void OnUpgradeFromVersion(int oldVersion) { }

	[Address(RVA = "0x2F27090", Offset = "0x2F26490", Length = "0x10D")]
	[Token(Token = "0x600007F")]
	private bool RequiresMotionXPlayable(AppliedOffsetMode mode, GameObject gameObject) { }

	[Address(RVA = "0x2F271A0", Offset = "0x2F265A0", Length = "0x8D")]
	[ContextMenu("Reset Offsets")]
	[Token(Token = "0x6000072")]
	private void ResetOffsets() { }

	[Address(RVA = "0x2F27740", Offset = "0x2F26B40", Length = "0x7")]
	[Token(Token = "0x600005E")]
	public void set_applyAvatarMask(bool value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000052")]
	public void set_applyOffsets(bool value) { }

	[Address(RVA = "0xE26C30", Offset = "0xE26030", Length = "0x13")]
	[Token(Token = "0x600005C")]
	public void set_avatarMask(AvatarMask value) { }

	[Address(RVA = "0x2F27750", Offset = "0x2F26B50", Length = "0x16")]
	[Token(Token = "0x6000050")]
	public void set_eulerAngles(Vector3 value) { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[Token(Token = "0x6000058")]
	internal void set_infiniteClip(AnimationClip value) { }

	[Address(RVA = "0x2F27770", Offset = "0x2F26B70", Length = "0x7")]
	[Token(Token = "0x6000069")]
	internal void set_infiniteClipApplyFootIK(bool value) { }

	[Address(RVA = "0x29E0BE0", Offset = "0x29DFFE0", Length = "0x7")]
	[Token(Token = "0x6000071")]
	internal void set_infiniteClipLoop(LoopMode value) { }

	[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
	[Token(Token = "0x6000067")]
	public void set_infiniteClipOffsetEulerAngles(Vector3 value) { }

	[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
	[Token(Token = "0x6000063")]
	public void set_infiniteClipOffsetPosition(Vector3 value) { }

	[Address(RVA = "0x2F27780", Offset = "0x2F26B80", Length = "0x7F")]
	[Token(Token = "0x6000065")]
	public void set_infiniteClipOffsetRotation(Quaternion value) { }

	[Address(RVA = "0x2F27800", Offset = "0x2F26C00", Length = "0x7")]
	[Token(Token = "0x600006F")]
	public void set_infiniteClipPostExtrapolation(ClipExtrapolation value) { }

	[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
	[Token(Token = "0x600006D")]
	public void set_infiniteClipPreExtrapolation(ClipExtrapolation value) { }

	[Address(RVA = "0x29E0AA0", Offset = "0x29DFEA0", Length = "0x7")]
	[Token(Token = "0x600005A")]
	internal void set_infiniteClipRemoveOffset(bool value) { }

	[Address(RVA = "0x2F27810", Offset = "0x2F26C10", Length = "0x9")]
	[Token(Token = "0x600006B")]
	internal void set_infiniteClipTimeOffset(double value) { }

	[Address(RVA = "0x2F27820", Offset = "0x2F26C20", Length = "0x66")]
	[Token(Token = "0x6000056")]
	public void set_matchTargetFields(MatchTargetFields value) { }

	[Address(RVA = "0xE265F0", Offset = "0xE259F0", Length = "0x16")]
	[Token(Token = "0x6000095")]
	public void set_openClipOffsetEulerAngles(Vector3 value) { }

	[Address(RVA = "0xE26DA0", Offset = "0xE261A0", Length = "0x16")]
	[Token(Token = "0x6000091")]
	public void set_openClipOffsetPosition(Vector3 value) { }

	[Address(RVA = "0x2F27890", Offset = "0x2F26C90", Length = "0x8C")]
	[Token(Token = "0x6000093")]
	public void set_openClipOffsetRotation(Quaternion value) { }

	[Address(RVA = "0x2F27800", Offset = "0x2F26C00", Length = "0x7")]
	[Token(Token = "0x6000099")]
	public void set_openClipPostExtrapolation(ClipExtrapolation value) { }

	[Address(RVA = "0x1D639B0", Offset = "0x1D62DB0", Length = "0x7")]
	[Token(Token = "0x6000097")]
	public void set_openClipPreExtrapolation(ClipExtrapolation value) { }

	[Address(RVA = "0x2F27920", Offset = "0x2F26D20", Length = "0x16")]
	[Token(Token = "0x600004C")]
	public void set_position(Vector3 value) { }

	[Address(RVA = "0x2F27940", Offset = "0x2F26D40", Length = "0x7F")]
	[Token(Token = "0x600004E")]
	public void set_rotation(Quaternion value) { }

	[Address(RVA = "0x2F279C0", Offset = "0x2F26DC0", Length = "0x7")]
	[Token(Token = "0x6000054")]
	public void set_trackOffset(TrackOffset value) { }

	[Address(RVA = "0x2F27230", Offset = "0x2F26630", Length = "0x55")]
	[Token(Token = "0x600007A")]
	private override Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000078")]
	internal void UpdateClipOffsets() { }

	[Address(RVA = "0x2F27290", Offset = "0x2F26690", Length = "0xF")]
	[Token(Token = "0x6000080")]
	private static bool UsesAbsoluteMotion(AppliedOffsetMode mode) { }

}

