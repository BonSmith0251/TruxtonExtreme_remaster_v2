namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x2000328")]
public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput>
{
	[Token(Token = "0x4000848")]
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000847")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x170003B2")]
	public static PlayableOutput Null
	{
		[Address(RVA = "0x307EBB0", Offset = "0x307DFB0", Length = "0x60")]
		[Token(Token = "0x6001987")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x307EB10", Offset = "0x307DF10", Length = "0x99")]
	[Token(Token = "0x600198C")]
	private static PlayableOutput() { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x6001988")]
	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x307EA30", Offset = "0x307DE30", Length = "0xD4")]
	[Token(Token = "0x600198B")]
	public override bool Equals(PlayableOutput other) { }

	[Address(RVA = "0x307EBB0", Offset = "0x307DFB0", Length = "0x60")]
	[Token(Token = "0x6001987")]
	public static PlayableOutput get_Null() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001989")]
	public override PlayableOutputHandle GetHandle() { }

	[Address(RVA = "0x8B14B0", Offset = "0x8B08B0", Length = "0x114")]
	[Token(Token = "0x600198A")]
	public bool IsPlayableOutputOfType() { }

}

