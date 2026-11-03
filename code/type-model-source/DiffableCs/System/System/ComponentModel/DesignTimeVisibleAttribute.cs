namespace System.ComponentModel;

[AttributeUsage(1028)]
[Token(Token = "0x2000170")]
public sealed class DesignTimeVisibleAttribute : Attribute
{
	[Token(Token = "0x400061B")]
	public static readonly DesignTimeVisibleAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x400061C")]
	public static readonly DesignTimeVisibleAttribute No; //Field offset: 0x8
	[Token(Token = "0x400061D")]
	public static readonly DesignTimeVisibleAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061A")]
	private readonly bool <Visible>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001A5")]
	public bool Visible
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008DA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x265F8B0", Offset = "0x265ECB0", Length = "0xE0")]
	[Token(Token = "0x60008DE")]
	private static DesignTimeVisibleAttribute() { }

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x60008D9")]
	public DesignTimeVisibleAttribute(bool visible) { }

	[Address(RVA = "0x265F730", Offset = "0x265EB30", Length = "0x7A")]
	[Token(Token = "0x60008DB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008DA")]
	public bool get_Visible() { }

	[Address(RVA = "0x265F7B0", Offset = "0x265EBB0", Length = "0x87")]
	[Token(Token = "0x60008DC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x265F840", Offset = "0x265EC40", Length = "0x69")]
	[Token(Token = "0x60008DD")]
	public virtual bool IsDefaultAttribute() { }

}

