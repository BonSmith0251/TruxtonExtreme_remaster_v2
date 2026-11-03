namespace UnityEngine.Playables;

[Token(Token = "0x2000003")]
internal interface IDataPlayer
{

	[Token(Token = "0x6000004")]
	public void Bind(DataPlayableOutput output) { }

	[Token(Token = "0x6000005")]
	public void Release(DataPlayableOutput output) { }

}

