namespace UnityEngine.UIElements;

[Token(Token = "0x20002DC")]
public class Painter2D : IDisposable
{
	[Token(Token = "0x20002DE")]
	private struct Painter2DJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000BB3")]
		public IntPtr painterHandle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4000BB4")]
		public TempMeshAllocator allocator; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x4000BB5")]
		public NativeSlice<Painter2DJobData> jobParameters; //Field offset: 0x10

		[Address(RVA = "0x3406EC0", Offset = "0x34062C0", Length = "0x5A7")]
		[Token(Token = "0x60013ED")]
		public override void Execute(int i) { }

	}

	[Token(Token = "0x20002DD")]
	private struct Painter2DJobData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BAF")]
		public UnsafeMeshGenerationNode node; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BB0")]
		public int snapshotIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BB1")]
		public IntPtr vectorImagePtr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BB2")]
		public IntPtr texturePtr; //Field offset: 0x18

	}

	[Token(Token = "0x4000BA0")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000BAB")]
	private static bool <isPainterActive>k__BackingField; //Field offset: 0x10
	[Token(Token = "0x4000BAC")]
	private static readonly ProfilerMarker s_StrokeMarker; //Field offset: 0x18
	[Token(Token = "0x4000BAD")]
	private static readonly ProfilerMarker s_FillMarker; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA1")]
	private MeshGenerationContext m_Ctx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BA2")]
	internal DetachedAllocator m_DetachedAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BA3")]
	internal SafeHandleAccess m_Handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BA4")]
	private FillGradient m_FillGradient; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BA5")]
	private Texture2D m_FillTexture; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BA6")]
	private FillGradient m_StrokeFillGradient; //Field offset: 0x68
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000BA7")]
	private List<Painter2DJobData> m_JobSnapshots; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000BA8")]
	private List<VectorImage> m_VectorImageToRelease; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000BA9")]
	private NativeArray<Painter2DJobData> m_JobParameters; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000BAA")]
	private bool m_Disposed; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000BAE")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0xC8

	[Token(Token = "0x170003E3")]
	internal static bool isPainterActive
	{
		[Address(RVA = "0x3407FD0", Offset = "0x34073D0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x60013E9")]
		internal set { } //Length: 84
	}

	[Address(RVA = "0x3407BB0", Offset = "0x3406FB0", Length = "0xF6")]
	[Token(Token = "0x60013EC")]
	private static Painter2D() { }

	[Address(RVA = "0x3407CB0", Offset = "0x34070B0", Length = "0x19B")]
	[Token(Token = "0x60013E4")]
	internal Painter2D(MeshGenerationContext ctx) { }

	[Address(RVA = "0x3407E50", Offset = "0x3407250", Length = "0x179")]
	[Token(Token = "0x60013E5")]
	public Painter2D() { }

	[Address(RVA = "0x34076F0", Offset = "0x3406AF0", Length = "0x56")]
	[Token(Token = "0x60013E7")]
	public override void Dispose() { }

	[Address(RVA = "0x3407470", Offset = "0x3406870", Length = "0x275")]
	[Token(Token = "0x60013E8")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x3407750", Offset = "0x3406B50", Length = "0x71")]
	[Token(Token = "0x60013EB")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[Address(RVA = "0x34077D0", Offset = "0x3406BD0", Length = "0x71")]
	[Token(Token = "0x60013E6")]
	internal void Reset() { }

	[Address(RVA = "0x3407850", Offset = "0x3406C50", Length = "0x350")]
	[Token(Token = "0x60013EA")]
	internal void ScheduleJobs(MeshGenerationContext mgc) { }

	[Address(RVA = "0x3407FD0", Offset = "0x34073D0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x60013E9")]
	internal static void set_isPainterActive(bool value) { }

}

