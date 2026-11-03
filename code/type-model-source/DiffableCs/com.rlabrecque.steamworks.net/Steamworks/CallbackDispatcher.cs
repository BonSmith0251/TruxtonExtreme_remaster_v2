namespace Steamworks;

[Token(Token = "0x2000182")]
public static class CallbackDispatcher
{
	[Token(Token = "0x4000A4E")]
	private static Dictionary<Int32, List`1<Callback>> m_registeredCallbacks; //Field offset: 0x0
	[Token(Token = "0x4000A4F")]
	private static Dictionary<Int32, List`1<Callback>> m_registeredGameServerCallbacks; //Field offset: 0x8
	[Token(Token = "0x4000A50")]
	private static Dictionary<UInt64, List`1<CallResult>> m_registeredCallResults; //Field offset: 0x10
	[Token(Token = "0x4000A51")]
	private static object m_sync; //Field offset: 0x18
	[Token(Token = "0x4000A52")]
	private static IntPtr m_pCallbackMsg; //Field offset: 0x20
	[Token(Token = "0x4000A53")]
	private static int m_initCount; //Field offset: 0x28

	[Token(Token = "0x17000021")]
	public static bool IsInitialized
	{
		[Address(RVA = "0x609DA0", Offset = "0x6091A0", Length = "0x52")]
		[Token(Token = "0x60008B9")]
		 get { } //Length: 82
	}

	[Address(RVA = "0x609C10", Offset = "0x609010", Length = "0x181")]
	[Token(Token = "0x60008C2")]
	private static CallbackDispatcher() { }

	[Address(RVA = "0x607AB0", Offset = "0x606EB0", Length = "0x49")]
	[Token(Token = "0x60008B8")]
	public static void ExceptionHandler(Exception e) { }

	[Address(RVA = "0x609DA0", Offset = "0x6091A0", Length = "0x52")]
	[Token(Token = "0x60008B9")]
	public static bool get_IsInitialized() { }

	[Address(RVA = "0x607B00", Offset = "0x606F00", Length = "0x23E")]
	[Token(Token = "0x60008BA")]
	internal static void Initialize() { }

	[Address(RVA = "0x607D40", Offset = "0x607140", Length = "0x28A")]
	[Token(Token = "0x60008BC")]
	internal static void Register(Callback cb) { }

	[Address(RVA = "0x607FD0", Offset = "0x6073D0", Length = "0x29D")]
	[Token(Token = "0x60008BD")]
	internal static void Register(SteamAPICall_t asyncCall, CallResult cr) { }

	[Address(RVA = "0x608270", Offset = "0x607670", Length = "0xB8F")]
	[Token(Token = "0x60008C1")]
	internal static void RunFrame(bool isGameServer) { }

	[Address(RVA = "0x608E00", Offset = "0x608200", Length = "0x17A")]
	[Token(Token = "0x60008BB")]
	internal static void Shutdown() { }

	[Address(RVA = "0x6099F0", Offset = "0x608DF0", Length = "0x212")]
	[Token(Token = "0x60008BE")]
	internal static void Unregister(Callback cb) { }

	[Address(RVA = "0x6097C0", Offset = "0x608BC0", Length = "0x228")]
	[Token(Token = "0x60008BF")]
	internal static void Unregister(SteamAPICall_t asyncCall, CallResult cr) { }

	[Address(RVA = "0x608F80", Offset = "0x608380", Length = "0x83C")]
	[Token(Token = "0x60008C0")]
	private static void UnregisterAll() { }

}

