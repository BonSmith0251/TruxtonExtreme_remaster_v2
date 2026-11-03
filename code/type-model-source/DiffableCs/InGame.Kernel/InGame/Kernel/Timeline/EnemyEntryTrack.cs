namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E9")]
[TrackBindingType(typeof(Transform))]
[TrackClipType(typeof(EnemyEntryClip))]
[TrackColor(1, 0, 0)]
public class EnemyEntryTrack : TrackAsset
{

	[Address(RVA = "0x1D355A0", Offset = "0x1D349A0", Length = "0x49")]
	[Token(Token = "0x6000794")]
	public EnemyEntryTrack() { }

	[Address(RVA = "0x1D351A0", Offset = "0x1D345A0", Length = "0x3F0")]
	[Token(Token = "0x6000792")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000793")]
	public bool IsEnemyEntry(string enemyName) { }

}

