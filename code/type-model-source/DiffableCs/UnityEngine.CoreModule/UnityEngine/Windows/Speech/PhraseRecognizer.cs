namespace UnityEngine.Windows.Speech;

[Token(Token = "0x2000210")]
public abstract class PhraseRecognizer
{
	[Token(Token = "0x2000211")]
	internal sealed class PhraseRecognizedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1B5D080", Offset = "0x1B5C480", Length = "0xA6")]
		[Token(Token = "0x600175B")]
		public PhraseRecognizedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0xE2BD70", Offset = "0xE2B170", Length = "0x38")]
		[Token(Token = "0x600175C")]
		public override void Invoke(PhraseRecognizedEventArgs args) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000743")]
	protected IntPtr m_Recognizer; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000744")]
	private PhraseRecognizedDelegate OnPhraseRecognized; //Field offset: 0x18

	[Address(RVA = "0x307BA70", Offset = "0x307AE70", Length = "0x177")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001759")]
	private void InvokePhraseRecognizedEvent(IntPtr rawText, int rawTextLength, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[Address(RVA = "0x307BBF0", Offset = "0x307AFF0", Length = "0x239")]
	[RequiredByNativeCode]
	[Token(Token = "0x600175A")]
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

