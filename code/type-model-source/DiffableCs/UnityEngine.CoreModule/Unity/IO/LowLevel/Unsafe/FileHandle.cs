namespace Unity.IO.LowLevel.Unsafe;

[IsReadOnly]
[Token(Token = "0x2000041")]
public struct FileHandle
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000BB")]
	internal readonly IntPtr fileCommandPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BC")]
	internal readonly int version; //Field offset: 0x8

	[Token(Token = "0x17000017")]
	public JobHandle JobHandle
	{
		[Address(RVA = "0x2FE2480", Offset = "0x2FE1880", Length = "0xCD")]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 205
	}

	[Address(RVA = "0x2FE22B0", Offset = "0x2FE16B0", Length = "0xE7")]
	[Token(Token = "0x60000B8")]
	public JobHandle Close(JobHandle dependency = null) { }

	[Address(RVA = "0x2FE2480", Offset = "0x2FE1880", Length = "0xCD")]
	[Token(Token = "0x60000B6")]
	public JobHandle get_JobHandle() { }

	[Address(RVA = "0x2FE23F0", Offset = "0x2FE17F0", Length = "0x4B")]
	[FreeFunction("AsyncReadManagerManaged::GetJobFenceFromManagedHandle")]
	[Token(Token = "0x60000BA")]
	private static JobHandle GetJobHandle_Internal(in FileHandle handle) { }

	[Address(RVA = "0x2FE23A0", Offset = "0x2FE17A0", Length = "0x42")]
	[Token(Token = "0x60000BB")]
	private static void GetJobHandle_Internal_Injected(in FileHandle handle, out JobHandle ret) { }

	[Address(RVA = "0x2FE2440", Offset = "0x2FE1840", Length = "0x33")]
	[FreeFunction("AsyncReadManagerManaged::IsFileHandleValid")]
	[Token(Token = "0x60000B9")]
	private static bool IsFileHandleValid(in FileHandle handle) { }

	[Address(RVA = "0x2FE2440", Offset = "0x2FE1840", Length = "0x33")]
	[Token(Token = "0x60000B7")]
	public bool IsValid() { }

}

