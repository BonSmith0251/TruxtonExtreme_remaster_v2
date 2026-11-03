namespace UnityEngine.EventSystems;

[Token(Token = "0x20000C7")]
public static class RaycasterManager
{
	[Token(Token = "0x400036A")]
	private static readonly List<BaseRaycaster> s_Raycasters; //Field offset: 0x0

	[Address(RVA = "0x3470120", Offset = "0x346F520", Length = "0x84")]
	[Token(Token = "0x600077F")]
	private static RaycasterManager() { }

	[Address(RVA = "0x346FED0", Offset = "0x346F2D0", Length = "0x120")]
	[Token(Token = "0x600077C")]
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	[Address(RVA = "0x3470000", Offset = "0x346F400", Length = "0x4E")]
	[Token(Token = "0x600077D")]
	public static List<BaseRaycaster> GetRaycasters() { }

	[Address(RVA = "0x3470050", Offset = "0x346F450", Length = "0xCB")]
	[Token(Token = "0x600077E")]
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

}

