namespace UnityEngine.VFX;

[Token(Token = "0x200002E")]
[TrackBindingType(typeof(VisualEffect))]
[TrackClipType(typeof(VisualEffectControlClip))]
[TrackColor(0.5990566, 0.9038978, 1)]
internal class VisualEffectControlTrack : TrackAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private sealed class <>c
	{
		[Token(Token = "0x4000098")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000099")]
		public static Func<TimelineClip, Boolean> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x2F72570", Offset = "0x2F71970", Length = "0x67")]
		[Token(Token = "0x6000087")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000088")]
		public <>c() { }

		[Address(RVA = "0x2F721B0", Offset = "0x2F715B0", Length = "0x7F")]
		[Token(Token = "0x6000089")]
		internal bool <OnBeforeTrackSerialize>b__5_0(TimelineClip x) { }

	}

	[Token(Token = "0x200002F")]
	internal enum ReinitMode : int
	{
		None = 0,
		OnBindingEnable = 1,
		OnBindingDisable = 2,
		OnBindingEnableOrDisable = 3,
	}

	[Token(Token = "0x4000090")]
	private const int kCurrentVersion = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000091")]
	private int m_VFXVersion; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[NotKeyable]
	[SerializeField]
	[Token(Token = "0x4000092")]
	public ReinitMode reinit; //Field offset: 0xA4

	[Address(RVA = "0x2F7D640", Offset = "0x2F7CA40", Length = "0x53")]
	[Token(Token = "0x6000086")]
	public VisualEffectControlTrack() { }

	[Address(RVA = "0x2F7D0B0", Offset = "0x2F7C4B0", Length = "0x386")]
	[Token(Token = "0x6000084")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x2F7D440", Offset = "0x2F7C840", Length = "0x9D")]
	[Token(Token = "0x6000085")]
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x2F7D4E0", Offset = "0x2F7C8E0", Length = "0xB")]
	[Token(Token = "0x6000082")]
	public bool IsUpToDate() { }

	[Address(RVA = "0x2F7D4F0", Offset = "0x2F7C8F0", Length = "0x144")]
	[Token(Token = "0x6000083")]
	protected virtual void OnBeforeTrackSerialize() { }

}

