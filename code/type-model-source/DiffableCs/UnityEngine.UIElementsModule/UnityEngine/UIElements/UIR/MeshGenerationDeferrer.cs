namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AC")]
internal class MeshGenerationDeferrer : IDisposable
{
	[Token(Token = "0x20005AD")]
	private struct CallbackInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013CF")]
		public MeshGenerationCallback callback; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40013D0")]
		public object userData; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013C6")]
	private Queue<CallbackInfo> m_Fork; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013C7")]
	private Queue<CallbackInfo> m_WorkThenFork; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013C8")]
	private Queue<CallbackInfo> m_Work; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013C9")]
	private Queue<CallbackInfo> m_JobDependentFork; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013CA")]
	private Queue<CallbackInfo> m_JobDependentWorkThenFork; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013CB")]
	private Queue<CallbackInfo> m_JobDependentWork; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013CC")]
	private Queue<JobHandle> m_Dependencies; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013CD")]
	private JobMerger m_DependencyMerger; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013CE")]
	private bool <disposed>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000A4E")]
	protected private bool disposed
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028DE")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60028DF")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32F8CD0", Offset = "0x32F80D0", Length = "0x201")]
	[Token(Token = "0x60028E2")]
	public MeshGenerationDeferrer() { }

	[Address(RVA = "0x32F8530", Offset = "0x32F7930", Length = "0x1B9")]
	[Token(Token = "0x60028DB")]
	public void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	[Address(RVA = "0x32F86F0", Offset = "0x32F7AF0", Length = "0x5E")]
	[Token(Token = "0x60028DA")]
	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	[Address(RVA = "0x32F8750", Offset = "0x32F7B50", Length = "0x7B")]
	[Token(Token = "0x60028E0")]
	public override void Dispose() { }

	[Address(RVA = "0x32F87D0", Offset = "0x32F7BD0", Length = "0x45")]
	[Token(Token = "0x60028E1")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028DE")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32F8820", Offset = "0x32F7C20", Length = "0xFC")]
	[Token(Token = "0x60028DD")]
	private static void Invoke(CallbackInfo ci, MeshGenerationContext mgc) { }

	[Address(RVA = "0x32F8920", Offset = "0x32F7D20", Length = "0x3A6")]
	[Token(Token = "0x60028DC")]
	public void ProcessDeferredWork(MeshGenerationContext meshGenerationContext) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60028DF")]
	private void set_disposed(bool value) { }

}

