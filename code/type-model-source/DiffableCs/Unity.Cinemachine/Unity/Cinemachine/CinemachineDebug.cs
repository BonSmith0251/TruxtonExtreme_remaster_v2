namespace Unity.Cinemachine;

[Token(Token = "0x20000FC")]
internal static class CinemachineDebug
{
	[Token(Token = "0x40003A6")]
	private static List<StringBuilder> s_AvailableStringBuilders; //Field offset: 0x0
	[Token(Token = "0x40003A7")]
	public static Action<CinemachineBrain> OnGUIHandlers; //Field offset: 0x8
	[Token(Token = "0x40003A8")]
	public static bool GameViewGuidesEnabled; //Field offset: 0x10

	[Address(RVA = "0x2859EB0", Offset = "0x28592B0", Length = "0x12C")]
	[Token(Token = "0x60004A8")]
	public static void ReturnToPool(StringBuilder sb) { }

	[Address(RVA = "0x2859FE0", Offset = "0x28593E0", Length = "0xFA")]
	[Token(Token = "0x60004A7")]
	public static StringBuilder SBFromPool() { }

}

