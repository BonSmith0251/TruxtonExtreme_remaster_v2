namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B6")]
internal class NativeList : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001424")]
	private readonly MemoryLabel m_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001425")]
	private NativeArray<T> m_NativeArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001426")]
	private int m_Count; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001427")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000A54")]
	public int Count
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x600291B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000A55")]
	protected private bool disposed
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600291C")]
		 get { } //Length: 5
		[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600291D")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xD85860", Offset = "0xD84C60", Length = "0xC0")]
	[Token(Token = "0x6002916")]
	public NativeList`1(int initialCapacity, MemoryLabel allocLabel) { }

	[Address(RVA = "0xD83F70", Offset = "0xD83370", Length = "0x20B")]
	[Token(Token = "0x6002918")]
	public void Add(NativeSlice<T> src) { }

	[Address(RVA = "0xD842D0", Offset = "0xD836D0", Length = "0x8")]
	[Token(Token = "0x6002919")]
	public void Clear() { }

	[Address(RVA = "0xD84B00", Offset = "0xD83F00", Length = "0x86")]
	[Token(Token = "0x600291E")]
	public override void Dispose() { }

	[Address(RVA = "0xD84500", Offset = "0xD83900", Length = "0x35")]
	[Token(Token = "0x600291F")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xD85000", Offset = "0xD84400", Length = "0x176")]
	[Token(Token = "0x6002917")]
	private void Expand(int newLength) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x600291B")]
	public int get_Count() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600291C")]
	protected bool get_disposed() { }

	[Address(RVA = "0xD852C0", Offset = "0xD846C0", Length = "0x54")]
	[Token(Token = "0x600291A")]
	public NativeSlice<T> GetSlice(int start, int length) { }

	[Address(RVA = "0xD85C80", Offset = "0xD85080", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600291D")]
	private void set_disposed(bool value) { }

}

