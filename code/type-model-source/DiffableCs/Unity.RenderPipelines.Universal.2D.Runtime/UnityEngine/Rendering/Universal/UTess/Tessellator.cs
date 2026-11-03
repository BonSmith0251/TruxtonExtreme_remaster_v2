namespace UnityEngine.Rendering.Universal.UTess;

[Token(Token = "0x200009B")]
internal struct Tessellator
{
	[Token(Token = "0x20000A1")]
	private struct TestCellE : ICondition2<int3, int3>
	{

		[Address(RVA = "0x2D569A0", Offset = "0x2D55DA0", Length = "0x75")]
		[Token(Token = "0x60003B3")]
		public override bool Test(int3 h, int3 p, ref float t) { }

	}

	[Token(Token = "0x20000A0")]
	private struct TestEdgePointE : ICondition2<int2, int2>
	{

		[Address(RVA = "0x2D56A20", Offset = "0x2D55E20", Length = "0x32")]
		[Token(Token = "0x60003B2")]
		public override bool Test(int2 h, int2 p, ref float t) { }

	}

	[Token(Token = "0x200009F")]
	private struct TestHullEventE : ICondition2<UHull, UEvent>
	{

		[Address(RVA = "0x2D56A60", Offset = "0x2D55E60", Length = "0x7E")]
		[Token(Token = "0x60003B1")]
		public override bool Test(UHull h, UEvent p, ref float t) { }

	}

	[Token(Token = "0x200009E")]
	private struct TestHullEventLe : ICondition2<UHull, UEvent>
	{

		[Address(RVA = "0x2D56AE0", Offset = "0x2D55EE0", Length = "0x70")]
		[Token(Token = "0x60003B0")]
		public override bool Test(UHull h, UEvent p, ref float t) { }

	}

	[Token(Token = "0x200009C")]
	private struct TestHullPointL : ICondition2<UHull, float2>
	{

		[Address(RVA = "0x2D56B50", Offset = "0x2D55F50", Length = "0xE9")]
		[Token(Token = "0x60003AE")]
		public override bool Test(UHull h, float2 p, ref float t) { }

	}

	[Token(Token = "0x200009D")]
	private struct TestHullPointU : ICondition2<UHull, float2>
	{

		[Address(RVA = "0x2D56C40", Offset = "0x2D56040", Length = "0xE9")]
		[Token(Token = "0x60003AF")]
		public override bool Test(UHull h, float2 p, ref float t) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002D1")]
	private NativeArray<int2> m_Edges; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D2")]
	private NativeArray<UStar> m_Stars; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D3")]
	private NativeArray<int3> m_Cells; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D4")]
	private int m_CellCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D5")]
	private NativeArray<Int32> m_ILArray; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D6")]
	private NativeArray<Int32> m_IUArray; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002D7")]
	private NativeArray<Int32> m_SPArray; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002D8")]
	private int m_NumEdges; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002D9")]
	private int m_NumHulls; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002DA")]
	private int m_NumPoints; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40002DB")]
	private int m_StarCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002DC")]
	private NativeArray<Int32> m_Flags; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002DD")]
	private NativeArray<Int32> m_Neighbors; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002DE")]
	private NativeArray<Int32> m_Constraints; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40002DF")]
	private Allocator m_Allocator; //Field offset: 0xA8

	[Address(RVA = "0x2D53070", Offset = "0x2D52470", Length = "0x4B6")]
	[Token(Token = "0x6000397")]
	private bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx) { }

	[Address(RVA = "0x2D53530", Offset = "0x2D52930", Length = "0x1C6")]
	[Token(Token = "0x60003A0")]
	private void AddTriangle(int i, int j, int k) { }

