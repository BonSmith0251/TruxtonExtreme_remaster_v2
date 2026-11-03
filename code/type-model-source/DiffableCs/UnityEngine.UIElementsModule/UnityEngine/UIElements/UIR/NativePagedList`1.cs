namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B7")]
internal class NativePagedList : IDisposable
{
	[Token(Token = "0x20005B9")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001432")]
		private NativePagedList<T> m_NativePagedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001433")]
		private NativeArray<T> m_CurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001434")]
		private int m_IndexInCurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001435")]
		private int m_IndexOfCurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001436")]
		private int m_CountInCurrentPage; //Field offset: 0x0

		[Address(RVA = "0x19A5CA0", Offset = "0x19A50A0", Length = "0x2EF")]
		[Token(Token = "0x600292C")]
		public Enumerator(NativePagedList<T> nativePagedList, int offset) { }

		[Address(RVA = "0x199C450", Offset = "0x199B850", Length = "0x47B")]
		[Token(Token = "0x600292E")]
		public T GetNext() { }

		[Address(RVA = "0x199C8D0", Offset = "0x199BCD0", Length = "0xC")]
		[Token(Token = "0x600292D")]
		public bool HasNext() { }

	}

	[Token(Token = "0x20005B8")]
	private struct NativeArrayAllocator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001430")]
		private Allocator m_Allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001431")]
		private MemoryLabel m_MemoryLabel; //Field offset: 0x0

		[Address(RVA = "0xD121A0", Offset = "0xD115A0", Length = "0x86")]
		[Token(Token = "0x600292A")]
		public NativeArrayAllocator(string profilerName, Allocator allocator) { }

		[Address(RVA = "0xD11EA0", Offset = "0xD112A0", Length = "0xF7")]
		[Token(Token = "0x600292B")]
		public NativeArray<T> CreateArray(int length, NativeArrayOptions options = 1) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001428")]
	private readonly int k_PoolCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001429")]
	private List<NativeArray`1<T>> m_Pages; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142A")]
	private NativeArray<T> m_LastPage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142B")]
	private int m_CountInLastPage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142C")]
	private readonly NativeArrayAllocator<T> m_FirstPageAllocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142D")]
	private readonly NativeArrayAllocator<T> m_OtherPagesAllocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142E")]
	private List<NativeSlice`1<T>> m_Enumerator; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400142F")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000A56")]
	protected private bool disposed
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002926")]
		 get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002927")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xD89050", Offset = "0xD88450", Length = "0x1F1")]
	[Token(Token = "0x6002920")]
	public NativePagedList`1(int poolCapacity, string profilerName, Allocator firstPageAllocator = 4, Allocator otherPagesAllocator = 4) { }

	[Address(RVA = "0xD86580", Offset = "0xD85980", Length = "0x35C")]
	[Token(Token = "0x6002921")]
	public void Add(ref T data) { }

	[Address(RVA = "0xD86D00", Offset = "0xD86100", Length = "0x26E")]
	[Token(Token = "0x6002922")]
	public void Add(T data) { }

	[Address(RVA = "0xD86F90", Offset = "0xD86390", Length = "0x11D")]
	[Token(Token = "0x6002928")]
	public override void Dispose() { }

	[Address(RVA = "0xD871D0", Offset = "0xD865D0", Length = "0xD9")]
	[Token(Token = "0x6002929")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002926")]
	protected bool get_disposed() { }

	[Address(RVA = "0xD876E0", Offset = "0xD86AE0", Length = "0x91")]
	[Token(Token = "0x6002924")]
	public int GetCount() { }

	[Address(RVA = "0xD88200", Offset = "0xD87600", Length = "0x28D")]
	[Token(Token = "0x6002923")]
	public List<NativeSlice`1<T>> GetPages() { }

	[Address(RVA = "0xD88490", Offset = "0xD87890", Length = "0x1A0")]
	[Token(Token = "0x6002925")]
	public void Reset() { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002927")]
	private void set_disposed(bool value) { }

}

