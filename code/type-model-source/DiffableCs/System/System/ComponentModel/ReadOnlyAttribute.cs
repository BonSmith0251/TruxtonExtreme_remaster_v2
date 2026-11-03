namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000156")]
public sealed class ReadOnlyAttribute : Attribute
{
	[Token(Token = "0x40005F5")]
	public static readonly ReadOnlyAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x40005F6")]
	public static readonly ReadOnlyAttribute No; //Field offset: 0x8
	[Token(Token = "0x40005F7")]
	public static readonly ReadOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F8")]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700018E")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000859")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2649820", Offset = "0x2648C20", Length = "0xE1")]
	[Token(Token = "0x600085D")]
	private static ReadOnlyAttribute() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x6000858")]
	public ReadOnlyAttribute(bool isReadOnly) { }

	[Address(RVA = "0x26496F0", Offset = "0x2648AF0", Length = "0xB7")]
	[Token(Token = "0x600085A")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000859")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x600085B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26497B0", Offset = "0x2648BB0", Length = "0x69")]
	[Token(Token = "0x600085C")]
	public virtual bool IsDefaultAttribute() { }

}

