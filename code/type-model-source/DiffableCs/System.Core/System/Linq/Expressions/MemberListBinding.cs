namespace System.Linq.Expressions;

[Token(Token = "0x20000A2")]
public sealed class MemberListBinding : MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400019C")]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000C4")]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600045F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600045F")]
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

}

