namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000089")]
public struct NativeBitArray : INativeDisposable, IDisposable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x200008A")]
	internal struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003AE")]
		internal ReadOnly m_BitArray; //Field offset: 0x0

		[Token(Token = "0x170000AE")]
		public bool IsCreated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x600070F")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000AF")]
		public bool IsEmpty
		{
			[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
			[IsReadOnly]
			[Token(Token = "0x6000710")]
			 get { } //Length: 17
		}

		[Token(Token = "0x170000B0")]
		public int Length
		{
			[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
			[IsReadOnly]
			[Token(Token = "0x6000712")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x28CBB70", Offset = "0x28CAF70", Length = "0x2A")]
		[Token(Token = "0x6000711")]
		internal ReadOnly(ref NativeBitArray data) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[IsReadOnly]
		[Token(Token = "0x600071B")]
		private void CheckRead() { }

		[Address(RVA = "0x28CB310", Offset = "0x28CA710", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x600071A")]
		public int CountBits(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CB9D0", Offset = "0x28CADD0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000715")]
		public int Find(int pos, int numBits) { }

		[Address(RVA = "0x28CB9B0", Offset = "0x28CADB0", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000716")]
		public int Find(int pos, int count, int numBits) { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x600070F")]
		public bool get_IsCreated() { }

		[Address(RVA = "0x28CBBA0", Offset = "0x28CAFA0", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000710")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000712")]
		public int get_Length() { }

		[Address(RVA = "0x28CBA00", Offset = "0x28CAE00", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000713")]
		public ulong GetBits(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBA70", Offset = "0x28CAE70", Length = "0xB")]
		[IsReadOnly]
		[Token(Token = "0x6000714")]
		public bool IsSet(int pos) { }

		[Address(RVA = "0x28CBA80", Offset = "0x28CAE80", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000719")]
		public bool TestAll(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBAB0", Offset = "0x28CAEB0", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000718")]
		public bool TestAny(int pos, int numBits = 1) { }

		[Address(RVA = "0x28CBAE0", Offset = "0x28CAEE0", Length = "0x23")]
		[IsReadOnly]
		[Token(Token = "0x6000717")]
		public bool TestNone(int pos, int numBits = 1) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003AC")]
	internal UnsafeBitArray* m_BitArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003AD")]
	internal AllocatorHandle m_Allocator; //Field offset: 0x8

	[Token(Token = "0x170000AD")]
	public int Capacity
	{
		[Address(RVA = "0x28C88C0", Offset = "0x28C7CC0", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x60006FB")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170000AA")]
	public bool IsCreated
	{
		[Address(RVA = "0x28C88E0", Offset = "0x28C7CE0", Length = "0x14")]
		[IsReadOnly]
		[Token(Token = "0x60006F3")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000AB")]
	public bool IsEmpty
	{
		[Address(RVA = "0x28C8900", Offset = "0x28C7D00", Length = "0x1A")]
		[IsReadOnly]
		[Token(Token = "0x60006F4")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170000AC")]
	public int Length
	{
		[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
		[IsReadOnly]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 25
	}

	[Address(RVA = "0x28C87A0", Offset = "0x28C7BA0", Length = "0x115")]
	[Token(Token = "0x60006F2")]
	public NativeBitArray(int numBits, AllocatorHandle allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0x88F360", Offset = "0x88E760", Length = "0x8E")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x60006FD")]
	public NativeArray<T> AsNativeArray() { }

	[Address(RVA = "0x28C8260", Offset = "0x28C7660", Length = "0x2D")]
	[Token(Token = "0x600070B")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[IsReadOnly]
	[Token(Token = "0x600070C")]
	private void CheckRead() { }

	[Address(RVA = "0x88F3F0", Offset = "0x88E7F0", Length = "0x1E2")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x600070D")]
	private void CheckReadBounds() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x600070E")]
	private void CheckWrite() { }

	[Address(RVA = "0x28C8290", Offset = "0x28C7690", Length = "0x35")]
	[Token(Token = "0x60006FC")]
	public void Clear() { }

	[Address(RVA = "0x28C82F0", Offset = "0x28C76F0", Length = "0x2A")]
	[Token(Token = "0x6000703")]
	public void Copy(int dstPos, int srcPos, int numBits) { }

	[Address(RVA = "0x28C82D0", Offset = "0x28C76D0", Length = "0x14")]
	[Token(Token = "0x6000704")]
	public void Copy(int dstPos, ref NativeBitArray srcBitArray, int srcPos, int numBits) { }

	[Address(RVA = "0x28C8320", Offset = "0x28C7720", Length = "0x26")]
	[Token(Token = "0x600070A")]
	public int CountBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28C8450", Offset = "0x28C7850", Length = "0xC5")]
	[Token(Token = "0x60006F8")]
	public override void Dispose() { }

	[Address(RVA = "0x28C8350", Offset = "0x28C7750", Length = "0xFF")]
	[Token(Token = "0x60006F9")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x28C8520", Offset = "0x28C7920", Length = "0x27")]
	[Token(Token = "0x6000705")]
	public int Find(int pos, int numBits) { }

	[Address(RVA = "0x28C8550", Offset = "0x28C7950", Length = "0x14")]
	[Token(Token = "0x6000706")]
	public int Find(int pos, int count, int numBits) { }

	[Address(RVA = "0x28C88C0", Offset = "0x28C7CC0", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x60006FB")]
	public int get_Capacity() { }

	[Address(RVA = "0x28C88E0", Offset = "0x28C7CE0", Length = "0x14")]
	[IsReadOnly]
	[Token(Token = "0x60006F3")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x28C8900", Offset = "0x28C7D00", Length = "0x1A")]
	[IsReadOnly]
	[Token(Token = "0x60006F4")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x1E64320", Offset = "0x1E63720", Length = "0x19")]
	[IsReadOnly]
	[Token(Token = "0x60006FA")]
	public int get_Length() { }

	[Address(RVA = "0x28C8570", Offset = "0x28C7970", Length = "0x26")]
	[Token(Token = "0x6000701")]
	public ulong GetBits(int pos, int numBits = 1) { }

	[Address(RVA = "0x28C85A0", Offset = "0x28C79A0", Length = "0xE")]
	[Token(Token = "0x6000702")]
	public bool IsSet(int pos) { }

	[Address(RVA = "0x28C85B0", Offset = "0x28C79B0", Length = "0x69")]
	[Token(Token = "0x60006F5")]
	public void Resize(int numBits, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x28C8680", Offset = "0x28C7A80", Length = "0x6C")]
	[Token(Token = "0x60006FE")]
	public void Set(int pos, bool value) { }

	[Address(RVA = "0x28C8640", Offset = "0x28C7A40", Length = "0x11")]
	[Token(Token = "0x6000700")]
	public void SetBits(int pos, ulong value, int numBits = 1) { }

	[Address(RVA = "0x28C8620", Offset = "0x28C7A20", Length = "0x11")]
	[Token(Token = "0x60006FF")]
	public void SetBits(int pos, bool value, int numBits) { }

	[Address(RVA = "0x28C8660", Offset = "0x28C7A60", Length = "0x11")]
	[Token(Token = "0x60006F6")]
	public void SetCapacity(int capacityInBits) { }

	[Address(RVA = "0x28C86F0", Offset = "0x28C7AF0", Length = "0x26")]
	[Token(Token = "0x6000709")]
	public bool TestAll(int pos, int numBits = 1) { }

	[Address(RVA = "0x28C8720", Offset = "0x28C7B20", Length = "0x26")]
	[Token(Token = "0x6000708")]
	public bool TestAny(int pos, int numBits = 1) { }

	[Address(RVA = "0x28C8750", Offset = "0x28C7B50", Length = "0x26")]
	[Token(Token = "0x6000707")]
	public bool TestNone(int pos, int numBits = 1) { }

	[Address(RVA = "0x28C8780", Offset = "0x28C7B80", Length = "0x14")]
	[Token(Token = "0x60006F7")]
	public void TrimExcess() { }

}

