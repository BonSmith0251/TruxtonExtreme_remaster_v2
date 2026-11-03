namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattenedNode.h")]
[Token(Token = "0x200001E")]
public struct HierarchyFlattenedNode : IEquatable<HierarchyFlattenedNode>
{
	[Token(Token = "0x400003F")]
	private static readonly HierarchyFlattenedNode s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000040")]
	private readonly HierarchyNode m_Node; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000041")]
	private readonly HierarchyNodeType m_Type; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000042")]
	private readonly int m_Version; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000043")]
	private readonly int m_ParentOffset; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000044")]
	private readonly int m_NextSiblingOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000045")]
	private readonly int m_ChildIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000046")]
	private readonly int m_ChildrenCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000047")]
	private readonly int m_Depth; //Field offset: 0x20

	[Token(Token = "0x17000016")]
	public int Depth
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60000AE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public int NextSiblingOffset
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public HierarchyNode Node
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 4
	}

	[IsReadOnly]
	[Token(Token = "0x17000013")]
	public static HierarchyFlattenedNode Null
	{
		[Address(RVA = "0x30D5DF0", Offset = "0x30D51F0", Length = "0x33")]
		[Token(Token = "0x60000AB")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x30D5D70", Offset = "0x30D5170", Length = "0x7C")]
	[Token(Token = "0x60000AF")]
	public HierarchyFlattenedNode() { }

	[Address(RVA = "0x30D5B20", Offset = "0x30D4F20", Length = "0x1E")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B1")]
	public override bool Equals(HierarchyFlattenedNode other) { }

	[Address(RVA = "0x30D5B40", Offset = "0x30D4F40", Length = "0x9F")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60000AE")]
	public int get_Depth() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60000AD")]
	public int get_NextSiblingOffset() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60000AC")]
	public HierarchyNode get_Node() { }

	[Address(RVA = "0x30D5DF0", Offset = "0x30D51F0", Length = "0x33")]
	[Token(Token = "0x60000AB")]
	public static HierarchyFlattenedNode get_Null() { }

	[Address(RVA = "0x30D5BE0", Offset = "0x30D4FE0", Length = "0x62")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60000B5")]
	internal static HierarchyNode GetNodeByRef(in HierarchyFlattenedNode hierarchyFlattenedNode) { }

	[Address(RVA = "0x30D5E30", Offset = "0x30D5230", Length = "0x1E")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B0")]
	public static bool op_Equality(in HierarchyFlattenedNode lhs, in HierarchyFlattenedNode rhs) { }

	[Address(RVA = "0x30D5C50", Offset = "0x30D5050", Length = "0x119")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000B2")]
	public virtual string ToString() { }

}

