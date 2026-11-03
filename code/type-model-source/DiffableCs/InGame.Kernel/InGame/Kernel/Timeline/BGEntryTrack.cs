namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CF")]
[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(BGEntryClip))]
public class BGEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D30C40", Offset = "0x1D30040", Length = "0x49")]
	[Token(Token = "0x6000720")]
	public BGEntryTrack() { }

	[Address(RVA = "0x1D308C0", Offset = "0x1D2FCC0", Length = "0x37C")]
	[Token(Token = "0x600071F")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

