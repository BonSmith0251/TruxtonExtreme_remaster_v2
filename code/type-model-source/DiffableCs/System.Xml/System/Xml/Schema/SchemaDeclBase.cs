namespace System.Xml.Schema;

[Token(Token = "0x20001D8")]
internal abstract class SchemaDeclBase
{
	[Token(Token = "0x20001D9")]
	public enum Use : int
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008DE")]
	protected XmlQualifiedName name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008DF")]
	protected string prefix; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008E0")]
	protected bool isDeclaredInExternal; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008E1")]
	protected Use presence; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008E2")]
	protected XmlSchemaType schemaType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008E3")]
	protected XmlSchemaDatatype datatype; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008E4")]
	protected string defaultValueRaw; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008E5")]
	protected object defaultValueTyped; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008E6")]
	protected long maxLength; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008E7")]
	protected long minLength; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008E8")]
	protected List<String> values; //Field offset: 0x58

	[Token(Token = "0x170004F6")]
	internal XmlSchemaDatatype Datatype
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600129D")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600129E")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F8")]
	internal string DefaultValueRaw
	{
		[Address(RVA = "0x246F780", Offset = "0x246EB80", Length = "0x1E")]
		[Token(Token = "0x60012A2")]
		internal get { } //Length: 30
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60012A3")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F9")]
	internal object DefaultValueTyped
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60012A4")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60012A5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F1")]
	internal bool IsDeclaredInExternal
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001293")]
		internal get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6001294")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004F3")]
	internal long MaxLength
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001297")]
		internal get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[Token(Token = "0x6001298")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x170004F4")]
	internal long MinLength
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001299")]
		internal get { } //Length: 5
		[Address(RVA = "0x246F7C0", Offset = "0x246EBC0", Length = "0x5")]
		[Token(Token = "0x600129A")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x170004EF")]
	internal XmlQualifiedName Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600128F")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6001290")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F0")]
	internal string Prefix
	{
		[Address(RVA = "0x246F7A0", Offset = "0x246EBA0", Length = "0x1E")]
		[Token(Token = "0x6001291")]
		internal get { } //Length: 30
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001292")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F2")]
	internal Use Presence
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6001295")]
		internal get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6001296")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004F5")]
	internal XmlSchemaType SchemaType
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600129B")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600129C")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004F7")]
	internal List<String> Values
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60012A0")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60012A1")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x246F650", Offset = "0x246EA50", Length = "0xB5")]
	[Token(Token = "0x600128D")]
	protected SchemaDeclBase(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x246F710", Offset = "0x246EB10", Length = "0x6B")]
	[Token(Token = "0x600128E")]
	protected SchemaDeclBase() { }

	[Address(RVA = "0x246F420", Offset = "0x246E820", Length = "0xFC")]
	[Token(Token = "0x600129F")]
	internal void AddValue(string value) { }

	[Address(RVA = "0x246F520", Offset = "0x246E920", Length = "0xC4")]
	[Token(Token = "0x60012A6")]
	internal bool CheckEnumeration(object pVal) { }

	[Address(RVA = "0x246F5F0", Offset = "0x246E9F0", Length = "0x52")]
	[Token(Token = "0x60012A7")]
	internal bool CheckValue(object pVal) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600129D")]
	internal XmlSchemaDatatype get_Datatype() { }

	[Address(RVA = "0x246F780", Offset = "0x246EB80", Length = "0x1E")]
	[Token(Token = "0x60012A2")]
	internal string get_DefaultValueRaw() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60012A4")]
	internal object get_DefaultValueTyped() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001293")]
	internal bool get_IsDeclaredInExternal() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001297")]
	internal long get_MaxLength() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001299")]
	internal long get_MinLength() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600128F")]
	internal XmlQualifiedName get_Name() { }

	[Address(RVA = "0x246F7A0", Offset = "0x246EBA0", Length = "0x1E")]
	[Token(Token = "0x6001291")]
	internal string get_Prefix() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6001295")]
	internal Use get_Presence() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600129B")]
	internal XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60012A0")]
	internal List<String> get_Values() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600129E")]
	internal void set_Datatype(XmlSchemaDatatype value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60012A3")]
	internal void set_DefaultValueRaw(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60012A5")]
	internal void set_DefaultValueTyped(object value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6001294")]
	internal void set_IsDeclaredInExternal(bool value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[Token(Token = "0x6001298")]
	internal void set_MaxLength(long value) { }

	[Address(RVA = "0x246F7C0", Offset = "0x246EBC0", Length = "0x5")]
	[Token(Token = "0x600129A")]
	internal void set_MinLength(long value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6001290")]
	internal void set_Name(XmlQualifiedName value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001292")]
	internal void set_Prefix(string value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6001296")]
	internal void set_Presence(Use value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600129C")]
	internal void set_SchemaType(XmlSchemaType value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60012A1")]
	internal void set_Values(List<String> value) { }

}

