namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000039")]
public class LRUCacheAllocationStrategy : IAllocationStrategy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000090")]
	private int m_poolMaxSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000091")]
	private int m_poolInitialCapacity; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000092")]
	private int m_poolCacheMaxSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000093")]
	private List<List`1<Object>> m_poolCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000094")]
	private Dictionary<Int32, List`1<Object>> m_cache; //Field offset: 0x28

	[Address(RVA = "0x2E45110", Offset = "0x2E44510", Length = "0x1C4")]
	[Token(Token = "0x600014C")]
	public LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	[Address(RVA = "0x2E44BE0", Offset = "0x2E43FE0", Length = "0xEA")]
	[Token(Token = "0x600014D")]
	private List<Object> GetPool() { }

	[Address(RVA = "0x2E44CD0", Offset = "0x2E440D0", Length = "0x1C8")]
	[Token(Token = "0x600014F")]
	public override object New(Type type, int typeHash) { }

	[Address(RVA = "0x2E44F10", Offset = "0x2E44310", Length = "0x1FD")]
	[Token(Token = "0x6000150")]
	public override void Release(int typeHash, object obj) { }

	[Address(RVA = "0x2E44EA0", Offset = "0x2E442A0", Length = "0x68")]
	[Token(Token = "0x600014E")]
	private void ReleasePool(List<Object> pool) { }

}

