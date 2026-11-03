namespace System.Xml.Linq;

[Token(Token = "0x200000E")]
public class XDocumentType : XNode
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000017")]
	private string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000018")]
	private string _publicId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000019")]
	private string _systemId; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001A")]
	private string _internalSubset; //Field offset: 0x40

	[Token(Token = "0x17000011")]
	public string InternalSubset
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600005A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000012")]
	public string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000013")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x600005C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000014")]
	public string PublicId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000015")]
	public string SystemId
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x240AA90", Offset = "0x2409E90", Length = "0xBB")]
	[Token(Token = "0x6000058")]
	public XDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[Address(RVA = "0x240A9D0", Offset = "0x2409DD0", Length = "0xB2")]
	[Token(Token = "0x6000059")]
	public XDocumentType(XDocumentType other) { }

	[Address(RVA = "0x240A840", Offset = "0x2409C40", Length = "0xE1")]
	[Token(Token = "0x6000060")]
	internal virtual XNode CloneNode() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600005A")]
	public string get_InternalSubset() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600005B")]
	public string get_Name() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x600005C")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600005D")]
	public string get_PublicId() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600005E")]
	public string get_SystemId() { }

	[Address(RVA = "0x240A930", Offset = "0x2409D30", Length = "0x94")]
	[Token(Token = "0x600005F")]
	public virtual void WriteTo(XmlWriter writer) { }

}

