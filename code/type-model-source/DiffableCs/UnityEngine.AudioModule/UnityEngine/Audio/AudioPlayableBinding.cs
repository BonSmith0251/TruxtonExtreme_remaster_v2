namespace UnityEngine.Audio;

[Token(Token = "0x200002B")]
public static class AudioPlayableBinding
{

	[Address(RVA = "0x2FC7F70", Offset = "0x2FC7370", Length = "0x11B")]
	[Token(Token = "0x60000C0")]
	public static PlayableBinding Create(string name, object key) { }

	[Address(RVA = "0x2FC7F00", Offset = "0x2FC7300", Length = "0x65")]
	[Token(Token = "0x60000C1")]
	private static PlayableOutput CreateAudioOutput(PlayableGraph graph, string name) { }

}

