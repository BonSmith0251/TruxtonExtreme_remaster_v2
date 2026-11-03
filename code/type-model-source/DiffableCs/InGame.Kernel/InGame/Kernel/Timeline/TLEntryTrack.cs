namespace InGame.Kernel.Timeline;

[Token(Token = "0x2000104")]
[TrackClipType(typeof(TLEntryClip))]
public class TLEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D53790", Offset = "0x1D52B90", Length = "0x49")]
	[Token(Token = "0x600080C")]
	public TLEntryTrack() { }

	[Address(RVA = "0x1D53470", Offset = "0x1D52870", Length = "0x315")]
	[Token(Token = "0x600080B")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

