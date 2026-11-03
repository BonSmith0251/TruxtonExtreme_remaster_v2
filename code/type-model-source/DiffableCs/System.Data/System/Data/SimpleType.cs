namespace System.Data;

[Token(Token = "0x200008F")]
internal sealed class SimpleType : ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002BD")]
	private string _baseType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002BE")]
	private SimpleType _baseSimpleType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002BF")]
	private XmlQualifiedName _xmlBaseType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002C0")]
	private string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002C1")]
	private int _length; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002C2")]
	private int _minLength; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002C3")]
	private int _maxLength; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002C4")]
	private string _pattern; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002C5")]
	private string _ns; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002C6")]
	private string _maxExclusive; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002C7")]
	private string _maxInclusive; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002C8")]
	private string _minExclusive; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002C9")]
	private string _minInclusive; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002CA")]
	internal string _enumeration; //Field offset: 0x70

	[Token(Token = "0x1700011E")]
	internal SimpleType BaseSimpleType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000745")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000118")]
	internal string BaseType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600073E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011C")]
	internal int Length
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000742")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700011D")]
	internal int MaxLength
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000743")]
		internal get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6000744")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700011A")]
	internal string Name
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000740")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011B")]
	internal string Namespace
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000741")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011F")]
	public string SimpleTypeQualifiedName
	{
		[Address(RVA = "0x234E920", Offset = "0x234DD20", Length = "0x5E")]
		[Token(Token = "0x6000746")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000119")]
	internal XmlQualifiedName XmlBaseType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600073F")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x234E600", Offset = "0x234DA00", Length = "0x133")]
	[Token(Token = "0x6000739")]
	internal SimpleType(string baseType) { }

	[Address(RVA = "0x234E740", Offset = "0x234DB40", Length = "0x1DE")]
	[Token(Token = "0x600073A")]
	internal SimpleType(XmlSchemaSimpleType node) { }

	[Address(RVA = "0x234D200", Offset = "0x234C600", Length = "0x6D")]
	[Token(Token = "0x600074E")]
	internal bool CanHaveMaxLength() { }

	[Address(RVA = "0x234D270", Offset = "0x234C670", Length = "0xA5")]
	[Token(Token = "0x600074F")]
	internal void ConvertToAnnonymousSimpleType() { }

	[Address(RVA = "0x234D320", Offset = "0x234C720", Length = "0x58")]
	[Token(Token = "0x600074A")]
	internal static SimpleType CreateByteArrayType(string encoding) { }

	[Address(RVA = "0x234D380", Offset = "0x234C780", Length = "0x7E")]
	[Token(Token = "0x6000749")]
	internal static SimpleType CreateEnumeratedType(string values) { }

	[Address(RVA = "0x234D400", Offset = "0x234C800", Length = "0x70")]
	[Token(Token = "0x600074B")]
	internal static SimpleType CreateLimitedStringType(int length) { }

	[Address(RVA = "0x234D480", Offset = "0x234C880", Length = "0xC2")]
	[Token(Token = "0x600074C")]
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000745")]
	internal SimpleType get_BaseSimpleType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600073E")]
	internal string get_BaseType() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000742")]
	internal int get_Length() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000743")]
	internal int get_MaxLength() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000740")]
	internal string get_Name() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000741")]
	internal string get_Namespace() { }

	[Address(RVA = "0x234E920", Offset = "0x234DD20", Length = "0x5E")]
	[Token(Token = "0x6000746")]
	public string get_SimpleTypeQualifiedName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600073F")]
	internal XmlQualifiedName get_XmlBaseType() { }

	[Address(RVA = "0x234D550", Offset = "0x234C950", Length = "0x111")]
	[Token(Token = "0x600074D")]
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	[Address(RVA = "0x234D670", Offset = "0x234CA70", Length = "0x10D")]
	[Token(Token = "0x600073D")]
	internal bool IsPlainString() { }

	[Address(RVA = "0x234D780", Offset = "0x234CB80", Length = "0x85A")]
	[Token(Token = "0x600073C")]
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	[Address(RVA = "0x234DFE0", Offset = "0x234D3E0", Length = "0x64")]
	[Token(Token = "0x6000747")]
	internal string QualifiedName(string name) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6000744")]
	internal void set_MaxLength(int value) { }

	[Address(RVA = "0x234E050", Offset = "0x234D450", Length = "0x3E")]
	[Token(Token = "0x600073B")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x234E090", Offset = "0x234D490", Length = "0x564")]
	[Token(Token = "0x6000748")]
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

}

