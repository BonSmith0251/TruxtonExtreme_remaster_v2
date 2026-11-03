namespace UnityEngine.Pool;

[Token(Token = "0x2000305")]
internal static class PoolManager
{
	[Token(Token = "0x40007FB")]
	private static readonly List<WeakReference`1<IPool>> s_WeakPoolReferences; //Field offset: 0x0

	[Address(RVA = "0x3081960", Offset = "0x3080D60", Length = "0x84")]
	[Token(Token = "0x60018AE")]
	private static PoolManager() { }

	[Address(RVA = "0x3081830", Offset = "0x3080C30", Length = "0x120")]
	[Token(Token = "0x60018AD")]
	public static void Register(IPool pool) { }

}

