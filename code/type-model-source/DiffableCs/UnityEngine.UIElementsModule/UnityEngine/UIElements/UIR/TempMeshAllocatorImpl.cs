namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005DD")]
internal class TempMeshAllocatorImpl : IDisposable
{
	[Token(Token = "0x20005DE")]
	private struct ThreadData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400155A")]
		public List<IntPtr> allocations; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001555")]
	private GCHandle m_GCHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001556")]
	private ThreadData[] m_ThreadData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001557")]
	private TempAllocator<Vertex> m_VertexPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001558")]
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001559")]
	private bool <disposed>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000A8C")]
	protected private bool disposed
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002A35")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A36")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3327D20", Offset = "0x3327120", Length = "0x1DE")]
	[Token(Token = "0x6002A30")]
	public TempMeshAllocatorImpl() { }

	[Address(RVA = "0x942C10", Offset = "0x942010", Length = "0x1C5")]
	[Token(Token = "0x6002A32")]
	private NativeSlice<T> Allocate(int count, int alignment) { }

	[Address(RVA = "0x3327740", Offset = "0x3326B40", Length = "0x26E")]
	[Token(Token = "0x6002A33")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x33279B0", Offset = "0x3326DB0", Length = "0x1F4")]
	[Token(Token = "0x6002A34")]
	public void Clear() { }

	[Address(RVA = "0x3327BB0", Offset = "0x3326FB0", Length = "0xC")]
	[Token(Token = "0x6002A31")]
	public void CreateNativeHandle(out TempMeshAllocator allocator) { }

	[Address(RVA = "0x3327BC0", Offset = "0x3326FC0", Length = "0xBF")]
	[Token(Token = "0x6002A37")]
	public override void Dispose() { }

	[Address(RVA = "0x3327C80", Offset = "0x3327080", Length = "0x96")]
	[Token(Token = "0x6002A38")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002A35")]
	protected bool get_disposed() { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A36")]
	private void set_disposed(bool value) { }

}

