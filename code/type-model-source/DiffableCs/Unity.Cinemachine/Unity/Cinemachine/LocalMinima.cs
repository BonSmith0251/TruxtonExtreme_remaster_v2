namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000177")]
internal struct LocalMinima
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400063F")]
	public readonly Vertex vertex; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000640")]
	public readonly PathType polytype; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000641")]
	public readonly bool isOpen; //Field offset: 0xC

	[Address(RVA = "0x289C660", Offset = "0x289BA60", Length = "0x38")]
	[Token(Token = "0x6000762")]
	public LocalMinima(Vertex vertex, PathType polytype, bool isOpen = false) { }

	[Address(RVA = "0x289C5A0", Offset = "0x289B9A0", Length = "0x81")]
	[Token(Token = "0x6000765")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x289C630", Offset = "0x289BA30", Length = "0x29")]
	[Token(Token = "0x6000766")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x289C6A0", Offset = "0x289BAA0", Length = "0xA")]
	[Token(Token = "0x6000763")]
	public static bool op_Equality(LocalMinima lm1, LocalMinima lm2) { }

	[Address(RVA = "0x289C6B0", Offset = "0x289BAB0", Length = "0xA")]
	[Token(Token = "0x6000764")]
	public static bool op_Inequality(LocalMinima lm1, LocalMinima lm2) { }

}

