namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000106")]
internal static class UniTaskCompletionSourceCoreShared
{
	[Token(Token = "0x40003CC")]
	internal static readonly Action<Object> s_sentinel; //Field offset: 0x0

	[Address(RVA = "0x27412D0", Offset = "0x27406D0", Length = "0x89")]
	[Token(Token = "0x600065C")]
	private static UniTaskCompletionSourceCoreShared() { }

	[Address(RVA = "0x2741280", Offset = "0x2740680", Length = "0x4E")]
	[Token(Token = "0x600065B")]
	private static void CompletionSentinel(object _) { }

}

