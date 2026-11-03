namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x200032D")]
public struct ScriptPlayableOutput : IPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400084E")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x170003B5")]
	public static ScriptPlayableOutput Null
	{
		[Address(RVA = "0x3088AC0", Offset = "0x3087EC0", Length = "0xB2")]
		[Token(Token = "0x60019C2")]
		 get { } //Length: 178
	}

	[Address(RVA = "0x30889C0", Offset = "0x3087DC0", Length = "0xF6")]
	[Token(Token = "0x60019C1")]
	internal ScriptPlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x30888D0", Offset = "0x3087CD0", Length = "0xEF")]
	[Token(Token = "0x60019C0")]
	public static ScriptPlayableOutput Create(PlayableGraph graph, string name) { }

	[Address(RVA = "0x3088AC0", Offset = "0x3087EC0", Length = "0xB2")]
	[Token(Token = "0x60019C2")]
	public static ScriptPlayableOutput get_Null() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60019C3")]
	public override PlayableOutputHandle GetHandle() { }

	[Address(RVA = "0x3088B80", Offset = "0x3087F80", Length = "0xC")]
	[Token(Token = "0x60019C4")]
	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }

}

