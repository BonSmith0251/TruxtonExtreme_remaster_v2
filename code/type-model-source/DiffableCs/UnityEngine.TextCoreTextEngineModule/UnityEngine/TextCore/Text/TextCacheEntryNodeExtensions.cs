namespace UnityEngine.TextCore.Text;

[Extension]
[Token(Token = "0x2000062")]
internal static class TextCacheEntryNodeExtensions
{

	[Address(RVA = "0x31C3E50", Offset = "0x31C3250", Length = "0xFC")]
	[Extension]
	[Token(Token = "0x6000307")]
	public static void SetTextHandle(LinkedListNode<TextCacheEntry> node, TextHandle newTextHandle) { }

	[Address(RVA = "0x31C3F50", Offset = "0x31C3350", Length = "0x6E")]
	[Extension]
	[Token(Token = "0x6000306")]
	public static void SetTime(LinkedListNode<TextCacheEntry> node, float newTime) { }

}

