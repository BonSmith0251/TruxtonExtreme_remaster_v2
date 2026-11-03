namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D4")]
[TrackClipType(typeof(BGMEntryClip))]
public class BGMEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D31930", Offset = "0x1D30D30", Length = "0x49")]
	[Token(Token = "0x6000734")]
	public BGMEntryTrack() { }

	[Address(RVA = "0x1D31620", Offset = "0x1D30A20", Length = "0x30A")]
	[Token(Token = "0x6000733")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

