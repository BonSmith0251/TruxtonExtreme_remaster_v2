namespace UnityEngine.Rendering;

[Token(Token = "0x20000CF")]
internal struct SilhouettePlaneCache : IDisposable
{
	[Token(Token = "0x20000D0")]
	private struct Slot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003C1")]
		public bool isActive; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003C2")]
		public int viewInstanceID; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003C3")]
		public int planeCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40003C4")]
		public int lastUsedFrameIndex; //Field offset: 0xC

		[Address(RVA = "0x2D03190", Offset = "0x2D02590", Length = "0xF")]
		[Token(Token = "0x600035B")]
		public Slot(int viewInstanceID, int planeCount, int frameIndex) { }

	}

	[Token(Token = "0x40003BC")]
	private const int kMaxSilhouettePlanes = 6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003BD")]
	private NativeParallelHashMap<Int32, Int32> m_SubviewIDToIndexMap; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003BE")]
	private NativeList<Int32> m_SlotFreeList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003BF")]
	private NativeList<Slot> m_Slots; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C0")]
	private NativeList<Plane> m_PlaneStorage; //Field offset: 0x20

	[Address(RVA = "0x2D028F0", Offset = "0x2D01CF0", Length = "0x8D")]
	[Token(Token = "0x6000357")]
	public override void Dispose() { }

	[Address(RVA = "0x2D02980", Offset = "0x2D01D80", Length = "0x1B5")]
	[Token(Token = "0x6000359")]
	public void FreeUnusedSlots(int frameIndex, int maximumAge) { }

	[Address(RVA = "0x2D02B40", Offset = "0x2D01F40", Length = "0x12F")]
	[Token(Token = "0x600035A")]
	public NativeArray<Plane> GetSubArray(int viewInstanceID) { }

	[Address(RVA = "0x2D02C70", Offset = "0x2D02070", Length = "0x129")]
	[Token(Token = "0x6000356")]
	public void Init() { }

	[Address(RVA = "0x2D02DA0", Offset = "0x2D021A0", Length = "0x3E2")]
	[Token(Token = "0x6000358")]
	public void Update(int viewInstanceID, NativeArray<Plane> planes, int frameIndex) { }

}

