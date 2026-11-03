namespace UnityEngine.UIElements.Layout;

[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutNative.h")]
[Token(Token = "0x2000624")]
internal static class LayoutNative
{
	[Token(Token = "0x2000626")]
	public class LayoutLogData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001695")]
		public LayoutNode node; //Field offset: 0x10
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001696")]
		public LayoutLogEventType eventType; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001697")]
		public string message; //Field offset: 0x58

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002B8A")]
		public LayoutLogData() { }

	}

	[Token(Token = "0x2000625")]
	public enum LayoutLogEventType : int
	{
		None = 0,
		Error = 1,
		Measure = 2,
		Layout = 3,
		CacheUsage = 4,
		BeginLayout = 5,
		EndLayout = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400168C")]
	private static Action<LayoutLogData> onLayoutLog; //Field offset: 0x0

	[Address(RVA = "0x3320A20", Offset = "0x331FE20", Length = "0x62")]
	[NativeMethod(IsThreadSafe = False)]
	[Token(Token = "0x6002B88")]
	internal static void CalculateLayout(IntPtr node, float parentWidth, float parentHeight, int parentDirection, IntPtr state, IntPtr exceptionGCHandle) { }

	[Address(RVA = "0x3320A90", Offset = "0x331FE90", Length = "0xDF")]
	[RequiredByNativeCode]
	[Token(Token = "0x6002B89")]
	private static void LayoutLog_Internal(IntPtr nodePtr, LayoutLogEventType type, string message) { }

}

