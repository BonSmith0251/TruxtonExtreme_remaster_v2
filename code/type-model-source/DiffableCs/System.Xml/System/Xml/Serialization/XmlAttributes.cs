namespace System.Xml.Serialization;

[Token(Token = "0x200010C")]
public class XmlAttributes
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061D")]
	private XmlAnyAttributeAttribute xmlAnyAttribute; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400061E")]
	private XmlAnyElementAttributes xmlAnyElements; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400061F")]
	private XmlArrayAttribute xmlArray; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000620")]
	private XmlArrayItemAttributes xmlArrayItems; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000621")]
	private XmlAttributeAttribute xmlAttribute; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000622")]
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000623")]
	private object xmlDefaultValue; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000624")]
	private XmlElementAttributes xmlElements; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000625")]
	private XmlEnumAttribute xmlEnum; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000626")]
	private bool xmlIgnore; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000627")]
	private bool xmlns; //Field offset: 0x59
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000628")]
	private XmlRootAttribute xmlRoot; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000629")]
	private XmlTextAttribute xmlText; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400062A")]
	private XmlTypeAttribute xmlType; //Field offset: 0x70

	[Token(Token = "0x17000336")]
	internal Nullable<Int32> Order
	{
		[Address(RVA = "0x25608D0", Offset = "0x255FCD0", Length = "0xB0")]
		[Token(Token = "0x6000C6D")]
		internal get { } //Length: 176
	}

	[Token(Token = "0x17000337")]
	internal int SortableOrder
	{
		[Address(RVA = "0x2560990", Offset = "0x255FD90", Length = "0x7E")]
		[Token(Token = "0x6000C6E")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x17000329")]
	public XmlAnyAttributeAttribute XmlAnyAttribute
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C5F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032A")]
	public XmlAnyElementAttributes XmlAnyElements
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C60")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032B")]
	public XmlArrayAttribute XmlArray
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C61")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032C")]
	public XmlArrayItemAttributes XmlArrayItems
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C62")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032D")]
	public XmlAttributeAttribute XmlAttribute
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C63")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032E")]
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C64")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700032F")]
	public object XmlDefaultValue
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000C65")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000330")]
	public XmlElementAttributes XmlElements
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000C66")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000331")]
	public bool XmlIgnore
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x6000C67")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000332")]
	public bool Xmlns
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x6000C68")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000333")]
	public XmlRootAttribute XmlRoot
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000C69")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000334")]
	public XmlTextAttribute XmlText
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000C6A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000335")]
	public XmlTypeAttribute XmlType
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000C6B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x255FB70", Offset = "0x255EF70", Length = "0x112")]
	[Token(Token = "0x6000C5D")]
	public XmlAttributes() { }

	[Address(RVA = "0x255FC90", Offset = "0x255F090", Length = "0xC37")]
	[Token(Token = "0x6000C5E")]
	public XmlAttributes(ICustomAttributeProvider provider) { }

	[Address(RVA = "0x255F5D0", Offset = "0x255E9D0", Length = "0x593")]
	[Token(Token = "0x6000C6C")]
	internal void AddKeyHash(StringBuilder sb) { }

	[Address(RVA = "0x25608D0", Offset = "0x255FCD0", Length = "0xB0")]
	[Token(Token = "0x6000C6D")]
	internal Nullable<Int32> get_Order() { }

	[Address(RVA = "0x2560990", Offset = "0x255FD90", Length = "0x7E")]
	[Token(Token = "0x6000C6E")]
	internal int get_SortableOrder() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C5F")]
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C60")]
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C61")]
	public XmlArrayAttribute get_XmlArray() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C62")]
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C63")]
	public XmlAttributeAttribute get_XmlAttribute() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C64")]
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000C65")]
	public object get_XmlDefaultValue() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000C66")]
	public XmlElementAttributes get_XmlElements() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x6000C67")]
	public bool get_XmlIgnore() { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x6000C68")]
	public bool get_Xmlns() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000C69")]
	public XmlRootAttribute get_XmlRoot() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000C6A")]
	public XmlTextAttribute get_XmlText() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000C6B")]
	public XmlTypeAttribute get_XmlType() { }

}

