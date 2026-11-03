namespace System.Xml.Serialization;

[Token(Token = "0x2000141")]
public class XmlTypeMapping : XmlMapping
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006CE")]
	private string xmlType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006CF")]
	private string xmlTypeNamespace; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006D0")]
	private TypeData type; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006D1")]
	private XmlTypeMapping baseMap; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006D2")]
	private bool multiReferenceType; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40006D3")]
	private bool includeInSchema; //Field offset: 0x69
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x40006D4")]
	private bool isNullable; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6B")]
	[Token(Token = "0x40006D5")]
	private bool isAny; //Field offset: 0x6B
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006D6")]
	private ArrayList _derivedTypes; //Field offset: 0x70

	[Token(Token = "0x17000395")]
	internal XmlTypeMapping BaseMap
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000E17")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6000E18")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x17000393")]
	internal ArrayList DerivedTypes
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000E15")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000392")]
	internal bool HasXmlTypeNamespace
	{
		[Address(RVA = "0x2594450", Offset = "0x2593850", Length = "0x9")]
		[Token(Token = "0x6000E14")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000396")]
	internal bool IncludeInSchema
	{
		[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
		[Token(Token = "0x6000E19")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000398")]
	internal bool IsAny
	{
		[Address(RVA = "0x2594460", Offset = "0x2593860", Length = "0x5")]
		[Token(Token = "0x6000E1C")]
		internal get { } //Length: 5
		[Address(RVA = "0x25944B0", Offset = "0x25938B0", Length = "0x4")]
		[Token(Token = "0x6000E1D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000397")]
	internal bool IsNullable
	{
		[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
		[Token(Token = "0x6000E1A")]
		internal get { } //Length: 5
		[Address(RVA = "0x24F8F90", Offset = "0x24F8390", Length = "0x4")]
		[Token(Token = "0x6000E1B")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000394")]
	internal bool MultiReferenceType
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6000E16")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700038F")]
	internal TypeData TypeData
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000E0F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700038E")]
	public string TypeFullName
	{
		[Address(RVA = "0x2594470", Offset = "0x2593870", Length = "0x1B")]
		[Token(Token = "0x6000E0E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000390")]
	internal string XmlType
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000E10")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000E11")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000391")]
	internal string XmlTypeNamespace
	{
		[Address(RVA = "0x2594490", Offset = "0x2593890", Length = "0x1B")]
		[Token(Token = "0x6000E12")]
		internal get { } //Length: 27
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6000E13")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2594380", Offset = "0x2593780", Length = "0xCE")]
	[Token(Token = "0x6000E0D")]
	internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000E17")]
	internal XmlTypeMapping get_BaseMap() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000E15")]
	internal ArrayList get_DerivedTypes() { }

	[Address(RVA = "0x2594450", Offset = "0x2593850", Length = "0x9")]
	[Token(Token = "0x6000E14")]
	internal bool get_HasXmlTypeNamespace() { }

	[Address(RVA = "0x2594460", Offset = "0x2593860", Length = "0x5")]
	[Token(Token = "0x6000E1C")]
	internal bool get_IsAny() { }

	[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
	[Token(Token = "0x6000E1A")]
	internal bool get_IsNullable() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6000E16")]
	internal bool get_MultiReferenceType() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000E0F")]
	internal TypeData get_TypeData() { }

	[Address(RVA = "0x2594470", Offset = "0x2593870", Length = "0x1B")]
	[Token(Token = "0x6000E0E")]
	public string get_TypeFullName() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000E10")]
	internal string get_XmlType() { }

	[Address(RVA = "0x2594490", Offset = "0x2593890", Length = "0x1B")]
	[Token(Token = "0x6000E12")]
	internal string get_XmlTypeNamespace() { }

	[Address(RVA = "0x2593F30", Offset = "0x2593330", Length = "0x22D")]
	[Token(Token = "0x6000E1F")]
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	[Address(RVA = "0x2594160", Offset = "0x2593560", Length = "0x186")]
	[Token(Token = "0x6000E1E")]
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6000E18")]
	internal void set_BaseMap(XmlTypeMapping value) { }

	[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
	[Token(Token = "0x6000E19")]
	internal void set_IncludeInSchema(bool value) { }

	[Address(RVA = "0x25944B0", Offset = "0x25938B0", Length = "0x4")]
	[Token(Token = "0x6000E1D")]
	internal void set_IsAny(bool value) { }

	[Address(RVA = "0x24F8F90", Offset = "0x24F8390", Length = "0x4")]
	[Token(Token = "0x6000E1B")]
	internal void set_IsNullable(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000E11")]
	internal void set_XmlType(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6000E13")]
	internal void set_XmlTypeNamespace(string value) { }

	[Address(RVA = "0x25942F0", Offset = "0x25936F0", Length = "0x89")]
	[Token(Token = "0x6000E20")]
	internal void UpdateRoot(XmlQualifiedName qname) { }

}

