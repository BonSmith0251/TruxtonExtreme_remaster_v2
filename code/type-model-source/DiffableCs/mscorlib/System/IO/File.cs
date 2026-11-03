namespace System.IO;

[Token(Token = "0x200065E")]
public static class File
{
	[CompilerGenerated]
	[Token(Token = "0x200065F")]
	private struct <InternalReadAllBytesAsync>d__71 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001983")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001984")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001985")]
		public FileStream fs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001986")]
		public int count; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001987")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001988")]
		private FileStream <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001989")]
		private int <index>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400198A")]
		private Byte[] <bytes>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400198B")]
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x1FE6960", Offset = "0x1FE5D60", Length = "0x68A")]
		[Token(Token = "0x6002F95")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE6FF0", Offset = "0x1FE63F0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6002F96")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000660")]
	private struct <InternalReadAllBytesUnknownLengthAsync>d__72 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400198C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400198D")]
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400198E")]
		public FileStream fs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400198F")]
		public CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001990")]
		private Byte[] <rentedArray>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001991")]
		private int <bytesRead>5__3; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001992")]
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x40

		[Address(RVA = "0x2002950", Offset = "0x2001D50", Length = "0x8A6")]
		[Token(Token = "0x6002F97")]
		private override void MoveNext() { }

		[Address(RVA = "0x2003200", Offset = "0x2002600", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6002F98")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000661")]
	private struct <InternalWriteAllBytesAsync>d__74 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001993")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001994")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001995")]
		public string path; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001996")]
		public Byte[] bytes; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001997")]
		public CancellationToken cancellationToken; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001998")]
		private FileStream <fs>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001999")]
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400199A")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x2003270", Offset = "0x2002670", Length = "0x770")]
		[Token(Token = "0x6002F99")]
		private override void MoveNext() { }

		[Address(RVA = "0x20039F0", Offset = "0x2002DF0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6002F9A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x1FD7DA0", Offset = "0x1FD71A0", Length = "0x111")]
	[Token(Token = "0x6002F82")]
	public static void Delete(string path) { }

	[Address(RVA = "0x1FD7EC0", Offset = "0x1FD72C0", Length = "0x117")]
	[Token(Token = "0x6002F83")]
	public static bool Exists(string path) { }

	[Address(RVA = "0x1FD7FE0", Offset = "0x1FD73E0", Length = "0xA2")]
	[Token(Token = "0x6002F86")]
	public static FileAttributes GetAttributes(string path) { }

	[Address(RVA = "0x1FD8090", Offset = "0x1FD7490", Length = "0x134")]
	[AsyncStateMachine(typeof(<InternalReadAllBytesAsync>d__71))]
	[Token(Token = "0x6002F91")]
	private static Task<Byte[]> InternalReadAllBytesAsync(FileStream fs, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FD81D0", Offset = "0x1FD75D0", Length = "0x12A")]
	[AsyncStateMachine(typeof(<InternalReadAllBytesUnknownLengthAsync>d__72))]
	[Token(Token = "0x6002F92")]
	private static Task<Byte[]> InternalReadAllBytesUnknownLengthAsync(FileStream fs, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FD8300", Offset = "0x1FD7700", Length = "0x10E")]
	[Token(Token = "0x6002F8A")]
	private static string InternalReadAllText(string path, Encoding encoding) { }

	[Address(RVA = "0x1FD8530", Offset = "0x1FD7930", Length = "0x126")]
	[Token(Token = "0x6002F8F")]
	private static void InternalWriteAllBytes(string path, Byte[] bytes) { }

	[Address(RVA = "0x1FD8410", Offset = "0x1FD7810", Length = "0x11E")]
	[AsyncStateMachine(typeof(<InternalWriteAllBytesAsync>d__74))]
	[Token(Token = "0x6002F94")]
	private static Task InternalWriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FD8890", Offset = "0x1FD7C90", Length = "0x8C")]
	[Token(Token = "0x6002F85")]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	[Address(RVA = "0x1FD8800", Offset = "0x1FD7C00", Length = "0x90")]
	[Token(Token = "0x6002F84")]
	public static FileStream Open(string path, FileMode mode) { }

	[Address(RVA = "0x1FD8660", Offset = "0x1FD7A60", Length = "0x6E")]
	[Token(Token = "0x6002F87")]
	public static FileStream OpenRead(string path) { }

	[Address(RVA = "0x1FD86D0", Offset = "0x1FD7AD0", Length = "0xBD")]
	[Token(Token = "0x6002F81")]
	public static StreamReader OpenText(string path) { }

	[Address(RVA = "0x1FD8790", Offset = "0x1FD7B90", Length = "0x68")]
	[Token(Token = "0x6002F88")]
	public static FileStream OpenWrite(string path) { }

	[Address(RVA = "0x1FD92F0", Offset = "0x1FD86F0", Length = "0x250")]
	[Token(Token = "0x6002F8C")]
	public static Byte[] ReadAllBytes(string path) { }

	[Address(RVA = "0x1FD8920", Offset = "0x1FD7D20", Length = "0x4E2")]
	[Token(Token = "0x6002F90")]
	public static Task<Byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FD8E10", Offset = "0x1FD8210", Length = "0x4D9")]
	[Token(Token = "0x6002F8D")]
	private static Byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	[Address(RVA = "0x1FD9550", Offset = "0x1FD8950", Length = "0xDB")]
	[Token(Token = "0x6002F89")]
	public static string ReadAllText(string path) { }

	[Address(RVA = "0x1FD98E0", Offset = "0x1FD8CE0", Length = "0x12E")]
	[Token(Token = "0x6002F8E")]
	public static void WriteAllBytes(string path, Byte[] bytes) { }

	[Address(RVA = "0x1FD9630", Offset = "0x1FD8A30", Length = "0x2A9")]
	[Token(Token = "0x6002F93")]
	public static Task WriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FD9A10", Offset = "0x1FD8E10", Length = "0x227")]
	[Token(Token = "0x6002F8B")]
	public static void WriteAllText(string path, string contents) { }

}

