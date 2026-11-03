namespace UnityEngine.Rendering;

[Token(Token = "0x2000055")]
public static class GenericPool
{
	[Token(Token = "0x4000142")]
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[Address(RVA = "0x1C3F430", Offset = "0x1C3E830", Length = "0x103")]
	[Token(Token = "0x6000529")]
	private static GenericPool`1() { }

	[Address(RVA = "0xB0CBD0", Offset = "0xB0BFD0", Length = "0xC6")]
	[Token(Token = "0x6000526")]
	public static T Get() { }

	[Address(RVA = "0xB0C890", Offset = "0xB0BC90", Length = "0xF4")]
	[Token(Token = "0x6000527")]
	public static PooledObject<T> Get(out T value) { }

	[Address(RVA = "0xB0CCA0", Offset = "0xB0C0A0", Length = "0xD6")]
	[Token(Token = "0x6000528")]
	public static void Release(T toRelease) { }

}

