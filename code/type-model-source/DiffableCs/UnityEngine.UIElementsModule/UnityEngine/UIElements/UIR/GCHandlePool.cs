namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000573")]
internal class GCHandlePool : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001217")]
	private List<GCHandle> m_Handles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001218")]
	private int m_UsedHandlesCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001219")]
	private readonly int k_AllocBatchSize; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400121A")]
	private bool <disposed>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000A2F")]
	internal bool disposed
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60027BB")]
		internal get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60027BC")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32DDB00", Offset = "0x32DCF00", Length = "0x9D")]
	[Token(Token = "0x60027B7")]
	public GCHandlePool(int capacity = 256, int allocBatchSize = 64) { }

	[Address(RVA = "0x32DD680", Offset = "0x32DCA80", Length = "0x56")]
	[Token(Token = "0x60027BD")]
	public override void Dispose() { }

	[Address(RVA = "0x32DD6E0", Offset = "0x32DCAE0", Length = "0x15A")]
	[Token(Token = "0x60027BE")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x32DD870", Offset = "0x32DCC70", Length = "0x1A8")]
	[Token(Token = "0x60027B8")]
	public GCHandle Get(object target) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60027BB")]
	internal bool get_disposed() { }

	[Address(RVA = "0x32DD840", Offset = "0x32DCC40", Length = "0x26")]
	[Token(Token = "0x60027B9")]
	public IntPtr GetIntPtr(object target) { }

	[Address(RVA = "0x32DDA20", Offset = "0x32DCE20", Length = "0xDB")]
	[Token(Token = "0x60027BA")]
	public void ReturnAll() { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60027BC")]
	private void set_disposed(bool value) { }

}

