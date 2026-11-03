namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000542")]
public struct BindingId : IEquatable<BindingId>
{
	[Token(Token = "0x4001170")]
	public static readonly BindingId Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001171")]
	private readonly PropertyPath m_PropertyPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001172")]
	private readonly string m_Path; //Field offset: 0x90

	[Address(RVA = "0x32B8610", Offset = "0x32B7A10", Length = "0x65")]
	[Token(Token = "0x60026BC")]
	private static BindingId() { }

	[Address(RVA = "0x32B8680", Offset = "0x32B7A80", Length = "0xD9")]
	[Token(Token = "0x60026B0")]
	public BindingId(string path) { }

	[Address(RVA = "0x32B8760", Offset = "0x32B7B60", Length = "0xB3")]
	[Token(Token = "0x60026B1")]
	public BindingId(in PropertyPath path) { }

	[Address(RVA = "0x32B82D0", Offset = "0x32B76D0", Length = "0x119")]
	[Token(Token = "0x60026B7")]
	public override bool Equals(BindingId other) { }

	[Address(RVA = "0x32B83F0", Offset = "0x32B77F0", Length = "0x204")]
	[Token(Token = "0x60026B8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32B8600", Offset = "0x32B7A00", Length = "0x9")]
	[Token(Token = "0x60026B9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32B8820", Offset = "0x32B7C20", Length = "0xCF")]
	[Token(Token = "0x60026BA")]
	public static bool op_Equality(in BindingId lhs, in BindingId rhs) { }

	[Address(RVA = "0x32B89F0", Offset = "0x32B7DF0", Length = "0x50")]
	[Token(Token = "0x60026B2")]
	public static PropertyPath op_Implicit(in BindingId vep) { }

	[Address(RVA = "0x30E9A60", Offset = "0x30E8E60", Length = "0xA")]
	[Token(Token = "0x60026B3")]
	public static string op_Implicit(in BindingId vep) { }

	[Address(RVA = "0x32B8A40", Offset = "0x32B7E40", Length = "0xF7")]
	[Token(Token = "0x60026B4")]
	public static BindingId op_Implicit(string name) { }

	[Address(RVA = "0x32B88F0", Offset = "0x32B7CF0", Length = "0xF7")]
	[Token(Token = "0x60026B5")]
	public static BindingId op_Implicit(in PropertyPath path) { }

	[Address(RVA = "0x32B8B40", Offset = "0x32B7F40", Length = "0x136")]
	[Token(Token = "0x60026BB")]
	public static bool op_Inequality(in BindingId lhs, in BindingId rhs) { }

	[Address(RVA = "0x30E9A60", Offset = "0x30E8E60", Length = "0xA")]
	[Token(Token = "0x60026B6")]
	public virtual string ToString() { }

}

