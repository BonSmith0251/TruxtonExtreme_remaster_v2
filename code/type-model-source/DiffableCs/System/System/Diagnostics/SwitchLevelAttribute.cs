namespace System.Diagnostics;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x20000FB")]
public sealed class SwitchLevelAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400045B")]
	private Type type; //Field offset: 0x10

	[Token(Token = "0x170000E7")]
	public Type SwitchLevelType
	{
		[Address(RVA = "0x263D660", Offset = "0x263CA60", Length = "0x98")]
		[Token(Token = "0x600061F")]
		 set { } //Length: 152
	}

	[Address(RVA = "0x263D5C0", Offset = "0x263C9C0", Length = "0x9F")]
	[Token(Token = "0x600061E")]
	public SwitchLevelAttribute(Type switchLevelType) { }

	[Address(RVA = "0x263D660", Offset = "0x263CA60", Length = "0x98")]
	[Token(Token = "0x600061F")]
	public void set_SwitchLevelType(Type value) { }

}

