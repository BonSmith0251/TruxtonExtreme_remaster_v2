namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AA")]
public class DisposableBuffer : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000728")]
	private IntPtr <IntPtr>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000304")]
	public private IntPtr IntPtr
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE7")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DE8")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B8DFD0", Offset = "0x2B8D3D0", Length = "0x5B")]
	[Token(Token = "0x6000DE2")]
	public DisposableBuffer() { }

	[Address(RVA = "0x2B8E030", Offset = "0x2B8D430", Length = "0x96")]
	[Token(Token = "0x6000DE3")]
	public DisposableBuffer(int size) { }

	[Address(RVA = "0x2B8DE00", Offset = "0x2B8D200", Length = "0xA1")]
	[Token(Token = "0x6000DE4")]
	public override void Dispose() { }

	[Address(RVA = "0x2B8DEB0", Offset = "0x2B8D2B0", Length = "0x67")]
	[Token(Token = "0x6000DE5")]
	private void Dispose(bool isDisposing) { }

	[Address(RVA = "0x2B8DF20", Offset = "0x2B8D320", Length = "0xA9")]
	[Token(Token = "0x6000DE6")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE7")]
	public IntPtr get_IntPtr() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DE8")]
	private void set_IntPtr(IntPtr value) { }

}

