namespace UnityEngine.Timeline;

[Token(Token = "0x2000051")]
internal struct ObjectId : IEquatable<ObjectId>, IComparable<ObjectId>
{
	[Token(Token = "0x4000135")]
	public static readonly ObjectId InvalidId; //Field offset: 0x0
	[Token(Token = "0x4000136")]
	public static readonly ObjectId DefaultId; //Field offset: 0x4
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000137")]
	private int m_Data; //Field offset: 0x0

	[Address(RVA = "0x2F2FFF0", Offset = "0x2F2F3F0", Length = "0x4E")]
	[Token(Token = "0x60002CD")]
	private static ObjectId() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x60002C0")]
	internal ObjectId(int data) { }

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x60002C5")]
	public override int CompareTo(ObjectId other) { }

	[Address(RVA = "0x2F2FF50", Offset = "0x2F2F350", Length = "0x94")]
	[Token(Token = "0x60002C3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x60002C4")]
	public override bool Equals(ObjectId other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60002CC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2F30040", Offset = "0x2F2F440", Length = "0x4F")]
	[Token(Token = "0x60002C6")]
	public static bool op_Equality(ObjectId left, ObjectId right) { }

	[Address(RVA = "0x2F300A0", Offset = "0x2F2F4A0", Length = "0x6")]
	[Token(Token = "0x60002C9")]
	public static bool op_GreaterThan(ObjectId left, ObjectId right) { }

	[Address(RVA = "0x2F30090", Offset = "0x2F2F490", Length = "0x6")]
	[Token(Token = "0x60002CB")]
	public static bool op_GreaterThanOrEqual(ObjectId left, ObjectId right) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x60002C1")]
	public static ObjectId op_Implicit(EntityId entityId) { }

	[Address(RVA = "0x2F300B0", Offset = "0x2F2F4B0", Length = "0x7")]
	[Token(Token = "0x60002C2")]
	public static EntityId op_Implicit(ObjectId objectId) { }

	[Address(RVA = "0x2F300C0", Offset = "0x2F2F4C0", Length = "0x4F")]
	[Token(Token = "0x60002C7")]
	public static bool op_Inequality(ObjectId left, ObjectId right) { }

	[Address(RVA = "0x2F30120", Offset = "0x2F2F520", Length = "0x6")]
	[Token(Token = "0x60002C8")]
	public static bool op_LessThan(ObjectId left, ObjectId right) { }

	[Address(RVA = "0x2F30110", Offset = "0x2F2F510", Length = "0x6")]
	[Token(Token = "0x60002CA")]
	public static bool op_LessThanOrEqual(ObjectId left, ObjectId right) { }

}

