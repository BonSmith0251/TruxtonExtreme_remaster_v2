namespace UnityEngine.UIElements;

[Token(Token = "0x200018D")]
internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000780")]
	private readonly Hashtable m_GenericData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000781")]
	private Label m_DraggedInfoLabel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000782")]
	private DragVisualMode m_VisualMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000783")]
	private IReadOnlyList<EntityId> m_EntityIds; //Field offset: 0x30

	[Token(Token = "0x1700020F")]
	public override DragAndDropData data
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000BBD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700020E")]
	public virtual object source
	{
		[Address(RVA = "0x33AD920", Offset = "0x33ACD20", Length = "0x48")]
		[Token(Token = "0x6000BB6")]
		 get { } //Length: 72
	}

	[Address(RVA = "0x33AD8B0", Offset = "0x33ACCB0", Length = "0x66")]
	[Token(Token = "0x6000BBE")]
	public DefaultDragAndDropClient() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BBA")]
	public override void AcceptDrag() { }

	[Address(RVA = "0x33ACF10", Offset = "0x33AC310", Length = "0x6F")]
	[Token(Token = "0x6000BBC")]
	public override void DragCleanup() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000BBD")]
	public override DragAndDropData get_data() { }

	[Address(RVA = "0x33AD920", Offset = "0x33ACD20", Length = "0x48")]
	[Token(Token = "0x6000BB6")]
	public virtual object get_source() { }

	[Address(RVA = "0x33ACF80", Offset = "0x33AC380", Length = "0x6C")]
	[Token(Token = "0x6000BB7")]
	public virtual object GetGenericData(string key) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000BBB")]
	public override void SetVisualMode(DragVisualMode mode) { }

	[Address(RVA = "0x33ACFF0", Offset = "0x33AC3F0", Length = "0x6D9")]
	[Token(Token = "0x6000BB8")]
	public override void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	[Address(RVA = "0x33AD6D0", Offset = "0x33ACAD0", Length = "0x1DE")]
	[Token(Token = "0x6000BB9")]
	public override void UpdateDrag(Vector3 pointerPosition) { }

}

