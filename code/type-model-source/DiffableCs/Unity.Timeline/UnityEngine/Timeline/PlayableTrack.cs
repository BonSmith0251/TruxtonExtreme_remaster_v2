namespace UnityEngine.Timeline;

[Token(Token = "0x2000060")]
public class PlayableTrack : TrackAsset
{

	[Address(RVA = "0x2F42240", Offset = "0x2F41640", Length = "0x49")]
	[Token(Token = "0x600031D")]
	public PlayableTrack() { }

	[Address(RVA = "0x2F42180", Offset = "0x2F41580", Length = "0xB4")]
	[Token(Token = "0x600031C")]
	protected virtual void OnCreateClip(TimelineClip clip) { }

}

