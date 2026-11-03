namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200003C")]
internal static class GlobalLinkedListNodeCache
{
	[Token(Token = "0x4000099")]
	private static LinkedListNodeCache<T> m_globalCache; //Field offset: 0x0

	[Token(Token = "0x17000029")]
	public static bool CacheExists
	{
		[Address(RVA = "0x1C40B50", Offset = "0x1C3FF50", Length = "0x48")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x1C401F0", Offset = "0x1C3F5F0", Length = "0x1B5")]
	[Token(Token = "0x600015C")]
	public static LinkedListNode<T> Acquire(T val) { }

	[Address(RVA = "0x1C40B50", Offset = "0x1C3FF50", Length = "0x48")]
	[Token(Token = "0x600015A")]
	public static bool get_CacheExists() { }

	[Address(RVA = "0x1C403B0", Offset = "0x1C3F7B0", Length = "0x1B5")]
	[Token(Token = "0x600015D")]
	public static void Release(LinkedListNode<T> node) { }

	[Address(RVA = "0x1C40990", Offset = "0x1C3FD90", Length = "0x1B3")]
	[Token(Token = "0x600015B")]
	public static void SetCacheSize(int length) { }

}

