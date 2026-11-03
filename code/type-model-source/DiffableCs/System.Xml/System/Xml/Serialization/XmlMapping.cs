namespace System.Xml.Serialization;

[Token(Token = "0x2000114")]
public abstract class XmlMapping
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000636")]
	private ObjectMap map; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000637")]
	private ArrayList relatedMaps; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000638")]
	private SerializationFormat format; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000639")]
	private SerializationSource source; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400063A")]
	internal string _elementName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400063B")]
	internal string _namespace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400063C")]
	private string key; //Field offset: 0x40

	[Token(Token = "0x17000344")]
	public string ElementName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000C8E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000348")]
	internal SerializationFormat Format
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C95")]
		internal get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000C96")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000345")]
	public string Namespace
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000346")]
	internal ObjectMap ObjectMap
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C91")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000C92")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000347")]
	internal ArrayList RelatedMaps
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C93")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000C94")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000349")]
	internal SerializationSource Source
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000C97")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x25630C0", Offset = "0x25624C0", Length = "0x4E")]
	[Token(Token = "0x6000C8D")]
	internal XmlMapping(string elementName, string ns) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000C8E")]
	public string get_ElementName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C95")]
	internal SerializationFormat get_Format() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C8F")]
	public string get_Namespace() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C91")]
	internal ObjectMap get_ObjectMap() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C93")]
	internal ArrayList get_RelatedMaps() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000C97")]
	internal SerializationSource get_Source() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000C96")]
	internal void set_Format(SerializationFormat value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000C92")]
	internal void set_ObjectMap(ObjectMap value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000C94")]
	internal void set_RelatedMaps(ArrayList value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000C90")]
	public void SetKey(string key) { }

}

