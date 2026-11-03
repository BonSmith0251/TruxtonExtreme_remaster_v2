namespace UnityEngine.UIElements;

[Token(Token = "0x2000284")]
internal class UIDocumentList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009F5")]
	internal List<UIDocument> m_AttachedUIDocuments; //Field offset: 0x10

	[Address(RVA = "0x33F4B70", Offset = "0x33F3F70", Length = "0x77")]
	[Token(Token = "0x600119D")]
	public UIDocumentList() { }

	[Address(RVA = "0x33F4760", Offset = "0x33F3B60", Length = "0x390")]
	[Token(Token = "0x600119C")]
	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, bool ignoreContentContainer, int firstInsertIndex = 0) { }

	[Address(RVA = "0x33F4B00", Offset = "0x33F3F00", Length = "0x69")]
	[Token(Token = "0x600119B")]
	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

}

