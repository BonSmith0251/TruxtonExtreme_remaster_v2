namespace UnityEngine.Windows.Speech;

[Token(Token = "0x200020D")]
public static class PhraseRecognitionSystem
{
	[Token(Token = "0x200020E")]
	internal sealed class ErrorDelegate : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6001755")]
		public ErrorDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001756")]
		public override void Invoke(SpeechError errorCode) { }

	}

	[Token(Token = "0x200020F")]
	internal sealed class StatusDelegate : MulticastDelegate
	{

		[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
		[Token(Token = "0x6001757")]
		public StatusDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001758")]
		public override void Invoke(SpeechSystemStatus status) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000741")]
	private static ErrorDelegate OnError; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000742")]
	private static StatusDelegate OnStatusChanged; //Field offset: 0x8

	[Address(RVA = "0x307B950", Offset = "0x307AD50", Length = "0x56")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001753")]
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[Address(RVA = "0x307B9B0", Offset = "0x307ADB0", Length = "0x57")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001754")]
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

