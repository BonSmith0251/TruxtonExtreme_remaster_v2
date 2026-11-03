namespace UnityEngine.Rendering;

[Token(Token = "0x2000056")]
public static class UnsafeGenericPool
{
	[Token(Token = "0x4000143")]
	private static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[Address(RVA = "0x11A5A50", Offset = "0x11A4E50", Length = "0x12D")]
	[Token(Token = "0x600052D")]
	private static UnsafeGenericPool`1() { }

	[Address(RVA = "0x11A5700", Offset = "0x11A4B00", Length = "0x170")]
	[Token(Token = "0x600052A")]
	public static T Get() { }

	[Address(RVA = "0x11A5570", Offset = "0x11A4970", Length = "0x186")]
	[Token(Token = "0x600052B")]
	public static PooledObject<T> Get(out T value) { }

	[Address(RVA = "0x11A5880", Offset = "0x11A4C80", Length = "0x1CF")]
	[Token(Token = "0x600052C")]
	public static void Release(T toRelease) { }

}

