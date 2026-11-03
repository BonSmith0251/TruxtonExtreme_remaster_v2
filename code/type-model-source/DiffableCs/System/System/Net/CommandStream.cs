namespace System.Net;

[Token(Token = "0x2000227")]
internal class CommandStream : NetworkStreamWrapper
{
	[Token(Token = "0x200022A")]
	public class PipelineEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000841")]
		internal string Command; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000842")]
		internal PipelineEntryFlags Flags; //Field offset: 0x18

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000EA5")]
		internal PipelineEntry(string command) { }

		[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
		[Token(Token = "0x6000EA6")]
		internal PipelineEntry(string command, PipelineEntryFlags flags) { }

		[Address(RVA = "0x26ABCF0", Offset = "0x26AB0F0", Length = "0x7")]
		[Token(Token = "0x6000EA7")]
		internal bool HasFlag(PipelineEntryFlags flags) { }

	}

	[Flags]
	[Token(Token = "0x2000229")]
	public enum PipelineEntryFlags : int
	{
		UserCommand = 1,
		GiveDataStream = 2,
		CreateDataConnection = 4,
		DontLogParameter = 8,
	}

	[Token(Token = "0x2000228")]
	public enum PipelineInstruction : int
	{
		Abort = 0,
		Advance = 1,
		Pause = 2,
		Reread = 3,
		GiveStream = 4,
	}

	[Token(Token = "0x4000827")]
	private static readonly AsyncCallback s_writeCallbackDelegate; //Field offset: 0x0
	[Token(Token = "0x4000828")]
	private static readonly AsyncCallback s_readCallbackDelegate; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000829")]
	private bool _recoverableFailure; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400082A")]
	protected WebRequest _request; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400082B")]
	protected bool _isAsync; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x400082C")]
	private bool _aborted; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400082D")]
	protected PipelineEntry[] _commands; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400082E")]
	protected int _index; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400082F")]
	private bool _doRead; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4000830")]
	private bool _doSend; //Field offset: 0x5D
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000831")]
	private ResponseDescription _currentResponseDescription; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000832")]
	protected string _abortReason; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000833")]
	private string _buffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000834")]
	private Encoding _encoding; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000835")]
	private Decoder _decoder; //Field offset: 0x80

	[Token(Token = "0x170002E4")]
	protected Encoding Encoding
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 5
		[Address(RVA = "0x269A6A0", Offset = "0x2699AA0", Length = "0x52")]
		[Token(Token = "0x6000EA0")]
		 set { } //Length: 82
	}

	[Token(Token = "0x170002E3")]
	internal bool RecoverableFailure
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000E90")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x269A4B0", Offset = "0x26998B0", Length = "0xE4")]
	[Token(Token = "0x6000EA4")]
	private static CommandStream() { }

	[Address(RVA = "0x269A5A0", Offset = "0x26999A0", Length = "0xF0")]
	[Token(Token = "0x6000E8C")]
	internal CommandStream(TcpClient client) { }

	[Address(RVA = "0x26989A0", Offset = "0x2697DA0", Length = "0x1CF")]
	[Token(Token = "0x6000E8D")]
	internal override void Abort(Exception e) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E94")]
	protected override PipelineEntry[] BuildCommandsList(WebRequest request) { }

	[Address(RVA = "0x2698B70", Offset = "0x2697F70", Length = "0x40")]
	[Token(Token = "0x6000E98")]
	internal void CheckContinuePipeline() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000EA1")]
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	[Address(RVA = "0x2698BB0", Offset = "0x2697FB0", Length = "0x1F")]
	[Token(Token = "0x6000E93")]
	protected override void ClearState() { }

	[Address(RVA = "0x2698BD0", Offset = "0x2697FD0", Length = "0x4DB")]
	[Token(Token = "0x6000E99")]
	protected Stream ContinueCommandPipeline() { }

	[Address(RVA = "0x26990B0", Offset = "0x26984B0", Length = "0x8C")]
	[Token(Token = "0x6000E8E")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26991F0", Offset = "0x26985F0", Length = "0x7D")]
	[Token(Token = "0x6000E95")]
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	[Address(RVA = "0x2699140", Offset = "0x2698540", Length = "0xA3")]
	[Token(Token = "0x6000E96")]
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000E9F")]
	protected Encoding get_Encoding() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000E90")]
	internal bool get_RecoverableFailure() { }

	[Address(RVA = "0x2699270", Offset = "0x2698670", Length = "0x92")]
	[Token(Token = "0x6000E97")]
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	[Address(RVA = "0x2699310", Offset = "0x2698710", Length = "0x8B")]
	[Token(Token = "0x6000E8F")]
	protected void InvokeRequestCallback(object obj) { }

	[Address(RVA = "0x26993A0", Offset = "0x26987A0", Length = "0xB")]
	[Token(Token = "0x6000E91")]
	protected void MarkAsRecoverableFailure() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000E9C")]
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	[Address(RVA = "0x26993B0", Offset = "0x26987B0", Length = "0x212")]
	[Token(Token = "0x6000E9B")]
	private bool PostReadCommandProcessing(ref Stream stream) { }

	[Address(RVA = "0x26995D0", Offset = "0x26989D0", Length = "0xEF")]
	[Token(Token = "0x6000E9A")]
	private bool PostSendCommandProcessing(ref Stream stream) { }

	[Address(RVA = "0x26996C0", Offset = "0x2698AC0", Length = "0x1E7")]
	[Token(Token = "0x6000E9D")]
	private static void ReadCallback(IAsyncResult asyncResult) { }

	[Address(RVA = "0x2699F10", Offset = "0x2699310", Length = "0x368")]
	[Token(Token = "0x6000EA2")]
	private ResponseDescription ReceiveCommandResponse() { }

	[Address(RVA = "0x26998B0", Offset = "0x2698CB0", Length = "0x650")]
	[Token(Token = "0x6000EA3")]
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	[Address(RVA = "0x269A6A0", Offset = "0x2699AA0", Length = "0x52")]
	[Token(Token = "0x6000EA0")]
	protected void set_Encoding(Encoding value) { }

	[Address(RVA = "0x269A280", Offset = "0x2699680", Length = "0x9B")]
	[Token(Token = "0x6000E92")]
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	[Address(RVA = "0x269A320", Offset = "0x2699720", Length = "0x181")]
	[Token(Token = "0x6000E9E")]
	private static void WriteCallback(IAsyncResult asyncResult) { }

}

