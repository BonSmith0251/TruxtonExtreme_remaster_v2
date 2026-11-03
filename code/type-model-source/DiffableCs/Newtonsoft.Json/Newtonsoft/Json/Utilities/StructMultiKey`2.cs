namespace Newtonsoft.Json.Utilities;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000F3")]
internal struct StructMultiKey : IEquatable<StructMultiKey`2<T1, T2>>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D6")]
	public readonly T1 Value1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D7")]
	public readonly T2 Value2; //Field offset: 0x0

	[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
	[Token(Token = "0x600071A")]
	public StructMultiKey`2(T1 v1, T2 v2) { }

	[Address(RVA = "0xFCFE10", Offset = "0xFCF210", Length = "0x121")]
	[NullableContext(2)]
	[Token(Token = "0x600071C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xFCF8A0", Offset = "0xFCECA0", Length = "0x47")]
	[Token(Token = "0x600071D")]
	public override bool Equals(StructMultiKey<T1, T2> other) { }

	[Address(RVA = "0xFCFF40", Offset = "0xFCF340", Length = "0x67")]
	[Token(Token = "0x600071B")]
	public virtual int GetHashCode() { }

}

