namespace UnityEngine.UIElements;

[Token(Token = "0x20004B3")]
internal class UITKTextJobSystem
{
	[CompilerGenerated]
	[Token(Token = "0x20004B7")]
	private sealed class <>c
	{
		[Token(Token = "0x400100B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32AFDD0", Offset = "0x32AF1D0", Length = "0x67")]
		[Token(Token = "0x60023D5")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60023D6")]
		public <>c() { }

		[Address(RVA = "0x32AF7C0", Offset = "0x32AEBC0", Length = "0x44")]
		[Token(Token = "0x60023D7")]
		internal ManagedJobData <.cctor>b__25_0() { }

		[Address(RVA = "0x32AF810", Offset = "0x32AEC10", Length = "0x25")]
		[Token(Token = "0x60023D8")]
		internal void <.cctor>b__25_1(ManagedJobData inst) { }

		[Address(RVA = "0x32AF840", Offset = "0x32AEC40", Length = "0x55")]
		[Token(Token = "0x60023D9")]
		internal List<Material> <.cctor>b__25_2() { }

		[Address(RVA = "0x32AF8A0", Offset = "0x32AECA0", Length = "0x5B")]
		[Token(Token = "0x60023DA")]
		internal void <.cctor>b__25_3(List<Material> list) { }

		[Address(RVA = "0x32AF900", Offset = "0x32AED00", Length = "0x55")]
		[Token(Token = "0x60023DB")]
		internal List<GlyphRenderMode> <.cctor>b__25_4() { }

		[Address(RVA = "0x32AF960", Offset = "0x32AED60", Length = "0x3F")]
		[Token(Token = "0x60023DC")]
		internal void <.cctor>b__25_5(List<GlyphRenderMode> list) { }

		[Address(RVA = "0x32AF9A0", Offset = "0x32AEDA0", Length = "0x55")]
		[Token(Token = "0x60023DD")]
		internal List<NativeSlice`1<Vertex>> <.cctor>b__25_6() { }

		[Address(RVA = "0x32AFA00", Offset = "0x32AEE00", Length = "0x3F")]
		[Token(Token = "0x60023DE")]
		internal void <.cctor>b__25_7(List<NativeSlice`1<Vertex>> list) { }

		[Address(RVA = "0x32AFA40", Offset = "0x32AEE40", Length = "0x55")]
		[Token(Token = "0x60023DF")]
		internal List<NativeSlice`1<UInt16>> <.cctor>b__25_8() { }

		[Address(RVA = "0x32AFAA0", Offset = "0x32AEEA0", Length = "0x3F")]
		[Token(Token = "0x60023E0")]
		internal void <.cctor>b__25_9(List<NativeSlice`1<UInt16>> list) { }

	}

	[Token(Token = "0x20004B6")]
	private struct GenerateTextJobData : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001009")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x400100A")]
		public TempMeshAllocator alloc; //Field offset: 0x8

		[Address(RVA = "0x32A03A0", Offset = "0x329F7A0", Length = "0x23F")]
		[Token(Token = "0x60023D4")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x20004B4")]
	private class ManagedJobData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001001")]
		public TextElement visualElement; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001002")]
		public MeshGenerationNode node; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001003")]
		public List<Material> materials; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001004")]
		public List<GlyphRenderMode> renderModes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001005")]
		public List<NativeSlice`1<Vertex>> vertices; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001006")]
		public List<NativeSlice`1<UInt16>> indices; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001007")]
		public bool prepareSuccess; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60023D2")]
		public ManagedJobData() { }

		[Address(RVA = "0x32A14C0", Offset = "0x32A08C0", Length = "0x170")]
		[Token(Token = "0x60023D1")]
		public void Release() { }

	}

	[Token(Token = "0x20004B5")]
	private struct PrepareTextJobData : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001008")]
		public GCHandle managedJobDataHandle; //Field offset: 0x0

		[Address(RVA = "0x32A1C60", Offset = "0x32A1060", Length = "0xF6")]
		[Token(Token = "0x60023D3")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x4000FF2")]
	private static readonly ProfilerMarker k_ExecuteMarker; //Field offset: 0x0
	[Token(Token = "0x4000FF3")]
	private static readonly ProfilerMarker k_UpdateMainThreadMarker; //Field offset: 0x8
	[Token(Token = "0x4000FF4")]
	private static readonly ProfilerMarker k_PrepareMainThreadMarker; //Field offset: 0x10
	[Token(Token = "0x4000FF5")]
	private static readonly ProfilerMarker k_PrepareJobifiedMarker; //Field offset: 0x18
	[Token(Token = "0x4000FF9")]
	private static ObjectPool<ManagedJobData> s_JobDataPool; //Field offset: 0x20
	[Token(Token = "0x4000FFA")]
	private static ObjectPool<List`1<Material>> s_MaterialsPool; //Field offset: 0x28
	[Token(Token = "0x4000FFB")]
	private static ObjectPool<List`1<GlyphRenderMode>> s_RenderModesPool; //Field offset: 0x30
	[Token(Token = "0x4000FFC")]
	private static ObjectPool<List`1<NativeSlice`1<Vertex>>> s_VerticesPool; //Field offset: 0x38
	[Token(Token = "0x4000FFD")]
	private static ObjectPool<List`1<NativeSlice`1<UInt16>>> s_IndicesPool; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF6")]
	private GCHandle textJobDatasHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF7")]
	private List<ManagedJobData> textJobDatas; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF8")]
	private bool hasPendingTextWork; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FFE")]
	internal MeshGenerationCallback m_PrepareTextJobifiedCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FFF")]
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001000")]
	internal MeshGenerationCallback m_AddDrawEntriesCallback; //Field offset: 0x38

	[Address(RVA = "0x32B6640", Offset = "0x32B5A40", Length = "0x745")]
	[Token(Token = "0x60023D0")]
	private static UITKTextJobSystem() { }

	[Address(RVA = "0x32B6D90", Offset = "0x32B6190", Length = "0x143")]
	[Token(Token = "0x60023C9")]
	public UITKTextJobSystem() { }

	[Address(RVA = "0x32B4FB0", Offset = "0x32B43B0", Length = "0x3E4")]
	[Token(Token = "0x60023CF")]
	private void AddDrawEntries(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x32B53A0", Offset = "0x32B47A0", Length = "0xAAA")]
	[Token(Token = "0x60023CE")]
	private static void ConvertMeshInfoToUIRVertex(MeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Material>& materials, ref List<NativeSlice`1<Vertex>>& verticesArray, ref List<NativeSlice`1<UInt16>>& indicesArray, ref List<GlyphRenderMode>& renderModes) { }

	[Address(RVA = "0x32B62E0", Offset = "0x32B56E0", Length = "0x19B")]
	[Token(Token = "0x60023CB")]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	[Address(RVA = "0x32B5E50", Offset = "0x32B5250", Length = "0x483")]
	[Token(Token = "0x60023CD")]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _) { }

	[Address(RVA = "0x32B6480", Offset = "0x32B5880", Length = "0x65")]
	[Token(Token = "0x60023CA")]
	private static void OnGetManagedJob(ManagedJobData managedJobData) { }

	[Address(RVA = "0x32B64F0", Offset = "0x32B58F0", Length = "0x144")]
	[Token(Token = "0x60023CC")]
	internal void PrepareTextJobified(MeshGenerationContext mgc, object _) { }

}

