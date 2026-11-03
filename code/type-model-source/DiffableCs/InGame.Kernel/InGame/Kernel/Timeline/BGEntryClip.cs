namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CD")]
public class BGEntryClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E1")]
	private TimelineClip _timelineClip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005E2")]
	private GameObject _trackedObject; //Field offset: 0x20

	[Token(Token = "0x17000151")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000719")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600071C")]
	public BGEntryClip() { }

	[Address(RVA = "0x1D30750", Offset = "0x1D2FB50", Length = "0x115")]
	[Token(Token = "0x600071A")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000719")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1D30870", Offset = "0x1D2FC70", Length = "0x37")]
	[Token(Token = "0x600071B")]
	public void Set(TimelineClip tc, GameObject tobj) { }

}

