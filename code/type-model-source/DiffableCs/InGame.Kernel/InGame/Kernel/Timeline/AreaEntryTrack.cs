namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000CB")]
[TrackClipType(typeof(AreaEntryClip))]
[TrackColor(0, 0, 1)]
public class AreaEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D30660", Offset = "0x1D2FA60", Length = "0x49")]
	[Token(Token = "0x6000713")]
	public AreaEntryTrack() { }

	[Address(RVA = "0x1D305A0", Offset = "0x1D2F9A0", Length = "0xB3")]
	[Token(Token = "0x6000712")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

