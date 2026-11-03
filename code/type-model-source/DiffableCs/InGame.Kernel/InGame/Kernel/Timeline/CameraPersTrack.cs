namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000DC")]
[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(CameraPersClip))]
public class CameraPersTrack : TrackAsset
{

	[Address(RVA = "0x1D32190", Offset = "0x1D31590", Length = "0x49")]
	[Token(Token = "0x600074A")]
	public CameraPersTrack() { }

	[Address(RVA = "0x1D320D0", Offset = "0x1D314D0", Length = "0xB3")]
	[Token(Token = "0x6000749")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

