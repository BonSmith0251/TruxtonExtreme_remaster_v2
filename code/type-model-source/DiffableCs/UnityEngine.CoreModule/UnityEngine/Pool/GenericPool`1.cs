namespace UnityEngine.Pool;

[Token(Token = "0x20002FF")]
public class GenericPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000300")]
	private sealed class <>c
	{
		[Token(Token = "0x40007EF")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600189E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600189F")]
		public <>c() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x60018A0")]
		internal T <.cctor>b__5_0() { }

	}

	[Token(Token = "0x40007EE")]
	internal static readonly ObjectPool<T> s_Pool; //Field offset: 0x0

	[Address(RVA = "0x1C3F1F0", Offset = "0x1C3E5F0", Length = "0x23D")]
	[Token(Token = "0x600189D")]
	private static GenericPool`1() { }

	[Address(RVA = "0x1C3EE90", Offset = "0x1C3E290", Length = "0x176")]
	[Token(Token = "0x600189A")]
	public static T Get() { }

	[Address(RVA = "0x16D2650", Offset = "0x16D1A50", Length = "0xF4")]
	[Token(Token = "0x600189B")]
	public static PooledObject<T> Get(out T value) { }

	[Address(RVA = "0x1C3F010", Offset = "0x1C3E410", Length = "0x1D4")]
	[Token(Token = "0x600189C")]
	public static void Release(T toRelease) { }

}

