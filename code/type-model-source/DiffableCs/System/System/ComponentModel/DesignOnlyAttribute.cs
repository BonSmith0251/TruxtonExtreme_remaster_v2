namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200014B")]
public sealed class DesignOnlyAttribute : Attribute
{
	[Token(Token = "0x40005DD")]
	public static readonly DesignOnlyAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x40005DE")]
	public static readonly DesignOnlyAttribute No; //Field offset: 0x8
	[Token(Token = "0x40005DF")]
	public static readonly DesignOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005DC")]
	private readonly bool <IsDesignOnly>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000182")]
	public bool IsDesignOnly
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600082F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2647F20", Offset = "0x2647320", Length = "0xE1")]
	[Token(Token = "0x6000833")]
	private static DesignOnlyAttribute() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x600082E")]
	public DesignOnlyAttribute(bool isDesignOnly) { }

	[Address(RVA = "0x2647DF0", Offset = "0x26471F0", Length = "0xB7")]
	[Token(Token = "0x6000830")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600082F")]
	public bool get_IsDesignOnly() { }

	[Address(RVA = "0x2642600", Offset = "0x2641A00", Length = "0x32")]
	[Token(Token = "0x6000831")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2647EB0", Offset = "0x26472B0", Length = "0x69")]
	[Token(Token = "0x6000832")]
	public virtual bool IsDefaultAttribute() { }

}

