namespace UnityEngine.Timeline;

[Token(Token = "0x2000050")]
public interface ILayerable
{

	[Token(Token = "0x60002BF")]
	public Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

