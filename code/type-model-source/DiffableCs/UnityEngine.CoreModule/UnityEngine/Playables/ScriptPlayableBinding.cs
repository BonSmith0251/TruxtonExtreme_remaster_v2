namespace UnityEngine.Playables;

[Token(Token = "0x200032C")]
public static class ScriptPlayableBinding
{

	[Address(RVA = "0x3088730", Offset = "0x3087B30", Length = "0x199")]
	[Token(Token = "0x60019BE")]
	public static PlayableBinding Create(string name, object key, Type type) { }

	[Address(RVA = "0x3088630", Offset = "0x3087A30", Length = "0xF6")]
	[Token(Token = "0x60019BF")]
	private static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name) { }

}

