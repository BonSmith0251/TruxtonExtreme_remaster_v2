namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D2")]
public class BGMEntryClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005F0")]
	[Tooltip("アーケードでの順番")]
	private PlayStage _stageKind; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40005F1")]
	private PlaySection _sectionKind; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F2")]
	private TimelineClip _timelineClip; //Field offset: 0x20

	[Token(Token = "0x17000153")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
		[Token(Token = "0x600072D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x6000730")]
	public BGMEntryClip() { }

	[Address(RVA = "0x1D314E0", Offset = "0x1D308E0", Length = "0x12A")]
	[Token(Token = "0x600072E")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
	[Token(Token = "0x600072D")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600072F")]
	public void Set(TimelineClip tc) { }

}

