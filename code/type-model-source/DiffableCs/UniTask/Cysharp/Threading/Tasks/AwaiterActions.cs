namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000E9")]
internal static class AwaiterActions
{
	[Token(Token = "0x4000397")]
	internal static readonly Action<Object> InvokeContinuationDelegate; //Field offset: 0x0

	[Address(RVA = "0x272F1F0", Offset = "0x272E5F0", Length = "0x89")]
	[Token(Token = "0x60005F3")]
	private static AwaiterActions() { }

	[Address(RVA = "0x272F180", Offset = "0x272E580", Length = "0x6A")]
	[DebuggerHidden]
	[Token(Token = "0x60005F2")]
	private static void Continuation(object state) { }

}

