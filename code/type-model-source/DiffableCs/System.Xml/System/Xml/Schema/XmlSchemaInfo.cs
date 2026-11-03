namespace System.Xml.Schema;

[Token(Token = "0x200022E")]
public class XmlSchemaInfo : IXmlSchemaInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B93")]
	private bool isDefault; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000B94")]
	private bool isNil; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B95")]
	private XmlSchemaElement schemaElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B96")]
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B97")]
	private XmlSchemaType schemaType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B98")]
	private XmlSchemaSimpleType memberType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B99")]
	private XmlSchemaValidity validity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B9A")]
	private XmlSchemaContentType contentType; //Field offset: 0x3C

	[Token(Token = "0x1700060C")]
	public XmlSchemaContentType ContentType
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60015E1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700060E")]
	internal bool HasDefaultValue
	{
		[Address(RVA = "0x248F150", Offset = "0x248E550", Length = "0x34")]
		[Token(Token = "0x60015E3")]
		internal get { } //Length: 52
	}

	[Token(Token = "0x17000606")]
	public override bool IsDefault
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60015D5")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x60015D6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000607")]
	public override bool IsNil
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x60015D7")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[Token(Token = "0x60015D8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700060F")]
	internal bool IsUnionType
	{
		[Address(RVA = "0x248F190", Offset = "0x248E590", Length = "0x3F")]
		[Token(Token = "0x60015E4")]
		internal get { } //Length: 63
	}

	[Token(Token = "0x17000608")]
	public override XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60015D9")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60015DA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700060B")]
	public override XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60015DF")]
		 get { } //Length: 5
		[Address(RVA = "0x248F1F0", Offset = "0x248E5F0", Length = "0x40")]
		[Token(Token = "0x60015E0")]
		 set { } //Length: 64
	}

	[Token(Token = "0x1700060A")]
	public override XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60015DD")]
		 get { } //Length: 5
		[Address(RVA = "0x248F230", Offset = "0x248E630", Length = "0x40")]
		[Token(Token = "0x60015DE")]
		 set { } //Length: 64
	}

	[Token(Token = "0x17000609")]
	public override XmlSchemaType SchemaType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60015DB")]
		 get { } //Length: 5
		[Address(RVA = "0x248F270", Offset = "0x248E670", Length = "0x47")]
		[Token(Token = "0x60015DC")]
		 set { } //Length: 71
	}

	[Token(Token = "0x17000605")]
	public override XmlSchemaValidity Validity
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60015D3")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x60015D4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700060D")]
	internal XmlSchemaType XmlType
	{
		[Address(RVA = "0x248F1D0", Offset = "0x248E5D0", Length = "0x11")]
		[Token(Token = "0x60015E2")]
		internal get { } //Length: 17
	}

	[Address(RVA = "0x248F0E0", Offset = "0x248E4E0", Length = "0x6D")]
	[Token(Token = "0x60015D1")]
	public XmlSchemaInfo() { }

	[Address(RVA = "0x248F060", Offset = "0x248E460", Length = "0x79")]
	[Token(Token = "0x60015D2")]
	internal XmlSchemaInfo(XmlSchemaValidity validity) { }

	[Address(RVA = "0x248EFF0", Offset = "0x248E3F0", Length = "0x66")]
	[Token(Token = "0x60015E5")]
	internal void Clear() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60015E1")]
	public XmlSchemaContentType get_ContentType() { }

	[Address(RVA = "0x248F150", Offset = "0x248E550", Length = "0x34")]
	[Token(Token = "0x60015E3")]
	internal bool get_HasDefaultValue() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60015D5")]
	public override bool get_IsDefault() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x60015D7")]
	public override bool get_IsNil() { }

	[Address(RVA = "0x248F190", Offset = "0x248E590", Length = "0x3F")]
	[Token(Token = "0x60015E4")]
	internal bool get_IsUnionType() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60015D9")]
	public override XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60015DF")]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60015DD")]
	public override XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60015DB")]
	public override XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60015D3")]
	public override XmlSchemaValidity get_Validity() { }

	[Address(RVA = "0x248F1D0", Offset = "0x248E5D0", Length = "0x11")]
	[Token(Token = "0x60015E2")]
	internal XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x60015D6")]
	public void set_IsDefault(bool value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[Token(Token = "0x60015D8")]
	public void set_IsNil(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60015DA")]
	public void set_MemberType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x248F1F0", Offset = "0x248E5F0", Length = "0x40")]
	[Token(Token = "0x60015E0")]
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	[Address(RVA = "0x248F230", Offset = "0x248E630", Length = "0x40")]
	[Token(Token = "0x60015DE")]
	public void set_SchemaElement(XmlSchemaElement value) { }

	[Address(RVA = "0x248F270", Offset = "0x248E670", Length = "0x47")]
	[Token(Token = "0x60015DC")]
	public void set_SchemaType(XmlSchemaType value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60015D4")]
	public void set_Validity(XmlSchemaValidity value) { }

}

