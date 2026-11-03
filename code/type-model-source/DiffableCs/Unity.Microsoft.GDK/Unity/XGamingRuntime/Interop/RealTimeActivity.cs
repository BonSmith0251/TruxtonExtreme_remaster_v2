namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003AF")]
public static class RealTimeActivity
{
	[Token(Token = "0x20003B0")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	internal sealed class XblRealTimeActivityConnectionStateChangeHandler : MulticastDelegate
	{

		[Address(RVA = "0x2BB7F80", Offset = "0x2BB7380", Length = "0xA6")]
		[Token(Token = "0x600126C")]
		public XblRealTimeActivityConnectionStateChangeHandler(object object, IntPtr method) { }

		[Address(RVA = "0x2BB7EE0", Offset = "0x2BB72E0", Length = "0x91")]
		[Token(Token = "0x600126E")]
		public override IAsyncResult BeginInvoke(IntPtr context, XblRealTimeActivityConnectionState connectionState, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600126F")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600126D")]
		public override void Invoke(IntPtr context, XblRealTimeActivityConnectionState connectionState) { }

	}

	[Token(Token = "0x20003B1")]
	[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
	internal sealed class XblRealTimeActivityResyncHandler : MulticastDelegate
	{

		[Address(RVA = "0x60D6F0", Offset = "0x60CAF0", Length = "0xA6")]
		[Token(Token = "0x6001270")]
		public XblRealTimeActivityResyncHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60D690", Offset = "0x60CA90", Length = "0x5E")]
		[Token(Token = "0x6001272")]
		public override IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6001273")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001271")]
		public override void Invoke(IntPtr context) { }

	}


	[Address(RVA = "0x2B9EB10", Offset = "0x2B9DF10", Length = "0xA0")]
	[Token(Token = "0x6001268")]
	public static int XblRealTimeActivityAddConnectionStateChangeHandler(IntPtr xboxLiveContext, XblRealTimeActivityConnectionStateChangeHandler handler, IntPtr context) { }

	[Address(RVA = "0x2B9EBB0", Offset = "0x2B9DFB0", Length = "0xA0")]
	[Token(Token = "0x600126A")]
	public static int XblRealTimeActivityAddResyncHandler(IntPtr xboxLiveContext, XblRealTimeActivityResyncHandler handler, IntPtr context) { }

	[Address(RVA = "0x2B9EC50", Offset = "0x2B9E050", Length = "0x85")]
	[Token(Token = "0x6001269")]
	public static int XblRealTimeActivityRemoveConnectionStateChangeHandler(IntPtr xboxLiveContext, int token) { }

	[Address(RVA = "0x2B9ECE0", Offset = "0x2B9E0E0", Length = "0x85")]
	[Token(Token = "0x600126B")]
	public static int XblRealTimeActivityRemoveResyncHandler(IntPtr xboxLiveContext, int token) { }

}

