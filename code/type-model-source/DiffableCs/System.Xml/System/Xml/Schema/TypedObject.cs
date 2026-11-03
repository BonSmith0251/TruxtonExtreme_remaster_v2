namespace System.Xml.Schema;

[Token(Token = "0x200015A")]
internal class TypedObject
{
	[Token(Token = "0x200015B")]
	private class DecimalStruct
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400074A")]
		private bool isDecimal; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400074B")]
		private Decimal[] dvalue; //Field offset: 0x18

		[Token(Token = "0x170003DE")]
		public Decimal[] Dvalue
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000EE5")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170003DD")]
		public bool IsDecimal
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[Token(Token = "0x6000EE3")]
			 get { } //Length: 5
			[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
			[Token(Token = "0x6000EE4")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x2582010", Offset = "0x2581410", Length = "0x55")]
		[Token(Token = "0x6000EE6")]
		public DecimalStruct() { }

		[Address(RVA = "0x2581FB0", Offset = "0x25813B0", Length = "0x5D")]
		[Token(Token = "0x6000EE7")]
		public DecimalStruct(int dim) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000EE5")]
		public Decimal[] get_Dvalue() { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000EE3")]
		public bool get_IsDecimal() { }

		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x6000EE4")]
		public void set_IsDecimal(bool value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000744")]
	private DecimalStruct dstruct; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000745")]
	private object ovalue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000746")]
	private string svalue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000747")]
	private XmlSchemaDatatype xsdtype; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000748")]
	private int dim; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000749")]
	private bool isList; //Field offset: 0x34

	[Token(Token = "0x170003D7")]
	public int Dim
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000ED8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003DA")]
	public Decimal[] Dvalue
	{
		[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
		[Token(Token = "0x6000EDB")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170003D9")]
	public bool IsDecimal
	{
		[Address(RVA = "0x258B880", Offset = "0x258AC80", Length = "0x1B")]
		[Token(Token = "0x6000EDA")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170003D8")]
	public bool IsList
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x6000ED9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003DC")]
	public XmlSchemaDatatype Type
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000EDD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003DB")]
	public object Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000EDC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x258B710", Offset = "0x258AB10", Length = "0x164")]
	[Token(Token = "0x6000EDE")]
	public TypedObject(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	[Address(RVA = "0x258AFC0", Offset = "0x258A3C0", Length = "0x387")]
	[Token(Token = "0x6000EE2")]
	public bool Equals(TypedObject other) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000ED8")]
	public int get_Dim() { }

	[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
	[Token(Token = "0x6000EDB")]
	public Decimal[] get_Dvalue() { }

	[Address(RVA = "0x258B880", Offset = "0x258AC80", Length = "0x1B")]
	[Token(Token = "0x6000EDA")]
	public bool get_IsDecimal() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x6000ED9")]
	public bool get_IsList() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000EDD")]
	public XmlSchemaDatatype get_Type() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000EDC")]
	public object get_Value() { }

	[Address(RVA = "0x258B350", Offset = "0x258A750", Length = "0x118")]
	[Token(Token = "0x6000EE1")]
	private bool ListDValueEquals(TypedObject other) { }

	[Address(RVA = "0x258B470", Offset = "0x258A870", Length = "0x298")]
	[Token(Token = "0x6000EE0")]
	public void SetDecimal() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000EDF")]
	public virtual string ToString() { }

}

