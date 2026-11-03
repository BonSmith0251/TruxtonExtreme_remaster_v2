namespace System.Xml.Serialization;

[Token(Token = "0x2000138")]
internal class XmlTypeMapMember
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006BA")]
	private string _name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006BB")]
	private int _index; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006BC")]
	private int _globalIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006BD")]
	private int _specifiedGlobalIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006BE")]
	private TypeData _typeData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006BF")]
	private MemberInfo _member; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006C0")]
	private MemberInfo _specifiedMember; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006C1")]
	private MethodInfo _shouldSerialize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006C2")]
	private object _defaultValue; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006C3")]
	private int _flags; //Field offset: 0x50

	[Token(Token = "0x1700037D")]
	public object DefaultValue
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000DD9")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000DDA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000380")]
	public int GlobalIndex
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000DE5")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000DE6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700037F")]
	public int Index
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000DE3")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000DE4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000381")]
	public bool IsOptionalValueType
	{
		[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
		[Token(Token = "0x6000DE7")]
		 get { } //Length: 7
		[Address(RVA = "0x2593ED0", Offset = "0x25932D0", Length = "0x2B")]
		[Token(Token = "0x6000DE8")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000382")]
	public bool IsReturnValue
	{
		[Address(RVA = "0x1F0D320", Offset = "0x1F0C720", Length = "0x8")]
		[Token(Token = "0x6000DE9")]
		 get { } //Length: 8
		[Address(RVA = "0x2593F00", Offset = "0x2593300", Length = "0x2B")]
		[Token(Token = "0x6000DEA")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700037C")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000DD7")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000DD8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700037E")]
	public TypeData TypeData
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000DE1")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000DE2")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2593E50", Offset = "0x2593250", Length = "0x72")]
	[Token(Token = "0x6000DD6")]
	public XmlTypeMapMember() { }

	[Address(RVA = "0x2592DB0", Offset = "0x25921B0", Length = "0x78")]
	[Token(Token = "0x6000DEB")]
	public void CheckOptionalValueType(Type type) { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000DD9")]
	public object get_DefaultValue() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000DE5")]
	public int get_GlobalIndex() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000DE3")]
	public int get_Index() { }

	[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
	[Token(Token = "0x6000DE7")]
	public bool get_IsOptionalValueType() { }

	[Address(RVA = "0x1F0D320", Offset = "0x1F0C720", Length = "0x8")]
	[Token(Token = "0x6000DE9")]
	public bool get_IsReturnValue() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000DD7")]
	public string get_Name() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000DE1")]
	public TypeData get_TypeData() { }

	[Address(RVA = "0x2593110", Offset = "0x2592510", Length = "0x16F")]
	[Token(Token = "0x6000DDD")]
	public object GetValue(object ob) { }

	[Address(RVA = "0x2593280", Offset = "0x2592680", Length = "0x194")]
	[Token(Token = "0x6000DDC")]
	public static object GetValue(object ob, string name) { }

	[Address(RVA = "0x2592E30", Offset = "0x2592230", Length = "0x2DB")]
	[Token(Token = "0x6000DEC")]
	public bool GetValueSpecified(object ob) { }

	[Address(RVA = "0x2593420", Offset = "0x2592820", Length = "0x2A9")]
	[Token(Token = "0x6000DE0")]
	private void InitMember(Type type) { }

	[Address(RVA = "0x25936D0", Offset = "0x2592AD0", Length = "0xDE")]
	[Token(Token = "0x6000DDB")]
	public bool IsReadOnly(Type type) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000DDA")]
	public void set_DefaultValue(object value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000DE6")]
	public void set_GlobalIndex(int value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000DE4")]
	public void set_Index(int value) { }

	[Address(RVA = "0x2593ED0", Offset = "0x25932D0", Length = "0x2B")]
	[Token(Token = "0x6000DE8")]
	public void set_IsOptionalValueType(bool value) { }

	[Address(RVA = "0x2593F00", Offset = "0x2593300", Length = "0x2B")]
	[Token(Token = "0x6000DEA")]
	public void set_IsReturnValue(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000DD8")]
	public void set_Name(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000DE2")]
	public void set_TypeData(TypeData value) { }

	[Address(RVA = "0x2593C90", Offset = "0x2593090", Length = "0x1B3")]
	[Token(Token = "0x6000DDF")]
	public static void SetValue(object ob, string name, object value) { }

	[Address(RVA = "0x2593AF0", Offset = "0x2592EF0", Length = "0x192")]
	[Token(Token = "0x6000DDE")]
	public void SetValue(object ob, object value) { }

	[Address(RVA = "0x25937B0", Offset = "0x2592BB0", Length = "0x33F")]
	[Token(Token = "0x6000DED")]
	public void SetValueSpecified(object ob, bool value) { }

}

