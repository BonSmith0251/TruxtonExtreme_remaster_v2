namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000102")]
public struct UnsafeAppendBuffer : INativeDisposable, IDisposable
{
	[GenerateTestsForBurstCompatibility]
	[Token(Token = "0x2000103")]
	internal struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049B")]
		public readonly Byte* Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400049C")]
		public readonly int Size; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400049D")]
		public int Offset; //Field offset: 0xC

		[Token(Token = "0x1700013B")]
		public bool EndOfBuffer
		{
			[Address(RVA = "0x28CC440", Offset = "0x28CB840", Length = "0xA")]
			[Token(Token = "0x6000AEF")]
			 get { } //Length: 10
		}

		[Address(RVA = "0x28CC420", Offset = "0x28CB820", Length = "0x14")]
		[Token(Token = "0x6000AED")]
		public Reader(ref UnsafeAppendBuffer buffer) { }

		[Address(RVA = "0x28CC410", Offset = "0x28CB810", Length = "0xF")]
		[Token(Token = "0x6000AEE")]
		public Reader(Void* ptr, int length) { }

		[Address(RVA = "0x28CC0C0", Offset = "0x28CB4C0", Length = "0xBB")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[Token(Token = "0x6000AF5")]
		private void CheckBounds(int structSize) { }

		[Address(RVA = "0x28CC440", Offset = "0x28CB840", Length = "0xA")]
		[Token(Token = "0x6000AEF")]
		public bool get_EndOfBuffer() { }

		[Address(RVA = "0x9F3AE0", Offset = "0x9F2EE0", Length = "0xAA")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000AF0")]
		public void ReadNext(out T value) { }

		[Address(RVA = "0x9F3A50", Offset = "0x9F2E50", Length = "0x83")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000AF1")]
		public T ReadNext() { }

		[Address(RVA = "0x28CC2A0", Offset = "0x28CB6A0", Length = "0x3F")]
		[Token(Token = "0x6000AF2")]
		public Void* ReadNext(int structSize) { }

		[Address(RVA = "0x9F3730", Offset = "0x9F2B30", Length = "0xF4")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000AF3")]
		public void ReadNext(out NativeArray<T>& value, AllocatorHandle allocator) { }

		[Address(RVA = "0x9F3690", Offset = "0x9F2A90", Length = "0x91")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000AF4")]
		public Void* ReadNextArray(out int length) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000496")]
	public Byte* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000497")]
	public int Length; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000498")]
	public int Capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000499")]
	public AllocatorHandle Allocator; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400049A")]
	public readonly int Alignment; //Field offset: 0x14

	[Token(Token = "0x1700013A")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000ADF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000139")]
	public bool IsEmpty
	{
		[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000ADE")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x28D1490", Offset = "0x28D0890", Length = "0x103")]
	[Token(Token = "0x6000ADC")]
	public UnsafeAppendBuffer(int initialCapacity, int alignment, AllocatorHandle allocator) { }

	[Address(RVA = "0x28D1400", Offset = "0x28D0800", Length = "0x84")]
	[Token(Token = "0x6000ADD")]
	public UnsafeAppendBuffer(Void* ptr, int length) { }

	[Address(RVA = "0x9D7A00", Offset = "0x9D6E00", Length = "0xDF")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AE8")]
	public void Add(NativeArray<T> value) { }

	[Address(RVA = "0x28D1000", Offset = "0x28D0400", Length = "0x4D")]
	[Token(Token = "0x6000AE6")]
	public void Add(Void* ptr, int structSize) { }

	[Address(RVA = "0x9D7BB0", Offset = "0x9D6FB0", Length = "0xC0")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AE5")]
	public void Add(T value) { }

	[Address(RVA = "0x9D7970", Offset = "0x9D6D70", Length = "0x8F")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AE7")]
	public void AddArray(Void* ptr, int length) { }

	[Address(RVA = "0x11DD2F0", Offset = "0x11DC6F0", Length = "0x17")]
	[Token(Token = "0x6000AEB")]
	public Reader AsReader() { }

	[Address(RVA = "0x28D1050", Offset = "0x28D0450", Length = "0xA6")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000AEC")]
	private static void CheckAlignment(int alignment) { }

	[Address(RVA = "0x28D11A0", Offset = "0x28D05A0", Length = "0x10F")]
	[Token(Token = "0x6000AE1")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28D1100", Offset = "0x28D0500", Length = "0x91")]
	[Token(Token = "0x6000AE0")]
	public override void Dispose() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000ADF")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xF1EA30", Offset = "0xF1DE30", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000ADE")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x9D7C70", Offset = "0x9D7070", Length = "0x162")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AE9")]
	public T Pop() { }

	[Address(RVA = "0x28D12B0", Offset = "0x28D06B0", Length = "0x39")]
	[Token(Token = "0x6000AEA")]
	public void Pop(Void* ptr, int structSize) { }

	[Address(RVA = "0x11AAC00", Offset = "0x11AA000", Length = "0x8")]
	[Token(Token = "0x6000AE2")]
	public void Reset() { }

	[Address(RVA = "0x28D12F0", Offset = "0x28D06F0", Length = "0x25")]
	[Token(Token = "0x6000AE4")]
	public void ResizeUninitialized(int length) { }

	[Address(RVA = "0x28D1320", Offset = "0x28D0720", Length = "0xD7")]
	[Token(Token = "0x6000AE3")]
	public void SetCapacity(int capacity) { }

}

