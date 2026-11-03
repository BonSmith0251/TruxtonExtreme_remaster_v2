namespace UnityEngine;

[NativeClass("EntityId")]
[Token(Token = "0x20001CF")]
[UsedByNativeCode]
public struct EntityId : IEquatable<EntityId>, IComparable<EntityId>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40006AC")]
	private int m_Data; //Field offset: 0x0

	[Token(Token = "0x170002F8")]
	public static EntityId None
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600142B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x60B4B0", Offset = "0x60A8B0", Length = "0x8")]
	[Token(Token = "0x600142E")]
	public override int CompareTo(EntityId other) { }

	[Address(RVA = "0x305EAE0", Offset = "0x305DEE0", Length = "0x81")]
	[Token(Token = "0x600142C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x6041D0", Offset = "0x6035D0", Length = "0x6")]
	[Token(Token = "0x600142D")]
	public override bool Equals(EntityId other) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600142B")]
	public static EntityId get_None() { }

	[Address(RVA = "0x305EB70", Offset = "0x305DF70", Length = "0x41")]
	[Token(Token = "0x6001431")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
	[Token(Token = "0x600142F")]
	public static bool op_Equality(EntityId left, EntityId right) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6001432")]
	public static int op_Implicit(EntityId entityId) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x6001433")]
	public static EntityId op_Implicit(int intValue) { }

	[Address(RVA = "0x639780", Offset = "0x638B80", Length = "0x6")]
	[Token(Token = "0x6001430")]
	public static bool op_Inequality(EntityId left, EntityId right) { }

	[Address(RVA = "0x60B560", Offset = "0x60A960", Length = "0x7")]
	[Token(Token = "0x6001434")]
	public virtual string ToString() { }

}

