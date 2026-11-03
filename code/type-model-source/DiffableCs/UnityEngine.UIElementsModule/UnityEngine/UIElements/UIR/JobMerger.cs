namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A6")]
internal class JobMerger : IDisposable
{
	[Token(Token = "0x40013BA")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013BB")]
	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013BC")]
	private int m_JobCount; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013BD")]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	[Token(Token = "0x17000A4C")]
	protected private bool disposed
	{
		[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028C7")]
		 get { } //Length: 5
		[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028C8")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32F83C0", Offset = "0x32F77C0", Length = "0x82")]
	[Token(Token = "0x60028CB")]
	private static JobMerger() { }

	[Address(RVA = "0x32F8450", Offset = "0x32F7850", Length = "0xDA")]
	[Token(Token = "0x60028C4")]
	public JobMerger(int capacity) { }

	[Address(RVA = "0x32F81B0", Offset = "0x32F75B0", Length = "0x80")]
	[Token(Token = "0x60028C5")]
	public void Add(JobHandle job) { }

	[Address(RVA = "0x32F8290", Offset = "0x32F7690", Length = "0x7F")]
	[Token(Token = "0x60028C9")]
	public override void Dispose() { }

	[Address(RVA = "0x32F8230", Offset = "0x32F7630", Length = "0x56")]
	[Token(Token = "0x60028CA")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x1DFC7D0", Offset = "0x1DFBBD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028C7")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32F8310", Offset = "0x32F7710", Length = "0xA6")]
	[Token(Token = "0x60028C6")]
	public JobHandle MergeAndReset() { }

	[Address(RVA = "0x1CC8060", Offset = "0x1CC7460", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028C8")]
	private void set_disposed(bool value) { }

}