	[Address(RVA = "0x2D53700", Offset = "0x2D52B00", Length = "0x663")]
	[Token(Token = "0x60003A6")]
	internal bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges) { }

	[Address(RVA = "0x2D53D70", Offset = "0x2D53170", Length = "0x15D")]
	[Token(Token = "0x60003AD")]
	internal void Cleanup() { }

	[Address(RVA = "0x2D53ED0", Offset = "0x2D532D0", Length = "0x557")]
	[Token(Token = "0x60003A8")]
	private NativeArray<int3> Constrain(ref int count) { }

	[Address(RVA = "0x2D54430", Offset = "0x2D53830", Length = "0x104")]
	[Token(Token = "0x60003A3")]
	private void EdgeFlip(int i, int j) { }

	[Address(RVA = "0x2D54540", Offset = "0x2D53940", Length = "0x61")]
	[Token(Token = "0x6000399")]
	private static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count) { }

	[Address(RVA = "0x2D545B0", Offset = "0x2D539B0", Length = "0xAC")]
	[Token(Token = "0x600039F")]
	private int FindConstraint(int a, int b) { }

	[Address(RVA = "0x2D54660", Offset = "0x2D53A60", Length = "0xE7")]
	[Token(Token = "0x60003A7")]
	private int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c) { }

	[Address(RVA = "0x2D54750", Offset = "0x2D53B50", Length = "0x2CD")]
	[Token(Token = "0x6000395")]
	private static float FindSplit(UHull hull, UEvent edge) { }

	[Address(RVA = "0x2D54A20", Offset = "0x2D53E20", Length = "0x1F3")]
	[Token(Token = "0x60003A4")]
	private bool Flip(NativeArray<float2> points, ref NativeArray<Int32>& stack, ref int stackCount, int a, int b, int x) { }

	[Address(RVA = "0x2D54C20", Offset = "0x2D54020", Length = "0x197")]
	[Token(Token = "0x60003A5")]
	private NativeArray<int3> GetCells(ref int count) { }

	[Address(RVA = "0x2D54DC0", Offset = "0x2D541C0", Length = "0xBA")]
	[Token(Token = "0x6000398")]
	private static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value) { }

	[Address(RVA = "0x2D54E80", Offset = "0x2D54280", Length = "0x85")]
	[Token(Token = "0x600039C")]
	private static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount) { }

	[Address(RVA = "0x2D54F10", Offset = "0x2D54310", Length = "0x28F")]
	[Token(Token = "0x600039B")]
	private bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	[Address(RVA = "0x2D551A0", Offset = "0x2D545A0", Length = "0xCE")]
	[Token(Token = "0x600039E")]
	private int OppositeOf(int a, int b) { }

	[Address(RVA = "0x2D55270", Offset = "0x2D54670", Length = "0x508")]
	[Token(Token = "0x600039D")]
	private void PrepareDelaunay(NativeArray<int2> edges, int edgeCount) { }

	[Address(RVA = "0x2D55780", Offset = "0x2D54B80", Length = "0x11C")]
	[Token(Token = "0x60003A9")]
	internal NativeArray<int3> RemoveExterior(ref int cellCount) { }

	[Address(RVA = "0x2D558A0", Offset = "0x2D54CA0", Length = "0x106")]
	[Token(Token = "0x60003AA")]
	internal NativeArray<int3> RemoveInterior(int cellCount) { }

	[Address(RVA = "0x2D559B0", Offset = "0x2D54DB0", Length = "0x15D")]
	[Token(Token = "0x60003A1")]
	private void RemovePair(int r, int j, int k) { }

	[Address(RVA = "0x2D55B10", Offset = "0x2D54F10", Length = "0x73")]
	[Token(Token = "0x60003A2")]
	private void RemoveTriangle(int i, int j, int k) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[Token(Token = "0x6000396")]
	private void SetAllocator(Allocator allocator) { }

	[Address(RVA = "0x2D55B90", Offset = "0x2D54F90", Length = "0x402")]
	[Token(Token = "0x600039A")]
	private bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt) { }

	[Address(RVA = "0x2D55FA0", Offset = "0x2D553A0", Length = "0x318")]
	[Token(Token = "0x60003AC")]
	internal static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2>& outputVertices, ref int vertexCount, ref NativeArray<Int32>& outputIndices, ref int indexCount) { }

	[Address(RVA = "0x2D562C0", Offset = "0x2D556C0", Length = "0x6D9")]
	[Token(Token = "0x60003AB")]
	internal bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount) { }

}

