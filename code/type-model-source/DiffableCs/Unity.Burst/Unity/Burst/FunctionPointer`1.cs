namespace Unity.Burst;

[IsReadOnly]
[Token(Token = "0x200002C")]
public struct FunctionPointer : IFunctionPointer
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x400017D")]
	private readonly IntPtr _ptr; //Field offset: 0x0

	[Token(Token = "0x17000019")]
	public T Invoke
	{
		[Address(RVA = "0x1C186A0", Offset = "0x1C17AA0", Length = "0x76")]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001A")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000018")]
	public IntPtr Value
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x60000DC")]
	public FunctionPointer`1(IntPtr ptr) { }

	[Address(RVA = "0x1C185D0", Offset = "0x1C179D0", Length = "0x6F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Token(Token = "0x60000DE")]
	private void CheckIsCreated() { }

	[Address(RVA = "0x1C186A0", Offset = "0x1C17AA0", Length = "0x76")]
	[Token(Token = "0x60000DF")]
	public T get_Invoke() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x60000E0")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60000DD")]
	public IntPtr get_Value() { }

	[Address(RVA = "0x1C18640", Offset = "0x1C17A40", Length = "0x5B")]
	[Token(Token = "0x60000E1")]
	private override IFunctionPointer Unity.Burst.IFunctionPointer.FromIntPtr(IntPtr ptr) { }

}

