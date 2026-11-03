namespace UnityEngine.UIElements;

[Token(Token = "0x20002DB")]
internal class MeshGenerationNodeManager : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B9C")]
	private List<MeshGenerationNodeImpl> m_Nodes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B9D")]
	private int m_UsedCounter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B9E")]
	private EntryRecorder m_EntryRecorder; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B9F")]
	private bool <disposed>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170003E2")]
	protected private bool disposed
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013E0")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60013E1")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x34068D0", Offset = "0x3405CD0", Length = "0x99")]
	[Token(Token = "0x60013DB")]
	public MeshGenerationNodeManager(EntryRecorder entryRecorder) { }

	[Address(RVA = "0x3406240", Offset = "0x3405640", Length = "0x217")]
	[Token(Token = "0x60013DE")]
	private MeshGenerationNodeImpl CreateImpl(Entry parentEntry, bool safe) { }

	[Address(RVA = "0x3406460", Offset = "0x3405860", Length = "0x2B")]
	[Token(Token = "0x60013DC")]
	public void CreateNode(Entry parentEntry, out MeshGenerationNode node) { }

	[Address(RVA = "0x3406490", Offset = "0x3405890", Length = "0x2B")]
	[Token(Token = "0x60013DD")]
	public void CreateUnsafeNode(Entry parentEntry, out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x34064C0", Offset = "0x34058C0", Length = "0x188")]
	[Token(Token = "0x60013E2")]
	public override void Dispose() { }

	[Address(RVA = "0x3406650", Offset = "0x3405A50", Length = "0x15A")]
	[Token(Token = "0x60013E3")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013E0")]
	protected bool get_disposed() { }

	[Address(RVA = "0x34067B0", Offset = "0x3405BB0", Length = "0x114")]
	[Token(Token = "0x60013DF")]
	public void ResetAll() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60013E1")]
	private void set_disposed(bool value) { }

}

