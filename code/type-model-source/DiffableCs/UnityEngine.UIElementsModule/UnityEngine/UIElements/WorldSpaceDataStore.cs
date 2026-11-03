namespace UnityEngine.UIElements;

[Token(Token = "0x200056C")]
internal static class WorldSpaceDataStore
{
	[Token(Token = "0x4001205")]
	private static Dictionary<UInt32, WorldSpaceData> m_WorldSpaceData; //Field offset: 0x0

	[Address(RVA = "0x32EE340", Offset = "0x32ED740", Length = "0x84")]
	[Token(Token = "0x6002780")]
	private static WorldSpaceDataStore() { }

	[Address(RVA = "0x32EDDB0", Offset = "0x32ED1B0", Length = "0x225")]
	[Token(Token = "0x600277F")]
	public static void ClearLocalBounds3DData(VisualElement ve) { }

	[Address(RVA = "0x32EDFE0", Offset = "0x32ED3E0", Length = "0x127")]
	[Token(Token = "0x600277E")]
	public static void ClearWorldSpaceData(VisualElement ve) { }

	[Address(RVA = "0x32EE110", Offset = "0x32ED510", Length = "0x148")]
	[Token(Token = "0x600277D")]
	public static WorldSpaceData GetWorldSpaceData(VisualElement ve) { }

	[Address(RVA = "0x32EE260", Offset = "0x32ED660", Length = "0xD2")]
	[Token(Token = "0x600277C")]
	public static void SetWorldSpaceData(VisualElement ve, WorldSpaceData data) { }

}

