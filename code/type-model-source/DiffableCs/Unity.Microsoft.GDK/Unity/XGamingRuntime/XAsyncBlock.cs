namespace Unity.XGamingRuntime;

[Token(Token = "0x2000107")]
public class XAsyncBlock : IDisposable
{
	[Token(Token = "0x2000108")]
	internal struct XAsyncBlockInterop
	{
		[CompilerGenerated]
		[Token(Token = "0x2000109")]
		[UnsafeValueType]
		internal struct <reserved>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40001E1")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DD")]
		public IntPtr queue; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001DE")]
		public IntPtr context; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001DF")]
		public IntPtr callback; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[FixedBuffer(typeof(byte), 32)]
		[Token(Token = "0x40001E0")]
		public <reserved>e__FixedBuffer reserved; //Field offset: 0x18

	}

	[Token(Token = "0x40001DA")]
	private static XAsyncCompletionRoutineInterop InteropCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D4")]
	public XTaskQueueHandle Queue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D5")]
	public IntPtr Context; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D6")]
	public XAsyncCompletionRoutine Callback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D7")]
	public XAsyncBlockInterop Interop; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001D8")]
	private GCHandle callbackObjHandle; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001D9")]
	private GCHandle interopHandle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001DB")]
	private bool disposedValue; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40001DC")]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x71

	[Token(Token = "0x1700006A")]
	public IntPtr InteropPtr
	{
		[Address(RVA = "0x2B7C930", Offset = "0x2B7BD30", Length = "0xB")]
		[Token(Token = "0x600065A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000069")]
	public private bool IsCompleted
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000658")]
		 get { } //Length: 5
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000659")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2B7C6C0", Offset = "0x2B7BAC0", Length = "0x89")]
	[Token(Token = "0x600065F")]
	private static XAsyncBlock() { }

	[Address(RVA = "0x2B7C750", Offset = "0x2B7BB50", Length = "0x1D6")]
	[Token(Token = "0x6000657")]
	public XAsyncBlock(XTaskQueueHandle queue, XAsyncCompletionRoutine callback, IntPtr context) { }

	[Address(RVA = "0x2B7C420", Offset = "0x2B7B820", Length = "0x3D")]
	[Token(Token = "0x600065C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2B7C3B0", Offset = "0x2B7B7B0", Length = "0x61")]
	[Token(Token = "0x600065E")]
	public override void Dispose() { }

	[Address(RVA = "0x2B7C460", Offset = "0x2B7B860", Length = "0x5B")]
	[Token(Token = "0x600065B")]
	private void DoCompletionCallback() { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x600065D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2B7C930", Offset = "0x2B7BD30", Length = "0xB")]
	[Token(Token = "0x600065A")]
	public IntPtr get_InteropPtr() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000658")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x2B7C4C0", Offset = "0x2B7B8C0", Length = "0x1F1")]
	[MonoPInvokeCallback(typeof(XAsyncCompletionRoutineInterop))]
	[Token(Token = "0x6000656")]
	private static void OnXAsyncBlockCompletion(IntPtr asyncBlock) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000659")]
	private void set_IsCompleted(bool value) { }

}

