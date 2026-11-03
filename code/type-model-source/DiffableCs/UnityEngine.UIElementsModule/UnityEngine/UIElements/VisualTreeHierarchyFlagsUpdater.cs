namespace UnityEngine.UIElements;

[Token(Token = "0x200055B")]
internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x40011BD")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x40011BE")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011BB")]
	private uint m_Version; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40011BC")]
	private uint m_LastVersion; //Field offset: 0x2C

	[Token(Token = "0x17000A1D")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x32E8AF0", Offset = "0x32E7EF0", Length = "0x4F")]
		[Token(Token = "0x6002712")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x32E8A40", Offset = "0x32E7E40", Length = "0x9B")]
	[Token(Token = "0x600271A")]
	private static VisualTreeHierarchyFlagsUpdater() { }

	[Address(RVA = "0x32E8AE0", Offset = "0x32E7EE0", Length = "0xD")]
	[Token(Token = "0x6002719")]
	public VisualTreeHierarchyFlagsUpdater() { }

	[Address(RVA = "0x32E8540", Offset = "0x32E7940", Length = "0xEF")]
	[Token(Token = "0x6002716")]
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	[Address(RVA = "0x32E8630", Offset = "0x32E7A30", Length = "0xEF")]
	[Token(Token = "0x6002715")]
	protected static void DirtyChildrenHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	[Address(RVA = "0x32E8720", Offset = "0x32E7B20", Length = "0x6E")]
	[Token(Token = "0x6002717")]
	private static void DirtyParentHierarchy(VisualElement ve, VisualElementFlags flags) { }

	[Address(RVA = "0x32E8AF0", Offset = "0x32E7EF0", Length = "0x4F")]
	[Token(Token = "0x6002712")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32E8790", Offset = "0x32E7B90", Length = "0x37")]
	[Token(Token = "0x6002714")]
	protected static VisualElementFlags GetChildrenMustDirtyFlags(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32E87D0", Offset = "0x32E7BD0", Length = "0x1B0")]
	[Token(Token = "0x6002713")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32E8990", Offset = "0x32E7D90", Length = "0xA8")]
	[Token(Token = "0x6002718")]
	public virtual void Update() { }

}

