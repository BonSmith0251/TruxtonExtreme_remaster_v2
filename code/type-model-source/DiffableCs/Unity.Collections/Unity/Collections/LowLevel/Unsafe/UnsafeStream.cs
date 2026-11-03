namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000143")]
public struct UnsafeStream : INativeDisposable, IDisposable
{
	[BurstCompile]
	[Token(Token = "0x2000146")]
	private struct ConstructJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000533")]
		public UnsafeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x4000534")]
		public NativeArray<Int32> Length; //Field offset: 0x20

		[Address(RVA = "0x28C66B0", Offset = "0x28C5AB0", Length = "0xE")]
		[Token(Token = "0x6000D93")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000145")]
	private struct ConstructJobList : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000531")]
		public UnsafeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		[Token(Token = "0x4000532")]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[Address(RVA = "0x28C6680", Offset = "0x28C5A80", Length = "0x21")]
		[Token(Token = "0x6000D92")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x2000144")]
	private struct DisposeJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000530")]
		public UnsafeStream Container; //Field offset: 0x0

		[Address(RVA = "0x28C69F0", Offset = "0x28C5DF0", Length = "0x7")]
		[Token(Token = "0x6000D91")]
		public override void Execute() { }

	}

	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000148")]
	internal struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400053F")]
		internal Block m_BlockData; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000540")]
		internal UnsafeStreamBlock* m_CurrentBlock; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000541")]
		internal Byte* m_CurrentPtr; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000542")]
		internal Byte* m_CurrentBlockEnd; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000543")]
		internal int m_RemainingItemCount; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000544")]
		internal int m_LastBlockSize; //Field offset: 0x3C

		[Token(Token = "0x1700019D")]
		public int ForEachCount
		{
			[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
			[Token(Token = "0x6000D9E")]
			 get { } //Length: 32
		}

		[Token(Token = "0x1700019E")]
		public int RemainingItemCount
		{
			[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
			[Token(Token = "0x6000D9F")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x28CC3E0", Offset = "0x28CB7E0", Length = "0x21")]
		[Token(Token = "0x6000D9B")]
		internal Reader(ref UnsafeStream stream) { }

		[Address(RVA = "0x28CC030", Offset = "0x28CB430", Length = "0x88")]
		[Token(Token = "0x6000D9C")]
		public int BeginForEachIndex(int foreachIndex) { }

		[Address(RVA = "0x28CC230", Offset = "0x28CB630", Length = "0x67")]
		[Token(Token = "0x6000DA3")]
		public int Count() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D9D")]
		public void EndForEachIndex() { }

		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[Token(Token = "0x6000D9E")]
		public int get_ForEachCount() { }

		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000D9F")]
		public int get_RemainingItemCount() { }

		[Address(RVA = "0x9F3270", Offset = "0x9F2670", Length = "0x72")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000DA2")]
		public T Peek() { }

		[Address(RVA = "0x9F5F50", Offset = "0x9F5350", Length = "0x59")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000DA1")]
		public T Read() { }

		[Address(RVA = "0x28CC340", Offset = "0x28CB740", Length = "0x5D")]
		[Token(Token = "0x6000DA0")]
		public Byte* ReadUnsafePtr(int size) { }

	}

	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000147")]
	internal struct Writer
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000535")]
		internal Block m_BlockData; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000536")]
		private UnsafeStreamBlock* m_CurrentBlock; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000537")]
		private Byte* m_CurrentPtr; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000538")]
		private Byte* m_CurrentBlockEnd; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000539")]
		internal int m_ForeachIndex; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400053A")]
		private int m_ElementCount; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400053B")]
		private UnsafeStreamBlock* m_FirstBlock; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400053C")]
		private int m_FirstOffset; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400053D")]
		private int m_NumberOfBlocks; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[NativeSetThreadIndex]
		[Token(Token = "0x400053E")]
		private int m_ThreadIndex; //Field offset: 0x50

		[Token(Token = "0x1700019C")]
		public int ForEachCount
		{
			[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
			[Token(Token = "0x6000D95")]
			 get { } //Length: 32
		}

		[Address(RVA = "0x28D49D0", Offset = "0x28D3DD0", Length = "0x30")]
		[Token(Token = "0x6000D94")]
		internal Writer(ref UnsafeStream stream) { }

		[Address(RVA = "0x9FBEF0", Offset = "0x9FB2F0", Length = "0x59")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000D99")]
		public T Allocate() { }

		[Address(RVA = "0x28D4830", Offset = "0x28D3C30", Length = "0x9E")]
		[Token(Token = "0x6000D9A")]
		public Byte* Allocate(int size) { }

		[Address(RVA = "0x28D48D0", Offset = "0x28D3CD0", Length = "0x1D")]
		[Token(Token = "0x6000D96")]
		public void BeginForEachIndex(int foreachIndex) { }

		[Address(RVA = "0x28D4900", Offset = "0x28D3D00", Length = "0xCD")]
		[Token(Token = "0x6000D97")]
		public void EndForEachIndex() { }

		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[Token(Token = "0x6000D95")]
		public int get_ForEachCount() { }

		[Address(RVA = "0x9FCA80", Offset = "0x9FBE80", Length = "0xD3")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000D98")]
		public void Write(T value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400052F")]
	internal Block m_BlockData; //Field offset: 0x0

	[Token(Token = "0x1700019B")]
	public int ForEachCount
	{
		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[IsReadOnly]
		[Token(Token = "0x6000D89")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700019A")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000D88")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x28C8E70", Offset = "0x28C8270", Length = "0x33")]
	[Token(Token = "0x6000D82")]
	public UnsafeStream(int bufferCount, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D35E0", Offset = "0x28D29E0", Length = "0x154")]
	[Token(Token = "0x6000D85")]
	internal static void AllocateBlock(out UnsafeStream stream, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D3740", Offset = "0x28D2B40", Length = "0xDD")]
	[Token(Token = "0x6000D86")]
	internal void AllocateForEach(int forEachCount) { }

	[Address(RVA = "0x28D3820", Offset = "0x28D2C20", Length = "0x24")]
	[Token(Token = "0x6000D8A")]
	public Reader AsReader() { }

	[Address(RVA = "0x28D3850", Offset = "0x28D2C50", Length = "0x34")]
	[Token(Token = "0x6000D8B")]
	public Writer AsWriter() { }

	[Address(RVA = "0x28C8C90", Offset = "0x28C8090", Length = "0x6C")]
	[Token(Token = "0x6000D8C")]
	public int Count() { }

	[Address(RVA = "0x28D3890", Offset = "0x28D2C90", Length = "0xB3")]
	[Token(Token = "0x6000D8E")]
	private void Deallocate() { }

	[Address(RVA = "0x28C8B20", Offset = "0x28C7F20", Length = "0xE")]
	[Token(Token = "0x6000D8F")]
	public override void Dispose() { }

	[Address(RVA = "0x28D3950", Offset = "0x28D2D50", Length = "0x93")]
	[Token(Token = "0x6000D90")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
	[IsReadOnly]
	[Token(Token = "0x6000D89")]
	public int get_ForEachCount() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000D88")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28D39F0", Offset = "0x28D2DF0", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000D87")]
	public bool IsEmpty() { }

	[Address(RVA = "0x9DC640", Offset = "0x9DBA40", Length = "0xE9")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000D83")]
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D3A70", Offset = "0x28D2E70", Length = "0xBE")]
	[Token(Token = "0x6000D84")]
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeArray<Int32> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[Address(RVA = "0x9DC730", Offset = "0x9DBB30", Length = "0x1DF")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000D8D")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

