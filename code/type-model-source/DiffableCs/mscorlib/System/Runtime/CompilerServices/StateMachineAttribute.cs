namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200048C")]
public class StateMachineAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400125B")]
	private readonly Type <StateMachineType>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000405")]
	public Type StateMachineType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60020F5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x60020F4")]
	public StateMachineAttribute(Type stateMachineType) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60020F5")]
	public Type get_StateMachineType() { }

}

