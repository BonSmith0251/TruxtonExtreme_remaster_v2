namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200028C")]
internal abstract class RenderGraphResourcePool : IRenderGraphResourcePool
{
	[CompilerGenerated]
	[Token(Token = "0x200028E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B67")]
		public static readonly <>c<Type> <>9; //Field offset: 0x0
		[Token(Token = "0x4000B68")]
		public static Comparison<ResourceLogInfo<Type>> <>9__15_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6001247")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001248")]
		public <>c() { }

		[Address(RVA = "0xA35620", Offset = "0xA34A20", Length = "0x18")]
		[Token(Token = "0x6001249")]
		internal int <LogResources>b__15_0(ResourceLogInfo<Type> a, ResourceLogInfo<Type> b) { }

	}

	[Token(Token = "0x200028D")]
	private struct ResourceLogInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B65")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B66")]
		public long size; //Field offset: 0x0

	}

	[Token(Token = "0x4000B63")]
	private const int kStaleResourceLifetime = 10; //Field offset: 0x0
	[Token(Token = "0x4000B64")]
	private static List<Int32> s_ToRemoveList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B61")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"resource", "frameIndex"})]
	protected Dictionary<Int32, SortedList`2<Int32, ValueTuple`2<Type, Int32>>> m_ResourcePool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B62")]
	private List<ValueTuple`2<Int32, Type>> m_FrameAllocatedResources; //Field offset: 0x0

	[Address(RVA = "0xF513F0", Offset = "0xF507F0", Length = "0xE3")]
	[Token(Token = "0x6001246")]
	private static RenderGraphResourcePool`1() { }

	[Address(RVA = "0xF514E0", Offset = "0xF508E0", Length = "0xDB")]
	[Token(Token = "0x6001245")]
	protected RenderGraphResourcePool`1() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001240")]
	public virtual void CheckFrameAllocation(bool onException, int frameIndex) { }

	[Address(RVA = "0xF4F790", Offset = "0xF4EB90", Length = "0x34C")]
	[Token(Token = "0x600123D")]
	public virtual void Cleanup() { }

	[Address(RVA = "0xF4FAE0", Offset = "0xF4EEE0", Length = "0x362")]
	[Token(Token = "0x6001242")]
	public float GetMemorySizeInMB() { }

	[Address(RVA = "0xF4FE50", Offset = "0xF4F250", Length = "0x15A")]
	[Token(Token = "0x6001243")]
	public int GetNumResourcesAvailable() { }

	[Token(Token = "0x6001237")]
	protected abstract string GetResourceName(in Type res) { }

	[Token(Token = "0x6001238")]
	protected abstract long GetResourceSize(in Type res) { }

	[Token(Token = "0x6001239")]
	protected abstract string GetResourceTypeName() { }

	[Token(Token = "0x600123A")]
	protected abstract int GetSortIndex(Type res) { }

	[Address(RVA = "0xF4FFB0", Offset = "0xF4F3B0", Length = "0x9A2")]
	[Token(Token = "0x6001241")]
	public virtual void LogResources(RenderGraphLogger logger) { }

	[Address(RVA = "0xF50960", Offset = "0xF4FD60", Length = "0x558")]
	[Token(Token = "0x6001244")]
	public virtual void PurgeUnusedResources(int currentFrameIndex) { }

	[Address(RVA = "0xF50EC0", Offset = "0xF502C0", Length = "0x170")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600123E")]
	public void RegisterFrameAllocation(int hash, Type value) { }

	[Token(Token = "0x6001236")]
	protected abstract void ReleaseInternalResource(Type res) { }

	[Address(RVA = "0xF51040", Offset = "0xF50440", Length = "0x164")]
	[Token(Token = "0x600123B")]
	public void ReleaseResource(int hash, Type resource, int currentFrameIndex) { }

	[Address(RVA = "0xF511B0", Offset = "0xF505B0", Length = "0x118")]
	[Token(Token = "0x600123C")]
	public bool TryGetResource(int hashCode, out Type resource) { }

	[Address(RVA = "0xF512D0", Offset = "0xF506D0", Length = "0x110")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600123F")]
	public void UnregisterFrameAllocation(int hash, Type value) { }

}

