namespace Unity.IO.LowLevel.Unsafe;

[NativeHeader("Runtime/File/AsyncReadManagerManagedApi.h")]
[Token(Token = "0x2000043")]
public static class AsyncReadManager
{

	[Address(RVA = "0x2FCE530", Offset = "0x2FCD930", Length = "0x5B")]
	[FreeFunction("AsyncReadManagerManaged::ScheduleCloseRequest", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000D1")]
	internal static JobHandle CloseFileAsync(in FileHandle fileHandle, JobHandle dependency) { }

	[Address(RVA = "0x2FCE4D0", Offset = "0x2FCD8D0", Length = "0x52")]
	[Token(Token = "0x60000D5")]
	private static void CloseFileAsync_Injected(in FileHandle fileHandle, in JobHandle dependency, out JobHandle ret) { }

	[Address(RVA = "0x2FCE7D0", Offset = "0x2FCDBD0", Length = "0x78")]
	[Token(Token = "0x60000CC")]
	public static ReadHandle GetFileInfo(string filename, FileInfoResult* result) { }

	[Address(RVA = "0x2FCE5F0", Offset = "0x2FCD9F0", Length = "0x1D2")]
	[FreeFunction("AsyncReadManagerManaged::GetFileInfo", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000CB")]
	private static ReadHandle GetFileInfoInternal(string filename, Void* cmd) { }

	[Address(RVA = "0x2FCE590", Offset = "0x2FCD990", Length = "0x52")]
	[Token(Token = "0x60000D2")]
	private static void GetFileInfoInternal_Injected(ref ManagedSpanWrapper filename, Void* cmd, out ReadHandle ret) { }

	[Address(RVA = "0x2FCEA70", Offset = "0x2FCDE70", Length = "0x84")]
	[Token(Token = "0x60000D0")]
	public static FileHandle OpenFileAsync(string fileName) { }

	[Address(RVA = "0x2FCE8A0", Offset = "0x2FCDCA0", Length = "0x1CF")]
	[FreeFunction("AsyncReadManagerManaged::ScheduleOpenRequest", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000CF")]
	private static FileHandle OpenFileAsync_Internal(string fileName) { }

	[Address(RVA = "0x2FCE850", Offset = "0x2FCDC50", Length = "0x42")]
	[Token(Token = "0x60000D4")]
	private static void OpenFileAsync_Internal_Injected(ref ManagedSpanWrapper fileName, out FileHandle ret) { }

	[Address(RVA = "0x2FCEBC0", Offset = "0x2FCDFC0", Length = "0xDD")]
	[Token(Token = "0x60000CE")]
	public static ReadHandle Read(in FileHandle fileHandle, ReadCommandArray readCmdArray) { }

	[Address(RVA = "0x2FCEB60", Offset = "0x2FCDF60", Length = "0x5B")]
	[FreeFunction("AsyncReadManagerManaged::ReadWithHandles_NativeCopy", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	[Token(Token = "0x60000CD")]
	private static ReadHandle ReadWithHandlesInternal_NativeCopy(in FileHandle fileHandle, Void* readCmdArray) { }

	[Address(RVA = "0x2FCEB00", Offset = "0x2FCDF00", Length = "0x52")]
	[Token(Token = "0x60000D3")]
	private static void ReadWithHandlesInternal_NativeCopy_Injected(in FileHandle fileHandle, Void* readCmdArray, out ReadHandle ret) { }

}

