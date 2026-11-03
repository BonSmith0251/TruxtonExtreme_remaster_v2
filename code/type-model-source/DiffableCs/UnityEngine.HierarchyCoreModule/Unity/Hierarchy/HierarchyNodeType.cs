namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeType.h")]
[Token(Token = "0x2000021")]
public struct HierarchyNodeType : IEquatable<HierarchyNodeType>
{
	[Token(Token = "0x4000051")]
	private static readonly HierarchyNodeType s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	private readonly int m_Id; //Field offset: 0x0

	[Token(Token = "0x1700001B")]
	public int Id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x1700001A")]
	public static HierarchyNodeType Null
	{
		[Address(RVA = "0x30D7C20", Offset = "0x30D7020", Length = "0x33")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x30D7A90", Offset = "0x30D6E90", Length = "0x6")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C3")]
	public override bool Equals(HierarchyNodeType other) { }

	[Address(RVA = "0x30D7AA0", Offset = "0x30D6EA0", Length = "0x84")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60000C1")]
	public int get_Id() { }

	[Address(RVA = "0x30D7C20", Offset = "0x30D7020", Length = "0x33")]
	[Token(Token = "0x60000C0")]
	public static HierarchyNodeType get_Null() { }

	[Address(RVA = "0x30D7B30", Offset = "0x30D6F30", Length = "0x1B")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3046600", Offset = "0x3045A00", Length = "0x8")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C2")]
	public static bool op_Equality(in HierarchyNodeType lhs, in HierarchyNodeType rhs) { }

	[Address(RVA = "0x30D7B50", Offset = "0x30D6F50", Length = "0xC5")]
	[ExcludeFromDocs]
	[Token(Token = "0x60000C4")]
	public virtual string ToString() { }

}

