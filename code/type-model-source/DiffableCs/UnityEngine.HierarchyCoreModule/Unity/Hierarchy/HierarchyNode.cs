namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNode.h")]
[Token(Token = "0x200001F")]
public struct HierarchyNode : IEquatable<HierarchyNode>
{
	[Token(Token = "0x4000048")]
	private static readonly HierarchyNode s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000049")]
	private readonly int m_Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400004A")]
	private readonly int m_Version; //Field offset: 0x4

	[Token(Token = "0x17000018")]
	public int Id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x17000017")]
	public static HierarchyNode Null
	{
		[Address(RVA = "0x30D7EA0", Offset = "0x30D72A0", Length = "0x33")]
		[Token(Token = "0x60000B6")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000019")]
	public int Version
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x30D7E90", Offset = "0x30D7290", Length = "0x6")]
	[Token(Token = "0x60000B9")]
	public HierarchyNode() { }

	[Address(RVA = "0x30D7CF0", Offset = "0x30D70F0", Length = "0x12")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BC")]
	public override bool Equals(HierarchyNode other) { }

	[Address(RVA = "0x30D7C60", Offset = "0x30D7060", Length = "0x8B")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60000B7")]
	public int get_Id() { }

	[Address(RVA = "0x30D7EA0", Offset = "0x30D72A0", Length = "0x33")]
	[Token(Token = "0x60000B6")]
	public static HierarchyNode get_Null() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60000B8")]
	public int get_Version() { }

	[Address(RVA = "0x30D7D10", Offset = "0x30D7110", Length = "0x69")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3074EC0", Offset = "0x30742C0", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BA")]
	public static bool op_Equality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[Address(RVA = "0x30D7EE0", Offset = "0x30D72E0", Length = "0x1A")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BB")]
	public static bool op_Inequality(in HierarchyNode lhs, in HierarchyNode rhs) { }

	[Address(RVA = "0x30D7D80", Offset = "0x30D7180", Length = "0x10D")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000BD")]
	public virtual string ToString() { }

}

