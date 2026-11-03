namespace UnityEngine.Playables;

[Token(Token = "0x200031D")]
public interface IPlayableAsset
{

	[Token(Token = "0x170003AD")]
	public double duration
	{
		[Token(Token = "0x6001908")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001907")]
	public Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Token(Token = "0x6001908")]
	public double get_duration() { }

}

