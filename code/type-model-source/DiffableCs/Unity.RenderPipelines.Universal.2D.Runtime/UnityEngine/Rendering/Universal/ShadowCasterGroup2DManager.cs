namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006D")]
internal class ShadowCasterGroup2DManager
{
	[Token(Token = "0x400026C")]
	private static List<ShadowCasterGroup2D> s_ShadowCasterGroups; //Field offset: 0x0

	[Token(Token = "0x17000090")]
	public static List<ShadowCasterGroup2D> shadowCasterGroups
	{
		[Address(RVA = "0x2D3DC70", Offset = "0x2D3D070", Length = "0x36")]
		[Token(Token = "0x60002A5")]
		 get { } //Length: 54
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002AF")]
	public ShadowCasterGroup2DManager() { }

	[Address(RVA = "0x2D3D200", Offset = "0x2D3C600", Length = "0x1AA")]
	[Token(Token = "0x60002AD")]
	public static void AddGroup(ShadowCasterGroup2D group) { }

	[Address(RVA = "0x2D3D3B0", Offset = "0x2D3C7B0", Length = "0xDA")]
	[Token(Token = "0x60002A7")]
	public static void AddShadowCasterGroupToList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

	[Address(RVA = "0x2D3D490", Offset = "0x2D3C890", Length = "0x333")]
	[Token(Token = "0x60002AB")]
	public static bool AddToShadowCasterGroup(ShadowCaster2D shadowCaster, ref ShadowCasterGroup2D shadowCasterGroup, ref int priority) { }

	[Address(RVA = "0x2D3D7D0", Offset = "0x2D3CBD0", Length = "0x17E")]
	[Token(Token = "0x60002A6")]
	public static void CacheValues() { }

	[Address(RVA = "0x2D3D950", Offset = "0x2D3CD50", Length = "0xBF")]
	[Token(Token = "0x60002A9")]
	private static CompositeShadowCaster2D FindTopMostCompositeShadowCaster(ShadowCaster2D shadowCaster) { }

	[Address(RVA = "0x2D3DC70", Offset = "0x2D3D070", Length = "0x36")]
	[Token(Token = "0x60002A5")]
	public static List<ShadowCasterGroup2D> get_shadowCasterGroups() { }

	[Address(RVA = "0x2D3DA10", Offset = "0x2D3CE10", Length = "0x72")]
	[Token(Token = "0x60002AA")]
	public static int GetRendereringPriority(ShadowCaster2D shadowCaster) { }

	[Address(RVA = "0x2D3DA90", Offset = "0x2D3CE90", Length = "0xCE")]
	[Token(Token = "0x60002AC")]
	public static void RemoveFromShadowCasterGroup(ShadowCaster2D shadowCaster, ShadowCasterGroup2D shadowCasterGroup) { }

	[Address(RVA = "0x2D3DB60", Offset = "0x2D3CF60", Length = "0xAC")]
	[Token(Token = "0x60002AE")]
	public static void RemoveGroup(ShadowCasterGroup2D group) { }

	[Address(RVA = "0x2D3DC10", Offset = "0x2D3D010", Length = "0x52")]
	[Token(Token = "0x60002A8")]
	public static void RemoveShadowCasterGroupFromList(ShadowCasterGroup2D shadowCaster, List<ShadowCasterGroup2D> list) { }

}

