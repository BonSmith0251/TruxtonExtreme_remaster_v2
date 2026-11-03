namespace UnityEngine.UIElements;

[Token(Token = "0x20003FC")]
internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D65")]
	public Rotate rotate; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D66")]
	public Scale scale; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D67")]
	public TransformOrigin transformOrigin; //Field offset: 0x28
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D68")]
	public Translate translate; //Field offset: 0x3C

	[Address(RVA = "0x327E550", Offset = "0x327D950", Length = "0x30")]
	[Token(Token = "0x6001E47")]
	public override TransformData Copy() { }

	[Address(RVA = "0x327E520", Offset = "0x327D920", Length = "0x2D")]
	[Token(Token = "0x6001E48")]
	public override void CopyFrom(ref TransformData other) { }

	[Address(RVA = "0x327E580", Offset = "0x327D980", Length = "0x288")]
	[Token(Token = "0x6001E4A")]
	public override bool Equals(TransformData other) { }

	[Address(RVA = "0x327E810", Offset = "0x327DC10", Length = "0xCA")]
	[Token(Token = "0x6001E4B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x327E8E0", Offset = "0x327DCE0", Length = "0x138")]
	[Token(Token = "0x6001E4C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327EA20", Offset = "0x327DE20", Length = "0x2A5")]
	[Token(Token = "0x6001E49")]
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

}

