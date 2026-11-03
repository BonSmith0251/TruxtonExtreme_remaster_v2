namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002A8")]
public class AsyncHelpers
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000DCF")]
	public AsyncHelpers() { }

	[Address(RVA = "0x2B8CF10", Offset = "0x2B8C310", Length = "0x19")]
	[Token(Token = "0x6000DCE")]
	internal static void CleanupAsyncBlock(XAsyncBlock block) { }

	[Address(RVA = "0x2B8CF30", Offset = "0x2B8C330", Length = "0x6D")]
	[Token(Token = "0x6000DCD")]
	public static XAsyncBlock WrapAsyncBlock(XTaskQueueHandle queue, XAsyncCompletionRoutine callback) { }

}

