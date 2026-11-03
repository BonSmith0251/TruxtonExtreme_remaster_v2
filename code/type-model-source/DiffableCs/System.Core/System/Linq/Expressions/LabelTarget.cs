namespace System.Linq.Expressions;

[Token(Token = "0x200008F")]
public sealed class LabelTarget
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400017F")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000180")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700009C")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000410")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700009D")]
	public Type Type
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000411")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1EE5030", Offset = "0x1EE4430", Length = "0x4E")]
	[Token(Token = "0x600040F")]
	internal LabelTarget(Type type, string name) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000410")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000411")]
	public Type get_Type() { }

	[Address(RVA = "0x2265E20", Offset = "0x2265220", Length = "0x45")]
	[Token(Token = "0x6000412")]
	public virtual string ToString() { }

}

