namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x200019F")]
internal static class ListViewDraggerExtension
{

	[Address(RVA = "0x33D41B0", Offset = "0x33D35B0", Length = "0x19D")]
	[Extension]
	[Token(Token = "0x6000C28")]
	public static ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) { }

	[Address(RVA = "0x33D4350", Offset = "0x33D3750", Length = "0x19D")]
	[Extension]
	[Token(Token = "0x6000C29")]
	public static ReusableCollectionItem GetRecycledItemFromIndex(BaseVerticalCollectionView listView, int index) { }

}

