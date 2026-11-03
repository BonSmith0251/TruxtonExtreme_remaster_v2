namespace System.Xml.Schema;

[Token(Token = "0x2000154")]
internal class CompiledIdentityConstraint
{
	[Token(Token = "0x2000155")]
	internal enum ConstraintRole : int
	{
		Unique = 0,
		Key = 1,
		Keyref = 2,
	}

	[Token(Token = "0x4000730")]
	public static readonly CompiledIdentityConstraint Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072B")]
	internal XmlQualifiedName name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072C")]
	private ConstraintRole role; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072D")]
	private Asttree selector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072E")]
	private Asttree[] fields; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400072F")]
	internal XmlQualifiedName refer; //Field offset: 0x30

	[Token(Token = "0x170003D3")]
	public Asttree[] Fields
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000EC9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003D1")]
	public ConstraintRole Role
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000EC7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003D2")]
	public Asttree Selector
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000EC8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2581290", Offset = "0x2580690", Length = "0xD9")]
	[Token(Token = "0x6000ECC")]
	private static CompiledIdentityConstraint() { }

	[Address(RVA = "0x2581370", Offset = "0x2580770", Length = "0x8A")]
	[Token(Token = "0x6000ECA")]
	private CompiledIdentityConstraint() { }

	[Address(RVA = "0x2581400", Offset = "0x2580800", Length = "0x4A2")]
	[Token(Token = "0x6000ECB")]
	public CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000EC9")]
	public Asttree[] get_Fields() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000EC7")]
	public ConstraintRole get_Role() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000EC8")]
	public Asttree get_Selector() { }

}

