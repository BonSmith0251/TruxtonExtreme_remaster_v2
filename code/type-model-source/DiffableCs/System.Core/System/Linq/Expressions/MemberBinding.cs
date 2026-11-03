namespace System.Linq.Expressions;

[Token(Token = "0x200009D")]
public abstract class MemberBinding
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000195")]
	private readonly MemberBindingType <BindingType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000196")]
	private readonly MemberInfo <Member>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000BB")]
	public MemberBindingType BindingType
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600044C")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000BC")]
	public MemberInfo Member
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600044D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600044C")]
	public MemberBindingType get_BindingType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600044D")]
	public MemberInfo get_Member() { }

}

