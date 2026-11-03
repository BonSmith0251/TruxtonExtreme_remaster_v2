namespace Unity.Cinemachine;

[Nullable(0)]
[NullableContext(2)]
[Token(Token = "0x200017C")]
internal class Joiner
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000654")]
	public int idx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Nullable(1)]
	[Token(Token = "0x4000655")]
	public OutPt op1; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000656")]
	public OutPt op2; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000657")]
	public Joiner next1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000658")]
	public Joiner next2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000659")]
	public Joiner nextH; //Field offset: 0x38

	[Address(RVA = "0x289C400", Offset = "0x289B800", Length = "0x16B")]
	[Token(Token = "0x600076B")]
	public Joiner(List<Joiner> joinerList, OutPt op1, OutPt op2, Joiner nextH) { }

}

