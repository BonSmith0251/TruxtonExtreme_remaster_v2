namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000106")]
public struct UnsafeBitArray : INativeDisposable, IDisposable
{
	[Token(Token = "0x2000107")]
	internal struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004A4")]
		public readonly UInt64* Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004A5")]
		public readonly int Length; //Field offset: 0x8

		[Token(Token = "0x1700013E")]
		public bool IsCreated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x6000B24")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700013F")]
		public bool IsEmpty
		{
			[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
			[IsReadOnly]
			[Token(Token = "0x6000B25")]
			 get { } //Length: 17
		}

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000B26")]
		internal ReadOnly(UInt64* ptr, int length) { }

		[Address(RVA = "0x28CAF50", Offset = "0x28CA350", Length = "0xED")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000B2F")]
		private void CheckArgs(int pos, int numBits) { }

		[Address(RVA = "0x28CABF0", Offset = "0x28C9FF0", Length = "0x1E4")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000B30")]
		private void CheckArgsPosCount(int begin, int count, int numBits) { }

		[Address(RVA = "0x28CADE0", Offset = "0x28CA1E0", Length = "0x166")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		[IsReadOnly]
		[Token(Token = "0x6000B31")]
		private void CheckArgsUlong(int pos, int numBits) { }

		[Address(RVA = "0x28CB310", Offset = "0x28CA710", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000B2E")]
		public int CountBits(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CB9D0", Offset = "0x28CADD0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000B29")]
		public int Find(int pos, int numBits) { }

		[Address(RVA = "0x28CB9B0", Offset = "0x28CADB0", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000B2A")]
		public int Find(int pos, int count, int numBits) { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000B24")]
		public bool get_IsCreated() { }

		[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000B25")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0x28CBA00", Offset = "0x28CAE00", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000B27")]
		public ulong GetBits(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBA70", Offset = "0x28CAE70", Length = "0xB")]
		[IsReadOnly]
		[Token(Token = "0x6000B28")]
		public bool IsSet(int pos) { }

		[Address(RVA = "0x28CBA80", Offset = "0x28CAE80", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000B2D")]
		public bool TestAll(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBAB0", Offset = "0x28CAEB0", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000B2C")]
		public bool TestAny(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBAE0", Offset = "0x28CAEE0", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000B2B")]
		public bool TestNone(int pos, int numBits = 1) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004A0")]
	public UInt64* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004A1")]
	public int Length; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004A2")]
	public int Capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A3")]
	public AllocatorHandle Allocator; //Field offset: 0x10

	[Token(Token = "0x1700013C")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000B06")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700013D")]
	public bool IsEmpty
	{
		[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000B07")]
		 get { } //Length: 17
	}

	[Address(RVA = "0x28D2BC0", Offset = "0x28D1FC0", Length = "0x1E")]
	[Token(Token = "0x6000B02")]
	public UnsafeBitArray(Void* ptr, int sizeInBytes, AllocatorHandle allocator = null) { }

	[Address(RVA = "0x28D2BE0", Offset = "0x28D1FE0", Length = "0x78")]
	[Token(Token = "0x6000B03")]
	public UnsafeBitArray(int numBits, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x28D19C0", Offset = "0x28D0DC0", Length = "0x5E")]
	[Token(Token = "0x6000B04")]
	internal static UnsafeBitArray* Alloc(AllocatorHandle allocator) { }

	[Address(RVA = "0x699CB0", Offset = "0x6990B0", Length = "0x17")]
	[Token(Token = "0x6000B1E")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x28D1F30", Offset = "0x28D1330", Length = "0xED")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B20")]
	private void CheckArgs(int pos, int numBits) { }

	[Address(RVA = "0x28D1A20", Offset = "0x28D0E20", Length = "0x1A8")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B23")]
	private static void CheckArgsCopy(ref UnsafeBitArray dstBitArray, int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[Address(RVA = "0x28D1BD0", Offset = "0x28D0FD0", Length = "0x1E4")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B21")]
	private void CheckArgsPosCount(int begin, int count, int numBits) { }

	[Address(RVA = "0x28D1DC0", Offset = "0x28D11C0", Length = "0x166")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B22")]
	private void CheckArgsUlong(int pos, int numBits) { }

	[Address(RVA = "0x28D2020", Offset = "0x28D1420", Length = "0xA7")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B1F")]
	private static void CheckSizeMultipleOf8(int sizeInBytes) { }

	[Address(RVA = "0x28D20D0", Offset = "0x28D14D0", Length = "0x35")]
	[Token(Token = "0x6000B0E")]
	public void Clear() { }

	[Address(RVA = "0x28D2420", Offset = "0x28D1820", Length = "0x27")]
	[Token(Token = "0x6000B16")]
	public void Copy(int dstPos, int srcPos, int numBits) { }

	[Address(RVA = "0x28D2170", Offset = "0x28D1570", Length = "0x2A4")]
	[Token(Token = "0x6000B17")]
	public void Copy(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[Address(RVA = "0x28D2110", Offset = "0x28D1510", Length = "0x57")]
	[Token(Token = "0x6000B15")]
	internal void CopyUlong(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits) { }

	[Address(RVA = "0x28CB310", Offset = "0x28CA710", Length = "0x23")]
	[Token(Token = "0x6000B1D")]
	public int CountBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28D24E0", Offset = "0x28D18E0", Length = "0x10F")]
	[Token(Token = "0x6000B0D")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28D2450", Offset = "0x28D1850", Length = "0x90")]
	[Token(Token = "0x6000B0C")]
	public override void Dispose() { }

	[Address(RVA = "0x28CB9B0", Offset = "0x28CADB0", Length = "0x11")]
	[Token(Token = "0x6000B19")]
	public int Find(int pos, int count, int numBits) { }

	[Address(RVA = "0x28CB9D0", Offset = "0x28CADD0", Length = "0x24")]
	[Token(Token = "0x6000B18")]
	public int Find(int pos, int numBits) { }

	[Address(RVA = "0x28D25F0", Offset = "0x28D19F0", Length = "0x9D")]
	[Token(Token = "0x6000B05")]
	internal static void Free(UnsafeBitArray* data, AllocatorHandle allocator) { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000B06")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
	[IsReadOnly]
	[Token(Token = "0x6000B07")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x28CBA00", Offset = "0x28CAE00", Length = "0x23")]
	[Token(Token = "0x6000B13")]
	public ulong GetBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28CBA70", Offset = "0x28CAE70", Length = "0xB")]
	[Token(Token = "0x6000B14")]
	public bool IsSet(int pos) { }

	[Address(RVA = "0x28D2690", Offset = "0x28D1A90", Length = "0x183")]
	[Token(Token = "0x6000B08")]
	private void Realloc(int capacityInBits) { }

	[Address(RVA = "0x28D2820", Offset = "0x28D1C20", Length = "0x66")]
	[Token(Token = "0x6000B09")]
	public void Resize(int numBits, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x28D2B30", Offset = "0x28D1F30", Length = "0x69")]
	[Token(Token = "0x6000B10")]
	public void Set(int pos, bool value) { }

	[Address(RVA = "0x28D2AC0", Offset = "0x28D1EC0", Length = "0x69")]
	[Token(Token = "0x6000B0F")]
	public static void Set(UInt64* ptr, int pos, bool value) { }

	[Address(RVA = "0x28D29A0", Offset = "0x28D1DA0", Length = "0x10B")]
	[Token(Token = "0x6000B11")]
	public void SetBits(int pos, bool value, int numBits) { }

	[Address(RVA = "0x28D2890", Offset = "0x28D1C90", Length = "0x10F")]
	[Token(Token = "0x6000B12")]
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	[Address(RVA = "0x28D2AB0", Offset = "0x28D1EB0", Length = "0xE")]
	[Token(Token = "0x6000B0A")]
	public void SetCapacity(int capacityInBits) { }

	[Address(RVA = "0x28CBA80", Offset = "0x28CAE80", Length = "0x23")]
	[Token(Token = "0x6000B1C")]
	public bool TestAll(int pos, int numBits = 1) { }

	[Address(RVA = "0x28CBAB0", Offset = "0x28CAEB0", Length = "0x23")]
	[Token(Token = "0x6000B1B")]
	public bool TestAny(int pos, int numBits = 1) { }

	[Address(RVA = "0x28CBAE0", Offset = "0x28CAEE0", Length = "0x23")]
	[Token(Token = "0x6000B1A")]
	public bool TestNone(int pos, int numBits = 1) { }

	[Address(RVA = "0x28D2BA0", Offset = "0x28D1FA0", Length = "0x11")]
	[Token(Token = "0x6000B0B")]
	public void TrimExcess() { }

}

