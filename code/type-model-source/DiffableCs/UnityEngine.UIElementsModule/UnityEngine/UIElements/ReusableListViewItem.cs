namespace UnityEngine.UIElements;

[Token(Token = "0x200006C")]
internal class ReusableListViewItem : ReusableCollectionItem
{
	[Token(Token = "0x4000201")]
	private static readonly string k_SortingDisablesReorderingTooltip; //Field offset: 0x0
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000202")]
	private VisualElement m_Container; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000203")]
	private VisualElement m_DragHandle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000204")]
	private VisualElement m_ItemContainer; //Field offset: 0x58

	[Token(Token = "0x17000083")]
	public virtual VisualElement rootElement
	{
		[Address(RVA = "0x3227270", Offset = "0x3226670", Length = "0xE")]
		[Token(Token = "0x60003BD")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x32271F0", Offset = "0x32265F0", Length = "0x62")]
	[Token(Token = "0x60003C7")]
	private static ReusableListViewItem() { }

	[Address(RVA = "0x3227260", Offset = "0x3226660", Length = "0x7")]
	[Token(Token = "0x60003C6")]
	public ReusableListViewItem() { }

	[Address(RVA = "0x32269C0", Offset = "0x3225DC0", Length = "0x8F")]
	[Token(Token = "0x60003C3")]
	public virtual void DetachElement() { }

	[Address(RVA = "0x3227270", Offset = "0x3226670", Length = "0xE")]
	[Token(Token = "0x60003BD")]
	public virtual VisualElement get_rootElement() { }

	[Address(RVA = "0x3226A50", Offset = "0x3225E50", Length = "0xD8")]
	[Token(Token = "0x60003BE")]
	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	[Address(RVA = "0x3226B30", Offset = "0x3225F30", Length = "0x8B")]
	[Token(Token = "0x60003C5")]
	protected virtual void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3226BC0", Offset = "0x3225FC0", Length = "0x8F")]
	[Token(Token = "0x60003C2")]
	public virtual void PreAttachElement() { }

	[Address(RVA = "0x3226C50", Offset = "0x3226050", Length = "0x65")]
	[Token(Token = "0x60003C4")]
	public virtual void SetDragGhost(bool dragGhost) { }

	[Address(RVA = "0x3226CC0", Offset = "0x32260C0", Length = "0x99")]
	[Token(Token = "0x60003C1")]
	public void SetDragHandleEnabled(bool enabled) { }

	[Address(RVA = "0x3226D60", Offset = "0x3226160", Length = "0x169")]
	[Token(Token = "0x60003C0")]
	public void UpdateDragHandle(bool needsDragHandle) { }

	[Address(RVA = "0x3226ED0", Offset = "0x32262D0", Length = "0x314")]
	[Token(Token = "0x60003BF")]
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

}

