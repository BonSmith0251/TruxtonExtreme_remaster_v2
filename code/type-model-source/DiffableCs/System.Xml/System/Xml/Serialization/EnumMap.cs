namespace System.Xml.Serialization;

[Token(Token = "0x2000145")]
internal class EnumMap : ObjectMap
{
	[Token(Token = "0x2000146")]
	internal class EnumMapMember
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006F1")]
		private readonly string _xmlName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006F2")]
		private readonly string _enumName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006F3")]
		private readonly long _value; //Field offset: 0x20

		[Token(Token = "0x170003AD")]
		public string EnumName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000E4A")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170003AE")]
		public long Value
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000E4B")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170003AC")]
		public string XmlName
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000E49")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x21BDD60", Offset = "0x21BD160", Length = "0x60")]
		[Token(Token = "0x6000E48")]
		public EnumMapMember(string xmlName, string enumName, long value) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000E4A")]
		public string get_EnumName() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000E4B")]
		public long get_Value() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E49")]
		public string get_XmlName() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EC")]
	private readonly EnumMapMember[] _members; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006ED")]
	private readonly bool _isFlags; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006EE")]
	private readonly String[] _enumNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006EF")]
	private readonly String[] _xmlNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006F0")]
	private readonly Int64[] _values; //Field offset: 0x30

	[Token(Token = "0x170003A9")]
	public String[] EnumNames
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000E43")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003A8")]
	public bool IsFlags
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000E42")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003AB")]
	public Int64[] Values
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000E45")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003AA")]
	public String[] XmlNames
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000E44")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2582F40", Offset = "0x2582340", Length = "0x1CC")]
	[Token(Token = "0x6000E41")]
	public EnumMap(EnumMapMember[] members, bool isFlags) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000E43")]
	public String[] get_EnumNames() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000E42")]
	public bool get_IsFlags() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000E45")]
	public Int64[] get_Values() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000E44")]
	public String[] get_XmlNames() { }

	[Address(RVA = "0x25828C0", Offset = "0x2581CC0", Length = "0x2E8")]
	[Token(Token = "0x6000E47")]
	public string GetEnumName(string typeName, string xmlName) { }

	[Address(RVA = "0x2582BB0", Offset = "0x2581FB0", Length = "0x38D")]
	[Token(Token = "0x6000E46")]
	public string GetXmlName(string typeName, object enumValue) { }

}

