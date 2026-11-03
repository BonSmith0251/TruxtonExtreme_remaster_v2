namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = True)]
[Token(Token = "0x200014C")]
public sealed class DesignerCategoryAttribute : Attribute
{
	[Token(Token = "0x40005E0")]
	public static readonly DesignerCategoryAttribute Component; //Field offset: 0x0
	[Token(Token = "0x40005E1")]
	public static readonly DesignerCategoryAttribute Default; //Field offset: 0x8
	[Token(Token = "0x40005E2")]
	public static readonly DesignerCategoryAttribute Form; //Field offset: 0x10
	[Token(Token = "0x40005E3")]
	public static readonly DesignerCategoryAttribute Generic; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E4")]
	private readonly string <Category>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000183")]
	public string Category
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000836")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000184")]
	public virtual object TypeId
	{
		[Address(RVA = "0x2648320", Offset = "0x2647720", Length = "0x45")]
		[Token(Token = "0x600083A")]
		 get { } //Length: 69
	}

	[Address(RVA = "0x2648110", Offset = "0x2647510", Length = "0x1C6")]
	[Token(Token = "0x600083B")]
	private static DesignerCategoryAttribute() { }

	[Address(RVA = "0x26482E0", Offset = "0x26476E0", Length = "0x33")]
	[Token(Token = "0x6000834")]
	public DesignerCategoryAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000835")]
	public DesignerCategoryAttribute(string category) { }

	[Address(RVA = "0x2648010", Offset = "0x2647410", Length = "0x7F")]
	[Token(Token = "0x6000837")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000836")]
	public string get_Category() { }

	[Address(RVA = "0x2648320", Offset = "0x2647720", Length = "0x45")]
	[Token(Token = "0x600083A")]
	public virtual object get_TypeId() { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6000838")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2648090", Offset = "0x2647490", Length = "0x76")]
	[Token(Token = "0x6000839")]
	public virtual bool IsDefaultAttribute() { }

}

