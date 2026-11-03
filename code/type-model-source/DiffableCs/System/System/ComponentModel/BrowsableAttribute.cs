namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000148")]
public sealed class BrowsableAttribute : Attribute
{
	[Token(Token = "0x40005D6")]
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x40005D7")]
	public static readonly BrowsableAttribute No; //Field offset: 0x8
	[Token(Token = "0x40005D8")]
	public static readonly BrowsableAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D9")]
	private readonly bool <Browsable>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700017E")]
	public bool Browsable
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x26426B0", Offset = "0x2641AB0", Length = "0xE0")]
	[Token(Token = "0x6000823")]
	private static BrowsableAttribute() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x600081E")]
	public BrowsableAttribute(bool browsable) { }

	[Address(RVA = "0x2642540", Offset = "0x2641940", Length = "0xB7")]
	[Token(Token = "0x6000820")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081F")]
	public bool get_Browsable() { }

	[Address(RVA = "0x2642600", Offset = "0x2641A00", Length = "0x32")]
	[Token(Token = "0x6000821")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2642640", Offset = "0x2641A40", Length = "0x6B")]
	[Token(Token = "0x6000822")]
	public virtual bool IsDefaultAttribute() { }

}

