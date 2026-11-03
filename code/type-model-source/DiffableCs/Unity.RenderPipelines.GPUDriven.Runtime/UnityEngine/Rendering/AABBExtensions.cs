namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000007")]
internal static class AABBExtensions
{

	[Address(RVA = "0x2CC0460", Offset = "0x2CBF860", Length = "0x8E")]
	[Extension]
	[Token(Token = "0x600000A")]
	public static AABB ToAABB(Bounds bounds) { }

	[Address(RVA = "0x2CC04F0", Offset = "0x2CBF8F0", Length = "0xB1")]
	[Extension]
	[Token(Token = "0x600000B")]
	public static Bounds ToBounds(AABB aabb) { }

}

