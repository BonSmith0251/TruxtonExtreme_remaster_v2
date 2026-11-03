namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000031")]
public static class OcclusionTestMethods
{

	[Address(RVA = "0x2CD3930", Offset = "0x2CD2D30", Length = "0x11")]
	[Extension]
	[Token(Token = "0x600011D")]
	public static uint GetBatchLayerMask(OcclusionTest occlusionTest) { }

}

