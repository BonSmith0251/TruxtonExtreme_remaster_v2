namespace UnityEngine;

[NativeHeader("Modules/SpriteMask/Public/ScriptBindings/SpriteMask.bindings.h")]
[StaticAccessor("SpriteUtilityBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
internal static class SpriteMaskUtility
{

	[Address(RVA = "0x3166510", Offset = "0x3165910", Length = "0x33")]
	[Token(Token = "0x6000001")]
	internal static bool HasSpriteMaskInLayerRange(SortingLayerRange range) { }

	[Address(RVA = "0x31664D0", Offset = "0x31658D0", Length = "0x33")]
	[Token(Token = "0x6000002")]
	private static bool HasSpriteMaskInLayerRange_Injected(in SortingLayerRange range) { }

}

