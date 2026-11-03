namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000EF")]
[TrackClipType(typeof(EnemyWaveClip))]
[TrackColor(0, 0, 0.5)]
public class EnemyWaveTrack : TrackAsset
{

	[Address(RVA = "0x1D36B60", Offset = "0x1D35F60", Length = "0x49")]
	[Token(Token = "0x60007AD")]
	public EnemyWaveTrack() { }

	[Address(RVA = "0x1D36AA0", Offset = "0x1D35EA0", Length = "0xB3")]
	[Token(Token = "0x60007AC")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

