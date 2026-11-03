namespace UnityEngine.Rendering;

[Token(Token = "0x20000FC")]
internal class ProbeGlobalIndirection
{
	[Token(Token = "0x20000FD")]
	public struct IndexMetaData
	{
		[Token(Token = "0x40003A7")]
		private static UInt32[] s_PackedValues; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003A8")]
		internal Vector3Int minLocalIdx; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40003A9")]
		internal Vector3Int maxLocalIdxPlusOne; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003AA")]
		internal int firstChunkIndex; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40003AB")]
		internal int minSubdiv; //Field offset: 0x1C

		[Address(RVA = "0x2C0DE20", Offset = "0x2C0D220", Length = "0x68")]
		[Token(Token = "0x60008CB")]
		private static IndexMetaData() { }

		[Address(RVA = "0x2C0DC20", Offset = "0x2C0D020", Length = "0x1F5")]
		[Token(Token = "0x60008CA")]
		internal void Pack(out UInt32[] vals) { }

	}

	[Token(Token = "0x400039D")]
	private const int kUintPerEntry = 3; //Field offset: 0x0
	[Token(Token = "0x400039F")]
	internal const int kEntryMaxSubdivLevel = 3; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039E")]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A0")]
	private ComputeBuffer m_IndexOfIndicesBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A1")]
	private UInt32[] m_IndexOfIndicesData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003A2")]
	private int m_CellSizeInMinBricks; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003A3")]
	private Vector3Int m_EntriesCount; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003A4")]
	private Vector3Int m_EntryMin; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003A5")]
	private Vector3Int m_EntryMax; //Field offset: 0x44
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003A6")]
	private bool m_NeedUpdateComputeBuffer; //Field offset: 0x50

	[Token(Token = "0x170000F7")]
	internal int entriesPerCellDimension
	{
		[Address(RVA = "0x2C15AA0", Offset = "0x2C14EA0", Length = "0x40")]
		[Token(Token = "0x60008C0")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x170000F6")]
	private int entrySizeInBricks
	{
		[Address(RVA = "0x2C15AE0", Offset = "0x2C14EE0", Length = "0x28")]
		[Token(Token = "0x60008BF")]
		private get { } //Length: 40
	}

	[Token(Token = "0x170000F5")]
	internal int estimatedVMemCost
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60008BA")]
		internal get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60008BB")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C15730", Offset = "0x2C14B30", Length = "0x370")]
	[Token(Token = "0x60008C2")]
	internal ProbeGlobalIndirection(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks) { }

	[Address(RVA = "0x2C14D80", Offset = "0x2C14180", Length = "0x69")]
	[Token(Token = "0x60008C9")]
	internal void Cleanup() { }

	[Address(RVA = "0x2C15AA0", Offset = "0x2C14EA0", Length = "0x40")]
	[Token(Token = "0x60008C0")]
	internal int get_entriesPerCellDimension() { }

	[Address(RVA = "0x2C15AE0", Offset = "0x2C14EE0", Length = "0x28")]
	[Token(Token = "0x60008BF")]
	private int get_entrySizeInBricks() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x60008BA")]
	internal int get_estimatedVMemCost() { }

	[Address(RVA = "0x2C14DF0", Offset = "0x2C141F0", Length = "0x78")]
	[Token(Token = "0x60008C3")]
	internal int GetFlatIdxForEntry(Vector3Int entryPosition) { }

	[Address(RVA = "0x2C14E70", Offset = "0x2C14270", Length = "0x11")]
	[Token(Token = "0x60008C1")]
	private int GetFlatIndex(Vector3Int normalizedPos) { }

	[Address(RVA = "0x2C14E90", Offset = "0x2C14290", Length = "0x248")]
	[Token(Token = "0x60008C4")]
	internal Int32[] GetFlatIndicesForCell(Vector3Int cellPosition) { }

	[Address(RVA = "0x2C150E0", Offset = "0x2C144E0", Length = "0x13")]
	[Token(Token = "0x60008BD")]
	internal Vector3Int GetGlobalIndirectionDimension() { }

	[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
	[Token(Token = "0x60008BE")]
	internal Vector3Int GetGlobalIndirectionMinEntry() { }

	[Address(RVA = "0x2C15100", Offset = "0x2C14500", Length = "0x21")]
	[Token(Token = "0x60008BC")]
	internal void GetMinMaxEntry(out Vector3Int minEntry, out Vector3Int maxEntry) { }

	[Address(RVA = "0x2C15130", Offset = "0x2C14530", Length = "0x4F")]
	[Token(Token = "0x60008C8")]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[Address(RVA = "0x2C15180", Offset = "0x2C14580", Length = "0x88")]
	[Token(Token = "0x60008C6")]
	internal void MarkEntriesAsUnloaded(Int32[] entriesFlatIndices) { }

	[Address(RVA = "0x2C15210", Offset = "0x2C14610", Length = "0x2D")]
	[Token(Token = "0x60008C7")]
	internal void PushComputeData() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60008BB")]
	private void set_estimatedVMemCost(int value) { }

	[Address(RVA = "0x2C15240", Offset = "0x2C14640", Length = "0x4E4")]
	[Token(Token = "0x60008C5")]
	internal void UpdateCell(CellIndexInfo cellInfo) { }

}

