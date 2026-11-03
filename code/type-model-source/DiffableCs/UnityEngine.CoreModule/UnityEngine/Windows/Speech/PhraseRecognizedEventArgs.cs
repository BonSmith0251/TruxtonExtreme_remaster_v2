namespace UnityEngine.Windows.Speech;

[Token(Token = "0x200021C")]
public struct PhraseRecognizedEventArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000769")]
	public readonly ConfidenceLevel confidence; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400076A")]
	public readonly SemanticMeaning[] semanticMeanings; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400076B")]
	public readonly string text; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400076C")]
	public readonly DateTime phraseStartTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400076D")]
	public readonly TimeSpan phraseDuration; //Field offset: 0x20

	[Address(RVA = "0x307BA10", Offset = "0x307AE10", Length = "0x59")]
	[Token(Token = "0x6001769")]
	internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}

