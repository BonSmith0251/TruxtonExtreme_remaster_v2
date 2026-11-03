namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D8")]
[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(BGSlideRangeClip))]
public class BGSlideRangeTrack : TrackAsset
{

	[Address(RVA = "0x1D31D60", Offset = "0x1D31160", Length = "0x49")]
	[Token(Token = "0x600073F")]
	public BGSlideRangeTrack() { }

	[Address(RVA = "0x1D31CA0", Offset = "0x1D310A0", Length = "0xB3")]
	[Token(Token = "0x600073E")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

