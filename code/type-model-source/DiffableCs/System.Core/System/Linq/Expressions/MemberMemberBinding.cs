namespace System.Linq.Expressions;

[Token(Token = "0x20000A3")]
public sealed class MemberMemberBinding : MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400019D")]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000C5")]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000460")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000460")]
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

}

