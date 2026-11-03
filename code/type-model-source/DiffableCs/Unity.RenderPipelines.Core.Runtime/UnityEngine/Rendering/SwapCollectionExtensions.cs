namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000069")]
public static class SwapCollectionExtensions
{

	[Address(RVA = "0x93F1D0", Offset = "0x93E5D0", Length = "0x4A9")]
	[CollectionAccess(CollectionAccessType::ModifyExistingContent (2))]
	[Extension]
	[MustUseReturnValue]
	[Token(Token = "0x600057C")]
	public static bool TrySwap(IList<TValue> list, int from, int to, out Exception error) { }

}

