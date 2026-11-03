namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x2000042")]
public struct ReadHandle : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000BD")]
	internal IntPtr ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BE")]
	internal int version; //Field offset: 0x8

	[Token(Token = "0x17000018")]
	public JobHandle JobHandle
	{
		[Address(RVA = "0x2FE5AE0", Offset = "0x2FE4EE0", Length = "0xE1")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 225
	}

	[Token(Token = "0x17000019")]
	public ReadStatus Status
	{
		[Address(RVA = "0x2FE5BD0", Offset = "0x2FE4FD0", Length = "0xB7")]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 183
	}

	[Address(RVA = "0x2FE56B0", Offset = "0x2FE4AB0", Length = "0xB7")]
	[Token(Token = "0x60000BE")]
	public void Cancel() { }

	[Address(RVA = "0x2FE5670", Offset = "0x2FE4A70", Length = "0x33")]
	[FreeFunction("AsyncReadManagerManaged::CancelReadRequest")]
	[Token(Token = "0x60000BF")]
	private static void CancelInternal(ReadHandle handle) { }

	[Address(RVA = "0x2FE5630", Offset = "0x2FE4A30", Length = "0x33")]
	[Token(Token = "0x60000C6")]
	private static void CancelInternal_Injected(in ReadHandle handle) { }

	[Address(RVA = "0x2FE5770", Offset = "0x2FE4B70", Length = "0x10F")]
	[Token(Token = "0x60000BD")]
	public override void Dispose() { }

	[Address(RVA = "0x2FE5AE0", Offset = "0x2FE4EE0", Length = "0xE1")]
	[Token(Token = "0x60000C0")]
	public JobHandle get_JobHandle() { }

	[Address(RVA = "0x2FE5BD0", Offset = "0x2FE4FD0", Length = "0xB7")]
	[Token(Token = "0x60000C1")]
	public ReadStatus get_Status() { }

	[Address(RVA = "0x2FE58D0", Offset = "0x2FE4CD0", Length = "0x4B")]
	[FreeFunction("AsyncReadManagerManaged::GetJobHandle", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000C5")]
	private static JobHandle GetJobHandle(ReadHandle handle) { }

	[Address(RVA = "0x2FE5880", Offset = "0x2FE4C80", Length = "0x42")]
	[Token(Token = "0x60000CA")]
	private static void GetJobHandle_Injected(in ReadHandle handle, out JobHandle ret) { }

	[Address(RVA = "0x2FE5960", Offset = "0x2FE4D60", Length = "0x33")]
	[FreeFunction("AsyncReadManagerManaged::GetReadStatus", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000C2")]
	private static ReadStatus GetReadStatus(ReadHandle handle) { }

	[Address(RVA = "0x2FE5920", Offset = "0x2FE4D20", Length = "0x33")]
	[Token(Token = "0x60000C7")]
	private static ReadStatus GetReadStatus_Injected(in ReadHandle handle) { }

	[Address(RVA = "0x2FE59E0", Offset = "0x2FE4DE0", Length = "0x33")]
	[FreeFunction("AsyncReadManagerManaged::IsReadHandleValid", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000C4")]
	private static bool IsReadHandleValid(ReadHandle handle) { }

	[Address(RVA = "0x2FE59A0", Offset = "0x2FE4DA0", Length = "0x33")]
	[Token(Token = "0x60000C9")]
	private static bool IsReadHandleValid_Injected(in ReadHandle handle) { }

	[Address(RVA = "0x2FE5A20", Offset = "0x2FE4E20", Length = "0x37")]
	[Token(Token = "0x60000BC")]
	public bool IsValid() { }

	[Address(RVA = "0x2FE5AA0", Offset = "0x2FE4EA0", Length = "0x33")]
	[FreeFunction("AsyncReadManagerManaged::ReleaseReadHandle", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000C3")]
	private static void ReleaseReadHandle(ReadHandle handle) { }

	[Address(RVA = "0x2FE5A60", Offset = "0x2FE4E60", Length = "0x33")]
	[Token(Token = "0x60000C8")]
	private static void ReleaseReadHandle_Injected(in ReadHandle handle) { }

}

