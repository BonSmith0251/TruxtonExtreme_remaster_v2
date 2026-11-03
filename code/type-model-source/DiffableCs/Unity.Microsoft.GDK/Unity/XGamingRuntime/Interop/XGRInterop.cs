namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002B0")]
internal class XGRInterop
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000E0E")]
	public XGRInterop() { }

	[Address(RVA = "0x2BA02E0", Offset = "0x2B9F6E0", Length = "0x94")]
	[Token(Token = "0x6000E0C")]
	public static int HCAddWebSocketRoutedHandler(HCWebSocketRoutedHandler handler, IntPtr conext) { }

	[Address(RVA = "0x2BA0380", Offset = "0x2B9F780", Length = "0x78")]
	[Token(Token = "0x6000DFF")]
	public static int HCCleanupAsync(XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA0400", Offset = "0x2B9F800", Length = "0x87")]
	[Token(Token = "0x6000E05")]
	public static int HCGetWebSocketConnectResult(XAsyncBlockPtr asyncBlock, in WebSocketCompletionResult result) { }

	[Address(RVA = "0x2BA0490", Offset = "0x2B9F890", Length = "0x87")]
	[Token(Token = "0x6000E08")]
	public static int HCGetWebSocketSendMessageResult(XAsyncBlockPtr asyncBlock, in WebSocketCompletionResult result) { }

	[Address(RVA = "0x2BA0520", Offset = "0x2B9F920", Length = "0x78")]
	[Token(Token = "0x6000DFE")]
	public static int HCInitialize(IntPtr args) { }

	[Address(RVA = "0x2BA05A0", Offset = "0x2B9F9A0", Length = "0x76")]
	[Token(Token = "0x6000E0D")]
	public static void HCRemoveWebSocketRoutedHandler(int handlerId) { }

	[Address(RVA = "0x2BA0620", Offset = "0x2B9FA20", Length = "0x78")]
	[Token(Token = "0x6000E0B")]
	public static int HCWebSocketCloseHandle(IntPtr websocket) { }

	[Address(RVA = "0x2BA06A0", Offset = "0x2B9FAA0", Length = "0xB5")]
	[Token(Token = "0x6000E04")]
	public static int HCWebSocketConnectAsync(Byte[] uri, Byte[] subProtocol, IntPtr websocket, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA0760", Offset = "0x2B9FB60", Length = "0xC8")]
	[Token(Token = "0x6000E00")]
	public static int HCWebSocketCreate(out IntPtr websocket, HCWebSocketMessageFunction messageFunc, HCWebSocketBinaryMessageFunction binaryMessageFunc, HCWebSocketCloseEventFunction closeFunc, IntPtr functionContext) { }

	[Address(RVA = "0x2BA0830", Offset = "0x2B9FC30", Length = "0x78")]
	[Token(Token = "0x6000E09")]
	public static int HCWebSocketDisconnect(IntPtr websocket) { }

	[Address(RVA = "0x2BA08B0", Offset = "0x2B9FCB0", Length = "0x78")]
	[Token(Token = "0x6000E0A")]
	public static IntPtr HCWebSocketDuplicateHandle(IntPtr websocket) { }

	[Address(RVA = "0x2BA0930", Offset = "0x2B9FD30", Length = "0x17F")]
	[Token(Token = "0x6000E03")]
	public static int HCWebSocketGetEventFunctions(IntPtr websocket, out HCWebSocketMessageFunction messageFunc, out HCWebSocketBinaryMessageFunction binaryMessageFunc, out HCWebSocketCloseEventFunction closeFunc, out IntPtr functionContext) { }

	[Address(RVA = "0x2BA0AB0", Offset = "0x2B9FEB0", Length = "0xAC")]
	[Token(Token = "0x6000E07")]
	public static int HCWebSocketSendBinaryMessageAsync(IntPtr websocket, Byte[] data, uint payloadSize, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA0B60", Offset = "0x2B9FF60", Length = "0x9D")]
	[Token(Token = "0x6000E06")]
	public static int HCWebSocketSendMessageAsync(IntPtr websocket, Byte[] message, XAsyncBlockPtr asyncBlock) { }

	[Address(RVA = "0x2BA0C00", Offset = "0x2BA0000", Length = "0xA5")]
	[Token(Token = "0x6000E02")]
	public static int HCWebSocketSetHeader(IntPtr websocket, Byte[] headerName, Byte[] headerValue) { }

	[Address(RVA = "0x2BA0CB0", Offset = "0x2BA00B0", Length = "0x91")]
	[Token(Token = "0x6000E01")]
	public static int HCWebSocketSetProxyUri(IntPtr websocket, Byte[] proxyUri) { }

}

