//Type is in global namespace

[Token(Token = "0x2000004")]
internal class RenderGraphCompilationCache
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c__11
	{
		[Token(Token = "0x400000C")]
		public static readonly <>c__11<T> <>9; //Field offset: 0x0
		[Token(Token = "0x400000D")]
		public static Predicate<HashEntry`1<T>> <>9__11_0; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x600000B")]
		private static <>c__11`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600000C")]
		public <>c__11`1() { }

		[Address(RVA = "0xA50AD0", Offset = "0xA4FED0", Length = "0x59")]
		[Token(Token = "0x600000D")]
		internal bool <GetCompilationCache>b__11_0(HashEntry<T> value) { }

	}

	[Token(Token = "0x2000005")]
	private struct HashEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000009")]
		public int hash; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000A")]
		public int lastFrameUsed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000B")]
		public T compiledGraph; //Field offset: 0x0

	}

	[Token(Token = "0x4000005")]
	private static SortComparer<HashEntry<CompiledGraph>> s_EntryComparer; //Field offset: 0x0
	[Token(Token = "0x4000007")]
	private const int k_CachedGraphCount = 20; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static SortComparer<HashEntry<CompilerContextData>> s_NativeEntryComparer; //Field offset: 0x8
	[Token(Token = "0x4000008")]
	private static int s_Hash; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private DynamicArray<HashEntry`1<CompiledGraph>> m_HashEntries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private DynamicArray<HashEntry`1<CompilerContextData>> m_NativeHashEntries; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000003")]
	private Stack<CompiledGraph> m_CompiledGraphPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000004")]
	private Stack<CompilerContextData> m_NativeCompiledGraphPool; //Field offset: 0x28

	[Address(RVA = "0x2BC57B0", Offset = "0x2BC4BB0", Length = "0xF0")]
	[Token(Token = "0x600000A")]
	private static RenderGraphCompilationCache() { }

	[Address(RVA = "0x2BC58A0", Offset = "0x2BC4CA0", Length = "0x209")]
	[Token(Token = "0x6000004")]
	public RenderGraphCompilationCache() { }

	[Address(RVA = "0x2BC5230", Offset = "0x2BC4630", Length = "0x22F")]
	[Token(Token = "0x6000009")]
	public void Cleanup() { }

	[Address(RVA = "0x2BC5460", Offset = "0x2BC4860", Length = "0x1C5")]
	[Token(Token = "0x6000008")]
	public void Clear() { }

	[Address(RVA = "0x8E6B30", Offset = "0x8E5F30", Length = "0x307")]
	[Token(Token = "0x6000005")]
	private bool GetCompilationCache(int hash, int frameIndex, out T outGraph, DynamicArray<HashEntry`1<T>> hashEntries, Stack<T> pool, SortComparer<HashEntry<T>> comparer) { }

	[Address(RVA = "0x2BC56F0", Offset = "0x2BC4AF0", Length = "0xBF")]
	[Token(Token = "0x6000006")]
	public bool GetCompilationCache(int hash, int frameIndex, out CompiledGraph outGraph) { }

	[Address(RVA = "0x2BC5630", Offset = "0x2BC4A30", Length = "0xC0")]
	[Token(Token = "0x6000007")]
	public bool GetCompilationCache(int hash, int frameIndex, out CompilerContextData outGraph) { }

	[Address(RVA = "0x8E6FA0", Offset = "0x8E63A0", Length = "0x1A")]
	[Token(Token = "0x6000003")]
	private static int HashEntryComparer(HashEntry<T> a, HashEntry<T> b) { }

}

