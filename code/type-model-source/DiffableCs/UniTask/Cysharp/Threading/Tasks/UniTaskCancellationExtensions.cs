namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000074")]
public static class UniTaskCancellationExtensions
{

	[Address(RVA = "0x2741250", Offset = "0x2740650", Length = "0x23")]
	[Extension]
	[Token(Token = "0x6000191")]
	public static CancellationToken GetCancellationTokenOnDestroy(GameObject gameObject) { }

	[Address(RVA = "0x2741220", Offset = "0x2740620", Length = "0x23")]
	[Extension]
	[Token(Token = "0x6000192")]
	public static CancellationToken GetCancellationTokenOnDestroy(Component component) { }

}

