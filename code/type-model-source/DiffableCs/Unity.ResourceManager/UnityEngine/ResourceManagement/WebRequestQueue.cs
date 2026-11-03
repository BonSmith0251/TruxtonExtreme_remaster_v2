namespace UnityEngine.ResourceManagement;

[Token(Token = "0x2000013")]
public static class WebRequestQueue
{
	[Token(Token = "0x400004E")]
	internal static int s_MaxRequest; //Field offset: 0x0
	[Token(Token = "0x400004F")]
	internal static Queue<WebRequestQueueOperation> s_QueuedOperations; //Field offset: 0x8
	[Token(Token = "0x4000050")]
	internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests; //Field offset: 0x10

	[Address(RVA = "0x2E523D0", Offset = "0x2E517D0", Length = "0xFF")]
	[Token(Token = "0x60000A7")]
	private static WebRequestQueue() { }

	[Address(RVA = "0x2E51990", Offset = "0x2E50D90", Length = "0x1E2")]
	[Token(Token = "0x60000A6")]
	private static void BeginWebRequest(WebRequestQueueOperation queueOperation) { }

	[Address(RVA = "0x2E51B80", Offset = "0x2E50F80", Length = "0xA5")]
	[Token(Token = "0x60000A3")]
	internal static void DequeueRequest(UnityWebRequestAsyncOperation operation) { }

	[Address(RVA = "0x2E51C30", Offset = "0x2E51030", Length = "0x96")]
	[Token(Token = "0x60000A4")]
	private static void OnWebAsyncOpComplete(AsyncOperation operation) { }

	[Address(RVA = "0x2E51CD0", Offset = "0x2E510D0", Length = "0x10C")]
	[Token(Token = "0x60000A5")]
	private static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation) { }

	[Address(RVA = "0x2E51DE0", Offset = "0x2E511E0", Length = "0x120")]
	[Token(Token = "0x60000A1")]
	public static WebRequestQueueOperation QueueRequest(UnityWebRequest request) { }

	[Address(RVA = "0x2E51F10", Offset = "0x2E51310", Length = "0xBB")]
	[Token(Token = "0x60000A0")]
	public static void SetMaxConcurrentRequests(int maxRequests) { }

	[Address(RVA = "0x2E51FD0", Offset = "0x2E513D0", Length = "0x3F0")]
	[Token(Token = "0x60000A2")]
	public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout) { }

}

