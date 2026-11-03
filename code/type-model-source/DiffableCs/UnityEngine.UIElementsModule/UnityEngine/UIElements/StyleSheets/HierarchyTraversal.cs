namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200062A")]
internal abstract class HierarchyTraversal
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002B92")]
	protected HierarchyTraversal() { }

	[Address(RVA = "0x3318220", Offset = "0x3317620", Length = "0xCF")]
	[Token(Token = "0x6002B91")]
	protected void Recurse(VisualElement element, int depth) { }

	[Address(RVA = "0x33182F0", Offset = "0x33176F0", Length = "0x17")]
	[Token(Token = "0x6002B8F")]
	public override void Traverse(VisualElement element) { }

	[Token(Token = "0x6002B90")]
	public abstract void TraverseRecursive(VisualElement element, int depth) { }

}

