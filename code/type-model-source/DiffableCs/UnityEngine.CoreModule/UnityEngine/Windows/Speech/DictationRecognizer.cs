namespace UnityEngine.Windows.Speech;

[Token(Token = "0x2000212")]
public sealed class DictationRecognizer
{
	[Token(Token = "0x2000215")]
	internal sealed class DictationCompletedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6001765")]
		public DictationCompletedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001766")]
		public override void Invoke(DictationCompletionCause cause) { }

	}

	[Token(Token = "0x2000216")]
	internal sealed class DictationErrorHandler : MulticastDelegate
	{

		[Address(RVA = "0x22D3640", Offset = "0x22D2A40", Length = "0xB5")]
		[Token(Token = "0x6001767")]
		public DictationErrorHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6001768")]
		public override void Invoke(string error, int hresult) { }

	}

	[Token(Token = "0x2000213")]
	internal sealed class DictationHypothesisDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6001761")]
		public DictationHypothesisDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001762")]
		public override void Invoke(string text) { }

	}

	[Token(Token = "0x2000214")]
	internal sealed class DictationResultDelegate : MulticastDelegate
	{

		[Address(RVA = "0x22D3640", Offset = "0x22D2A40", Length = "0xB5")]
		[Token(Token = "0x6001763")]
		public DictationResultDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6001764")]
		public override void Invoke(string text, ConfidenceLevel confidence) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000745")]
	private IntPtr m_Recognizer; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000746")]
	private DictationHypothesisDelegate DictationHypothesis; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000747")]
	private DictationResultDelegate DictationResult; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000748")]
	private DictationCompletedDelegate DictationComplete; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000749")]
	private DictationErrorHandler DictationError; //Field offset: 0x30

	[Address(RVA = "0x3078760", Offset = "0x3077B60", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x600175F")]
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[Address(RVA = "0x3078780", Offset = "0x3077B80", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001760")]
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

	[Address(RVA = "0x30787A0", Offset = "0x3077BA0", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x600175D")]
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(IntPtr keyword, int keywordLength) { }

	[Address(RVA = "0x3078800", Offset = "0x3077C00", Length = "0x69")]
	[RequiredByNativeCode]
	[Token(Token = "0x600175E")]
	private void DictationRecognizer_InvokeResultGeneratedEvent(IntPtr keyword, int keywordLength, ConfidenceLevel minimumConfidence) { }

}

