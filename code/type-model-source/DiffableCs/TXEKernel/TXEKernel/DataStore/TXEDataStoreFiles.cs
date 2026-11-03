namespace TXEKernel.DataStore;

[Token(Token = "0x200013E")]
public static class TXEDataStoreFiles
{
	[CompilerGenerated]
	[Token(Token = "0x2000140")]
	private struct <ReadFileAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000916")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000917")]
		public AsyncUniTaskMethodBuilder<Response> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000918")]
		public string name; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000919")]
		public Action<Response> endcallback; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400091A")]
		private Response <res>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400091B")]
		private Byte[] <t>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400091C")]
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x50

		[Address(RVA = "0x272A0C0", Offset = "0x27294C0", Length = "0x379")]
		[Token(Token = "0x60008AB")]
		private override void MoveNext() { }

		[Address(RVA = "0x272A440", Offset = "0x2729840", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60008AC")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000141")]
	private struct <WriteFileAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400091D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400091E")]
		public AsyncUniTaskMethodBuilder<Response> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400091F")]
		public string pathname; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000920")]
		public Byte[] bytedata; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000921")]
		public Action<Response> endcallback; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000922")]
		private Response <res>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000923")]
		private TaskAwaiter <>u__1; //Field offset: 0x50

		[Address(RVA = "0x272B800", Offset = "0x272AC00", Length = "0x281")]
		[Token(Token = "0x60008AD")]
		private override void MoveNext() { }

		[Address(RVA = "0x272BA90", Offset = "0x272AE90", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x60008AE")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200013F")]
	internal struct Response
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000912")]
		internal bool _isFinish; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000913")]
		internal bool _isError; //Field offset: 0x1
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000914")]
		internal ErrorCode _errorCode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000915")]
		public Byte[] Data; //Field offset: 0x8

		[Token(Token = "0x1700025B")]
		public ErrorCode ErrorCode
		{
			[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
			[Token(Token = "0x60008A9")]
			 get { } //Length: 4
		}

		[Token(Token = "0x1700025A")]
		public bool IsError
		{
			[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
			[Token(Token = "0x60008A8")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000259")]
		public bool IsFinish
		{
			[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
			[Token(Token = "0x60008A7")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60008A9")]
		public ErrorCode get_ErrorCode() { }

		[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
		[Token(Token = "0x60008A8")]
		public bool get_IsError() { }

		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[Token(Token = "0x60008A7")]
		public bool get_IsFinish() { }

		[Address(RVA = "0x2721CC0", Offset = "0x27210C0", Length = "0xC")]
		[Token(Token = "0x60008AA")]
		public void SetError(int errorCode) { }

	}


	[Address(RVA = "0x2726910", Offset = "0x2725D10", Length = "0x121")]
	[AsyncStateMachine(typeof(<ReadFileAsync>d__1))]
	[Token(Token = "0x60008A5")]
	public static UniTask<Response> ReadFileAsync(string name, Action<Response> endcallback = null) { }

	[Address(RVA = "0x2726A40", Offset = "0x2725E40", Length = "0x13F")]
	[AsyncStateMachine(typeof(<WriteFileAsync>d__2))]
	[Token(Token = "0x60008A6")]
	public static UniTask<Response> WriteFileAsync(string pathname, Byte[] bytedata, Action<Response> endcallback = null) { }

}

