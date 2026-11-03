namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005BA")]
internal class OpacityIdAccelerator : IDisposable
{
	[Token(Token = "0x20005BB")]
	private struct OpacityIdUpdateJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		[Token(Token = "0x400143D")]
		public NativeSlice<Vertex> oldVerts; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[Token(Token = "0x400143E")]
		public NativeSlice<Vertex> newVerts; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400143F")]
		public Color32 opacityData; //Field offset: 0x20

		[Address(RVA = "0x3303EF0", Offset = "0x33032F0", Length = "0xDE")]
		[Token(Token = "0x6002937")]
		public override void Execute(int i) { }

	}

	[Token(Token = "0x4001437")]
	private const int k_VerticesPerBatch = 128; //Field offset: 0x0
	[Token(Token = "0x4001438")]
	private const int k_JobLimit = 256; //Field offset: 0x0
	[Token(Token = "0x4001439")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400143A")]
	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400143B")]
	private int m_NextJobIndex; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400143C")]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x17000A57")]
	protected private bool disposed
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002931")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002932")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3303DB0", Offset = "0x33031B0", Length = "0x82")]
	[Token(Token = "0x6002936")]
	private static OpacityIdAccelerator() { }

	[Address(RVA = "0x3303E40", Offset = "0x3303240", Length = "0xA4")]
	[Token(Token = "0x6002935")]
	public OpacityIdAccelerator() { }

	[Address(RVA = "0x3303B00", Offset = "0x3302F00", Length = "0xA8")]
	[Token(Token = "0x6002930")]
	public void CompleteJobs() { }

	[Address(RVA = "0x3303BB0", Offset = "0x3302FB0", Length = "0x123")]
	[Token(Token = "0x600292F")]
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	[Address(RVA = "0x3303CE0", Offset = "0x33030E0", Length = "0x61")]
	[Token(Token = "0x6002933")]
	public override void Dispose() { }

	[Address(RVA = "0x3303D50", Offset = "0x3303150", Length = "0x56")]
	[Token(Token = "0x6002934")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002931")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002932")]
	private void set_disposed(bool value) { }

}

