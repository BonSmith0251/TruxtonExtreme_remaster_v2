namespace Unity.Hierarchy;

[IsReadOnly]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyPropertyId.h")]
[Token(Token = "0x2000023")]
internal struct HierarchyPropertyId : IEquatable<HierarchyPropertyId>
{
	[Token(Token = "0x4000055")]
	private static readonly HierarchyPropertyId s_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000056")]
	private readonly int m_Id; //Field offset: 0x0

	[Token(Token = "0x1700001F")]
	public int Id
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 3
	}

	[IsReadOnly]
	[Token(Token = "0x1700001E")]
	public static HierarchyPropertyId Null
	{
		[Address(RVA = "0x30D8060", Offset = "0x30D7460", Length = "0x33")]
		[Token(Token = "0x60000C9")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x60000CB")]
	public HierarchyPropertyId() { }

	[Address(RVA = "0x30D7A90", Offset = "0x30D6E90", Length = "0x6")]
	[Token(Token = "0x60000CD")]
	public override bool Equals(HierarchyPropertyId other) { }

	[Address(RVA = "0x30D7F00", Offset = "0x30D7300", Length = "0x84")]
	[Token(Token = "0x60000CF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60000CA")]
	public int get_Id() { }

	[Address(RVA = "0x30D8060", Offset = "0x30D7460", Length = "0x33")]
	[Token(Token = "0x60000C9")]
	public static HierarchyPropertyId get_Null() { }

	[Address(RVA = "0x30D7B30", Offset = "0x30D6F30", Length = "0x1B")]
	[Token(Token = "0x60000D0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3046600", Offset = "0x3045A00", Length = "0x8")]
	[Token(Token = "0x60000CC")]
	public static bool op_Equality(in HierarchyPropertyId lhs, in HierarchyPropertyId rhs) { }

	[Address(RVA = "0x30D7F90", Offset = "0x30D7390", Length = "0xC5")]
	[Token(Token = "0x60000CE")]
	public virtual string ToString() { }

}

