namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000139")]
public static class UniTaskScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x40004CE")]
	private static Action<Exception> UnobservedTaskException; //Field offset: 0x0
	[Token(Token = "0x40004CF")]
	public static bool PropagateOperationCanceledException; //Field offset: 0x8
	[Token(Token = "0x40004D0")]
	public static LogType UnobservedExceptionWriteLogType; //Field offset: 0xC
	[Token(Token = "0x40004D1")]
	public static bool DispatchUnityMainThread; //Field offset: 0x10
	[Token(Token = "0x40004D2")]
	private static readonly SendOrPostCallback handleExceptionInvoke; //Field offset: 0x18

	[Token(Token = "0x14000001")]
	public static event Action<Exception> UnobservedTaskException
	{
		[Address(RVA = "0x27483A0", Offset = "0x27477A0", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x600075B")]
		 add { } //Length: 257
		[Address(RVA = "0x27484B0", Offset = "0x27478B0", Length = "0x101")]
		[CompilerGenerated]
		[Token(Token = "0x600075C")]
		 remove { } //Length: 257
	}

	[Address(RVA = "0x27482D0", Offset = "0x27476D0", Length = "0xC7")]
	[Token(Token = "0x600075F")]
	private static UniTaskScheduler() { }

	[Address(RVA = "0x27483A0", Offset = "0x27477A0", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x600075B")]
	public static void add_UnobservedTaskException(Action<Exception> value) { }

	[Address(RVA = "0x2747E80", Offset = "0x2747280", Length = "0xB7")]
	[Token(Token = "0x600075D")]
	private static void InvokeUnobservedTaskException(object state) { }

	[Address(RVA = "0x2747F40", Offset = "0x2747340", Length = "0x386")]
	[Token(Token = "0x600075E")]
	internal static void PublishUnobservedTaskException(Exception ex) { }

	[Address(RVA = "0x27484B0", Offset = "0x27478B0", Length = "0x101")]
	[CompilerGenerated]
	[Token(Token = "0x600075C")]
	public static void remove_UnobservedTaskException(Action<Exception> value) { }

}

