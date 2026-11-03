namespace System.Buffers;

[Token(Token = "0x200062D")]
internal sealed class TlsOverPerCoreLockedStacksArrayPool : ArrayPool<T>
{
	[Token(Token = "0x2000630")]
	private sealed class LockedStack
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018C5")]
		private readonly T[][] _arrays; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018C6")]
		private int _count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018C7")]
		private uint _firstStackItemMS; //Field offset: 0x0

		[Address(RVA = "0xCF00E0", Offset = "0xCEF4E0", Length = "0x55")]
		[Token(Token = "0x6002DFC")]
		public LockedStack() { }

		[Address(RVA = "0xCEFBC0", Offset = "0xCEEFC0", Length = "0x25D")]
		[Token(Token = "0x6002DFB")]
		public void Trim(uint tickCount, int id, MemoryPressure<T> pressure, int bucketSize) { }

		[Address(RVA = "0xCEFE20", Offset = "0xCEF220", Length = "0x85")]
		[Token(Token = "0x6002DFA")]
		public T[] TryPop() { }

		[Address(RVA = "0xCEFEB0", Offset = "0xCEF2B0", Length = "0xFC")]
		[Token(Token = "0x6002DF9")]
		public bool TryPush(T[] array) { }

	}

	[Token(Token = "0x200062E")]
	private enum MemoryPressure : int
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	[Token(Token = "0x200062F")]
	private sealed class PerCoreLockedStacks
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018C4")]
		private readonly LockedStack<T>[] _perCoreStacks; //Field offset: 0x0

		[Address(RVA = "0xE20940", Offset = "0xE1FD40", Length = "0x14E")]
		[Token(Token = "0x6002DF5")]
		public PerCoreLockedStacks() { }

		[Address(RVA = "0xE1F210", Offset = "0xE1E610", Length = "0xD4")]
		[Token(Token = "0x6002DF8")]
		public bool Trim(uint tickCount, int id, MemoryPressure<T> pressure, Int32[] bucketSizes) { }

		[Address(RVA = "0xE1F6C0", Offset = "0xE1EAC0", Length = "0x163")]
		[Token(Token = "0x6002DF7")]
		public T[] TryPop() { }

		[Address(RVA = "0xE1FE40", Offset = "0xE1F240", Length = "0x1BC")]
		[Token(Token = "0x6002DF6")]
		public void TryPush(T[] array) { }

	}

	[ThreadStatic]
	[Token(Token = "0x40018BC")]
	private static T[][] t_tlsBuckets; //Field offset: 0xFFFFFFFF
	[Token(Token = "0x40018BE")]
	private static readonly bool s_trimBuffers; //Field offset: 0x0
	[Token(Token = "0x40018BF")]
	private static readonly ConditionalWeakTable<T[][], Object> s_allTlsBuckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018BA")]
	private readonly Int32[] _bucketArraySizes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018BB")]
	private readonly PerCoreLockedStacks<T>[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018BD")]
	private int _callbackCreated; //Field offset: 0x0

	[Token(Token = "0x17000741")]
	private int Id
	{
		[Address(RVA = "0x108EF90", Offset = "0x108E390", Length = "0x26")]
		[Token(Token = "0x6002DED")]
		private get { } //Length: 38
	}

	[Address(RVA = "0x108E420", Offset = "0x108D820", Length = "0x18F")]
	[Token(Token = "0x6002DF4")]
	private static TlsOverPerCoreLockedStacksArrayPool`1() { }

	[Address(RVA = "0x108EE70", Offset = "0x108E270", Length = "0x118")]
	[Token(Token = "0x6002DEB")]
	public TlsOverPerCoreLockedStacksArrayPool`1() { }

	[Address(RVA = "0x1085000", Offset = "0x1084400", Length = "0xAA")]
	[Token(Token = "0x6002DEC")]
	private PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }

	[Address(RVA = "0x10856F0", Offset = "0x1084AF0", Length = "0x104")]
	[Token(Token = "0x6002DF1")]
	private static bool Gen2GcCallbackFunc(object target) { }

	[Address(RVA = "0x108EF90", Offset = "0x108E390", Length = "0x26")]
	[Token(Token = "0x6002DED")]
	private int get_Id() { }

	[Address(RVA = "0x1085E10", Offset = "0x1085210", Length = "0xCF")]
	[Token(Token = "0x6002DF2")]
	private static MemoryPressure<T> GetMemoryPressure() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002DF3")]
	private static bool GetTrimBuffers() { }

	[Address(RVA = "0x1086B50", Offset = "0x1085F50", Length = "0x55F")]
	[Token(Token = "0x6002DEE")]
	public virtual T[] Rent(int minimumLength) { }

	[Address(RVA = "0x1088630", Offset = "0x1087A30", Length = "0x548")]
	[Token(Token = "0x6002DEF")]
	public virtual void Return(T[] array, bool clearArray = false) { }

	[Address(RVA = "0x108AB50", Offset = "0x1089F50", Length = "0x812")]
	[Token(Token = "0x6002DF0")]
	public bool Trim() { }

}

