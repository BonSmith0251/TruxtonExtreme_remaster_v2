namespace UnityEngine.UIElements;

[Token(Token = "0x20004CD")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class UIEventRegistration
{
	[CompilerGenerated]
	[Token(Token = "0x20004CE")]
	private sealed class <>c
	{
		[Token(Token = "0x4001037")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32BB1B0", Offset = "0x32BA5B0", Length = "0x67")]
		[Token(Token = "0x6002496")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002497")]
		public <>c() { }

		[Address(RVA = "0x32BAE40", Offset = "0x32BA240", Length = "0x40")]
		[Token(Token = "0x6002498")]
		internal void <.cctor>b__1_0() { }

		[Address(RVA = "0x32BAE80", Offset = "0x32BA280", Length = "0x40")]
		[Token(Token = "0x6002499")]
		internal void <.cctor>b__1_1() { }

		[Address(RVA = "0x32BAEC0", Offset = "0x32BA2C0", Length = "0x57")]
		[Token(Token = "0x600249A")]
		internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

		[Address(RVA = "0x32BAF20", Offset = "0x32BA320", Length = "0x40")]
		[Token(Token = "0x600249B")]
		internal void <.cctor>b__1_3() { }

		[Address(RVA = "0x32BAF60", Offset = "0x32BA360", Length = "0x49")]
		[Token(Token = "0x600249C")]
		internal bool <.cctor>b__1_4(Exception exception) { }

		[Address(RVA = "0x32BAFB0", Offset = "0x32BA3B0", Length = "0x40")]
		[Token(Token = "0x600249D")]
		internal void <.cctor>b__1_5() { }

	}

	[Token(Token = "0x4001036")]
	private static List<IUIElementsUtility> s_Utilities; //Field offset: 0x0

	[Address(RVA = "0x32BFEC0", Offset = "0x32BF2C0", Length = "0x6C2")]
	[Token(Token = "0x600248E")]
	private static UIEventRegistration() { }

	[Address(RVA = "0x32BF410", Offset = "0x32BE810", Length = "0x168")]
	[Token(Token = "0x6002494")]
	private static void CleanupRoots() { }

	[Address(RVA = "0x32BF580", Offset = "0x32BE980", Length = "0x243")]
	[Token(Token = "0x6002492")]
	private static bool EndContainerGUIFromException(Exception exception) { }

	[Address(RVA = "0x32BF7D0", Offset = "0x32BEBD0", Length = "0x168")]
	[Token(Token = "0x6002495")]
	internal static void MakeCurrentIMGUIContainerDirty() { }

	[Address(RVA = "0x32BF940", Offset = "0x32BED40", Length = "0x21F")]
	[Token(Token = "0x6002493")]
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[Address(RVA = "0x32BFB60", Offset = "0x32BEF60", Length = "0x7A")]
	[Token(Token = "0x600248F")]
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	[Address(RVA = "0x32BFBE0", Offset = "0x32BEFE0", Length = "0x168")]
	[Token(Token = "0x6002491")]
	private static void ReleaseCapture() { }

	[Address(RVA = "0x32BFD50", Offset = "0x32BF150", Length = "0x165")]
	[Token(Token = "0x6002490")]
	private static void TakeCapture() { }

}

