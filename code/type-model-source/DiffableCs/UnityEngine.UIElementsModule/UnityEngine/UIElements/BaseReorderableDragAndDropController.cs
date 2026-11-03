namespace UnityEngine.UIElements;

[Token(Token = "0x200018B")]
internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077A")]
	protected readonly BaseVerticalCollectionView m_View; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400077B")]
	protected List<Int32> m_SortedSelectedIds; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077C")]
	private bool <enableReordering>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700020D")]
	public override bool enableReordering
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BAC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x33AC520", Offset = "0x33AB920", Length = "0x98")]
	[Token(Token = "0x6000BAA")]
	protected BaseReorderableDragAndDropController(BaseVerticalCollectionView view) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000BAE")]
	public override bool CanDrop() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000BAD")]
	public override bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	[Address(RVA = "0x33AC000", Offset = "0x33AB400", Length = "0x1D")]
	[Token(Token = "0x6000BB0")]
	protected override int CompareId(int id1, int id2) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BB3")]
	public override void DragCleanup() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAB")]
	public override bool get_enableReordering() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000BA9")]
	public override IEnumerable<Int32> GetSortedSelectedIds() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BB4")]
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Token(Token = "0x6000BB1")]
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BB2")]
	public override void OnDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BAC")]
	public override void set_enableReordering(bool value) { }

	[Address(RVA = "0x33AC020", Offset = "0x33AB420", Length = "0x4F1")]
	[Token(Token = "0x6000BAF")]
	public override StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}

