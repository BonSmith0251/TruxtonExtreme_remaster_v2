namespace UnityEngine.UIElements;

[Token(Token = "0x20002D6")]
public class MeshGenerationContext
{
	[Flags]
	[Token(Token = "0x20002D7")]
	public enum MeshFlags : int
	{
		None = 0,
		SkipDynamicAtlas = 2,
		IsUsingVectorImageGradients = 4,
		SliceTiled = 8,
	}

	[Token(Token = "0x4000B8E")]
	private static readonly ProfilerMarker k_AllocateMarker; //Field offset: 0x0
	[Token(Token = "0x4000B8F")]
	private static readonly ProfilerMarker k_DrawVectorImageMarker; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B84")]
	private VisualElement <visualElement>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B85")]
	private RenderData <renderData>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B86")]
	private Painter2D m_Painter2D; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B87")]
	private MeshWriteDataPool m_MeshWriteDataPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B88")]
	private TempMeshAllocatorImpl m_Allocator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B89")]
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B8A")]
	private MeshGenerationNodeManager m_MeshGenerationNodeManager; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B8B")]
	private IMeshGenerator <meshGenerator>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B8C")]
	private EntryRecorder <entryRecorder>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B8D")]
	private Entry <parentEntry>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B90")]
	private bool <disposed>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x170003E0")]
	internal bool disposed
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013C2")]
		internal get { } //Length: 5
		[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013C3")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003DE")]
	internal EntryRecorder entryRecorder
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013B5")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60013B6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003DC")]
	internal bool hasPainter2D
	{
		[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
		[Token(Token = "0x60013B2")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170003DD")]
	internal IMeshGenerator meshGenerator
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013B3")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60013B4")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003DB")]
	public Painter2D painter2D
	{
		[Address(RVA = "0x3405BF0", Offset = "0x3404FF0", Length = "0x23B")]
		[Token(Token = "0x60013B1")]
		 get { } //Length: 571
	}

	[Token(Token = "0x170003DF")]
	internal Entry parentEntry
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013B7")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60013B8")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003DA")]
	internal RenderData renderData
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013AF")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60013B0")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170003D9")]
	public private VisualElement visualElement
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013AD")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60013AE")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3405A70", Offset = "0x3404E70", Length = "0x98")]
	[Token(Token = "0x60013C6")]
	private static MeshGenerationContext() { }

	[Address(RVA = "0x3405B10", Offset = "0x3404F10", Length = "0xDB")]
	[Token(Token = "0x60013B9")]
	internal MeshGenerationContext(MeshWriteDataPool meshWriteDataPool, EntryRecorder entryRecorder, TempMeshAllocatorImpl allocator, MeshGenerationDeferrer meshGenerationDeferrer, MeshGenerationNodeManager meshGenerationNodeManager) { }

	[Address(RVA = "0x34053B0", Offset = "0x34047B0", Length = "0x2D")]
	[Token(Token = "0x60013BF")]
	internal void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	[Address(RVA = "0x34053E0", Offset = "0x34047E0", Length = "0x2C")]
	[Token(Token = "0x60013BE")]
	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	[Address(RVA = "0x3405410", Offset = "0x3404810", Length = "0x24")]
	[Token(Token = "0x60013BA")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x3405440", Offset = "0x3404840", Length = "0x193")]
	[Token(Token = "0x60013C0")]
	internal void Begin(Entry parentEntry, VisualElement ve, RenderData renderData) { }

	[Address(RVA = "0x34055E0", Offset = "0x34049E0", Length = "0x175")]
	[Token(Token = "0x60013C4")]
	internal void Dispose() { }

	[Address(RVA = "0x3405760", Offset = "0x3404B60", Length = "0x146")]
	[Token(Token = "0x60013C5")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x34058B0", Offset = "0x3404CB0", Length = "0xD9")]
	[Token(Token = "0x60013C1")]
	internal void End() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013C2")]
	internal bool get_disposed() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013B5")]
	internal EntryRecorder get_entryRecorder() { }

	[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
	[Token(Token = "0x60013B2")]
	internal bool get_hasPainter2D() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013B3")]
	internal IMeshGenerator get_meshGenerator() { }

	[Address(RVA = "0x3405BF0", Offset = "0x3404FF0", Length = "0x23B")]
	[Token(Token = "0x60013B1")]
	public Painter2D get_painter2D() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013B7")]
	internal Entry get_parentEntry() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013AF")]
	internal RenderData get_renderData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013AD")]
	public VisualElement get_visualElement() { }

	[Address(RVA = "0x3405990", Offset = "0x3404D90", Length = "0x1E")]
	[Token(Token = "0x60013BB")]
	public void GetTempMeshAllocator(out TempMeshAllocator allocator) { }

	[Address(RVA = "0x34059B0", Offset = "0x3404DB0", Length = "0x58")]
	[Token(Token = "0x60013BC")]
	public void InsertMeshGenerationNode(out MeshGenerationNode node) { }

	[Address(RVA = "0x3405A10", Offset = "0x3404E10", Length = "0x58")]
	[Token(Token = "0x60013BD")]
	internal void InsertUnsafeMeshGenerationNode(out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x28A42A0", Offset = "0x28A36A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013C3")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60013B6")]
	private void set_entryRecorder(EntryRecorder value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60013B4")]
	internal void set_meshGenerator(IMeshGenerator value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60013B8")]
	private void set_parentEntry(Entry value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60013B0")]
	private void set_renderData(RenderData value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60013AE")]
	private void set_visualElement(VisualElement value) { }

}

