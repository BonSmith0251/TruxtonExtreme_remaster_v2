namespace System.Threading.Tasks;

[Extension]
[Token(Token = "0x200025E")]
internal static class TaskAwaiters
{

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Extension]
	[Token(Token = "0x60013DC")]
	public static ForceAsyncAwaiter ForceAsync(Task task) { }

}

