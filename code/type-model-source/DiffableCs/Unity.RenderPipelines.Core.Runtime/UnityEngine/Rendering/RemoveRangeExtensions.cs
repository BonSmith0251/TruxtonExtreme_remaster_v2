namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000064")]
public static class RemoveRangeExtensions
{

	[Address(RVA = "0x8E6040", Offset = "0x8E5440", Length = "0x1A4")]
	[CollectionAccess(CollectionAccessType::ModifyExistingContent (2))]
	[Extension]
	[MustUseReturnValue]
	[Token(Token = "0x600056A")]
	public static bool TryRemoveElementsInRange(IList<TValue> list, int index, int count, out Exception error) { }

}

