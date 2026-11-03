namespace UnityEngine.UIElements;

[Token(Token = "0x20004A1")]
internal class ATGTextJobSystem
{
	[CompilerGenerated]
	[Token(Token = "0x20004A6")]
	private sealed class <>c
	{
		[Token(Token = "0x4000F7E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32AFE40", Offset = "0x32AF240", Length = "0x67")]
		[Token(Token = "0x60022DA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60022DB")]
		public <>c() { }

		[Address(RVA = "0x32AFAE0", Offset = "0x32AEEE0", Length = "0x44")]
		[Token(Token = "0x60022DC")]
		internal ManagedJobData <.cctor>b__26_0() { }

		[Address(RVA = "0x32AFB30", Offset = "0x32AEF30", Length = "0x1F")]
		[Token(Token = "0x60022DD")]
		internal void <.cctor>b__26_1(ManagedJobData inst) { }

		[Address(RVA = "0x32AFB50", Offset = "0x32AEF50", Length = "0x55")]
		[Token(Token = "0x60022DE")]
		internal Dictionary<Int32, HashSet`1<UInt32>> <.cctor>b__26_2() { }

		[Address(RVA = "0x32AFBB0", Offset = "0x32AEFB0", Length = "0x140")]
		[Token(Token = "0x60022DF")]
		internal void <.cctor>b__26_3(Dictionary<Int32, HashSet`1<UInt32>> dict) { }

	}

	[Token(Token = "0x20004A5")]
	private struct ConvertToUIRVertexJobData : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7C")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4000F7D")]
		public TempMeshAllocator alloc; //Field offset: 0x8

		[Address(RVA = "0x32A01B0", Offset = "0x329F5B0", Length = "0x1EF")]
		[Token(Token = "0x60022D9")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x20004A4")]
	private struct GenerateTextJobData : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F7A")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4000F7B")]
		public TempMeshAllocator alloc; //Field offset: 0x8

		[Address(RVA = "0x32A05E0", Offset = "0x329F9E0", Length = "0x307")]
		[Token(Token = "0x60022D8")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x20004A2")]
	private class ManagedJobData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F6C")]
		public TextElement textElement; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000F6D")]
		public MeshGenerationNode node; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F6E")]
		public NativeTextInfo textInfo; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000F6F")]
		public bool success; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000F70")]
		public List<Texture2D> atlases; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000F71")]
		public List<Single> sdfScales; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000F72")]
		public List<NativeSlice`1<Vertex>> vertices; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000F73")]
		public List<NativeSlice`1<UInt16>> indices; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000F74")]
		public List<GlyphRenderMode> renderModes; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000F75")]
		public List<List`1<List`1<Int32>>> textElementIndicesByMesh; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000F76")]
		public List<Boolean> hasMultipleColorsByMesh; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000F77")]
		public Dictionary<Int32, HashSet`1<UInt32>> missingGlyphsPerFontAsset; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000F78")]
		public bool hasMissingGlyphs; //Field offset: 0x80

		[Address(RVA = "0x32A1640", Offset = "0x32A0A40", Length = "0x265")]
		[Token(Token = "0x60022D6")]
		public ManagedJobData() { }

		[Address(RVA = "0x32A1050", Offset = "0x32A0450", Length = "0x469")]
		[Token(Token = "0x60022D5")]
		public void Clear() { }

	}

	[Token(Token = "0x20004A3")]
	private struct PrepareShapingJob : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F79")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0

		[Address(RVA = "0x32A1BA0", Offset = "0x32A0FA0", Length = "0xB3")]
		[Token(Token = "0x60022D7")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x4000F61")]
	private static readonly ObjectPool<ManagedJobData> s_JobDataPool; //Field offset: 0x0
	[Token(Token = "0x4000F62")]
	private static ObjectPool<Dictionary`2<Int32, HashSet`1<UInt32>>> s_AggregatedMissingGlyphsPool; //Field offset: 0x8
	[Token(Token = "0x4000F66")]
	private static readonly ProfilerMarker k_GenerateTextMarker; //Field offset: 0x10
	[Token(Token = "0x4000F67")]
	private static readonly ProfilerMarker k_ATGTextJobMarker; //Field offset: 0x18
	[Token(Token = "0x4000F68")]
	private static readonly ProfilerMarker k_PrepareShapingMarker; //Field offset: 0x20
	[Token(Token = "0x4000F69")]
	private static readonly bool k_IsMultiThreaded; //Field offset: 0x28
	[Token(Token = "0x4000F6B")]
	private static List<UInt32> s_GlyphsToAddBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F5E")]
	private GCHandle textJobDatasHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5F")]
	private List<ManagedJobData> textJobDatas; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F60")]
	private bool hasPendingTextWork; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F63")]
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F64")]
	internal MeshGenerationCallback m_PopulateGlyphsCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F65")]
	internal MeshGenerationCallback m_AddDrawEntriesCallback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F6A")]
	private List<TextElement> m_PrepareShapingDataList; //Field offset: 0x40

	[Address(RVA = "0x329FB40", Offset = "0x329EF40", Length = "0x3D3")]
	[Token(Token = "0x60022D4")]
	private static ATGTextJobSystem() { }

	[Address(RVA = "0x329FF20", Offset = "0x329F320", Length = "0x189")]
	[Token(Token = "0x60022CC")]
	public ATGTextJobSystem() { }

	[Address(RVA = "0x329D7A0", Offset = "0x329CBA0", Length = "0x3C7")]
	[Token(Token = "0x60022D2")]
	private void AddDrawEntries(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x329DB70", Offset = "0x329CF70", Length = "0xC4C")]
	[Token(Token = "0x60022D3")]
	private static void ConvertMeshInfoToUIRVertex(Span<ATGMeshInfo> meshInfos, TempMeshAllocator alloc, TextElement visualElement, List<List`1<List`1<Int32>>> textElementIndicesByMesh, List<Boolean> hasMultipleColorsByMesh, ref List<Texture2D>& atlases, ref List<NativeSlice`1<Vertex>>& verticesArray, ref List<NativeSlice`1<UInt16>>& indicesArray, ref List<GlyphRenderMode>& renderModes, ref List<Single>& sdfScales) { }

	[Address(RVA = "0x329EA40", Offset = "0x329DE40", Length = "0x1CE")]
	[Token(Token = "0x60022CF")]
	public void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	[Address(RVA = "0x329E7C0", Offset = "0x329DBC0", Length = "0x27D")]
	[Token(Token = "0x60022D0")]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x329EC10", Offset = "0x329E010", Length = "0x885")]
	[Token(Token = "0x60022D1")]
	private void PopulateGlyphs(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x329F4A0", Offset = "0x329E8A0", Length = "0x51A")]
	[Token(Token = "0x60022CE")]
	internal void PrepareShapingBeforeLayout(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x329F9C0", Offset = "0x329EDC0", Length = "0x173")]
	[Token(Token = "0x60022CD")]
	private static bool PrepareTextElementForJobsOnMainThread(TextElement textElement) { }

}

