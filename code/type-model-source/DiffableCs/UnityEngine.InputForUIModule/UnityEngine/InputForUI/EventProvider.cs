namespace UnityEngine.InputForUI;

[Token(Token = "0x200001D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class EventProvider
{
	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <>c
	{
		[Token(Token = "0x40000B2")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000B3")]
		public static Comparison<Registration> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x31103E0", Offset = "0x310F7E0", Length = "0x67")]
		[Token(Token = "0x600007A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600007B")]
		public <>c() { }

		[Address(RVA = "0x31103A0", Offset = "0x310F7A0", Length = "0x1B")]
		[Token(Token = "0x600007C")]
		internal int <Subscribe>b__7_0(Registration a, Registration b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000B4")]
		public EventConsumer handler; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600007D")]
		public <>c__DisplayClass8_0() { }

		[Address(RVA = "0x31103C0", Offset = "0x310F7C0", Length = "0x12")]
		[Token(Token = "0x600007E")]
		internal bool <Unsubscribe>b__0(Registration x) { }

	}

	[Token(Token = "0x200001E")]
	private struct Registration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000AE")]
		public EventConsumer handler; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000AF")]
		public int priority; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40000B0")]
		public Nullable<Int32> playerId; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000B1")]
		public HashSet<Type> _types; //Field offset: 0x18

	}

	[Token(Token = "0x40000A7")]
	private static IEventProviderImpl s_impl; //Field offset: 0x0
	[Token(Token = "0x40000A8")]
	private static EventSanitizer s_sanitizer; //Field offset: 0x8
	[Token(Token = "0x40000A9")]
	private static IEventProviderImpl s_implMockBackup; //Field offset: 0x10
	[Token(Token = "0x40000AA")]
	private static bool s_focusChangedRegistered; //Field offset: 0x18
	[Token(Token = "0x40000AB")]
	private static bool m_IsEnabled; //Field offset: 0x19
	[Token(Token = "0x40000AC")]
	private static bool m_IsInitialized; //Field offset: 0x1A
	[Token(Token = "0x40000AD")]
	private static List<Registration> _registrations; //Field offset: 0x20

	[Address(RVA = "0x3108370", Offset = "0x3107770", Length = "0x128")]
	[Token(Token = "0x6000079")]
	private static EventProvider() { }

	[Address(RVA = "0x3107590", Offset = "0x3106990", Length = "0x67")]
	[Token(Token = "0x6000073")]
	private static void Bootstrap() { }

	[Address(RVA = "0x3107600", Offset = "0x3106A00", Length = "0x28E")]
	[Token(Token = "0x6000072")]
	internal static void Dispatch(in Event ev) { }

	[Address(RVA = "0x3107890", Offset = "0x3106C90", Length = "0x193")]
	[Token(Token = "0x6000074")]
	private static void Initialize() { }

	[Address(RVA = "0x3107A30", Offset = "0x3106E30", Length = "0x152")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000077")]
	internal static void NotifyUpdate() { }

	[Address(RVA = "0x3107B90", Offset = "0x3106F90", Length = "0xE3")]
	[Token(Token = "0x6000076")]
	private static void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x3107C80", Offset = "0x3107080", Length = "0x8E")]
	[Token(Token = "0x6000071")]
	public static void SetEnabled(bool enable) { }

	[Address(RVA = "0x3107D10", Offset = "0x3107110", Length = "0xAC")]
	[Token(Token = "0x6000078")]
	internal static void SetInputSystemProvider(IEventProviderImpl impl) { }

	[Address(RVA = "0x3107DC0", Offset = "0x31071C0", Length = "0x162")]
	[Token(Token = "0x6000075")]
	private static void Shutdown() { }

	[Address(RVA = "0x3107F30", Offset = "0x3107330", Length = "0x32A")]
	[Token(Token = "0x600006F")]
	public static void Subscribe(EventConsumer handler, int priority = 0, Nullable<Int32> playerId = null, Type[] type) { }

	[Address(RVA = "0x3108260", Offset = "0x3107660", Length = "0x109")]
	[Token(Token = "0x6000070")]
	public static void Unsubscribe(EventConsumer handler) { }

}

