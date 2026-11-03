namespace UnityEngine.UIElements;

[Token(Token = "0x200055C")]
internal class VisualTreeWorldSpaceHierarchyFlagsUpdater : VisualTreeHierarchyFlagsUpdater
{

	[Address(RVA = "0x32EDD60", Offset = "0x32ED160", Length = "0x4F")]
	[Token(Token = "0x6002720")]
	public VisualTreeWorldSpaceHierarchyFlagsUpdater() { }

	[Address(RVA = "0x32ED8C0", Offset = "0x32ECCC0", Length = "0x16A")]
	[Token(Token = "0x600271D")]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	[Address(RVA = "0x32EDA30", Offset = "0x32ECE30", Length = "0xF0")]
	[Token(Token = "0x600271E")]
	private static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	[Address(RVA = "0x32EDB20", Offset = "0x32ECF20", Length = "0x25")]
	[Token(Token = "0x600271C")]
	private static VisualElementFlags GetParentMustDirtyFlags(VisualElement ve) { }

	[Address(RVA = "0x32EDB50", Offset = "0x32ECF50", Length = "0x204")]
	[Token(Token = "0x600271B")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600271F")]
	public virtual void Update() { }

}

