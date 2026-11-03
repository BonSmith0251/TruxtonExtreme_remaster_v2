namespace Unity.XGamingRuntime;

[Token(Token = "0x2000004")]
public class CallbackWrapper : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private GCHandle selfPtr; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000007")]
	private T <StaticCallback>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000008")]
	private T <Callback>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000009")]
	private IntPtr <Context>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000002")]
	public private T Callback
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000004")]
	public IntPtr CallbackContext
	{
		[Address(RVA = "0x16C44C0", Offset = "0x16C38C0", Length = "0xB")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000003")]
	public private IntPtr Context
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000009")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600000A")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000001")]
	public private T StaticCallback
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x16C4400", Offset = "0x16C3800", Length = "0xBD")]
	[Token(Token = "0x6000003")]
	public CallbackWrapper`1(T callback, IntPtr context, T staticCallback) { }

	[Address(RVA = "0x16C4390", Offset = "0x16C3790", Length = "0x61")]
	[Token(Token = "0x600000C")]
	public override void Dispose() { }

	[Address(RVA = "0x16C4380", Offset = "0x16C3780", Length = "0xB")]
	[Token(Token = "0x600000D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1082700", Offset = "0x1081B00", Length = "0x7A")]
	[Token(Token = "0x6000004")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public T get_Callback() { }

	[Address(RVA = "0x16C44C0", Offset = "0x16C38C0", Length = "0xB")]
	[Token(Token = "0x600000B")]
	public IntPtr get_CallbackContext() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000009")]
	public IntPtr get_Context() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	public T get_StaticCallback() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	private void set_Callback(T value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600000A")]
	private void set_Context(IntPtr value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	private void set_StaticCallback(T value) { }

}

