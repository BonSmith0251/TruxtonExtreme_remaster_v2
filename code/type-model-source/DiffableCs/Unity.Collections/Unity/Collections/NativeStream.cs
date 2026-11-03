namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x20000CB")]
public struct NativeStream : INativeDisposable, IDisposable
{
	[BurstCompile]
	[Token(Token = "0x20000CD")]
	private struct ConstructJob : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000406")]
		public NativeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x4000407")]
		public NativeArray<Int32> Length; //Field offset: 0x20

		[Address(RVA = "0x28C66B0", Offset = "0x28C5AB0", Length = "0xE")]
		[Token(Token = "0x600094E")]
		public override void Execute() { }

	}

	[BurstCompile]
	[Token(Token = "0x20000CC")]
	private struct ConstructJobList : IJob
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000404")]
		public NativeStream Container; //Field offset: 0x0
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		[Token(Token = "0x4000405")]
		public UntypedUnsafeList* List; //Field offset: 0x20

		[Address(RVA = "0x28C6680", Offset = "0x28C5A80", Length = "0x21")]
		[Token(Token = "0x600094D")]
		public override void Execute() { }

	}

	[GenerateTestsForBurstCompatibility]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x20000CF")]
	internal struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000409")]
		private Reader m_Reader; //Field offset: 0x0

		[Token(Token = "0x1700010F")]
		public int ForEachCount
		{
			[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
			[Token(Token = "0x600095D")]
			 get { } //Length: 32
		}

		[Token(Token = "0x17000110")]
		public int RemainingItemCount
		{
			[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
			[Token(Token = "0x600095E")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x28CC3A0", Offset = "0x28CB7A0", Length = "0x33")]
		[Token(Token = "0x600095A")]
		internal Reader(ref NativeStream stream) { }

		[Address(RVA = "0x28CC020", Offset = "0x28CB420", Length = "0x8")]
		[Token(Token = "0x600095B")]
		public int BeginForEachIndex(int foreachIndex) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000966")]
		private void CheckBeginForEachIndex(int forEachIndex) { }

		[Address(RVA = "0x28CC180", Offset = "0x28CB580", Length = "0xAD")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000967")]
		private void CheckEndForEachIndex() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000963")]
		private void CheckNotReadingOutOfBounds(int size) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Token(Token = "0x6000964")]
		private void CheckRead() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000965")]
		private void CheckReadSize(int size) { }

		[Address(RVA = "0x28CC230", Offset = "0x28CB630", Length = "0x67")]
		[Token(Token = "0x6000962")]
		public int Count() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600095C")]
		public void EndForEachIndex() { }

		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[Token(Token = "0x600095D")]
		public int get_ForEachCount() { }

		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x600095E")]
		public int get_RemainingItemCount() { }

		[Address(RVA = "0x9F3220", Offset = "0x9F2620", Length = "0x49")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000961")]
		public T Peek() { }

		[Address(RVA = "0x9F5EF0", Offset = "0x9F52F0", Length = "0x59")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000960")]
		public T Read() { }

		[Address(RVA = "0x28CC2E0", Offset = "0x28CB6E0", Length = "0x5F")]
		[Token(Token = "0x600095F")]
		public Byte* ReadUnsafePtr(int size) { }

	}

	[GenerateTestsForBurstCompatibility]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[Token(Token = "0x20000CE")]
	internal struct Writer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000408")]
		private Writer m_Writer; //Field offset: 0x0

		[Token(Token = "0x1700010E")]
		public int ForEachCount
		{
			[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
			[Token(Token = "0x6000950")]
			 get { } //Length: 32
		}

		[Address(RVA = "0x28D4A00", Offset = "0x28D3E00", Length = "0x78")]
		[Token(Token = "0x600094F")]
		internal Writer(ref NativeStream stream) { }

		[Address(RVA = "0x9FBE90", Offset = "0x9FB290", Length = "0x59")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000955")]
		public T Allocate() { }

		[Address(RVA = "0x28D4820", Offset = "0x28D3C20", Length = "0x8")]
		[Token(Token = "0x6000956")]
		public Byte* Allocate(int size) { }

		[Address(RVA = "0x28D48D0", Offset = "0x28D3CD0", Length = "0x1D")]
		[Token(Token = "0x6000952")]
		public void BeginForEachIndex(int foreachIndex) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000959")]
		private void CheckAllocateSize(int size) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000957")]
		private void CheckBeginForEachIndex(int foreachIndex) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000958")]
		private void CheckEndForEachIndex() { }

		[Address(RVA = "0x28D48F0", Offset = "0x28D3CF0", Length = "0x7")]
		[Token(Token = "0x6000953")]
		public void EndForEachIndex() { }

		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[Token(Token = "0x6000950")]
		public int get_ForEachCount() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000951")]
		public void PatchMinMaxRange(int foreEachIndex) { }

		[Address(RVA = "0x9FCA80", Offset = "0x9FBE80", Length = "0xD3")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000954")]
		public void Write(T value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000403")]
	private UnsafeStream m_Stream; //Field offset: 0x0

	[Token(Token = "0x1700010D")]
	public int ForEachCount
	{
		[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
		[IsReadOnly]
		[Token(Token = "0x6000942")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700010C")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000941")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x28C8E70", Offset = "0x28C8270", Length = "0x33")]
	[Token(Token = "0x600093D")]
	public NativeStream(int bufferCount, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C8B30", Offset = "0x28C7F30", Length = "0x8")]
	[Token(Token = "0x6000949")]
	private static void AllocateBlock(out NativeStream stream, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C8B40", Offset = "0x28C7F40", Length = "0x8")]
	[Token(Token = "0x600094A")]
	private void AllocateForEach(int forEachCount) { }

	[Address(RVA = "0x28C8B50", Offset = "0x28C7F50", Length = "0x36")]
	[Token(Token = "0x6000943")]
	public Reader AsReader() { }

	[Address(RVA = "0x28C8B90", Offset = "0x28C7F90", Length = "0x7B")]
	[Token(Token = "0x6000944")]
	public Writer AsWriter() { }

	[Address(RVA = "0x28C8C10", Offset = "0x28C8010", Length = "0x7B")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600094B")]
	private static void CheckForEachCountGreaterThanZero(int forEachCount) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x600094C")]
	private void CheckRead() { }

	[Address(RVA = "0x28C8C90", Offset = "0x28C8090", Length = "0x6C")]
	[Token(Token = "0x6000945")]
	public int Count() { }

	[Address(RVA = "0x28C8B20", Offset = "0x28C7F20", Length = "0xE")]
	[Token(Token = "0x6000947")]
	public override void Dispose() { }

	[Address(RVA = "0x28C8D00", Offset = "0x28C8100", Length = "0x93")]
	[Token(Token = "0x6000948")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28C8EB0", Offset = "0x28C82B0", Length = "0x20")]
	[IsReadOnly]
	[Token(Token = "0x6000942")]
	public int get_ForEachCount() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000941")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28C8DA0", Offset = "0x28C81A0", Length = "0x7")]
	[IsReadOnly]
	[Token(Token = "0x6000940")]
	public bool IsEmpty() { }

	[Address(RVA = "0x8996F0", Offset = "0x898AF0", Length = "0xE9")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600093E")]
	public static JobHandle ScheduleConstruct(out NativeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[Address(RVA = "0x28C8DB0", Offset = "0x28C81B0", Length = "0xBE")]
	[Token(Token = "0x600093F")]
	public static JobHandle ScheduleConstruct(out NativeStream stream, NativeArray<Int32> bufferCount, JobHandle dependency, AllocatorHandle allocator) { }

	[Address(RVA = "0x8997E0", Offset = "0x898BE0", Length = "0x67")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000946")]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

