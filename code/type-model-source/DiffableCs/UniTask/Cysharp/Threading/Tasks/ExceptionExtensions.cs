namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x200002F")]
public static class ExceptionExtensions
{

	[Address(RVA = "0x2734710", Offset = "0x2733B10", Length = "0x71")]
	[Extension]
	[Token(Token = "0x6000109")]
	public static bool IsOperationCanceledException(Exception exception) { }

}

