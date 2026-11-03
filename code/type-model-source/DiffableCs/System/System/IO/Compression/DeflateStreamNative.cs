namespace System.IO.Compression;

[Token(Token = "0x2000215")]
internal class DeflateStreamNative
{
	[Token(Token = "0x2000217")]
	private sealed class SafeDeflateStreamHandle : SafeHandle
	{

		[Token(Token = "0x170002D8")]
		public virtual bool IsInvalid
		{
			[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
			[Token(Token = "0x6000E1C")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x1E7C790", Offset = "0x1E7BB90", Length = "0xD")]
		[Token(Token = "0x6000E1D")]
		private SafeDeflateStreamHandle() { }

		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000E1C")]
		public virtual bool get_IsInvalid() { }

		[Address(RVA = "0x268DC60", Offset = "0x268D060", Length = "0x17")]
		[Token(Token = "0x6000E1E")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000216")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class UnmanagedReadOrWrite : MulticastDelegate
	{

		[Address(RVA = "0x260A420", Offset = "0x2609820", Length = "0xA6")]
		[Token(Token = "0x6000E1A")]
		public UnmanagedReadOrWrite(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000E1B")]
		public override int Invoke(IntPtr buffer, int length, IntPtr data) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B4")]
	private UnmanagedReadOrWrite feeder; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B5")]
	private Stream base_stream; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007B6")]
	private SafeDeflateStreamHandle z_stream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007B7")]
	private GCHandle data; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007B8")]
	private bool disposed; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007B9")]
	private Byte[] io_buffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007BA")]
	private Exception last_error; //Field offset: 0x40

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E09")]
	private DeflateStreamNative() { }

	[Address(RVA = "0x267E7F0", Offset = "0x267DBF0", Length = "0x4C")]
	[Token(Token = "0x6000E14")]
	private void CheckResult(int result, string where) { }

	[Address(RVA = "0x267E940", Offset = "0x267DD40", Length = "0x5")]
	[Token(Token = "0x6000E16")]
	private static int CloseZStream(IntPtr stream) { }

	[Address(RVA = "0x267E9E0", Offset = "0x267DDE0", Length = "0x272")]
	[Token(Token = "0x6000E0A")]
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	[Address(RVA = "0x267E950", Offset = "0x267DD50", Length = "0x90")]
	[Token(Token = "0x6000E15")]
	private static SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	[Address(RVA = "0x267EC60", Offset = "0x267E060", Length = "0x105")]
	[Token(Token = "0x6000E0C")]
	public void Dispose(bool disposing) { }

	[Address(RVA = "0x267ED70", Offset = "0x267E170", Length = "0x5A")]
	[Token(Token = "0x6000E0B")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x267EDD0", Offset = "0x267E1D0", Length = "0xA1")]
	[Token(Token = "0x6000E0D")]
	public void Flush() { }

	[Address(RVA = "0x267EE80", Offset = "0x267E280", Length = "0x64")]
	[Token(Token = "0x6000E17")]
	private static int Flush(SafeDeflateStreamHandle stream) { }

	[Address(RVA = "0x267EEF0", Offset = "0x267E2F0", Length = "0xBA")]
	[Token(Token = "0x6000E0E")]
	public int ReadZStream(IntPtr buffer, int length) { }

	[Address(RVA = "0x267EFB0", Offset = "0x267E3B0", Length = "0x79")]
	[Token(Token = "0x6000E18")]
	private static int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	[Address(RVA = "0x267F140", Offset = "0x267E540", Length = "0x159")]
	[Token(Token = "0x6000E11")]
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[Address(RVA = "0x267F030", Offset = "0x267E430", Length = "0x10E")]
	[MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
	[Token(Token = "0x6000E10")]
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	[Address(RVA = "0x267F420", Offset = "0x267E820", Length = "0x10E")]
	[MonoPInvokeCallback(typeof(UnmanagedReadOrWrite))]
	[Token(Token = "0x6000E12")]
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	[Address(RVA = "0x267F2A0", Offset = "0x267E6A0", Length = "0x174")]
	[Token(Token = "0x6000E13")]
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	[Address(RVA = "0x267F530", Offset = "0x267E930", Length = "0xB7")]
	[Token(Token = "0x6000E0F")]
	public void WriteZStream(IntPtr buffer, int length) { }

	[Address(RVA = "0x267F5F0", Offset = "0x267E9F0", Length = "0x79")]
	[Token(Token = "0x6000E19")]
	private static int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

