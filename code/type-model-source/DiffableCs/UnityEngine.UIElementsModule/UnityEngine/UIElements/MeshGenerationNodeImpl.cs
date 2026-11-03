namespace UnityEngine.UIElements;

[Token(Token = "0x20002DA")]
internal class MeshGenerationNodeImpl : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B98")]
	private GCHandle m_SelfHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B99")]
	private Entry m_ParentEntry; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B9A")]
	private EntryRecorder m_EntryRecorder; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B9B")]
	private bool <disposed>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170003E1")]
	protected private bool disposed
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013D7")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013D8")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3406210", Offset = "0x3405610", Length = "0x24")]
	[Token(Token = "0x60013CF")]
	public MeshGenerationNodeImpl() { }

	[Address(RVA = "0x3405E70", Offset = "0x3405270", Length = "0x6F")]
	[Token(Token = "0x60013D9")]
	public override void Dispose() { }

	[Address(RVA = "0x3405E30", Offset = "0x3405230", Length = "0x36")]
	[Token(Token = "0x60013DA")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x3405EE0", Offset = "0x34052E0", Length = "0xF5")]
	[Token(Token = "0x60013D6")]
	public void DrawGradients(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x3405FE0", Offset = "0x34053E0", Length = "0xD0")]
	[Token(Token = "0x60013D5")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013D7")]
	protected bool get_disposed() { }

	[Address(RVA = "0x34060C0", Offset = "0x34054C0", Length = "0x8")]
	[Token(Token = "0x60013D2")]
	public void GetNode(out MeshGenerationNode node) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60013D4")]
	public Entry GetParentEntry() { }

	[Address(RVA = "0x34060C0", Offset = "0x34054C0", Length = "0x8")]
	[Token(Token = "0x60013D3")]
	public void GetUnsafeNode(out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x34060D0", Offset = "0x34054D0", Length = "0xAD")]
	[Token(Token = "0x60013D0")]
	public void Init(Entry parentEntry, EntryRecorder entryRecorder, bool safe) { }

	[Address(RVA = "0x3406180", Offset = "0x3405580", Length = "0x88")]
	[Token(Token = "0x60013D1")]
	public void Reset() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013D8")]
	private void set_disposed(bool value) { }

}

