namespace UnityEngine;

[Token(Token = "0x2000021")]
internal class IMGUITextHandle : TextHandle
{
	[Token(Token = "0x2000022")]
	public class TextHandleTuple
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CD")]
		public float lastTimeUsed; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000CE")]
		public int hashCode; //Field offset: 0x14

		[Address(RVA = "0x30F98F0", Offset = "0x30F8CF0", Length = "0x37")]
		[Token(Token = "0x60001C5")]
		public TextHandleTuple(float lastTimeUsed, int hashCode) { }

	}

	[Token(Token = "0x40000C8")]
	private static Dictionary<Int32, IMGUITextHandle> textHandles; //Field offset: 0x0
	[Token(Token = "0x40000C9")]
	private static LinkedList<TextHandleTuple> textHandlesTuple; //Field offset: 0x8
	[Token(Token = "0x40000CA")]
	private static float lastCleanupTime; //Field offset: 0x10
	[Token(Token = "0x40000CB")]
	private static int newHandlesSinceCleanup; //Field offset: 0x14
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000C7")]
	internal LinkedListNode<TextHandleTuple> tuple; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000CC")]
	internal bool isCachedOnNative; //Field offset: 0xD0

	[Address(RVA = "0x30F6800", Offset = "0x30F5C00", Length = "0xFC")]
	[Token(Token = "0x60001C4")]
	private static IMGUITextHandle() { }

	[Address(RVA = "0x30F6900", Offset = "0x30F5D00", Length = "0x50")]
	[Token(Token = "0x60001C3")]
	public IMGUITextHandle() { }

	[Address(RVA = "0x30F5260", Offset = "0x30F4660", Length = "0x263")]
	[Token(Token = "0x60001BC")]
	private static void ClearUnusedTextHandles() { }

	[Address(RVA = "0x30F54D0", Offset = "0x30F48D0", Length = "0x978")]
	[Token(Token = "0x60001C0")]
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	[Address(RVA = "0x30F5E60", Offset = "0x30F5260", Length = "0x9E")]
	[Token(Token = "0x60001B8")]
	internal static void EmptyManagedCache() { }

	[Address(RVA = "0x30F5F00", Offset = "0x30F5300", Length = "0x195")]
	[Token(Token = "0x60001BF")]
	internal static float GetLineHeight(GUIStyle style) { }

	[Address(RVA = "0x30F60A0", Offset = "0x30F54A0", Length = "0x5B")]
	[Token(Token = "0x60001BE")]
	protected virtual float GetPixelsPerPoint() { }

	[Address(RVA = "0x30F6260", Offset = "0x30F5660", Length = "0x14C")]
	[Token(Token = "0x60001B9")]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	[Address(RVA = "0x30F6100", Offset = "0x30F5500", Length = "0x153")]
	[Token(Token = "0x60001BA")]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	[Address(RVA = "0x30F63B0", Offset = "0x30F57B0", Length = "0x40A")]
	[Token(Token = "0x60001BD")]
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x60001C2")]
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	[Address(RVA = "0x30F67C0", Offset = "0x30F5BC0", Length = "0x1A")]
	[Token(Token = "0x60001C1")]
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	[Address(RVA = "0x30F67E0", Offset = "0x30F5BE0", Length = "0x1C")]
	[Token(Token = "0x60001BB")]
	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

}

