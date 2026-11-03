namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A2")]
internal class JobManager : IDisposable
{
	[Token(Token = "0x4001390")]
	private const string k_JobManagerName = "Renderer.JobManager"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001391")]
	private NativePagedList<NudgeJobData> m_NudgeJobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001392")]
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001393")]
	private NativePagedList<CopyMeshJobData> m_CopyMeshJobs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001394")]
	private JobMerger m_JobMerger; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001395")]
	private bool <disposed>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x17000A4B")]
	protected private bool disposed
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028BF")]
		 get { } //Length: 5
		[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028C0")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32F8000", Offset = "0x32F7400", Length = "0x1A7")]
	[Token(Token = "0x60028C3")]
	public JobManager() { }

	[Address(RVA = "0x32F7470", Offset = "0x32F6870", Length = "0x53")]
	[Token(Token = "0x60028B9")]
	public void Add(ref NudgeJobData job) { }

	[Address(RVA = "0x32F73B0", Offset = "0x32F67B0", Length = "0x53")]
	[Token(Token = "0x60028BA")]
	public void Add(ref ConvertMeshJobData job) { }

	[Address(RVA = "0x32F7410", Offset = "0x32F6810", Length = "0x53")]
	[Token(Token = "0x60028BB")]
	public void Add(ref CopyMeshJobData job) { }

	[Address(RVA = "0x32F74D0", Offset = "0x32F68D0", Length = "0x322")]
	[Token(Token = "0x60028BD")]
	public void CompleteConvertMeshJobs() { }

	[Address(RVA = "0x32F7800", Offset = "0x32F6C00", Length = "0x322")]
	[Token(Token = "0x60028BE")]
	public void CompleteCopyMeshJobs() { }

	[Address(RVA = "0x32F7B30", Offset = "0x32F6F30", Length = "0x322")]
	[Token(Token = "0x60028BC")]
	public void CompleteNudgeJobs() { }

	[Address(RVA = "0x32F7F20", Offset = "0x32F7320", Length = "0xDB")]
	[Token(Token = "0x60028C1")]
	public override void Dispose() { }

	[Address(RVA = "0x32F7E60", Offset = "0x32F7260", Length = "0xB2")]
	[Token(Token = "0x60028C2")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028BF")]
	protected bool get_disposed() { }

	[Address(RVA = "0xD99D40", Offset = "0xD99140", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028C0")]
	private void set_disposed(bool value) { }

}

