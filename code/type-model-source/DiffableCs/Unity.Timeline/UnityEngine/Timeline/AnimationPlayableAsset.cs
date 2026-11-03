namespace UnityEngine.Timeline;

[NotKeyable]
[Token(Token = "0x200000A")]
public class AnimationPlayableAsset : PlayableAsset, ITimelineClipAsset, IPropertyPreview, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x200000E")]
	private sealed class <get_outputs>d__45 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000029")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002A")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400002B")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400002C")]
		public AnimationPlayableAsset <>4__this; //Field offset: 0x40

		[Token(Token = "0x17000012")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x6000040")]
			private get { } //Length: 19
		}

		[Token(Token = "0x17000013")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F3FAB0", Offset = "0x2F3EEB0", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x6000042")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600003D")]
		public <get_outputs>d__45(int <>1__state) { }

		[Address(RVA = "0x2F3F940", Offset = "0x2F3ED40", Length = "0x8D")]
		[Token(Token = "0x600003F")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3F9D0", Offset = "0x2F3EDD0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000043")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x6000040")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3F9D0", Offset = "0x2F3EDD0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000044")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F3FAB0", Offset = "0x2F3EEB0", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x6000042")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3FA70", Offset = "0x2F3EE70", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000041")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600003E")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200000D")]
	private static class AnimationPlayableAssetUpgrade
	{

		[Address(RVA = "0x2F224D0", Offset = "0x2F218D0", Length = "0x87")]
		[Token(Token = "0x600003C")]
		public static void ConvertRotationToEuler(AnimationPlayableAsset asset) { }

	}

	[Token(Token = "0x200000B")]
	internal enum LoopMode : int
	{
		UseSourceAsset = 0,
		On = 1,
		Off = 2,
	}

	[Token(Token = "0x200000C")]
	private enum Versions : int
	{
		Initial = 0,
		RotationAsEuler = 1,
	}

	[Token(Token = "0x400001F")]
	private static readonly int k_LatestVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000016")]
	private AnimationClip m_Clip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000017")]
	private Vector3 m_Position; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private Vector3 m_EulerAngles; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private bool m_UseTrackMatchFields; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private MatchTargetFields m_MatchTargetFields; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private bool m_RemoveStartOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private bool m_ApplyFootIK; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private LoopMode m_Loop; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001E")]
	private AppliedOffsetMode <appliedOffsetMode>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private int m_Version; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[Obsolete("Use m_RotationEuler Instead", False)]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private Quaternion m_Rotation; //Field offset: 0x50

	[Token(Token = "0x1700000D")]
	internal AppliedOffsetMode appliedOffsetMode
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		internal get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600002A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public bool applyFootIK
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 5
		[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
		[Token(Token = "0x6000025")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public AnimationClip clip
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F23380", Offset = "0x2F22780", Length = "0xAC")]
		[Token(Token = "0x600002C")]
		 set { } //Length: 172
	}

	[Token(Token = "0x17000011")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x2F230A0", Offset = "0x2F224A0", Length = "0xDA")]
		[Token(Token = "0x6000033")]
		 get { } //Length: 218
	}

	[Token(Token = "0x1700000F")]
	public virtual double duration
	{
		[Address(RVA = "0x2F23180", Offset = "0x2F22580", Length = "0x6F")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 111
	}

	[Token(Token = "0x17000006")]
	public Vector3 eulerAngles
	{
		[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 19
		[Address(RVA = "0x2F23430", Offset = "0x2F22830", Length = "0x10")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700000C")]
	internal bool hasRootTransforms
	{
		[Address(RVA = "0x2F231F0", Offset = "0x2F225F0", Length = "0x97")]
		[Token(Token = "0x6000028")]
		internal get { } //Length: 151
	}

	[Token(Token = "0x1700000B")]
	public LoopMode loop
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[Token(Token = "0x6000027")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public MatchTargetFields matchTargetFields
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F23290", Offset = "0x2F22690", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__45))]
		[Token(Token = "0x600002E")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000004")]
	public Vector3 position
	{
		[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 19
		[Address(RVA = "0x1D533E0", Offset = "0x1D527E0", Length = "0x10")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000009")]
	public bool removeStartOffset
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 5
		[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
		[Token(Token = "0x6000023")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000005")]
	public Quaternion rotation
	{
		[Address(RVA = "0x2F23310", Offset = "0x2F22710", Length = "0x67")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 103
		[Address(RVA = "0x2F23440", Offset = "0x2F22840", Length = "0x79")]
		[Token(Token = "0x600001B")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000007")]
	public bool useTrackMatchFields
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x600001F")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F22F50", Offset = "0x2F22350", Length = "0x39")]
	[Token(Token = "0x600003B")]
	private static AnimationPlayableAsset() { }

	[Address(RVA = "0x2F22F90", Offset = "0x2F22390", Length = "0x10C")]
	[Token(Token = "0x600003A")]
	public AnimationPlayableAsset() { }

	[Address(RVA = "0x2F22560", Offset = "0x2F21960", Length = "0x446")]
	[Token(Token = "0x6000030")]
	internal static Playable CreatePlayable(PlayableGraph graph, AnimationClip clip, Vector3 positionOffset, Vector3 eulerOffset, bool removeStartOffset, AppliedOffsetMode mode, bool applyFootIK, LoopMode loop) { }

	[Address(RVA = "0x2F229B0", Offset = "0x2F21DB0", Length = "0x12B")]
	[Token(Token = "0x600002F")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x2F22AE0", Offset = "0x2F21EE0", Length = "0xC3")]
	[Token(Token = "0x6000035")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000029")]
	internal AppliedOffsetMode get_appliedOffsetMode() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x6000024")]
	public bool get_applyFootIK() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600002B")]
	public AnimationClip get_clip() { }

	[Address(RVA = "0x2F230A0", Offset = "0x2F224A0", Length = "0xDA")]
	[Token(Token = "0x6000033")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x2F23180", Offset = "0x2F22580", Length = "0x6F")]
	[Token(Token = "0x600002D")]
	public virtual double get_duration() { }

	[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
	[Token(Token = "0x600001C")]
	public Vector3 get_eulerAngles() { }

	[Address(RVA = "0x2F231F0", Offset = "0x2F225F0", Length = "0x97")]
	[Token(Token = "0x6000028")]
	internal bool get_hasRootTransforms() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6000026")]
	public LoopMode get_loop() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000020")]
	public MatchTargetFields get_matchTargetFields() { }

	[Address(RVA = "0x2F23290", Offset = "0x2F22690", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__45))]
	[Token(Token = "0x600002E")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x1D53450", Offset = "0x1D52850", Length = "0x13")]
	[Token(Token = "0x6000018")]
	public Vector3 get_position() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000022")]
	public bool get_removeStartOffset() { }

	[Address(RVA = "0x2F23310", Offset = "0x2F22710", Length = "0x67")]
	[Token(Token = "0x600001A")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x600001E")]
	public bool get_useTrackMatchFields() { }

	[Address(RVA = "0x2F22BB0", Offset = "0x2F21FB0", Length = "0xAC")]
	[Token(Token = "0x6000036")]
	internal static bool HasRootTransforms(AnimationClip clip) { }

	[Address(RVA = "0x2F22C60", Offset = "0x2F22060", Length = "0x8F")]
	[Token(Token = "0x6000039")]
	private void OnUpgradeFromVersion(int oldVersion) { }

	[Address(RVA = "0x2F22CF0", Offset = "0x2F220F0", Length = "0x81")]
	[Token(Token = "0x6000034")]
	public void ResetOffsets() { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600002A")]
	internal void set_appliedOffsetMode(AppliedOffsetMode value) { }

	[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
	[Token(Token = "0x6000025")]
	public void set_applyFootIK(bool value) { }

	[Address(RVA = "0x2F23380", Offset = "0x2F22780", Length = "0xAC")]
	[Token(Token = "0x600002C")]
	public void set_clip(AnimationClip value) { }

	[Address(RVA = "0x2F23430", Offset = "0x2F22830", Length = "0x10")]
	[Token(Token = "0x600001D")]
	public void set_eulerAngles(Vector3 value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[Token(Token = "0x6000027")]
	public void set_loop(LoopMode value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x6000021")]
	public void set_matchTargetFields(MatchTargetFields value) { }

	[Address(RVA = "0x1D533E0", Offset = "0x1D527E0", Length = "0x10")]
	[Token(Token = "0x6000019")]
	public void set_position(Vector3 value) { }

	[Address(RVA = "0x11169B0", Offset = "0x1115DB0", Length = "0x4")]
	[Token(Token = "0x6000023")]
	public void set_removeStartOffset(bool value) { }

	[Address(RVA = "0x2F23440", Offset = "0x2F22840", Length = "0x79")]
	[Token(Token = "0x600001B")]
	public void set_rotation(Quaternion value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x600001F")]
	public void set_useTrackMatchFields(bool value) { }

	[Address(RVA = "0x2F22D80", Offset = "0x2F22180", Length = "0x6A")]
	[Token(Token = "0x6000031")]
	private static bool ShouldApplyOffset(AppliedOffsetMode mode, AnimationClip clip) { }

	[Address(RVA = "0x2F22DF0", Offset = "0x2F221F0", Length = "0x14")]
	[Token(Token = "0x6000032")]
	private static bool ShouldApplyScaleRemove(AppliedOffsetMode mode) { }

	[Address(RVA = "0x2F22E10", Offset = "0x2F22210", Length = "0xD5")]
	[Token(Token = "0x6000038")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2F22EF0", Offset = "0x2F222F0", Length = "0x56")]
	[Token(Token = "0x6000037")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

