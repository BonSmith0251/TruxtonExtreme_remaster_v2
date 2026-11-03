namespace UnityEngine.UIElements;

[Token(Token = "0x200055D")]
internal enum HierarchyChangeType : int
{
	AddedToParent = 0,
	RemovedFromParent = 1,
	ChildrenReordered = 2,
	AttachedToPanel = 3,
	DetachedFromPanel = 4,
}

