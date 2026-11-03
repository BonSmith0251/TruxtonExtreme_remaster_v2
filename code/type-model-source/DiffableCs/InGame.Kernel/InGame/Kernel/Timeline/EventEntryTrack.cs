namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F4")]
[TrackBindingType(typeof(Transform))]
[TrackClipType(typeof(EventEntryClip))]
[TrackColor(50, 205, 50)]
public class EventEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D377E0", Offset = "0x1D36BE0", Length = "0x49")]
	[Token(Token = "0x60007C8")]
	public EventEntryTrack() { }

	[Address(RVA = "0x1D37720", Offset = "0x1D36B20", Length = "0xB3")]
	[Token(Token = "0x60007C7")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

