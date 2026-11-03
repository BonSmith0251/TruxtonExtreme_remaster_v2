namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x200003C")]
public static class UniTaskStatusExtensions
{

	[Address(RVA = "0x27485C0", Offset = "0x27479C0", Length = "0x7")]
	[Extension]
	[Token(Token = "0x6000126")]
	public static bool IsCanceled(UniTaskStatus status) { }

	[Address(RVA = "0x1F95350", Offset = "0x1F94750", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000124")]
	public static bool IsCompleted(UniTaskStatus status) { }

	[Address(RVA = "0x1DEAD40", Offset = "0x1DEA140", Length = "0x7")]
	[Extension]
	[Token(Token = "0x6000125")]
	public static bool IsCompletedSuccessfully(UniTaskStatus status) { }

	[Address(RVA = "0x27485D0", Offset = "0x27479D0", Length = "0x7")]
	[Extension]
	[Token(Token = "0x6000127")]
	public static bool IsFaulted(UniTaskStatus status) { }

}

