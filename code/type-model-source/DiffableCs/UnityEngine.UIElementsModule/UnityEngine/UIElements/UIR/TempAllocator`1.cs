namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005DB")]
internal class TempAllocator : IDisposable
{
	[Token(Token = "0x20005DC")]
	private struct Page
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001553")]
		public NativeArray<T> array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001554")]
		public int used; //Field offset: 0x0

	}

	[Token(Token = "0x400154C")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400154D")]
	private readonly int m_ExcessMinCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400154E")]
	private readonly int m_ExcessMaxCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400154F")]
	private Page<T> m_Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001550")]
	private List<Page<T>> m_Excess; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001551")]
	private int m_NextExcessSize; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001552")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000A8B")]
	protected private bool disposed
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002A27")]
		 get { } //Length: 5
		[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A28")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x101D450", Offset = "0x101C850", Length = "0xB0")]
	[Token(Token = "0x6002A2F")]
	private static TempAllocator`1() { }

	[Address(RVA = "0x101D660", Offset = "0x101CA60", Length = "0x1A4")]
	[Token(Token = "0x6002A26")]
	public TempAllocator`1(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }

	[Address(RVA = "0x101BFF0", Offset = "0x101B3F0", Length = "0x4A")]
	[Token(Token = "0x6002A2B")]
	public NativeSlice<T> Alloc(int count) { }

	[Address(RVA = "0x101C2A0", Offset = "0x101B6A0", Length = "0xC3")]
	[Token(Token = "0x6002A29")]
	public override void Dispose() { }

	[Address(RVA = "0x101C150", Offset = "0x101B550", Length = "0x7B")]
	[Token(Token = "0x6002A2A")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x101C370", Offset = "0x101B770", Length = "0x434")]
	[Token(Token = "0x6002A2C")]
	private NativeSlice<T> DoAlloc(int count) { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002A27")]
	protected bool get_disposed() { }

	[Address(RVA = "0x101D050", Offset = "0x101C450", Length = "0x181")]
	[Token(Token = "0x6002A2E")]
	private void ReleaseExcess() { }

	[Address(RVA = "0x101D410", Offset = "0x101C810", Length = "0x33")]
	[Token(Token = "0x6002A2D")]
	public void Reset() { }

	[Address(RVA = "0x101DB80", Offset = "0x101CF80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A28")]
	private void set_disposed(bool value) { }

}

