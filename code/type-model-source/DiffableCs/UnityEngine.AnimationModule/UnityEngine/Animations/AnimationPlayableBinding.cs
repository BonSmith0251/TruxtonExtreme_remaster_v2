namespace UnityEngine.Animations;

[Token(Token = "0x2000028")]
public static class AnimationPlayableBinding
{

	[Address(RVA = "0x2FB29E0", Offset = "0x2FB1DE0", Length = "0x11B")]
	[Token(Token = "0x6000222")]
	public static PlayableBinding Create(string name, object key) { }

	[Address(RVA = "0x2FB2970", Offset = "0x2FB1D70", Length = "0x65")]
	[Token(Token = "0x6000223")]
	private static PlayableOutput CreateAnimationOutput(PlayableGraph graph, string name) { }

}

